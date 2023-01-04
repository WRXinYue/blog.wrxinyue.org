---
title: 3.C#编程概述
date: 2022-07-23 21:47:45.0
updated: 2022-10-26 22:40:36.928
url: /archives/3c-bian-cheng-gai-shu
categories: 
- C#/.NET
tags: 
- c#
---

<h2>一个简单的C#程序</h2>
<p>windows按下W+R，在运行窗口输入devenv调出VS，然后新建一个项目</p>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220723171156852.png" alt="image-20220723171156852" /></p>
<p>选择C#-Windows-控制台应用模板，名称改为SimpleProgram</p>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220723171448502.png" alt="image-20220723171448502" /></p>
<p>右键项目文件夹我们在新建一个SimpleProgram的C#脚本</p>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220723171731579.png" alt="image-20220723171731579" /></p>
<p>输入代码如下：</p>
<pre><code class="language-c#">using System;   //诉编译器这个应用程序使用System命名空间的类型

namespace Simple  //声明一个新命名空间，名称为Simple
{
    class Program   //声明一个新的类类型，名称为Program
    {
        static void Main()  //声明一个名称为Main的方法作为类Program的成员
        {
            Console.WriteLine(&quot;Hello World&quot;); //只包含一条单独的、简单的语句，这一行组成了Main的方法体
        }
    }
}</code></pre>
<h2>标识符</h2>
<p>标识符是一种字符串，用来命名变量、方法、参数和许多后面将要闸述的其他程序结构。</p>
<p>实例：</p>
<pre><code class="language-C#">//语法上有效，但非常混乱
int totalCycleCount;
int TotalCycleCount;
int TotalcycleCount;</code></pre>
<p>命名字符规则：</p>
<blockquote>
<ul>
<li>字母和下划线可以用在任何位置</li>
<li>数字不能放在首位</li>
<li>@字符只能放在标识符首位，但不推荐使用</li>
</ul>
</blockquote>
<p>命名规则最好为驼峰式命名法或者下划线命名法，在团队合作中一个命名是很重要的！！！</p>
<p>什么是驼峰命名法？</p>
<blockquote>
<p>驼峰命名法有大驼峰和小驼峰，函数、变量一般用小驼峰法，除第一个单词外，其他单词首字母大写，大驼峰法（即帕斯卡命名法），全部单词首字母大写。常用于类名，属性，命名空间等，实例如下：</p>
</blockquote>
<pre><code class="language-C">public class DataBaseUser;  //大驼峰，类名，属性，命名空间等
int myStudentCount;     //小驼峰，函数、变量</code></pre>
<h2>关键字</h2>
<ul>
<li>关键字不能被用作变量名或者其他形式的标识符，除非以@字符开始。</li>
<li>所有C#关键字全部都是小写</li>
</ul>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220723174734662.png" alt="image-20220723174734662" /></p>
<p>上下文关键字是仅在特定的语言结构中充当关键字的标识符。</p>
<p>关键字和上下文关键字的区别：</p>
<blockquote>
<p>关键字不能被用作标识符，而上下位关键字可以在代码的其他部分被用作标识符</p>
</blockquote>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220723175213250.png" alt="image-20220723175213250" /></p>
<h2>Main函数：程序的起始点</h2>
<p>每个C#程序都必须有一个类带有Main方法（函数）。在先前所示的SimpleRrogram程序中，它被声明在Program类中。</p>
<p>最简单的Main方法：</p>
<pre><code class="language-c#">static void Main()
{
    更多语句
}</code></pre>
<h2>空白</h2>
<p>程序中的空白指的是没有可视化输出的字符。空白字符包括：</p>
<blockquote>
<ul>
<li>空格（Space）；</li>
<li>制表符（Tab）；</li>
<li>换行符：</li>
<li>回车符。</li>
</ul>
</blockquote>
<p>例如，下面代码段虽然看起来不一样，但是在编译器的眼里都是一样的...</p>
<pre><code class="language-c#">//我心目中的完美的格式（强迫症福音）
Main()
{
    Console.WriteLine(&quot;Hello Word&quot;);
}

//老程序员的代码段，这看起来好难受:(
Main(){
    Console.WriteLine(&quot;Hello Word&quot;);
}

//没有空格回车的代码段
Main(){Console.WriteLine(&quot;Hello Word&quot;);}</code></pre>
<h2>语句</h2>
<p>语句是描述一个类型或告诉程序去执行某个动作的一条源代码指令，语句有简单语句（simple statement）和复杂语句（compound statement）</p>
<blockquote>
<h3>简单语句（simple statement</h3>
<ul>
<li>
<p>指定(赋值)</p>
</li>
<li>
<p>调用</p>
</li>
<li>
<p><a href="https://zh.wikipedia.org/w/index.php?title=回傳_(電腦科學)&amp;action=edit&amp;redlink=1">回传</a></p>
</li>
<li>
<p>goto</p>
</li>
<li>
<p>断言</p>
</li>
</ul>
<h3>复合语句（compound statement）</h3>
<ul>
<li><strong><a href="https://zh.wikipedia.org/w/index.php?title=Block_(程式設計)&amp;action=edit&amp;redlink=1">block</a></strong></li>
<li><strong><a href="https://zh.wikipedia.org/wiki/條件語句">if语句</a></strong></li>
<li><strong><a href="https://zh.wikipedia.org/w/index.php?title=Switch敘述&amp;action=edit&amp;redlink=1">Switch语句</a></strong></li>
<li><strong><a href="https://zh.wikipedia.org/wiki/While迴圈">While循环</a></strong></li>
<li><strong><a href="https://zh.wikipedia.org/wiki/Do-while循环">Do-while循环</a></strong></li>
<li><strong><a href="https://zh.wikipedia.org/wiki/For迴圈">For循环</a></strong></li>
</ul>
</blockquote>
<p>实例：</p>
<pre><code class="language-C#">int combatRating = 5; //定义一个初始指为5，ombatRating的整数型变量
System.Console.WriteLine(&quot;This is a scum with a combatRating of {0}&quot;,ombatRating);</code></pre>
<p>代码块：</p>
<blockquote>
<p>块可以是一个由成对大括号包围的0条或者N条语句的序列，它在语法相当于一条语句。</p>
</blockquote>
<pre><code class="language-c#">{
    int combatRating = 5; //定义一个初始指为5，ombatRating的整数型变量
    System.Console.WriteLine(&quot;This is a scum with a combatRating of {0}&quot;,ombatRating);
}</code></pre>
<p>关于代码块一些重要的内容：</p>
<blockquote>
<ul>
<li>语法上只需要一条语句，而你需要执行的动作无法用一条简单的语句表达的情况下，考虑使用代码快。</li>
<li>有些特定的程序结构只能使用块。在这些结构中，不能使用简单语句替换块。</li>
<li>虽然简单语句以分号结束，但块后面不跟分号。</li>
</ul>
</blockquote>
<h2>从程序中输出文本</h2>
<p>BLC提供一个名为Console的类（在System命名空间中），该类包含了将数据输入和输出到控制台窗口的方法。</p>
<h3>Write</h3>
<p>Write是Console类的成员，它把一个文本字符串发送到程序的控制台窗口</p>
<p>实列：</p>
<pre><code class="language-C#">Console.Write(&quot;This is trivial text&quot;);</code></pre>
<h3>WriteLine</h3>
<p>WriteLine是Console的另一个成员，它和Write实现相同的功能，但是在每个输出字符串的结尾添加一个换行字符。</p>
<h3>格式字符串</h3>
<p>Write语句和WriteLine语句的常规形式中可以由一个以上的参数。</p>
<ul>
<li>如果不止一个参数，参数间用逗号分隔。</li>
<li>第一个参数必须是字符串，称为<strong>格式字符串</strong>。格式字符串可以包含<strong>替代标记</strong>。
<ul>
<li>替代标记在格式字符串中标出位置，在输出字符串中该位置将用一个值来替代。</li>
<li>替代标记由一个整数及括住它的一对大括号组成，其中整数就是替换值的数字位置。跟着格式字符串的参数称为替换值，这些替换值从0开始编号</li>
</ul></li>
</ul>
<p>语法：</p>
<pre><code class="language-c#">Console.WriteLine(格式字符串 (含替代标记) ，替换值0，替换值1， 替换值2，......);</code></pre>
<p>实例：</p>
<pre><code class="language-c#">Console.WriteLine(&quot;Two saple integers are {0} and {1}.&quot; 3，6)；</code></pre>
<p>C# 6.0引入了更简单易懂的的方式表述参数化字符串的语法，称为<strong>字符串插值</strong>，他是通过直接在替代标记内插入变量名实现的。实际上，替代标记告诉编辑器这个变量名将被视作为一个变量，而不是字符串字面量——前提是在字符串前面加上了$符号。</p>
<pre><code class="language-c#">int var1 = 3;
int var2 = 6;
Console.WriteLine($&quot;Two sample integers are {var1} and {var2}.&quot;)</code></pre>
<h3>多重标记和值</h3>
<p>在C#中，可以使用任意数量的替代标记和任意数量的值。</p>
<ul>
<li>值可以以任何顺序使用</li>
<li>值可以在格式字符串中替换任意次</li>
</ul>
<p>例如，下面的语句使用了3个标记但只有两个值。注意：值1被用在了值0之前，而且被用了两次。</p>
<pre><code class="language-C#">Console.WriteLine(&quot;Three integers are {1}, {0} and {1}.&quot;,3,6)</code></pre>
<h3>格式化数字字符串</h3>
<pre><code class="language-c#">Console.WriteLine(&quot;The value: {0}.&quot; , 500);       //输出数字
Console.WriteLine(&quot;The value: {0:C}.&quot; , 500); //格式化为货币</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220723210332696.png" alt="image-20220723210332696" /></p>
<ol>
<li>
<p>对齐说明符</p>
<p>对齐说明符表示字段中字符的最小宽度。对齐说明符有以下特性：</p>
<ol>
<li>对齐说明符是可选的，而且使用逗号来和索引号分离。</li>
<li>符号表示右对齐或左对齐。正数表示右对齐，负数表示左对齐。</li>
</ol>
</li>
<li>
<p>格式字段</p>
<p>格式字段表示指定了数字应该以哪种形式表示。例如：应该表示为货币、十进制数字、十六进制数字还是定点符号？</p>
<ol>
<li>
<p>冒号后必须紧跟着格式说明符，中间不能有空格。</p>
</li>
<li>
<p><strong>格式说明符</strong>是一个字母字符，是9个内置字符格式之一。某些字符形式不分大小写</p>
</li>
<li>
<p><strong>精度说明符</strong>是可选的，由1~2位数字组成。它的实际意义取决于格式说明符。实例：</p>
<pre><code class="language-c#">Console.WriteLine("{0:F4}, 12.345678");
//F4：格式组件——4位小数的定点数</code></pre>
</li>
</ol>
</li>
<li>
<p>标准数字格式说明符
<img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220723212252685.png" alt="image-20220723212252685" />
<img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220723212330265.png" alt="image-20220723212330265" /></p>
</li>
</ol>
<h2>注释</h2>
<ul>
<li>不能嵌套带有分隔符的注释</li>
<li>注释类型的范围如下：
<ul>
<li>对于单行注释//，一直到行结束都有效。</li>
<li>对于带分隔符的注释，直至遇到第一个结束分隔符都有效。</li>
</ul></li>
</ul>
<pre><code class="language-c#">    带分割符的注释由两个字符的开始标记（/*）和两个字符的结束标记（*/）
/*
    注释的文本不会被编译器执行
    带分隔符的注释可以跨任意多行
*/</code></pre>
<h3>文档注释</h3>
<p>文档注释只包含XML文本，可以用于产生程序文档，实例：</p>
<pre><code class="language-c#">///&lt;summary&gt;
///This class does...
///&lt;/summary&gt;
class Program
{
    ......</code></pre>