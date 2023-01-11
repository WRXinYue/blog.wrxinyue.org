---
title: MySQL笔记(office)
date: 2022-09-25 00:23:25.0
updated: 2022-10-27 10:17:01.184
categories: 
- WEBbackend
tags: 
- office
- mysql
---

# 数据库基本知识

## 数据库介绍

###  数据库概念

* 数据库（Database）是按照数据结构来组织、存储和管理数据的仓库

### 数据库的发展史

* 最早期以穿孔卡片的方式，按照一定的排列方式记录数据

### 数据库管理系统DBMS

* 是一种操作和管理数据库的大型软件，用于建立，使用和维护数据库，简称DBSN
* 它对数据库进行统一的管理和控制，以保证数据库的安全性和完整性
* 数据库管理系统是数据库的核心，是管理数据库的软件
* 我们一般说的数据库，就是DBMS，数据库管理系统

常见的数据库

* Oracle ：运行稳定，可移植性高，功能齐全，性能超群，适用于大型企业领域
* DB2：速度快，可靠性好，适用于海量数据，恢复性极强，适用于大中型企业领域
* Mysql：开源，体积小，速度快，适用于中小型企业领域
* SQL Server：全面，效率高，界面友好，操作容易，但是不跨平台，适用于中小型企业领域

## 专业术语

表：具有固定的列数和任意的行数

| Sno  | SNAME  | Sgender | Sheight |
| ---- | ------ | ------- | ------- |
| 1    | 小红   | 18      | 165     |
| 2    | 小兰   | 19      | 170     |
| 3    | 刘德华 | 25      | 179     |
| 4    | 刘能   | 20      | 173     |
| 5    | 赵四   | 30      | 166     |
| 6    | 谢大脚 | 27      | 171     |
| 7    | 王祖贤 | 22      | 169     |
| 8    | 郭靖   | 24      | 181     |
| 9    | 黄蓉   | 23      | 161     |
| 10   | 黄老师 | 43      | 175     |

* 列
  * 一个数据项Field字段
* 行
  * 一条记录row
* 数据库
  * 数据库是一些关联表的集合
* 主键
  * 主键是唯一的，一个数据表只能包含一个主键，可以使用主键来查询数据
* 外键
  * 外键用于关联两个表
* 索引
  * 使用索引可快速访问数据库表中的特定信息，索引是对数据库表中的一列或多列的值进行排序的一种结构，类似于书籍的目录。

## MySql数据库2022

### 9.22

~~~sql
#查询班级中所有学生
SELECT * FROM students;

#查询班级中所有男生
SELECT * FROM students WHERE stu_sex='男';

#建表的语句
CREATE TABLE teachers(
	t_id INT(255) NOT NULL PRIMARY KEY,
	t_name VARCHAR(255) NOT NULL,
	t_age INT(255) NOT NULL,
	t_sex VARCHAR(255) NOT NULL,
	t_height DOUBLE(255,2)
);

#添加一条教师信息
INSERT INTO teachers(t_id,t_name,t_sex,t_age,t_height)
VALUE(202201,"孔子","男",80,1.88);

INSERT INTO teachers(t_id,t_name,t_sex,t_age)
VALUE(202202,"墨子","男",70);

INSERT INTO teachers(t_id,t_name,t_sex,t_age,t_height)
VALUE(202203,"孟子","男",60,NULL);

INSERT INTO teachers VALUE(202204,"韩非子",77,"男",NULL);

#插入一条老师信息，姓名诸葛亮，男，34岁,1.89,教师编号202201 
INSERT INTO teachers(t_name,t_sex,t_age,t_height,t_id)
VALUE("诸葛亮","男",34,1.89,202205);

#插入一条老师信息，教师编号202202，庞统，男，33岁，身高不详 
INSERT INTO teachers(t_id,t_name,t_sex,t_age)
VALUE(202206,"庞统","男",33);

#添加三条学生记录 刘备，35，男，身高1.78，体重不详，编号202211
#编号202212，关羽，34，男，身高2.1，体重100kg
#编号202213，张飞，33，男，身高1.8，体重90kg
INSERT INTO students VALUES
(202211,"刘备",35,"男",1.78,NULL),
(202212,"关羽",34,"男",2.1,100),
(202213,"张飞",33,"男",1.8,90);
~~~

### 9.23

~~~sql
CREATE TABLE staff(
	sta_id INT(255) NOT NULL PRIMARY KEY,
	sta_name VARCHAR(255) NOT NULL,
	sta_department VARCHAR(255),
	sta_sex VARCHAR(255) NOT NULL,
	sta_age INT(255) NOT NULL,
	sta_salary DOUBLE(255,2) NOT NULL,
	sta_phone VARCHAR(255) NOT NULL,
	sta_marital VARCHAR(255)
);

#一次性录入三条员工信息：
#开发部的王建国，男，29岁，员工号201904，工资10k，18866667777，已婚；
#人事部的魏淑芬，女，29岁，至今未婚，员工号201702，13366669999，工资7.5k；
#测试部的夏雨荷，女，23岁，员工号202207，工资4k，15922223333，婚姻状况未知；
INSERT INTO staff(sta_name,sta_sex,sta_age,sta_id,sta_salary,sta_phone,sta_marital,sta_department) VALUES
("王建国","男",29,201904,10000,"18866667777","已婚","开发部"),
("魏淑芬","女",29,201702,7500,"13366669999","至今未婚","人事部"),
("夏雨荷","女",23,202207,4000,"13366669999","未知","测试部");

#录入一条员工信息：
#开发部吴邪，年龄22岁，男，员工号202220，工资2k，联系方式13155551111，未婚；
INSERT INTO staff(sta_name,sta_sex,sta_age,sta_id,sta_salary,sta_phone,sta_marital,sta_department) VALUE
("吴邪","男",22,202220,2000,"13155551111","未婚","开发部");

#把李四的身高更新为1.75
UPDATE students SET stu_height = 1.75 WHERE stu_name = "李四";

#把班级中所有学生的年龄加1岁
UPDATE students
SET stu_age = stu_age + 1;

#把李四年龄改为20，身高加2里面
UPDATE students SET stu_age = "20",stu_height = stu_height + 0.02 WHERE stu_name = "李四";

#删除小红的全部信息
DELETE FROM students WHERE stu_name = "小红";

#查询出班级中年龄20岁以下，身高1.65以上的女生姓名，年龄，身高
SELECT stu_name,stu_age,stu_height 
FROM students 
WHERE stu_age<20 AND stu_height>1.65;
#查询出班级中身高不低于1.7，体重不大于65kg的所有男生信息
SELECT stu_name,stu_age,stu_height 
FROM students 
WHERE stu_height>1.7 AND stu_weight<65;
#把学号202204,202206,202208三名学生的年龄加一岁
UPDATE students 
SET stu_age = stu_age + 1 
WHERE stu_id = 202204 OR stu_id = 202206 OR stu_id = 202208;
#找出班级中1.6以下和1.8以上的所有男生
SELECT * 
FROM students
WHERE stu_height < 1.6 OR stu_height > 1.8;
#找出班级中身高1.62以上的女生和1.75以上的男生全部信息 
SELECT *
FROM students
WHERE stu_height > 1.62 AND stu_sex = "女" OR stu_height > 1.75 AND stu_sex = "男";
~~~

### 9.26

~~~sql
# 查询出班级中所有姓张的学生信息
SELECT * FROM students WHERE stu_name LIKE "张%";

#查询出班级中名字由三个字组成的学生信息
SELECT * FROM students WHERE stu_name LIKE "___";

#查询出班级中第二个字为"杰"的学生
SELECT * FROM students WHERE stu_name LIKE "_杰%";

#查询出班级中名字带有"杰"的学生信息
SELECT * FROM students WHERE stu_name LIKE "%杰%";

#查询出班级中1.6以上的女生全部信息，按照身高升排序
SELECT
 * 
FROM
 students 
WHERE
 stu_height > 1.6 
AND
 stu_sex = "女" 
ORDER BY
 stu_height 
ASC;

#查询出班级中的年龄不大于22的男生姓名，性别和年龄，按照年龄降序
SELECT
 stu_name AS 学生姓名,
 stu_sex AS 学生性别,
 stu_age AS 学生年龄
FROM
	students
WHERE
	stu_age < 22
AND
	stu_sex = "男"
ORDER BY
	stu_age 
DESC;

#查询出班级中男生的数量
SELECT
 COUNT(*) AS 男生数量
FROM
	students
WHERE
	stu_sex = "男";
	
#查询出班级中最大年龄和最小年龄
SELECT
	MAX(stu_age) AS 最大年龄,
	MIN(stu_age) AS 最小年龄
FROM
	students;
	
#查询班级总年龄，平均年龄
SELECT
	SUM(stu_age) AS 总年龄,
	AVG(stu_age) AS 平均年龄
FROM
	students;
	
#查询出身高不低于1.63的名字两个字的学生学号，姓名，身高。按照身高降序排序
SELECT
 stu_id AS 学号,
 stu_name AS 姓名,
 stu_height AS 身高
FROM
	students
ORDER BY
	stu_height
DESC;

#查询出周姓学生的平均年龄，平均身高，平均体重;
SELECT
 AVG(stu_age) AS 平均年龄,
 AVG(stu_height) AS 平均身高,
 AVG(stu_weight) AS 平均体重
FROM
	students
WHERE
	stu_name LIKE "周%";

#查询出班级中姓张，姓王，姓李且年龄不小于21的学生信息，按照年龄升序显示，同龄者按照身高降序；
SELECT 
 *
FROM
	students
WHERE
	stu_name LIKE "张%" OR
	stu_name LIKE "王%" OR
	stu_name LIKE "李%" AND
	stu_age > 21
ORDER BY
	stu_age,
	stu_height DESC;
	
# 查询出班级中低于男生平均身高的男生数量
SELECT
	COUNT(*) AS 低于平均身高男生数量
FROM
	students
WHERE
	stu_height < (
		SELECT AVG(stu_height)
		FROM students
		WHERE stu_sex = "男"
	);
	
#查询出班级中年龄最小的学生全部信息
SELECT
	*
FROM
	students
WHERE
	stu_age = (
		SELECT MIN(stu_age)
		FROM students
	);
	
#查询出班级中年龄低于班级平均年龄，身高不低于1.62的女生姓名，年龄和身高。按照年龄升序
SELECT
	stu_name AS 姓名,
	stu_age AS 年龄,
	stu_height AS 身高
FROM
	students
WHERE
	stu_age < (
		SELECT AVG(stu_age)
		FROM students
		WHERE stu_height > 1.62 AND stu_sex = "女"
	)
ORDER BY stu_age DESC;

#查询出班级中姓张和姓刘的学生中年龄最大者的全部信息
SELECT * FROM students WHERE stu_age=(
SELECT MAX(stu_age) FROM students WHERE stu_name LIKE '张%' OR  stu_name LIKE '刘%'
)AND (stu_name LIKE '张%' OR  stu_name LIKE '刘%');
	
#统计出班级中体重信息缺失的学生个数
SELECT
	COUNT(*)
FROM
	students
WHERE
	stu_weight IS NULL;
	
#查询出比202203这个学生高的全部男学生信息
SELECT
	*
FROM
	students
WHERE
	stu_height > (
		SELECT stu_height
		FROM students
		WHERE stu_id = 202203
	)
	AND stu_sex = "男"
	;
~~~

### 9.27

~~~sql
#查询出班级中比李四年龄大的学生姓名和年龄，按照年龄降序显示
SELECT stu_name,stu_age FROM students WHERE stu_age>(
SELECT stu_age FROM students WHERE stu_name='李四'
) ORDER BY stu_age DESC;

#查询出班级中有多少名女生的身高高于女生平均身高；
SELECT COUNT(*) FROM students WHERE stu_sex='女' AND stu_height>
(SELECT AVG(stu_height) FROM students WHERE stu_sex='女')

#查询出最小年龄的男生全部信息
SELECT * FROM students WHERE stu_sex='男' AND stu_age=
(SELECT MIN(stu_age) FROM students WHERE stu_sex='男'); 

INSERT INTO scores VALUES
(202215,'语文',100),
(202215,'数学',NULL),
(202215,'英语',77);

#查询出缺考和挂科的学生学号和姓名；
SELECT stu_id,stu_name FROM students
WHERE stu_id in
(SELECT sc_id FROM scores WHERE IFNULL(sc_score,0)<60);

#查询出学号202205这个学生的总成绩；
SELECT SUM(sc_score) FROM scores WHERE sc_id=202205

#查询出语文成绩大于85分的男生学号，姓名和性别；
SELECT stu_id,stu_name,stu_sex FROM students WHERE 
stu_id in 
(SELECT sc_id FROM scores WHERE sc_sub='语文' AND sc_score>85) AND stu_sex='男';


#查询英语最高分的学生学号，姓名，性别，年龄；
SELECT stu_id,stu_name,stu_sex,stu_age FROM students WHERE
stu_id in (SELECT sc_id FROM scores WHERE sc_sub='英语' and sc_score=(
SELECT MAX(sc_score) FROM scores WHERE sc_sub='英语'
));

#查询出数学及格的学生数量；
SELECT COUNT(*) FROM scores WHERE sc_sub='数学' AND sc_score>=60;


#查询出班级中男生女生分别多少人
SELECT stu_sex AS 性别,COUNT(*) AS 人数 FROM students GROUP BY stu_sex;
#查询班级中分组后男女的名字
SELECT  stu_sex,GROUP_CONCAT(stu_name) FROM students GROUP BY stu_sex;
#查询出每个人的学号和总成绩
SELECT sc_id,SUM(sc_score) FROM scores GROUP BY sc_id

#查询出张三，李四，王五分别的总成绩，按照总成绩降序显示

SELECT sc_id,SUM(sc_score) FROM scores WHERE sc_id in (
SELECT stu_id FROM students WHERE stu_name in ('张三','李四','王五')
) GROUP BY sc_id ORDER BY SUM(sc_score) DESC;

#查询出班级中平均分大于75的学生学号和姓名
SELECT stu_id,stu_name FROM students WHERE stu_id in 
(SELECT sc_id FROM scores GROUP BY sc_id HAVING AVG(IFNULL(sc_score,0))>75);
~~~

### 9.28

~~~sql
#查询出班级中每名女生的学号，姓名，性别，总成绩及平均分
#查询出本轮考试中各科挂科及缺考的总人数
#查询出低于班级整体平均分的学生全部信息
#查询出比202205总成绩高的学生学号，姓名及总成绩
#查询各科成绩的第一名的学生学号，姓名和对应科目及成绩
~~~

### 9.29

~~~sql
#查询出班级中每名女生的学号，姓名，性别，总成绩及平均分
SELECT stu_id,stu_name,stu_sex,SUM(sc_score),AVG(IFNULL(sc_score,0))
FROM students,scores
WHERE stu_id=sc_id AND stu_sex='女'
GROUP BY sc_id;

#查询出本轮考试中各科挂科及缺考的总人数
SELECT sc_sub,COUNT(*) 
FROM scores
WHERE IFNULL(sc_score,0)<60 
GROUP BY sc_sub;

#查询出低于班级整体平均分的学生全部信息
SELECT * FROM students,scores
WHERE stu_id=sc_id AND stu_id in (
SELECT sc_id FROM scores 
GROUP BY sc_id
HAVING AVG(IFNULL(sc_score,0))<(
SELECT AVG(IFNULL(sc_score,0)) FROM scores
));

#查询出比202205总成绩高的学生学号，姓名及总成绩
SELECT stu_id,stu_name,SUM(sc_score) FROM students,scores
WHERE stu_id=sc_id 
GROUP BY sc_id
HAVING SUM(sc_score)>(
SELECT SUM(sc_score) FROM scores WHERE sc_id=202205
);

#查询各科成绩的第一名的学生学号，姓名和对应科目及成绩

SELECT stu_id,stu_name,sc_sub,sc_score
FROM students,scores,(SELECT sc_sub AS sc_subject,MAX(sc_score) as sc_max FROM scores GROUP BY sc_sub
) AS a
WHERE stu_id=sc_id AND scores.sc_sub=a.sc_subject AND scores.sc_score=a.sc_max;
~~~

### 9.30

~~~sql
SELECT stu_id AS 学号,stu_name AS 姓名,stu_sex AS 性别,sc_sub AS 科目,sc_score AS 分数,sc_idsc.score AS 总成绩
FROM students,scores,
(SELECT sc_id AS id,sum(sc_score) AS score FROM scores GROUP BY sc_id) AS sc_idsc,
(SELECT stu_sex AS gender,MAX(sum1.sc_sum) AS num_max FROM students,(SELECT sc_id AS sum_id,SUM(sc_score) AS sc_sum FROM scores,students WHERE stu_id=sc_id GROUP BY sc_id) AS sum1 
WHERE stu_id=sum1.sum_id
GROUP BY stu_sex) AS gender_max
WHERE stu_id=sc_id AND sc_id=sc_idsc.id AND stu_sex=gender AND num_max=sc_idsc.score; 
~~~

~~~sql
SELECT stu_id,stu_name,stu_sex,GROUP_CONCAT(sc_score),SUM(sc_score) FROM students,scores, 
(SELECT sc_id AS sc_ida FROM scores,students WHERE
stu_id=sc_id AND stu_sex='男' GROUP BY sc_id ORDER BY SUM(sc_score) DESC LIMIT 0,1) AS a,
(SELECT sc_id AS sc_idb FROM scores,students WHERE
stu_id=sc_id AND stu_sex='女' GROUP BY sc_id ORDER BY SUM(sc_score) DESC LIMIT 0,1) AS b
WHERE sc_id=stu_id AND (scores.sc_id=a.sc_ida OR scores.sc_id=b.sc_idb) GROUP BY sc_id 
ORDER BY SUM(sc_score) DESC;
~~~

~~~Sql
SELECT stu_id,stu_name,students.stu_sex,sc_sub,sc_score,b.fen 
FROM students,scores,(
SELECT stu_sex,stu_id AS stuid,a.sumscore as fen FROM 
(SELECT sc_id AS scid,SUM(sc_score) AS sumscore FROM scores GROUP BY sc_id ORDER BY sumscore DESC) AS a,
students
WHERE a.scid=stu_id GROUP BY stu_sex
) AS b
WHERE stu_id=sc_id AND students.stu_id=b.stuid
~~~

### 10.8

~~~sql
#建表students
#学号主键，姓名（不为空），性别（不为空），生日（date类型），班级

CREATE TABLE students(
stu_id INT(255) PRIMARY KEY,
stu_name VARCHAR(255) NOT NULL,
stu_sex VARCHAR(255) NOT NULL,
stu_birth date,
stu_class VARCHAR(255)
);

#删除指定列
ALTER TABLE students DROP COLUMN stu_birth;
#添加一列
ALTER TABLE students ADD COLUMN stu_birth date AFTER stu_sex;

#插入
insert into students values(105,'匡明','男','1975-10-02','95031');
insert into students values(107,'王丽','女','1976-01-23','95033');
insert into students values(101,'李军','男','1976-02-20','95033');
insert into students values(109,'王芳','女','1975-02-10','95031');
insert into students values(108,'曾华','男','1977-09-01','95033');
insert into students values(103,'陆君','男','1974-06-03','95031');

#把曾华性别改为女
UPDATE students SET stu_sex='女' WHERE stu_name='曾华';

#建表teachers
#教师编号（主键），姓名（不为空），性别（不为空），
#生日（t_birth），职称(t_prof)，系别(t_depart)

CREATE TABLE teachers(
t_id INT(255) PRIMARY KEY,
t_name VARCHAR(255) NOT NULL,
t_sex VARCHAR(255) NOT NULL,
t_birth date,
t_prof VARCHAR(255),
t_depart VARCHAR(255)
);

insert into teachers values(804,'李诚','男','1985-12-02','副教授','计算机系');
insert into teachers values(856,'张旭','男','1969-03-12','讲师','电子工程系');
insert into teachers values(825,'王萍','女','1972-05-05','助教','计算机系');
insert into teachers values(831,'刘冰','女','1977-08-14','助教','电子工程系');

#建表course
#课程号（c_id，主键，vachar类型） 课程名（c_name varchar）,任课教师（c_tid  int）
#任课教师字段设置外键，参考教师表的t_id字段


insert into course values('3-105','计算机导论',825);
insert into course values('3-245','操作系统',856);
insert into course values('6-166','数字电路',856);
insert into course values('9-888','高等数学',831);

#建表scores
#sc_stuid(外键，参考学生id，不为空)
#sc_cid(外键，参考课程号，不为空)
#sc_score(可以为空，分数保留1位小数)

#sc_stuid和sc_cid联合主键


insert into scores values(103,'3-245',86);
insert into scores values(105,'3-245',75);
insert into scores values(109,'3-245',68);
insert into scores values(103,'3-105',92);
insert into scores values(105,'3-105',88);
insert into scores values(101,'3-105',64);
insert into scores values(107,'3-105',91);
insert into scores values(108,'3-105',78);
insert into scores values(101,'6-166',85);
insert into scores values(107,'6-166',79);
insert into scores values(108,'6-166',81);
insert into scores values(109,'3-105',50);


#1.查询老师名和该老师带的课程名
SELECT t_name,c_name FROM teachers,course WHERE t_id=c_tid;

#2.查询修了“计算机导论”的所有学生的信息
SELECT * FROM students,course,scores WHERE stu_id=sc_stuid
AND sc_cid=c_id AND c_name='计算机导论';

#3.查询95033班级的学生所选课程的平均分
SELECT c_name,AVG(sc_score) FROM students,course,scores WHERE sc_stuid=stu_id AND c_id=sc_cid
AND stu_class='95033' GROUP BY c_name;

#4.查询男生和女生分别的平均分
SELECT stu_sex,AVG(IFNULL(sc_score,0)) FROM students,scores
WHERE stu_id=sc_stuid GROUP BY stu_sex;

#5.求出总成绩最高的学生姓名
SELECT stu_name,SUM(sc_score) FROM students,scores WHERE stu_id=sc_stuid
GROUP BY stu_id ORDER BY SUM(sc_score) DESC LIMIT 0,1;

#6.查询每个老师带了多少个学生 
SELECT t_name,COUNT(*) FROM course,teachers,scores WHERE c_tid=t_id
AND sc_cid=c_id GROUP BY t_name;

#7.查询“曾华”选修的所有课程名
SELECT c_name FROM students,scores,course WHERE stu_id=sc_stuid
AND c_id=sc_cid AND stu_name='曾华';

#8.查询李军有哪些课程没有选
SELECT c_name FROM course WHERE c_name NOT in (
SELECT c_name FROM students,course,scores WHERE sc_stuid=stu_id
AND sc_cid=c_id AND stu_name='李军'
);

#9.查询每个科目成绩最高的学生学号和姓名
SELECT stu_id,stu_name,c_name FROM scores,students,course,(
SELECT sc_cid AS sc_sub,MAX(sc_score) AS sc_max FROM scores
GROUP BY sc_cid
) AS a
WHERE stu_id=sc_stuid AND scores.sc_cid=a.sc_sub AND scores.sc_score=a.sc_max
AND sc_cid=c_id;


#10.查询哪个学科最受女生喜欢
SELECT c_name from students,scores,course WHERE
c_id=sc_cid AND sc_stuid=stu_id AND stu_sex='女' GROUP BY c_name
ORDER BY COUNT(stu_id) DESC LIMIT 0,1;

#11.查询讲师代课班级里成绩最低的是哪个班级
SELECT stu_class FROM students,course,scores WHERE stu_id=sc_stuid
AND c_id=sc_cid AND c_tid in (
SELECT t_id FROM teachers WHERE t_prof='讲师'
) GROUP BY stu_class ORDER BY SUM(sc_score) LIMIT 0,1;

#12.查询“1975年以后”出生的学生都选修的课程号和课程名
SELECT c_id,c_name FROM course,students,scores
WHERE c_id=sc_cid AND stu_id=sc_stuid AND YEAR(stu_birth)>1975
GROUP BY c_id;
~~~

