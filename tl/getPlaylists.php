<?php
    include 'dbc.php';

    $userID = $_POST['userID'];

    $result = mysqli_query($conn, "SELECT playlistID, name FROM Playlists WHERE userID = ". $userID);
    if(mysqli_num_rows($result) > 0){
        while($row = mysqli_fetch_assoc($result)){
            echo $row['playlistID'].",".$row['name'].",";
        }
    }
?>