---
title: Servlet
date: 2023-1-10 7:58:16.916
categories: 
- WEBbackend
tags: 
- Java
updated: 2023-04-18 15:09:37
---

## 简述

* Servlet是一种基于组件的技术，它可以在多种Web服务器上运行，并且独立于平台。
* Servlet可以访问整个Java API系列，包括JDBC用于访问企业数据库。
* Servlet可以通过表单从用户那里收集输入，显示来自数据库或其他来源的记录，并动态创建网页。
* Servlet通常认为是CGI程序的高效替代品。Servlet相比CGI有很多种优点，如更高的性能。
* Servlet 是平台无关的，因为它们是用 Java 编写的。
* Java安全管理器强制执行限制以保护服务器资源，可以使用Java类库全部功能（依赖于容器和服务器支持的功能）。
* Servlet需要运行在Servlet容器（如 Tomcat）上，然后才能在Web服务器上工作。

![image-20230110201204891](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230110201204891.png)

## 环境

Java Servlet是由支持Java Servlet规范的解释器（通常是Web容器）在服务器端运行的Java类。这些类可以使用 `javax.servlet` 和 `javax.servlet.http`包中的类来创建，这些包是Java企业版标准部分，可以支持大型开发项目。

Servlet的创建和编译基本上就像其他Java类一样，需要将Servlet包安装并添加到类路径中，然后可以使用JDK的Java编译器或其他编译器来编译Servlet。

但是一般会使用一些构建工具来管理依赖，打包和发布项目。这样可以更加便捷的管理项目，常见构建工具有：Apache Maven、Gradle、Apache Ant



本次使用环境：

* Java开发工具包（SDK）
* Web服务器 - Tomcat

## 应用

* **处理和相应HTTP请求**：Servlet通过实现HTTP协议相关的方法来响应客户端的请求，如get或post。
* **维护状态信息**：Servlet可以在会话期间维护状态信息，这在跨请求的操作中很有用，例如在网上购物车中存储物品。
* **数据库交互**：Servlet通过JDBC或其他数据库访问技术来访问数据库并执行查询和更新操作。
* **生成动态内容**：Servlet可以根据请求内容动态生成HTML、XML或其他格式的文档。
* **访问远程组件**：Servlet可以通过RMI或SOAP等协议访问远程组件。



## 生命周期

Servlet的生命周期可以定义为从创建到销毁的整个过程。在这个过程中，Servlet容器会调用Servlet的三个生命周期方法：`init()`、`service()`和`destroy()`。

### init()

Servlet的生命周期中有一个可选的方法叫做`init()`,它通常在Servlet第一次被请求时被调用一次。它可以用于进行一些初始化工作，如加载配置文件、建立数据库连接等。



常见`init()`方法:

~~~java
public void init() throws ServletException {
    // initialization code
}
~~~



带**ServletConfig** 参数的`init()`方法:

```java
public void init(ServletConfig config) throws ServletException {
    // initialization code
}
```



### service()

Servlet的生命周期中`service()`方法是执行实际任务的主要方法。当客户端（浏览器）发送请求到Servlet时，Servlet容器（即Web服务器）会生成一个新线程并调用`service()`方法来处理请求。

~~~java
public void service(ServletRequest request, ServletResponse response) throws ServletException, IOException {
   // Service Code
}
~~~

#### doGet()

~~~java
public void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
   // Servlet code
}
~~~

#### doPost()

~~~java
public void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
   // Servlet code
}
~~~



### destroy()

Servlet生命周期结束时会调用一次`destroy()`方法。它可以进行关闭数据库连接、停止后台线程等。

~~~java
public void destroy() {
   // Finalization code...
}
~~~



## 参考学习

[Servlet - 教程](https://www.jc2182.com/servlet/servlet-jiaocheng.html)

[Servlet入门 - 廖雪峰的官方网站](https://www.liaoxuefeng.com/wiki/1252599548343744/1304265949708322)