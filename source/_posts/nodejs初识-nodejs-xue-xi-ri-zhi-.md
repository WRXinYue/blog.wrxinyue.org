---
title: node.js初识
date: 2022-10-17 23:48:45.0
updated: 2022-10-28 12:10:38.951
url: /archives/nodejs-xue-xi-ri-zhi-
categories: 
- WebFrontend
tags: 
- node.js
---

2022/10/17

**学习node前置知识：**

* HTML，CSS，JavaScript

* 数据交互 封装的原生ajax请求 axios fetch jq（用的少）
* JavaScript的es6基础认识 解构赋值，数组对象api等
* 处理异步async await promise

| JS核心语法         | WebAPI                       |
| ------------------ | ---------------------------- |
| 变量，数据类型     | DOM操作                      |
| 循环，分支，判断   | BOM操作                      |
| 函数，作用域，this | 基于XMLHttpRequest的Ajax操作 |
| etc                | etc                          |

浏览器构成：

* 用户界面
* 浏览器引擎(负责窗口管理、Tab进程管理等)
* 渲染引擎(有叫内核，负责HTML解析、页面渲染)
* JS引擎(JS解释器，如Chrome和Nodejs采用的V8)

## 初识node

* 在node中书写的是js代码
* node的作用：
  * 配合js 操作文件夹
  * 后端：
    * 数据交互（后端[服务器应用]给数据，前端渲染页面）
    * 存储数据（账号数据-后端数据库中）
    * 数据通信（实时通讯技术）
    * 各种插件
  * Node.js是一个基于Chrome V8引擎的JavaScript运行环境
    * 通过谷歌内核与js进行封装的后端语言
  * Node.js使用一个事件驱动、非阻塞式 I/O 的模型，使其轻量又高效
  * 服务器（网络上一个虚拟电脑）防止文件（项目）供别人观看
  * 使用node需安装node
    * 长期维护版本 => 稳定版本
    * 下载连接：https://nodejs.org/zh-cn/
    * 判断是否安装成功
      * cmd操作
      * PowerShell操作
        * PowerShell是cmd的进阶版本
        * 打开方式与cmd方式一致
      * 是否安装
        * 输入指令 node -v
    * node.js与js的区别
      * 浏览器 是JavaScript的前端运行环境。
      * Node.js 是JavaScript的后端运行环境。
      * Node.js 中无法调用DOM和BOM等，浏览器内置API。
    * node.js可以做什么
      * Express框架 (快速构建web应用)
      * Electron 框架 （快速构建跨平台的桌面应用）
      * restify 框架 （快速构建API接口项目）
      * 读写操作数据库，创建实用的命令行工具辅助前端开发
    * node.js常见shell指令：
      * cls 清空指令
      * cd 打开对应文件夹
        * ../ 上一层 ./ 本层 ./文件夹
        * cd d: 到达d盘  cd c: 到达c盘
      * ctrl + c 推出
      * cd 打开相应文件夹
      * dir 打印文件夹内所有目录
      * md 创建文件夹
      * rd 删除文件夹
      * cd> 文件.后缀
      * del 文件.后缀