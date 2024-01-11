---
title: DNS记录类型
categories:
 - server
tags:
 - DNS
data: 2023-05-10 19:18:14
updated: 2023-05-10 19:18:14
---

1.  `A` 记录（Address Record）：将一个域名映射到一个IPv4地址。
    
2.  `AAAA` 记录（Quad A Record）：将一个域名映射到一个IPv6地址。与A记录类似，只是它们适用于IPv6地址而不是IPv4地址。
    
3.  `CNAME` 记录（Canonical Name Record）：将一个域名映射到另一个域名。它允许你创建别名，指向其他的DNS记录。
    
4.  `MX` 记录（Mail Exchange Record）：定义用于处理电子邮件的服务器。当你发送一封邮件到一个域名时，MX记录告诉邮件服务器应该向哪个服务器发送邮件。
    
5.  `TXT` 记录（Text Record）：提供关于域名的任何文本信息。这种类型的记录经常被用于各种目的，包括SPF记录（用于防止垃圾邮件）和域名验证（例如，Google的网站所有权验证）。
    
6.  `SPF` 记录（Sender Policy Framework Record）：用来防止垃圾邮件。它指定了哪些邮件服务器被允许发送你的域名的邮件。
    
7.  `SRV` 记录（Service Record）：定义提供特定服务的服务器。例如，SRV记录可以用来指定用于音频和视频通话的服务器。
    
8.  `CAA` 记录（Certification Authority Authorization Record）：指定哪些证书颁发机构（CA）被允许为一个域名颁发SSL/TLS证书。