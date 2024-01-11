---
title: Python  orm 连接MySQL数据库
categories:
 - Python
tags:
 - Python
 - mysql
data: 2023-05-21 19:04:18
updated: 2023-05-22 13:44:30
---

## 安装第三方模块
```python
pip install mysqlclient
```

## ORM
ORM可以帮助我们做两件事
* 创建、修改、删除数据库中的表。 (不用创建数据库)
* 操作表中的数据 (不用写SQL语句)

## django连接数据库
在settings.py文件中配置和修改

**生成数据库同步脚本：**
```bash
python manage.py makemigrations
```

**迁移处理表：**
```bash
python manage.py migrate
```


## 依赖安装

```bash
pip install -r requirements.txt
```