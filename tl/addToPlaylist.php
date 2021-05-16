<?php
    include 'dbc.php';

    $videoID = $_POST['videoID'];
    $playlistID =$_POST['playlistID'];
    $videoName = $_POST['videoName'];
    $checkForSong = mysqli_query($conn, "SELECT * FROM Songs WHERE url = '".$videoID."'");
    $songID;
    if(mysqli_num_rows($checkForSong) == 0){
        $highestSongID = mysqli_query($conn, "SELECT songID FROM Songs ORDER BY songID DESC");
        $songID = intval(mysqli_fetch_assoc($highestSongID)['songID'])+1;
        mysqli_query($conn, "INSERT INTO Songs (songID, url, name) VALUES (".$songID.", '".$videoID."', '".$videoName."')");
    }else{
        $songID = intval(mysqli_fetch_assoc($checkForSong)['songID']);
    }

    mysqli_query($conn, "INSERT INTO PlaylistSongs (songID, playlistID) VALUES (".$songID.",".$playlistID.")")

?>