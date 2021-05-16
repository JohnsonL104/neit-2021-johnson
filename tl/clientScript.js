
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




$(document).ready(function() {
    initPlayer()
    var started = false;
    var dataArray;
    var sessionID = -1;
    var currentTrackTime;
    var status;
    var ogVideoID
    var videoID;
    var player;
    function onPlayerReady(event) {
        event.target.playVideo();
        event.target.seekTo(currentTrackTime);
      }
    
    
    $("#start").click(function(){
        sessionID = parseInt($("#sessionID").val())
        started = true 
        $.post('getsession.php', {
            sessionID: sessionID
        }, function(data){
            
            dataArray = data.split(",")
            currentTrackTime = dataArray[0]
            status = dataArray[1]
            videoID = dataArray[2]
            ogVideoID = videoID
            player = new YT.Player('player', {
                height: '390',
                width: '640',
                videoId: videoID,
                events: {
                    'onReady': onPlayerReady
                }
              });
        })
    })

    function loop(){
        if(started){
            $.post('getsession.php', {
                sessionID: sessionID
            }, function(data){
                
                dataArray = data.split(",")
                currentTrackTime = dataArray[0]
                status = dataArray[1]
                videoID = dataArray[2]

                if(status === 'started'){
                    if(player.getPlayerState() == 2){
                        player.playVideo()
                    }
                    $('#timer').html(currentTrackTime)
                }else if(status === 'paused'){
                    if(player.getPlayerState() == 1){
                        player.pauseVideo()
                    }
                }
                if(Math.abs(Math.floor(player.getCurrentTime()) - currentTrackTime) > 1){
                    console.log(videoID)
                    console.log(ogVideoID)
                    if(videoID === ogVideoID){
                        player.seekTo(currentTrackTime)
                    }else{
                        player.loadVideoById(videoID)
                        player.seekTo(currentTrackTime)
                        ogVideoID = videoID
                    }
                }
            })


        }

        
        
    }setInterval(loop, 500)
    
})