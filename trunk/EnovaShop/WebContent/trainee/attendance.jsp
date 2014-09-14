<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@ taglib uri="http://struts.apache.org/tags-bean" prefix="bean"%>
<%@ taglib uri="http://struts.apache.org/tags-html" prefix="html"%>
<%@ taglib uri="http://struts.apache.org/tags-logic" prefix="logic"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<script type="text/javascript"
	src="http://danangtourism.org/wp-content/themes/ctnet/js/jquery.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>

<script type="text/javascript">
	$(document).ready(function() {
		setInterval(getFormAttendance, 1000);
	});
	
	
	function getFormAttendance() {
		nextTimeAttendance();
		$.ajax({
			url : '/AMS/navigateattendance.do',
			type : 'POST',
			success : function(data_return) {
				if (data_return == "callFormAttendance") {
					callFormAttendance();
				} else if (data_return == "countdown") {
					countdown();
				} else if (data_return == "turnOffAll") {
					turnOffAll();
				}
			}
		});
	}
	function callFormAttendance() {
		$.ajax({
			url : '/AMS/createattendanceform.do',
			type : 'POST',
			success : function(data_return) {
				$('#captchaform').html(data_return);
			}
		});
	};
	function countdown() {
		$.ajax({
			url : '/AMS/countdownforsubmit.do',
			type : 'POST',
			success : function(data_return) {
				$('#timer').html("Time: "+data_return);
			}
		});
	};
	function turnOffAll() {
		$('#captchaform').html("");
		$('#timer').html("");
	};
	function nextTimeAttendance() {
		$.ajax({
			url : '/AMS/countdownfornextattendance.do',
			type : 'POST',
			success : function(data_return) {
				$('#nexttime').html(data_return);
			}
		});
	};
	function autoSubmit(){
		var data_st0 = 'captcha0='+$("#captcha0").val();
		var data_st1 = '&captcha1='+$("#captcha1").val();
		var data_st2 = '&captcha2='+$("#captcha2").val();
		var data_st = data_st0 + data_st1 + data_st2;
		$.ajax({
			url : '/AMS/checkcaptcha.do',
			type : 'POST',
			data : data_st,
			success : function(data_return) {
				$('#autosubmit').html(data_return);
			}
		});
	};
</script>

</head>
<body>
	<div id="result"></div>
	<div id="nexttime"></div>
	<div id="captchaform"></div>
	<div id="autosubmit"></div>
	<span id='timer'></span>
</body>
<p>
	Xin Chao ban: <strong> <bean:write name="loginUserForm"
			property="account" />
	</strong>
</p>
<br>
<a href="http://10.133.228.160:1234/chatrome/">Chat Room</a>
</html>