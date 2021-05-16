<?php
    include 'dbc.php';

    $sessionID = $_POST['sessionID'];
    $status = $_POST['status'];

    mysqli_query($conn,  "UPDATE Sessions SET status = '". $status ."' WHERE sessionID = ". $sessionID);
?>