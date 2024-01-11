---
title: RESTful API
categories:
 - 其它
tags:
 - Django
 - Spring
data: 2023-05-22 10:35:49
updated: 2023-05-22 10:35:49
---

**1. RESTful API**

RESTful API，全称为 Representational State Transfer API，是一种建构 API 的软件架构风格。主要特性如下：

-   客户端-服务器架构：客户端负责用户交互，服务器负责数据存储，二者通过 API 进行交互。
-   无状态：每次请求都应含有处理该请求所需的所有信息。服务器不保存客户端的任何状态，简化了服务器设计并提升可扩展性。
-   可缓存：服务器可以定义响应是否可以被缓存，以降低客户端-服务器之间的交互次数。
-   统一接口：RESTful API 应遵循统一接口原则，包括使用标准的 HTTP 方法（GET、POST、PUT、DELETE 等）和状态代码。
-   分层系统：客户端无法识别是否直接连接的服务器或通过中间层。分层架构允许在系统中添加代理、缓存等中间层，以提高系统的可扩展性和性能。

**2. Django 和 RESTful API**

Django 是一个开源的 Python Web 框架，用于快速构建高质量的 Web 应用。基于 Django 的 RESTful API 项目模板可以快速创建满足企业级需求、高性能的服务端应用。

**3. Spring 和 RESTful API**

Spring Framework 是一个基于 Java 的开源应用程序框架。虽然 Spring Framework 本身并不基于 RESTful，但它的 Spring MVC 模块提供了创建 RESTful 风格 API 的强大支持。

**4. RESTful API URL 设计**

-   使用名词而非动词表示资源，通过 HTTP 方法表示操作。例如：
    
    -   GET /users/1：获取 ID 为 1 的用户信息。
    -   POST /users：创建一个新用户。
    -   PUT /users/1：更新 ID 为 1 的用户信息。
    -   DELETE /users/1：删除 ID 为 1 的用户。
-   支持复杂的 URL 结构和查询参数。例如：
    
    -   GET /api/products/123/reviews：获取 ID 为 123 的产品的所有评论。
    -   GET /api/products/123/reviews?page=2&size=10&sort=time：获取 ID 为 123 的产品的第二页评论，每页 10 条，按时间排序。