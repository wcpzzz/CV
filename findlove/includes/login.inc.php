<?php

session_start();

if (isset($_POST['submit'])) {

    include 'dbh.inc.php';

    $phone=mysqli_real_escape_string($conn,$_POST['phone']);
    $pwd=mysqli_real_escape_string($conn,$_POST['pwd']);

    //Check 
    if (empty($phone)||empty($pwd)) {
        header("Location:../index.php?login=empty");
        exit();
    }  else {
        $sql = "SELECT * FROM users WHERE user_phone='$phone' OR user_email='$phone'";
        $result=mysqli_query($conn,$sql);
        $resultCheck=mysqli_num_rows($result);
        if ($resultCheck<1) {
            header("Location:../index.php?login=NoSuchPhone");
            exit();
            # code...
        } else {
            if ($row = mysqli_fetch_assoc($result)) {
                //De-hashing the password
                $hashedPwdCheck= password_verify($pwd,$row['user_pwd']);
                if ($hashedPwdCheck==false) {

                    header("Location:../index.php?login=pwderror");
                    exit();
                }elseif ($hashedPwdCheck==true) {
                    //Login the user here
                    $_SESSION['session_phone']=$row['user_phone'];
                    $_SESSION['session_name']=$row['user_name'];
                    header("Location:../index.php?login=success");
                    exit();

                }
            }
        }
    }
}else {
    header("Location:../index.php?login=error");
    exit();
}