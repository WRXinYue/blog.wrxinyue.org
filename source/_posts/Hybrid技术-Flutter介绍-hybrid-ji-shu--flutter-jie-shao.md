---
title: Hybrid技术-Flutter介绍
date: 2022-08-13 22:52:01.0
updated: 2022-10-27 00:13:12.999
url: /archives/hybrid-ji-shu--flutter-jie-shao
categories: 
- WebFrontend
tags: 
- hybrid
---

# Hybrid技术

> hybrid译为中文是“混合”的意思，是一种原生APP和[HTML5](https://so.csdn.net/so/search?q=HTML5&spm=1001.2101.3001.7020)混合开发的技术。

 在前端移动端开发中，到现在阶段主要有三大潮流

  1. 原生APP开发(以Android和iOS为主导)
  2. HTML5 WebAPP开发
  3. 原生APP和HTML5混合开发，也就是hybrid技术

Hybrid主要分为三类：

> H5 + 原生：Cordova，lonic，微信小程序
>
> JavaScript开发+原生渲染：React Native、Wex、快应用
>
> 自绘UI + 原生：QT for mobile，Flutter

![image-20220813205022119](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220813205022119.png)

![image-20220813205116298](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220813205116298.png)

## 什么是原生开发?

原生应用程序是指某一个移动平台（比如iOS或者Android）所特有的应用，使用相应平台支持的开发工具和语言，并直接调用系统提供的SDK API。比如Android原生应用是指使用Java或者Kotlin语言直接调用Android SDK开发的应用程序；而iOS原生应用就是指通过Objective-C或Swift语言直接调用iOS SDK开发的应用程序

# Flutter介绍

Flutter是Google推出并开源的移动应用开发UI框架，主打跨平台、高保真、高性能。开发者可以通过Dart语言开发App，一套代码同时运行在多个平台。Flutter提供了丰富的组件、接口，开发者可以很快地为Flutter添加Native扩展

# JIT和AOT

JIT既Just-in-time，动态（即时）编译，边运行边编译。

优点：

> * 可以根据当前硬件情况实时编译生成最优机器指令
> * 可以根据当前程序的运行情况生成最优的机器指令序列
> * 当程序需要支持支持动态链接时，只能使用JIT
> * 可以根据进程中内存的实际情况调整代码，使内存能够更充分的利用

缺点：

> * 编译需要占用运行时资源，会导致进程卡顿
> * 由于编译时间需要占用运行时间，对于某些代码的编译优化不能完全支持，需要在程序流畅和编译时间之间做权衡
> * 在编译准备和识别频繁使用的方法需要占用时间，使得初始编译不能达到最高性能

AOT即Ahead Of Time，指运行前编译。

优点：

> * 在程序运行前编译，可以避免在运行时的编译性能消耗和内存消耗
> * 可以在程序运行初期就达到最高性能
> * 可以显著的加快程序的启动

缺点：

> * 在程序运行前编译会使程序安装的时间增加
> * 牺牲Java的一致性
> * 将提前编译的内容保存会占用更多的外

# 关于Dart

Dart是由谷歌开发的计算机编程语言，可以用于web、服务器、移动程序和物联网领域的开发。

Dart诞生于2011年，号称要取代JavaScript。但是过去几年中一直不温不火。直到Flutter的出现被人们重新重视起来，要学Flutter必须的会Dart

## 开发效率高

Dart运行时和编译器支持Flutter的两个关键特性的组合：

* 基于JIT的快速开发周期；
* 基于AOT的发布包

## 高性能

Flutter提供流畅、高保真的UI体验。

## 快速内存分配

Flutter框架使用函数式流，这使得它在很大程度上依赖于低层的内存分配器。

## 类型安全和空安全

由于Dart是类型安全的语言，且2.12版本后也支持了空安全特性，所以Dart支持静态类型检测，可以在编译前发现一些类型的错误，并排除潜在问题。