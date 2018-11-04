<?php   
    include_once 'header.php';
?>

    <section class="main-container">
        <div class="main-wrapper">
            <h2>注册</h2>
            <form class="signup-form" action="includes/signup.inc.php" method="POST">
                <input type="text" name="name" placeholder="姓名">
                <input type="text" name="email" placeholder="E-mail">
                <input type="password" name="pwd" placeholder="密码">
                <input type="text" name="qq" placeholder="QQ号">
                <input type="text" name="phone" placeholder="手机号">
                <button type="submit" name ="submit">注册</button>
                
            </form>
        </div>
    </section>
<?php   
    include_once 'footer.php';
?>