---
title: Spring
date: 2023-1-11 15:17:00.0
categories: 
- WEBbackend
tags: 
- Spring
---

## Preface

当我第一次接触Spring框架时，我的导师(项目经理)以迅雷不及掩耳之势，在短短三天内讲完了整个Spring框架。尽管当时我对很多概念还有疑问，但我决定将我的学习过程记录下来，这就是这篇研究Spring框架的笔记。这篇文章于2023年1月11日开始编写。快过年了我可以摸几天鱼吗...

## Synopsis

Spring是最受欢迎的企业级Java应用程序开发框架。它是一个开源的Java平台，轻量级且灵活，可以用于开发各种类型的Java应用程序。其中最常用的是基于Spring MVC构建Web应用程序。Spring框架的目标是使J2EE(企业版)开发变得更容易使用，通过启用基于**POJO**编程模型来促进良好的编程实践。

> POJO 是 Plain Old Java Object 的缩写，意思是“纯粹的旧Java对象”。在Java中，POJO指的是没有任何特殊要求的Java类，也就是没有任何继承自特定父类或实现特定接口的类。
>
> Spring框架采用了POJO编程模型，它提供了一种简洁而直观的方式来管理应用程序对象之间的关系。使用POJO编程模型，开发人员可以将业务逻辑与框架相分离，使得应用程序更易于理解和维护。

## 两大核心

### IoC和DI

**IoC：**控制反转（Inversion of Control，IoC）是指将对象的实例化和管理的权限（反转）交给容器。即对象不在负责创建和管理自己的依赖，而是将这些工作委托给容器来完成。

**DI：**依赖注入（Dependency Injection，DI）是一种从容器角度管理对象依赖关系的方式。容器自动将对象依赖的其他对象注入。例如：对象A在实例化过程中声明了一个B类型的属性，容器会在运行时自动将B对象注入到A中。

**区别：**IoC和DI形成了类似"嵌套"的关系，其中IoC是一个更宽泛的概念，而DI是一种实现IoC的具体方式。IoC是一种范式，而DI是一种实现IOC的技术。简单来说，**IoC是一个思想，而DI是一种实现IoC的具体方式。**

**何为反转：**如果对反转控制的概念还有疑惑，没关系。我们来举个例子。在传统的Java SE程序设计中，我们通常会直接在对象内使用new关键字创建对象，这是程序主动去创建依赖对象。而IoC则使用一个专门的容器来创建这些对象，容器控制了对象的创建，并主要控制了外部资源的获取。*这种方式被称为反转，因为它与传统的程序设计相反。在传统方式中，我们自己在对象中主动控制直接获取依赖对象，这就是正转。而在IoC中，容器帮助创建和注入依赖对象，对象只是被动接受依赖对象，依赖对象的获取被反转了*

![image-20230112171221155](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230112171221155.png)

**Spring是一种IoC容器：**它使用依赖注入（DI）的方式管理对象之间的依赖关系，使得对象之间松耦合，方便管理。

### AOP

**概述：**面向切面编程（Aspect-Oriented Programming，AOP）是一种编程思想，在不修改源代码的情况下，通过切面来统一管理公用行为。它可以将程序中与业务无关的功能，比如日志记录、性能监控、事务处理等抽离出来，通过配置或代码的方式组合到业务逻辑中。这样做有助于提高代码的可重用性和可维护性，同时提高开发效率。AOP在Spring框架中是一个重要的内容。

**AOP和OOP：**AOP是OOP（Object-Oriented Programming）的延续。AOP主要用于解决OOP重复代码和横切关注点的问题。

![image-20230112154043848](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230112154043848.png)

## Spring 体系结构

Spring框架是一个非常强大的框架，它提供了各种各样的功能和模块。在实际的应用开发中，我们并不需要使用所有的功能和模块，而是可以根据需要，选择适合自己项目的Spring模块进行使用。

![image-20230112164031999](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230112164031999.png)

## Conclusion

## References

[1] [SPRING TUTORIAL spring-tutoria](https://dunwu.github.io/spring-tutorial/)

[2] [Spring框架两大核心特征的基本理解_sandyLL0224的博客-CSDN博客_spring框架两大特性](https://blog.csdn.net/sandyLL0224/article/details/81147316)

[3] [IOC是什么意思！？- 动力节点在线](https://www.zhihu.com/tardis/sogou/qus/335362570)

[4] [浅谈IOC--说清楚IOC是什么](https://blog.csdn.net/ivan820819/article/details/79744797)

[5] [Aspect Oriented Programing - Introduction](https://www.slideshare.net/koneru9999/aspect-oriented-programing-introduction)

[6] [Chapter 8. AspectJ weaving models - AspectJ in Action, Second Edition](https://livebook.manning.com/book/aspectj-in-action-second-edition/chapter-8/73)

[7] [Java Proxy和CGLIB动态代理原理 - CarpenterLee - 博客园](https://www.cnblogs.com/carpenterlee/p/8241042.html)

[8] [來談談 AOP (Aspect-Oriented Programming) 的精神與各種主流實現模式的差異](https://tech-blog.cymetrics.io/posts/maxchiu/aop/)

[9] [What are the differences between Spring IOC and Spring MVC? - Quora](https://www.quora.com/What-are-the-differences-between-Spring-IOC-and-Spring-MVC)

[10] [Spring IOC 原理深层解析-技术圈](https://jishuin.proginn.com/p/763bfbd2a478)