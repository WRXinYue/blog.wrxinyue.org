---
title: DOM与数据交互(学习日志)
date: 2022-09-26 00:56:34.0
updated: 2022-10-27 00:04:48.199
categories: 
- WebFrontend
tags: 
- javascript
- dom
---

# day1-初识dom

## dom是什么

DOM就是一个`编程接口`，就是一套`API`。

DOM是针对标记语言（HTML文档、XML等文档）的一套API。

**JS由的三个组成部分**

* ECMAscript (js的语法规范)
* DOM (文档对象模型)
* BOM (浏览器对象模型)

> 注：
>
> * api：学习浏览器向我们提供的操作页面和操作浏览器的api
>
> * DOM：不是js提供的方法，而是html向js提供的api
>
>   DOM树页面渲染完成以后，所有页面中的内容都会被抽象成一个树形结构

**DOM 基本名词**

* 文档：一个HTML页面就叫做一个文档
* 节点：网页中所有内容都是一个节点（标签，元素，文本，注释节点）
* 元素：元素中的标签节点
* 属性：标签的属性



**api分类**

* 节点获取
* 节点操作（修改节点内容的api）
* 用户交互行为 - 事件



页面中的元素都是有内置的类创建的

HTMLElement 类 所有html元素的根类

* HTMLBodyElement
* HTMLInputElement

~~~js
console.log(document.body.constructor.name) //HTMLBodyElement
console.log(document.body instanceof HTMLBodyElement) //true
console.log(document.body instanceof Element) //true
console.log(document.body instanceof Node) //true
console.log(document.body instanceof Text) //false

//log 和 dir 的区别, log展示元素,dir是以树形结构展示元素
console.log(document.body)
console.dir(document.body)
~~~

## DOM 与 HTML

HTML文档是树状结构，根为html；

DOM Tree也是树状结构，根为window或document对象。

html通过DOM API来解析生成DOM Tree

![image-20220925234249240](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220925234249240.png)

## DOM与其他技术的联系

JavaScript 可以通过DOM来访问和操作HTML文档所有的元素。

**JavaScript是一种脚本语言，DOM是用来获得和操作HTML文档的节点属性。**

**JavaScript通常是通过DOM来获得和操作HTML属性的。这就是二者的区别与联系。**

```js
<script>
function test() {
    window.alert('成功');
}
</script>
<input type = button value = '提交' onClick = 'test()'/>
```

第1，2，4，5行是javaScript代码。

第3行是DOM代码（此行一定不要混淆成是JavaScript代码）。这就是JavaScript调用DOM的例子。

第6行是html代码。

## DOM的级别Level

- DOM0：不是W3C规范。
- DOM1：开始是W3C规范。专注于HTML文档和XML文档。
- DOM2：对DOM1增加了`样式表对象模型`
- DOM3：对DOM2增加了`内容模型` (DTD 、Schemas) 和`文档验证`。

![image-20220925234141261](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220925234141261.png)

## DOM节点类型

DOM（文档对象模型）是针对 HTML和 XML文档的一个API（应用程序编程接口）。

DOM描绘了一个层次化的节点树，允许开发人员添加、移除和修改页面的某一部分。

DOM将整个页面映射为一个由层次节点组成的文件。有1级、2级、3级共三个级别。



**节点分类**

dom一级有一个Node类,这个类里面存储了所有节点类型

Node类中有个方法叫nodeType 专门用于检测节点的类型，返回时一个数值:

* document - dom的入口节点 9
* 元素节点 - html标签 1
* 文本节点 - 页面中的文字 3
* 注释节点 - 注释节点 8

~~~js
let ele = document.body //获取到body标签
console.log(ele.nodeType) //1元素节点
let son = ele.firstChild
console.log(son.nodeType) //8注释节点

//nodeName(所有节点都能访问的属性) 和 tagName (元素节点独有的属性)
console.log(ele.nodeName) //节点名称 BODY
console.log(ele.tagName)  //节点名称 BODY

console.log(son.tagName) //undefined
console.log(som.nodeName) //#comment
~~~

## 获取节点

**获取元素的节点**



Es5获取元素的api：

~~~js
getElementById(str) //str是元素的id名
getElementById(str) //str是元素的id名
getElementsByTagName(str) //str是元素的标签名称
~~~



H5获取元素的方式:

~~~js
querySelector(str) 获取满足str选择器的单个元素
querySelectorAll(str) 获取满足str选择器的所有元素
~~~



通过id名获取 通过id名获取满足条件的第一个元素：

~~~js
let oApp = document.getElementById('app')
~~~



通过class名获取，获取到的是一个类数组，保存的是满足条件的所有元素：

~~~js
let aFirst = document.getElementsByClassName('first')
~~~



通过标签名获取元素：

~~~js
let aP = document.getElementsByTagName('p')
~~~



H5的方式获取元素：

~~~js
let p = 'p'
~~~

获取单个元素

~~~js
let oP = document.querySelector(p)
let oP = document.querySelector('p.first')
let oP = document.querySelector('p[class="first"]')
~~~

获取多个元素

~~~js
let aPP = document.querySelectorAll('p')
~~~



特殊标签获取：

~~~js
let html = document.documentElement
let body = document.body
let head = document.head
et title = document.title //获取到网页的标题

document.title = '123' //修改标签
~~~



**get系列获取标签和query系列获取标签的区别：**

get系列获取到的所有的节点都是动态节点（实时集合），当页面节点更新的时候get元素也会动态更新。

query系列获取到的是一个静态集合，不会实时更新。

## 获取节点属性

**元素的属性和特性**：

* 属性：指的就是在节点下存储的键值对。
* 特性：指的就是获取到元素，元素本身自带（合法标签属性）的标签属性的描述。

~~~js
let oImg = document.querySelector('img')
let oDiv = document.querySelector('div')
~~~

把节点对象当普通对象使用

~~~js
//<img src="https://gimg2.baidu.com/image_search/src=http%3A%2F%2Fc-ssl.duitang.com%2Fuploads%2Fblog%2F202105%2F09%2F20210509225323_2c0c6.thumb.1000_0.jpeg&refer=http%3A%2F%2Fc-ssl.duitang.com&app=2002&size=f9999,10000&q=a80&n=0&g=0n&fmt=auto?sec=1664979662&t=f772af80870fbc53ff44e52ce83ba3cc" alt="我要睡觉了" title="睡觉.png" id="img" class="sleep" is-ok="false" width="300">
//<div id="div" width="123">123</div>
oImg.xixi = 'xixixixi'
oImg.sayName = function(){
      alert(this.tagName)
    }
oImg.isDown = true
console.dir(oImg.xixi)
// oImg.sayName()

console.log(oImg.width)
console.log(oImg.src)

//无法获取自定义的标签属性
console.log(oDiv.width) //undefined
console.log(oDiv.width) //undefined

//class名的获取
console.log(oImg.className) //获取class名称
~~~

