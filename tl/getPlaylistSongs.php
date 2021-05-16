<?php
    include 'dbc.php';

    $playlistID = $_POST['playlistID'];

    $result = mysqli_query($conn, "SELECT songID FROM PlaylistSongs WHERE playlistID = ". $playlistID. " ORDER BY songID");
    if(mysqli_num_rows($result) > 0){
        while($row = mysqli_fetch_assoc($result)){
            $result2 = mysqli_fetch_assoc(mysqli_query($conn, "SELECT url FROM Songs WHERE songID = ".$row['songID']));
            echo $result2['url'].",";
        }
    }
?>