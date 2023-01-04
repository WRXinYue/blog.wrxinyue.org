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

<p>复习以下HTML和CSS基础知识，参考书籍：《HTML&amp;CSS设计与构造网站》,HTML和CSS分开写，写这个笔记花了四天时间（看来摸鱼摸多了）</p>
<h1>结构</h1>
<h2>HTML描述页面的结构</h2>
<p>HTML代码由包括含在尖括号种的字符构成，这些代码称为HTML元素。元素通常由两个标签构成：一个起始标签和一个结束标签（结束标签要多一个斜杠）。每个HTML元素都会向浏览器传达起始标签和结束标签之间的内容的结构信息。</p>
<p>标签的作用就像是容器。它们告诉你起始标签和结束标签之间的内容的结构信息。</p>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220727205551238.png" alt="image-20220727205551238" /></p>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220727205655417.png" alt="image-20220727205655417" /></p>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220727205704320.png" alt="image-20220727205704320" /></p>
<h2>特性</h2>
<p>特性提供有关元素中内容的附加信息。它们出现在元素起始标签中，并由特性<strong>名称</strong>和特性<strong>值</strong>组成，中间由等号隔开。</p>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220727210210558.png" alt="image-20220727210210558" /></p>
<h1>文本</h1>
<ul>
<li>结构化标记：用来描述标题和段落的元素。</li>
<li>语义化标记：表达特定含义的标记。</li>
</ul>
<h2>标题</h2>
<pre><code class="language-html">&lt;h1&gt;&lt;/h1&gt;
~
&lt;h6&gt;</code></pre>
<h2>粗体斜体</h2>
<pre><code class="language-html">&lt;b&gt;&lt;/b&gt; //粗体
&lt;i&gt;&lt;/i&gt; //斜体</code></pre>
<h2>上标和下标</h2>
<pre><code class="language-html">&lt;sup&gt;&lt;/sup&gt;//如2²
&lt;sub&gt;&lt;/sub&gt;//如H₂O</code></pre>
<h2>空白</h2>
<p>当浏览器遇到两个或两个以上的连续空格时，只将其显示为一个空格。这一特性称为<strong>白色空间折叠</strong>.</p>
<h2>换行和水平线</h2>
<pre><code class="language-html">&lt;br /&gt;//换行符
&lt;hr /&gt;//上下文章分割线</code></pre>
<h2>语义化标记</h2>
<p>有一些元素，它们不不影响网页结构，却为所在的页面添加了格外信息——这些元素称为语义化标记。</p>
<p>如em和blockquote这些标签</p>
<h2>加粗和强调</h2>
<pre><code class="language-html">&lt;strong&gt;元素的作用是表示其中的内容十分重要。默认情况显示为粗体&lt;/strong&gt;
&lt;em&gt;元素其强调作用，能够细微改变语句的含义&lt;/em&gt; </code></pre>
<h2>引用</h2>
<p>这两个元素都可以用cite特性来表面引用的来源。cite</p>
<pre><code class="language-html">&lt;blockquote cite=&quot;www.wrxinyue.cn&quot;&gt;&lt;/blockquote&gt;
&lt;q&gt;标记段落较短引用&lt;/q&gt;</code></pre>
<h2>缩写词和首字母缩写词</h2>
<pre><code class="language-html">&lt;p&gt;&lt;abbr title=&quot;Professor&quot;&gt;Prof&lt;/abbr&gt;...&lt;/p&gt;
&lt;p&gt;&lt;acronym title=&quot;Professor&quot;&gt;Prof&lt;/acronym&gt;...&lt;/p&gt;</code></pre>
<h2>引文和定义</h2>
<pre><code class="language-html">&lt;cite&gt;元素可以用来表明引用的来源&lt;/cite&gt;
&lt;dfn&gt;元素用来表示一个新术语定义&lt;/dfn&gt;</code></pre>
<h2>设计者详细信息</h2>
<pre><code class="language-html">&lt;address&gt;元素有一个非常特殊的用途：包含页面设计者的联系详情&lt;/address&gt;</code></pre>
<h2>内容的修改</h2>
<pre><code class="language-html">&lt;ins&gt;下划线&lt;/ins&gt;
&lt;del&gt;删除线&lt;/del&gt;
&lt;s&gt;元素表示不准确或不相关却不应当予以删除的内容&lt;/s&gt;</code></pre>
<h1>列表</h1>
<h2>有序列表</h2>
<pre><code class="language-html">&lt;ol&gt;//使用由该元素来创建有序列表
    &lt;li&gt;有序列表1&lt;/li&gt;
    &lt;li&gt;有序列表2&lt;/li&gt;
    &lt;li&gt;有序列表3&lt;/li&gt;
    &lt;li&gt;有序列表4&lt;/li&gt;
&lt;/ol&gt;</code></pre>
<h2>无序列表</h2>
<pre><code class="language-html">&lt;ul&gt;
    &lt;li&gt;无序列表&lt;/li&gt;
    &lt;li&gt;无序列表&lt;/li&gt;
    &lt;li&gt;无序列表&lt;/li&gt;
    &lt;li&gt;无序列表&lt;/li&gt;
&lt;/ul&gt;</code></pre>
<h2>定义列表</h2>
<pre><code class="language-html">&lt;dl&gt;  //定义列表由该元素创建，并通常包含一系列术语及其定义
    &lt;dt&gt;元素用来包含被定义的术语&lt;/dt&gt;
    &lt;dd&gt;元素用来包含定义&lt;/dd&gt;
&lt;/dl&gt;</code></pre>
<h2>嵌套列表</h2>
<pre><code class="language-html">&lt;ul&gt;
  &lt;li&gt;一级嵌套&lt;/li&gt;
  &lt;li&gt;一级嵌套&lt;/li&gt;
     &lt;ul&gt;
        &lt;li&gt;二级嵌套&lt;/li&gt;
        &lt;li&gt;二级嵌套&lt;/li&gt;
    &lt;/ul&gt;
  &lt;li&gt;一级嵌套&lt;/li&gt;
&lt;/ul&gt;</code></pre>
<h1>链接</h1>
<h2>编写链接</h2>
<pre><code>链接是由&lt;a&gt;元素建立的。用户可以单击位于起始标签&lt;a&gt;和结束标签&lt;/a&gt;之间的任何内容。使用href特性来指定要链接到的页面。

如:
&lt;1 href=&quot;www.wrxinyue.cn&quot;&gt;我的博客地址&lt;/a&gt;</code></pre>
<h2>目录结构</h2>
<p>对于规模较大的网站而言，在管理代码时，更合理的方式是将不同类别的别的页面保存在不同的文件夹中。网站的文件夹有时也称为目录。</p>
<h2>相对URL</h2>
<p>相对URL可用于为网站内部的页面之间建立链接。它用一种简短的方式告诉浏览器去何处查找文件。</p>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220727222749598.png" alt="image-20220727222749598" /></p>
<h2>EMAIL链接</h2>
<pre><code>可以用&lt;a&gt;元素建立email链接

mailto：
&lt;a href=&quot;mailto&quot;:wrxinyue@formax.com&gt;给我发邮件&lt;/a&gt;</code></pre>
<h2>在新窗口打开链接</h2>
<pre><code class="language-html">target:
&lt;a href=&quot;http://www.wrxinyue.cn&quot; target=&quot;_blank&quot;&gt;新的窗口打开链接&lt;/a&gt;</code></pre>
<h2>链接到当前页面的某个特定位置</h2>
<p>只需要使用id特性就可以实现链接达到目标位置目的。</p>
<p>id特性值必须以字母或者下划线开头，同一页面不能出现两个相同id的值。</p>
<p>要连接到一个使用id特性的元素，还需要用到&lt; a&gt;元素，不同的是它的href特性值以#开头，后面跟着你所要链接元素的id特性值。实例：</p>
<pre><code class="language-html">&lt;h1 id=&quot;top&quot;&gt;需要到达的地方&lt;/h1&gt;
&lt;a href=&quot;#top&quot;&gt;点我开始到达&lt;/a&gt;</code></pre>
<h2>链接到其他页面的某个特定位置</h2>
<p>方法和上面类型，添加绝对或者相对链接即可，实列：</p>
<pre><code class="language-html">&lt;a href = &quot;http://www,htmalandcssbook.com/#bottom&quot;&gt;</code></pre>
<h1>图像</h1>
<h2>网站上存储图像</h2>
<p>一般网站图片会存在images文件夹中，但是我会选择使用图床给服务器减少负担</p>
<h2>添加图像</h2>
<p>&lt; img&gt;图像的参数必须包含src和alt参数：</p>
<blockquote>
<ul>
<li>src：图片地址</li>
<li>alt：图片无法显示出现的描述</li>
<li>title：添加图片的附加信息</li>
<li>height：以像素为单位来指定图像的高度</li>
<li>width：以像素为单位来指定图像的宽度</li>
</ul>
</blockquote>
<p>实列：</p>
<pre><code class="language-html">&lt;img src=&quot;images/quokka.jpg&quot; alt=&quot;quokka&quot; title=&quot;......&quot; /&gt;
&lt;img src=&quot;images/quokka.jpg&quot; alt=&quot;quokka&quot; width=&quot;600&quot; height=&quot;450&quot; /&gt;</code></pre>
<h1>表格</h1>
<p>表格以网络形式表示数据。网络中每个块称为表格的一个单元格。</p>
<h2>基本的表格结构</h2>
<pre><code class="language-html">&lt;table&gt;元素用来创建表格
&lt;tr&gt;table row表示每行的开始
&lt;td&gt;wable data，表示表格中的每个单元格
&lt;th&gt;table heading，表示类或行的标题
scope特性来表面此元素是列标题还是行标题。col表示列标题，row表示行标题</code></pre>
<p>实例：</p>
<pre><code class="language-html">&lt;table&gt;
    &lt;tr&gt;
        &lt;th&gt;&lt;/th&gt;
        &lt;th scope = &quot;col&quot;&gt;Saturday&lt;/th&gt;
        &lt;th scope = &quot;col&quot;&gt;Sunday&lt;/th&gt;
    &lt;/tr&gt;
    &lt;tr&gt;
        &lt;th =scope = &quot;row&quot;&gt;Tickets sold:&lt;/th&gt;
        &lt;td&gt;120&lt;/td&gt;
        &lt;td&gt;130&lt;/td&gt;
    &lt;/tr&gt;
    &lt;tr&gt;
        &lt;th scope = &quot;row&quot;&gt;Total sales：&lt;/th&gt;
        &lt;td&gt;$600&lt;/td&gt;
        &lt;td&gt;$675&lt;/td&gt;
    &lt;/tr&gt;
&lt;/table&gt;</code></pre>
<h2>跨列</h2>
<p>可以在&lt; th&gt;或者&lt; td&gt;元素中用colspan特性来表明单元格所要跨越的列数。</p>
<pre><code class="language-html">&lt;table&gt;
    &lt;tr&gt;
        &lt;th&gt;9am&lt;/th&gt;
        &lt;th&gt;10am&lt;/th&gt;
        &lt;th&gt;11am&lt;/th&gt;
        &lt;th&gt;12am&lt;/th&gt;
    &lt;/tr&gt;
    &lt;tr&gt;
        &lt;th&gt;Monday&lt;/th&gt;
        &lt;td colspan = &quot;2&quot;&gt;Geography&lt;/td&gt;
        &lt;td&gt;Math&lt;/td&gt;
        &lt;td&gt;Art&lt;/td&gt;
    &lt;/tr&gt;
    &lt;tr&gt;
        &lt;th&gt;Tuesday&lt;/th&gt;
        &lt;td colspan = &quot;30&quot;&gt;Gym&lt;/td&gt;
        &lt;td&gt;Home Ec&lt;/td&gt;
    &lt;/tr&gt;
&lt;/table&gt;</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220728111027574.png" alt="image-20220728111027574" /></p>
<h2>跨行</h2>
<p>和跨列差不多在&lt; th&gt;或者&lt; td&gt;元素中用rowspan特性来表明单元格所要跨越的行数</p>
<pre><code class="language-html">&lt;table&gt;
    &lt;tr&gt;
        &lt;th&gt;&lt;/th&gt;
        &lt;th&gt;ABC&lt;/th&gt;
        &lt;th&gt;BBC&lt;/th&gt;
        &lt;th&gt;CNN&lt;/th&gt;
    &lt;/tr&gt;
    &lt;tr&gt;
        &lt;th&gt;6pm * 7pm&lt;/th&gt;
        &lt;td rowspan = &quot;2&quot;&gt;Movie&lt;/td&gt;
        &lt;td&gt;Comedy&lt;/td&gt;
        &lt;td&gt;News&lt;/td&gt;
    &lt;/tr&gt;
    &lt;tr&gt;
        &lt;th&gt;7pm * 8pm&lt;/th&gt;
        &lt;td&gt;Sport&lt;/td&gt;
        &lt;td&gt;Current Affairs&lt;/td&gt;
    &lt;/tr&gt;
&lt;/table&gt;</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220728111700007.png" alt="image-20220728111700007" /></p>
<h2>长表格</h2>
<pre><code class="language-html">&lt;thead&gt;//表格标题
&lt;tbody&gt;//表格主体
&lt;tfoot&gt;//表格脚注</code></pre>
<p>实列：</p>
<pre><code class="language-html">&lt;table&gt;
    &lt;thead&gt;
        &lt;tr&gt;
            &lt;th&gt;Date&lt;/th&gt;
            &lt;th&gt;Income&lt;/th&gt;
            &lt;th&gt;Expenditure&lt;/th&gt;
        &lt;/tr&gt;
    &lt;/thead&gt;
    &lt;tbody&gt;
        &lt;tr&gt;
            &lt;th&gt;1st January&lt;/th&gt;
            &lt;td&gt;250&lt;/td&gt;
            &lt;td&gt;36&lt;/td&gt;
        &lt;/tr&gt;
        &lt;tr&gt;
            &lt;th&gt;2nd January&lt;/th&gt;
            &lt;td&gt;285&lt;/td&gt;
            &lt;td&gt;48&lt;/td&gt;
        &lt;/tr&gt;
        &lt;!-- additional rows as above --&gt;
        &lt;tr&gt;
            &lt;th&gt;31st January&lt;/th&gt;
            &lt;td&gt;129&lt;/td&gt;
            &lt;td&gt;64&lt;/td&gt;
        &lt;/tr&gt;
    &lt;/tbody&gt;
    &lt;tfoot&gt;
        &lt;tr&gt;
            &lt;td&gt;&lt;/td&gt;
            &lt;td&gt;7824&lt;/td&gt;
            &lt;td&gt;1241&lt;/td&gt;
        &lt;/tr&gt;
    &lt;/tfoot&gt;
&lt;/table&gt;</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220728113037759.png" alt="image-20220728113037759" /></p>
<h1>表单</h1>
<h2>表单概述</h2>
<p>网络最知名的表单大概就要术语Google主页中的搜索框了。除了可以让用户进行搜索。表单还可以让用户在线完成其他功能</p>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220728113619686.png" alt="image-20220728113619686" /></p>
<h2>表单控件</h2>
<p>添加文本：</p>
<blockquote>
<ul>
<li>单行文本框Texi input：用于单行文本</li>
<li>密码框Password input：类似于单行文本框，但它会掩盖输入其中的字符</li>
<li>文本域Text area：用于较长的文本，例如消息和评论</li>
</ul>
</blockquote>
<p>进行选择：</p>
<blockquote>
<ul>
<li>单选按钮Radio buttons：用户必须选择多个选项中的一个使用</li>
<li>复选框Checkboxes：用户可以选择一个或多个选项时使用</li>
<li>下拉列表Drop-down boxes：用户必须从一个选项列表中挑选其中之一时使用</li>
</ul>
</blockquote>
<p>提交表单：</p>
<blockquote>
<ul>
<li>提交按钮Submit buttons：从当前表单向另一个网页提交数据</li>
<li>图像按钮Image buttons：类似于提交按钮，但只能提交图片</li>
</ul>
</blockquote>
<p>上传文件：</p>
<blockquote>
<ul>
<li>允许用户把文件（例如图片）上传到网站。</li>
</ul>
</blockquote>
<h2>表单结构</h2>
<p><code>&lt;form&gt;</code>每个表单都位于<code>&lt;form&gt;</code>元素中。每个<code>&lt;form&gt;</code>元素都要设置action特性，通常还有要设置method特性和id特性。</p>
<ul>
<li>
<p>action：其特性值时服务器上一个页面的URL，这个页面用来在用户提交表单时接受表单的信息</p>
</li>
<li>
<p>method：提交表单可以采用get或者post方法。</p>
<ul>
<li>
<p>get方法：表单中的值附加在由action特性所指定的URL末尾。get方法适用以下情形</p>
</li>
<li>
<p>短表单（例如搜索框）</p>
</li>
<li>
<p>只从Web服务器上检索数据的情形（不发送那些要在数据库中添加或删除的数据）</p>
</li>
<li>
<p>post方法：表单的值被放在HTTP头信息进行发送，如果出现以下情形就用post方法</p>
</li>
<li>
<p>允许用户上传文件</p>
</li>
<li>
<p>非常长</p>
</li>
<li>
<p>包含敏感信息（例如密码等）</p>
</li>
<li>
<p>向数据库中添加或删除信息</p>
</li>
</ul>
</li>
<li>
<p>id：它的值是用来在页面上众多元素中对表单进行唯一性的标识（也常用在脚本中-例如检查你是否在那些需要信息的区域中填写了信息）</p>
</li>
</ul>
<pre><code class="language-html">&lt;form action=&quot;http://www.example.com/subscribe.php&quot; mothod=&quot;get&quot;&gt;
    &lt;p&gt;
        This is where the from controls will appear
    &lt;/p&gt;
&lt;/form&gt;</code></pre>
<h2>单行文本框</h2>
<p><code>&lt;input&gt;</code>元素用来创建多种不同的表单控件，其type特性的值决定了他将要创建哪种控件</p>
<ul>
<li>type = “text”：当type特性的值为text时，&lt; input&gt;元素会创建一个单行文本框。</li>
<li>name：这个特性的值对表单控件进行标识并与输入的信息一同传送到服务器</li>
<li>maxlength：这个特性可以用来限制用户在文本区域输入字符的数量，它的值为用户可以输入字符的最大数量</li>
</ul>
<pre><code class="language-html">&lt;form action = &quot;http://www.example.com/login.php&quot;&gt;
    &lt;p&gt;
        &lt;input type = &quot;text&quot; name &quot;username&quot; size = &quot;15&quot; maxlength = &quot;30&quot; /&gt;
    &lt;/p&gt;
&lt;/form&gt;</code></pre>
<h2>密码框</h2>
<p>为了保证绝对的安全，就要设置服务器通过安全套接层（SSL）与用户的浏览器进行连接。</p>
<ul>
<li>type = &quot;password&quot;：当type特性的值为password时，&lt; input&gt;</li>
<li>name ：这个特性表明密码框的名称，它将与用户输入的代码一同发送到服务器</li>
<li>size，maxlength ：密码框也会可以像单行文本框一样设置size特性和maxlength特性</li>
</ul>
<h2>文本域（多行文本框）</h2>
<p>&lt; textarea&gt;元素用来创建多行文本框。</p>
<pre><code class="language-html">&lt;form action = &quot;http://www.example.com/comments.php&quot;&gt;
    &lt;P&gt;
        What did you think of this gig
    &lt;/P&gt;
    &lt;textarea name = &quot;comments&quot; cols = &quot;20&quot; rows = &quot;4&quot;&gt;Enter your comments .....&lt;/textarea&gt;
&lt;/form&gt;</code></pre>
<h2>单选按钮</h2>
<p><code>&lt;input&gt;</code></p>
<ul>
<li>type = &quot;radio&quot;：单选按钮只让用户从一个选项中选择其中一个</li>
<li>name：将用户所选择选项的值一同发送到服务器中</li>
<li>value：为选项指定了被选中时要发送到服务器的值</li>
<li>cheacked：用来指定当页面加载时哪个值</li>
</ul>
<pre><code class="language-html">&lt;form action = &quot;httpL//www.example.com/profile.php&quot;&gt;
    &lt;p&gt;
        Please select your favorite genre:
        &lt;br /&gt;
        &lt;input type = &quot;radio&quot; name = &quot;genre&quot; value = &quot;rock&quot; checked = &quot;checked&quot; /&gt; Rpck
        &lt;input type = &quot;radio&quot; name = &quot;genre&quot; value = &quot;pop&quot; /&gt; Pop
        &lt;input type = &quot;radio&quot; name = &quot;genre&quot; value = &quot;jazz&quot; /&gt; Jazz
    &lt;/p&gt;
&lt;/form&gt;</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220728163318275.png" alt="image-20220728163318275" /></p>
<h2>复选框</h2>
<p>&lt; input&gt;</p>
<ul>
<li>type = &quot;checkbox&quot;复选框允许用户在回答一个问题时选择（和取消选择）一个或多个选项。</li>
<li>name：将用户所选择选项的值一同发送到服务器中</li>
<li>value：为选项指定了被选中时要发送到服务器的值</li>
<li>checked：用来指定当页面加载时哪个值</li>
</ul>
<pre><code class="language-html">&lt;form action = &quot;http://www.example.com/profile.php&quot;&gt;
    &lt;P&gt;
        Please select your favorite music service(s);
        &lt;br /&gt;
        &lt;input type = &quot;checkbox&quot; name = &quot;service&quot; value = &quot;itunes&quot; checked = &quot;checked&quot; /&gt; iTunes
        &lt;input type = &quot;checkbox&quot; name = &quot;service&quot; value = &quot;lastfm&quot; /&gt; Last.fm
        &lt;input type = &quot;checkbox&quot; name = &quot;service&quot; value = &quot;spotify&quot; /&gt; Spotify 
    &lt;/P&gt;
&lt;/form&gt;</code></pre>
<h2>下拉列表框</h2>
<p><code>&lt;slect&gt;</code></p>
<p>该元素用来创建下拉列表框，它包含两个或者两个以上的<code>&lt;option&gt;</code>元素</p>
<ul>
<li>name：指定这个表单控件名称，此名称与用户选项值一并发送到服务器。</li>
</ul>
<p><code>&lt;option&gt;</code></p>
<p>该元素用于指定用户可以选择的选项。</p>
<ul>
<li>value：<code>option</code>元素使用value特性来指定选项的值，如果该选项被选中，那么这个值将与控件的名称一并发送到服务器</li>
<li>selected特性可以用来指定当前页面加载时被选中的选项。selected特性的值应该时selected。</li>
</ul>
<pre><code class="language-html">&lt;form action = &quot;http://www.example.com/profile.php&quot;&gt;
    &lt;p&gt;
        What device do you listen to music on
    &lt;/p&gt;
    &lt;select name = &quot;devices&quot;&gt;
        &lt;option value = &quot;ipod&quot;&gt;iPod&lt;/option&gt;
        &lt;option value = &quot;radio&quot;&gt;Radio&lt;/option&gt;
        &lt;option value = &quot;computer&quot;Computer&lt;/select&gt;
    &lt;/select&gt;
&lt;/form&gt;</code></pre>
<h2>多选框</h2>
<p><code>&lt;select&gt;</code></p>
<ul>
<li>size：可以通过增加size特性的值来将一个下拉列表框变成一个能显示多个选项的列表框</li>
<li>multiple：该特性的值设置为multiple，允许用户从这一列表中选择多个选项</li>
</ul>
<pre><code class="language-html">&lt;form action = &quot;http://www.example.com/profile.php&quot;&gt;
    &lt;p&gt;
        Do you paly any ......
    &lt;/p&gt;
    &lt;select name = &quot;instruments&quot; size = &quot;3&quot; multiple = &quot;multiple&quot;&gt;
        &lt;option value = &quot;guitar&quot; selected = &quot;selected&quot;&gt;Guitar&lt;/option&gt;
        &lt;option value = &quot;drums&quot; Drums&gt;Drums&lt;/option&gt;
        &lt;option value = &quot;keyboard&quot; selected = &quot;selected&quot;&gt;Keyboard&lt;/option&gt;
        &lt;option value = &quot;bass&quot;&gt;Bass&lt;/option&gt;
    &lt;/select&gt;
&lt;/form&gt;</code></pre>
<h2>文件上传域</h2>
<p><code>&lt;input&gt;</code></p>
<p>如果你希望让用户上传文件（例如图像、视频、mp3或者PDF），就需要文件域</p>
<ul>
<li>
<p>type = ”file“：这个类型的input会创建一个后面附有Browse按钮的类似文本框的控件。当用户点击Browse按钮时，会打开一个新窗口来让用户从它们的计算机上选择一个文件上传到网站。</p>
<p>如果允许用户上传文件，必须将<code>&lt;form&gt;</code>元素上的method特性值设置为post（HTTP get方式是不能发送文件的）。</p>
</li>
</ul>
<pre><code class="language-html">&lt;form action = &quot;http://example.com/upload.php&quot; method = &quot;post&quot;&gt;
    &lt;p&gt;
        Upload your song in MP3 format:
    &lt;/p&gt;
    &lt;input type = &quot;file&quot; name = &quot;user song&quot; /&gt;&lt;br /&gt;
    &lt;input type = &quot;submit&quot; value = &quot;Upload&quot; /&gt;
&lt;/form&gt;</code></pre>
<h2>提交按钮</h2>
<p><code>&lt;input&gt;</code></p>
<ul>
<li>type = &quot;submit&quot;：提交按钮用来将表单发送到服务器。</li>
<li>name：可以用name特性但不是必须的</li>
<li>value：用于控制在按钮上显示的文本</li>
</ul>
<pre><code class="language-html">&lt;form action = &quot;http://www.example.com/subscribe.php&quot;&gt;
    &lt;p&gt;
        Subscribe to our email list:
    &lt;/p&gt;
    &lt;input type = &quot;text&quot; name = &quot;email&quot; /&gt;
    &lt;input type = &quot;submit&quot; name = &quot;subscribe&quot; value = &quot;Subscribe&quot; /&gt;
&lt;/form&gt;</code></pre>
<h2>按钮和隐藏控件</h2>
<p><code>&lt;button&gt;</code></p>
<p>引入<code>&lt;button&gt;</code>元素的目的是让用户更好地控制按钮的显示方式，并且允许其他元素出现在<code>&lt;button&gt;</code>元素内</p>
<pre><code class="language-html">&lt;form action = &quot;http://www.example.com/add.php&quot;&gt;
    &lt;button&gt;
        &lt;img scr = &quot;images/add.gif&quot; alt = &quot;add&quot; width = &quot;10&quot; height = &quot;10&quot; /&gt;
        Add
    &lt;/button&gt;
    &lt;input type = &quot;hidden&quot; name = &quot;bookmark&quot; value = &quot;lyrics&quot; /&gt;
&lt;/form&gt;</code></pre>
<h2>标签表单控制</h2>
<p><code>&lt;lable&gt;</code></p>
<p>在使用表单控件时，可以直接通过表单控件旁边的文本说明它的作用并以此保持代码的简洁。</p>
<ul>
<li>for特性用来声明标签控件标注的是哪个表单控件。</li>
</ul>
<h2>组合表单元素</h2>
<p><code>&lt;fieldset&gt;</code></p>
<p>可以将相关表单控件置于<code>&lt;fieldset&gt;</code>元素中分成一组。常常会带有分界线</p>
<p><code>&lt;legend&gt;</code></p>
<p>在表单控件上的标题</p>
<pre><code class="language-html">&lt;fieldset&gt;
    &lt;legend&gt;
        Contact details
    &lt;/legend&gt;
    &lt;label&gt;Email:&lt;br /&gt;
    &lt;input type = &quot;text&quot; name = &quot;email&quot; /&gt;&lt;/label&gt;&lt;br /&gt;
    &lt;label&gt;Mobile:&lt;br /&gt;
    &lt;input type = &quot;text&quot; name = &quot;moblie&quot; /&gt;&lt;/label&gt;&lt;br /&gt;
    &lt;label&gt;Telephon:&lt;br /&gt;
    &lt;input type = &quot;text&quot; name = &quot;telephone&quot; /&gt;&lt;/label&gt;
&lt;/fieldset&gt;</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220728212900976.png" alt="image-20220728212900976" /></p>
<h2>HTML：表单验证</h2>
<p>网络中的表单在用户错误地填写表单控件控件后会弹出错误提示消息，这个过程称为<strong>表单验证</strong>。</p>
<p>通常情况下，表单验证是通过JavaScript实现的。但HTML5引入了验证机制并将这一工作交由浏览器完成。</p>
<p>验证过程可以确保在表单提交后服务器能够理解用户在表单中所填写的信息。在表单发送到服务器之前对表单的内容进行验证有助于：</p>
<ul>
<li>减少服务器的工作量</li>
<li>让用户认识到表单是否存在问题时要比服务器完成验证要快</li>
</ul>
<pre><code class="language-html">&lt;form action = &quot;http://www.example.com/login&quot;method = &quot;post&quot;&gt;
    &lt;label for = &quot;username&quot;&gt;Username:&lt;/label&gt;
    &lt;input type = &quot;text&quot; name = &quot;username&quot; required = &quot;required&quot; /&gt;&lt;br /&gt;
    &lt;label for = &quot;password&quot;&gt;Password:&lt;/label&gt;
    &lt;input type = &quot;password&quot; name = &quot;password&quot; required = &quot;required&quot; /&gt;&lt;br /&gt;
    &lt;input type = &quot;submit&quot; value = &quot;Submit&quot; /&gt;
&lt;/form&gt;</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220728220232319.png" alt="image-20220728220232319" /></p>
<h2>HTML5：日期控件</h2>
<p><code>&lt;input&gt;</code></p>
<p>许多表单都需要收集日期、电子邮件地址和URL等信息。传统上，使用单行文本框来完成这些工作。</p>
<p>HTML5引入了新的表单控件并将某些信息的收集方式标准化，而那些不识别此类控件的旧浏览器会将它们作为单行文本框来处理。</p>
<ul>
<li>type = &quot;date&quot;：要求用户提供日期，可以使用<code>&lt;input&gt;</code>元素并将其type特性的值设为date。这会在支持HTML5新输入类型的浏览器上创建一个日期输入控件。</li>
</ul>
<pre><code class="language-html">&lt;form action = &quot;http://www.example.com/bookings/&quot; method = &quot;post&quot;&gt;
    &lt;label for = &quot;username&quot;&gt;Departure date:&lt;/label&gt;
    &lt;input type = &quot;date&quot; name = &quot;depart&quot; /&gt;
    &lt;input type = &quot;submit&quot; value = &quot;Submit&quot; /&gt;
&lt;/form&gt;</code></pre>
<h2>HTML：电子邮件和URL输入控件</h2>
<p><code>&lt;input&gt;</code></p>
<p>HTML5还引用了让用户输电子邮件地址和URL的输入控件。那些不支持这类输入控件的浏览器会把它们当成普通文本框来处理。</p>
<ul>
<li>type = “email” ：如果需要用户提供电子邮件地址，你可以使用电子邮件输入控件。那些支持HTML5验证机制的浏览器将检查用户提供的信息是不是一个格式正确的电子邮件地址。有些智能手机输入电子邮件地址时还会对其键盘布局进行优化，使得键盘可以显示最有可能用到的按键（比如@符号）</li>
<li>type = &quot;url&quot;：在你需要用户提供网页地址时，可以使用URL输入控件。那些支持HTML5验证机制的浏览器将检查用户所提供的信息是否符合URL的格式。有些智能收集在你输入URL时还会对其键盘布局进行优化。</li>
</ul>
<pre><code class="language-html">&lt;form action = &quot;http://www.example.org/profile.php&quot;&gt;
    &lt;p&gt;
        Please enter your website address:
    &lt;/p&gt;
    &lt;input type = &quot;url&quot; name = &quot;website&quot; /&gt;
    &lt;input type = &quot;submit&quot; value = &quot;Submit&quot; /&gt;
&lt;/form&gt;</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220729020716256.png" alt="image-20220729020716256" /></p>
<h2>HTML5：搜索输入控件</h2>
<p><code>&lt;input&gt;</code></p>
<p>如果你想为搜索查询创建一个单行文本框，可使用HTML5为此提供一个专用输入控件。</p>
<ul>
<li>type = &quot;search&quot;：创建HTML5的搜索框，应将<code>&lt;input&gt;</code>元素的type特性值设置为search，旧浏览器会显示文本框。</li>
<li>placeholder：在任何文本输入控件上，好可以使用一个名为placeholder的特性，在用户单击文本输入区域之前，文本框内显示的文本就是placeholder特性的值。</li>
</ul>
<pre><code class="language-html">&lt;form action = &quot;http://www.example.org/search.php&quot;&gt;
    &lt;p&gt;
        Search：
    &lt;/p&gt;
    &lt;input type = &quot;search&quot; name = &quot;search&quot; placeholder = &quot;Enter keyword&quot; /&gt;
    &lt;input type = &quot;submit&quot; value = &quot;Search&quot; /&gt;
&lt;/form&gt;</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220729025948421.png" alt="image-20220729025948421" /></p>
<h1>其他标记</h1>
<h2>DOCTYPE（文档类型）</h2>
<p>由于HTML存在多个版本，因此每个页面的开头都应该用一个DOCTYPE声明来告诉浏览器此页面是用来HTML的哪个版本。</p>
<p>由于XHTML是采用XML编写的，因此有时你会看到使用了严格版XHTML DOCTYPE 的页面以一个可选的XML声明开头</p>
<pre><code class="language-html">HTML5
&lt;!DOCTYPE html&gt;

XML声明
&lt;?xml version=&quot;1.0&quot; ?&gt;</code></pre>
<p>HTML中注释</p>
<pre><code class="language-html">&lt;!-- comment goes here --&gt;</code></pre>
<h2>id特性</h2>
<p>每个HTML元素都可以附带id特性。id特性用来从页面上的其他元素中对一个元素进行唯一标识，它的值应该以字母或下划线开头。</p>
<h2>class特性</h2>
<p>每个HTML元素都可以附带一个class特性，有时候，你希望有一种方法可以指定多个元素并将这些元素和页面上的其他元素区分出来，而不是单独指定文档中的某个元素。</p>
<h2>块级元素</h2>
<p>有些元素在浏览器窗口中显示时总是另起一行。这些元素被称为<strong>块级</strong>元素如<code>&lt;h1&gt;、&lt;p&gt;、&lt;li&gt;等</code></p>
<h2>内联元素</h2>
<p>有些元素在显示时总是与它的邻近元素出现在同一行内。这些元素被称为<strong>内联</strong>元素如<code>&lt;a&gt;、&lt;b&gt;、&lt;em&gt;、&lt;img&gt;等</code></p>
<h2>将文本和元素集中在一个块级元素中</h2>
<p><code>&lt;div&gt;</code></p>
<p><code>&lt;div&gt;</code>元素允许你将一组元素集中到一个块级元素内。</p>
<p>如果在<code>&lt;div&gt;</code>元素上使用id特性或者class特性，就意味着你可以通过创建CSS规则来指定<code>&lt;div&gt;</code>元素会在屏幕上占据多少空间，还可以改变其内部所有元素的外观。</p>
<h2>将文本和元素集中在一个内联元素中</h2>
<p><code>&lt;span&gt;</code></p>
<p><code>&lt;span&gt;</code>元素就像是<code>&lt;div&gt;</code>元素的内联版本。它用来：</p>
<ul>
<li>在没有其他合适元素的情况下包含一段文本并将其与周围的文本区别开</li>
<li>包含若干个内联元素</li>
</ul>
<p>人们使用<code>&lt;span&gt;</code>元素最常见的原因就是可以利用CSS来控制<code>&lt;span&gt;</code>元素中的内容的外观。</p>
<p>你经常会看到<code>&lt;class&gt;</code>特性或id特性用于<code>&lt;span&gt;</code>元素.</p>
<ul>
<li>解释这个<code>&lt;span&gt;</code>元素的作用</li>
<li>这样就可以在这些具有特定class或id特性值的元素上应用CSS样式</li>
</ul>
<h2>内联框架</h2>
<p><code>&lt;iframe&gt;</code></p>
<p>内联框架就像在你的网页里分隔的小窗口——你可以在这个小窗口中看到另一个网页。<code>&lt;iframe&gt;</code>这一术语是inline frame（内联框架的缩写）。</p>
<p>内联框架是由<code>&lt;iframe&gt;</code>元素创建的。你有必要知道如何使用它的几个特性：</p>
<ul>
<li>src：特性指定要在框架中显示页面的URL。</li>
<li>height：特性指定的内联框架高度的像素值</li>
<li>width：特性指定的内联框架宽度的像素值</li>
<li>seamless：在HTML5中，一个称为seamless的新特性可以应用在不希望出现滚动条的地方</li>
</ul>
<pre><code class="language-html">&lt;iframe
    width = &quot;450&quot;:
    height = &quot;350&quot;:
    src = &quot;http://www.wrxinyue.cn&quot;&gt;
&lt;/iframe&gt;
&lt;!-- 写在一行比较方便 --&gt;
&lt;iframe src = &quot;http://www.wrxinyue.cn&quot; width = &quot;450&quot; height = &quot;350&quot;&gt;&lt;/iframe&gt;</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220729180846171.png" alt="image-20220729180846171" /></p>
<h2>页面信息</h2>
<p><code>&lt;meta&gt;</code></p>
<p><code>&lt;meta&gt;</code>元素位于<code>&lt;head&gt;</code>元素中并包含着所在页面的相关信息。</p>
<p><code>&lt;meta&gt;</code>元素是空元素，所以它没有结束标签。它通过特性来携带信息。</p>
<p>最常用的特性是name特性和content特性，它们还经常同时出现。这些特性用来指定页面的某些特性。name特性的值就是你要设定的属性，而content特性的值就是你想给这个属性的值。</p>
<p>第一个<code>&lt;meta&gt;</code>元素的name特性表明此元素要为该页面指定一段描述信息。<strong>content</strong>特性是指定这段描述信息的位置。</p>
<p>name特性的值可以任意指定，该特性的一些常用的值有：</p>
<ul>
<li>description：用于包含一段关于页面的描述信息。</li>
<li>keywords：用于包含一组以逗号分隔的关键词列表，用户可以通过这些关键词来找到这个页面。</li>
<li>robots：用于指定搜索引擎是否可以将这个页面加入到它们的搜索结果中。如果不希望页面加入搜索结果，可以使用值noindex。如果希望搜索引擎将该页面加入搜索结果，但不要收录页面上的链接的其他页面，可以使用值nofollow</li>
</ul>
<p><code>&lt;meta&gt;</code>元素还会成对使用http-equiv特性和content特性。在下面的示例中，可以看到http-equiv特性的三个实例。每个实例都有各自的用途：</p>
<pre><code class="language-html">&lt;!DOCTYPE html&gt;
&lt;html&gt;
    &lt;head&gt;
        &lt;title&gt;Information About Your Pages&lt;/title&gt;
        &lt;meta name = &quot;description&quot; content = &quot;WRXinYue’s blog&quot; /&gt;
        &lt;meta name = &quot;keywords&quot; content = &quot;blog,wrxinyue,web,unity&quot; /&gt;
        &lt;meta name = &quot;robots&quot; content = &quot;nofollow&quot; /&gt;
        &lt;meta http-equiv = &quot;author&quot; content = &quot;WRXinYue&quot; /&gt;
        &lt;meta http-equiv = &quot;pragma&quot; content = &quot;no-cache&quot; /&gt;
        &lt;meta http-equiv = &quot;expires&quot; content = &quot;Fri, 04 Apr 2022 00:00:00 GMT&quot; /&gt;
    &lt;/head&gt;
    &lt;body&gt;
    &lt;/body&gt;
&lt;/html&gt;</code></pre>
<ul>
<li>author ：用于定义网页的设计者</li>
<li>pragma：用于防止浏览器对页面的缓存</li>
<li>expires：由于浏览器经常缓存页面的内容，expires选项可以用来指定页面的过期时间（以及缓存的有效期）</li>
</ul>
<h2>转义字符</h2>
<p>有一些字符用于编写HTML代码并作为HTML的保留字符（例如，左尖括号和右尖括号）</p>
<p>参考表：<a href="https://tool.oschina.net/commons?type=2">https://tool.oschina.net/commons?type=2</a></p>
<h1>视频和音频</h1>
<h2>HTML5：向网页添加视频</h2>
<p><code>&lt;vodeo&gt;</code></p>
<p><code>&lt;vodeo&gt;</code>元素有很多特性用于控制视频的播放：</p>
<ul>
<li>src：该特性指定视频的路径。</li>
<li>poster：在视频加载时或在视频播放之前，该特性用于指定在播放器中显示一个图像。</li>
<li>width，height：这两个特性用像素值指定播放器的大小。</li>
<li>controls：如果使用该特性，就表示浏览器需要提供默认的播放控件。</li>
<li>autoplay：如果使用了该特性，就表示视频文件应该自动播放。</li>
<li>loop：如果使用该特性，就表示在视频结束之后重新播放。</li>
<li>preload：该特性告诉浏览器在页面加载时需要做什么。它可以选用以下三个值：
<ul>
<li>none：该值表示在用户按下播按钮之前，浏览器不必加载视频。</li>
<li>auto：该值表示浏览器应该在页面加载时载入视频。</li>
<li>metadata：该值表示浏览器只需收集少量视频信息，比如大小、首帧图像、播放列表和持续时间。</li>
</ul></li>
</ul>
<pre><code class="language-html">&lt;!DOCTYPE html&gt;
&lt;html&gt;
    &lt;head&gt;
        &lt;title&gt;Adding HTML5 Video&lt;/title&gt;
    &lt;/head&gt;
    &lt;body&gt;
        &lt;video src = &quot;video/puppy.mp4&quot;
               poster = &quot;images/puppy.jpg&quot;
               width = &quot;400&quot; height = &quot;300&quot;
               preload
               controls
               loop&gt;
            &lt;p&gt;
                A video of a puppy playing in the snow
            &lt;/p&gt;
        &lt;/video&gt;
    &lt;/body&gt;
&lt;/html&gt;</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220730001457178.png" alt="image-20220730001457178" /></p>
<h2>HTML5：多个视频源</h2>
<p><code>&lt;source&gt;</code></p>
<p>要指定播放文件的路径，可以在<code>&lt;video&gt;</code>元素中使用<code>&lt;source&gt;</code>元素可以代替起始标签<code>&lt;video&gt;</code>中的src特性</p>
<p>可以使用多个<code>&lt;source&gt;</code>元素来指定不同格式的视频。</p>
<ul>
<li>src = 该特性用于指定视频的路径。</li>
<li>type = 需要使用该特性来告诉浏览器视频的格式，不然它会加载一些视频，看看是否可以播放该文件（这会耗费时间并占用宽带）</li>
<li>codece = 用来对视频进行编码的编码器也在type特性中指出。</li>
</ul>
<pre><code class="language-html">&lt;!DOCTYPE html&gt;
&lt;html&gt;
    &lt;head&gt;
        &lt;title&gt;Multiple video Sources&lt;/title&gt;
    &lt;/head&gt;
    &lt;body&gt;
        &lt;video poster = &quot;images/1.jpg&quot; width = &quot;400&quot; height = &quot;320&quot; preload controls loop &gt;
            &lt;source src = &quot;video/1.mp4&quot; type = &#039;video/mp4;codecs = &quot;avcl.42E01E, mp4a.40.2&quot;&#039; /&gt;
            &lt;source src = &quot;video/1.webm&quot; type = &#039;video/webm;codecs = &quot;vp8, vorbis&quot;&#039; /&gt;
            &lt;p&gt;
                A voideo of a puppy palying in the snow
            &lt;/p&gt;
        &lt;/video&gt;
    &lt;/body&gt;
&lt;/html&gt;</code></pre>
<h2>HTML5：向网页中添加HTML5音频</h2>
<p>使用托管服务：</p>
<p>有些网站允许上传音频，它们还会提供一个可以嵌入到网页的播放器。比如SoundCloud.com和MySpace.com</p>
<p>使用HTML5：</p>
<p>HTML5引入了一个新元素<code>&lt;audio&gt;</code>。支持该元素的浏览器会提供默认的控件，和上面以及一样</p>
<blockquote>
<p>当访问者从网站中的一个网页跳转到另一个网页时，需要如AJAX的技术来加载页面的内容，也正因为如此，有些网站将音频播放器在新窗口中打开，这样听众在页面跳转时音乐就不会中断。</p>
</blockquote>
<p><code>&lt;audio&gt;</code></p>
<p><code>&lt;audio&gt;</code>元素包含许多可以用来控制音频播放的特性：</p>
<blockquote>
<p>src：该特性用于指定音频文件路径。</p>
<p>controls：该特性表明播放器是否显示播放控件。如果没有使用该特性，播放控件就会默认隐藏。可以利用JavaScript来指定个性化控件。</p>
<p>autopplay：该特性的出现表示音频应该自动开始播放。</p>
<p>preload：该特性在播放器没有设置autoplay时告诉浏览器应该做什么。</p>
<p>loop：该特性表示在音频播放结束后进行重新播放。</p>
</blockquote>
<pre><code class="language-html">&lt;!DOCTYPE html&gt;
&lt;html&gt;
    &lt;head&gt;
        &lt;title&gt;Adding HTMLs Audio&lt;/title&gt;
    &lt;/head&gt;
    &lt;body&gt;
        &lt;audio src = &quot;audio/test=audio.ogg&quot; controls autoplay&gt;
            &lt;p&gt;
                This browser does not suppory our audio format.
            &lt;/p&gt;
        &lt;/audio&gt;
    &lt;/body&gt;
&lt;/html&gt;</code></pre>
<h2>HTML5：多个音频源</h2>
<p><code>&lt;source&gt;</code></p>
<p>在起始标签<code>&lt;audio&gt;</code>和结束标签<code>&lt;/audio&gt;</code>之间使用<code>&lt;source&gt;</code>元素可以指定多个音频文件(<code>&lt;source&gt;</code>元素可以替代起始标签<code>&lt;audio&gt;</code>中的src特性)。</p>
<blockquote>
<ul>
<li>src：<code>&lt;source&gt;</code>元素使用src特性来表示音频文件位于何处。</li>
<li>type：type特性还有像在<code>&lt;video&gt;</code>元素中那样被广泛用在<code>&lt;source&gt;</code>元素中.</li>
</ul>
</blockquote>