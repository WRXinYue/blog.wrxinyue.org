---
title: Alist美化
date: 2022-07-31 23:30:40.0
updated: 2022-11-06 19:39:55.179
url: /archives/alist-mei-hua
categories: 
- 其他
tags: 
---

[Alist官网](https://github.com/alist-org/alist)

## 效果:

![image-20220731233318449](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220731233318449.png)

参考以下API：
[aplayer、meting](https://github.com/metowolf/MetingJS)
[live2d-widget](https://github.com/stevenjoezhang/live2d-widget)

## 代码：

head：

```html
<style>
    .chakra-ui-light{
      background-image: url("https://www.dmoe.cc/random.php") !important;
      background-repeat:no-repeat;background-size:cover;background-attachment:fixed;background-position-x:center;
    }
    .main-box {
      border-radius: 15px !important;
    }
    .chakra-ui-light .main-box {
      background-color: #ffffff70 !important;
    }
    .chakra-ui-light .readme-box {
      background-color: white !important;
    }
    .readme-box {
      border-radius: 15px !important;
    }
 
</style>
 
<script src="https://eqcn.ajz.miesnfu.com/wp-content/plugins/wp-3d-pony/live2dw/lib/L2Dwidget.min.js"></script>
 
<!-- 看板娘 -->
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/font-awesome/css/font-awesome.min.css">
<script src="https://cdn.jsdelivr.net/gh/stevenjoezhang/live2d-widget@latest/autoload.js"></script>
 
<!--鼠标点击效果-->
<script src="https://cdn.jsdelivr.net/gh/TRHX/CDN-for-itrhx.com@3.0.8/js/maodian.js"></script>
 
<!-- aplayer、meting -->
<!-- require APlayer -->
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/aplayer/dist/APlayer.min.css">
<script src="https://cdn.jsdelivr.net/npm/aplayer/dist/APlayer.min.js"></script>
<!-- require MetingJS -->
<script src="https://cdn.jsdelivr.net/npm/meting@2/dist/Meting.min.js"></script>
 
<!-- nplayer -->
<script src="https://unpkg.com/nplayer@latest/dist/index.min.js"></script>
```

body：

```html
<meting-js 
auto = "https://y.qq.com/n/ryqq/playlist/2970622459.html"
fixed = true
>
</meting-js>
```

