---
title: BootStrap
date: 2022-08-05 11:12:00.0
categories: 
- WebFrontend
tags: 
- css
---



# BootStrap

## BootStrap 介绍

Bootstrap是一套现成的CSS样式集合。

BootStrap是最受欢迎的HTML、CSS和JS框架，用于开发响应式布局、移动设备优先的WEB项目。

## BootStrap 特点

1. 简洁、直观、强悍的前端开发框架，html、css、JavaScript工具集，让web开发更迅速，简单。
2. 基于html5、css3的bootstrap，具有大量的诱人特性：友好的学习曲线，卓越的兼容性，响应式设计，12列格网，样式向导文档。
3. 自定义jQuery插件，完整的类库，bootstrap3基于Less，bootstrap4基于Sass的CSS预处理技术
4. Bootstrap响应式布局设计，让一个网站可以兼容不同分辨率的设备。Bootstrap响应式布局设计，给用户提供更好的视觉使用体验。
5. 丰富的组件

## 下载与使用

1. 下载：https://getbootstrap.com/

2. 下载完成后

   拷贝dist/css中的bootstrap.min.css到项目css中

   拷贝dist/js中的bootstrap.min.js到项目的js中

3. 下载jQuery.js

4. 在html模板为

   ~~~html
   <!DOCTYPE html>
   <html>
   	<head>
   		<meta charset="utf-8">
   		<title>Bootstrap的HTML标准模板</title>
   		<!--
   			viewport表示用户是否可以缩放画面；
   			width指定视区的逻辑宽度；
   			device-width只是视区宽度应为设备的屏幕宽度；
   			initial-scale指令用于设置web页面的初始缩放比例
   			initial-scale=1则将显示未经缩放的web文档
   		-->
   		<meta name="viewport" content="width=device-width, initial-scale=1则将显示未经缩放的web文档=1.0">
   		<!-- 载入Bootstrap 的 css -->
   		<link href="css/bootstrap.min.css" rel="stylesheet"/>
   	</head>
   	<body>
   		<h1>Hello, world!</h1>
   
   		<!-- jQuery (Bootstrap 的 JavaScript 插件需要引入 jQuery) -->
   		<script src="https://code.jquery.com/jquery.js"></script>
   		<!-- 包括所有已编译的插件 -->
   		<script src="js/bootstrap.min.js"></script>
   	</body>
   </html>
   
   ~~~

   常规

   ~~~html
   <!DOCTYPE html>
   <html>
   	<head>
   		<meta charset="utf-8">
   		<title></title>
   		<meta name="viewport" content="width=device-width, initial-scale=1则将显示未经缩放的web文档=1.0">
   		<link href="bootstrap/css/bootstrap.min.css" rel="stylesheet"/>
   	</head>
   	<body>
   		<h1>Hello, world!</h1>
   
   		<script src="https://code.jquery.com/jquery.js"></script>
   		<script src="bootstrap/js/bootstrap.min.js"></script>
   	</body>
   </html>
   ~~~

   

   ## 布局容器和格栅网络系统