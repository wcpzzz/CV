<?php

if (isset($_POST['submit'])) {

    include_once 'dbh.inc.php';

    $name = mysqli_real_escape_string($conn,$_POST['name']);
    $email = mysqli_real_escape_string($conn,$_POST['email']);
    $pwd = mysqli_real_escape_string($conn,$_POST['pwd']);
    $qq = mysqli_real_escape_string($conn,$_POST['qq']);
    $phone = mysqli_real_escape_string($conn,$_POST['phone']);

    //Error handLers
    //Check for empty fields
    if (empty($name)||empty($pwd)||empty($phone)) {
        header("Location: ../signup.php?signup=empty");
        exit();
    } else {
        //Chexk if input characters are valid
        if (preg_match("/^[0-9]*[1-9][0-9]*$/",$name)) {
            header("Location: ../signup.php?signup=invalname");
            exit();
        } else {
            $sql = "SELECT * FROM users WHERE user_phone='$phone'";
            $result = mysqli_query($conn,$sql);
            $resultCheck = mysqli_num_rows($result);

            if ($resultCheck>0){
                header("Location: ../signup.php?signup=phonetaken");
                exit();
            } else {
                //Hashing the password
                $hashedPwd=password_hash($pwd,PASSWORD_DEFAULT);
                //Insert the user into the database
                $sql = "INSERT INTO users (user_name,user_email,user_pwd,user_qq,user_phone,user_professed) VALUES ('$name','$email','$hashedPwd','$qq','$phone','{\"friends\": []}')";
                mysqli_query($conn,$sql);
                header("Location: ../signup.php?signup=success");
                exit();
            }
        }
    }

    # code...
} else {
    header("Location: ../index.php");
    exit();
}