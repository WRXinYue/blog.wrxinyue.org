---
title: BOM
date: 2022-08-15 02:52:43.0
updated: 2022-10-27 00:11:55.391
url: /archives/bom
categories: 
- WebFrontend
tags: 
- javascript
- bom
---

* BOM（Browser object Model）：浏览器对象模型
* 其实就是操作浏览器的一些能力
* 我们可以操作哪些内容
  * 获取一些浏览器的相关信息（窗口的大小）
  * 操作浏览器进行页面跳转
  * 获取当前浏览器地址栏的信息
  * 浏览器的信息（浏览器的版本）
  * 让浏览器出现一个弹出框（alert/confirm/prompt）
  * ...
* BOM的核心就是window对象
* window是浏览器内置的一个对象，里面包含着操作浏览器的方法

### 重要事件

- onresize

  宽口大小发生改变的时候触发。

- onscroll

  页面滚动的时候触发，也可以用于某个元素节点上。

- onfocus onblur

  进入页面和离开页面时触发，也可以用于其他能获得焦点的元素节点上。

- 打开与关闭窗口

  open() close()

### 重要对象

- location

  获取/设置 URL相关的属性。

- history

  操作当前标签页的历史，类似于点击浏览器地址栏左侧的前进和后退按钮。

  `history.go(number)` -- 前进或后退指定的页面数。

  `history.back()` -- 后退一页。

  `history.forward()` -- 前进一页。

- navigator

  获取浏览器相关的信息。

- Screen

  获取用户显示屏幕的各种信息。

  `.width .height` 获取显示器分辨率。

  `.availWidth .availHeight` 获取除去任务栏的大小。

## 各种尺寸获取

### 可视区宽高

- 窗口宽高

  `window.innerWidth window.innerHeight`

  包含了滚动条的宽度和浏览器本身的边框宽度（低版本IE不支持）。

- 内容区宽高

  `document.documentElement.clientWidth`

  `document.documentElement.clientHeight`

  不包含滚动条等。

### 元素的各种宽高

- client

  `clientWidth clientHeight`

  宽(高)+padding。

- offset

  `offsetWidth offssetHeight`

  宽(高)+padding+border。

- scroll

  `scrollWidth / scrollHeigh`

  内容的实际高度，当内容没超出相当于client，当内容超出之后，会得到包括超出内容的实际高度，即使加了超出隐藏，也还是会得到内容所占的实际高度。

### 元素的各种距离

- offset

  `offsetLeft offsetTop`

  获取左边（上边），到定位父级的左边（上边）的距离。

- `getBoundingClientRect`

  返回一个对象，包含了元素各边到窗口的距离，返回的结构类似于：{top:100,left:20,bottom:500,right:890}。

### 滚动距离

- 页面滚动宽高

  `doucment.documentElement.scrollTop`

  `document.documentElement.scrollLeft`

  页面的滚动宽（高）。此属性可以赋值，能让页面滚动到指定的位置。

  设置滚动距离也可以使用`window.scrollTo()`。

- 元素滚动宽高

  `元素节点.scrollTop 元素节点.scrollLeft`