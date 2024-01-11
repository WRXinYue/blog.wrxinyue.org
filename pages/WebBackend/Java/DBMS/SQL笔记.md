---
title: SQL笔记
date: 2022-09-14 01:38:43.0
updated: 2023-04-18 18:02:52
categories: 
- WEBbackend
tags: 
- sql
---

# SQL简介

* 英文：Structured Query Language，简称SQL
* 结构化查询语言，一门操作关系型数据库的编程语言
* 定义操作所有关系型数据库的统一标准
* 对于同一个需求，每一种数据库操作的方式可能会存在一些不一样的地方，我们称为“方言”

# SQL通用语法

1. SQL语句可以单行或多行书写，以分号结尾。
2. MySQL数据库的SQL语句不区分大小写，关键字建议使用大写。
3. 注释
   1. 单行注释：-- 注释内容 或 # 注释内容（MySQL 特有）
   2. 多行注释：/* 注释 */

# SQL分类

* DDL(Data Definition Language)数据定义语言，用来定义数据库对象：数据库，表，列等
* DML(Data Manipulation Language)数据操作语言，用来对数据库中表的数据进行增删改
* DQL(Data Query Language)数据查询语言，用来查询数据库中表的记录（数据）
* DCL(Data Control Language)数据控制语言，用来定义数据库的访问权限和安全级别，及创建用户

## DDL

### 操作数据库

1. 查询

   ~~~sql
   SHOW DATABASES;
   ~~~

2. 创建

   * 创建数据库

     ~~~sql
     CREATE DATABASE 数据库名称;
     ~~~

   * 创建数据库（判断，如果不存在则创建）

     ~~~sql
     CREATE DATABASE IF NOT EXISTS 数据库名称;
     ~~~

3. 删除

   * 删除数据库

     ~~~sql
     DROP DATABASE 数据库名称;
     ~~~

   * 删除数据库（判断，如果存在则删除）

     ~~~sql
     DROP DATABASE IF EXISTS 数据库名称;
     ~~~

4. 使用数据库

   * 查看当前使用的数据库

     ~~~sql
     SELECT DATABASE();
     ~~~

   * 使用数据库

     ~~~sql
     USE 数据库名称;
     ~~~

### 操作表

**创建表**

~~~sql
CREATE TABLE 表名 (
    字段名1	数据类型1，
    字段名2	数据类型2，
    ...
    字段名n	数据类型n 
);
~~~

注意：最后一行末尾，不能加逗号

![image-20220913010304876](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220913010304876.png)



**数据类型**

* MySQL支持多种类型，可以分为三类：

  * 数值
  * 日期
  * 字符串

  ![image-20220913011509894](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220913011509894.png)

  ![image-20220913012335633](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220913012335633.png)

**查询表**

* 查询当前数据库下所有表名称

  ~~~sql
  SHOW TABLES;
  ~~~

* 查询表结构

  ~~~sql
   DESC 表名称;
  ~~~

**修改表**

1. 修改表名

   ~~~sql
   ALTER TABLE 表名 RENAME TO 新的表名;
   ~~~

2. 添加一列

   ~~~sql
   ALTER TABLE 表名 ADD 列名 数据类型;
   ~~~

3. 修改数据类型

   ~~~sql
   ALTER TABLE 表名 MODIFY 列名 新数据类型;
   ~~~

4. 修改列名和数据类型

   ~~~sql
   ALTER TABLE 表名 CHANGE 列名 新列名 新数据类型;
   ~~~

5. 删除列

   ~~~sql
   ALTER TABLE 表名 DROP 列名;
   ~~~

   

**删除表**

1. 删除表

   ~~~sql
   DROP TABLE 表名;
   ~~~

2. 删除表时判断表是否存在

   ~~~sql
   DROP TABLE IF EXISTS 表名;
   ~~~

   

## DML

### **添加数据**

1. 给指定列添加数据

   ~~~sql
   INSERT INTO 表名(列名1,列名2,...) VALUES(值1，值2，...);
   ~~~

2. 给全部列添加数据

   ~~~sql
   INSERT INTO 表名 VALUES(值1,值2,...);
   ~~~

3. 批量添加数据

   ~~~sql
   INSERT INTO 表名(列名1,列名2,...) VALUES(值 1,值2,...);
   ~~~

   ~~~sql
   INSERT INTO 表名 VALUES (值1,值2,...),(值1,值2,...),(值1,值2,...)...;
   ~~~

### **修改数据**

1. 修改表数据

   ~~~sql
   UPDATE 表名 SET 列名1=值1,列名2=值2,... [WHERE 条件];
   ~~~

   **注意：修改语句中如果不加条件，则将所有数据都修改！**

### **删除数据**

1. 删除数据

   ~~~sql
   DELETE FROM 表名 WHERE 条件;
   ~~~

   **注意：删除语句中如果不加条件，则将所有数据都删除！**

## DQL

### 查询语法

~~~sql
SELECT
	字段列表
FROM
	表名列表
WHERE
	条件列表
GROUP BY
	分组字段
HAVING
	分组后条件
ORDER BY
	排序字段
LIMIT
	分页限定
~~~

### 基础查询

1. 查询多个字段

   ~~~sql
   SELECT 字段列表 FROM 表名;
   SELECT * FROM 表名; -- 查询所有数据
   ~~~

2. 去除重复记录

   ~~~sql
   SELECT DISTINCT 字段列表 FROM 表名;
   ~~~

3. 起别名

   ~~~sql
   AS: AS 也可以省略
   ~~~



### 条件查询(WHERE)

1. 条件查询语法

   ~~~sql
   SELECT 字段列表 FROM 表名 WHERE 条件列表;
   ~~~

   

### 排序查询(ORDER BY)

1. 排序查询语法

   ~~~SQL
   SELECT 字段列表 FROM 表名 ORDER BY 排序字段名1 [排序方式1],排序字段名2 [排序方式2] ...;
   ~~~

   排序方式：

   * ASC：升序排序（默认值）
   * DESC：降序排列

   **注意：如果有多个排序条件，当前边的条件值一样时，才会根据第二条件进行排序**

   

### 聚合函数

1. 概念：

   将一列数据作为一个整体，进行纵向计算。

2. 聚合函数分类

   ![image-20220914011932454](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220914011932454.png)

3. 聚合函数语法：

   ~~~sql
   SELECT 聚合函数名(列名) FROM 表;
   ~~~

   **注意：null值不参与所有聚合函数运算**

### 分组查询(GROUP BY)

1. 分组查询语法

   ~~~sql
   SELECT 字段列表 FROM 表名 [WHERE 分组前条件限定] GROUP BY 分组字段名 [HAVING 分组后条件过滤];
   ~~~

   **注意：分组之后，查询的字段为聚合函数和分组字段，查询其他字段无任何意义**

   where和having区别：

   * 执行时机不一样：where是分组之前进行限定，不满足where条件，则不参与分组，而having是分组之后对结果进行过滤

   * 可判断的条件不一样：where不能对聚合函数进行判断，having可以

     

     执行顺序：where>聚合函数>having

     

### 分页查询(LIMIT)

1. 分页查询语法

   ~~~sql
   SELECT 字段列表 FROM 表名 LIMIT 起始索引 , 查询条目;
   ~~~

* 起始索引：从0开始

  

  **计算公式：起始索引 = (当前页码-1) * 每页显示的条数**

  tips:

  * 分页查询limit是MySQL数据库的方言
  * Oracle分页查询使用rownumber
  * SQL Server分页查询使用top