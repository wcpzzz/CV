<?php 
include 'includes/dbh.inc.php';
$sql="SELECT JSON_SEARCH((SELECT user_professed FROM `users` WHERE user_phone='110'), 'all', '110');";

$statement = $pdo->query($sql);

$results = $statement->fetch(PDO::FETCH_BOTH);
print_r($results[0]);
if ($results[0]!=null) {
    echo "<h1>太棒了！她也喜欢你！！！！！！！</h1>";
} else {
    echo "<h1>Ta暂时还没使用这个软件，再等等吧。</h1>";
}
