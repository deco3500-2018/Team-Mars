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

$newWord = $_POST["newWord"];
$sql = "INSERT INTO posttest (Content) VALUES ('$newWord')";
$result = mysqli_query($conn, $sql);
$resultCheck = mysqli_num_rows($result);
