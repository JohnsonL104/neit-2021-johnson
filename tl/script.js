
var seconds 
var lastVideoID
var videoID 
var player
var playlists = [];
var currentPlaylistIndex = 0
var currentPlaylistSongs = [];
var sessionID = -1
var started = false

function playerStateChange(event){
    if(event.data === 2){
        pauseVideo()
    }else if(event.data === 1){
        resumeVideo()
    }else if(event.data === 0){
        if(currentPlaylistIndex != currentPlaylistSongs.length){
            currentPlaylistIndex++
            playVideo(currentPlaylistSongs[currentPlaylistIndex])
        }
    }
}

function startSession(){
    $.post("startSession.php", function(data) {
        sessionID = parseInt(data)
        started = true
        $("#sessionID").html(`<p>SessionID ${data}</p>`)
    })
}
function playVideo(newVideoID){
    if(sessionID != -1){
        videoID = newVideoID
        player.loadVideoById(videoID)
        
        lastVideoID = videoID
        player.seekTo(0)
        setTimeout(resumeVideo, 200)
    }else{
        alert("You need to start a session")
    }
        
    }
function resumeVideo(){
    player.playVideo()
    $.post("pauseSession.php", {
        sessionID: sessionID,
        status: 'started'
    })
    started = true
}
function pauseVideo(){
    player.pauseVideo()
    $.post("pauseSession.php", {
        sessionID: sessionID,
        status: 'paused'
    })
    started = false
}

function showPlaylistSongs(playlistID){
    var html
    $.post("getPlaylistSongsWithNames.php", {
    playlistID: playlistID
    }, function(data){
        dataArray = data.split(",")
        dataArray.pop()
        if(dataArray.length != 0){
            html = '<tr><td><button onClick = "populatePlaylists()">Back</button></td><td><button onClick="playPlaylist('+playlistID+')">Play Playlist</button></td></tr>';
            //-------------IMPORTANT: MAKE SURE TO CHECK IF DATA ARRAY HAS UNDEFINED WHEN ACTUALLY IMPLEMENTING USERS

            //This temp array is so that when i am iterating by two i can still tell the button the proper index of the song it is trying to play so basicially the temp array will take to index of the for loop but will be the correct lenght and then just get index of the i that is not the right length and i did a horrible job of explaining this good luck i hope you don't forget why you did this or maybe i did do a good enough job of explaining but probably not becuase i am actually a horrid programmer and this is probably the worst possible solution and there is probably some simple equation you can do to figure it out but i am dumb so i just did this because my smooth dumb fucking brain can figure this out easier than doing a simple math equation becuase i am actually fucking dumb as fuck but anyway you are probably having some trouble right now like i am currently and i just wanted to tell you that you will eventually figure it out, you always do and i know that this message isn't helping but good luck gamer i hope you get it.
            var tempArray = []
            for(var i = 0; i < dataArray.length; i= i+2){
                tempArray.push(i)
                // console.log(listItem)
                console.log(i)
                html = html +  '<tr><td><button onClick = "playPlaylistFromSong('+playlistID+', '+tempArray.indexOf(i)+')">'+dataArray[i+1]+'</button></td></tr>'

                        $("#playlistTable").html(html)
                
            }
        }else{
            alert("Yo bitch you gotta put a song in that ho")
        }
                    
                
    })
    for(var i = 0; i < playlists.length; i++){
        if(i === playlistID){
            $("#playlistHeader").html(playlists[i-1][1])
        }
    }
        
          
     
}
function makeButton(){
    
}
function populatePlaylists(){
    playlists = []
    $.post("getPlaylists.php", {
        userID: 0
    }, function(data){
         dataArray = data.split(",")
         var html = '';
        //-------------IMPORTANT: MAKE SURE TO CHECK IF DATA ARRAY HAS UNDEFINED WHEN ACTUALLY IMPLEMENTING USERS
         for(var i =0; i < dataArray.length-2; i +=2){
            playlists.push([dataArray[i], dataArray[i+1]])
            html += '<tr><td><button onClick = "showPlaylistSongs('+dataArray[i]+')">' + dataArray[i+1] + '</button></td><td><button onClick="playPlaylist('+dataArray[i]+')">Play Playlist</button></td></tr>'
             
         }
         $("#playlistHeader").html("Playlists")
         $("#playlistTable").html(html)
    }) 
 }
function playPlaylist(playlistIndex){
    $.post("getPlaylistSongs.php", {
        playlistID: playlistIndex
    }, function(data){
        currentPlaylistSongs = data.split(",")
        currentPlaylistSongs.pop()
        currentPlaylistIndex = 0
        playVideo(currentPlaylistSongs[currentPlaylistIndex])
    })
}
function playPlaylistFromSong(playlistIndex, songIndex){
    $.post("getPlaylistSongs.php", {
        playlistID: playlistIndex
    }, function(data){
        currentPlaylistSongs = data.split(",")
        currentPlaylistSongs.pop()
        currentPlaylistIndex = songIndex
        playVideo(currentPlaylistSongs[currentPlaylistIndex])
    })
}
function initPlayer(){
    var tag = document.createElement('script');

    tag.src = "https://www.youtube.com/iframe_api";
    var firstScriptTag = document.getElementsByTagName('script')[0];
    firstScriptTag.parentNode.insertBefore(tag, firstScriptTag);
}

function youtube_parser(url){
    var regExp = /^.*((youtu.be\/)|(v\/)|(\/u\/\w\/)|(embed\/)|(watch\?))\??v?=?([^#\&\?]*).*/;
    var match = url.match(regExp);
    return (match&&match[7].length==11)? match[7] : false;
}

function onPlayerReady(event) {
    event.target.playVideo();
    event.target.seekTo(0);
    
  }
function onYouTubeIframeAPIReady(){
    player = new YT.Player('player', {
        height: '390',
        width: '640',
        events: {
            'onReady': onPlayerReady,
            'onStateChange': playerStateChange
        }
    });
}
$("#startButton").click(function(){
    startSession()
})
$("#playNow").click(function(){
    playVideo(youtube_parser($("#url").val()))
})
$("#newPlaylist").click(function(){
    var name = prompt("Enter Playlist Name")
    if(name != null){
        var dup = false;
        for(var i = 0; i < playlists.length; i ++){
            if(name === playlists[i][1]){
                dup = true;
            }
        }
        if(dup){
            alert("There is already a playlist with this name, Try again.")
        }else{
            $.post("newPlaylist.php", {
                name: name
            })
            populatePlaylists()
        }
    }
})
$("#pause").click(function(){
    if(started){
        pauseVideo()
        ("#pause").text("Pause")
    }else{
        resumeVideo()
        ("#pause").text("Play")
    }
})
$("#addToPlaylistButton").click(function(){
    var playlistToAdd = prompt("Which Playlist Would you like to add this song to")
    var playlistIDFound
    var songFound = false;
    for(var i = 0; i < playlists.length; i++){
        if(playlists[i][1] === playlistToAdd){
            playlistIDFound = playlists[i][0]
            $.post("getPlaylistSongs.php", {
                playlistID: playlistIDFound
            }, function(data){
                console.log(data)
                var songIDs = data.split(",")
                songIDs.pop()
                console.log(songIDs)
                for(var y = 0; y < songIDs.length; y++){
                    console.log("cool")
                    if(songIDs[y] === youtube_parser($("#url").val())){
                        songFound = true
                    }
                }
                if(songFound){
                    alert("This song has alreay been added to this playlist try again")
                }else{
                    var tempVidID = youtube_parser($("#url").val())
                    var tempVidName
                    $.get("https://www.googleapis.com/youtube/v3/videos?part=snippet&id=" + tempVidID + "&key=AIzaSyD3_gLYz7qzWeTobogU0D9FnCWRO5wDUcI", function(data) {
                        if(typeof data.items[0]!= 'undefined'){
                            
                            tempVidName = data.items[0].snippet.title
                            $.post("addToPlaylist.php", {
                                videoID: tempVidID,
                                playlistID: playlistIDFound,
                                videoName: tempVidName
                            }, function(data){
                                console.log(data)
                            })
                        }  
                    });
                    
                }
            })
            
        }
    }
})

$(document).ready(function(){
    
    initPlayer()
    // GETTING PLAYLISTS
    populatePlaylists()
    function loop(){
        if(sessionID != -1){
            seconds = Math.floor(player.getCurrentTime())
            $.post("updateSession.php", {
                sessionID: sessionID,
                time: `${seconds}`,
                videoID: videoID
            })      
        }
    }setInterval(loop, 1000)
    
    


    
})