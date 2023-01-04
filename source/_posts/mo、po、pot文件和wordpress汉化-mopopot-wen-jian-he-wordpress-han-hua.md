---
title: .mo、po、.pot文件和wordpress汉化
date: 2022-08-07 18:24:44.0
updated: 2022-10-26 23:11:29.002
url: /archives/mopopot-wen-jian-he-wordpress-han-hua
categories: 
- 博客搭建
tags: 
- 博客
- wordpress
---

<h2>.mo、po、和.pot文件介绍</h2>
<blockquote>
<p>MO文件：MO，即机器对象，是一个二进制数据文件，包含了程序所引用的对象数据。它通常被用来翻译程序代码，并可以被加载或导入GNU gettext程序中。</p>
<p>PO文件：PO文件是包含实际翻译的文件。每种语言都会有自己的PO文件，例如，中文会有zh_CN.po文件，法语会有fr.po文件，德语会有de.po，美式英语可能有en_US.po。</p>
<p>POT文件：POT文件是PO文件的模板文件。它们会把所有的翻译字符串留空。一个POT文件本质上是一个没有翻译的空PO文件，只有原始字符串。</p>
</blockquote>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220807172654931.png" alt="image-20220807172654931" /></p>
<h2>wordpress的汉化机制</h2>
<ol>
<li>
<p>在php文件中，需要汉化的地方使用__()或_e()函数进行标识；</p>
<p>​    _()函数<strong>返回</strong>翻译后的字符串，而<code>_e()</code>函数<strong>打印</strong>出翻译后的字符串。其实<code>_e()<em></code>就相当于echo </em>()。</p>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220807182117393.png" alt="image-20220807182117393" /></p>
</li>
<li>
<p>创建.po文件，进行翻译；</p>
</li>
<li>
<p>将.po文件编译成.mo文件；</p>
</li>
<li>
<p>向主题中加载.mo文件。</p>
</li>
</ol>
<h2>poedit的使用方法：</h2>
<p>打开我们的<code>zh_CN.po</code>文件，然后点击翻译-从源代码更新，就可以获取到我们要翻译的单词</p>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220807181803921.png" alt="image-20220807181803921" /></p>
<p>保存之后替换即可</p>
<p>翻译之前：</p>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220807181337697.png" alt="image-20220807181337697" /></p>
<p>翻译之后：</p>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220807181456376.png" alt="image-20220807181456376" /></p>
<h1>后语：</h1>
<h2>什么是GNU gettext？</h2>
<p><a href="https://www.gnu.org/software/gettext/">GNU gettext</a> 是使用最广泛的自由软件国际化工具之一</p>
<p>GNU gettext 工具（msgfmt、xgettext 等）的 Windows 构建，由 Poedit 开发人员维护。</p>
<p>该函数通常具有 _() 别名，以使代码更简单易读。</p>
<p>此外，它提供了 pgettext() 调用，可用于为翻译者提供更多的上下文；还提供了 ngettext()，可以处理目标语言定义的复数类型。</p>
<p>作为广泛传播的工具，它具有很多封装，使其使用相当简单，你也许会想尝试其中之一，例如 <a href="https://freedesktop.org/wiki/Software/intltool/">intltool</a>，而非下面描述的对 gettext 的手动调用。</p>
<h2>关于<a href="https://poedit.net/">Poedit</a></h2>
<blockquote>
<p>Poedit是一个免费增值软件及跨平台的gettext类国际化翻译编辑器，也是同类型软件中最广泛使用的一个。现时它不论在Unix+GTK 或 Windows平台 配合wxWidgets 均有相关版本。</p>
</blockquote>
<h2>参考：</h2>
<p><a href="https://wordpress.stackexchange.com/questions/227822/what-is-the-difference-between-the-po-mo-and-pot-localization-files">https://wordpress.stackexchange.com/questions/227822/what-is-the-difference-between-the-po-mo-and-pot-localization-files</a></p>
<p><a href="https://www.daimajiaoliu.com/daima/6cc27ed6f166400">https://www.daimajiaoliu.com/daima/6cc27ed6f166400</a></p>