<?php 
        $host ="localhost";
        $username ="deshalom_me";
        $password = "Epicpie99";
        $dbName = "deshalom_data";
        
        $conn = mysqli_connect($host, $username, $password, $dbName);
        
        if(mysqli_connect_errno())
        {
            echo "1";
            exit();
        }
        
        $name = $_POST["name"];
        
        $insertuserquery = "SELECT score FROM scores WHERE name='$name';";
        $result = mysqli_query($conn, $insertuserquery) or die("Query dead");
        while ($row = mysqli_fetch_array($result)) {
        echo $row['score'];
    }
?>