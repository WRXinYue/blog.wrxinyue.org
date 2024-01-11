---
title: jQuery
date: 2022-12-27 9:21:48.0
categories: 
- WebFrontend
tags: 
- jQuery
data: 2023-04-11 14:40:26
updated: 2023-04-11 14:40:26
---



# 初识jQuery

## 什么是jQuery

* 一个优秀的JS函数库（封装BOM和DOM）
* 使用jQuery的网站超过90%（18年统计）
* 中大型WEB项目开发首选
* Write Less，Do More!!!

## JavaScript and jQuery

我们知道Javascript以Netscape公司开发的一种脚本语言（scripting language）。Javascript存在3个弊端，即复杂的文档对象模型（DOM），不一致的浏览器实现和缺乏便捷的开发、调试工具。

正当JavaScript从开发者的视线中渐渐隐去时，一种新型的基于Javascript的Web技术——Ajax（Asynchronous Javascript And XML，异步的Javascript和XML）诞生了，是JavaScript不再是一种仅仅用于制作Web页面的简单脚本。

为了简化JavaScript的开发，一些JavaScript库诞生了。JavaScript库封装了很多预定义的对象和实用函数。

这里主要写jQuery库，jQuery同样是一个轻量级的库，拥有强大的选择器，出色的DOM操作，可靠的事件处理、完善的兼容性和链式操作等功能。

# jQuery代码的编写

## jQuery环境配置

jQuery不需要安装，把下载的jQuery放到网站上的一个公共的位置，想要在某个页面上使用jQuery时，只需要在相关的HTML文档中引入该库文件的位置即可。

## 在页面引入jQuery

把jQuery放在目录script下，然后在编写的页面代码中`<head>`标签内引入jQuery库后，就可以使用jQuery库了，程序如下：

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
        <!-- 在head标签内 引入jQuery -->
        <script src = "./scripts/jquery-1.10.2.js" type = "text/javascript"></script>
        <!-- Staticfile CDN引入 -->
        <script src="https://cdn.staticfile.org/jquery/1.10.2/jquery.min.js"></script>
    <head>
		<title></title>
	</head>
	<body>
	</body>
</html>
~~~

## 编写简单的jQuery代码

在jQuery库中，$就是jQuery的一个简写形式，例如$("#foo")和jQuery("#foo")是等价的，$.ajax和jQuery.ajax是等价的。

第一个jQuery程序。

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8" />
		<title></title>
		<script src="https://cdn.staticfile.org/jquery/1.10.2/jquery.min.js"></script>
	</head>
	<body>
		<script type="text/javascript">
			$(document).ready(function(){
				alert("Hello World!");
			});
		</script>
	</body>
</html>
~~~

![image-20220906230313680](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220906230313680.png)

~~~js
$(document).ready(function{
//...
});
~~~

这段代码的作用类似于传统JavaScript中的window.onload方法，但有些区别;

![image-20220906230911959](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220906230911959.png)

## jQuery代码风格

如果能统一jQuery代码编码风格，对日后代码的维护是非常有利的。

项目需求是做一个导航栏，点击不同章节名称连接，显示相应的内容，同时高亮显示当前选择的章节

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8" />
		<title></title>
		<script src="https://cdn.staticfile.org/jquery/1.10.2/jquery.min.js"></script>
		<style type="text/css">
			#menu { 
				width: 300px;
			}
			.has_children{
				background: #555;
				color: #fff;
				cursor: pointer;
			}
			.highlight{
				color: #fff;
				background: green;
			}
			div {
				padding: 0;
				margin: 10px 0;
			}
			div a {
				background: #888;
				display: none;
				float: left;
				width: 300px;
			}
		</style>
	</head>
	<body>
		<div id="menu">
			<div class="has_children">
				<span>第1章-认识jQuery</span>
				<a>什么是jQuery</a>
				<a>Javascript and jQuery</a>
				<a>jQuery代码的编写</a>
				<a>在页面进入jQuery</a>
				<a>编写简单的jQuery代码</a>
				<a>jQuery代码风格</a>
			</div>
			<div class="has_children">
				<span>第1章-认识jQuery</span>
				<a>什么是jQuery</a>
				<a>Javascript and jQuery</a>
				<a>jQuery代码的编写</a>
				<a>在页面进入jQuery</a>
				<a>编写简单的jQuery代码</a>
				<a>jQuery代码风格</a>
			</div>
			<div class="has_children">
				<span>第1章-认识jQuery</span>
				<a>什么是jQuery</a>
				<a>Javascript and jQuery</a>
				<a>jQuery代码的编写</a>
				<a>在页面进入jQuery</a>
				<a>编写简单的jQuery代码</a>
				<a>jQuery代码风格</a>
			</div>
		</div>
		<script type="text/javascript">
			$(".has_children").click(function(){
				$(this).addClass("highlight").children("a").show().end().siblings().removeClass("highlight").children("a").hide();
			});
		</script>
	</body>
</html>


~~~

这段代码的作用是，当鼠标单击到class中含有has_children的元素上的时候，给其添加一个名为highlight的class，然后将其内部`<a>`子元素都显示出来，并且被单击的class中含有has_children元素的同辈元素都去掉一个名为highlight的class，同时同辈元素内部的`<a>`子元素全部隐藏

![GIF 2022-9-6 23-32-24](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/GIF%202022-9-6%2023-32-24.gif)

这就是jQuery强大的链式操作，一行代码就完成了导航栏的功能
