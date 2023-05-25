---
title: Python虚拟环境创建
categories:
 - Python
tags:
 - Python
data: 2023-05-24 22:21:06
updated: 2023-05-25 19:20:21
---

## Python 虚拟环境

在这种情况下，您可以尝试在主系统上安装一个全局的 Python 虚拟环境，而不是使用 Anaconda。首先退出当前的Anaconda环境：

```bash
conda deactivate
```

然后确保您已经安装了Python及其包管理工具`pip`和虚拟环境创建工具`virtualenv`。可以使用以下命令安装：

```bash
sudo apt-get install python3 python3-pip python3-venv
```

创建一个新的虚拟环境，并将其命名为`django-RESTfulAPI`：

```bash
python3 -m venv django-RESTfulAPI
```

激活新的虚拟环境：

```bash
source django-RESTfulAPI/bin/activate
```

安装完成后，您可以继续使用这个虚拟环境进行项目开发。如果您要退出虚拟环境，请使用以下命令：

```bash
deactivate
```

## 未整理

```bash
pip3 install virtualen
````

**缺少库：**
```bash
apt-get install python3.4-dev python3.4-venv
```