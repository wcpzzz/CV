<?php 
include_once 'header.php';
include "includes/state.inc.php";




if ($results[0]!=null) {
    echo "<h1>太棒了！她也喜欢你！！！！！！！</h1>";
} else {
    echo "<h1>Ta暂时还没使用这个软件，再等等吧。</h1>";
}
?>