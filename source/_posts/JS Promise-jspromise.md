---
title: JS Promise
date: 2022-10-17 23:49:40.0
updated: 2022-10-26 23:49:06.261
url: /archives/jspromise
categories: 
- WebFrontend
tags: 
- javascript
---

# Promise是什么

* Promise是JS种进行异步编程的新解决方案
* Promise是一门新的技术（ES6规范）
* Promise是一个构造函数（从语法上来说）
* Promise对象用来封装一个异步操作并可以获取其成功/失败的结果值（从功能上说）

> 注：旧方案是单纯使用回调函数



**指定回调函数的方式更加灵活：**

1. 旧的：必须在启动异步任务前指定
2. promise：启动异步任务 => 返回promise对象 => 给promise对象绑定回调函数（甚至可以在异步任务结束后指定/多个）



**支持链式调用，可以解决回调地狱问题：**

1. 什么是回调地狱：

   回调函数嵌套调用，外部回调函数异步执行的结果是嵌套的回调执行的条件

2. 回调地狱的缺点：

   不便于阅读、不便于异常处理

3. 解决方案：

   promise链式调用

## 异步编程

fs 文件操作

数据库操作

AJAX

定时器