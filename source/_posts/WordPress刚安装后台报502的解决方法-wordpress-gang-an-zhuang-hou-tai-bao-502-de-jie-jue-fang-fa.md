---
title: WordPress刚安装后台报502的解决方法
date: 2022-07-26 19:00:28.0
updated: 2022-10-26 23:11:14.755
url: /archives/wordpress-gang-an-zhuang-hou-tai-bao-502-de-jie-jue-fang-fa
categories: 
- 博客搭建
tags: 
- 博客
- bug
- wordpress
---

<p>我的主机版本选择：</p>
<blockquote>
<ul>
<li>系统：CentOS 8.2 64bit</li>
<li>Nginx：1.20.2</li>
<li>PHP：7.4</li>
<li>WordPress：6.0.1</li>
</ul>
</blockquote>
<p>本机版本选择</p>
<blockquote>
<ul>
<li>系统：CentOS 8.3 64bit</li>
<li>Nginx：1.20.1</li>
<li>PHP：7.4</li>
<li>WordPress：6.0.1</li>
</ul>
</blockquote>
<p>附上博客搭建教程：<a href="https://blog.naibabiji.com/an-zhuang-wordpress">https://blog.naibabiji.com/an-zhuang-wordpress</a></p>
<p>关于我怎么发现这个问题，说来话长。我有两个服务器第一个服务器用来搭建博客网站，第二个一直是闲置的，本来想用第二个服务器来练习制作WordPress主题。主页能正常运行，进入后台一直是502。最开始我以为还是防火墙的问题，直到我把全部端口都放行也还是502，Nginx换成Apache登后台照样报错，php也正常运行，折腾一下午。然后php换了个版本，换成php8.0才登入后台，真是邪了门了</p>