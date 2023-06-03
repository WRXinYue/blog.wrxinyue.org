---
title: Linux备忘录
date: 2022-10-17 23:59:52.0
updated: 2023-05-29 01:02:45
url: /archives/linux-bei-wang-lu
categories: 
- Linux
tags: 
- linux
---
### 安装命令

~~~shell
    -bash: ar: command not found
     
    #Debian
    apt-get install binutils-aarch64-linux-gnu
     
    #Ubuntu
    apt-get install binutils-aarch64-linux-gnu
     
    #Arch Linux
    pacman -S binutils-aarch64-linux-gnu
     
    #Kali Linux
    apt-get install binutils-aarch64-linux-gnu
     
    #CentOS
    yum install binutils-aarch64-linux-gnu
     
    #Fedora
    dnf install binutils-aarch64-linux-gnu
     
    #Raspbian
    apt-get install binutils-aarch64-linux-gnu
~~~


## VI编辑器

vi保存命令。

> 按ESC键 跳到命令模式，然后：
>
> :w 保存文件但不退出vi
>
> :w file 将修改另外保存到file中，不退出vi
>
> :w! 强制保存，不推出vi
>
> :wq 保存文件并退出vi
>
> :wq! 强制保存文件，并退出vi
>
> q: 不保存文件，退出vi
>
> :q! 不保存文件，强制退出vi
>
> :e! 放弃所有修改，从上次保存文件开始再编辑。


## Docker

安装：

```bash
curl -fsSL https://get.docker.com -o get-docker.sh  
sudo sh get-docker.sh
```

国内镜像:
```cpp
curl -sSL http://acs-public-mirror.oss-cn-hangzhou.aliyuncs.com/docker-engine/internet | sh -
```

**查看发行版和版本**：

-   `cat /etc/os-release`
-   `cat /etc/*-release`

2.  **查看内核版本和系统架构**：
    -   `uname -a` (全部信息)
    -   `uname -r` (内核版本)
    -   `uname -m` (系统架构)
3.  **查看系统详细信息**：
    -   `lsb_release -a` (可能需安装)
4.  **查看硬件信息**：
    -   `sudo lshw -short` (可能需安装)

## 查看正在运行的容器

~~~shell
docker ps
~~~

包括停止的：
~~~shell
docker ps -a
~~~

## 进入容器

~~~shell
docker exec -it 容器ID /bin/bash
~~~

**alpine:**

~~~shell
docker exec -it 容器ID /bin/sh
~~~
>注：docker attach指令已经过时


## Mysql of Dokcer
~~~shell
docker run -p 3306:3306 --name mysql \
-v /mydata/mysql/log:/vat/log/mysql \
-v /mydata/mysql/data:/var/lib/mysql \
-v /mydata/mysql/conf:/etc/mysql/conf.d \
-e MYSQL_ROOT_PASSWORD=root \
-d mysql:5.7
~~~
  
### Mysql 配置文件
~~~shell
[clinet]
default-character-set=utf8
  
[mysql]
default-character-set=utf8

[mysqld]
init_connect='SET collation_connection = utf8_unicode_ci'
init_connect='SET NAMES utf8'
character-set-server=utf8
collation-server=utf8_unicode_ci
skip-character-set-client-handshake
skip-name-resolvnet
~~~


## Redis

### Redis of Docker
~~~shell
mkdir -p /mydata/redis/conf && touch /mydata/redis/confredis.conf
~~~

~~~shell
docker run -p 6379:6379 --name redis -v /mydata/redis/data:/data \
-v /mydata/redis/conf/redis.conf:/etc/redis/redis.conf \
-d redis redis-server /etc/redis/redis.conf
~~~


## 清屏

**解决乱码问题：**
```bash
reset
```


## 下载仓库
官方的死蛇（deadsnake）仓库，这是一个流行的第三方Python仓库：

```
sudo add-apt-repository ppa:deadsnakes/ppa
```

更新系统包列表：

```
sudo apt-get update
```