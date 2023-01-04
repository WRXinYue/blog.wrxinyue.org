---
title: 5.类的基本概念
date: 2022-07-25 23:56:39.0
updated: 2022-10-26 22:49:07.872
url: /archives/5-lei-de-ji-ben-gai-nian
categories: 
- C#/.NET
tags: 
- c#
---

<h2>类的概述</h2>
<h3>类是一种活动的数据结构</h3>
<p>程序的数据和功能被组织为逻辑上相关的数据项和函数的封装集合，并成为类。</p>
<p>类是一个能存储数据并执行代码的数据结构。它包含数据成员和函数成员：</p>
<blockquote>
<ul>
<li>数据成员    它存储与类或类的实例相关的数据。</li>
<li>函数成员    代码执行</li>
</ul>
</blockquote>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220725211627290.png" alt="image-20220725211627290" /></p>
<h2>声明类</h2>
<p>类型int、double和char由C#定义。但像Dealer和Player这样的类不是由语言定义，如果使用它们就必须通过<strong>编写类的声明</strong>来定义它们：</p>
<blockquote>
<ul>
<li>类的名称；</li>
<li>类的成员；</li>
<li>类的特征。</li>
</ul>
</blockquote>
<p>实例：</p>
<pre><code class="language-c#">关键字 类名
{
    成员声明
}
class MyExcellentClss
{
    ...
}</code></pre>
<h2>类成员</h2>
<p>字段和方式是最重要的类成员类型。字段是数据成员，方法是函数成员。</p>
<p>C#在类型的外部<strong>不能声明全局变量</strong>（也就是变量或字段）。所有的字段都属于类型，而且必须在类型声明内部声明。</p>
<h3>字段</h3>
<p>字段是隶属于类的变量：</p>
<blockquote>
<ul>
<li>它可以是任意类型，无论是预定义类型还是用户定义类型。</li>
<li>和所有变量一样，字段用来保存数据，并具有如下特征：
<ul>
<li>可以被写入；</li>
<li>可以被读取。</li>
</ul></li>
</ul>
</blockquote>
<p>实例：</p>
<pre><code class="language-c#">类型  字段名称;
Type  Identifier;
//例如，下面的类包含字段MyField的声明，它可以保存int值：
class MyClass
{
    int MyField;//类型  字段名称
}
</code></pre>
<ol>
<li>
<p>显式和隐式字段初始化</p>
<p>因为字段是一种变量所以和变量初始化语句相同：</p>
<blockquote>
<ul>
<li>
<p><strong>字段初始化语句</strong>是字段声明的一部分，由一个等号后面跟着一个求值表达式构成。</p>
</li>
<li>
<p>初始化值必须是编译时可确定的：</p>
<pre><code class="language-c#">class MyClass
{
  int F1 = 17;//类型  字段名称  字段初始化值
}</code></pre>
</li>
<li>
<p>如果没有初始化语句，字段的值会被编译器设为默认值，默认值由字段的类型决定。如int初始化值为0，bool为false，string为null。</p>
</li>
</ul>
</blockquote>
</li>
<li>
<p>声明多个字段</p>
<p>方法与前一章相同，实例：</p>
<pre><code class="language-c#">int F1,F3 = 25;
string F2,F4 = "abcd";</code></pre>
</li>
</ol>
<h3>方法</h3>
<p>方法是具有名称的可执行代码块，可以从程序的很多不同地方执行，甚至从其他程序执行。</p>
<p>当方法被<strong>调用</strong>（call/invoke）时，它执行自己所含的代码，然后返回到调用它的代码并继续执行调用代码。有些方法返回一个值到它们被调用的位置。方法相当于C++中的<strong>成员函数</strong>。</p>
<p>C#<strong>没有全局函数</strong>（方法）声明在类型声明的外部。C#方法没有默认的返回类型，所有方法必须包含返回类型或void</p>
<p>声明方法最简语法包括以下组成部分。</p>
<blockquote>
<ul>
<li>返回类型    方法返回值的类型，如果方法不返回值，那么返回类型被指定void</li>
<li>名称  方法的名称</li>
<li>参数列表    至少有一对空的圆括号组成</li>
<li>方法体 由一对大括号组成，大括号包含执行的代码</li>
</ul>
</blockquote>
<p>例如：</p>
<pre><code class="language-c#">class SimpleClass
{
    //返回类型  方法名称  参数列表
    void PrintNums()
    {
        Console.WriteLine(&quot;1&quot;);
        Console.WriteLine(&quot;2&quot;);
    }
}</code></pre>
<h2>创建变量和类的实例</h2>
<p>一旦类被声明，就可以创建类的实例：</p>
<blockquote>
<ul>
<li>类是引用类型</li>
<li>数据的引用保存在一个类类型的变量中</li>
</ul>
</blockquote>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220725220705021.png" alt="image-20220725220705021" /></p>
<h2>为数据分配内存</h2>
<p>声明类类型的变量所分配的内存是用来保存引用的，而不是用来保存类对象实际数据的。需要使用new运算符为实际数据分配内存：</p>
<blockquote>
<ul>
<li>
<p>new运算符为任意指定类型的实例分配并初始化内存。他依据类型的不同从栈或堆里分配。</p>
</li>
<li>
<p>使用new运算符组成一个<strong>对象创建表达式</strong>，他的组成如下：</p>
<ul>
<li>
<p>关键字 new；</p>
</li>
<li>
<p>需要分配的内存实例的类型名称；</p>
</li>
<li>
<p>成对的圆括号，可以是空值</p>
</li>
</ul>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220725221305453.png" alt="image-20220725221305453" /></p>
</li>
<li>
<p>如果将内存分配一个引用类型（变量），则对象创建表达式返回一个引用，指向在堆中被分配并初始化的对象实例。</p>
</li>
</ul>
</blockquote>
<p>实例：</p>
<pre><code class="language-C#">Dealer theDealer;   //声明引用对象
theDealer = new Dealer();   //为类对象分配内存并赋值给变量
//合并
Dealer theDealer = new Dealer();    //声明并初始化</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220725223853260.png" alt="image-20220725223853260" /></p>
<h2>实例成员</h2>
<p>类声明相当于蓝图，通过这个蓝图创建多少个类的实例都可以。</p>
<blockquote>
<ul>
<li>实例成员    类的每个实例都是不同的实体，它们有自己的一组数据成员，因为这些数据成员都和类的实例相关，所以被称为<strong>实例成员</strong>。</li>
<li>静态成员    实例成员是默认类型，但也可以声明与类而不是实例相关的成员，称为静态成员。</li>
</ul>
</blockquote>
<p>实例：</p>
<pre><code class="language-c#">class Dealer { ... }    //声明类
class Player            //声明类
{
    string Name;        //字段
    ...
}
class Program
{
    static void Main()
    {
        Dealer theDealer = new Dealer();
        Player player1 = new Player();
        Player player2 = new Player();
        Player player3 = new Player();
        ...
    }
}</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220725230028473.png" alt="image-20220725230028473" /></p>
<h2>访问修饰符</h2>
<p>从类的内部，任何函数成员都可以使用成员的名称访问类中任意的其他成员。</p>
<p>访问修饰符成员声明的可选部分。下面是字段和方法声明的语法：</p>
<pre><code class="language-c#">字段
    访问修饰符 类型 标识符;
方法
    访问修饰符 返回类型 方法名()
{
    ...
}</code></pre>
<p>5种成员访问控制如下：</p>
<blockquote>
<ul>
<li>私有的（private）</li>
<li>公有的（public）</li>
<li>受保护的（protected）</li>
<li>内部的（internal）</li>
<li>受保护内部的（protected internal）</li>
</ul>
</blockquote>
<h3>私有访问和公有访问</h3>
<p>私有成员只能从声明它的类的内部访问，其他的类看不见或者无法访问它们。</p>
<blockquote>
<ul>
<li>
<p>私有访问是默认访问级别</p>
</li>
<li>
<p>可以将private访问修饰符显式地将一个成员声明为私有。例如：</p>
<pre><code class="language-c#">     int MyInt1;      //隐式声明为私有
private int MyInt2;     //显式声明为私有</code></pre>
</li>
</ul>
</blockquote>
<ol>
<li>
<p>公有访问和私有访问图示</p>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220725231724122.png" alt="image-20220725231724122" /></p>
</li>
<li>
<p>成员访问示例</p>
<pre><code class="language-c#">class C1
{
   int   F1;                //隐式私有字段
   private int F2;          //显式私有字段
   public int F3;           //公有字段

   void DoCalc()            //隐式私有方法
   {
       ...
   }
   public int GetVal()      //公有方法
   {
       ...
   }
}</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220725232134734.png" alt="image-20220725232134734" /></p>
</li>
</ol>
<h2>从类的内部访问成员</h2>
<p>即使字段和两个方法被声明为private，类的所有成员还是可以被类的任何方法（或任何函数成员）访问。</p>
<pre><code class="language-c#">class DaysTemp
{
    //字段
    private int High = 75;
    private int Low = 45;

    //方法
    private int GetHigh()
    {
        return High;        //访问私有字段
    }
    private int GetLow()
    {
        return Low;
    }
    public float Average()
    {
        returm(GetHigh() + GetLow()) /2;   //访问自由方法
    }
}</code></pre>
<h2>从类的外部访问成员</h2>
<p>要从类的外部访问实例成员，必须包括变量名称和成员名称，中间用句点（.）分隔。这称为<strong>点运算符</strong>（dot-syntax notation）。实例：</p>
<pre><code class="language-c#">DaysTemp myDt = new DaysTemp();     //创建类的对象
float fValue = myDt.Average();      //从外部访问,myDt变量名称，Average成员名称

class DaysTemp      //声明类DaysTemp
{
    public int High = 75;
    public int Low = 45;
}

class Program       //声明类Program
{
    static void Main()
    {
        DaysTemp temp = new DaysTemp();     //创建对象
        temp.High = 85;         //tmp.high字段名称和字段，字段赋值
        temp.Low = 60;

        Console.WriteLine(&quot;High {0}&quot;,temp.High);      //读取字段值
        Console.WriteLine($&quot;Low: {temp.Low}&quot;);
    }
}</code></pre>
<h2>综合应用</h2>
<pre><code class="language-C#">class DaysTemp  //声明类
{
    public int High, Low;   //声明实例字段
    public int Average()
    {
        returm (High + Low) / 2;
    }

    class Program
    {
        static void Main()
        {
            //创建两个DaysTemp实例
            DaysTemp t1 = new DaysTemp();
            DaysTemp t2 = new DaysTemp();

            //给字段赋值
            t1.High = 76;   t1.Low = 57;
            t2.High = 75;   t2.Low = 53;

            //读取字段值
            //调用实例方法
            Console.WriteLine(&quot;t1: {0} {1} {2}&quot;, t1.High, t1.Low, t1.Average() );
            console.WriteLine(&quot;t2: {0} {1} {2}&quot;, t2.High, t2.Low, t2.Average() );
        }
    }
}</code></pre>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220725235419052.png" alt="image-20220725235419052" /></p>