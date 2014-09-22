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