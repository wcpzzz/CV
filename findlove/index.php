<?php   
    include_once 'header.php';
?>

<section class="main-container">

    <?php
            if(!isset($_SESSION['session_phone'])){

                
                echo '  <div class="main-wrapper">
                        <div class="sgolan">朋友以上恋人未满的复杂情感<br>
                                            如何比朋友更进一步<br>
                                            没有勇气跨出“那一步”？<br>
                                            害怕捅破窗户纸后的尴尬？<br>
                                            谁说表白后再难做朋友<br>
                                            科学表白避免尴尬！！



                        </div>
                        </div>
                        <a class="goto" href="signup.php">》即刻表白《</a>';


            }
            else{
                header("Location:home.php");
            }

        ?>
</section>
<?php   
    include_once 'footer.php';
?>