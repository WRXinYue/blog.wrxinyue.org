---
title: Windows本地MySQL安装
date: 2022-09-11 20:09:59.0
updated: 2022-10-27 10:17:50.405
url: /archives/windows-ben-de-mysql-an-zhuang
categories: 
- WEBbackend
tags: 
- mysql
---

# Windows本地MySQL安装

## 下载

[下载地址](https://downloads.mysql.com/archives/community/)

选择MySQL版本，以及计算机系统

这里选择5.7.24，比较稳定

![image-20220911200302681](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220911200302681.png)

## 安装(解压)

解压到安装目录

![image-20220911200540524](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220911200540524.png)

## 配置

### 添加环境配置

复制你MySQL的路径，变量名填MYSQL_HOME

![image-20220911194052552](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220911194052552.png)

在系统变量，Path里添加：

~~~
%MYSQL_HOME%\bin
~~~

![image-20220911194115687](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220911194115687.png)

### 新建配置文件

在\mysql-5.7.24-winx64\bin 目录下新建my.ini文本文件

![image-20220911193825969](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220911193825969.png)

右键记事本打开，内容如下：

~~~ini
[mysqld]
default-character-set=utf8

[mysqld]
character-set-server=utf8
default-storage-engine=INNODB
sql_mode=STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION
~~~

![image-20220911193927177](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220911193927177.png)

### 初始化MySQl

~~~
mysqld --initialize-insecure
~~~

![image-20220911193621195](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220911193621195.png)

### 注册MySQL服务

~~~
mysqld -install
~~~

![image-20220911193635151](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220911193635151.png)

### 启动MySQL服务

~~~
net start mysql
~~~

![image-20220911193646805](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220911193646805.png)

停止mysql服务：

~~~
net stop mysql
~~~

### 修改账户默认密码

~~~
mysqladmin -u root password 1234
~~~

![image-20220911194932794](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220911194932794.png)

### 登录MySQL

出现下午左下角为`mysql>`，则登录成功。

~~~
mysql -uroot -p1234
~~~

![image-20220911195448641](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220911195448641.png)

**到这里你就可以开始你的MySQL之旅了！**

退出mysql：

~~~
exit
quit
~~~

登录参数：

~~~
mysql -u用户名 -p密码 -h要连接的mysql服务器的ip地址(默认127.0.0.1) -P端口号(默认3306)
~~~

## 卸载MySQL

~~~
net stop mysql
~~~

~~~
mysqld -remove mysql
~~~

最后删除MySQL目录以及相关的环境变量