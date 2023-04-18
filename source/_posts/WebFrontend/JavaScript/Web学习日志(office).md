---
title: Web学习日志(office)
date: 2022-08-25 01:16:19.0
updated: 2022-10-27 00:10:16.103
categories: 
- WebFrontend
tags: 
- html
- css
- javascript
- office
---

# Day1

## input,button标签,实现简单加法计算器

~~~html
<input size = "6" id = "input1"/>+<input size = "6" id = "input2"/>
<button>=</button>
<input size = "6" / id = "input3"/>
~~~

![image-20220824213039132](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220824213039132.png)

> size ：可以调输入框的长度
>
> id ：id属性具有唯一值

在script标签写入脚本，推荐使用type属性：

~~~js
function sum(){
    var firstNum = document.getElementById("input1").value; //获取input输入值
    var secondNum = document.getElementById("input2").value;
    //输入的值会被转换成字符串类型，所以我们要从字符串类型转换为数值,也可以使用隐式转换
    firstNum = Number(firstNum);
    secondNum = Number(secondNum);
    
    document.getElementById("input3").value = firestNum + secondNum;
}
~~~

> var ：variable的缩写
>
> value：设置或者返回文本域的默认值

## 点击按钮切换图片，按钮触发事件

~~~html
<!DOCTYPE html>
<!-- 标签 -->
<!-- 一对标签  空标签  属性-->
<html>
	<!-- html css js -->
	<head>
		<meta charset="utf-8" />
		<title>切换图片</title>
	
	</head>
	<body>
		
		<img src="img/7.jpg" width="300px" height="186px" id="img_7"/>
		<br />
		<img src="img/10.jpg" width="300px" height="186px" id="img_10"/><br />
		<button onclick="changeImage()" id="btn">切换图片</button>
		
		<script type="text/javascript">
			/* 事件名或方法名  小驼峰 15个字符以内 */
			/* function 功能 ;document 文件；Element 元素*/
			function changeImage(){
				//通过id从页面文件中获取指定元素。修改这个元素的属性来实现效果变化
				x=document.getElementById("img_7").src;
				/* alert(x); */
				if(x=="http://127.0.0.1:8848/Day8.22/img/7.jpg"){
					document.getElementById("img_7").src="img/10.jpg";
					document.getElementById("img_10").src="img/7.jpg";
					document.getElementById("btn").innerText="切换回去";
				}
				if(x=="http://127.0.0.1:8848/Day8.22/img/10.jpg"){
					document.getElementById("img_7").src="img/7.jpg";
					document.getElementById("img_10").src="img/10.jpg";
					document.getElementById("btn").innerText="切换图片";
				}
				
				
				
			}
			
		</script>
		
	</body>
</html> 
~~~

# Day2

## 使用函数实现加法计算器

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title></title>
	</head>
	<body>
		<input id="input1"/>
		<button onclick="add()">+</button>
		<button onclick="sum()">=</button>
		
		<script type="text/javascript">
			let firstNum;
			function add(){
				firstNum = document.getElementById("input1").value;
				document.getElementById("input1").value = "";
			}
			function sum(){
				let secondNum = document.getElementById("input1").value;
				document.getElementById("input1").value = +firstNum+ +secondNum;
			}
		</script>
	</body>
</html>
~~~

## 计算机进阶,加减计算器

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8" />
		<title></title>
	</head>
	<body>
		<input id="input1"/>
		<button onclick="add()">+</button>
		<button onclick="sub()">-</button>
		<button onclick="sum()">=</button>
		<script type="text/javascript">
			//局部变量  全局变量
			//声明一个变量，命名为x；并且把10赋值给x
			var firstNum;//声明全局变量
			var sign;
			function add(){
				firstNum=document.getElementById("input1").value;
				document.getElementById("input1").value="";
				sign="+";
			}
			function sub(){
				firstNum=document.getElementById("input1").value;
				document.getElementById("input1").value="";
				sign="-";
			}
			function sum(){
				var secondNum=document.getElementById("input1").value;
				secondNum=Number(secondNum);
				firstNum=Number(firstNum);
				if(sign=="+"){
					document.getElementById("input1").value=firstNum+secondNum;
				}else{
					document.getElementById("input1").value=firstNum-secondNum;
				}	
			}
		</script>
	</body>
</html> 
~~~

> onclick ：方法，按钮的点击事件触发函数调用

# Day3

小技巧：

~~~
table>tr*7>td*7 //快速生成,输入之后输入tap键
~~~



## table表格显示(正)字

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title></title>
	</head>
	<body>
		<style>
			table{
				width: 500px;
				height: 500px;
				border: 1px; /* 边框 */
			}
		</style>
		<table border="1px">
			<tr id="1">
				<td colspan="7" bgcolor="red"></td>
			</tr>
			<tr id="2">
				<td></td>
				<td></td>
				<td></td>
				<td rowspan="5" bgcolor="red"></td>
				<td></td>
				<td></td>
				<td></td>
			</tr>
			<tr id="3">
				<td></td>
				<td></td>
				<td></td>

				<td></td>
				<td></td>
				<td></td>
			</tr>
			<tr id="4">
				<td></td>
				<td></td>
				<td></td>

				<td colspan="3" bgcolor="red"></td>
			</tr>
			<tr id="5">
				<td></td>
				<td rowspan="2" bgcolor="red"></td>
				<td></td>

				<td></td>
				<td></td>
				<td></td>
			</tr>
			<tr id="6">
				<td></td>

				<td></td>

				<td></td>
				<td></td>
				<td></td>
			</tr>
			<tr id="7">
				<td colspan="7" bgcolor="red"></td>
			</tr>
		</table>
	</body>
</html>
~~~

![img](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/I~IVKGSM61CU9LYV85R5X{X.png)

# Day4

## 实现简单前端验证码

~~~html
<body>
	<input />
	<button onclick="sendCode()" id="but1">发送验证码</button>
	<script type="text/javascript">
		var x = 60;
		var timer = null;

		function sendCode() {
			timer = window.setInterval(change, 100);
		}

		function change() {
			x--;
			document.getElementById("but1").innerText = "重新发送(" + x + ")"
			if (x == 0) {
				//1.清除定时器
				window.clearInterval(timer);
				//2.把按钮上的文字改回“发送验证码”
				document.getElementById("but1").innerText = "发送验证码";
				//3.把相关的值重置
				x = 60;
				timer = null;
			}
		}
	</script>
</body>
~~~

总结：

* 代码使用驼峰命名法，事件名，方法命名是小驼峰
* ctar+shift+/ 注释
* onclick 点击事件
* function 功能
* documet 文件
* Element 元素
* Interval 间隔、间隙

# Day5

## 产生指定范围随机整数

```html
	<script type="text/javascript">
		//[10,60]  [25,77]
		var x = Math.random(); //[0,1)
		var y = x * 51 + 10; //[0,51)->[10,61)
		var z = Math.floor(y); //[10,60]

		var a = Math.random(); //[0,1)
		var b = a * 53 + 25; //[0,53)->[25,78) 
		var c = Math.floor(b); //[25,77]

		var i = Math.floor(Math.random() * 53 + 25);
	</script>
```

* Math.random产生随机数
* Math.floor 取整

# Day6

## 随机滚动数据小练习(添加按钮)

~~~html
	<body>
		<span id = "span1">00</span>
		<br>
		<button onclick="startRoll()">开始滚动</button>
		<button onclick="stopRoll()">停止滚动</button>
		<script type="text/javascript">
			var timer = null;
			function startRoll(){
				if (timer == null){
					timer = window.setInterval("change()",100); <!-- 里面填change或"change()"，不能填change() -->
				}
			}
			function change(){
				var x = Math.floor(Math.random()*100+1);
				if(x<10){
					x="0"+x;
				}
				document.getElementById("span1").innerText = x;
			}
			function stopRoll(){
				window.clearInterval(timer);
				timer = null;
			}
		</script>
	</body>
~~~

![GIF 2022-9-1 21-52-24](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/GIF%202022-9-1%2021-52-24.gif)

## 定时随机滚动小练习

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title></title>
	</head>
	<body>
		<span id="span1">00</span>
		<script type="text/javascript">
			var timer = window.setInterval("change()",100); //间隔一定时间执行
			window.setTimeout(  //5秒后执行，一次
			function (){
				window.clearInterval(timer);//清除定时器
			}
			,5000);
			function change(){
				var x = Math.floor(Math.random()*100+10);
				if(x<10){
					x = "0"+x;
				}
				document.getElementById("span1").innerText = x;
			}
		</script>
	</body>
</html>
~~~

![GIF 2022-9-1 22-21-59](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/GIF%202022-9-1%2022-21-59.gif)


# Day7

## 作业：定时随机滚动小练习(添加按钮)

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8" />
		<title></title>
	</head>
	<body>
		<span id="span1">00</span>
		<br />
		<button onclick="startRoll()">开始滚动</button>
		<script type="text/javascript">
			var timer = null;

			function startRoll() {
				if (timer == null) {
					timer = window.setInterval(change, 500);
					window.setTimeout(
						function() {
							window.clearInterval(timer);
							timer = null;
						}, 5000);
				}

			}

			function change() {
				var x = Math.floor(Math.random() * 100 + 1);
				document.getElementById("span1").innerText = x;
			}
		</script>
	</body>
</html>
~~~

![GIF 2022-9-4 0-35-46](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/GIF%202022-9-4%200-35-46.gif)

# Day8

## 随机算数题

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title>算术题</title>
	</head>
	<body>
		<span id="span1">00</span>
		<label>-</label>
		<span id="span2">00</span>
		<label>=</label>
		<input size="5" id="input1" />
		<button onclick="submit()">提交</button>
		<script type="text/javascript">
			var x, y;
			var timer = window.setInterval(
				function() {
					x = Math.floor(Math.random() * 100 + 1);
					y = Math.floor(Math.random() * 100 + 1);
					document.getElementById("span1").innerText = x;
					document.getElementById("span2").innerText = y;
				}, 3000);

			function submit() {
				var num = document.getElementById("input1").value;
				if (x - y == num) {
					window.clearInterval(timer);
				}
			}
		</script>
	</body>
</html>
~~~

# Day9

## 猜大小游戏

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title>猜大小</title>
	</head>
	<body>
		<label>猜大小</label>
		<br />
		<button onclick="start()">开始游戏</button>
		<br />
		<span>生成随机数为: </span>
		<span id = "span"></span>
		<br />
		<input size="4" id = "input1"/>
		<button onclick="guess()">猜数</button>
		<span id = "span2"></span>
		<br />
		<span>竞猜结果：</span>
		<script type="text/javascript">
			var num,x;
			function start(){
				document.getElementById("span").innerText = "**";
				x = parseInt(Math.random()*100+1);
			}
			function guess(){
				num = document.getElementById("input1").value;
				if(num == x){
					document.getElementById("span2").innerText = "猜对了";
				}
				else if (num > x){
					document.getElementById("span2").innerText = "猜大了";
				}
				else if (num < x){
					document.getElementById("span2").innerText = "猜小了";
				}
			}
		</script>
	</body>
</html>
~~~

## 余数计算器

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title></title>
	</head>
	<body>
		<label>判断数据是否能被2整除还能被3整除</label>
		<br />
		<input id = "input1"/>
		<button onclick="start()">校验</button>
		<br />
		<span>检测结果：</span>
		<span id="span2"></span>
		<script type="text/javascript">
			var x,y,z;
			function start(){
				x = document.getElementById("input1").value
				y = x%3;
				z = x%2;
				if(y == 0 && z == 0){
					document.getElementById("span2").innerText = "是";
				}
				else{
					document.getElementById("span2").innerText = "否";
				}
			}
		</script>

	</body>
</html>
~~~

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title></title>
	</head>
	<body>
		<script type="text/javascript">
			/弱类型的语言   强类型的语言
			var x; //声明一个变量，命名为x，并且把10赋值给x
			//alert(typeof x);//undefined 未定义的
			x = 10;
			//alert(typeof x);//number  数值型
			var y = "1.5"; //声明一个变量，命名为y，并且把"20"赋值给y
			x = x / y;
			//x=x+y;   10+"20"="1020"  10+1.5=11.5
			//'+' 两边都是数值型，做加法运算；如果有一边是字符串类型，就是连接符
			//x=y-x;   "220.9"-10=210.9   "张三"-10=NaN
			//'-' 隐式的数据类型转换  只要两边能转换成number类型，就能做正常减法；
			//    如果转换不成数值，强制做减法，结果为NaN(not a number)
			//x=x*y;   10*"220.9"=2209    10*"张三"=NaN
			//'*' 隐式的数据类型转换  只要两边能转换成number类型，就能做正常乘法；
			//    如果转换不成数值，强制做乘法，结果为NaN(not a number)
			//x=x/y;   10/"1.5"=6.666666666667  10/"张三"=NaN
			//'/' 隐式的数据类型转换  只要两边能转换成number类型，就能做正常除法；
			//    如果转换不成数值，强制做除法，结果为NaN(not a number)
			//alert(typeof x);//string 字符串类型
			alert(x);
		</script>
	</body>
</html>

~~~

# Day10



## 体重健康计算器

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title>计算BMI</title>
	</head>
	<body>
		<!-- bmi=体重/(身高*身高)  计算时体重单位kg，身高m -->
		<!-- 小于18.5  偏瘦；18.5~24  正常； 24~28  偏胖；28以上  肥胖 -->
		<label>你的身高：</label>
		<input size="8" id="input1" />
		<label>单位：厘米cm</label>
		<br />
		<label>你的体重：</label>
		<input size="8" id="input2" />
		<label>单位：千克kg</label>
		<br />
		<button onclick="calculate()">计算BMI</button>
		<br />
		<span>你的身体状况为：</span><span id="span1"></span>
		<script type="text/javascript">
			function calculate() {
				var height = document.getElementById("input1").value;
				var weight = document.getElementById("input2").value;
				height = height / 100;
				var bmi = weight / (height * height);
				var spanObject = document.getElementById("span1");
				//number  string  undefined  object 对象类型
				if (bmi < 18.5) {
					spanObject.innerText = "偏瘦";
				} else if (bmi <= 24) {
					spanObject.innerText = "正常";
				} else if (bmi < 28) {
					spanObject.innerText = "偏胖";
				} else {
					spanObject.innerText = "肥胖";
				}

			}
		</script>
	</body>
</html>
~~~



## 输入框排序练习（答案）

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title>计算BMI</title>
	</head>
	<body>
		<!-- bmi=体重/(身高*身高)  计算时体重单位kg，身高m -->
		<!-- 小于18.5  偏瘦；18.5~24  正常； 24~28  偏胖；28以上  肥胖 -->
		<label>你的身高：</label>
		<input size="8" id = "input1"/>
		<label>单位：厘米cm</label>
		<br />
		<label>你的体重：</label>
		<input size="8" id = "input2"/>
		<label>单位：千克kg</label>
		<br />
		<button onclick="button()">计算BMI</button>
		<br />
		<span>你的身体状况为：</span>
		<span id = "span"></span>
		
		<script type="text/javascript">
			function button(){
				let height = document.getElementById("input1").value;
				height = height/100;
				let weight = document.getElementById("input2").value;
				let bmi = weight/(height*height);
				console.log(bmi)
				if (bmi >= 18.5 && bmi < 24){
					document.getElementById("span").innerText = "偏瘦";
				}
				else if (bmi >= 24 && bmi <= 28){
					document.getElementById("span").innerText = "正常";
				}
				else if (bmi > 28){
					document.getElementById("span").innerText = "肥胖";
				}
			};
		</script>
	</body>
</html>
~~~

## 输入框排序练习（提交）

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title></title>
	</head>
	<body>
		<input id = "input1"/>
		<input id = "input2"/>
		<input id = "input3"/>
		<button onclick="button1()">排序</button>
		<br />
		<input id = "input1_1"/> <
		<input id = "input2_2"/> <
		<input id = "input3_3"/>
		
		<script type="text/javascript">
			function button1(){
				let input1 = document.getElementById("input1").value;
				let input2 = document.getElementById("input2").value;
				let input3 = document.getElementById("input3").value;
				
				var points = [];
				points.push(input1);
				points.push(input2);
				points.push(input3);
				
				points.sort(function(a, b){return a - b}); 
				
				document.getElementById("input1_1").value = points[0];
				document.getElementById("input2_2").value = points[1];
				document.getElementById("input3_3").value = points[2];
				
			}
		</script>
	</body>
</html>
~~~

# Day11

## 找出1~1000所有含6的值

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8" />
		<title>for循环</title>
	</head>
	<body>
		<script type="text/javascript">
			//[0,1) [0,41) [10,51) 666
			let count = 0;
			for(let i=1;i<=1000;i++){
				let b = parseInt(i %1000 /100)
				let s = parseInt(i %100 /10)
				let g = parseInt(i %10 /1)
				if (b == 6 || s == 6 || g ==6){
					count ++;
				    document.write(i + "<br/>"); 
				}
			}
			document.write(count + "<br />"); //271
		</script>
	</body>
</html>

~~~

## 查看数组添加

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title></title>
	</head>
	<body>
		<input id="input1"/>
		<button onclick="add()">添加</button>
		<button onclick="check()">查看所有</button>
		<script type="text/javascript">
			let arr = new Array();
			
			function add(){
				x = document.getElementById("input1").value;
				arr.push(x);
				document.getElementById("input1").value = "";
			}
			function check(){
				alert(arr);
			}
			
		</script>
	</body>
</html>
~~~

# Day12

## 找出最小值，并计算和

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8" />
		<title></title>
	</head>
	<body>
		<script type="text/javascript">
			//找出数组中的最小值，并计算除所有数据的和
			var arr = [11, 22, 55, 3, 67, 99, 10, 78]; //数组名[下标]
			//arr.length 数组的长度 
			var min = arr[0];
			var sum = 0;
			for (var i = 0; i < arr.length; i++) {
				sum = sum + arr[i]; //sum += arr[i]   
				if (arr[i] < min) {
					min = arr[i];
				}
			}
			alert("数组最小值为" + min);
			alert("数组数据总和为" + sum);
		</script>
	</body>
</html>
~~~

## 按钮添加数值查看最大值

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title></title>
	</head>
	<body>
		<input size="5" id="input1" />
		<button onclick="add()">添加</button>
		<button onclick="showMax()">查看最大值</button>
		<script type="text/javascript">
			//用户在页面中输入任意数量整数，返回添加数字的最大值
			var arr = new Array(); //声明一个空数组
			function add() {
				var x = document.getElementById("input1").value;
				x = Number(x);
				arr.push(x);
				alert("添加成功");
				document.getElementById("input1").value = "";
			}

			function showMax() {
				var max = arr[0];
				for (var i = 0; i < arr.length; i++) {
					if (arr[i] > max) {
						max = arr[i];
					}
				}
				alert("最大值为" + max);
			}
		</script>
	</body>
</html>
~~~

# DAY13

## 查找质数

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8" />
		<title></title>
	</head>
	<body>
		<script type="text/javascript">
			//查找1~100之间所有的质数，并统计个数
			//质数（素数）只能被1和自身整除的数

			let primeNum = 0;
			for (let i = 1; i <= 100; i++) {
				let count = 0;
				for (let j = 1; j <= i; j++) {
					if (i % j == 0) {
						count++;
					}
				}

				if (count == 2) {
					document.write(i + "<br />");
					primeNum ++;
				}
			}
			document.write("1~100之间所有的质数个数为："+ primeNum);
		</script>
	</body>
</html>
~~~

## 查找完数

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title></title>
	</head>
	<body>
		<script type="text/javascript">
			//找到1000以内所有的完数，并统计个数
			//完数(完全数或完美数)，所有的因子之和等于本身
			let count = 0;
			for (let i = 1; i <= 1000; i++) {
				count = 0;
				for (let j = 1; j <= i/2; j++) {
					if (i % j == 0) {
						count = count + j;
					}
				}
				if (count == i) {
					document.write(count + "<br />");
					count = 0;
				}
			}
		</script>
	</body>
</html>
~~~

## 九九乘法表

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title></title>
	</head>
	<body>
		<script type="text/javascript">
			var num = 0;
			for (let i = 1; i <= 9; i++) {
				for (let j = 1; j <= i; j++) {
					num = i * j;
					//如果乘积是一位数，则前面添加两个空格保持队列
					if (num / 10 < 1) {
						num = i * j + "  ";
					}
					//如果乘积是一位数，则前面添加两个空格保持队列
					document.write(j + "x" + i + "=" + num + "    ");
				}
				document.write("<br />");
			}
		</script>
	</body>
</html>
~~~

## 冒泡排序

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title></title>
	</head>
	<body>
		<script type="text/javascript">
			//已知数组[33,55,22,77,66,99,11],从大到小排序显示到页面上
			let arr = [33, 55, 22, 77, 66, 99, 11];
			for(let j = 0;j < arr.length;j++){
				for (let i = 0; i < arr.length; i++) {
					if (arr[i] < arr[i + 1]) {
						//交换位置
						const temp = arr[i];
						arr[i] = arr[i + 1];
						arr[i + 1] = temp;
					}
				}
			}
			document.write(arr);
		</script>
	</body>
</html>
~~~

## 生成指定范围不重复的整数

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title></title>
	</head>
	<body>
		<script type="text/javascript">
			//随机生成六个1-33之间不重复的整数
			let arr = new Array;
			for(let i =1;i <= 6;i++){
				let number = Math.floor(Math.random()*32 + 1);
				if(arr.indexOf(number)== -1){
					arr.push(number);
				}else{
					i--;
				}
			}
			document.write(arr);
			
		</script>
	</body>
</html>
~~~

# DAY14

## 使用按钮给数组添加值，并进行排序

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8" />
		<title></title>
	</head>
	<body>
		<input size="5" id="input1" />
		<button onclick="add()">添加</button>
		<button onclick="show()">查看</button>

		<script type="text/javascript">
			var arr = new Array();

			function add() {
				var x = document.getElementById("input1").value;
				x = Number(x);
				arr.push(x);
				alert("添加成功");
				document.getElementById("input1").value = "";
			}

			function show() {
				for (var i = 0; i < arr.length; i++) {
					for (var j = i; j < arr.length; j++) {
						if (arr[i] > arr[j]) {
							var y = arr[i];
							arr[i] = arr[j];
							arr[j] = y;
						}
					}
				}
				alert(arr);
			}
		</script>
	</body>
</html>
~~~

## 使用按钮给数组添加值，并添加删除键

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title></title>
	</head>
	<body>
		<input size="5" id="input1" />
		<button onclick="add()">添加</button>
		<button onclick="del()">删除</button>
		<br />
		<span>已添加的数据：</span><span id="span1"></span>
		<script type="text/javascript">
			var arr = new Array();

			function add() {
				var x = document.getElementById("input1").value;
				x = Number(x);
				arr.push(x);
				document.getElementById("span1").innerText = arr;
				document.getElementById("input1").value = "";
			}

			function del() {
				arr.splice(arr.length - 1); //splice(下标值)
				document.getElementById("span1").innerText = arr;

			}
		</script>
	</body>
</html>
~~~

![GIF 2022-9-15 1-13-19](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/GIF%202022-9-15%201-13-19.gif)

## 使用按钮给数组添加值，并添加删除键（进行数组排序，并删除最近值）

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title></title>
	</head>
	<body>
		<input size="5" id="input1" />
		<button onclick="add()">添加</button>
		<button onclick="del()">删除</button>
		<br />
		<span>已添加的数据：</span><span id="span1"></span>

		<script type="text/javascript">
			var arr1 = new Array();
			var arr2;

			function add() {
				var x = document.getElementById("input1").value;
				x = Number(x);
				arr1.push(x);
				array();
				document.getElementById("input1").value = "";
			}
			function del() {
				arr1.splice(arr1.length - 1);
				array();
			}
			function array() {
				arr2 = new Array();
				for (var a = 0; a < arr1.length; a++) {
					arr2.push(arr1[a]);
				}
				arr2.sort(); //返回从小到大排序好的数组
				document.getElementById("span1").innerText = arr2;
			}
		</script>

	</body>
</html>
~~~

![GIF 2022-9-15 1-16-50](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/GIF%202022-9-15%201-16-50.gif)

## 作业：双色球

~~~html
<!DOCTYPE html>
<html>

	<head>
		<meta charset="utf-8">
		<title></title>
		<style>
			span1 {
				width: 100px;
				height: 70px;
				border: 1px solid rgb(48, 32, 189);
			}

			span2 {
				width: 100px;
				height: 70px;
				border: 1px solid #a00101;
			}
		</style>
	</head>

	<body>
		<span>双色球选号</span>
		<br />
		<button onclick="ball(1)">机选一注</button>
		<br>
		<span>红球号码：</span>
		<span id="redBallNum1"></span>
		<br />
		<span>蓝球号码：</span>
		<span id="blueBallNum1"></span>
		<br /><br />
		<button onclick="ball(2)">开奖</button>
		<br />
		<span>红球号码：</span>
		<span id="redBallNum2"></span>
		<br />
		<span>蓝球号码：</span>
		<span id="blueBallNum2"></span>
		<br /><br />
		<span>历史记录：</span>
		<br />
		<span id="history"></span>

		<script type="text/javascript">
			"use strict"
			//生成不重复随机数组
			function randomNum(x, y, z) {
				let arr = new Array();
				for (let i = 1; i <= z; i++) {
					let number = Math.floor(Math.random() * (y - x + 1) + x);
					//去重
					if (arr.indexOf(number) == -1) {
						arr.push(number);
					} else {
						i--;
					}
				}
				return arr;
			}
			//冒泡排序
			function sort(x, y, z) {
				let arr = [] = randomNum(x, y, z);
				for (let j = 0; j < arr.length; j++) {
					for (let i = 0; i < arr.length; i++) {
						if (arr[i] > arr[i + 1]) {
							//交换位置
							const temp = arr[i];
							arr[i] = arr[i + 1];
							arr[i + 1] = temp;
						}
					}
				}
				return arr;
			}

			
			let timer = null;
			let arr_red_ball1 = new Array();
			let arr_red_ball2 = new Array();
			let arr_bluer_ball1 = new Array();
			let arr_bluer_ball2 = new Array();
			//机选一注 开奖 ,添加计时器
			function ball(x) {
				if (timer == null) {
					timer = window.setInterval(
						function() {
							if (x == 1) {
								arr_red_ball1 = sort(1, 33, 6);
								document.getElementById(`redBallNum${x}`).innerText = arr_red_ball1.join("-");
								arr_bluer_ball1 = sort(1, 16, 1);
								document.getElementById(`blueBallNum${x}`).innerText = arr_bluer_ball1.join("-");
							}
							else if (x == 2 && arr_bluer_ball1.length != 0) {
								arr_red_ball2 = sort(1, 33, 6);
								document.getElementById(`redBallNum${x}`).innerText = arr_red_ball2.join("-");
								arr_bluer_ball2 = sort(1, 16, 1);
								document.getElementById(`blueBallNum${x}`).innerText = arr_bluer_ball2.join("-");
							}
							if (arr_red_ball1.length == 0) {
								alert("请点击机选一注后再开奖");
								window.clearInterval(timer);
								timer = null;
							}
						}, 100);

					//设置5秒定时器,并在结束时进行数值判断,防止刷新
					if(x == 1 ||(x == 2 && arr_bluer_ball1.length != 0)){
						window.setTimeout(
							function() {
								window.clearInterval(timer);
								timer = null;
								//执行历史记录方法
								history(x);
								judge(x);
							}, 5000
						);
					}
				}
			}
			//中奖判断
			function judge(x) {
				let arr1 = new Array();
				let arr2 = new Array();
				let judge = "";
				//let arr_length_red = 0,arr_length_bluer = 0;
				//红球判断
				for (let i = 0; i < arr_red_ball1.length; i++) {
					for (let j = 0; j < arr_red_ball2.length; j++) {
						if (arr_red_ball1[i] == arr_red_ball2[j]) {
							arr1.push(arr_red_ball1[i]);
						}
					}
				}
				//篮球判断
				for (let i = 0; i < arr_bluer_ball1.length; i++) {
					for (let j = 0; j < arr_bluer_ball2.length; j++) {
						if (arr_bluer_ball1[i] == arr_bluer_ball2[j]) {
							arr2.push(arr_bluer_ball1[i]);
						}
					}
				}
				//2+1/1+1/0+1   5元
				if ((arr1.length == 2 && arr2.length == 1) || (arr1.length == 1 && arr2.length == 1) || (arr1.length == 0 && arr2
						.length == 1)) {
					judge = "5元";
				}
				//4+0/3+1    10元
				else if ((arr1.length == 4 && arr2.length == 0) || (arr1.length == 3 && arr2.length == 1)) {
					judge = "10元";
				}
				//5+0/4+1   200元
				else if ((arr1.length == 5 && arr2.length == 0) || (arr1.length == 4 && arr2.length == 1)) {
					judge = "200元";
				}
				//5+1   3000元
				else if ((arr1.length == 5 && arr2.length == 1)) {
					judge = "3000元";
				}
				//6+0   100万
				else if ((arr1.length == 6 && arr2.length == 0)) {
					judge = "100万元";
				}
				//6+1    500万
				else if ((arr1.length == 6 && arr2.length == 1)) {
					judge = "500万元";
				} else {
					judge = "未中奖";
				}
				//更改空数组
				if (arr1.length == 0) {
					arr1 = "无";
				}
				if (arr2.length == 0) {
					arr2 = "无";
				}
				if (x == 2 && arr_bluer_ball1.length != 0){
					document.getElementById("history").innerHTML += "中奖结果：" + judge + "<br/ >" + "匹配红球：" + arr1 + "<br />" + "匹配篮球：" + arr2 + "<br/ >"+ "<br />";
				}
			}

			//历史记录
			function history(x) {
				if (x == 1) {
					document.getElementById("history").innerHTML += "<span1>" + "双色球选号：" + "</span1>" + "<br />";
					document.getElementById("history").innerHTML += "红球号码：" + arr_red_ball1.join("-") + "<br />";
					document.getElementById("history").innerHTML += "蓝球号码：" + arr_bluer_ball1.join("-") + "<br />" + "<br />";
				}
				if (x == 2) {
					document.getElementById("history").innerHTML += "<span2>" + "双色球开奖：" + "</span1>" + "<br />";
					document.getElementById("history").innerHTML += "红球号码：" + arr_red_ball2.join("-") + "<br />";
					document.getElementById("history").innerHTML += "蓝球号码：" + arr_bluer_ball2.join("-") + "<br />";
				}
			}
		</script>
	</body>

</html>

~~~

![GIF 2022-9-15 1-21-10](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/GIF%202022-9-15%201-21-10.gif)

# DAY15

## 三道简单for循环题

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8" />
		<title></title>
	</head>
	<body>
		<script type="text/javascript">
			//1.有一堆桃子i，猴子每天吃一半再多一个 ，吃到第五天j时发现只剩下1个桃子，问原来一共有多少桃子？
			let peach = 1;
			for(let i = 0;i < 4;i++){
				peach = (peach + 1) * 2;
			}
			console.log(`共吃了${peach}个桃子`,)

			//2.小球从100米高空落下，每次弹起是原高度一半，求第10次落地时，小球所经过的米数
			let q = 100;
			let q2 = 100;
			for (let i = 10; i >= 0; i--) {
				q = q / 2; //小球高度一半的距离 
				q2 += q * 2;
			}
			console.log("小球所经过的米数为:" + q2)
			//一个人很倒霉，不小心打碎了一篮子鸡蛋。
			//每次拿2个则剩1个，
			//每次拿3个则剩2个，
			//每次拿5个则剩4个，
			//问原先篮子中最少有多少枚鸡蛋？
			let g = 0;
			for (i = 1; g == 0; i++) {
				if ((i % 2 == 1) && (i % 3 == 2) && (i % 5 == 4)) {
					g = 1;
					console.log(`一共有个${i}鸡蛋`);
				}
			}
		</script>

	</body>
</html>
~~~

## 倒三角生成

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8" />
		<title></title>
	</head>
	<body>
		<span>倒三角的行数：</span>
		<input type="text" id="input1" />
		<button onclick="button1()">生成</button>
		<br />
		<span id = "span1"></span>
		<script type="text/javascript">
			function button1() {
				let inpt_value = Number(document.getElementById("input1").value);
				for (let i = inpt_value; i > 0; i--) {
					for (let j = 1; j <= i; j++) {
						document.getElementById("span1").innerHTML += "-";
					}
					document.getElementById("span1").innerHTML += "<br />";
				}
			}
		</script>
	</body>
</html>

~~~

![image-20220919013452541](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220919013452541.png)

## 等腰三角形生成

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title></title>
	</head>
	<body>
		<span>等腰三角的行数：</span>
		<input type="text" id="input1" />
		<button onclick="button1()">生成</button>
		<br />
		<span id="span1"></span>
		<script type="text/javascript">
			function button1() {
				let inpt_value = Number(document.getElementById("input1").value)
				for (let i = 0; i < inpt_value; i++) {
					for (let x = 0; x < inpt_value - i; x++) {
						document.getElementById("span1").innerHTML += ' ';
					}

					for (let j = 0; j <= i; j++) {
						document.getElementById("span1").innerHTML += '*' + ' ';
					}
					document.getElementById("span1").innerHTML += '<br />';
				}
			}
		</script>
	</body>
</html>
~~~

![image-20220919013540833](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220919013540833.png)

# DAY16

## 轮播图（练习）

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8" />
		<title></title>
	</head>
	<body>

		
		<img src="img/0.webp" id="img1" width="300" height="250">
		<br />
		<button onclick="last()">上一张</button>
		<button onclick="next()">下一张</button>
		<script type="text/javascript">
			"use strict"
			let x = 0;

			let timer = window.setInterval(next,2000);
			document.getElementById("img1").onmouseover = function (){
				window.clearInterval(timer);
			}
			document.getElementById("img1").onmouseout = function (){
				timer = window.setInterval(next,1500);
			}
			function next() {
				x++;
				if (x >= 6) {
					x = 0;
				}
				document.getElementById("img1").src = `img/${x}.webp`;
			}

			function last() {
				x--;
				if (x < 0) {
					x = 5;
				}
				document.getElementById("img1").src = `img/${x}.webp`;
			}
		</script>
	</body>
</html>
~~~

## 广告弹窗（练习）

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title></title>
		<style type="text/css">
			.expdiv {
				position: absolute;
				top:0px;
				right:0px;
				width: 300px;
				height: 200px;
				border: 1px solid #c8c8c8;
				z-index: 0;
				display: none;
			}

			.expimg {
				position: fixed;
				width: 300px;
				height: 200px;
				z-index: 1;
			}

			.expbtn {
				position: absolute;
				top:0px;
				right:0px;
/* 				padding: 10px;
				width: 80px; */
				background-color: #efefef;
				z-index: 2;
			}
		</style>
	</head>
	<body>
		<div class="expdiv" id = "expdiv">
			<img src="./img/0.webp" class="expimg">
			<button onclick="show()" class="expbtn">关闭</button>
		</div>
		<script type="text/javascript">
			window.setTimeout(function() {
				document.getElementById("expdiv").style = "display: block";
			}, 3000)

			function show() {
				document.getElementById("expdiv").style = "display: none";
			}
		</script>
	</body>
</html>
~~~

## 鼠标停留变颜色（练习）

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title></title>
		<style type="text/css">
		</style>
	</head>
	<body>
		<div id="spans">
			<span id="span1">变</span>
			<span id="span2">颜</span>
			<span id="span3">色</span>
		</div>
		<style>
			span {
				font-size: 40px;
			}
		</style>
		<script type="text/javascript">
			arr1 = [
				"color: DarkCyan;",
				"color: red;",
				"color: blue;",
				"color: green;",
				"color: #00FF00;",
				"color: #db25ff;",
				"color: #ff4cc7;",
				"color: #ff4197;",
				"color: #fff88b;",
			]
			let timer = null;
			//鼠标移入，循环调用color函数
			document.getElementById("spans").onmouseover = function() {
				timer = window.setInterval(color, 100);
			}
			//鼠标移除，清除timer方法，以及循环重置颜色
			document.getElementById("spans").onmouseout = function() {
				window.clearInterval(timer);
				for (let i = 1;i <= 3;i++){
					document.getElementById(`span${i}`).style = "color: #000000;"
				}
			}
			//color函数，dom选择器颜色更改
			function color() {
				for(let i = 1;i <= 3;i++){
					x = random();
					document.getElementById(`span${i}`).style = arr1[x];
				}
			}
			//随机数调用
			function random() {
				let x = Math.floor(Math.random() * 8);
				return x;
			}
		</script>
	</body>
</html>
~~~

## CSS+滚动数值综合（练习）

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title></title>
		<style type="text/css">
			div {
				width: 300px;
				height: 300px;
				text-align: center;
				background-color: #002e9b;
				color: rgb(245, 223, 77);
				font-size: 80px;
				font-weight: bold;
				line-height: 300px;
				border-radius: 50px;
				position: absolute;
				left: 40%;
				top: 30%;
				display: none;
			}
		</style>

	</head>
	<body>
		<input id = "input1" size="6">
		<button onclick="info()">录入</button>
		<button onclick="change()">开始滚动</button>
		<div id ="div1"></div>
	</body>
	<script type="text/javascript">
		let arr = new Array();
		function info(){
			if(document.getElementById("input1").value != " "){
				arr.push(document.getElementById("input1").value);
			}
			document.getElementById("input1").value = " ";
		}
		function change(){
			document.getElementById("div1").style = "display: block";
			//五秒清除定时器
			window.setTimeout(function(){
				window.clearInterval(timer)
			},5000)
			let timer = window.setInterval(function(){
				x = random();
				document.getElementById("div1").innerText = arr[x];
			},100)
		}
		//随机数调用
		function random() {
			let x = Math.floor(Math.random() * arr.length);
			return x;
		}
	</script>
</html>
~~~

## 轮播图（答案）

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8" />
		<title>轮播图</title>
	</head>
	<body>
		< img src="img/1.jpg" id="img1" width="400px" height="250px" />
		<br />
		<button onclick="last()">上一张</button>
		<button onclick="next()">下一张</button>
		<script type="text/javascript">
			var arr = ["img/1.jpg", "img/2.jpg", "img/8.jpg",
				"img/9.jpg", "img/向日葵.jpg", "img/小松鼠.jpg"
			];
			var index = 0;
			var timer = window.setInterval(next, 1000);
			document.getElementById("img1").onmouseover = function() {
				window.clearInterval(timer);
			}
			document.getElementById("img1").onmouseout = function() {
				timer = window.setInterval(next, 1000);
			}

			function next() {
				index++;
				if (index == 6) {
					index = 0;
				}
				document.getElementById("img1").src = arr[index];

			}

			function last() {
				index--;
				if (index == -1) {
					index = 5;
				}
				document.getElementById("img1").src = arr[index];
			}
		</script>
	</body>
</html>
~~~

## 鼠标停留变颜色（练习）

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title>鼠标停留文字变色</title>
		<style>
			/* 标签选择器 */
			span {
				font-size: 60px;
			}
		</style>
	</head>
	<body>
		<span id="span1" onmouseover="changeColor()" onmouseout="leave()">变</span>
		<span id="span2" onmouseover="changeColor()" onmouseout="leave()">颜</span>
		<span id="span3" onmouseover="changeColor()" onmouseout="leave()">色</span>
		<script type="text/javascript">
			var arr = ["red", "blue", "yellow", "green", "pink", "tan", "orange", "purple", "glod", "gray"];
			var timer = null;

			function changeColor() {
				timer = window.setInterval(
					function() {
						var x = Math.floor(Math.random() * arr.length);
						var y = Math.floor(Math.random() * arr.length);
						var z = Math.floor(Math.random() * arr.length);
						document.getElementById("span1").style.color = arr[x];
						document.getElementById("span2").style.color = arr[y];
						document.getElementById("span3").style.color = arr[z];
					}, 100);

			}

			function leave() {
				window.clearInterval(timer);
				document.getElementById("span1").style.color = "black";
				document.getElementById("span2").style.color = "black";
				document.getElementById("span3").style.color = "black";
			}
		</script>

	</body>
</html>
~~~

## CSS+滚动数值综合（练习）

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title></title>
		<style>
			div {
				width: 300px;
				height: 300px;
				border-radius: 50px;
				background-color: #002e9b;
				position: absolute;
				left: 40%;
				top: 30%;
				color: rgb(245, 223, 77);
				font-size: 50px;
				font-weight: bold;
				text-align: center;
				line-height: 300px;
				display: none;
			}
		</style>
	</head>
	<body>
		<input size="6" id="input1" />
		<button onclick="enter()">录入</button>
		<button onclick="startRoll()">开始滚动</button>
		<div id="div1"></div>
		<script type="text/javascript">
			var arr = new Array();
			var timer = null;

			function enter() {
				var name = document.getElementById("input1").value;
				arr.push(name);
				alert("录入成功！");
				document.getElementById("input1").value = "";
			}

			function startRoll() {
				document.getElementById("div1").style.display = "block";
				if (timer == null) {
					timer = window.setInterval(
						function() {
							var index = Math.floor(Math.random() * arr.length);
							document.getElementById("div1").innerText = arr[index];
						}, 100);
					window.setTimeout(
						function() {
							window.clearInterval(timer);
							timer = null;
						}, 5000);
				}

			}
		</script>
	</body>
</html>
~~~

# DAY17

## 双色球抽奖（练习）

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title></title>
		<style type="text/css">
			#div1 {
				width: 300px;
				height: 300px;
				text-align: center;
				background-color: #002e9b;
				color: rgb(245, 223, 77);
				font-size: 80px;
				font-weight: bold;
				line-height: 300px;
				border-radius: 50px;
				position: absolute;
				left: 40%;
				top: 30%;
				display: none;
			}

			#prize3,
			#prize2,
			#prize1 {
				display: none;
			}
		</style>

	</head>
	<body>
		<input id="input1" size="6">
		<button onclick="info()" id="info">录入</button>
		<button onclick="change()" id="change">开始滚动</button>
		<div id="div1"></div>
		<br />
		<span id="prize3">三等奖：</span>
		<br />
		<span id="prize2">二等奖：</span>
		<br />
		<span id="prize1">一等奖：</span>
		</div>
	</body>
	<script type="text/javascript">
		let arr1 = new Array();
		let arr2 = new Array();
		//录入button
		function info() {
			alert("添加成功");
			if (document.getElementById("input1").value != " ") {
				arr1.push(document.getElementById("input1").value);
			}
			document.getElementById("input1").value = " ";
		}

		//开始滚动button
		let g;
		function change() {
			document.getElementById("div1").style = "display: block";
			document.getElementById("info").disabled = "true";
			let timer = window.setInterval(function() {
				//随机生成0~arr.length长度单位的随机数
				g = random(arr1.length, 0);
				document.getElementById("div1").innerText = arr1[g];
			}, 100)
			//定时器
			window.setTimeout(function() {
				window.clearInterval(timer);
				timeout();
			}, 5000)
		}
		//随机数调用，扩展
		function random(x, y) {
			let random = Math.floor(Math.random() * (y - x) + x);
			return random;
		}
		//奖项判断，三等奖3人，二等奖2人，一等奖1人
		let i = 0
		//定时器结束时运行，防止浪费资源
		function timeout() {
			//arr2.push(Number(document.getElementById("div1").innerText));
			arr2.push(arr1[g])
			//三等奖
			if (i < 3) {
				document.getElementById("prize3").style = "display: block";
				document.getElementById("prize3").innerText += arr2[i] + ";";
			}
			//二等奖
			else if (i > 2 && i < 5) {
				document.getElementById("prize2").style = "display: block";
				document.getElementById("prize2").innerText += arr2[i] + ";";
			}
			//一等奖
			else if (i == 5) {
				document.getElementById("prize1").style = "display: block";
				document.getElementById("prize1").innerText += arr2[i] + ";";
			}
			else{
				alert("请勿重复点击");
				document.getElementById("change").disabled = "true";
			}
			arr1.splice(g,1);
			i++;
		}
	</script>
</html>
~~~

## 双色球抽奖（答案）

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8" />
		<title></title>
		<style type="text/css">
			div{
				width: 300px;
				height: 300px;
				background-color: blue;
				border-radius: 50px;
				position: absolute;
				left: 40%;
				top: 30%;
				color: yellow;
				font-size: 50px;
				font-weight: bold;
				text-align: center;
				line-height: 300px;
				display: none;
			}
			span{
				display: none;
			}
		</style>
	</head>
	<body>
		<input size="6" id="input1"/>
		<button onclick="enter()" id="btn1">录入</button>
		<button onclick="rolling()" id="btn2">开始滚动</button><br />
		<span id="third_1">三等奖</span><span id="third_2"></span><br />
		<span id="second_1">二等奖</span><span id="second_2"></span><br />
		<span id="first_1">一等奖</span><span id="first_2"></span><br />
		<div id="div1"></div>
		
		<script type="text/javascript">
			var arr=new Array();
			var count=0;
			function enter(){
				var name=document.getElementById("input1").value;
				arr.push(name);
				alert("录入成功");
				document.getElementById("input1").value="";
			}
			function rolling(){
				document.getElementById("btn1").disabled="false";
				document.getElementById("btn2").disabled="false";
				document.getElementById("div1").style.display="block";
				var index;
				var timer=window.setInterval(
				function (){
					index=Math.floor(Math.random()*arr.length);
					document.getElementById("div1").innerText=arr[index];
				}
				,100);
				window.setTimeout(
				function (){
					count++;
					window.clearInterval(timer);
					document.getElementById("btn2").disabled="";
					if(count<=3){
						document.getElementById("third_1").style.display="block";
						document.getElementById("third_2").style.display="block";
						document.getElementById("third_2").innerText=document.getElementById("third_2").innerText+arr[index]+";";
					}else if(count<=5){
						document.getElementById("second_1").style.display="block";
						document.getElementById("second_2").style.display="block";
						document.getElementById("second_2").innerText=document.getElementById("second_2").innerText+arr[index]+";";
					}else{
						document.getElementById("first_1").style.display="block";
						document.getElementById("first_2").style.display="block";
						document.getElementById("first_2").innerText=document.getElementById("first_2").innerText+arr[index]+";";
						document.getElementById("btn2").disabled="false";
					}
					arr.splice(index,1);
					
				}
				,4000);
				
			
			}
		</script>
		
	</body>
</html>
~~~

# DAY18

## 随机数滚动

~~~HTMl
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title>随机数滚动</title>
		<style>
			/* 标签选择器  */
			div {
				width: 300px;
				height: 300px;
				background-color: blue;
				border-radius: 150px;
				text-align: center;
				line-height: 300px;
				font-size: 100px;
				color: yellowgreen;
				font-weight: bold;
			}
		</style>

	</head>
	<body>
		<div id="div1">00</div>
		<button onclick="start()" id="btn1">开始</button>
		<script type="text/javascript">
			function start() {
				document.getElementById("btn1").disabled = "false";
				var timer = window.setInterval(
					function() {
						var x = Math.floor(Math.random() * 99 + 1);
						document.getElementById("div1").innerText = x;
						if (x < 10) {
							document.getElementById("div1").innerText = "0" + x;
						}
					}, 100);
				window.setTimeout(
					function() {
						window.clearInterval(timer);
						document.getElementById("btn1").disabled = "";
					}, 3000);


			}
		</script>
	</body>
</html>
~~~

## 秒表/定时器（练习）

~~~HTML
<!DOCTYPE html>
<html>

<head>
	<meta charset="utf-8">
	<title>秒表</title>
	<style type="text/css">
		#div1 {
			width: 200px;
			height: 50px;
			background-color: black;
			border-radius: 20px;
			color: greenyellow;
			text-align: center;
			line-height: 50px;
			font-size: 30px;
			display: table-cell;
		}
	</style>
</head>

<body>
	<div id="div1">00:00:00:00</div>
	<br />
	<button onclick="but_start()">当前时间</button>
	<button onclick="but_start2()">计时器</button>
	<button onclick="time_stop()">暂停</button>
	<button onclick="time_reset()">重置</button>
	<script type="text/javascript">
		//当前时间
		let timer = null;
		function but_start() {
			if (timer == null) {
				timer = window.setInterval(function () {
					ms++;
					let date = new Date();
					document.getElementById("div1").innerText = date.toLocaleTimeString() + ":" + showNum(ms);
				}, 10)
			}

		}
		//计时器
		function but_start2() {
			if (timer == null) {
				watch_ms();
				timer = window.setInterval(function () {
					document.getElementById("div1").innerText = watch();
				}, 10)
			}
		}
		//暂停
		function time_stop() {
			window.clearInterval(timer);
			timer = null;
			ms = null;
		}
		//重置
		function time_reset() {
			document.getElementById("div1").innerText = "00:00:00:00";
			window.clearInterval(timer);
			window.clearInterval(time_ms);
			timer = null;
			time_ms = null;
			s = 0;
			min = 0;
			h = 0;
			ms = 0;
		}


		let ms = 0; //毫秒
		let s = 0; //秒
		let min = 0; //分
		let h = 0; //时
		//毫秒计时器
		let time_ms = null;
		function watch_ms() {
			if (time_ms == null) {
				time_ms = window.setInterval(function () {
					ms++;
				}, 10)
			}
		}
		//秒表计数
		function watch() {
			if (ms >= 99) {
				s++;
				ms = 0;
			}
			if (s == 60) {
				min++;
				s = 0;
			}
			if (min == 60) {
				h++;
				min = 0;
			}
			return showNum(h) + ":" + showNum(min) + ":" + showNum(s) + ":" + showNum(ms);
		}

		//封装
		function showNum(i) {
			if (i < 10) {
				return "0" + i;
			}
			//判断为毫秒数
			if (i >= 99) {
				ms = 0;
			}
			return i;
		}
	</script>
</body>

</html>
~~~

![GIF 2022-9-27 0-20-45](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/GIF%202022-9-27%200-20-45.gif)

## 简单前端验证码（练习）

~~~HTML
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title></title>
		<style type="text/css">
		</style>
	</head>
	<body>
		<input id="input1" size="12"/>
		<button id = "btn1" onclick="btn1()">发送</button>
		<script type="text/javascript">
			let x = 10;
			let code = null;
			function btn1(){
				document.getElementById("btn1").disabled = "false";
				window.setTimeout(function(){
					code = showNum(random(0,999999));
					alert(code)
				},5000);
				let timer = window.setInterval(function(){
					x--;
					document.getElementById("btn1").innerText = "重新发送：" + x;
					if(x == 0){
						window.clearInterval(timer);
						document.getElementById("btn1").innerText = "发送";
						document.getElementById("btn1").disabled = "";
						code = showNum(random(0,999999));
						x = 20;
					}
				},1000)
				
			}
			//随机数调用
			function random(max,min) {
				return Math.floor(Math.random() * (max - min) + min);
			}
			//回车事件
			document.onkeydown = function(e){
				let ev = document.all ? window.event : e;
				if(ev.keyCode == 13 && code != null){
					if(code == document.getElementById("input1").value){
						alert("验证码正确")
					}
					else{
						alert("验证码错误")
					}
				}
			}
			//封装
			function showNum(i){
				if (i <100000){
					return "0" + i;
				}
				if (i <10000){
					return "00" + i;
				}
				if (i <1000){
					return "000" + i;
				}
				if (i <100){
					return "0000" + i;
				}
				if (i <10){
					return "00000" + i;
				}
				return i;
			}
		</script>
	</body>
</html>
~~~

## 获取当前系统时间（答案）

~~~HTML
万鹏:
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title>获取当前系统时间</title>
		<style>
			div{
				width: 200px;
				height: 50px;
				background-color: black;
				border-radius: 30px;
				color: yellow;
				text-align: center;
				line-height: 50px;
				font-size: 30px;
			}
		</style>
	</head>
	<body>
		<div id="div1">00:00:00</div>
		<br />
		<button onclick="stop()" >暂停</button>
		<button onclick="start()" id="btn1">开始</button>
		<script type="text/javascript">
			document.getElementById("btn1").disabled="false";
			function timeChange(){
				var myDate=new Date();
				var hour=myDate.getHours();
				var minute=myDate.getMinutes();
				var second=myDate.getSeconds();
				if(hour<10){
					hour="0"+hour;
				}
				if(minute<10){
					minute="0"+minute;
				}
				if(second<10){
					second="0"+second;
				}
				document.getElementById("div1").innerText=hour+":"+minute+":"+second;
			}
			var timer=window.setInterval(timeChange,1000);
			function stop(){
				window.clearInterval(timer);
				document.getElementById("btn1").disabled="";
			}
			function start(){
				timer=window.setInterval(timeChange,1000);
			}
			
		</script>
	</body>
</html>
~~~

PS:2022年9月27日00点23分完毕,其实四天前就完事了，不小心鸽了= =