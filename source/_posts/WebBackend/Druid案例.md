---
title: Druid案例
date: 2022-12-06 11:42:16.916
updated: 2023-04-18 14:52:08
categories: 
- WEBbackend
tags: 
- mysql
- java
---

Druid（德鲁伊）是由阿里巴巴开发，集合了c3p0、dbcp、proxool等连接池的优点，加入了日志监控，有效的监控DB池连接和SQL的执行情况

## 配置文件

~~~properties
# druid.properties文件的配置
driverClassName=com.mysql.cj.jdbc.Driver
url=jdbc:mysql://127.0.0.1:3306/mysql
username=root
password=
# 初始化连接数量
initialSize=5
# 最大连接数
maxActive=10
# 最大超时时间
maxWait=3000
~~~

## 实例

~~~mysql
USE sql2_wyg;
DROP TABLE IF EXISTS tb_brand;

CREATE TABLE tb_brand (
  -- id 主键
  id INT PRIMARY KEY AUTO_INCREMENT,
  -- 品牌名称
  brand_name VARCHAR(20),
  -- 企业名称
  company_name VARCHAR(20),
  -- 排序字段
  ordered INT,
	-- 描述信息
  description varchar(100),
  -- 状态:0 禁用，1 启用
  status int
);

INSERT INTO tb_brand (
	brand_name,
	company_name,
	ordered,
	description,
	`status`)
VALUES
	('三只松鼠', '三只松鼠股份有限公司', 5, '好吃不上火', 0),
	('华为', '华为技术有限公司', 100, '华为致力于把数字世界带入每个人、每个家庭、每个组织，构建万物互联的智能世界', 1),
	('小米', '小米科技有限公司', 50, 'are you ok', 1);
	
SELECT * FROM tb_brand;
~~~



~~~java
package com.itheima.example;

import com.alibaba.druid.pool.DruidDataSourceFactory;
import com.itheima.pojo.Brand;
import org.junit.Test;

import javax.sql.DataSource;
import java.io.FileInputStream;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;
import java.util.Properties;

public class BrandTest {

    @Test
    public void testSelectAll() throws  Exception{
        //1. 获取Connection
        // 加载配置文件
        Properties prop = new Properties();
        prop.load(new FileInputStream(System.getProperty("user.dir") + "/src/druid.properties"));
        // 获取连接池对象
        DataSource dataSource = DruidDataSourceFactory.createDataSource(prop);
        // 获取数据库连接 Connection
        Connection conn = dataSource.getConnection();
        // 定义SQL
        String sql = "SELECT * FROM tb_brand";
        // 获取pstmt对象，使用prepareStatement，防止sql注入
        PreparedStatement pstmt = conn.prepareStatement(sql);
        // 设置参数
        // 执行SQL
        ResultSet rs = pstmt.executeQuery();
        // 处理结果 List<Brand> 封装Brand对象,装载List集合
        Brand brand = null;
        List<Brand> brands = new ArrayList<>();
        while (rs.next()){
            // 获取数据
            int id = rs.getInt("id");
            String brandName = rs.getString("brand_name");
            String companyName = rs.getString("company_name");
            int ordered = rs.getInt("ordered");
            String description = rs.getString("description");
            int status = rs.getInt("status");
            // 封装Brand对象
            brand = new Brand();
            brand.setId(id);
            brand.setBrandName(brandName);
            brand.setCompanyName(companyName);
            brand.setOrdered(ordered);
            brand.setDescription(description);
            brand.setStatus(status);
            // 装载集合
            brands.add(brand);
        }
        System.out.println(brands);
        // 资源释放
        rs.close();
        pstmt.close();
        conn.close();
    }

    @Test
    public void testAdd() throws  Exception {
        // 接收页面提交的参数
        String brandName = "香飘飘";
        String companyName = "香飘飘";
        int ordered = 1;
        String description = "绕地球一圈";
        int status = 1;
        //1. 获取Connection
        // 加载配置文件
        Properties prop = new Properties();
        prop.load(new FileInputStream(System.getProperty("user.dir") + "/src/druid.properties"));
        // 获取连接池对象
        DataSource dataSource = DruidDataSourceFactory.createDataSource(prop);
        // 获取数据库连接 Connection
        Connection conn = dataSource.getConnection();
        // 定义SQL
        String sql = "INSERT INTO tb_brand(brand_name, company_name, ordered, description, status) VALUES(?,?,?,?,?)";
        // 获取pstmt对象，使用prepareStatement，防止sql注入
        PreparedStatement pstmt = conn.prepareStatement(sql);
        // 设置参数
        pstmt.setString(1, brandName);
        pstmt.setString(2, companyName);
        pstmt.setInt(3, ordered);
        pstmt.setString(4, description);
        pstmt.setInt(5, status);
        // 执行SQL
        int count = pstmt.executeUpdate();//影响的行数
        // 处理结果
        System.out.println(count > 0);
        // 资源释放
        pstmt.close();
        conn.close();
    }

    @Test
    public void testUpdate() throws  Exception {
        // 接收页面提交的参数
        String brandName = "香飘飘";
        String companyName = "香飘飘";
        int ordered = 1000;
        String description = "绕地球三圈";
        int status = 1;
        int id = 4;
        //1. 获取Connection
        // 加载配置文件
        Properties prop = new Properties();
        prop.load(new FileInputStream(System.getProperty("user.dir") + "/src/druid.properties"));
        // 获取连接池对象
        DataSource dataSource = DruidDataSourceFactory.createDataSource(prop);
        // 获取数据库连接 Connection
        Connection conn = dataSource.getConnection();
        // 定义SQL
        String sql = "UPDATE tb_brand\n" +
                "SET\n" +
                "\tbrand_name = ?,\n" +
                "\tcompany_name = ?,\n" +
                "\tordered = ?,\n" +
                "\tdescription = ?, \n" +
                "\t`status` = ?\n" +
                "WHERE id = ?;";
        // 获取pstmt对象，使用prepareStatement，防止sql注入
        PreparedStatement pstmt = conn.prepareStatement(sql);
        // 设置参数
        pstmt.setString(1, brandName);
        pstmt.setString(2, companyName);
        pstmt.setInt(3, ordered);
        pstmt.setString(4, description);
        pstmt.setInt(5, status);
        pstmt.setInt(4, id);
        // 执行SQL
        int count = pstmt.executeUpdate();//影响的行数
        // 处理结果
        System.out.println(count > 0);
        // 资源释放
        pstmt.close();
        conn.close();
    }

    @Test
    public void testDeleteById() throws  Exception {
        // 接收页面提交的参数
        int id = 4;
        //1. 获取Connection
        // 加载配置文件
        Properties prop = new Properties();
        prop.load(new FileInputStream(System.getProperty("user.dir") + "/src/druid.properties"));
        // 获取连接池对象
        DataSource dataSource = DruidDataSourceFactory.createDataSource(prop);
        // 获取数据库连接 Connection
        Connection conn = dataSource.getConnection();
        // 定义SQL
        String sql = "DELETE FROM tb_brand WHERE id = ?";
        // 获取pstmt对象，使用prepareStatement，防止sql注入
        PreparedStatement pstmt = conn.prepareStatement(sql);
        // 设置参数
        pstmt.setInt(1, id);
        // 执行SQL
        int count = pstmt.executeUpdate();//影响的行数
        // 处理结果
        System.out.println(count > 0);
        // 资源释放
        pstmt.close();
        conn.close();
    }
}
~~~

