<?php
    include 'dbc.php';

    $sessionID = $_POST['sessionID'];

    $result = mysqli_query($conn, "SELECT currentTrackTime, status, currentSongID FROM Sessions WHERE sessionID = ". $sessionID);
    if(mysqli_num_rows($result) > 0){
        while($row = mysqli_fetch_assoc($result)){
            echo $row['currentTrackTime'].",".$row['status'].",".$row['currentSongID'];
        }
    }
?>