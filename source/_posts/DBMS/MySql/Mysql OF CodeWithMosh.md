---
title: Mysql OF CodeWithMosh
date: 2022-12-01 20:02:26.992
updated: 2022-12-06 15:44:14.883
categories: 
- WEBbackend
tags: 
- mysql
- sql
---

# Ⅱ

## The SELECT Clause

~~~mysql
SELECT 	
	first_name, 
	last_name, 
	points, 
	(points + 10) * 100 AS 'discount factor'
FROM customers
-- WHERE customer_id = 1
-- ORDER BY first_name
~~~

![image-20221130145315129](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221130145315129.png)



~~~mysql
SELECT DISTINCT state FROM customers;
~~~

*DISTINCT* - 用于返回唯一不同的值

![image-20221130145229628](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221130145229628.png)



## The WHERE Clause

~~~mysql
SELECT *
FROM Customers
WHERE points > 3000;
~~~

![image-20221130150958390](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221130150958390.png)



~~~mysql
SELECT *
FROM Customers
-- WHERE state != 'va'
WHERE state <> 'va';
~~~

![image-20221130151118887](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221130151118887.png)



~~~mysql
SELECT *
FROM Customers
WHERE birth_date > '1990-01-01';
~~~

![image-20221130151157095](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221130151157095.png)



## The AND,OR and NOT Operators

~~~mysql
SELECT *
FROM Customers
-- WHERE birth_date > '1990-01-01' && points > 1000 || state = "VA"
WHERE birth_date > '1990-01-01' AND points > 1000 OR state = 'VA';
~~~

![image-20221130155206238](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221130155206238.png)



~~~mysql
SELECT *
FROM Customers
WHERE NOT (birth_date > '1990-01-01' OR points > 1000);
~~~

![image-20221130155309656](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221130155309656.png)

![image-20221130155452610](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221130155452610.png)



## The IN Operator

~~~mysql
SELECT *
FROM Customers
-- WHERE state = 'VA' OR state = 'GA' OR state = 'FL'
WHERE state IN ('VA','FL','GA');
-- WHERE state NOT IN ('VA','FL','GA')
~~~

![image-20221130202320809](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221130202320809.png)



## The BETWEEN Operator

~~~mysql
SELECT *
FROM customers
-- WHERE points >= 1000 AND points <= 3000
WHERE points BETWEEN 1000 AND 3000;
~~~

![image-20221130203222460](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221130203222460.png)



## The LIKE Operator

* `%` any number of characters
* `_` single character



~~~mysql
SELECT *
FROM customers
WHERE last_name LIKE '%b%';
~~~

![image-20221130204201974](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221130204201974.png)



~~~mysql
SELECT *
FROM customers
WHERE last_name LIKE 'b____y';
~~~

![image-20221130204234121](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221130204234121.png)



## The REGEXP Operator

* `^`   beginning
* `$`   end
* `|`   logical or
* `[abcd]`
* `[a-f]`



~~~mysql
SELECT *
FROM customers
-- WHERE last_name LIKE '%field' OR last_name LIKE 'mac%' OR last_name LIKE '%rose%'
WHERE last_name REGEXP 'field$|^mac|rose';
~~~

![image-20221130210217163](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221130210217163.png)



~~~mysql
SELECT *
FROM customers
WHERE last_name REGEXP '[a-h]e';
~~~

![image-20221130210238524](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221130210238524.png)



## The IS NULL Operator

~~~mysql
SELECT *
FROM customers
-- WHERE phone NOT IS NULL
WHERE phone IS NULL;
~~~

![image-20221130210848544](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221130210848544.png)



## The ORDER BY Clause

~~~mysql
SELECT *
FROM customers
ORDER BY points DESC;
~~~

![image-20221130212536832](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221130212536832.png)



~~~mysql
SELECT birth_date, first_name, last_name, 10 AS points
FROM customers
ORDER BY 1, 2;
~~~

![image-20221130212522151](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221130212522151.png)



## The LIMIT Clause

~~~mysql
SELECT *
FROM customers
LIMIT 6, 3;
-- page 1: 1 - 3
-- page 2: 4 - 6
-- page 3: 7 - 9
~~~

![image-20221130213146262](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221130213146262.png)



# Ⅲ

## Inner Joins

![image-20221201100403520](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201100403520.png)

~~~mysql
SELECT order_id, orders.customer_id, first_name, last_name
FROM orders
INNER JOIN customers
	ON orders.customer_id = customers.customer_id;
~~~

~~~mysql
SELECT order_id, o.customer_id, first_name, last_name
FROM orders o
JOIN customers c
	ON o.customer_id = c.customer_id;
~~~

![image-20221130214455720](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221130214455720.png)



## Joining Across Databases

~~~mysql
USE sql_store;

SELECT *
FROM order_items oi
JOIN sql_inventory.products p
	ON oi.product_id = p.product_id;
~~~

![image-20221130215210224](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221130215210224.png)



## Self Joins

~~~mysql
USE sql_hr;

SELECT
	e.employee_id,
	e.first_name,
	m.first_name AS manager
FROM employees e
JOIN employees m
	ON e.reports_to = m.employee_id;
~~~

![image-20221130220416319](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221130220416319.png)

## Joining Multiple Tables

~~~mysql
USE sql_store;

SELECT
	o.order_id,
	o.order_date,
	c.first_name,
	c.last_name,
	os.name AS status
FROM orders o
JOIN customers c
	ON o.customer_id = c.customer_id
JOIN order_statuses os
	ON o.status = os.order_status_id
~~~

![image-20221201092822387](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201092822387.png)



## Compound Join Conditions

~~~mysql
SELECT *
FROM order_items oi
JOIN order_item_notes oin
	ON oi.order_id = oin.order_id
	AND oi.product_id = oin.product_id
~~~



## Implicit Join Syntax

不建议使用隐式连接，WHERE不能省略 否则造成笛卡尔积 

~~~mysql
SELECT *
FROM orders o
JOIN customers c
	ON o.customer_id = c.customer_id;
~~~

~~~mysql
-- Implpicit Join Syntax
SELECT *
FROM orders o, customers c
WHERE o.customer_id = c.customer_id;
~~~

![image-20221201094922845](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201094922845.png)



## Outer Joins

左连接就是以FROM后面的表为主，右连接就是以JOIN 后面的表为主

![image-20221201100518304](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201100518304.png)

~~~mysql
-- LEFT JOIN
SELECT
	c.customer_id,
	c.first_name,
	o.order_id
FROM customers c
-- LEFT OUTER JOIN orders o
LEFT JOIN orders o
	ON c.customer_id = o.customer_id
ORDER BY c.customer_id;
~~~

![image-20221201095918049](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201095918049.png)



![image-20221201100546806](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201100546806.png)

~~~mysql
-- RIGHT JOIN
SELECT
	c.customer_id,
    c.first_name,
    o.order_id
FROM customers c
-- RIGHT OUTER JOIN orders o
RIGHT JOIN orders o
	ON c.customer_id = o.customer_id
ORDER BY c.customer_id;
~~~

![image-20221201095953308](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201095953308.png)



## Outer Joins Between Multiple Tables

~~~mysql
SELECT *
FROM customers c
LEFT JOIN orders o
	ON c.customer_id = o.customer_id
LEFT JOIN shippers sh
	ON o.shipper_id = sh.shipper_id
ORDER BY c.customer_id;
~~~

![image-20221201102129055](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201102129055.png)



## Self Outer Joins

~~~mysql
SELECT
	e.employee_id,
	e.first_name,
	m.first_name AS manager
FROM employees e
LEFT JOIN employees m
	ON e.reports_to = m.employee_id
~~~

![image-20221201112329462](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201112329462.png)



## The USING Clause

~~~mysql
SELECT
	o.order_id,
    c.first_name,
    sh.name AS shipper
FROM orders o
JOIN customers c
	-- ON o.customer_id = c.customer_id
    USING (customer_id)
LEFT JOIN shippers sh
	USING (shipper_id);
~~~

![image-20221201113617556](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201113617556.png)



~~~mysql
SELECT *
FROM order_items oi
JOIN order_item_notes oin
	-- ON oi.order_id = oin.order_id AND
		-- oi.product_id = oin.product_id
	USING(order_id, product_id);
~~~



## Natural Joins

*不建议使用随缘大法*

~~~mysql
SELECT
	o.order_id,
    c.first_name
FROM orders o
NATURAL JOIN customers c
~~~

![image-20221201114156839](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201114156839.png)



## Cross Joins

*笛卡尔积*

~~~mysql
SELECT
	c.first_name AS customer,
	p.name AS product
-- FROM customers c, products p
FROM customers c
CROSS JOIN products p
ORDER BY c.first_name
~~~

![image-20221201115028098](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201115028098.png)



## Unions

*没啥用,但是并和列数必须相等*

`UNION` / `UNION ALL`

~~~mysql
SELECT
	order_id,
	order_date,
	'Active' AS status
FROM orders
WHERE order_date >= '2019-01-01'
UNION
SELECT
	order_id,
	order_date,
	'Archived' AS status
FROM orders
WHERE order_date < '2019-01-01'
~~~

![image-20221201124209848](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201124209848.png)

# Ⅳ

## Column Attributes

![image-20221201124936727](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201124936727.png)

* PK -- 主键
* NN -- 非空值
* AI -- 自动递增
* Default/Expression -- 默认值



## Inserting a Single Row

~~~mysql
INSERT INTO customers
VALUES (
	DEFAULT,
    'John',
    'Smith',
    '1990-01-01',
    NULL,
    'address',
    'city',
    'CA',
    DEFAULT
);
~~~

~~~mysql
INSERT INTO customers (
	first_name,
    last_name,
    birth_date,
    address,
    city,
    state)
VALUES (
    'John',
    'Smith',
    '1990-01-01',
    'address',
    'city',
    'CA'
);
~~~

![image-20221201140340682](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201140340682.png)



## Inserting Multiple Rows

~~~mysql
INSERT INTO shippers (name)
VALUES ('Shipper1'),
	('Shipper2'),
	('Shipper3');
~~~

![image-20221201141627554](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201141627554.png)



## Inserting Hierarchical Rows

* `LAST_INSERT_ID()` --  最近插入ID

~~~mysql
INSERT INTO orders (customer_id, order_date, status)
VALUES (1, '2019-01-02', 1);

INSERT INTO order_items
VALUES
	(LAST_INSERT_ID(), 1, 1, 2.95),
	(LAST_INSERT_ID(), 2, 1, 3.95)
~~~

![image-20221201143711374](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201143711374.png)



## Creating a Copy of a Table

~~~mysql
CREATE TABLE orders_archived AS
SELECT * FROM orders;
~~~

![image-20221201151613569](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201151613569.png)



Truncate Table

![image-20221201151723929](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201151723929.png)

~~~mysql
INSERT INTO orders_archived
SELECT *
FROM orders
WHERE order_date < '2019-01-01';
~~~

![image-20221201151817025](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201151817025.png)



## Updating a Single Row

~~~mysql
UPDATE invoices
SET payment_total = 10, payment_date = '2019-03-01'
WHERE invoice_id = 1
~~~

![GIF 12-1-2022 3-26-54 PM](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/GIF%2012-1-2022%203-26-54%20PM.gif)



~~~mysql
UPDATE invoices
SET
	payment_total = invoice_total * 0.5,
	payment_date = due_date
WHERE invoice_id = 3
~~~

![GIF 12-1-2022 3-34-42 PM](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/GIF%2012-1-2022%203-34-42%20PM.gif)



## Updating Multiple Rows

~~~mysql
UPDATE invoices
SET
	payment_total = invoice_total * 0.5,
	payment_date = due_date
WHERE invoice_id IN (3, 4)
~~~



## Using Subqueries in Updates

~~~mysql
UPDATE invoices
SET
	payment_total = invoice_total * 0.5,
	payment_date = due_date
WHERE client_id IN
	(SELECT client_id
     FROM clients
     WHERE state IN ('CA','NY'))
~~~



## Deleting Rows

~~~mysql
DELETE FROM invoices
WHERE client_id = (
	SELECT client_id
    FROM clients
    WHERE name = 'Myworks'
)
~~~



# Ⅴ

## Aggregate Functions

~~~mysql
SELECT
	MAX(invoice_total) AS highest,
	MIN(invoice_total) AS lowest,
	AVG(invoice_total) AS average,
	SUM(invoice_total * 1.1) AS total,
	COUNT(DISTINCT client_id) AS total_records
FROM invoices
WHERE invoice_date > '2019-07-01'
~~~

![image-20221201164656552](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201164656552.png)



## The GROUP BY Clause

FROM->WHERE->GROUP BY->SELECT->ORDER BY

~~~mysql
SELECT
	client_id,
	SUM(invoice_total) AS total_sales
FROM invoices
WHERE invoice_date >= '2019-07-01'
GROUP BY client_id
ORDER BY total_sales DESC;
~~~

![image-20221201170410046](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201170410046.png)



~~~mysql
SELECT
	state,
	city,
	SUM(invoice_total) AS total_sales
FROM invoices
JOIN clients USING (client_id)
GROUP BY state, city
~~~

![image-20221201170432659](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201170432659.png)



## The HAVING Clause

~~~mysql
SELECT
	client_id,
	SUM(invoice_total) AS total_sales,
	COUNT(*) AS number_of_invoices
FROM invoices
GROUP BY client_id
HAVING total_sales > 500 AND number_of_invoices > 5
~~~

![image-20221201171533375](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201171533375.png)



## The ROLLUP Operator

~~~mysql
SELECT
	state,
	city,
	SUM(invoice_total) AS total_sales
FROM invoices
JOIN clients c USING (client_id)
GROUP BY state, city WITH ROLLUP
~~~

![image-20221201173117428](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201173117428.png)



# Ⅵ

## Subqueries

~~~mysql
SELECT *
FROM products
WHERE unit_price > (
    SELECT unit_price
    FROM products
    WHERE product_id = 3
)
~~~

![image-20221201174024448](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201174024448.png)



## The IN Operator

~~~mysql
SELECT *
FROM products
WHERE product_id NOT IN (
    SELECT DISTINCT product_id
    FROM order_items
)
~~~

![image-20221201174701644](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201174701644.png)



## Subqueries vs Joins

~~~mysql
-- Find clients without invoices
SELECT *
FROM clients
WHERE client_id NOT IN (
    SELECT DISTINCT client_id
    FROM invoices
)
~~~

~~~mysql
SELECT *
FROM clients
LEFT JOIN invoices USING (client_id)
WHERE invoice_id IS NULL
~~~

![image-20221201175621092](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201175621092.png)



## The ALL Keyword

`NOT IN` = `<>all`

~~~mysql
SELECT *
FROM invoices
WHERE invoice_total > (
    SELECT MAX(invoice_total)
    FROM invoices
    WHERE client_id = 3
)
~~~

~~~mysql
SELECT *
FROM invoices
WHERE invoice_total > ALL (
    SELECT invoice_total
    FROM invoices
    WHERE client_id = 3
)
~~~

![image-20221201180631709](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201180631709.png)



## The ANY Keyword

`IN` = `=ANY`

~~~mysql
-- Select clients with at least two invoices
SELECT *
FROM clients
-- WHERE client_id IN (
WHERE client_id = ANY (
    SELECT client_id
    FROM invoices
    GROUP BY client_id
    HAVING COUNT(*) >= 2
)
~~~

![image-20221201181604228](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201181604228.png)



## Correlated Subqueries

~~~mysql
-- Select employees whose salary is above the average in their office
SELECT *
FROM employees e
WHERE salary > (
    SELECT AVG(salary)
    FROM employees
    WHERE office_id = e.office_id
)
~~~

![image-20221201183245679](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201183245679.png)



## The EXISTS Operator

~~~mysql
-- Select clients that have an invoice
SELECT *
FROM clients
WHERE client_id IN (
    SELECT DISTINCT client_id
    FROM invoices
)
~~~

~~~mysql
SELECT *
FROM clients c
WHERE EXISTS (
    SELECT client_id
    FROM invoices
    WHERE client_id = c.client_id
)
~~~

![image-20221201193806982](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201193806982.png)

*NOT EXISTS 比 NOT IN 效率高*



## Subqueries in the SELECT Clause

~~~mysql
SELECT
	invoice_id,
    invoice_total,
    (SELECT AVG(invoice_total)
		FROM invoices) AS invoice_average,
	invoice_total - (SELECT invoice_average) AS difference
FROM invoices
~~~

![image-20221202085642576](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221202085642576.png)



## Subqueries in the FROM Clause

~~~mysql
USE sql_invoicing;

SELECT *
FROM (
	SELECT
		client_id,
		name,
		(SELECT SUM(invoice_total)
			FROM invoices
			WHERE client_id = c.client_id) AS total_sales,
		(SELECT AVG(invoice_total) FROM invoices) AS average,
		(SELECT total_sales - average) AS difference
	FROM clients c
) AS sales_summary
WHERE total_sales IS NOT NULL
~~~

![image-20221201200134326](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221201200134326.png)



# Ⅶ

## Numeric Functions

| 名称                                                         | 描述                       |
| ------------------------------------------------------------ | -------------------------- |
| [`ABS()`](https://dev.mysql.com/doc/refman/8.0/en/mathematical-functions.html#function_abs) | 返回绝对值                 |
| [`ACOS()`](https://dev.mysql.com/doc/refman/8.0/en/mathematical-functions.html#function_acos) | 返回反余弦                 |
| [`ASIN()`](https://dev.mysql.com/doc/refman/8.0/en/mathematical-functions.html#function_asin) | 返回反正弦                 |
| [`ATAN()`](https://dev.mysql.com/doc/refman/8.0/en/mathematical-functions.html#function_atan) | 返回反正切                 |
| [`ATAN2()`,  `ATAN()`](https://dev.mysql.com/doc/refman/8.0/en/mathematical-functions.html#function_atan2) | 返回两个参数的反正切值     |
| [`CEIL()`](https://dev.mysql.com/doc/refman/8.0/en/mathematical-functions.html#function_ceil) | 返回不小于参数的最小整数值 |
| [`CEILING()`](https://dev.mysql.com/doc/refman/8.0/en/mathematical-functions.html#function_ceiling) | 返回不小于参数的最小整数值 |
| [`CONV()`](https://dev.mysql.com/doc/refman/8.0/en/mathematical-functions.html#function_conv) | 在不同数基之间转换数字     |
| [`COS()`](https://dev.mysql.com/doc/refman/8.0/en/mathematical-functions.html#function_cos) | 返回余弦                   |
| [`COT()`](https://dev.mysql.com/doc/refman/8.0/en/mathematical-functions.html#function_cot) | 返回余切                   |
| [`CRC32()`](https://dev.mysql.com/doc/refman/8.0/en/mathematical-functions.html#function_crc32) | 计算循环冗余校验值         |
| [`DEGREES()`](https://dev.mysql.com/doc/refman/8.0/en/mathematical-functions.html#function_degrees) | 将弧度转换为度数           |
| [`EXP()`](https://dev.mysql.com/doc/refman/8.0/en/mathematical-functions.html#function_exp) | 提升到的力量               |
| [`FLOOR()`](https://dev.mysql.com/doc/refman/8.0/en/mathematical-functions.html#function_floor) | 返回不大于参数的最大整数值 |
| [`LN()`](https://dev.mysql.com/doc/refman/8.0/en/mathematical-functions.html#function_ln) | 返回参数的自然对数         |
| [`LOG()`](https://dev.mysql.com/doc/refman/8.0/en/mathematical-functions.html#function_log) | 返回第一个参数的自然对数   |
| [`LOG10()`](https://dev.mysql.com/doc/refman/8.0/en/mathematical-functions.html#function_log10) | 返回参数的以 10 为底的对数 |
| [`LOG2()`](https://dev.mysql.com/doc/refman/8.0/en/mathematical-functions.html#function_log2) | 返回参数的以 2 为底的对数  |
| [`MOD()`](https://dev.mysql.com/doc/refman/8.0/en/mathematical-functions.html#function_mod) | 退还余数                   |
| [`PI()`](https://dev.mysql.com/doc/refman/8.0/en/mathematical-functions.html#function_pi) | 返回 pi 的值               |
| [`POW()`](https://dev.mysql.com/doc/refman/8.0/en/mathematical-functions.html#function_pow) | 返回参数的指定幂           |
| [`POWER()`](https://dev.mysql.com/doc/refman/8.0/en/mathematical-functions.html#function_power) | 返回参数的指定幂           |
| [`RADIANS()`](https://dev.mysql.com/doc/refman/8.0/en/mathematical-functions.html#function_radians) | 返回参数转换为弧度         |
| [`RAND()`](https://dev.mysql.com/doc/refman/8.0/en/mathematical-functions.html#function_rand) | 返回一个随机浮点值         |
| [`ROUND()`](https://dev.mysql.com/doc/refman/8.0/en/mathematical-functions.html#function_round) | 绕过论点                   |
| [`SIGN()`](https://dev.mysql.com/doc/refman/8.0/en/mathematical-functions.html#function_sign) | 返回参数的符号             |
| [`SIN()`](https://dev.mysql.com/doc/refman/8.0/en/mathematical-functions.html#function_sin) | 返回参数的正弦             |
| [`SQRT()`](https://dev.mysql.com/doc/refman/8.0/en/mathematical-functions.html#function_sqrt) | 返回参数的平方根           |
| [`TAN()`](https://dev.mysql.com/doc/refman/8.0/en/mathematical-functions.html#function_tan) | 返回参数的正切             |
| [`TRUNCATE()`](https://dev.mysql.com/doc/refman/8.0/en/mathematical-functions.html#function_truncate) | 截断到指定的小数位数       |



## String Functions

| 姓名                                                         | 描述                                                         |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| [`ASCII()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_ascii) | 返回最左边字符的数值                                         |
| [`BIN()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_bin) | 返回包含数字二进制表示的字符串                               |
| [`BIT_LENGTH()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_bit-length) | 以位为单位返回参数的长度                                     |
| [`CHAR()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_char) | 返回传递的每个整数的字符                                     |
| [`CHAR_LENGTH()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_char-length) | 返回参数中的字符数                                           |
| [`CHARACTER_LENGTH()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_character-length) | CHAR_LENGTH() 的同义词                                       |
| [`CONCAT()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_concat) | 返回连接的字符串                                             |
| [`CONCAT_WS()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_concat-ws) | 返回带分隔符的连接                                           |
| [`ELT()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_elt) | 返回索引号处的字符串                                         |
| [`EXPORT_SET()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_export-set) | 返回一个字符串，这样对于值位中设置的每个位，您       得到一个 on string，对于每个未设置的位，你得到一个 off string |
| [`FIELD()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_field) | 后续参数中第一个参数的索引（位置）                           |
| [`FIND_IN_SET()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_find-in-set) | 第二个参数中第一个参数的索引（位置）                         |
| [`FORMAT()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_format) | 返回格式化为指定小数位数的数字                               |
| [`FROM_BASE64()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_from-base64) | 解码base64编码的字符串并返回结果                             |
| [`HEX()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_hex) | 十进制或字符串值的十六进制表示                               |
| [`INSERT()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_insert) | 在指定位置插入子串，最多指定个数       人物                  |
| [`INSTR()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_instr) | 返回第一次出现的子字符串的索引                               |
| [`LCASE()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_lcase) | LOWER() 的同义词                                             |
| [`LEFT()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_left) | 返回指定的最左边的字符数                                     |
| [`LENGTH()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_length) | 以字节为单位返回字符串的长度                                 |
| [`LIKE`](https://dev.mysql.com/doc/refman/8.0/en/string-comparison-functions.html#operator_like) | 简单模式匹配                                                 |
| [`LOAD_FILE()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_load-file) | 加载命名文件                                                 |
| [`LOCATE()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_locate) | 返回子串第一次出现的位置                                     |
| [`LOWER()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_lower) | 以小写形式返回参数                                           |
| [`LPAD()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_lpad) | 返回字符串参数，左填充指定的字符串                           |
| [`LTRIM()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_ltrim) | 删除前导空格                                                 |
| [`MAKE_SET()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_make-set) | 返回一组以逗号分隔的字符串，这些字符串具有       位集中的相应位 |
| [`MATCH()`](https://dev.mysql.com/doc/refman/8.0/en/fulltext-search.html#function_match) | 执行全文搜索                                                 |
| [`MID()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_mid) | 返回从指定位置开始的子串                                     |
| [`NOT LIKE`](https://dev.mysql.com/doc/refman/8.0/en/string-comparison-functions.html#operator_not-like) | 简单模式匹配的否定                                           |
| [`NOT REGEXP`](https://dev.mysql.com/doc/refman/8.0/en/regexp.html#operator_not-regexp) | REGEXP 的否定                                                |
| [`OCT()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_oct) | 返回包含数字的八进制表示的字符串                             |
| [`OCTET_LENGTH()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_octet-length) | LENGTH() 的同义词                                            |
| [`ORD()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_ord) | 返回参数最左边字符的字符代码                                 |
| [`POSITION()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_position) | LOCATE() 的同义词                                            |
| [`QUOTE()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_quote) | 转义参数以在 SQL 语句中使用                                  |
| [`REGEXP`](https://dev.mysql.com/doc/refman/8.0/en/regexp.html#operator_regexp) | 字符串是否匹配正则表达式                                     |
| [`REGEXP_INSTR()`](https://dev.mysql.com/doc/refman/8.0/en/regexp.html#function_regexp-instr) | 子串匹配正则表达式的起始索引                                 |
| [`REGEXP_LIKE()`](https://dev.mysql.com/doc/refman/8.0/en/regexp.html#function_regexp-like) | 字符串是否匹配正则表达式                                     |
| [`REGEXP_REPLACE()`](https://dev.mysql.com/doc/refman/8.0/en/regexp.html#function_regexp-replace) | 替换匹配正则表达式的子串                                     |
| [`REGEXP_SUBSTR()`](https://dev.mysql.com/doc/refman/8.0/en/regexp.html#function_regexp-substr) | 返回匹配正则表达式的子串                                     |
| [`REPEAT()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_repeat) | 重复一个字符串指定的次数                                     |
| [`REPLACE()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_replace) | 替换指定字符串的出现                                         |
| [`REVERSE()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_reverse) | 反转字符串中的字符                                           |
| [`RIGHT()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_right) | 返回指定的最右边的字符数                                     |
| [`RLIKE`](https://dev.mysql.com/doc/refman/8.0/en/regexp.html#operator_regexp) | 字符串是否匹配正则表达式                                     |
| [`RPAD()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_rpad) | 追加字符串指定的次数                                         |
| [`RTRIM()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_rtrim) | 删除尾随空格                                                 |
| [`SOUNDEX()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_soundex) | 返回一个 soundex 字符串                                      |
| [`SOUNDS LIKE`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#operator_sounds-like) | 比较声音                                                     |
| [`SPACE()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_space) | 返回指定空格数的字符串                                       |
| [`STRCMP()`](https://dev.mysql.com/doc/refman/8.0/en/string-comparison-functions.html#function_strcmp) | 比较两个字符串                                               |
| [`SUBSTR()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_substr) | 返回指定的子字符串                                           |
| [`SUBSTRING()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_substring) | 返回指定的子字符串                                           |
| [`SUBSTRING_INDEX()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_substring-index) | 返回字符串中指定数目之前的子串       分隔符的出现            |
| [`TO_BASE64()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_to-base64) | 返回转换为 base-64 字符串的参数                              |
| [`TRIM()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_trim) | 删除前导和尾随空格                                           |
| [`UCASE()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_ucase) | UPPER() 的同义词                                             |
| [`UNHEX()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_unhex) | 返回包含数字的十六进制表示的字符串                           |
| [`UPPER()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_upper) | 转换为大写                                                   |
| [`WEIGHT_STRING()`](https://dev.mysql.com/doc/refman/8.0/en/string-functions.html#function_weight-string) | 返回字符串的权重字符串                                       |



## Date Functions

| 名称                                                         | 描述                                                         |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| [`ADDDATE()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_adddate) | 将时间值（间隔）添加到日期值                                 |
| [`ADDTIME()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_addtime) | 添加时间                                                     |
| [`CONVERT_TZ()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_convert-tz) | 从一个时区转换为另一个时区                                   |
| [`CURDATE()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_curdate) | 返回当前日期                                                 |
| [`CURRENT_DATE()`,  `CURRENT_DATE`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_current-date) | CURDATE() 的同义词                                           |
| [`CURRENT_TIME()`,  `CURRENT_TIME`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_current-time) | CURTIME() 的同义词                                           |
| [`CURRENT_TIMESTAMP()`,  `CURRENT_TIMESTAMP`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_current-timestamp) | NOW() 的同义词                                               |
| [`CURTIME()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_curtime) | 返回当前时间                                                 |
| [`DATE()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_date) | 提取日期或日期时间表达式的日期部分                           |
| [`DATE_ADD()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_date-add) | 将时间值（间隔）添加到日期值                                 |
| [`DATE_FORMAT()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_date-format) | 按指定格式设置日期                                           |
| [`DATE_SUB()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_date-sub) | 从日期中减去时间值（间隔）                                   |
| [`DATEDIFF()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_datediff) | 减去两个日期                                                 |
| [`DAY()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_day) | DAYOFMONTH() 的同义词                                        |
| [`DAYNAME()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_dayname) | 返回工作日的名称                                             |
| [`DAYOFMONTH()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_dayofmonth) | 返回月份中的第几天 (0-31)                                    |
| [`DAYOFWEEK()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_dayofweek) | 返回参数的工作日索引                                         |
| [`DAYOFYEAR()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_dayofyear) | 返回一年中的第几天 (1-366)                                   |
| [`EXTRACT()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_extract) | 提取日期的一部分                                             |
| [`FROM_DAYS()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_from-days) | 将天数转换为日期                                             |
| [`FROM_UNIXTIME()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_from-unixtime) | 将 Unix 时间戳格式化为日期                                   |
| [`GET_FORMAT()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_get-format) | 返回日期格式字符串                                           |
| [`HOUR()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_hour) | 提取小时                                                     |
| [`LAST_DAY`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_last-day) | 返回参数月份的最后一天                                       |
| [`LOCALTIME()`,  `LOCALTIME`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_localtime) | NOW() 的同义词                                               |
| [`LOCALTIMESTAMP`,  `LOCALTIMESTAMP()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_localtimestamp) | NOW() 的同义词                                               |
| [`MAKEDATE()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_makedate) | 从年份和年份创建日期                                         |
| [`MAKETIME()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_maketime) | 从小时、分钟、秒创建时间                                     |
| [`MICROSECOND()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_microsecond) | 从参数返回微秒                                               |
| [`MINUTE()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_minute) | 从参数中返回分钟                                             |
| [`MONTH()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_month) | 从传递的日期返回月份                                         |
| [`MONTHNAME()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_monthname) | 返回月份名称                                                 |
| [`NOW()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_now) | 返回当前日期和时间                                           |
| [`PERIOD_ADD()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_period-add) | 在年月中添加句点                                             |
| [`PERIOD_DIFF()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_period-diff) | 返回期间之间的月数                                           |
| [`QUARTER()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_quarter) | 从日期参数返回季度                                           |
| [`SEC_TO_TIME()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_sec-to-time) | 将秒数转换为 'hh:mm:ss' 格式                                 |
| [`SECOND()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_second) | 返回第二个 (0-59)                                            |
| [`STR_TO_DATE()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_str-to-date) | 将字符串转换为日期                                           |
| [`SUBDATE()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_subdate) | 使用三个参数调用时 DATE_SUB() 的同义词                       |
| [`SUBTIME()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_subtime) | 减去次数                                                     |
| [`SYSDATE()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_sysdate) | 返回函数执行的时间                                           |
| [`TIME()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_time) | 提取传递的表达式的时间部分                                   |
| [`TIME_FORMAT()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_time-format) | 格式化为时间                                                 |
| [`TIME_TO_SEC()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_time-to-sec) | 返回转换为秒的参数                                           |
| [`TIMEDIFF()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_timediff) | 减去时间                                                     |
| [`TIMESTAMP()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_timestamp) | 使用单个参数，此函数返回日期或日期时间       表达;  有两个参数，参数之和 |
| [`TIMESTAMPADD()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_timestampadd) | 向日期时间表达式添加间隔                                     |
| [`TIMESTAMPDIFF()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_timestampdiff) | 从日期时间表达式中减去一个间隔                               |
| [`TO_DAYS()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_to-days) | 返回转换为天数的日期参数                                     |
| [`TO_SECONDS()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_to-seconds) | 返回转换为秒数的日期或日期时间参数       0年                 |
| [`UNIX_TIMESTAMP()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_unix-timestamp) | 返回一个 Unix 时间戳                                         |
| [`UTC_DATE()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_utc-date) | 返回当前 UTC 日期                                            |
| [`UTC_TIME()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_utc-time) | 返回当前 UTC 时间                                            |
| [`UTC_TIMESTAMP()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_utc-timestamp) | 返回当前 UTC 日期和时间                                      |
| [`WEEK()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_week) | 返回周数                                                     |
| [`WEEKDAY()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_weekday) | 返回工作日索引                                               |
| [`WEEKOFYEAR()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_weekofyear) | 返回日期的日历周 (1-53)                                      |
| [`YEAR()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_year) | 返回年份                                                     |
| [`YEARWEEK()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_yearweek) | 返回年份和星期                                               |



## Formatting Dates and Times

| 说明符   | 描述                                                         |
| -------- | ------------------------------------------------------------ |
| `%a`     | 缩写的工作日名称                 ( `Sun`.. `Sat`)            |
| `%b`     | 缩写月份名称 ( `Jan`.. `Dec`)                                |
| `%c`     | 月份，数字 ( `0`.. `12`)                                     |
| `%D`     | 带有英文后缀的月份中的第几天 ( `0th`,                 `1st`,  `2nd`,                 `3rd`, …) |
| `%d`     | 一个月中的第几天，数字 ( `00`.. `31`)                        |
| `%e`     | 一个月中的第几天，数字 ( `0`.. `31`)                         |
| `%f`     | 微秒 ( `000000`.. `999999`)                                  |
| `%H`     | 小时 （ `00`.. `23`)                                         |
| `%h`     | 小时 （ `01`.. `12`)                                         |
| `%I`     | 小时 （ `01`.. `12`)                                         |
| `%i`     | 分钟，数字 ( `00`.. `59`)                                    |
| `%j`     | 一年中的第几天 ( `001`.. `366`)                              |
| `%k`     | 小时 （ `0`.. `23`)                                          |
| `%l`     | 小时 （ `1`.. `12`)                                          |
| `%M`     | 月名 ( `January`.. `December`)                               |
| `%m`     | 月份，数字 ( `00`.. `12`)                                    |
| `%p`     | `AM`或者 `PM`                                                |
| `%r`     | 时间，12 小时（ *`hh:mm:ss`*其次是                 `AM`或者 `PM`) |
| `%S`     | 秒 ( `00`.. `59`)                                            |
| `%s`     | 秒 ( `00`.. `59`)                                            |
| `%T`     | 时间，24 小时制（ *`hh:mm:ss`*)                              |
| `%U`     | 星期 （ `00`.. `53`), 其中周日是                 一周的第一天；                 [`WEEK()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_week)模式 0 |
| `%u`     | 星期 （ `00`.. `53`), 其中星期一是                 一周的第一天；                 [`WEEK()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_week)方式一 |
| `%V`     | 星期 （ `01`.. `53`), 其中周日是                 一周的第一天；                 [`WEEK()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_week)方式二；  与                 `%X` |
| `%v`     | 星期 （ `01`.. `53`), 其中星期一是                 一周的第一天；                 [`WEEK()`](https://dev.mysql.com/doc/refman/8.0/en/date-and-time-functions.html#function_week)模式 3；  与                 `%x` |
| `%W`     | 工作日名称 ( `Sunday`.. `Saturday`)                          |
| `%w`     | 一周中的天                 ( `0`=星期天.. `6`=星期六）       |
| `%X`     | 星期日是一周的第一天的那一周的年份，数字，                 四位数;  与 `%V` |
| `%x`     | 一周的年份，其中星期一是一周的第一天，数字，                 四位数;  与 `%v` |
| `%Y`     | 年份，数字，四位数字                                         |
| `%y`     | 年份，数字（两位数）                                         |
| `%%`     | 文字 `%`特点                                                 |
| `%*`x`*` | *`x`*, 对于任何                   “ *`x`*” 未列出                   以上 |

~~~mysql
SELECT TIME_FORMAT(NOW(), '%H:%i %p')
~~~

![image-20221202102153269](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221202102153269.png)



## Calculating Dates and Times

~~~mysql
SELECT DATE_ADD(NOW(), INTERVAL 1 YEAR)
~~~

![image-20221202102647449](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221202102647449.png)



~~~mysql
-- SELECT DATE_ADD(NOW(), INTERVAL -1 YEAR)
SELECT DATE_SUB(NOW(), INTERVAL 1 YEAR)
~~~

![image-20221202102714372](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221202102714372.png)



~~~mysql
SELECT DATEDIFF('2019-01-05', '2019-01-01')
~~~

![image-20221202102942396](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221202102942396.png)



~~~mysql
SELECT TIME_TO_SEC('09:00')
~~~

![image-20221202103123832](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221202103123832.png)



~~~mysql
SELECT TIME_TO_SEC('09:00') - TIME_TO_SEC('09:02')
~~~

![image-20221202103257559](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221202103257559.png)



## The IFNULL and COALESCE Functions

~~~mysql
SELECT
	order_id,
	IFNULL(shipper_id, 'Not assigned') AS shipper
FROM orders
~~~

![image-20221202103730389](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221202103730389.png)



~~~mysql
SELECT
	order_id,
	COALESCE(shipper_id, comments, 'Not assigned') AS shipper
FROM orders
~~~

![image-20221202103933229](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221202103933229.png)



~~~mysql
SELECT
	order_id,
	IFNULL(shipper_id, '...'),
    COALESCE(shipper_id, comments, 'Not assigned') AS shipper
FROM orders
~~~

![image-20221202104109668](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221202104109668.png)



## The IF Function

~~~mysql
SELECT
	order_id,
	order_date,
    IF(
		YEAR(order_date) = YEAR(NOW()),
        'Active',
        'Archived') AS category
FROM orders
~~~

![image-20221202104820370](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221202104820370.png)



## The CASE Operator

~~~mysql
SELECT
	order_id,
    CASE
		WHEN YEAR(order_date) = YEAR(NOW()) THEN 'Active'
        WHEN YEAR(order_date) = YEAR(NOW()) - 1 THEN 'Last Year'
        WHEN YEAR(order_date) < YEAR(NOW()) - 1 THEN 'Archived'
        ELSE 'Future'
	END AS category
FROM orders
~~~

![image-20221202105738795](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221202105738795.png)