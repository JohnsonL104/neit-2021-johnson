<?php
    include 'dbc.php';

    $name = $_POST['name'];
    $result = mysqli_query($conn, "SELECT playlistID FROM Playlists ORDER BY playlistID DESC");
    $playlistID = intval(mysqli_fetch_assoc($result)['playlistID'])+1;
    mysqli_query($conn, "INSERT INTO Playlists (playlistID, name) VALUES (".$playlistID.", '".$name."')");
?>