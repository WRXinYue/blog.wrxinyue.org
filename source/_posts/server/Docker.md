---
title: Docker
categories:
 - server
tags:
 - ''
data: 2023-07-09 23:57:43
updated: 2023-07-09 23:57:43
---

## 克隆与运行

**克隆Ubuntu为例：**
~~~
docker commit c7b1021e0e3c ubuntu-tem

docker run --name my_container -d -p 8002:22 ubuntu-tem /usr/sbin/sshd -D
~~~