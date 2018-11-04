<?php

session_start();

?>
<!DOCTYPE html>
<html>

<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
    <title>TEST</title>
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    <link rel="stylesheet" type="text/css" href="style.css" />
</head>

<body>

    <header>
        <nav>
            <div class="main-wrapper">
                <ul>
                    <li><a href="index.php">主页</a></li>
                </ul>
                <div class="nav-login">
                    <?php
                        if (isset($_SESSION['session_phone'])) {
                            echo '  <form action="includes/logout.inc.php" method="POST">
                                    <button type="submit" name="submit">退出</button>
                                    </form>';

                            # code...
                        }
                        else {
                            echo '  <form action="includes/login.inc.php" method="POST">
                                        <input type="text" name=phone placeholder="手机号/e-mail">
                                        <input type="password" name=pwd placeholder="密码">
                                        <button ytpe="submit" name="submit">登陆</button>
                                    </form>
                                    ';
                        }

                    ?>


                </div>
            </div>
        </nav>
    </header>