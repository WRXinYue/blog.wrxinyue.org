---
title: 防火墙
categories:
 - server
tags:
 - linux
data: 2023-05-10 23:39:15
updated: 2023-05-10 23:39:15
---

版本查看：
```bash
iptables --version
```

安装：
```bash
sudo apt-get update
sudo apt-get install iptables
```

当前的规则:
```bash
sudo iptables -L -n -v
```

`-L` 选项表示 "list"（列出），`-n` 选项表示 "numeric"（不要解析和显示主机名、网络名和端口名），而 `-v` 选项表示 "verbose"（显示详细信息）