---
title: Linux备忘录
date: 2022-10-17 23:59:52.0
updated: 2023-04-19 18:36:24
url: /archives/linux-bei-wang-lu
categories: 
- Linux
tags: 
- linux
---

# 常用命令

## 解压

### deb包

进入到tools根目录下的终端，输入下面命令创建文件夹extract，并在extract文件夹下创建DEBIAN文件夹

~~~shell
mkdir -p extract/DEBIAN
~~~

将deb包解压到extract文件夹下

~~~shell
dpkg -X ./xxx.deb extract
~~~



dpkg解压：

~~~shell
dpkg -X ../openssh-client_6.1p1_i386.deb extract/
~~~



ar解压：

~~~shell
ar -x fileName.deb
tar -zxvf data.tar.gz
~~~



### ar 命令安装

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



## 下载

~~~
wget
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

# 查询指令

## 查看框架版本

~~~shell
node -e "console.log(process.arch)"
~~~

- x32: 386
- x64: amd64
- arm64: arm64
- arm: armv7

# 安装



## gcc和g++安装

gcc：C编译器

g++：C++编译器



**gcc版本检查：**

~~~shell
gcc -v
~~~

**g++版本检查：**

~~~shell
g++ -v
~~~



**gcc安装：**

~~~shell
yum install gcc
~~~

**g++安装：**

~~~shell
yum install gcc-c++ libstdc++-devel
~~~



切换root用户执行

~~~shell
yum install gcc -c++
~~~



## yarn安装

Node.js 自带名为 [npm](https://www.npmjs.com/) 的包管理器，我们可以直接使用它,[yarn](https://classic.yarnpkg.com/) 是功能非常强大的一个包管理器。



**安装yarn：**

~~~shell
npm i -g yarn
~~~

查看版本：

~~~shell
yarn -v
~~~



## git安装

git:分布式版本管理系统



安装：

~~~shell
yum install git -y
~~~


### 信息查看

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