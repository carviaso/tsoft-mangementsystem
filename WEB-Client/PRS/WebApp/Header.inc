<%@ page language="java" import="java.util.*" pageEncoding="utf-8"%>
<%
String path = request.getContextPath();
String basePath = request.getScheme()+"://"+request.getServerName()+":"+request.getServerPort()+path+"/";
request.setAttribute("cssPath",path+"/css");
request.setAttribute("jsPath",path+"/js");

%>
<%@taglib prefix="s" uri="/struts-tags" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head> 
	<meta http-equiv="pragma" content="no-cache">
	<meta http-equiv="cache-control" content="no-cache">
	<meta http-equiv="expires" content="0">    
<link rel="stylesheet" type="text/css" href="${cssPath}/prs.css"/>
<script type="text/javascript" src="${jsPath}/jquery.js"></script>

<style type="text/css">
 body{
 background-color:#FFF;margin:0;
 }
  #Header{
	 vertical-align:middle;
	 background-image:url(img/Banner.png);
	 height:50;
	 width:100%;
 }
 #Container{
 	vertical-align:middle;
 	height:100%;
 } 
 .menubar{
 background:url(img/menubar.png);
 vertical-align:top;
 height:25;
 width:100%;
 border-color:#D2DBFB;
 border-width:1px;
 border-style:solid;
 
 }  
 .info{
 padding:5px;
 list-style-type:none;
 height:15;
 vertical-align:bottom;
 font-size:12px;
 }
 .title{
 padding:5px;
 list-style-type:none;
 height:15;
 vertical-align:top;
 }
 
 .ColBody{
 	padding-left:5px;
 	 font-size:12px;
 }
 
 
</style>