---
title: String、StringBuffer和StringBuilder
date: 2022-11-30 09:18:20.677
updated: 2023-04-18 15:09:37
categories: 
- WEBbackend
tags: 
- java
---

String 是 Java 中基础且重要的类，被声明为 final class，是不可变字符串。

所以如果要频繁操作一个字符串会使其性能降低，所以使用StringBuffer和StringBuilder “字符串缓冲区”；

![image-20221130091509475](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221130091509475.png)

#### 线程安全：

StringBuffer：线程安全
StringBuilder：线程不安全

#### 速度：

一般情况下，速度从快到慢为 StringBuilder > StringBuffer > String，当然这是相对的，不是绝对的。

#### 使用环境：

操作少量的数据使用 String。
单线程操作大量数据使用 StringBuilder。
多线程操作大量数据使用 StringBuffer。