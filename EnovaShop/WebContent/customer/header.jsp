<!DOCTYPE html>
<html>
<head>
	<title>Trang chủ</title>
	<meta charset="utf-8"/>
	<script type="text/javascript" src="js/jquery.js"></script>
	<script type="text/javascript" src="js/bootstrap.js"></script>
  <script type="text/javascript" src="js/common.js"></script>
	<link rel="stylesheet" type="text/css" href="css/bootstrap.css">
	
	<link rel="stylesheet" type="text/css" href="css/style.css">
	<script>(function(d, s, id) {
  var js, fjs = d.getElementsByTagName(s)[0];
  if (d.getElementById(id)) return;
  js = d.createElement(s); js.id = id;
  js.src = "//connect.facebook.net/vi_VN/all.js#xfbml=1&appId=514839858621781";
  fjs.parentNode.insertBefore(js, fjs);
}(document, 'script', 'facebook-jssdk'));</script>
</head>
<body>
<div id="fb-root"></div>
<div class="modal fade shopping_cart_modal">
  <div class="modal-dialog modal-lg">
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
        <h4 class="modal-title">Bạn có 2 sản phẩm trong giỏ hàng</h4>
      </div>
      <div class="modal-body">
        	<table class="table table-condensed table-striped table-bordered">
        		<tr class="table-heading">
        			<td width="55%">Tên sản phẩm</td>
        			<td width="15%" class="text-center">Giá</td>
        			<td width="10%" class="text-center">Số lượng</td>
        			<td width="15%" class="text-center">Tổng tiền</td>
        			<td width="5%" class="text-center"><b class="glyphicon glyphicon-cog"></b></td>
        		</tr>
        		<tr >
        			<td>
        			<div class="row">
        				<div class="col-md-2 img_item">
        					<img src="images/item_1.jpg" alt="The title" class="img-responsive">
        				</div>
        				<div class="col-md-10">
        					<h5 class="title">Lorem ipsum dolor sit amet, consectetur adipisicing elit</h5>
        				</div>
        				
        			</div>
        			</td>
        			<td class="price">
        				5,000,000 Đ 
        			</td>
        			<td class="quantity"><input type="number" class="form-control input-sm" value="1" name="quantity" min="1"></td>
        			<td class="total">
        				5,000,000 Đ
        			</td>
        			<td class="control"><a href="" ><b class="glyphicon glyphicon-trash"></b></a></td>
        		</tr>
        		<tr >
        			<td>
        			<div class="row">
        				<div class="col-md-2 img_item">
        					<img src="images/item_2.jpg" alt="The title" class="img-responsive">
        				</div>
        				<div class="col-md-10">
        					<h5 class="title">Lorem ipsum dolor sit amet, consectetur adipisicing elit</h5>
        				</div>
        				
        			</div>
        			</td>
        			<td class="price">
        				5,000,000 Đ 
        			</td>
        			<td class="quantity"><input type="number" class="form-control input-sm" value="1" name="quantity" min="1"></td>
        			<td class="total">
        				5,000,000 Đ
        			</td>
        			<td class="control"><a href="" ><b class="glyphicon glyphicon-trash"></b></a></td>
        		</tr>
        	</table>
          <div class="form-group">
              <div class="row">
                  <div class="col-md-7">
                  </div>
                  <div class="col-md-5 text-right">
                    <strong>Tổng cộng: 2,000,000 VND</strong><br>
                    <p class="help-block">Đã bao gồm VAT</p>
                  </div>                
              </div>
          </div>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-success">Cập nhật giỏ hàng</button>
        <a href="cart.html" class="btn btn-primary">Tiến hành thanh toán</a>
        <button type="button" class="btn btn-default" data-dismiss="modal">Tiếp tục mua hàng</button>
      </div>
    </div><!-- /.modal-content -->
  </div><!-- /.modal-dialog -->
</div><!-- /.modal shopping cart -->
<div class="modal fade login_modal">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
        <h4 class="modal-title">Đăng nhập</h4>
      </div>
      <div class="modal-body">
        	<form>
        		<div class="form-group">
        			<label><b class="glyphicon glyphicon-envelope"></b> Email</label>
        			<input type="email" name="login_email" id="login_email" class="form-control" placeholder="Địa chỉ email" required>
        		</div>
        		<div class="form-group">
        			<label><b class="glyphicon glyphicon-lock"></b> Password</label>
        			<input type="password" name="login_pw" id="login_pw" class="form-control" placeholder="Nhập password" required>
        		</div>
        		<div class="form-group">
        			<input type="checkbox" name="login_cookie" id="login_cookie"  > Lưu thông tin đăng nhập
        			<a href="#" class="pull-right register_btn" data-toggle="modal" data-target=".register_modal"><b class="glyphicon glyphicon-new-window"></b> Đăng ký tài khoản mới</a>
        		</div>
            <div class="form-group">
              <label>Đăng nhập nhanh</label> <br>
              <a href="#" class="btn btn-primary btn-register"> 
                 <img src="images/facebook-icon.png" alt="">
                  Đăng nhập bằng Facebook
              </a>
              <a href="#" class="btn btn-danger btn-register pull-right"> 
                <img src="images/gbt.png" alt="">
                  Đăng nhập bằng Google+
                </a>
            </div>
        	</form>
        
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-primary" id="login_btn">Đăng nhập</button>
        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
      </div>
    </div><!-- /.modal-content -->
  </div><!-- /.modal-dialog -->
</div><!-- /.modal Login -->
<div class="modal fade register_modal">
  <div class="modal-dialog modal-lg">
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
        <h4 class="modal-title"><i class="glyphicon glyphicon-new-window"></i> Đăng ký tài khoản</h4>
      </div>
      <div class="modal-body">
          <div class="row">
            <div class="col-md-7">
              	<form id="register">
              		<div class="form-group">
              			<label><b class="glyphicon glyphicon-user"></b> Họ và tên</label>
              			<input type="text" name="reg_name" id="reg_name" class="form-control" placeholder="Họ và tên" required> 
              		</div>
              		<div class="form-group">
              			<label><b class="glyphicon glyphicon-envelope"></b> Địa chỉ email</label>
              			<input type="email" name="reg_email" id="reg_email" class="form-control" placeholder="Địa chỉ email" required>
              		</div>
              		<div class="form-group">
              			<div class="col-md-6 non_pd_l">
              				<label><b class="glyphicon glyphicon-lock"></b> Nhập password</label>
              				<input type="password" name="reg_pw" id="reg_pw" class="form-control" placeholder="Nhập password" required>
              			</div>
              			<div class="col-md-6 non_pd_r">
      	        			<label><b class="glyphicon glyphicon-lock"></b> Xác nhận password</label>
      	        			<input type="password" name="reg_repw" id="reg_repw" class="form-control" placeholder="Xác nhận password" required>
              			</div>
              			<div class="clearfix"></div>
              			
              		</div>
              		<div class="form-group">
              			<label><b class="glyphicon glyphicon-earphone"></b> Số điện thoại</label>
              			<input type="number" name="reg_phone" id="reg_phone" class="form-control" placeholder="Số điện thoại" required>
              		</div>
              		<div class="form-group">
              			Bằng việc bấm đăng ký bạn đã chấp nhận các điểu khoản và quy định của Enova 
              		</div>
              	</form>
                </div>
                <div class="col-md-5">
                  <label>Hoặc đăng ký bằng mạng xã hội</label>
                  <div class="form-group">
                       <a href="#" class="btn btn-primary btn-register"> 
                       <img src="images/facebook-icon.png" alt="">
                        Đăng ký bằng Facebook
                      </a>
                  </div>
                  <div class="form-group">
                    <a href="#" class="btn btn-danger btn-register"> 
                    <img src="images/gbt.png" alt="">
                      Đăng ký bằng Google+
                    </a>
                  </div>
                  <div class="form-group">
                    <p><a href="#" class="login_btn">Đã có tài khoản</a> | <a href="#" class="getpass_btn">Quên mật khẩu ?</a></p>
                  </div>
                </div>
            </div>
      </div>
      <div class="modal-footer">
        <button type="submit" form="register" class="btn btn-primary pull-left" id="login_btn">Đăng ký</button>
      </div>
    </div><!-- /.modal-content -->
  </div><!-- /.modal-dialog -->
</div><!-- /.modal Register -->
<div class="modal fade getpass_modal">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
        <h4 class="modal-title">Lấy lại mật khẩu</h4>
      </div>
      <div class="modal-body">
        	<form id="getpass">
        		<div class="form-group">
        			<label><b class="glyphicon glyphicon-envelope"></b> Email</label>
        			<input type="email" name="login_email" id="login_email" class="form-control" placeholder="Địa chỉ email" required>
        		</div>
        		<div class="form-group">
        			Nhập Email lúc đăng ký để nhận lại mật khẩu.
        		</div>
        	</form>
        
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-primary" form="getpass">Xác nhận</button>
        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
      </div>
    </div><!-- /.modal-content -->
  </div><!-- /.modal-dialog -->
</div><!-- /.modal Forgot password -->
<nav class="navbar navbar-default navbar-top" role="navigation">
  <div class="container">
    <!-- Brand and toggle get grouped for better mobile display -->
    <div class="navbar-header">
      <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
        <span class="sr-only">Toggle navigation</span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
      </button>
    </div>

    <!-- Collect the nav links, forms, and other content for toggling -->
    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
      <ul class="nav navbar-nav">
        <li><a href="#"><b class="glyphicon glyphicon-phone-alt"></b> Hotline: 0902 850 157</a></li>
      </ul>
      <ul class="nav navbar-nav navbar-right">
        <li><a href="#">Chính sách giao hàng</a></li>
        <li><a href="#">Hướng dẫn mua hàng</a></li>
        <li><a href="#" class="register_btn" data-toggle="modal" data-target=".register_modal"><b class="glyphicon glyphicon-new-window"></b> Đăng ký</a></li>
        <li><a href="#" class="login_btn" data-toggle="modal" data-target=".login_modal"><b class="glyphicon glyphicon-log-in"></b> Đăng nhập</a></li>
      </ul>
    </div><!-- /.navbar-collapse -->
  </div><!-- /.container-fluid -->
</nav><!--./ Top Navigation -->
<header class="header">
	<div class="container">
		<div class="row header_inner">
			<div class="col-md-6 col-sm-6">
				<h1 class="logo_sec">
					<a href="#" class="logo">
						<img src="images/logo.png" class="img-responsive" />
						Enova Core Team
					</a>
				</h1>
			</div>
			<div class="col-md-2 col-sm-2 hidden-xs">
				<div class="row tip_item">
					<div class="col-md-5">
						<img src="images/transport_icon.png" class="img-responsive">
					</div>
					<div class="col-md-7">
						<p class="tip">Giao hàng toàn quốc</p>
					</div>
				</div>
			</div>
			<div class="col-md-2 col-sm-2 hidden-xs">
				<div class="row tip_item">
					<div class="col-md-5">
						<img src="images/money_icon.png" class="img-responsive">
					</div>
					<div class="col-md-7">
						<p class="tip">Thanh toán khi nhận hàng</p>
					</div>
				</div>
			</div>
			<div class="col-md-2 col-sm-2 hidden-xs">
				<div class="row tip_item">
					<div class="col-md-5">
						<img src="images/turn_back_icon.png"  class="img-responsive">
					</div>
					<div class="col-md-7">
						<p class="tip">Đổi trả trong 3 ngày</p>
					</div>
				</div>
			</div>
		</div>
	</div>
</header><!--./Header -->
<nav class="navbar navbar-inverse navbar-menu" role="navigation">
  <div class="container">
    <!-- Brand and toggle get grouped for better mobile display -->
   	<div class="row">
   		<div class="col-md-5 col-sm-8 hidden-xs">
   			<div class="menu_item">
   				<a href="" class="btn btn-success" ><b class="glyphicon glyphicon-star"></b> Hot deal</a>
   				<a href="" class="btn btn-danger" ><b class="glyphicon glyphicon-gift"></b> Khuyến mãi</a>
   				<a href="" class="btn btn-warning hidden-md" ><b class="glyphicon glyphicon-hand-right"></b> Click nhận voucher</a>
   			</div>
   		</div>
   		<div class="col-md-5 col-sm-12">
   			<div class="menu_item">
   				<form>
   					<div class="search_form input-group">
   						<span class="input-group-btn">
   							<button type="submit" class="btn btn-primary" name="submit">
   								Tìm <b class="glyphicon glyphicon-search"></b>
   							</button>
   						</span>
   						<input type="text" class="form-control" placeholder="Nhập tên sản phẩm, thương hiệu, nhà sản xuất" name="search"/>
   					</div>
   				</form>
   			</div>
   		</div>
   		<div class="col-md-2 col-sm-4 hidden-xs">
   			<div class="menu_item">
   				<button class="btn btn-primary pull-right cart" data-toggle="modal" data-target=".shopping_cart_modal"><b class="glyphicon glyphicon-shopping-cart"></b> Giỏ hàng (2)</button>
   			</div>
   		</div>
   	</div>
  </div><!-- /.container-fluid -->
</nav><!-- ./midle navigation -->