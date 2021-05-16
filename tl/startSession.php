<?php
    include 'dbc.php';
    
    $result = mysqli_query($conn, "SELECT sessionID FROM Sessions ORDER BY sessionID DESC");
    
    $sessionID = intval(mysqli_fetch_assoc($result)['sessionID'])+1;
    $timezone = new DateTimeZone('GMT');
    $strdate = gmdate("Y-m-d H:i:sa");
    $date = DateTime::createFromFormat("Y-m-d H:i:sa", $strdate, $timezone);

    $date->add(new DateInterval('PT5S'));
    mysqli_query($conn, "INSERT INTO Sessions (sessionID, nextTrackTime, status) VALUES ($sessionID, '". $date->format('Y-m-d H:i:s') ."', 'started')");

    echo $sessionID

    

    // $sql = "SELECT * FROM Sessions WHERE status = '" . $status . "'";
    // $result = mysqli_query($conn, $sql);
    
    // if(mysqli_num_rows($result) > 0){
    //     while ($row = mysqli_fetch_assoc($result)){
    //         echo $row['status'];
    //     }
    // }
?>