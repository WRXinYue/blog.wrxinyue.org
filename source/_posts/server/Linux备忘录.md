---
title: Linux备忘录
date: 2022-10-17 23:59:52.0
updated: 2023-05-08 16:25:34
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

1.  **查看发行版和版本信息**：

有多个文件可以提供关于 Linux 发行版和版本的信息，这里列出了一些常见的文件：

-   `/etc/os-release`：提供发行版的详细信息，如名称、版本等。

bash

`cat /etc/os-release`

-   `/etc/*-release`：该命令可以显示发行版的信息。`*` 是通配符，表示可能的发行版名称，如 `centos-release`、`redhat-release`、`lsb-release` 等。

bash

`cat /etc/*-release`

2.  **查看内核版本和系统架构**：

使用 `uname` 命令可以查看内核版本、系统架构等详细信息。要查看所有可用信息，请使用 `-a`（all）选项：

bash

`uname -a`

要仅查看内核版本，请使用 `-r`（release）选项：

bash

`uname -r`

要仅查看系统架构，请使用 `-m`（machine）选项：

bash

`uname -m`

3.  **查看系统详细信息**：

`lsb_release` 命令提供了有关 Linux 标准基础（LSB）的信息。要查看所有可用信息，请使用 `-a`（all）选项：

bash

`lsb_release -a`

请注意，`lsb_release` 命令可能不是所有发行版的默认组件。如果尚未安装，请根据您的发行版使用相应的包管理器进行安装。

4.  **查看硬件信息**：

使用 `lshw` 命令可以查看系统硬件信息。为了获得更易于阅读的输出，可以使用 `-short` 选项：

bash

`sudo lshw -short`

请注意，`lshw` 命令可能不是所有发行版的默认组件。如果尚未安装，请根据您的发行版使用相应的包管理器进行安装。

通过使用这些命令，您可以查看 Linux 系统的详细信息，如发行版、版本、内核版本、硬件信息等。


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