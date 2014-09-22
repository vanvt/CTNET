$(document).ready(function(){
		var cate = $('.panel-cate').find('.panel-body');
		$('.btn_addtocart').click(function() {
			$('.modal').modal('hide');
			$('.shopping_cart_modal').modal('show');
			return false;
		});
		$('.register_btn').click(function() {
			$('.modal').modal('hide');
			$('.register_modal').modal('show');
			return false;
		});
		$('.login_btn').click(function() {
			$('.modal').modal('hide');
			$('.login_modal').modal('show');
			return false;
		});
		$('.getpass_btn').click(function() {
			$('.modal').modal('hide');
			$('.getpass_modal').modal('show');
			return false;
		});
		$('.pro_item .thumbnail').hover(function() {
			$(this).find('.thumb_overlay').stop().fadeIn(300);
			$(this).find('.btn_addtocart').stop().fadeIn(300);
		}, function() {
			$(this).find('.thumb_overlay').stop().fadeOut(200);
			$(this).find('.btn_addtocart').stop().fadeOut(300);
		});
		$('.tooltips').hover(function() {
			$(this).tooltip('show');
		}, function() {
			/* Stuff to do when the mouse leaves the element */
		});
		$('#pro_tab_content a').click(function (e) {
		  e.preventDefault()
		  $(this).tab('show');
		});
		$(".tab_content").find('table').addClass('table table-bordered table-striped').css({
			margin: '10px auto'
		});
		$(".panel-cate .panel-heading").click(function(e) {
			e.preventDefault();
			if(cate.css('display')!='none'){
				cate.stop().slideUp(300);
			} else {
				cate.stop().slideDown(300);
			}
		});
		$(".show_cate").hover(function() {
			cate.stop().slideDown(300);
		}, function() {
			cate.stop().slideUp(300);
		});

		$('.show_rep_form').click(function(e) {
			e.preventDefault();
			$('.form_reply').slideUp(200);
			var obj = $(this).parent().parent().find('.form_reply');
			if(obj.css('display')=='none'){
				obj.stop().slideDown(200);
			} else {
				obj.stop().slideUp(200);
			}
		});

	});