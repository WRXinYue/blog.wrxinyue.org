---
title: HRACK攻击原理解析
date: 2022-08-30 20:15:21.0
updated: 2023-04-18 15:07:47
categories: 
- 网络安全
tags: 
- hacker
- hrack
---

## HRACK攻击(WPA1/WP2)

KRACKs（Key Reinstallation AttaCKs）是一系列WPA2 (Wi-Fi  Protected Access 2 )协定漏洞的总称

## 四向交握(4-WAY HANDSHAKE)

* 第一步(Msg1)，AP会发送一组初始化向量（ANonce）到客户端装置（STA）。
* 第二步(Msg2)，STA接到ANonce，会产生一组PTK（Pairwise Transient  Key）和另一个初始化向量（SNonce）发送给AP，并且使用了名为MIC（Message Integrity Code）的验证码。
* 第三步(Msg3)，AP收到SNonce后，也会导出一组PTK，并发送密钥GRK给STA。
* 第四步(Msg4)，STA在安装本身PTK和GRK之后回复讯息（Ack）给AP。

![image-20220829165024722](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220829165024722.png)

* 利用Wi-Fi握手协议漏洞，在四向交握中客户端没有收到AP的 讯息时，会要求讯息重传。
* 当客户端收到AP发来的讯息(Msg3)后将会安装PTK和GTK，用 于加密正常的封包。但因为Msg3可能丢失或者被丢弃，AP没有 收到回应(Msg4)的话，AP将会重新传输Msg3。
* 客户端每次收到Msg3都会重新安装加密key，从而重置nonce和 replay counters 。而攻击者可以收集和重新发送四向交握中的 Msg3强制重置nonce，从而成功攻击加密协议，解密客户端发 送的封包，截获敏感信息。

![image-20220829165218159](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220829165218159.png)

防御方法

总而言之，提供一个临时解决方案，更改路由器的默认用户名、密码和SSID，打开防火墙，关闭SSID广播，为自己的用户设置单独的SSID，彻底关闭DHCP。

**项目地址：**

**https://github.com/vanhoefm/krackattacks-scripts**