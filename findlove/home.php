<?php 
include_once 'header.php';
if (!isset($_SESSION['session_phone'])) {
    header("Location:index.php");
        # code...
}
?>

<section class="main-container">
    <div class="main-wrapper">




        <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal" data-whatever="@mdo">我要表白</button>


        <!-- 弹出div---------------------------------------------------------------------------------------------- -->
        <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel"
            aria-hidden="true">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLabel">你要想谁表白？</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <form action="includes/home.inc.php" method="POST">
                            <div class="form-group">
                                <label for="recipient-name" class="col-form-label">Ta的姓名:</label>
                                <input type="text" class="form-control" name="toname">
                            </div>
                            <div class="form-group">
                                <label for="message-text" class="col-form-label">Ta的电话:</label>
                                <input type="text" class="form-control" name="tophone">
                            </div>
                            <div class="form-group">
                                <label for="message-text" class="col-form-label">Message:</label>
                                <textarea class="form-control" id="message-text"></textarea>
                            </div>
                            <div class="modal-footer">
                                <button type="button" class="btn btn-secondary" data-dismiss="modal">取消</button>
                                <button type="submit" class="btn btn-primary" name="submit">向Ta表白！</button>
                            </div>
                        </form>
                    </div>

                </div>
            </div>
        </div>
        <!-- 弹出div -------------------------------------------------------------------------------------------------->





    </div>
</section>

<?php 
include_once 'footer.php';
?>