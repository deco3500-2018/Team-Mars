<?php

$dbServername = "127.0.0.1";
$dbUsername = "root";
$dbPassword = "wsadghjvbn";
$dbName = "unitytest";

$conn = mysqli_connect($dbServername, $dbUsername, $dbPassword, $dbName);

if (!$conn) {
	echo "Failed to connect to MySQL: " . mysqli_connect_error();
    header("Location: ../index.php?login=dn_access_error");
}

$sql = "SElECT * FROM posttest";
$result = mysqli_query($conn, $sql);
$resultCheck = mysqli_num_rows($result);
        
if($resultCheck < 1){
    exit();

} else {
    $rows = array();
    while ($row = mysqli_fetch_assoc($result)) {
        array_push($rows, $row);
    }
    
    for ($i = 0; $i < sizeof($rows); $i++){
        $date = new DateTime($rows[$i]['Date']);
        echo $rows[$i]['Content'] . ":" . date_format($date, 'M-d') . "|";
    }
}
