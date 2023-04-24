---
title: OkHttp WebSocket
categories:
 - WebBackend/Java
tags:
 - Spring
 - Java
 - Http
data: 2023-04-21 14:34:47
updated: 2023-04-21 14:35:25
---


## WebSocket

**WebSocket**是一种[网络传输协议](https://zh.wikipedia.org/wiki/%E7%BD%91%E7%BB%9C%E4%BC%A0%E8%BE%93%E5%8D%8F%E8%AE%AE "网络传输协议")，可在单个[TCP](https://zh.wikipedia.org/wiki/%E4%BC%A0%E8%BE%93%E6%8E%A7%E5%88%B6%E5%8D%8F%E8%AE%AE "传输控制协议")连接上进行[全双工](https://zh.wikipedia.org/wiki/%E5%85%A8%E9%9B%99%E5%B7%A5 "全双工")通信，位于[OSI模型](https://zh.wikipedia.org/wiki/OSI%E6%A8%A1%E5%9E%8B "OSI模型")的[应用层](https://zh.wikipedia.org/wiki/%E5%BA%94%E7%94%A8%E5%B1%82 "应用层")。
WebSocket使得客户端和服务器之间的数据交换变得更加简单，允许服务端主动向客户端推送数据。在WebSocket API中，浏览器和服务器只需要完成一次握手，两者之间就可以创建持久性的连接，并进行双向数据传输。

# 扩展阅读

1. [Spring Boot教程(15) – 使用WebSocket](https://zhuanlan.zhihu.com/p/80971113)