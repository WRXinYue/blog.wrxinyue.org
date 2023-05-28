---
title: Python虚拟环境创建
categories:
 - Python
tags:
 - Python
data: 2023-05-24 22:21:06
updated: 2023-05-27 14:07:03
---

## Python 虚拟环境

```bash
pip3 install virtualenv
````

或者：
```bash
sudo apt install python-virtualenv
```

```bash
virtualenv --python=/usr/bin/python3.4 venv
```

**虚拟环境安装：**
```bash
sudo apt install python3.8-dev python3.8-venv
```

```bash
apt-cache show python3.8-dev
apt-cache show python3.8-venv
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

## django

我认为使用 django 的最好方法是使用 virtualenv，它是安全的，你可以在 virtualenv 中安装许多应用程序，这不会影响系统的任何外部空间 vitualenv 使用默认版本的 python，这与你的系统中安装 virtualenv 的相同

```
pip install virtualenv
```

或者对于 python3

```
pip3 install virtualenv
```

然后在你的目录中

> mkdir ~/新项目
> 
> cd ~/新项目

现在，通过键入在项目目录中创建一个虚拟环境

```undefined
virtualenv newenv
```

要将软件包安装到隔离环境中，您必须通过键入以下内容来激活它：

```bash
source newenv/bin/activate
```

现在在这里安装

```undefined
pip install django
```

您可以通过键入以下内容来验证安装：

```css
django-admin --version
```

要离开虚拟环境，您需要从系统的任何位置发出 deactivate 命令：

```undefined
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

### [Ubuntu 18.04 中 sudo apt update 的问题：如果 /usr/bin/test -w /var/lib/command-not-found/ 调用成功后](https://askubuntu.com/questions/1041226/problem-with-sudo-apt-update-in-ubuntu-18-04-post-invoke-success-if-usr-bin-te)