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
        $score = $_POST["score"];
        
        echo($name);
        echo($score);
        
        $insertuserquery = "INSERT INTO `scores` (`name`, `score`) VALUES ('$name', '$score');";
        mysqli_query($conn, $insertuserquery) or die("Query dead");
        
        echo("0");
?>