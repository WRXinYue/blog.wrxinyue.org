---
title: Python虚拟环境创建
categories:
 - Python
tags:
 - Python
data: 2023-05-24 22:21:06
updated: 2023-08-25 13:43:54
---

## Python 虚拟环境

**创建虚拟环境:**

```bash
python3 -m venv venv
```

**激活新的虚拟环境：**

```bash
# windows
.\venv\Scripts\activate
# linux
source venv/bin/activate
```


安装完成后，您可以继续使用这个虚拟环境进行项目开发。如果您要退出虚拟环境，请使用以下命令：

```bash
deactivate
```

## 大坑

* 在virtualenv中不要加sudo安装pip包

## 其他

退出当前的Anaconda环境：

```bash
conda deactivate
```

**线程性能测试：**
```bash
sysbench cpu --threads=8 --time=0 run
```

### 添加代理

```bash
$env:http_proxy = "http://proxy.example.com:port"
$env:https_proxy = "http://proxy.example.com:port"
```

### [Ubuntu 18.04 中 sudo apt update 的问题：如果 /usr/bin/test -w /var/lib/command-not-found/ 调用成功后](https://askubuntu.com/questions/1041226/problem-with-sudo-apt-update-in-ubuntu-18-04-post-invoke-success-if-usr-bin-te)