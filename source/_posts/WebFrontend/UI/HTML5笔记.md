---
title: HTML5笔记
date: 2022-07-30 00:00:04.0
updated: 2022-10-26 22:57:34.708
url: /archives/html5-bi-ji
categories: 
- WebFrontend
tags: 
- html
---

复习以下HTML和CSS基础知识，参考书籍：《HTML&CSS设计与构造网站》

# 结构

## HTML描述页面的结构

HTML代码由包括含在尖括号种的字符构成，这些代码称为HTML元素。元素通常由两个标签构成：一个起始标签和一个结束标签（结束标签要多一个斜杠）。每个HTML元素都会向浏览器传达起始标签和结束标签之间的内容的结构信息。

标签的作用就像是容器。它们告诉你起始标签和结束标签之间的内容的结构信息。

![image-20220727205551238](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220727205551238.png)

![image-20220727205655417](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220727205655417.png)

![image-20220727205704320](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220727205704320.png)

## 特性

特性提供有关元素中内容的附加信息。它们出现在元素起始标签中，并由特性**名称**和特性**值**组成，中间由等号隔开。

![image-20220727210210558](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220727210210558.png)

# 文本

* 结构化标记：用来描述标题和段落的元素。
* 语义化标记：表达特定含义的标记。

## 标题

~~~html
<h1></h1>
~
<h6>
~~~

## 粗体斜体

~~~html
<b></b> //粗体
<i></i>	//斜体
~~~

## 上标和下标

~~~html
<sup></sup>//如2²
<sub></sub>//如H₂O
~~~

## 空白

当浏览器遇到两个或两个以上的连续空格时，只将其显示为一个空格。这一特性称为**白色空间折叠**.

## 换行和水平线

~~~html
<br />//换行符
<hr />//上下文章分割线
~~~

## 语义化标记

有一些元素，它们不不影响网页结构，却为所在的页面添加了格外信息——这些元素称为语义化标记。

如em和blockquote这些标签

## 加粗和强调

~~~html
<strong>元素的作用是表示其中的内容十分重要。默认情况显示为粗体</strong>
<em>元素其强调作用，能够细微改变语句的含义</em> 
~~~

## 引用

这两个元素都可以用cite特性来表面引用的来源。cite

~~~html
<blockquote cite="www.wrxinyue.cn"></blockquote>
<q>标记段落较短引用</q>
~~~

## 缩写词和首字母缩写词

~~~html
<p><abbr title="Professor">Prof</abbr>...</p>
<p><acronym title="Professor">Prof</acronym>...</p>
~~~

## 引文和定义

~~~html
<cite>元素可以用来表明引用的来源</cite>
<dfn>元素用来表示一个新术语定义</dfn>
~~~

## 设计者详细信息

~~~html
<address>元素有一个非常特殊的用途：包含页面设计者的联系详情</address>
~~~

## 内容的修改

~~~html
<ins>下划线</ins>
<del>删除线</del>
<s>元素表示不准确或不相关却不应当予以删除的内容</s>
~~~

# 列表

## 有序列表

~~~html
<ol>//使用由该元素来创建有序列表
    <li>有序列表1</li>
    <li>有序列表2</li>
    <li>有序列表3</li>
    <li>有序列表4</li>
</ol>
~~~

## 无序列表

~~~html
<ul>
    <li>无序列表</li>
    <li>无序列表</li>
    <li>无序列表</li>
    <li>无序列表</li>
</ul>
~~~

## 定义列表

~~~html
<dl>	//定义列表由该元素创建，并通常包含一系列术语及其定义
	<dt>元素用来包含被定义的术语</dt>
    <dd>元素用来包含定义</dd>
</dl>
~~~

## 嵌套列表

~~~html
<ul>
  <li>一级嵌套</li>
  <li>一级嵌套</li>
     <ul>
        <li>二级嵌套</li>
        <li>二级嵌套</li>
    </ul>
  <li>一级嵌套</li>
</ul>
~~~

# 链接

## 编写链接

~~~
链接是由<a>元素建立的。用户可以单击位于起始标签<a>和结束标签</a>之间的任何内容。使用href特性来指定要链接到的页面。

如:
<1 href="www.wrxinyue.cn">我的博客地址</a>
~~~

## 目录结构

对于规模较大的网站而言，在管理代码时，更合理的方式是将不同类别的别的页面保存在不同的文件夹中。网站的文件夹有时也称为目录。

## 相对URL

相对URL可用于为网站内部的页面之间建立链接。它用一种简短的方式告诉浏览器去何处查找文件。

![image-20220727222749598](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220727222749598.png)

## EMAIL链接

~~~
可以用<a>元素建立email链接

mailto：
<a href="mailto":wrxinyue@formax.com>给我发邮件</a>
~~~

## 在新窗口打开链接

~~~html
target:
<a href="http://www.wrxinyue.cn" target="_blank">新的窗口打开链接</a>
~~~

## 链接到当前页面的某个特定位置

只需要使用id特性就可以实现链接达到目标位置目的。

id特性值必须以字母或者下划线开头，同一页面不能出现两个相同id的值。

要连接到一个使用id特性的元素，还需要用到< a>元素，不同的是它的href特性值以#开头，后面跟着你所要链接元素的id特性值。实例：

~~~html
<h1 id="top">需要到达的地方</h1>
<a href="#top">点我开始到达</a>
~~~

## 链接到其他页面的某个特定位置

方法和上面类型，添加绝对或者相对链接即可，实列：

~~~html
<a href = "http://www,htmalandcssbook.com/#bottom">
~~~

# 图像

## 网站上存储图像

一般网站图片会存在images文件夹中，但是我会选择使用图床给服务器减少负担

## 添加图像

< img>图像的参数必须包含src和alt参数：

> * src：图片地址
> * alt：图片无法显示出现的描述
> * title：添加图片的附加信息
> * height：以像素为单位来指定图像的高度
> * width：以像素为单位来指定图像的宽度

实列：

~~~html
<img src="images/quokka.jpg" alt="quokka" title="......" />
<img src="images/quokka.jpg" alt="quokka" width="600" height="450" />
~~~

# 表格

表格以网络形式表示数据。网络中每个块称为表格的一个单元格。

## 基本的表格结构

~~~html
<table>元素用来创建表格
<tr>table row表示每行的开始
<td>wable data，表示表格中的每个单元格
<th>table heading，表示类或行的标题
scope特性来表面此元素是列标题还是行标题。col表示列标题，row表示行标题
~~~

实例：

~~~html
<table>
    <tr>
        <th></th>
        <th scope = "col">Saturday</th>
        <th scope = "col">Sunday</th>
    </tr>
    <tr>
        <th =scope = "row">Tickets sold:</th>
        <td>120</td>
        <td>130</td>
    </tr>
    <tr>
        <th scope = "row">Total sales：</th>
        <td>$600</td>
        <td>$675</td>
    </tr>
</table>
~~~

## 跨列

可以在< th>或者< td>元素中用colspan特性来表明单元格所要跨越的列数。

~~~html
<table>
    <tr>
        <th>9am</th>
        <th>10am</th>
        <th>11am</th>
        <th>12am</th>
    </tr>
    <tr>
        <th>Monday</th>
        <td colspan = "2">Geography</td>
        <td>Math</td>
        <td>Art</td>
    </tr>
    <tr>
        <th>Tuesday</th>
        <td colspan = "30">Gym</td>
        <td>Home Ec</td>
    </tr>
</table>
~~~

![image-20220728111027574](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220728111027574.png)

## 跨行

和跨列差不多在< th>或者< td>元素中用rowspan特性来表明单元格所要跨越的行数

~~~html
<table>
    <tr>
        <th></th>
        <th>ABC</th>
        <th>BBC</th>
        <th>CNN</th>
    </tr>
    <tr>
        <th>6pm * 7pm</th>
        <td rowspan = "2">Movie</td>
        <td>Comedy</td>
        <td>News</td>
    </tr>
    <tr>
        <th>7pm * 8pm</th>
        <td>Sport</td>
        <td>Current Affairs</td>
    </tr>
</table>
~~~

![image-20220728111700007](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220728111700007.png)

## 长表格

~~~html
<thead>//表格标题
<tbody>//表格主体
<tfoot>//表格脚注
~~~

实列：

~~~html
<table>
    <thead>
        <tr>
            <th>Date</th>
            <th>Income</th>
            <th>Expenditure</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th>1st January</th>
            <td>250</td>
            <td>36</td>
        </tr>
        <tr>
            <th>2nd January</th>
            <td>285</td>
            <td>48</td>
        </tr>
        <!-- additional rows as above -->
        <tr>
            <th>31st January</th>
            <td>129</td>
            <td>64</td>
        </tr>
    </tbody>
    <tfoot>
        <tr>
            <td></td>
            <td>7824</td>
            <td>1241</td>
        </tr>
    </tfoot>
</table>
~~~

![image-20220728113037759](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220728113037759.png)

# 表单

## 表单概述

网络最知名的表单大概就要术语Google主页中的搜索框了。除了可以让用户进行搜索。表单还可以让用户在线完成其他功能

![image-20220728113619686](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220728113619686.png)

## 表单控件

添加文本：

> * 单行文本框Texi input：用于单行文本
> * 密码框Password input：类似于单行文本框，但它会掩盖输入其中的字符
> * 文本域Text area：用于较长的文本，例如消息和评论

进行选择：

> * 单选按钮Radio buttons：用户必须选择多个选项中的一个使用
> * 复选框Checkboxes：用户可以选择一个或多个选项时使用
> * 下拉列表Drop-down boxes：用户必须从一个选项列表中挑选其中之一时使用

提交表单：

> * 提交按钮Submit buttons：从当前表单向另一个网页提交数据
> * 图像按钮Image buttons：类似于提交按钮，但只能提交图片

上传文件：

> * 允许用户把文件（例如图片）上传到网站。

## 表单结构

`<form>`每个表单都位于`<form>`元素中。每个`<form>`元素都要设置action特性，通常还有要设置method特性和id特性。

* action：其特性值时服务器上一个页面的URL，这个页面用来在用户提交表单时接受表单的信息
* method：提交表单可以采用get或者post方法。
  * get方法：表单中的值附加在由action特性所指定的URL末尾。get方法适用以下情形
    * 短表单（例如搜索框）
    * 只从Web服务器上检索数据的情形（不发送那些要在数据库中添加或删除的数据）

  * post方法：表单的值被放在HTTP头信息进行发送，如果出现以下情形就用post方法
    * 允许用户上传文件
    * 非常长
    * 包含敏感信息（例如密码等）
    * 向数据库中添加或删除信息

* id：它的值是用来在页面上众多元素中对表单进行唯一性的标识（也常用在脚本中-例如检查你是否在那些需要信息的区域中填写了信息）

~~~html
<form action="http://www.example.com/subscribe.php" mothod="get">
    <p>
        This is where the from controls will appear
    </p>
</form>
~~~

## 单行文本框

`<input>`元素用来创建多种不同的表单控件，其type特性的值决定了他将要创建哪种控件

* type = “text”：当type特性的值为text时，< input>元素会创建一个单行文本框。
* name：这个特性的值对表单控件进行标识并与输入的信息一同传送到服务器
* maxlength：这个特性可以用来限制用户在文本区域输入字符的数量，它的值为用户可以输入字符的最大数量

~~~html
<form action = "http://www.example.com/login.php">
    <p>
        <input type = "text" name "username" size = "15" maxlength = "30" />
    </p>
</form>
~~~



## 密码框

为了保证绝对的安全，就要设置服务器通过安全套接层（SSL）与用户的浏览器进行连接。

* type = "password"：当type特性的值为password时，< input>
* name ：这个特性表明密码框的名称，它将与用户输入的代码一同发送到服务器
* size，maxlength ：密码框也会可以像单行文本框一样设置size特性和maxlength特性

## 文本域（多行文本框）

< textarea>元素用来创建多行文本框。

~~~html
<form action = "http://www.example.com/comments.php">
    <P>
        What did you think of this gig
    </P>
    <textarea name = "comments" cols = "20" rows = "4">Enter your comments .....</textarea>
</form>
~~~

## 单选按钮

`<input>`

* type = "radio"：单选按钮只让用户从一个选项中选择其中一个
* name：将用户所选择选项的值一同发送到服务器中
* value：为选项指定了被选中时要发送到服务器的值
* cheacked：用来指定当页面加载时哪个值

~~~html
<form action = "httpL//www.example.com/profile.php">
    <p>
        Please select your favorite genre:
        <br />
        <input type = "radio" name = "genre" value = "rock" checked = "checked" /> Rpck
        <input type = "radio" name = "genre" value = "pop" /> Pop
        <input type = "radio" name = "genre" value = "jazz" /> Jazz
    </p>
</form>
~~~

![image-20220728163318275](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220728163318275.png)

## 复选框

< input>

* type = "checkbox"复选框允许用户在回答一个问题时选择（和取消选择）一个或多个选项。
* name：将用户所选择选项的值一同发送到服务器中
* value：为选项指定了被选中时要发送到服务器的值
* checked：用来指定当页面加载时哪个值

~~~html
<form action = "http://www.example.com/profile.php">
    <P>
        Please select your favorite music service(s);
        <br />
        <input type = "checkbox" name = "service" value = "itunes" checked = "checked" /> iTunes
        <input type = "checkbox" name = "service" value = "lastfm" /> Last.fm
        <input type = "checkbox" name = "service" value = "spotify" /> Spotify 
    </P>
</form>
~~~

## 下拉列表框

`<slect>`

该元素用来创建下拉列表框，它包含两个或者两个以上的`<option>`元素

* name：指定这个表单控件名称，此名称与用户选项值一并发送到服务器。

`<option>`

该元素用于指定用户可以选择的选项。

* value：`option`元素使用value特性来指定选项的值，如果该选项被选中，那么这个值将与控件的名称一并发送到服务器
* selected特性可以用来指定当前页面加载时被选中的选项。selected特性的值应该时selected。

~~~html
<form action = "http://www.example.com/profile.php">
    <p>
        What device do you listen to music on
    </p>
    <select name = "devices">
        <option value = "ipod">iPod</option>
        <option value = "radio">Radio</option>
        <option value = "computer"Computer</select>
    </select>
</form>
~~~



## 多选框

`<select>`

* size：可以通过增加size特性的值来将一个下拉列表框变成一个能显示多个选项的列表框
* multiple：该特性的值设置为multiple，允许用户从这一列表中选择多个选项

~~~html
<form action = "http://www.example.com/profile.php">
    <p>
        Do you paly any ......
    </p>
    <select name = "instruments" size = "3" multiple = "multiple">
        <option value = "guitar" selected = "selected">Guitar</option>
        <option value = "drums" Drums>Drums</option>
        <option value = "keyboard" selected = "selected">Keyboard</option>
        <option value = "bass">Bass</option>
    </select>
</form>
~~~



## 文件上传域

`<input>`

如果你希望让用户上传文件（例如图像、视频、mp3或者PDF），就需要文件域

* type = ”file“：这个类型的input会创建一个后面附有Browse按钮的类似文本框的控件。当用户点击Browse按钮时，会打开一个新窗口来让用户从它们的计算机上选择一个文件上传到网站。

  如果允许用户上传文件，必须将`<form>`元素上的method特性值设置为post（HTTP get方式是不能发送文件的）。

~~~html
<form action = "http://example.com/upload.php" method = "post">
    <p>
        Upload your song in MP3 format:
    </p>
    <input type = "file" name = "user song" /><br />
    <input type = "submit" value = "Upload" />
</form>
~~~



## 提交按钮

`<input>`

* type = "submit"：提交按钮用来将表单发送到服务器。
* name：可以用name特性但不是必须的
* value：用于控制在按钮上显示的文本

~~~html
<form action = "http://www.example.com/subscribe.php">
    <p>
        Subscribe to our email list:
    </p>
    <input type = "text" name = "email" />
    <input type = "submit" name = "subscribe" value = "Subscribe" />
</form>
~~~

## 按钮和隐藏控件

`<button>`

引入`<button>`元素的目的是让用户更好地控制按钮的显示方式，并且允许其他元素出现在`<button>`元素内

~~~html
<form action = "http://www.example.com/add.php">
    <button>
        <img scr = "images/add.gif" alt = "add" width = "10" height = "10" />
        Add
    </button>
    <input type = "hidden" name = "bookmark" value = "lyrics" />
</form>
~~~



## 标签表单控制

`<lable>`

在使用表单控件时，可以直接通过表单控件旁边的文本说明它的作用并以此保持代码的简洁。

* for特性用来声明标签控件标注的是哪个表单控件。

## 组合表单元素

`<fieldset>`

可以将相关表单控件置于`<fieldset>`元素中分成一组。常常会带有分界线

`<legend>`

在表单控件上的标题

~~~html
<fieldset>
    <legend>
        Contact details
    </legend>
    <label>Email:<br />
    <input type = "text" name = "email" /></label><br />
    <label>Mobile:<br />
    <input type = "text" name = "moblie" /></label><br />
    <label>Telephon:<br />
    <input type = "text" name = "telephone" /></label>
</fieldset>
~~~

![image-20220728212900976](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220728212900976.png)

## HTML：表单验证

网络中的表单在用户错误地填写表单控件控件后会弹出错误提示消息，这个过程称为**表单验证**。

通常情况下，表单验证是通过JavaScript实现的。但HTML5引入了验证机制并将这一工作交由浏览器完成。

验证过程可以确保在表单提交后服务器能够理解用户在表单中所填写的信息。在表单发送到服务器之前对表单的内容进行验证有助于：

* 减少服务器的工作量
* 让用户认识到表单是否存在问题时要比服务器完成验证要快

~~~html
<form action = "http://www.example.com/login"method = "post">
    <label for = "username">Username:</label>
    <input type = "text" name = "username" required = "required" /><br />
    <label for = "password">Password:</label>
    <input type = "password" name = "password" required = "required" /><br />
    <input type = "submit" value = "Submit" />
</form>
~~~

![image-20220728220232319](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220728220232319.png)

## HTML5：日期控件

`<input>`

许多表单都需要收集日期、电子邮件地址和URL等信息。传统上，使用单行文本框来完成这些工作。

HTML5引入了新的表单控件并将某些信息的收集方式标准化，而那些不识别此类控件的旧浏览器会将它们作为单行文本框来处理。

* type = "date"：要求用户提供日期，可以使用`<input>`元素并将其type特性的值设为date。这会在支持HTML5新输入类型的浏览器上创建一个日期输入控件。

~~~html
<form action = "http://www.example.com/bookings/" method = "post">
    <label for = "username">Departure date:</label>
    <input type = "date" name = "depart" />
    <input type = "submit" value = "Submit" />
</form>
~~~

## HTML：电子邮件和URL输入控件

`<input>`

HTML5还引用了让用户输电子邮件地址和URL的输入控件。那些不支持这类输入控件的浏览器会把它们当成普通文本框来处理。

* type = “email” ：如果需要用户提供电子邮件地址，你可以使用电子邮件输入控件。那些支持HTML5验证机制的浏览器将检查用户提供的信息是不是一个格式正确的电子邮件地址。有些智能手机输入电子邮件地址时还会对其键盘布局进行优化，使得键盘可以显示最有可能用到的按键（比如@符号）
* type = "url"：在你需要用户提供网页地址时，可以使用URL输入控件。那些支持HTML5验证机制的浏览器将检查用户所提供的信息是否符合URL的格式。有些智能收集在你输入URL时还会对其键盘布局进行优化。

~~~html
<form action = "http://www.example.org/profile.php">
    <p>
        Please enter your website address:
    </p>
    <input type = "url" name = "website" />
    <input type = "submit" value = "Submit" />
</form>
~~~

![image-20220729020716256](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220729020716256.png)

## HTML5：搜索输入控件

`<input>`

如果你想为搜索查询创建一个单行文本框，可使用HTML5为此提供一个专用输入控件。

* type = "search"：创建HTML5的搜索框，应将`<input>`元素的type特性值设置为search，旧浏览器会显示文本框。
* placeholder：在任何文本输入控件上，好可以使用一个名为placeholder的特性，在用户单击文本输入区域之前，文本框内显示的文本就是placeholder特性的值。

~~~html
<form action = "http://www.example.org/search.php">
    <p>
        Search：
    </p>
    <input type = "search" name = "search" placeholder = "Enter keyword" />
    <input type = "submit" value = "Search" />
</form>
~~~

![image-20220729025948421](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220729025948421.png)

# 其他标记

## DOCTYPE（文档类型）

由于HTML存在多个版本，因此每个页面的开头都应该用一个DOCTYPE声明来告诉浏览器此页面是用来HTML的哪个版本。

由于XHTML是采用XML编写的，因此有时你会看到使用了严格版XHTML DOCTYPE 的页面以一个可选的XML声明开头

~~~html
HTML5
<!DOCTYPE html>

XML声明
<?xml version="1.0" ?>
~~~

HTML中注释

~~~html
<!-- comment goes here -->
~~~

## id特性

每个HTML元素都可以附带id特性。id特性用来从页面上的其他元素中对一个元素进行唯一标识，它的值应该以字母或下划线开头。

## class特性

每个HTML元素都可以附带一个class特性，有时候，你希望有一种方法可以指定多个元素并将这些元素和页面上的其他元素区分出来，而不是单独指定文档中的某个元素。

## 块级元素

有些元素在浏览器窗口中显示时总是另起一行。这些元素被称为**块级**元素如`<h1>、<p>、<li>等`

## 内联元素

有些元素在显示时总是与它的邻近元素出现在同一行内。这些元素被称为**内联**元素如`<a>、<b>、<em>、<img>等`

## 将文本和元素集中在一个块级元素中

`<div>`

`<div>`元素允许你将一组元素集中到一个块级元素内。

如果在`<div>`元素上使用id特性或者class特性，就意味着你可以通过创建CSS规则来指定`<div>`元素会在屏幕上占据多少空间，还可以改变其内部所有元素的外观。

## 将文本和元素集中在一个内联元素中

`<span>`

`<span>`元素就像是`<div>`元素的内联版本。它用来：

* 在没有其他合适元素的情况下包含一段文本并将其与周围的文本区别开
* 包含若干个内联元素

人们使用`<span>`元素最常见的原因就是可以利用CSS来控制`<span>`元素中的内容的外观。

你经常会看到`<class>`特性或id特性用于`<span>`元素.

* 解释这个`<span>`元素的作用
* 这样就可以在这些具有特定class或id特性值的元素上应用CSS样式

## 内联框架

`<iframe>`

内联框架就像在你的网页里分隔的小窗口——你可以在这个小窗口中看到另一个网页。`<iframe>`这一术语是inline frame（内联框架的缩写）。

内联框架是由`<iframe>`元素创建的。你有必要知道如何使用它的几个特性：

* src：特性指定要在框架中显示页面的URL。
* height：特性指定的内联框架高度的像素值
* width：特性指定的内联框架宽度的像素值
* seamless：在HTML5中，一个称为seamless的新特性可以应用在不希望出现滚动条的地方

~~~html
<iframe
    width = "450":
    height = "350":
    src = "http://www.wrxinyue.cn">
</iframe>
<!-- 写在一行比较方便 -->
<iframe src = "http://www.wrxinyue.cn" width = "450" height = "350"></iframe>
~~~

![image-20220729180846171](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220729180846171.png)

## 页面信息

`<meta>`

`<meta>`元素位于`<head>`元素中并包含着所在页面的相关信息。

`<meta>`元素是空元素，所以它没有结束标签。它通过特性来携带信息。

最常用的特性是name特性和content特性，它们还经常同时出现。这些特性用来指定页面的某些特性。name特性的值就是你要设定的属性，而content特性的值就是你想给这个属性的值。

第一个`<meta>`元素的name特性表明此元素要为该页面指定一段描述信息。**content**特性是指定这段描述信息的位置。

name特性的值可以任意指定，该特性的一些常用的值有：

* description：用于包含一段关于页面的描述信息。
* keywords：用于包含一组以逗号分隔的关键词列表，用户可以通过这些关键词来找到这个页面。
* robots：用于指定搜索引擎是否可以将这个页面加入到它们的搜索结果中。如果不希望页面加入搜索结果，可以使用值noindex。如果希望搜索引擎将该页面加入搜索结果，但不要收录页面上的链接的其他页面，可以使用值nofollow

`<meta>`元素还会成对使用http-equiv特性和content特性。在下面的示例中，可以看到http-equiv特性的三个实例。每个实例都有各自的用途：

~~~html
<!DOCTYPE html>
<html>
    <head>
        <title>Information About Your Pages</title>
        <meta name = "description" content = "WRXinYue’s blog" />
        <meta name = "keywords" content = "blog,wrxinyue,web,unity" />
        <meta name = "robots" content = "nofollow" />
        <meta http-equiv = "author" content = "WRXinYue" />
        <meta http-equiv = "pragma" content = "no-cache" />
        <meta http-equiv = "expires" content = "Fri, 04 Apr 2022 00:00:00 GMT" />
    </head>
    <body>
    </body>
</html>
~~~

* author ：用于定义网页的设计者
* pragma：用于防止浏览器对页面的缓存
* expires：由于浏览器经常缓存页面的内容，expires选项可以用来指定页面的过期时间（以及缓存的有效期）

## 转义字符

有一些字符用于编写HTML代码并作为HTML的保留字符（例如，左尖括号和右尖括号）

参考表：https://tool.oschina.net/commons?type=2

# 视频和音频

## HTML5：向网页添加视频

`<vodeo>`

`<vodeo>`元素有很多特性用于控制视频的播放：

* src：该特性指定视频的路径。
* poster：在视频加载时或在视频播放之前，该特性用于指定在播放器中显示一个图像。
* width，height：这两个特性用像素值指定播放器的大小。
* controls：如果使用该特性，就表示浏览器需要提供默认的播放控件。
* autoplay：如果使用了该特性，就表示视频文件应该自动播放。
* loop：如果使用该特性，就表示在视频结束之后重新播放。
* preload：该特性告诉浏览器在页面加载时需要做什么。它可以选用以下三个值：
  * none：该值表示在用户按下播按钮之前，浏览器不必加载视频。
  * auto：该值表示浏览器应该在页面加载时载入视频。
  * metadata：该值表示浏览器只需收集少量视频信息，比如大小、首帧图像、播放列表和持续时间。

~~~html
<!DOCTYPE html>
<html>
    <head>
        <title>Adding HTML5 Video</title>
    </head>
    <body>
        <video src = "video/puppy.mp4"
               poster = "images/puppy.jpg"
               width = "400" height = "300"
               preload
               controls
               loop>
            <p>
                A video of a puppy playing in the snow
            </p>
        </video>
    </body>
</html>
~~~

![image-20220730001457178](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220730001457178.png)

## HTML5：多个视频源

`<source>`

要指定播放文件的路径，可以在`<video>`元素中使用`<source>`元素可以代替起始标签`<video>`中的src特性

可以使用多个`<source>`元素来指定不同格式的视频。

* src = 该特性用于指定视频的路径。
* type = 需要使用该特性来告诉浏览器视频的格式，不然它会加载一些视频，看看是否可以播放该文件（这会耗费时间并占用宽带）
* codece = 用来对视频进行编码的编码器也在type特性中指出。

```html
<!DOCTYPE html>
<html>
    <head>
        <title>Multiple video Sources</title>
    </head>
    <body>
        <video poster = "images/1.jpg" width = "400" height = "320" preload controls loop >
            <source src = "video/1.mp4" type = 'video/mp4;codecs = "avcl.42E01E, mp4a.40.2"' />
            <source src = "video/1.webm" type = 'video/webm;codecs = "vp8, vorbis"' />
            <p>
                A voideo of a puppy palying in the snow
            </p>
        </video>
    </body>
</html>
```

## HTML5：向网页中添加HTML5音频

使用托管服务：

有些网站允许上传音频，它们还会提供一个可以嵌入到网页的播放器。比如SoundCloud.com和MySpace.com

使用HTML5：

HTML5引入了一个新元素`<audio>`。支持该元素的浏览器会提供默认的控件，和上面以及一样

> 当访问者从网站中的一个网页跳转到另一个网页时，需要如AJAX的技术来加载页面的内容，也正因为如此，有些网站将音频播放器在新窗口中打开，这样听众在页面跳转时音乐就不会中断。

`<audio>`

`<audio>`元素包含许多可以用来控制音频播放的特性：

> src：该特性用于指定音频文件路径。
>
> controls：该特性表明播放器是否显示播放控件。如果没有使用该特性，播放控件就会默认隐藏。可以利用JavaScript来指定个性化控件。
>
> autopplay：该特性的出现表示音频应该自动开始播放。
>
> preload：该特性在播放器没有设置autoplay时告诉浏览器应该做什么。
>
> loop：该特性表示在音频播放结束后进行重新播放。

~~~html
<!DOCTYPE html>
<html>
    <head>
        <title>Adding HTMLs Audio</title>
    </head>
    <body>
        <audio src = "audio/test=audio.ogg" controls autoplay>
            <p>
                This browser does not suppory our audio format.
            </p>
        </audio>
    </body>
</html>
~~~

## HTML5：多个音频源

`<source>`

在起始标签`<audio>`和结束标签`</audio>`之间使用`<source>`元素可以指定多个音频文件(`<source>`元素可以替代起始标签`<audio>`中的src特性)。

> * src：`<source>`元素使用src特性来表示音频文件位于何处。
> * type：type特性还有像在`<video>`元素中那样被广泛用在`<source>`元素中.