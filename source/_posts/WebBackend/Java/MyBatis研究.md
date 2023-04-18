---
title: MyBatis
date: 2023-01-13 10:32:48
tags:
 - MyBatis
 - Java
updated: 2023-04-18 15:09:43
---



## Preface

记录知识是一个重要的习惯，尤其是对于一个技术框架来说，Mybatis虽然简单易用，但是为了更好地理解其基本概念和原理，我决定在2023年1月13日开始编写这篇笔记。这将不仅仅是使用API字典。在导师（项目经理）的指导下，我将自己的理解与导师的讲解相结合，当然我也References(借鉴)了网上一些优秀的文章，这样做不仅有助于我自己未来复习回顾，同时也希望对阅读这篇文章的人有所帮助。

## Synopsis

MyBatis是一个开源、轻量级的持久层框架，它内部封装了JDBC，可以简化JDBC加载驱动、创建连接、创建statement等繁杂过程，使开发人员更专注于SQL语句本身。

> PS：MyBatis不是专门用于ORM映射，而是为了简化和优化JDBC操作而设计的，所以严格意义上来讲，**MyBatis不是ORM框架**。

**总结要点：**

* MyBatis是一款优秀的持久层框架，主要通过XML或注解来配置和映射原始类型、接口和Java POJO（Plain Old Java Objects，普通老式Java对象）为数据库中的记录。它支持自定义SQL、存储过程以及高级映射，可以在实体类和SQL语句之间建立映射关系。
* MyBatis减少了大量的JDBC代码、设置参数和获取结果集的重复工作。并且连接池是可选的，默认使用的是PooledDataSource（Apache commons DBCP）连接池。
* MyBatis不同于Hibernate等全自动化ORM框架，它更多的是手动编写SQL，用来满足在追求性能和灵活性的同时对于开发者更好的掌握数据库操作。

> ORM (Object Relational Mapping，对象关系映射) 是一种数据持久化技术，它在对象模型和关系型数据库之间建立起对应关系。ORM提供了一种机制，通过JavaBean对象去操作数据库表中的数据。 这样就可以避免编写大量的SQL语句和JDBC代码，提高开发效率。
>
> 常见的ORM框架有：[Hibernate](https://stackshare.io/hibernate)、[Entity Framework](https://stackshare.io/entity-framework)、[SQLAlchemy](https://stackshare.io/sqlalchemy)、[Sequelize](https://stackshare.io/sequelize)

## 构建方式

### 普通构建：

Mybatis安装方式有很多种，其中最简单一种就是直接下载MyBatis的jar包，然后导入到项目中。

* **下载MyBatis jar包：**可以从[MyBatis官网](http://mybatis.org)或者[Github](https://github.com/mybatis/mybatis-3/releases)上下载最新版本的jar包。
* **将jar包导入到项目中：**将下载下来的jar包文件导入到项目中即可。

### maven构建：

使用[maven](https://mvnrepository.com/)构建时，可以通过在pom.xml文件上添加下面的代码来添加MyBatis的依赖。需要注意的是，version应该填写最新版本号。

~~~xml
<dependency>
    <groupId>org.mybatis</groupId>
    <artifactId>mybatis</artifactId>
    <version>x.x.x</version>
</dependency>
~~~

## MyBatis文件目录结构

这是常用的目录结构，但是和Maven项目的目录结构会有所不同。

![image-20230113152144935](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230113152144935.png)

* dao：数据访问对象。用于存放与数据库交互的类，负责数据访问层的实现。
* factory：工厂。用于存放工厂类，这些类用于创建其他对象。
* mapper：映射器。用于存放于数据库表之间的映射关系。
* model：模型。用于存放项目中的实体类，这些类用于表示数据库中的表。
* test：测试。用于存放单元测试代码。

## 主配置文件

![image-20230115190035491](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230115190035491.png)

* `<configuration>`是**配置**文件的根标签，里面包含了Mybatis的各种配置信息。
* `<properties>`标签用于配置Mybatis使用的**属性**文件。
* `<settings>`标签用于配置Mybatis的运行时**设置**。
* `<typeAliases>`标签用于配置**类型别名**。
* `<typeHandlers>`标签用于配置**类型处理器**。
* <u>`<objectFactory>`标签用于配置**对象工厂**。</u>
* <u>`<plugins>`标签用于配置**插件**。</u>
* `<environments>`标签用于配置环境变量(**环境配置**)，里面包含`<environment>`标签。
* `<environment>`标签用于配置单个**环境变量**，里面包含:
  * `<transactionManager>`用于配置**事物管理器**。
  * `<dataSource>`用于配置**数据源**。
* <u>`<databaseIdProvider>`标签用于配置**数据库厂商标识**。</u>
* `<mappers>`标签用于配置**映射器**。

> PS：除了这些重要标签，还有其他标签可用。具体方式可参考[MyBatis官方文档](https://mybatis.net.cn/configuration.html)。阅读官方文档是一个非常高效的学习方式。

## 公共类

* 构建sqlSessionFactory
* 打开sqlSession会话，并执行sql

![image-20230115190026118](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230115190026118.png)

~~~java
public class MybatisTest {
   public static void main(String[] args) throws Exception {
      // 指定全局配置文件
      String resource = "mybatis-config.xml";
      // 读取配置文件
      InputStream inputStream = Resources.getResourceAsStream(resource);
      // 构建sqlSessionFactory
      SqlSessionFactory sqlSessionFactory = new SqlSessionFactoryBuilder().build(inputStream);
      // 获取sqlSession
      SqlSession sqlSession = sqlSessionFactory.openSession();
      try {
         // 操作CRUD，第一个参数：指定statement，规则：命名空间+“.”+statementId
         // 第二个参数：指定传入sql的参数：这里是用户id
         User user = sqlSession.selectOne("MyMapper.selectUser", 1);
         System.out.println(user);
      } finally {
         sqlSession.close();
      }
   }
}
~~~

## Mapper.xml

![image-20230115190017708](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230115190017708.png)

~~~xml
<?xml version="1.0" encoding="UTF-8" ?>
<!DOCTYPE mapper
  PUBLIC "-//mybatis.org//DTD Mapper 3.0//EN"
  "http://mybatis.org/dtd/mybatis-3-mapper.dtd">
<!-- mapper:根标签，namespace：命名空间，随便写，一般保证命名空间唯一 -->
<mapper namespace="MyMapper">
   <!-- statement，内容：sql语句。id：唯一标识，随便写，在同一个命名空间下保持唯一
      resultType：sql语句查询结果集的封装类型,tb_user即为数据库中的表
    -->
   <select id="selectUser" resultType="com.zpc.mybatis.User">
      select * from tb_user where id = #{id}
   </select>
</mapper>
~~~

## 执行

![image-20230115190007814](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230115190007814.png)

![image-20230115190002784](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230115190002784.png)

## 查询多条数据

![image-20230115185950761](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230115185950761.png)

## 插入修改删除

![image-20230115185923512](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230115185923512.png)

## 动态SQL语句

![image-20230115193252619](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230115193252619.png)

## 多表连接-一对多

![image-20230115185844380](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230115185844380.png)

## 多表连接-一对一

![image-20230115185826453](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230115185826453.png)

## 多表连接-动态SQL

![image-20230115185819470](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230115185819470.png)

## 注解开发

![image-20230115185812232](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230115185812232.png)



## Conclusion

## References

[1] [MyBatis 全网最通俗易懂的教程（2020年、非常详细） - B站狂神MyBatis](https://blog.csdn.net/wanglei19891210/article/details/105653841)

[2] [Mybatis - C语言中文网](http://c.biancheng.net/mybatis/)

[3] [MyBatis 教程 - 蝴蝶教程](https://www.jc2182.com/mybatis/mybatis-jiaocheng.html)

[4] [MYBATIS 教程 - 奇客谷教程 💯](https://www.qikegu.com/docs/1868)

[5] [MyBatis中文网](https://mybatis.net.cn/)
