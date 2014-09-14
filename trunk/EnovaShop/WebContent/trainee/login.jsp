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
		setInterval(gettime, 1000);
		function gettime() {
			$.ajax({
				url : '/AMS/countdownfornextattendance.do',
				type : 'POST',
				success : function(data_return) {
					$('#result').html(data_return);
				}
			});
		}
	});
</script>
</head>
<body>
	<form action="/login" method="post"></form>
	<html:form action="/login">
	
		<span id="result"></span>
		<table>
			<tr>
				<td>Account</td>
				<td><html:text property="account"></html:text></td>
			</tr>
		</table>
		<html:submit>Login</html:submit>
		<input type="submit">
	</html:form>
</body>
</html>
