<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@ taglib uri="http://struts.apache.org/tags-bean" prefix="bean"%>
<%@ taglib uri="http://struts.apache.org/tags-html" prefix="html"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
</head>
<body>
	<html:form action="logins">
		<html:messages id="check" property="passwordMessageError">
			<bean:write name="check" />
		</html:messages>
		<br>
Username<html:text property="account"></html:text>
		<br>
Password<html:text property="password"></html:text>
		<html:submit></html:submit>
	</html:form>
</body>
</html>