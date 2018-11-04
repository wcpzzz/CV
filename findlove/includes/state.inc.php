<?php
include 'dbh.inc.php';


$tophone = $_SESSION['session_tophone'];

$user_phone=$_SESSION['session_phone'];

$sql="SELECT JSON_SEARCH((SELECT user_professed FROM `users` WHERE user_phone='".$tophone."'), 'all', '".$user_phone."');";

$statement = $pdo->query($sql);

$results = $statement->fetch(PDO::FETCH_BOTH);


if (!isset($_SESSION['session_phone'])) {
    header("Location:index.php");
        # code...
}
