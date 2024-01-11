---
title: Markdown语法
date: 2021-11-20 08:38:00.0
updated: 2022-10-26 18:08:25.385
categories: 
- 博客
tags: 
---

<p>前言：在建造博客网站时我是第一次接触到关于Markdown的文本语言，Markdown经常会被用来写博客使用，Markdown学起来很简单，下面是我整理的关于Markdown语法手册，希望能帮到像我这样刚刚学会建立博客网站的萌新。</p>
<h2>Markdown 标题</h2>
<p>= 和 - 标记语法格式如下：</p>
<pre><code class="language-bash">我展示的是一级标题
=================

我展示的是二级标题
-----------------</code></pre>
<p>使用 # 号可表示 1-6 级标题，一级标题对应一个 # 号，二级标题对应两个 # 号，以此类推：</p>
<pre><code class="language-bash"># 一级标题
## 二级标题
### 三级标题
#### 四级标题
##### 五级标题
###### 六级标题</code></pre>
<h2>Markdown 段落</h2>
<p>Markdown 段落没有特殊的格式，直接编写文字就好，段落的换行是使用两个以上空格加上回车。</p>
<h3>字体</h3>
<p>Markdown 可以使用以下几种字体：</p>
<pre><code class="language-bash">*斜体文本*
_斜体文本_
**粗体文本**
__粗体文本__
***粗斜体文本***
___粗斜体文本___</code></pre>
<p>显示效果：</p>
<p><em>斜体文本</em>
<em>斜体文本</em>
<strong>粗体文本</strong>
<strong>粗体文本</strong>
<strong><em>粗斜体文本</em></strong>
<strong><em>粗斜体文本</em></strong></p>
<h3>分割线</h3>
<pre><code class="language-bash">***
* * *
*****
- - -
----------</code></pre>
<p>显示效果：</p>
<hr />
<hr />
<hr />
<hr />
<hr />
<h3>删除线</h3>
<pre><code class="language-bash">~~删除线~~</code></pre>
<p><del>删除线</del></p>
<h3>下划线</h3>
<pre><code class="language-bash">&lt;u&gt;下划线文本&lt;/u&gt;</code></pre>
<p><u>下划线文本</u></p>
<h3>脚注</h3>
<p>脚注是对文本的补充说明。</p>
<p>Markdown 脚注的格式如下:</p>
<pre><code class="language-bash">注释[^要注明的文本]

[^要注明的文本]: 这是一个注释</code></pre>
<p>显示效果：</p>
<p>注释<a href="这是一个注释">^要注明的文本</a></p>
<h2>Markdown 列表</h2>
<p>Markdown 支持有序列表和无序列表。</p>
<p>无序列表使用星号(*)、加号(+)或是减号(-)作为列表标记，这些标记后面要添加一个空格，然后再填写内容：</p>
<pre><code class="language-bash">* 第一项
* 第二项
* 第三项

+ 第一项
+ 第二项
+ 第三项

- 第一项
- 第二项
- 第三项</code></pre>
<p>显示效果：</p>
<ul>
<li>
<p>第一项</p>
</li>
<li>
<p>第二项</p>
</li>
<li>
<p>第三项</p>
</li>
<li>
<p>第一项</p>
</li>
<li>
<p>第二项</p>
</li>
<li>
<p>第三项</p>
</li>
<li>
<p>第一项</p>
</li>
<li>
<p>第二项</p>
</li>
<li>
<p>第三项</p>
</li>
</ul>
<p>有序列表使用数字并加上 . 号来表示，如：</p>
<pre><code class="language-bash">1. 第一项
2. 第二项
3. 第三项</code></pre>
<p>显示效果：</p>
<ol>
<li>第一项</li>
<li>第二项</li>
<li>第三项</li>
</ol>
<h3>列表嵌套</h3>
<pre><code class="language-bash">1. 第一项：
    - 第一项嵌套的第一个元素
    - 第一项嵌套的第二个元素
2. 第二项：
    - 第二项嵌套的第一个元素
    - 第二项嵌套的第二个元素</code></pre>
<p>显示效果：</p>
<ol>
<li>第一项：
<ul>
<li>第一项嵌套的第一个元素</li>
<li>第一项嵌套的第二个元素</li>
</ul></li>
<li>第二项：
<ul>
<li>第二项嵌套的第一个元素</li>
<li>第二项嵌套的第二个元素</li>
</ul></li>
</ol>
<h2>Markdown 区块</h2>
<p>Markdown 区块引用是在段落开头使用 &gt; 符号 ，然后后面紧跟一个空格符号：</p>
<pre><code class="language-bash">> 区块引用</code></pre>
<p>显示效果：</p>
<blockquote>
<p>区块引用</p>
</blockquote>
<p>区块是可以嵌套的：</p>
<pre><code class="language-bash">> 最外层
> &gt; 第一层嵌套
> &gt; &gt; 第二层嵌套</code></pre>
<p>显示效果：</p>
<blockquote>
<p>最外层</p>
<blockquote>
<p>第一层嵌套</p>
<blockquote>
<p>第二层嵌套</p>
</blockquote>
</blockquote>
</blockquote>
<h3>区块中使用列表</h3>
<p>区块中使用列表实例如下：</p>
<pre><code class="language-bash">> 区块中使用列表
> 1. 第一项
> 2. 第二项
> + 第一项
> + 第二项
> + 第三项</code></pre>
<p>显示效果：</p>
<blockquote>
<p>区块中使用列表</p>
<ol>
<li>第一项</li>
<li>第二项</li>
</ol>
<ul>
<li>第一项</li>
<li>第二项</li>
<li>第三项</li>
</ul>
</blockquote>
<h3>列表中使用区块</h3>
<p>如果要在列表项目内放进区块，那么就需要在 &gt; 前添加四个空格的缩进。</p>
<p>列表中使用区块实例如下：</p>
<pre><code class="language-bash">* 第一项
    &gt; 嵌套的第一个元素
    &gt; 嵌套的第二个元素
* 第二项</code></pre>
<ul>
<li>
<p>第一项</p>
<blockquote>
<p>嵌套的第一个元素
嵌套的第二个元素</p>
</blockquote>
</li>
<li>
<p>第二项</p>
</li>
</ul>
<h2>Markdown 代码</h2>
<p>如果是段落上的一个函数或片段的代码可以用反引号把它包起来（`），例如：</p>
<pre><code class="language-bash">`printf()` 函数</code></pre>
<h3>代码区块</h3>
<p>代码区块使用 4 个空格或者一个制表符（Tab 键）:</p>
<pre><code class="language-bash">    &lt;?php #在开头前面加
    echo &#039;blog&#039;;
    function test() {
        echo &#039;test&#039;;
    }</code></pre>
<p>显示效果：</p>
<pre><code><?php
echo 'bolg';
function test() {
    echo 'test';
}</code></pre>
<p>还可以用```或~~~包裹一段代码，可以指定语言：</p>
<pre><code>``` javascrpt
$(document).ready(function () {
    alert(&#039;blog&#039;);
});
```</code></pre>
<p>显示效果：</p>
<pre><code class="language-javascrpt">$(document).ready(function () {
    alert(&#039;blog&#039;);
});</code></pre>
<h2>Markdown 链接</h2>
<p>使用方法如下：</p>
<pre><code class="language-bash">[链接名称](链接地址)

或者

&lt;链接地址&gt;</code></pre>
<p>例如：</p>
<p>这是一个链接 <a href="https://www.baidu.com">百度</a></p>
<p>直接使用链接地址：</p>
<pre><code>&lt;https://www.baidu.com&gt;</code></pre>
<p>显示效果：</p>
<p><a href="https://www.baidu.com">https://www.baidu.com</a></p>
<p>高级链接</p>
<p>通过变量来设置一个链接，变量赋值在文档末尾进行：</p>
<pre><code>这个链接用 1 作为网址变量 [Google][1]
这个链接用 2 作为网址变量 [baidu][2]
然后在文档的结尾为变量赋值（网址）

[1]: http://www.google.com/
  [baidu]: http://www.baidu.com/</code></pre>
<p>显示效果：</p>
<p>这个链接用 1 作为网址变量 <a href="http://www.google.com/">Google</a>
这个链接用 2 作为网址变量 <a href="http://www.baidu.com/">baidu</a>
然后在文档的结尾为变量赋值（网址）</p>
<h2>Markdown 图片</h2>
<p>Markdown 图片语法格式如下：</p>
<pre><code>![alt 属性文本](图片地址)

![alt 属性文本](图片地址 &quot;可选标题&quot;)</code></pre>
<ul>
<li>开头一个感叹号 !</li>
<li>接着一个方括号，里面放上图片的替代文字</li>
<li>接着一个普通括号，里面放上图片的网址，最后还可以用引号包住并加上选择性的 'title' 属性的文字。</li>
</ul>
<p>显示效果：</p>
<p><img src="https://wrxinyue.github.io/blog/img/welcome/welcome.jpg" alt="welcome 图片" /></p>
<p><img src="https://wrxinyue.github.io/blog/img/welcome/home2.jpg" alt="home 图片" title="home2" /></p>
<p>显示效果：</p>
<img src="https://wrxinyue.github.io/blog/img/welcome/welcome2.jpg" width="50%">
<h2>Markdown 表格</h2>
<p>Markdown 制作表格使用 | 来分隔不同的单元格，使用 - 来分隔表头和其他行。</p>
<p>语法格式如下：</p>
<pre><code>|  表头   | 表头  |
|  ----  | ----  |
| 单元格  | 单元格 |
| 单元格  | 单元格 |</code></pre>
<p>显示效果：</p>
<table>
<thead>
<tr>
<th>表头</th>
<th>表头</th>
</tr>
</thead>
<tbody>
<tr>
<td>单元格</td>
<td>单元格</td>
</tr>
<tr>
<td>单元格</td>
<td>单元格</td>
</tr>
</tbody>
</table>
<p>我们可以设置表格的对齐方式：</p>
<blockquote>
<ul>
<li>-: 设置内容和标题栏居右对齐。</li>
<li>:- 设置内容和标题栏居左对齐。</li>
<li>:-: 设置内容和标题栏居中对齐。</li>
</ul>
</blockquote>
<p>实例：</p>
<pre><code>| 左对齐 | 右对齐 | 居中对齐 |
| :-----| ----: | :----: |
| 单元格 | 单元格 | 单元格 |
| 单元格 | 单元格 | 单元格 |</code></pre>
<p>显示效果:</p>
<table>
<thead>
<tr>
<th style="text-align: left;">左对齐</th>
<th style="text-align: right;">右对齐</th>
<th style="text-align: center;">居中对齐</th>
</tr>
</thead>
<tbody>
<tr>
<td style="text-align: left;">单元格</td>
<td style="text-align: right;">单元格</td>
<td style="text-align: center;">单元格</td>
</tr>
<tr>
<td style="text-align: left;">单元格</td>
<td style="text-align: right;">单元格</td>
<td style="text-align: center;">单元格</td>
</tr>
</tbody>
</table>
<h2>Markdown 高级技巧</h2>
<h3>支持的 HTML 元素</h3>
<p>不在 Markdown 涵盖范围之内的标签，都可以直接在文档里面用 HTML 撰写。
目前支持的 HTML 元素有：</p>
<pre><code>&lt;kbd&gt; &lt;b&gt; &lt;i&gt; &lt;em&gt; &lt;sup&gt; &lt;sub&gt; &lt;br&gt;...</code></pre>
<p>例如：</p>
<pre><code>使用 &lt;kbd&gt;Ctrl&lt;/kbd&gt;+&lt;kbd&gt;Alt&lt;/kbd&gt;+&lt;kbd&gt;Del&lt;/kbd&gt; 重启电脑</code></pre>
<h3>转义</h3>
<p>Markdown 使用了很多特殊符号来表示特定的意义，如果需要显示特定的符号则需要使用转义字符，Markdown 使用反斜杠转义特殊字符：</p>
<pre><code>**文本加粗** 
\*\* 正常显示星号 \*\*</code></pre>
<p>显示效果：</p>
<p><strong>文本加粗</strong>
** 正常显示星号 **</p>
<p>Markdown 支持以下这些符号前面加上反斜杠来帮助插入普通的符号：</p>
<pre><code>\   反斜线
`   反引号
*   星号
_   下划线
{}  花括号
[]  方括号
()  小括号
#   井字号
+   加号
-   减号
.   英文句点
!   感叹号</code></pre>
<h3>公式</h3>
<p>在编辑器中插入数学公式时，可以使用两个美元符 $$ 包裹 TeX 或 LaTeX 格式的数学公式来实现。提交后，问答和文章页会根据需要加载 Mathjax 对数学公式进行渲染。如：</p>
<pre><code>$$
\mathbf{V}_1 \times \mathbf{V}_2 =  \begin{vmatrix} 
\mathbf{i} &amp; \mathbf{j} &amp; \mathbf{k} \\
\frac{\partial X}{\partial u} &amp;  \frac{\partial Y}{\partial u} &amp; 0 \\
\frac{\partial X}{\partial v} &amp;  \frac{\partial Y}{\partial v} &amp; 0 \\
\end{vmatrix}
${$tep1}{\style{visibility:hidden}{(x+1)(x+1)}}
$$</code></pre>