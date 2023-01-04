---
title: CSS3笔记
date: 2022-08-05 01:44:58.0
updated: 2022-10-26 23:06:39.802
url: /archives/css3-bi-ji
categories: 
- WebFrontend
tags: 
- css
---

<h1>CSS简介</h1>
<h2>理解CSS：设想元素周围有一个盒子</h2>
<p>CSS允许你创建规则，来控制每个盒子（以及盒子中的内容）的呈现方式。</p>
<h2>CSS将样式规则与HTML元素关联</h2>
<p>CSS通过将规则与HTML元素相关联的方式来工作。这些规则用来控制指定元素中的内容如何显示。一条CSS规则包含两个部分：一个<strong>选择器</strong>和一条声明</p>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220731142459124.png" alt="image-20220731142459124" /></p>
<p>这条规则表明所有<code>&lt;p&gt;</code>元素都应该用Arial字体来显示。</p>
<p><strong>选择器</strong>表明要应用规则的元素。同一条规则可以应用在多个元素上，前提是你需要将这些元素名用逗号隔开。</p>
<p><strong>声明</strong>用于表明应该如何显示选择器指明的元素。声明分为两个部分（属性和值）并以冒号作为分隔符。</p>
<h2>CSS属性会影响元素的显示方式</h2>
<p>CSS声明位于花括号中，而且每条声明都由两部分组成：<strong>属性</strong>和<strong>值</strong>，两者由冒号隔开。可在一条声明内指定多个属性，各属性之间用分号隔开。</p>
<pre><code class="language-css">h1, h2，h3 {
    font-family: Arial;
    color: yellow;}  /* 属性：值 */</code></pre>
<p>上面这条规则表明所有的<code>&lt;h1&gt;</code>元素、<code>&lt;h2&gt;</code>元素和<code>&lt;h3&gt;</code>元素将以黄色的Arial字体显示。</p>
<p><strong>属性</strong>表明你想要改变元素的哪些方面。例如颜色、字体、宽度、高度和边框.</p>
<p><strong>值</strong>用来指定想要在所选属性上应用的设置。例如：如果指定一个颜色属性，那么这个属性的值就算你希望这些元素中的文本所呈现的颜色。</p>
<h2>使用外部CSS</h2>
<p><code>&lt;link&gt;</code></p>
<p>在HTML文档中，<code>&lt;link&gt;</code>元素可以告诉浏览器何处寻找用于定义页面样式的CSS文件。它是一个空元素（也就是说它不需要结束标签），而且位于<code>&lt;head&gt;</code>元素中。它应该使用以下三个特性：</p>
<blockquote>
<p>href：该特性表明CSS文件的路径（通常位于css或styles文件夹中）。</p>
<p>type：表明该页面所连接的文档的类型。它的值应该是text/css。</p>
<p>rel：该特性表明HTML页面与被链接文件的关系。当链接到一个CSS文件时，该特性的值应该为stylesheet。</p>
</blockquote>
<pre><code class="language-html">&lt;link href = &quot;css/styles.css&quot; type = &quot;text/css&quot; rel = &quot;stylesheet&quot; /&gt;</code></pre>
<p>当建立一个包含有多个页面的网站时，应该使用外部样式表。这样做具有以下好处：</p>
<blockquote>
<ul>
<li>允许所有页面使用同样的样式规则（重复利用性）。</li>
<li>将页面的内容和表现分离。</li>
<li>可以通过修改一个文件（而不必修改每个页面）来改变所有页面的样式。</li>
</ul>
</blockquote>
<h2>使用内部CSS</h2>
<p><code>&lt;style&gt;</code></p>
<p>可以在HTML页面添加CSS规则，这时需要将它们置于<code>&lt;style&gt;</code>元素内，<code>&lt;style&gt;</code>元素通常位于页面的<code>&lt;head&gt;</code>元素中。</p>
<p><code>&lt;style&gt;</code>使用该元素特性表明这些样式是在CSS中指定的。该特性的值应该为text/css。</p>
<pre><code class="language-html">&lt;style type = &quot;text/css&quot;&gt;
    body {
        ......
    }
&lt;/style&gt;</code></pre>
<h2>CSS选择器</h2>
<p><a href="https://www.w3school.com.cn/cssref/css_selectors.asp">CSS选择器参考手册</a></p>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220801011311058.png" alt="image-20220801011311058" /></p>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220801011327836.png" alt="image-20220801011327836" /></p>
<h2>CSS规则如何级联</h2>
<p>如果有两个或者更多的规则应用在同一个元素上，那么理解这些规则的优先级关系是非常重要的。</p>
<p>就近原则：
如果两个选择器完全相同，那么后出现的选择器优先级较高。</p>
<p>具体性原则：
如果一个选择器比其他选择器更加具体，那么具体的选择器优先于一般的选择器。</p>
<p>重要性：
可以在任意属性值的后面添加<strong>!important</strong>来强调这一条规则比应用于同一元素的其他规则更重要。</p>
<h2>继承</h2>
<p>如果在<code>&lt;body&gt;</code>元素上指定了font-family属性或color属性，那么它们将应用于<code>&lt;body&gt;</code>元素的大多数元素上。这是因为font - family属性被这些子元素所继承。</p>
<p>background-color属性和border属性不会被子元素继承。如果这些元素会被继承，那么这些页面会很乱。</p>
<p>可以通过将属性值设置为<strong>inherit</strong>来强制大多数元素从它的父元素中继承属性值。在本示例中，<code>&lt;div&gt;</code>元素(属于page类)从应用于<code>&lt;body&gt;</code>元素的CSS规则中继承了padding属性的值。</p>
<pre><code class="language-html">&lt;div class = &quot;page&quot;&gt;
    &lt;h1&gt;Potatoes&lt;/h1&gt;
    &lt;P&gt;
        There are dozens of different potato varieties.
    &lt;/P&gt;
    &lt;p&gt;
        They are usually described as early.second early and maincrop potatoes.
    &lt;/p&gt;
&lt;/div&gt;</code></pre>
<pre><code class="language-css">body {
    font-family: Arual, Verdana, sans-serif;
    color: #665544;
    padding: 10px;
}
.page {
    border: 1px solid #664433;
    background-color: #efefef;
    padding: inherit;
}</code></pre>
<h1>颜色</h1>
<h2>前景色color</h2>
<p>color属性允许指定元素中文本的颜色。可以在CSS中采用以下三种方法之一来指定任何颜色：</p>
<p>RGB值：
三原色组成颜色，例如：rgb(100,100,90)。</p>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/0823dd54564e92580c2f0c8d9482d158ccbf4ebe" alt="img" /></p>
<p>十六进制编码：
这种方式是通过六位十六进制编码表示颜色，其中的六位编码（每两位构成一个值，共三个值）前面加一个#号。例如：#ee3e80。</p>
<p>颜色名称：
浏览器可以标识147种预定义的颜色名称。</p>
<pre><code class="language-css">/* color name */
h1 {
    color: DarkCyan;
}
/* hex code */
h2 {
    color: #ee3e80;
}
/* rgb calue */
p {
    color: rgb(100.100.90);
}</code></pre>
<h2>背景色background-color</h2>
<p>CSS在处理每个HTML元素时都假设它们位于一个无形的盒子中，而background-color属性设置的正是这个盒子的背景色。</p>
<p>如果为指定背景色，那么背景将是透明的。</p>
<pre><code class="language-css">body {
    background-color: rgb(200, 200, 200);
}
h1 {
    background-color: darkcyan;
}
h2 {
    background-color: #ee3e80;
}
p {
    background-color: white;
}</code></pre>
<h2>CSS3：透明度</h2>
<p><code>opacity,rgba</code></p>
<p>opacity 指定透明度，数组介于0.1~1.0之间，0.5表示50%的透明度，0.15表示15%的透明度（会影响子元素）</p>
<p>CSS3中的rgba属性比rgb多个了标识透明度的值。这个值称为alpha值，数组介于0.1~1.0之间，0.5表示50%的透明度，0.15表示15%的透明度。（不会影响子元素）</p>
<pre><code class="language-css">p.one {
    background-color: rgb(0, 0, 0);
    opacity: 0.5;
}
p.two {
    background-color: rgba(0, 0, 0, 0.5);
}</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220802014044242.png" alt="image-20220802014044242" /></p>
<h2>CSS3：HSL和HSLA</h2>
<p>hsl颜色属性以及作为一种新的颜色指定方式进入CSS3中。该属性的值以hsl开头，位于其后的括号内是以下几种值：</p>
<blockquote>
<p>色调：通过介于0°~360°之间的一个角度表示。</p>
<p>饱和度：通过百分数表示。</p>
<p>明度：通过百分数表示，0%表示黑色，50%表示标准色，100%表示白色</p>
<p>ALPHA：透明度，该值由于0~1.0之间的数字表示。</p>
</blockquote>
<pre><code class="language-css">body {
    background-color: #C8C8C8; /*添加该值为了兼容旧浏览器*/
    background-color: hsl(0, 0%, 78);
}
p {
    background-color: #ffffff;
    background-color: hsla(0, 100%, 100%, 0.5);
}</code></pre>
<h1>文本</h1>
<h2>字体术语</h2>
<blockquote>
<p>衬托字体(SERIF)：衬托字体在字母主要笔画的末端有一些额外的装饰。这些装饰被称为衬线</p>
<p>无衬线字体(SABS-SERIF)：无衬线字体中的字母拥有笔直的线条，因此它的设计更加简洁。</p>
<p>等宽字体(MONOSPACE)：等宽字体中的每个字母的宽度都相同，而非等宽字体中字母的宽度不同。</p>
<p>草书字体(Cursive)： 模仿了人类的笔迹。</p>
<p>幻想字体(Fantasy)：是装饰性/俏皮的字体。</p>
</blockquote>
<pre><code class="language-css">font-family: Georgia, Times, serif; /*衬托字体*/</code></pre>
<h2>字体大小font-size</h2>
<p>dont-size属性用来指定字体大小，常用方式：</p>
<blockquote>
<p>像素：像素之所以能被广泛使用，是因为它能让Web设计人员对文本占用的空间进行精准的控制。它的表示方式是在像素值后面加个px。</p>
<p>百分数：文本在浏览器中默认大小是16px。因此75%相当于12px，200%相当于32px。</p>
<p>EM值：lem相当于一个字母m的宽度。</p>
</blockquote>
<h2>选用更多字体@font-face</h2>
<p>@font-face通过指定字体的下载地址(当这种字体在用户的计算机上没有安装时，就会自动下载)让你调用字体，即使用户在浏览时使用的计算机上没有安装相应的字体也可以加以使用。</p>
<blockquote>
<p>font-family：该属性指定字体的名称</p>
<p>src：该属性指定字体的路径。</p>
<p>format：该属性指定所提供字体的格式。</p>
</blockquote>
<pre><code class="language-css">@font-face {
    font-family: &#039;ChunckFiveRegular&#039;;
    src: url(&#039;fonts/chunkfive.eot&#039;);
}
h1, h2 {
    font-family: ChukFiveRegular, Georgia, serif;
}</code></pre>
<h2>粗体font-weight</h2>
<p>font-weight属性允许创建粗体文本。该属性通常选用以下两个值：</p>
<blockquote>
<p>normal：该值使文本以普通粗细显示。</p>
<p>bold：该值使文本以粗体显示</p>
</blockquote>
<pre><code class="language-css">.credits {
    font-weight: bold;
}</code></pre>
<h2>斜体font-style</h2>
<p>font-style属性允许创建斜体文本：该属性有三个可选值：</p>
<blockquote>
<p>normal：该值使文以普通字体（相对斜体和倾斜来说）显示。</p>
<p>italic：该值使文本以斜体显示。</p>
<p>oblique：该值使文本倾斜显示。</p>
</blockquote>
<pre><code class="language-css">.credits {
    font-style: italic;
}</code></pre>
<h2>大写和小写text-transform</h2>
<p>text-transform属性可以改变文本的大小写，可选用以下值之一：</p>
<blockquote>
<p>uppercase：该值使文本以大写显示。</p>
<p>lowercase：该值使文本以小写显示。</p>
<p>capitalize：该值使每个单词的首字母以大写显示。</p>
</blockquote>
<pre><code class="language-css">h1 {
    text-transform: uppercase;
}
h2 {
    text-transform: lowercase;
}
.credits {
    text-transform: capitalize;
}</code></pre>
<h2>下划线和删除线text-decoratioon</h2>
<p>text-decoratioon属性可以选用以下值：</p>
<blockquote>
<p>none：删除应用在文本上的装饰线</p>
<p>underline：该值会在文本底部增加一条实线</p>
<p>overline：该值会在文本顶部增加一条实线</p>
<p>line-through：该值会用一条实现穿过文字</p>
</blockquote>
<h2>行间距line-height</h2>
<p>在css中，line-height属性用于设置文本行的整个高度</p>
<pre><code class="language-css">p {
    line-height: 1.4em;
}</code></pre>
<h2>字母间距和单词间距letter-spacing，word-spacing</h2>
<p><strong>字距</strong>是印刷行业用来描述字母之间空隙的一个术语。可以使用letter-spacing属性来控制字母之间的间距。</p>
<pre><code class="language-css">h1, h2{
    text-transform: uppercase;
    letter-spacing: 0.2em;
}
.credits {
    font-weight: bold;
    word-spacing: 1em;
}</code></pre>
<h2>对齐方式text-align</h2>
<p>text-align用于控制文本的对齐方式。该属性可以选用以下值：</p>
<blockquote>
<p>left：该值表明文本向左对齐</p>
<p>right：该值表明文本向右对齐</p>
<p>center：该值将文本居中显示</p>
<p>justify：该值表明文本两端对齐，即段落中除了末行以外的其他每行都要在宽度上占满文本所在的容器。</p>
</blockquote>
<pre><code class="language-css">h1 {
    text-align: left;
}
p {
    text-align: justify;
}
.credits {
    text-align: right;
}</code></pre>
<h2>垂直对齐vertical-align</h2>
<p>vertical-align属性可以选用的值包括：</p>
<blockquote>
<ul>
<li>baseline</li>
<li>sub</li>
<li>super</li>
<li>top</li>
<li>text-top</li>
<li>middle</li>
<li>bottom</li>
<li>text-bottom</li>
</ul>
</blockquote>
<p>它还可以选用长度值（通常以像素或em值指定）或是行高的百分数。</p>
<pre><code class="language-css">#six-moths {
    vertical-align: text-top;
}
#one-year {
    vertical-align: baseline;
}
#two-years {
    vertical-align: text-bottom;
}</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220802182646488.png" alt="image-20220802182646488" /></p>
<h2>文本缩进text-indent</h2>
<p>text-indent属性允许将元素中的首行文本进行所见，通常采用像素值或em值。</p>
<pre><code class="language-css">h1{
    text-indent: -9999px;
}</code></pre>
<h2>CSS3：投影text-shadow</h2>
<p>该属性用于创建投影，投影指的是比文本颜色更暗的版本，它位于文本的后方并略有偏移。该属性还可以通过添加亮度比文本稍高的阴影来创建浮雕效果。</p>
<p>由于创建投影需要指定三个长度值和一种颜色，因此该属性的值非常复杂：</p>
<blockquote>
<ul>
<li>第一个长度值表明阴影向左或向右延伸的距离</li>
<li>第二个长度值表明阴影向上或向下延伸的距离</li>
<li>第三个长度值为可选项，它用于指定投影的模糊程度</li>
<li>最后一项是投影的颜色值</li>
</ul>
</blockquote>
<pre><code class="language-css">p{
    background-color: #aaaaaa;
    color: #ffffff;
    text-shadow: -1px -1px #666666;
}</code></pre>
<h2>首字母或首行文本:first-letter, :first-line</h2>
<p>可以通过:first-letter和 :first-line为一个元素中的首字母或者首行文本另外指定一个值。他们被称为伪元素</p>
<pre><code class="language-css">p.intro:first-letter {
    font-size: 200%;
}
p.inro:first-line{
    font-weight: bold;
}</code></pre>
<h2>链接样式:link, :visited</h2>
<p>默认情况下,浏览器通常以蓝色显示链接并附带下划线,此外,浏览器还会改变那些已经访问过的链接的颜色,以此来帮助用户分清他们已经访问过哪些页面.</p>
<p>在CSS中,有两个伪类允许为已访问的和未访问的链接定义不同的样式.</p>
<blockquote>
<p>:link 该伪类允许给未访问的链接设置样式</p>
<p>:visited 该伪类允许给访问过链接设置样式</p>
</blockquote>
<pre><code class="language-css">a:link {
    color: deeppink;
    text-decoration: none;
}
a:visited {
    color: black;
}
a:hover {
    color: deeppink;
    text-decoration: underline;
}
a:active{
    color: darkcyan;
}</code></pre>
<h2>相应用户 :hover, :active, :focus</h2>
<p>当用户与元素进行交互时,可使用下面的三种伪元素来改变元素的外观.</p>
<blockquote>
<p>:hover 该伪元素在用户将定位设备(比如光标)悬停在某个元素上时生效</p>
<p>:active 该伪类在元素上进行操作时生效</p>
<p>:focus 该伪类在元素拥有拥有焦点时生效</p>
<p>当使用多个伪类时,应当遵循:link,:visited,:hover,:focus,:active顺序</p>
</blockquote>
<h2>特性选择器</h2>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220803021359528.png" alt="image-20220803021359528" /></p>
<h1>盒子</h1>
<h2>盒子的大小width, height</h2>
<p>默认情况下,一个盒子的大小刚好容下其中的内容,并根据其中内容的变化而变化.如果自定义盒子的大小,就需要用到windth和height属性.</p>
<p>指定盒子大小最常用的方式是像素、百分数或em值。</p>
<pre><code class="language-html">&lt;div&gt;
    &lt;p&gt;
        一段文本
    &lt;/p&gt;
&lt;/div&gt;</code></pre>
<pre><code class="language-css">div.box {
    height: 300px;
    width: 400px;
    background-color: #ee3e80;
}
p {
    height: 75%;
    width: 75%;
    background-color: #eeddda;
}</code></pre>
<h2>宽度限制min-width, max-width</h2>
<p>为了适应用户的屏幕大小，有些设计会适时地展开或收缩页面。在此设计中min-width属性指定一个盒子在浏览器窗口较窄时可以显示的最小宽度，max-width属性指定一个盒子在浏览器较宽时成伸展的最大宽度。</p>
<pre><code class="language-html">&lt;tr&gt;
    &lt;td class = &quot;description&quot;&gt;
    ......
    &lt;/td&gt;
    &lt;td&gt;......&lt;/td&gt;
&lt;/tr&gt;</code></pre>
<pre><code class="language-css">td.description {
    min-width: 450px;
    max-width: 650px;
    text-align: left;
    padding: 5px;
    margin: 0px;
}</code></pre>
<h2>高度限制min-height, max-height</h2>
<p>和宽度限同理</p>
<h2>内容移除 overflow</h2>
<p>ofverflow属性告诉浏览器当盒子的内容超过盒子本身时如何显示。它有两个属性值可供选择：</p>
<blockquote>
<p>hidden：该属性会直接把溢出盒子空间的内容进行隐藏。</p>
<p>scroll：该属性会在盒子上添加一个滚动条，这样用户可以通过滚动滑块来查看剩余的内容。</p>
</blockquote>
<pre><code class="language-css">p.one {
    overflow: hidden;
}
p.two {
    overflow: scroll;
}</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220803025548770.png" alt="image-20220803025548770" /></p>
<h2>外框、外边距和内边距</h2>
<p>有三种属性可以应用在所有盒子上，可以通过调节这些属性来控制盒子的外观：</p>
<blockquote>
<p>外框(BORDER)</p>
<p>外边距(MARGIN)</p>
<p>内边距(PADDING)</p>
</blockquote>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220803030020194.png" alt="image-20220803030020194" /></p>
<h2>边框宽度border-width</h2>
<p>border-width属性用来控制边框宽度。该属性可以时像素值(不可以使用百分数)，也可以选择以下值之一:</p>
<blockquote>
<p>thin</p>
<p>medium</p>
<p>think</p>
</blockquote>
<p>可以通过下面4种属性分别对各个边框大小进行控制:</p>
<blockquote>
<p>border-top-width</p>
<p>border-right-width</p>
<p>border-bottom-width</p>
<p>border-left-width</p>
</blockquote>
<p>又或者：</p>
<pre><code class="language-css">border-width: 2px 1px 1px 2px; /*顺序为，上方，右侧，下方，左侧*/</code></pre>
<h2>边框样式border-style</h2>
<p>可使用border-style属性来控制边框的样式。该属性可以选用以下值：</p>
<blockquote>
<p>solid 一条实现</p>
<p>dotted 一串方形点</p>
<p>dashed 一条虚线</p>
<p>double 两条实线</p>
<p>ridge 显示为在页面上凸起的效果</p>
<p>inset 显示为嵌入页面的效果</p>
<p>outset 看起来像是凸出屏幕</p>
<p>hedden/none 不显示任何边框</p>
<p>每个边也可以单独设置样式</p>
</blockquote>
<pre><code class="language-css">p.one {border-style: solid;}</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220803031425280.png" alt="image-20220803031425280" /></p>
<h2>边框颜色border-color</h2>
<p>可利用RGB值、十六进制码或是CSS颜色名称来指定边框颜色。</p>
<p>每个边框可以单独设置。</p>
<pre><code class="language-css">p.one {
    border-color: #0088dd;
}</code></pre>
<h2>快捷方式border</h2>
<p>border属性允许你在一个属性中同时指定边框的宽度、样式和颜色</p>
<pre><code class="language-css">p {
    width: 250px;
    border:3px dotted #0088dd;
}</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220803032040230.png" alt="image-20220803032040230" /></p>
<h2>内边距padding</h2>
<p>padding属性用来指定元素的内容与元素边框之间保持多大的空隙。</p>
<pre><code class="language-css">p {
    padding: 10px;
}</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220803032254374.png" alt="image-20220803032254374" /></p>
<h2>外边距margin</h2>
<p>margin属性用来控制盒子之间的空隙。</p>
<pre><code class="language-css">p {
    margin: 20px;
}</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220803032433775.png" alt="image-20220803032433775" /></p>
<h2>内容居中</h2>
<p>如果想让一个盒子在页面上居中显示（或者在某个元素居中显示），可将left-margin属性和right-margin属性的值设置为auto</p>
<pre><code class="language-css">body {
    text-align: center;
}
p {
    width: 300px;
    padding: 50px;
    border: 20px solid #0088dd;
}
p.example {
    margin: 10px auto 10px auto;
    text-align: left;
}</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220803033236133.png" alt="image-20220803033236133" /></p>
<h2>内联元素与块级元素的转换display</h2>
<p>display属性允许你将一个内联元素转换成一个块级元素，反之赤然，而且该属性还可以从页面上隐藏元素。该属性可以选用以下值：</p>
<blockquote>
<p>inline：该值可以使一个块级元素表现得像一个内联元素。</p>
<p>block：该值可以使一个内联元素表现得像一个块级元素。</p>
<p>inline-block：该值可以使一个块级元素像内联元素那样浮动并保持其他的块级元素特征。</p>
<p>none：该值将一个元素从页面上隐藏。</p>
</blockquote>
<pre><code class="language-css">li {
    display: inline;
    margin-right: 10px;
}
li.coming-soon {
    display: none;
}</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220803034202040.png" alt="image-20220803034202040" /></p>
<h2>盒子的隐藏visibility</h2>
<p>visibility属性允许从用户的视线中隐藏盒子，但它保留了元素原来占用的空间。该属性可以选用以下值之一：</p>
<blockquote>
<p>hidden：该值用于隐藏元素。</p>
<p>visible：该值用于显示元素。</p>
</blockquote>
<pre><code class="language-css">li {
    display: inline;
    margin-right: 100px;
}
li.coming-soom {
    visibility: hidden;
}</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220803035335170.png" alt="image-20220803035335170" /></p>
<h2>CSS3：边框图像border-image</h2>
<p>border-image属性将图片应用到盒子的边框上。它采用一张背景图片，并将图片切割成九块。</p>
<p>该属性需要三种信息：</p>
<blockquote>
<ul>
<li>
<p>图片的URL</p>
</li>
<li>
<p>切割图片的位置</p>
</li>
<li>
<p>如何处理直边，可以选用以下值：</p>
<ul>
<li>stretch 伸展图片</li>
<li>repeat 重复图片</li>
<li>round 平铺图片</li>
</ul>
</li>
</ul>
</blockquote>
<pre><code class="language-css">#borderimg {
  border: 10px solid transparent;
  padding: 15px;
  border-image: url(border.png) 30 stretch;
}</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220803040837063.png" alt="image-20220803040837063" /></p>
<h2>CSS3：盒子的阴影box-shadow</h2>
<p>box-shadow属性允许在盒子的周围增加阴影。使用该属性时，至少包含下列项目中前两项的值以及一个颜色值。</p>
<blockquote>
<p>水平偏移：负值表示将阴影置于盒子的左侧。</p>
<p>垂直偏移：负值表示将阴影置于盒子的上方。</p>
<p>模糊距离：缺省默认为实边。</p>
<p>阴影扩展：如果使用该值，正值会使用阴影向四周延伸，负值则会使阴影收缩。</p>
</blockquote>
<pre><code class="language-css">p {
    box-shadow: 5px 5px 5px #777777;
}</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220803041620416.png" alt="image-20220803041620416" /></p>
<h2>CSS3：圆角border-radius</h2>
<p>css3引入了在盒子上创建圆角的功能。为了实现该功能，需要使用一个称为border-radius的属性。该值表示半径（像素）</p>
<pre><code class="language-css">p {
    border-radius: 10px
}</code></pre>
<h2>CSS3：椭圆形border-radius</h2>
<p>要创建更复杂的形状，可给圆角的横向值和纵向值指定不同的距离。</p>
<pre><code class="language-css">p {
    border-radius: 80px 50px;
}</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220803042115435.png" alt="image-20220803042115435" /></p>
<h1>列表、表格和表单</h1>
<h2>项目符号样式list-style-type</h2>
<p>list-style-type属性允许控制项目符号（也成为标记）的形状或样式。</p>
<p>该属性可在应用到<code>&lt;ol&gt;</code>元素、<code>&lt;ul&gt;</code>元素和<code>&lt;li&gt;</code>元素的规则中使用。</p>
<p>无序列表：</p>
<p>对于一个无序列表的list-style-type属性，可以使用以下值：</p>
<blockquote>
<p>none</p>
<p>disc</p>
<p>circle</p>
<p>square</p>
</blockquote>
<p>有序列表：</p>
<p>对于一个有序（编号）列表的list-style-type属性，可以使用以下值：</p>
<blockquote>
<p>decimal：123</p>
<p>decimal-leading-zero：01 02 03</p>
<p>lower-alpha：a b c</p>
<p>upper-alpha：A B C</p>
<p>lower-roman：i. ii. iii.</p>
<p>upper-roman：I II III</p>
</blockquote>
<pre><code class="language-css">ol {
    list-style-type: lower-roman;
}</code></pre>
<h2>项目图像list-style-image</h2>
<p>可利用list-style-imagge属性将一个图像作为项目符号使用。</p>
<p>该属性的值以字母url开头，后秒跟着一对圆括号。在括号里面，图像的路径在双引号中给出。</p>
<p>该属性可以在应用到<code>&lt;ul&gt;</code>元素和<code>&lt;li&gt;</code>元素的规则中使用。</p>
<pre><code class="language-css">ul {
    list-style-image: url(&quot;images/star.png&quot;);
}
li {
    margin: 10px 0px 0px 0px;
}</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220803152800407.png" alt="image-20220803152800407" /></p>
<h2>标记的定位list-style-position</h2>
<p>默认情况下，列表会缩进到页面中。list-style-position属性用于表明标记显示的位置，是在包含主体内容的盒子的内部，还是其在外部。</p>
<p>该属性可以选用以下两个值：</p>
<blockquote>
<p>outside：该值表明标记于文本块的左侧（这也是未使用该属性时的默认处理方式）</p>
<p>inside：该值表明标记位于文本的内部，同时文本块会被缩进。  </p>
</blockquote>
<pre><code class="language-css">ul {
    width: 250;
}
li {
    margin: 10px;
}
ul.illuminations {
    list-style-position: outside;
}
ul.season {
    list-style-position: inside;
}</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220803154637968.png" alt="image-20220803154637968" /></p>
<h2>列表快捷方式list-style</h2>
<p>与其他的一些CSS属性一样，针对列表样式也有一个类似快捷方式的属性。该属性称为list-style，它允许按任意顺序表示标记的样式、图像和位置属性。</p>
<pre><code class="language-css">ul {
    list-style:inside circle;
}</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220803174955075.png" alt="image-20220803174955075" /></p>
<h2>表格属性</h2>
<blockquote>
<p>width：表格宽度</p>
<p>padding：用于设置每个单元格边框与器内容之间的空隙</p>
<p>text-transform：用于将表格标题中的内容转换大写。</p>
<p>letter-spacing，font-size：用于为表格标题的内容增加额外的样式。</p>
<p>border-top，border-bottom：用于设置表格标题上方和下方的边框。</p>
<p>text-align：用于将某些单元格中的书写方式设置为左对齐或者向右对齐</p>
<p>background-color：用于交替改变表格行的背景颜色。</p>
<p>:hover：在用户把光标悬停在某个表格行时将此高亮显示</p>
</blockquote>
<h2>空单元格的边框empty-cells</h2>
<p>如果在一个表格中含有空单元格，那么就可以使用empty-cells属性来指定是否显示空单元格的边框。</p>
<p>如果想显示或隐藏单元格的边框，就需要用到empty-cells属性。可以选用以下三个值之一：</p>
<blockquote>
<p>show：用于显示空单元格的边框</p>
<p>hide：该值用于隐藏空单元格边框</p>
<p>inherit：如果一个表格嵌套在另一个表格中，那么inherit值表明单元格遵循外部表格规则。</p>
</blockquote>
<h2>单元格之间的空隙border-spacing，border-collapse</h2>
<p>border-spacing属性允许你控制相邻单元格之间的距离。默认情况下，浏览器经常在每个单元格之间留有一个较小的空隙，利用border-spacing属性可以进行控制，该属性的可选值有：</p>
<blockquote>
<p>collapse：该值表示尽可能将单元格相邻的边框合并为一个单独的边框</p>
<p>separate：该值表示将相邻的边框分离</p>
</blockquote>
<h2>定义单行文本框样式</h2>
<p>文本输入框的一些常用CSS属性：</p>
<blockquote>
<p>font-size：用于设置用户输入文本的大小</p>
<p>color，background-color：文本颜色,输入框的背景色</p>
<p>border，border-radius：增加边框边缘,创建圆角</p>
<p>:focus(伪类)：用来改变输入时文本输入框的背景颜色</p>
<p>:hover(伪类)：用来在用户将光标悬停在文本输入框时改变文本输入框的背景色</p>
<p>background-image：为盒子增加背景图像。</p>
</blockquote>
<h2>定义提交按钮样式</h2>
<blockquote>
<p>color：控制按钮上文本颜色</p>
<p>text-shandow：可在支持该属性的浏览器中展示3D效果的文本</p>
<p>border-bottom：使按钮的下方边框稍粗一点，从而使3D效果更加逼真</p>
<p>background-color：可以使提交按钮从周围的项目中突显出来</p>
</blockquote>
<h2>光标样式cursor</h2>
<p>cursor属性用于控制显示给用户的光标的类型。</p>
<p>例如，对于一个表单，把光标悬停于表单上时将光标设置为手型。常用值如下：</p>
<blockquote>
<ul>
<li>
<p>auto</p>
</li>
<li>
<p>crosshair</p>
</li>
<li>
<p>default</p>
</li>
<li>
<p>pointer</p>
</li>
<li>
<p>move</p>
</li>
<li>
<p>text</p>
</li>
<li>
<p>wait</p>
</li>
<li>
<p>help</p>
</li>
<li>
<p>url(&quot;cursor.gif&quot;);</p>
</li>
</ul>
</blockquote>
<pre><code class="language-css">a {
    cursor: move;
}</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220804000157227.png" alt="image-20220804000157227" /></p>
<h1>布局</h1>
<h2>普通流position:static</h2>
<p>在普通流中，每个块级元素都会在下一个元素的上方。由于这是浏览器处理HTML元素的默认方式。</p>
<h2>相对定位position:relative</h2>
<p>如果将一个盒子的position属性值设置为absolute，那么它就会脱离普通流，不在影响页面中其它元素的位置（如同它不在那个位置一样）。</p>
<p>盒子的位移属性（top或bottom以及keft或right）用于指定元素相对于它的包含元素应该显示在什么位置、</p>
<pre><code class="language-css">h1 {
    position: absolute;
    top: 0px;
    left: 500px;
    width: 250px;
}
p {
    width: 450px;
}</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220804003146839.png" alt="image-20220804003146839" /></p>
<h2>固定定位position:fixed</h2>
<p>固定定位时绝对定位的一种类型，将position属性的值设置为fixed就表示固定定位</p>
<p>固定定位时指元素相对于浏览器窗口进行定位。因此，当用户滚动页面时，这类元素的位置保持不变。</p>
<pre><code class="language-css">h1 {
    position: fixed;
    top: 0px;
    left: 0px;
    padding: 10px;
    margin: 0px;
    width: 100%;
    background-color: #efefef;
}</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220804005016393.png" alt="image-20220804005016393" /></p>
<h2>重叠元素z-index</h2>
<p>当使用相对定位、固定定位或者绝对定位时，盒子时可以重叠的。如果盒子出现重叠，那么在HTML代码中，后出现的元素将位于页面中先出现元素的上层。</p>
<p>如果要控制元素的层次，可使用z-index属性。该属性的值是一个数字，数值越大，元素的层级就越靠前。</p>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220804005615033.png" alt="image-20220804005615033" /></p>
<h2>浮动元素float</h2>
<p>float属性允许将普通流的元素在它的包含元素内尽可能地向左或向右排列。</p>
<pre><code class="language-css">blockquote {
    float: right;
}</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220804012217388.png" alt="image-20220804012217388" /></p>
<h2>清除浮动clear</h2>
<p>clear属性用于表明一个盒子的左侧或者右侧不允许浮动元素（在同一个包含元素内）。该属性可以选用以下值：</p>
<blockquote>
<p>left：盒子的左侧不能接触同一个包含元素内其他任何元素。</p>
<p>right：盒子的右侧不能接触同一个包含元素内其他任何元素。</p>
<p>both：盒子的左侧和右侧都不能接触同一个包含元素内的其他任何元素。</p>
<p>none：盒子的两侧都可以接触元素。</p>
</blockquote>
<h2>利用浮动创建多列式布局</h2>
<p>许多网页都采用了多列式的设计。这种设计的每一个列用一个<code>&lt;div&gt;</code>元素表示。下面三种CSS属性用来将多个列并排到一起：</p>
<blockquote>
<p>width：该属性用于设置列宽</p>
<p>float：该属性用于将多个列并排</p>
<p>margin：该属性用于将多个列之间创建空隙</p>
</blockquote>
<pre><code class="language-css">.columnlof2 {
    float: left;
    width: 620px;
    margin: 10px;
}
.column2of2 {
    float: left;
    width: 300px;
    margin: 10px;
}</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220804015424279.png" alt="image-20220804015424279" /></p>
<h2>固定宽度布局，流体布局</h2>
<p>固定宽度布局的设计不会因为用户扩大或缩小浏览器窗口而发生变化。这种设计通常以像素作为衡量单位。</p>
<p>流体布局设计随着用户对浏览器窗口的扩大或缩小而伸展或收缩，这种设计通常使用百分数。</p>
<h2>多个样式表@import,link</h2>
<p>有些网页设计人员将它们的CSS规则分为几个单独的样式表。例如他们可能会使用一个样式表来控制布局，而用另一个样式表来控制字体和颜色等</p>
<p>有些设计人员采取更加模块化的方法指定样式表，他们创建单独的样式表分别控制印刷排版、布局、表单、表格，甚至为网站内的每个子栏目指定不同的样式。</p>
<p>在一个页面内加入多个样式表的方法有两种：</p>
<blockquote>
<ul>
<li>在HTML页面链接一个样式表，然后再这个样式表中使用@import规则来导入其他的样式表。</li>
<li>可在HTML页面内使用多个<code>&lt;link&gt;</code>元素分别引用样式表。</li>
</ul>
</blockquote>
<pre><code class="language-html">&lt;!DOCTYPE html&gt;
&lt;html&gt;
    &lt;head&gt;
        &lt;title&gt;Import&lt;/title&gt;
        &lt;link rel = &quot;stylesheet&quot; type = &quot;text/css&quot; href = &quot;css/styles.css&quot; /&gt;
    &lt;/head&gt;
    &lt;body&gt;
    &lt;/body&gt;
&lt;/html&gt;</code></pre>
<pre><code class="language-css">@import url(&quot;tables.css&quot;);
@import url(&quot;typography.css&quot;);
body {
    ......
}</code></pre>
<h1>图像</h1>
<h2>在CSS中控制图像的大小</h2>
<p>可在CSS中利用width属性和height属性控制一个图像的大小</p>
<pre><code class="language-html">&lt;img src=&quot;images/magnolia-large.jpg&quot; class=&quot;large&quot; alt=&quot;Magnolia&quot;&gt;</code></pre>
<pre><code class="language-css">img.large{
    width: 500px;
    height: 500px;
}</code></pre>
<h2>使用CSS将图像对齐</h2>
<p>相对于<code>&lt;img&gt;</code>元素的align特性来说，越来越多的网页设计人员使用float属性来对齐图像。可以采用两种方式来实现对齐：</p>
<blockquote>
<ul>
<li>将float属性添加到控制图像大小的类中（比如small类）。</li>
<li>使用如align-left或align-right的名称创建新类，将图像在页面内向左或右对齐。</li>
</ul>
</blockquote>
<pre><code class="language-css">img.align-left {
    float: left;
    margin-right: 10px;
}</code></pre>
<h2>使用CSS将图像居中</h2>
<p>默认情况下，图像属于内联元素。这意味着它们与周围的文本一起流动。为使图像居中，我们应该转换成块级元素，通过将display属性的值设置为block可以完成转换。</p>
<p>图像被转换成块级元素后，可采用以下两种方法将其水平居中：</p>
<blockquote>
<ul>
<li>
<p>对于图像的包含元素，可将其text-align属性的值设置为center。</p>
</li>
<li>
<p>对于图像本身而言，可使用margin属性并将其左，右外边距的值设置为auto。</p>
</li>
</ul>
</blockquote>
<pre><code class="language-css">img.align-center{
    dispaly: block;
    margin: 0px auto;
}</code></pre>
<h2>背景图像background-image</h2>
<p>background-image属性允许你在任何HTML元素之后放置图像。背景图像可以填满整个页面或是填充页面的一部分。默认情况下，背景图像会自动重复并充满整个盒子。</p>
<pre><code class="language-css">body {
    background-image: url(&quot;images/pattern.gif&quot;);
}</code></pre>
<h2>重复图像background-repeat background-attachment</h2>
<p>background-repeat 属性可选用以下四个字值中的一个：</p>
<blockquote>
<ul>
<li>
<p>repeat：背景图像在水平方向和垂直方向上都进行重复（默认的显示方式）</p>
</li>
<li>
<p>repeat-x：背景图像只在水平方向进行重复</p>
</li>
<li>
<p>repeat-y：背景图像仅在垂直方向上重复</p>
</li>
<li>
<p>no-repeat：背景图像只显示一次。background-attachment属性用于指定背景图像在用户混动页面时的移动方式，可以选用以下两个值中的一个：</p>
<ul>
<li>fixed：背景图像固定在页面中的一个位置</li>
<li>scroll：背景图像随用户上下滚动页面而上下移动</li>
</ul>
</li>
</ul>
</blockquote>
<h2>背景图像的定位background-position</h2>
<p>如果背景图像不进行重复，可以使用background-position属性来指定背景图像在浏览器在窗口中的位置</p>
<p>该属性通常会有一堆值。第一个值表示水平位置，第二个值表示垂直位置</p>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220805005947429.png" alt="image-20220805005947429" /></p>
<pre><code class="language-css">body {
    background-image: url(&quot;images/tulip.gif&quot;);
    background-repeat: no-repeat;
    background-position: center top;
}</code></pre>
<h2>简写background</h2>
<p>该属性比如按照以下顺序来指定，但如果不想指定某个属性，可将其忽略。</p>
<blockquote>
<p>background-color</p>
<p>background-image</p>
<p>background-repeat</p>
<p>background-attachment</p>
<p>background-position</p>
</blockquote>
<pre><code class="language-css">div {
    background:
        url(example-1.jpg)
        no-repeat top left
}</code></pre>
<h2>图像翻转与子画面</h2>
<p>利用CSS，可在用户将光标悬停在一个链接或按钮上时为链接或按钮创建另一种样式（称为翻转），还可以在用户单击它时创建第三种样式。</p>
<p>当一个单独的图像应用在某个界面的多个不同部位时，它就被称为子画面（sprite）</p>
<h2>CSS3：渐变background-image</h2>
<p>渐变通过background-image属性来创建。</p>
<pre><code class="language-css">#grad {
    background-image: linear-gradient(#e66465, #9198e5);
}</code></pre>