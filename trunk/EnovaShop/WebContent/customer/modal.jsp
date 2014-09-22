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