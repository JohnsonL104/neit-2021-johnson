<?php
    include 'dbc.php';

    $sessionID = $_POST['sessionID'];
    $time = $_POST['time'];
    $videoID = $_POST['videoID'];
    mysqli_query($conn, "UPDATE Sessions SET currentTrackTime = '". $time ."', currentSongID = '". $videoID ."'  WHERE sessionID = ". $sessionID);

?>