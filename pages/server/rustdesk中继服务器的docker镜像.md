---
title: rustdesk中继服务器的docker镜像
categories:
 - 玩转服务器
tags:
 - ''
data: 2023-04-18 14:48:38
updated: 2023-04-18 14:49:11
---
1、docker 拉取镜像
```bash
docker image pull rustdesk/rustdesk-server
```
1
2、运行hbbs
```bash
docker run --name hbbs -p 21115:21115 -p 21116:21116 -p 21116:21116/udp -p 21118:21118 -v `pwd`:/root -it --net=host --rm rustdesk/rustdesk-server hbbs -r 自己的服务器IP
```

3、运行hbbr
```bash
docker run --name hbbr -p 21117:21117 -p 21119:21119 -v `pwd`:/root -it --net=host --rm rustdesk/rustdesk-server hbbr
```

4、配置防火墙与安全组
TCP(21115, 21116, 21117, 21118, 21119)
UDP(21116)
网页客户端（21118，21119），对应端口可以不开。
