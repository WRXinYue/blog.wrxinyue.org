---
title: 4.类型、存储量和变量
date: 2022-07-24 23:03:58.0
updated: 2022-10-26 22:46:29.268
url: /archives/4-lei-xing--cun-chu-liang-he-bian-liang
categories: 
- C#/.NET
tags: 
- c#
- ./net
---

<h2>C#程序是一组类型声明</h2>
<p>C程序可以说是一组函数和数据类型，C++程序是一组函数和类，而C#程序是一组类型声明。</p>
<ul>
<li>C#程序或DLL的源代码是一组类型声明。</li>
<li>对于可执行程序，类型声明中必须有一个包含Main方法的类</li>
<li>命名空间是一种将相关的类型声明分组并命名的方法。因为程序是一组相关的类型声明，所以通常在你创建的命名空间内部声明程序类型。</li>
</ul>
<pre><code class="language-c#">namespace MyProgram     //创建新的命名空间
{
    DeclarationOfTypeA      //声明类型
    DeclarationOfTypeB

    class C             //声明类型
    {
        static void Mian()
        {
            ...
        }
    }
}</code></pre>
<h2>类型（数据类型）是一种模板</h2>
<p>既然C#程序是一组类型声明，那么学习C#就是学习如何创建和使用类型。</p>
<p>类型由下面的元素定义：</p>
<ul>
<li>名称；</li>
<li>用于保存数据成员的数据结构；</li>
<li>一些行为及约束条件。</li>
</ul>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220724204941396.png" alt="image-20220724204941396" /></p>
<h2>实例化类型</h2>
<p>从某个类型模板创建实际的对象，称为实例化该类型。</p>
<ul>
<li>通过实例化类型而创建的对象被称为类型的<strong>对象</strong>或者类型的<strong>实例</strong></li>
<li>在C#程序中，每个数据项都是某种类型的实例。这些类型可以是语言自带的，可以是BCL或者其他库提供的，也可以是程序与定义的。</li>
</ul>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220724205821339.png" alt="image-20220724205821339" /></p>
<h2>数据成员和函数成员</h2>
<p>像short、int和long这样的类型称为<strong>简单类型</strong>。这种类型只能存储一个数据项。</p>
<p>其他的类型可以存储多个数据项。比如<strong>数组(array)</strong>类型就可以存储多个同类型的数据项。这些数据项称为<strong>数组</strong>元素。可以通过数字来引用这些元素，这些数字被称为<strong>索引</strong>。</p>
<h3>成员的类别</h3>
<p>包含多个不同的数据类型的数据项，这些类型中的数据项个体称为<strong>成员</strong>，和数组不同，这些成员有独特的名称：</p>
<ul>
<li>数据成员  保存了这个类的对象或整个类相关的数据。</li>
<li>函数成员    执行代码。函数成员定义类型的行为。</li>
</ul>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220724210808664.png" alt="image-20220724210808664" /></p>
<h2>预定义类型</h2>
<p>C#提供了16种预定义类型，其中包括13种简单类型和3种非简单类型。</p>
<p>简单类型：</p>
<blockquote>
<ul>
<li>11种数值类型（数据类型属于数值类型的超类）
<ul>
<li>不同长度的有符号和无符号整数类型。</li>
<li>浮点数类型float和double。</li>
<li>decimal高精度小数类型，常用于货币计算。</li>
</ul></li>
<li>Unicode字符类型char。</li>
<li>布尔类型bool。</li>
</ul>
</blockquote>
<p>非简单类型：</p>
<blockquote>
<ul>
<li>string，Unicode字符数组。</li>
<li>object，其他类型的基类。</li>
<li>dynamic，使用动态语言编写的程序集时使用。</li>
</ul>
</blockquote>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220724212150360.png" alt="image-20220724212150360" /></p>
<h3>预定类型的补充</h3>
<p>所有预定类型都直接映射到底层的.NET类型。C#类型名称就是.NET类型的别名，所以使用.NET的类型名称也符合C#语法。</p>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220724212526509.png" alt="image-20220724212526509" /></p>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220724212540755.png" alt="image-20220724212540755" /></p>
<h2>用户定义类型</h2>
<p>有6种类型可以由用户自己创建：</p>
<blockquote>
<ul>
<li>类类型（calss）；</li>
<li>结构类型（struct）；</li>
<li>数组类型（array）；</li>
<li>枚举类型（enum）；</li>
<li>委托类型（delegate）；</li>
<li>接口类型（interface）；</li>
</ul>
</blockquote>
<p>类型通过类型声明创建，类型声明包含以下信息：</p>
<blockquote>
<ul>
<li>要创建的类型的种类；</li>
<li>新类型的名称；</li>
<li>对类型中每个成员的声明（名称和规格），array和delegate类型除外，它们不含有命名成员。</li>
</ul>
</blockquote>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220724213342909.png" alt="image-20220724213342909" /></p>
<h2>栈和堆</h2>
<p>程序运行时，它的数据必须存储在内存中。一个数据项需要多大的内存、存储在什么地方，以及如何存储都依赖于该数据项的类型。</p>
<p>运行中的程序使用两个内存区域来存储数据：栈和堆</p>
<h3>栈</h3>
<p>栈是一个内存数组，是一个LIFO（Last-In First-Out，后进先出）的数据结构。栈存储几种类型的数据：</p>
<blockquote>
<ul>
<li>某些类型变量的值；</li>
<li>程序当前的执行环境；</li>
<li>传递给方法的参数。</li>
</ul>
</blockquote>
<p>栈的特性：</p>
<blockquote>
<ul>
<li>数据只能从栈的顶端插入和删除。</li>
<li>把数据放到栈顶称为<strong>入栈</strong>（push）。</li>
<li>从栈顶删除数据称为出栈（pop）。</li>
</ul>
</blockquote>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220724214439691.png" alt="image-20220724214439691" /></p>
<h3>堆</h3>
<p>堆是一块内存区域，在堆里可以分配大块的内存用于存储某种类型的数据对象。与栈不同，堆的内存能够以任意顺序存入和移除。</p>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220724215301619.png" alt="image-20220724215301619" /></p>
<p>堆里面的数据不能显式删除。CLR的自动垃圾收集器在判断出程序的代码将不会再访问某数据项时，会自动清除无主的堆对象。</p>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220724215639141.png" alt="image-20220724215639141" /></p>
<h2>值类型和引用类型</h2>
<p>数据项的类型定义了存储数据需要的内存大小及组成该类型的数据成员。类型还决定了对象在内存中的存储位置——栈或堆。</p>
<p>类型被分为两种：值类型和引用类型，这两种类型在内存中的存储方式不同：</p>
<blockquote>
<ul>
<li>值类型只需要一段单独的内存，用于存储实际的数据。</li>
<li>引用类型需要两端内存。
<ul>
<li>第一段存储实际的数据，它总是位于堆中。</li>
<li>第二段是引用，指向数据在堆中的存放位置。</li>
</ul></li>
</ul>
</blockquote>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220724220552136.png" alt="image-20220724220552136" /></p>
<h3>存储引用类型对象的成员</h3>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220724221100783.png" alt="image-20220724221100783" /></p>
<h3>C#类型的分类</h3>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220724221306178.png" alt="image-20220724221306178" /></p>
<h2>变量</h2>
<p>变量是一个名称，表示程序执行时存储在内存中的数据</p>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220724221647942.png" alt="image-20220724221647942" /></p>
<h3>变量声明</h3>
<p>变量使用前必须声明：</p>
<blockquote>
<ul>
<li>给变量命名，并为它关联一种类型；</li>
<li>让编译器为它分配一块内存。</li>
</ul>
</blockquote>
<p>实例：</p>
<pre><code class="language-C">int var1;
//int为数据类型，var2为类型的值</code></pre>
<p>4个变量的声明以及它们在栈中的位置</p>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220724222035940.png" alt="image-20220724222035940" /></p>
<p>1.变量初始化语句</p>
<p>除声明变量的名称和类型以外，声明还能把它的内存初始化为一个明确的值。</p>
<p><strong>变量初始化语句（variablie initializer）</strong>由一个等号后面跟一个初始值组成，如：</p>
<pre><code class="language-c#">int var2 = 17;</code></pre>
<p>有些程序变量不初始化赋值会报错</p>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220724222632442.png" alt="image-20220724222632442" /></p>
<p>2.自动初始化</p>
<p>有些程序会自动初始化，没有自动初始化为默认值的变量在程序为它赋值之前包含未定义值。</p>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220724222902859.png" alt="image-20220724222902859" /></p>
<p><img src="https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220724222919753.png" alt="image-20220724222919753" /></p>
<h3>多变量声明</h3>
<p>可以在单个声明语句中声明多个变量：</p>
<blockquote>
<ul>
<li>多变量声明中的变量必须类型相同。</li>
<li>变量名必须用逗号分隔，可以在变量名后包含初始化语句。</li>
</ul>
</blockquote>
<p>实例：</p>
<pre><code class="language-c#">//声明一些变量，有的被初始化，优点未被初始化
int var3 = 7, var4, var5 = 3;
double var6, var7 = 6.53;

int var8, float var9;   //错误！多变量声明的变量类型必须相同</code></pre>
<h3>使用变量的值</h3>
<p>变量名代表该变量保存的值，可以通过使用变量名来使用值。例如：</p>
<pre><code class="language-c#">Console.WriteLine(&quot;{0}&quot;, var2);
Console.WriteLine(&quot;{var2}&quot;);</code></pre>
<h2>静态类型和dynamic关键字</h2>
<p>每一个变量都包括变量类型。这样编译器在运行时可以确定需要的内存总量以及那些部分应该存在栈上，哪些部分应该在堆上。变量的类型在编译运行的时候不能被修改。这叫做<strong>静态类型</strong>。</p>
<p>不是所有的语言都是静态类型的，诸如InronPython和IronRuby之类的脚本语言时<strong>动态类型</strong>的。也就是说，变量的类型直到运行时才会被解析。由于它们是.NET语言，所以C#程序需要能够使用这些语言编写的程序集。问题是，程序集中的类型到运行时才会被解析，而C#又要引用这样的类型并且需要在编译的时候解析类型。</p>
<p>针对这个问题，C#语言设计者增加了dynamic关键字，代表一个特定的C#类型，它知道如何在运行时解析自身。</p>
<p>在编译时，编译器不会对dynamic类型的变量做类型检查。相反，他将与该变量及该变量的操作有关的所有信息打包。在运行时，会对这些信息进行检查，以确保它与变量所代表的实际类型一致。否则，将在运行时抛出异常。</p>
<h2>可空类型</h2>
<p>在某些情况下，特别是使用数据库的时候，你希望表示变量目前为保存有效的值。对于引用类型把变量设置为null即可。但定义值类型的变量时，不管它的内容是否含有有效的意义，其内存都会进行分配。</p>
<p><strong>可空类型</strong>允许创建可以标记为有效或无效的值类型变量，这样就可以在使用它之前确定值的有效性。普通的值类型称作<strong>非可空类型</strong>。</p>