<!-- 
    open new terminal
    type: "php -S localhost:4000"
    go to "localhost:4000"
-->

<?php
    include 'dbc.php';
?>
<!DOCTYPE html>
<html lang="en">
        <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
        <title>Host</title>
    </head>
    <body>
        <h1>Host</h1>
        <button id = "startButton">Start</button>
        <div id = "leftPanel">
            <div id = "player"></div>
            <button id = "pause">Pause</button>
        </div>

        <div id = "rightPanel">
            <input id = "url" type = "text" placeholder="Youtube URL">
            <button id = "addToPlaylistButton">Add to playlist</button>
            <button id = "playNow">Play Now</button>
            <h2 id = "playlistHeader">Playlists</h2>
            <button id = "newPlaylist">New Playlist</button>
            <table id = "playlistTable">
            </table>

        </div>
        
        
        
        


        
        
        
        <p id = "sessionID"></p>
        <p id = "time"></p>
    </body>
    <script type="text/javascript" src="script.js"></script>
</html>