---
title: Promise 笔记
date: 2022-10-17 23:49:40.0
updated: 2023-05-08 14:09:52
categories: 
- WebFrontend
tags: 
- javascript
---

# Promise介绍

promise是一个异步编程的一种解决方式，专门用于解决回调函数出现的回调地狱情况。

抽象表达：

1. Promise是一门新的技术（ES6规范）
2. Promise是JS中进行异步编程的新解决方法（旧方案是单纯使用回调函数）

具体表达：

1. 从语法上来说：Promise是一个构造函数
2. 从功能上来说：promise对象用来封装一个异步操作并可以获取成功/失败的结果值

> fs 文件操作
>
> ~~~
> require('fs').readFile('./index.html',(err,data)=>{})
> ~~~
>
> 数据库操作
>
> AJAX
>
> ~~~js
> $.get('/server',(data)=>{})
> ~~~
>
> 定时器
>
> ~~~js
> setTimeout(()=>{},2000);
> ~~~

 

# Promise 初体验

使用回调函数：

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title></title>
	</head>
	<body>
		<div class="container">
			<h2 class="pape-header">Promise 初体验</h2>
			<button class="btn butn-primary" id="btn">点击抽奖</button>
		</div>
		<script type="text/javascript">
			//生成随机数
			function rand(m,n){
				return Math.ceil(Math.random() * (n-m+1)) + m -1
			}
			/*  点击按钮，2s后显示是否中奖（30%概率中奖）
			 *  容易中奖弹出 恭喜恭喜，奖品为10万RMB劳斯莱斯优惠卷
			 *  若未中奖弹出 再接再厉
			 */
			//获取元素对象
			const btn = document.querySelector('#btn');
			//绑定单击事件
			btn.addEventListener('click', function(){
				//定时器
				setTimeout(() => {
					//30% 1-100 1 2 30
					//获取从 1 - 100的一个随机数
					let n = rand(1,100);
					if(n <= 30){
						alert("恭喜恭喜，奖品为10万RMB劳斯莱斯优惠卷");
					}else{
						alert("再接再厉");
					}
				},1000);
			});
			
		</script>
	</body>
</html>
~~~
Promise方法：

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title></title>
	</head>
	<body>
		<div class="container">
			<h2 class="pape-header">Promise 初体验</h2>
			<button class="btn butn-primary" id="btn">点击抽奖</button>
		</div>
		<script type="text/javascript">
			//生成随机数
			function rand(m,n){
				return Math.ceil(Math.random() * (n-m+1)) + m -1
			}
			/*  点击按钮，2s后显示是否中奖（30%概率中奖）
			 *  容易中奖弹出 恭喜恭喜，奖品为10万RMB劳斯莱斯优惠卷
			 *  若未中奖弹出 再接再厉
			 */
			//获取元素对象
			const btn = document.querySelector('#btn');
			//绑定单击事件
			btn.addEventListener('click', function(){
				
				//Promise 形式实现
				const p = new Promise((resolve,reject) => {
					setTimeout(() => {
						//30% 1-100 1 2 30
						//获取从 1 - 100的一个随机数
						let n = rand(1,100);
						if(n <= 30){
							resolve();
						}else{
							reject();
						}
					},1000);
				});
				
				// 调用 then 方法
				p.then(() => {
					alert("恭喜恭喜，奖品为10万RMB劳斯莱斯优惠卷");
				},() => {
					alert("再接再厉");
				});
			});
			
		</script>
	</body>
</html>
~~~

# fs读取文件

