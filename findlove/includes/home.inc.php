<?php
include 'dbh.inc.php';
session_start();

if (isset($_POST['submit'])) {

    
    $toname = $_POST['toname'];
    $tophone = $_POST['tophone'];
    $user_phone = $_SESSION['session_phone'];
    if (empty($toname) || empty($tophone)) {
        header("Location: ../home.php?empty");
        exit();
    } else {

        /* $sql = "set @var =JSON_ARRAY_INSERT((SELECT user_professed FROM `users` WHERE user_phone='".$user_phone."'), '$.friends[0]', '".$tophone."');UPDATE users SET user_professed = @var WHERE user_phone = '".$user_phone."';";
        mysqli_query($conn,$sql); */

        # SELECT JSON_SEARCH((SELECT user_professed FROM `users` WHERE user_phone='110'), 'all', 'cccc');

        $pdo->query("set @var =JSON_ARRAY_INSERT((SELECT user_professed FROM `users` WHERE user_phone='" . $user_phone . "'), '$.friends[0]', '" . $tophone . "');UPDATE users SET user_professed = @var WHERE user_phone = '" . $user_phone . "';");
        $_SESSION['session_tophone']=$tophone;
        header("Location:../state.php");
        exit();

    }
} else {
    header("Location:../home.php");
    exit();
}