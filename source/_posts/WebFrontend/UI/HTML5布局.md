---
title: HTML5布局
date: 2022-08-05 02:37:33.0
updated: 2022-10-26 23:08:09.984
categories: 
- WebFrontend
tags: 
- html
---

# HTML5布局

## 传统的HTML布局

一直以来，网页设计人员都利用`<div>`元素将页面中的相关元素集中在一起（比如那些组成页眉、文章、页脚、侧边栏的元素），并使用class或id特性来指定`<div>`在页面结构中的作用

![image-20220805013034182](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220805013034182.png)

## 新的HTML5布局元素

HTML5引入了一组新的元素，这些元素允许对页面各个部分进行分割。它们的名称直接表明了其中包含的内容。

![image-20220805013340845](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220805013340845.png)

## 页眉和页脚`<header>` `<footer>`

`<header>` 和 `<footer>`元素可以用作：

> * 网站中出现在每个页面顶部的主页眉或底部的主页脚
> * 页面中单独的`<article>`或`<section>`中的页眉或页脚。

~~~html
<header>
    <h1>WRXinYue's blog</h1>
    <nav>
        <ul>
            <li><a href="" class= "curremt">home</a></li>
            <li><a href="">classes</a></li>
            <li><a href="">catering</a></li>
            <li><a href="">about</a></li>
            <li><a href="">contact</a></li>
        </ul>
    </nav>
</header>
~~~

~~~html
<footer>
    $copy: 2022 WRXinYue's blog
</footer>
~~~

## 导航`<nav>`

`<nav>`元素专门用于包含网站的主要导航块，比如网站的主导航。

## 文章`<artcle>`

`<artcle>`元素就像是页面中任意部分（可能是单独存在的部分，也可能是联合出现的某一部分）的一个容器。

它们可以是一个单独的文章、博客日志、评论、论坛帖子，或者任何其他独立的内容。

如果一个页面含多篇文章（或是多个文章摘要），那么每个单独的元素的文章都应个位于其专属的`<article>`元素中

~~~html
<article>
    <figure>
        <img scr = "images/bok-choi.jpg" alt = "Bok Choi" />
        <figcaption>Bok Choi</figcaption>
    </figure>
    <hgroup>
        <h2>二级标题</h2>
    </hgroup>
    <p>
        .......
    </p>
</article>
~~~

## 附属信息`<aside>`

`<aside>`元素有两个作用，具体具有哪种作用取决于其是否位于`<article>`元素中

如果在`<article>`元素内出现时，它应该包含与当前文章相关的信息，而不必涉及页面的整体信息。

当在`<article>`元素外出现，它应该包含与整个页面相关的内容。

## 部分`<section>`

`<section>`元素用于将相关的内容集中到一块，而每个部分通常都带有一个标题。

`<section>`元素不能作为整个页面的容器使用（除非这个页面只包含一个内容）

## 标题组`<hgroup>`

`<hgroup>`元素的作用是将一个或多个`<h1>`到`<h6>`的标题元素组合到一块，将它们当成一个标题看待。

## 图形 `<figure>` `<figcaption>`

它可以用来包含一篇文章正文中引用的任何内容

## 分节元素 `<div>`

在没有合适的元素用来组合一组元素时，仍可以使用`<div>`元素

## 为块级元素添加链接

HTML5允许网页设计人员在包含子元素的块级元素周围添加`<a>`元素。这将使整个块变成一个链接、