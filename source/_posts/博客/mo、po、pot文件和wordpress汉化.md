---
title: .mo、po、.pot文件和wordpress汉化
date: 2022-08-07 18:24:44.0
updated: 2022-10-26 23:11:29.002
url: /archives/mopopot-wen-jian-he-wordpress-han-hua
categories: 
- 博客
tags: 
- wordpress
---

## .mo、po、和.pot文件介绍

> MO文件：MO，即机器对象，是一个二进制数据文件，包含了程序所引用的对象数据。它通常被用来翻译程序代码，并可以被加载或导入GNU gettext程序中。
>
> PO文件：PO文件是包含实际翻译的文件。每种语言都会有自己的PO文件，例如，中文会有zh_CN文件，法语会有fr.po文件，德语会有de.po，美式英语可能有en_US.po。
>
> POT文件：POT文件是PO文件的模板文件。它们会把所有的翻译字符串留空。一个POT文件本质上是一个没有翻译的空PO文件，只有原始字符串。

![image-20220807172654931](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220807172654931.png)

## wordpress的汉化机制

1. 在php文件中，需要汉化的地方使用__()或_e()函数进行标识；

   ​	_()函数**返回**翻译后的字符串，而`__e()`函数**打印**出翻译后的字符串。其实`__e()`就相当于echo __()。

   ![image-20220807182117393](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220807182117393.png)

2. 创建.po文件，进行翻译；

3. 将.po文件编译成.mo文件；

4. 向主题中加载.mo文件。

## poedit的使用方法：

打开我们的`zh_CN.po`文件，然后点击翻译-从源代码更新，就可以获取到我们要翻译的单词

![image-20220807181803921](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220807181803921.png)

保存之后替换即可

翻译之前：

![image-20220807181337697](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220807181337697.png)

翻译之后：

![image-20220807181456376](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220807181456376.png)

# 后语：

## 什么是GNU gettext？

[GNU gettext](https://www.gnu.org/software/gettext/) 是使用最广泛的自由软件国际化工具之一

GNU gettext 工具（msgfmt、xgettext 等）的 Windows 构建，由 Poedit 开发人员维护。

该函数通常具有 _() 别名，以使代码更简单易读。

此外，它提供了 pgettext() 调用，可用于为翻译者提供更多的上下文；还提供了 ngettext()，可以处理目标语言定义的复数类型。

作为广泛传播的工具，它具有很多封装，使其使用相当简单，你也许会想尝试其中之一，例如 [intltool](https://freedesktop.org/wiki/Software/intltool/)，而非下面描述的对 gettext 的手动调用。

## 关于[Poedit](https://poedit.net/)

> Poedit是一个免费增值软件及跨平台的gettext类国际化翻译编辑器，也是同类型软件中最广泛使用的一个。现时它不论在Unix+GTK 或 Windows平台 配合wxWidgets 均有相关版本。

## 参考：

https://wordpress.stackexchange.com/questions/227822/what-is-the-difference-between-the-po-mo-and-pot-localization-files

https://www.daimajiaoliu.com/daima/6cc27ed6f166400