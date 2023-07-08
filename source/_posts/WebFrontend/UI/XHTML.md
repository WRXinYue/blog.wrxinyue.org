---
title: XHTML
date: 2022-12-27 9:21:48.0
categories: 
- WebFrontend
tags: 
- html
updated: 2023-06-17 22:07:21
---

# XHTML 简介

## 什么是XHTML

![image-20220926165030652](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220926165030652.png)

* XHTML指的是可扩展性超文本标签语言（EXtensible HyperText Markup Language）。
* XHTML的目标是取代HTML。
* XHTML 与 HTML 4.01 几乎是相同的。
* XHTML是更严格纯净的HTML版本。
* XHTML是作为一种 XML 应用被重新定义的HTML
* XHTML是一个W3C标准。

## 需要掌握的知识

* HTML
* 基本的网站建设知识

## HTML、XHTML、XML与HTML5区别与联系

![image-20220926100030989](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220926100030989.png)

xhtml：可扩展超文本标记语言，是一种置标语言，表现方式与超文本标记语言（HTML）类似，不过语法上更加严格。

html5（h5）：更先由WHATWG（web 超文本应用技术工作组）命名的一种超文本标记语言，随后和W3C的xhtml2.0(标准)相结合，产生现在更新一代的超文本标记语言。可以简单理解为：h5 ≈ html + CSS 3 + js + API。

XML：~~未来再进行讨论~~

**html特性：**

* 标识文本、建立超链接、创建列表、多媒体、制作表格表单等



**h5的认识：**

* 新特性应该基于HTML、CSS、DOM以及JavaScript

* 减少对外部插件的需求（比如Flash）

* 更优秀的错误处理

* 更多取代脚本的标记



**h5新特性：**

* 用于绘画的`canvas`元素
* 用于媒介回放的`video`和`audio`元素
* 更具语义化的标签，便于浏览器识别
* 对本地离线存储有更好的支持，可通过ofline实现
* 新的特殊内容元素，比如`article`、`footer`、`header`、`nav`、`section`
* 新的表单控件，比如`calendar`、`date`、`time`、`email`、`url`、`search`

# XHTML语法

1. XHTML要求正确嵌套
2. XHTML所有元素必须关闭
3. XHTML区分大小写
4. XHTML属性要用双引号
5. XHTML用id属性替代name属性
6. XHTML特殊字符的处理

# XHTML DTD

XHTML 定义了三种文件类型声明。

使用最普遍的是XHTML Transitional。

## `<!DOCTYPE>`是强制使用的

一个XHTML文档有三个主要的部分：

* DOCTYPE
* Head
* Body

~~~XHTML
<!DOCTYPE ...>
<html>
	<head>
		<title>... </title>
	</head>
	<body> ... </body>
</html>
~~~

在XHTML文档中，文档类型声明总是位于首行。

## 一个XHTML的实例

一个简单的（最小化的）XHTML文档：

~~~XHTML
<!DOCTYPE html
PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html>
	<head>
		<title>simple document</title>
	</head>
	<body>
		<p>a simple paragraph</p>
	</body>
</html>
~~~

文档类型声明定义文档的类型：

~~~XHTML
<!DOCTYPE html
PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
~~~

文档的其余部分类似HTML：

~~~XHTML
<html>
	<head>
		<title>simple document</title>
	</head>
	<body>
		<p>a simple paragraph</p>
	</body>
</html>
~~~

## 3种文档类型声明

* DTD规定了使用通用标记语言（SGML）的网页的语法。
* 诸如HTML这样的通用标记语言应该使用DTD来规定应用于某种特定文档中的标签的规则，这些规则包括一系列的元素和实体的声明。
* 在通用标记语言（SGML）的文档类型声明或DTD中，XHTML被详细地进行了描述。
* XHTML DTD使用精确的可被计算机读取的语言来描述合法的XHTML标记的语法和句法。



**XHTML 1.0 Strict（严格模式）：**

~~~XHTML
<!DOCTYPE html
PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" 
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
~~~

使用场景：需要干净的标记，避免表现上的混乱。与层叠样式表配合使用。

严格 DTD 包含没有被反对使用的或不出现在框架结构中的元素和属性

**XHTML 1.0 Transitional（过度类型）：**

~~~XHTML
<!DOCTYPE html
PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
~~~

使用场景：当需要利用HTML在表现上的特征时，并且上需要为那些不支持层叠样式表的浏览器编写XHTML时。

过渡 DTD 包含严格 DTD 中的一切，外加那些不赞成使用的元素和属性

**XHTML 1.0 Frameset（框架类型）：**

~~~XHTML
<!DOCTYPE html
PUBLIC "-//W3C//DTD XHTML 1.0 Frameset//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-frameset.dtd">
~~~

使用场景：需要使用HTML框架将浏览器窗口分割为两部分或更多框架时。

框架 DTD 包含过渡 DTD 中的一切，外加框架

详细参数请参考：[XHTML参考手册](https://www.w3school.com.cn/tags/index.asp)

# XHTML的普及率

在知名站点(在 Google 上搜索“A”时排名前 30)的随机样本中，只有1个站点(3%)仍然使用 XHTML。 自2000年1月XHTML 被推荐为HTML的下一代标准以来，已经过去了将近三年，但还不能说它已经变得非常流行，可能是因为转向 XHTML 并没有太大的优势。现在的情况。 

顺便说一句，3个站点(10%)符合推荐的规范，例如 HTML 3.2/4.0/4.01，尽管存在一些错误，7 个站点 (23%) 尽管有 DOCTYPE 声明，但使用了浏览器特定的属性。19  个站点(63%)，包括雅虎、微软、网景、Adobe、NCSA 和 Amazon.com 等知名网站，不编写 DOCTYPE 声明，使用 HTML 有免费限制。  （2003 年 1 月调查） 

# 结论

HTML 和 XHTML 都是用于创建网页和应用程序的标记语言。  HTML和XHTML一些使它们与众不同的关键区别，但它们也有一些相似之处。 XHTML是HTML的扩展版本，两种语言都用于开发基于 Web和Android 的应用程序。 

虽然 HTML 可能更简单，但 XHTML 更结构化。  XHTML 旨在提高 HTML 的可扩展性和灵活性，使其更容易将 HTML 与其他数据格式（如 XML）集成。  因此，在做出决定时必须牢记每一方的优势和劣势。