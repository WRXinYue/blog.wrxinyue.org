---
title: HTML5布局
date: 2022-08-05 02:37:33.0
updated: 2022-10-26 23:08:09.984
url: /archives/html5-bu-ju
categories: 
- WebFrontend
tags: 
- html
---

<h1>HTML5布局</h1>
<h2>传统的HTML布局</h2>
<p>一直以来，网页设计人员都利用<code>&lt;div&gt;</code>元素将页面中的相关元素集中在一起（比如那些组成页眉、文章、页脚、侧边栏的元素），并使用class或id特性来指定<code>&lt;div&gt;</code>在页面结构中的作用</p>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220805013034182.png" alt="image-20220805013034182" /></p>
<h2>新的HTML5布局元素</h2>
<p>HTML5引入了一组新的元素，这些元素允许对页面各个部分进行分割。它们的名称直接表明了其中包含的内容。</p>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220805013340845.png" alt="image-20220805013340845" /></p>
<h2>页眉和页脚<code>&lt;header&gt;</code> <code>&lt;footer&gt;</code></h2>
<p><code>&lt;header&gt;</code> 和 <code>&lt;footer&gt;</code>元素可以用作：</p>
<blockquote>
<ul>
<li>网站中出现在每个页面顶部的主页眉或底部的主页脚</li>
<li>页面中单独的<code>&lt;article&gt;</code>或<code>&lt;section&gt;</code>中的页眉或页脚。</li>
</ul>
</blockquote>
<pre><code class="language-html">&lt;header&gt;
    &lt;h1&gt;WRXinYue&#039;s blog&lt;/h1&gt;
    &lt;nav&gt;
        &lt;ul&gt;
            &lt;li&gt;&lt;a href=&quot;&quot; class= &quot;curremt&quot;&gt;home&lt;/a&gt;&lt;/li&gt;
            &lt;li&gt;&lt;a href=&quot;&quot;&gt;classes&lt;/a&gt;&lt;/li&gt;
            &lt;li&gt;&lt;a href=&quot;&quot;&gt;catering&lt;/a&gt;&lt;/li&gt;
            &lt;li&gt;&lt;a href=&quot;&quot;&gt;about&lt;/a&gt;&lt;/li&gt;
            &lt;li&gt;&lt;a href=&quot;&quot;&gt;contact&lt;/a&gt;&lt;/li&gt;
        &lt;/ul&gt;
    &lt;/nav&gt;
&lt;/header&gt;</code></pre>
<pre><code class="language-html">&lt;footer&gt;
    $copy: 2022 WRXinYue&#039;s blog
&lt;/footer&gt;</code></pre>
<h2>导航<code>&lt;nav&gt;</code></h2>
<p><code>&lt;nav&gt;</code>元素专门用于包含网站的主要导航块，比如网站的主导航。</p>
<h2>文章<code>&lt;artcle&gt;</code></h2>
<p><code>&lt;artcle&gt;</code>元素就像是页面中任意部分（可能是单独存在的部分，也可能是联合出现的某一部分）的一个容器。</p>
<p>它们可以是一个单独的文章、博客日志、评论、论坛帖子，或者任何其他独立的内容。</p>
<p>如果一个页面含多篇文章（或是多个文章摘要），那么每个单独的元素的文章都应个位于其专属的<code>&lt;article&gt;</code>元素中</p>
<pre><code class="language-html">&lt;article&gt;
    &lt;figure&gt;
        &lt;img scr = &quot;images/bok-choi.jpg&quot; alt = &quot;Bok Choi&quot; /&gt;
        &lt;figcaption&gt;Bok Choi&lt;/figcaption&gt;
    &lt;/figure&gt;
    &lt;hgroup&gt;
        &lt;h2&gt;二级标题&lt;/h2&gt;
    &lt;/hgroup&gt;
    &lt;p&gt;
        .......
    &lt;/p&gt;
&lt;/article&gt;</code></pre>
<h2>附属信息<code>&lt;aside&gt;</code></h2>
<p><code>&lt;aside&gt;</code>元素有两个作用，具体具有哪种作用取决于其是否位于<code>&lt;article&gt;</code>元素中</p>
<p>如果在<code>&lt;article&gt;</code>元素内出现时，它应该包含与当前文章相关的信息，而不必涉及页面的整体信息。</p>
<p>当在<code>&lt;article&gt;</code>元素外出现，它应该包含与整个页面相关的内容。</p>
<h2>部分<code>&lt;section&gt;</code></h2>
<p><code>&lt;section&gt;</code>元素用于将相关的内容集中到一块，而每个部分通常都带有一个标题。</p>
<p><code>&lt;section&gt;</code>元素不能作为整个页面的容器使用（除非这个页面只包含一个内容）</p>
<h2>标题组<code>&lt;hgroup&gt;</code></h2>
<p><code>&lt;hgroup&gt;</code>元素的作用是将一个或多个<code>&lt;h1&gt;</code>到<code>&lt;h6&gt;</code>的标题元素组合到一块，将它们当成一个标题看待。</p>
<h2>图形 <code>&lt;figure&gt;</code> <code>&lt;figcaption&gt;</code></h2>
<p>它可以用来包含一篇文章正文中引用的任何内容</p>
<h2>分节元素 <code>&lt;div&gt;</code></h2>
<p>在没有合适的元素用来组合一组元素时，仍可以使用<code>&lt;div&gt;</code>元素</p>
<h2>为块级元素添加链接</h2>
<p>HTML5允许网页设计人员在包含子元素的块级元素周围添加<code>&lt;a&gt;</code>元素。这将使整个块变成一个链接、</p>