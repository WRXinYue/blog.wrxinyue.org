---
title: 使用PicGo+Github+jsDelivr搭建图床（扩展Typora）
date: 2022-07-17 20:26:50.0
updated: 2022-10-26 22:25:17.138
categories: 
- 博客搭建
tags: 
- github
- 博客
- jsdelivr
---

<h1>前言</h1>
<p>本文内容包括：</p>
<blockquote>
<ul>
<li>创建一个 github 仓库</li>
<li>使用 jsDelivr 免费 CDN 加速图片访问速度</li>
<li>创建 Token</li>
<li>使用 PicGo 配置 github 图床</li>
</ul>
</blockquote>
<p>众所周知网站图片是会影响云服务器性能，在我们这些小博客网站流量是非常有限的，为了避免网站性能降低我们除了压缩媒体文件还可以通过远程调用的方法，也就是用一个单独的云服务器存放媒体，如用一个专门的图床网站或者阿里云OSS对象存储之类的作为网站图床。</p>
<p>什么是图床：</p>
<blockquote>
<p>图床一般是指储存图片的服务器，有国内和国外之分。国外的图床由于有空间距离等因素决定访问速度很慢影响图片显示速度。国内也分为单线空间、多线空间和cdn加速三种。</p>
<p>图床就是专门用来存放图片，同时允许你把图片对外连接的网上空间，不少图床都是免费的。</p>
</blockquote>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/021357282173530.jpg" alt="img" /></p>
<h2>使用PicGo+GitHub+jsDelivr搭建图床</h2>
<h3>配置Github</h3>
<ol>
<li>登陆github账号创建新的仓库</li>
</ol>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220717192813938.png" alt="image-20220717192813938" /></p>
<ol start="2">
<li>填写仓库属性</li>
</ol>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220717193516646.png" alt="image-20220717193516646" /></p>
<ol start="3">
<li>
<p>点击头像-Settings-Developer settings-Personal access tokens-Generate new token
<img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220717193812726.png" alt="image-20220717193812726" /><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220717194039681.png" alt="image-20220717194039681" style="zoom: 50%;" /><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220717194216180.png" alt="image-20220717194216180" /><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220717194452344.png" alt="image-20220717194452344" /></p>
</li>
<li>
<p>填写内容
<img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220717194816210.png" alt="image-20220717194816210" /></p>
</li>
<li>
<p>复制token
<img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220717195046107.png" alt="image-20220717195046107" /></p>
</li>
</ol>
<h3>配置PicGo</h3>
<p><a href="https://github.com/Molunerfinn/PicGo/releases">PicGo官方下载链接</a>
<img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220717195901602.png" alt="image-20220717195901602" /></p>
<ul>
<li>仓库名即为你的github账号/图片仓库名</li>
<li>分支名我在这里使用master</li>
<li>Token 就填写刚才我们生成的 Token</li>
<li>存储路径如果需要指定子目录可以填写例如 img/  如果没有填，就会上传到图片仓库的根目录。</li>
<li>自定义域名就填写 jsDelivr 的域名，即图片访问地址，不包括图片路径的前半部分，</li>
<li><a href="https://cdn.jsdelivr.net/gh/用户名/仓库名">https://cdn.jsdelivr.net/gh/用户名/仓库名</a></li>
<li>最后设为默认图床，下次在 typora 上传图片就会自动上传到 github 图床了。</li>
</ul>
<h2>扩展</h2>
<p>图片粘贴到Typora后，自动把图片上传到配置好的图床上</p>
<h3>配置Typora</h3>
<p>文件-偏好设置-图像</p>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220717201003688.png" alt="image-20220717201003688" /></p>