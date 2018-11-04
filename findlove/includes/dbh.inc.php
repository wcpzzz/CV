<?php

$dbServername = "localhost";
$dbUsername = "root";
$dbPassword = "mashuai110";
$dbName = "login_test";

$conn = mysqli_connect($dbServername, $dbUsername, $dbPassword, $dbName);

/* try {
    $pdo = new PDO("mysql:host=localhost;dbname=login_test;","root","mashuai110");
} 
catch (PDOException $e) 
{
    die("数据库连接失败" . $e->getMessage());
} */
try {
    $pdo = new PDO("mysql:host=localhost;dbname=login_test;", "root", "mashuai110");
} catch (PDOException $e) {
    die("数据库连接失败" . $e->getMessage());
}