---
title: Java笔记
date: 2022-09-16 03:20:02.0
updated: 2023-04-18 15:09:30
categories: 
- WEBbackend
tags: 
- java
---

# Java 程序设计概述

## 简单性

Java语法是C++语法的一个“纯净”版本。这里没有头文件、指针运算（甚至指针语法）、结构、联合、操作符重载、虚基类等。

“简单”的另一个方面是小。Java的目标之一是支持开发能够在小型机器上独立运行的软件。

## 面向对象

简单来讲，面向对象设计是一种程序设计技术。它将重点放在数据（即对象）和对象的接口上。在本质上，Java的面向对象能力与C++是一样的。

## 分布式

Java有一个丰富的例程库，用于处理像HTTP和FTP之类的TCP/IP 协议。

Java应用程序能够通过URL打开和访问网络上的对象，其便捷程度就好像访问本地文件一样。

## 健壮性

Java的设计目标之一在于使得Java编写的程序具有多方面的可靠性。Java非常强调进行早期的问题检测、后期动态的（运行时）检测，以及消除容易出错的情况......Java与C/C++最大的不同在于Java采用的指针模型可以消除重写内存和损坏数据的可能性。

## 安全性

Java要适用于网络/分布式环境。为了实现这个目标，安全性颇受重视。使用Java可以构建防病毒、防篡改的系统。

## 体系结构中立

编译器生成一个体系结构中立的目标文件格式，这是一种编译过的代码，只要有Java运行时系统，这些编译后的代码可以在许多处理器上运行。Java编译器通过生成与特定的计算机体系结构无关的字节码指令来实现这一特性。精心设计的字节码不仅可以很容易地在任何机器上解释执行，而且还可以动态的转换成本地机器代码。

解释性虚拟机指令肯定会比全速运行机器指令慢很多。不过，虚拟机有一个选项，可以将执行最频繁的字节码序列转换成机器码，这一过程为即时编译。

Java虚拟器还有一些其他优点。它可以检查指令序列的行为，从而增强其安全性。

## 可移植性

与C和C++不同，Java规范中没有“依赖具体实现”的方法。基本数据类型的大小以及有关运算的行为都有明确的说明。

例如，Java中的int永远为32位的整数，而在C/C++中，int可能是16位整数、32位整数，也可能是编译器开发商指定的任何其他大小。唯一的限制只是int类型的字节数不能低于short int，而且不能高于long int。在Java 中，数值类型有固定的字节数，这消除了代码移植时一个令人头痛的主要问题。二进制数据以固定的格式进行存储和传输，消除了字节顺序的困扰。字符串则采用标准的Unicode格式存储。

Java库能够很好地支持平台独立性。可以处理文件、正则表达式、XML、日期和时间、数据库、网络连接、线程等，从而不用操心地城操作系统。不仅程序是可以移植的，Java API往往也比原生的API质量更高。

## 高性能

尽管对解释后的字节码性能已经比较满意，但在有些场合下还需要更高的性能。

字节码可以（在运行时）动态地转换成对应运行这个程序的特定CPU的机器码。

## 多线程

多线程可以带来更快的交互响应和实时行为。

至今我们非常关注并发性。我们不再追求更快的处理器，而是着眼于获得更多的处理器，而且要让它们一直保持工作。不过，可以看到，大多数编程语言对于这个问题并没有显示出足够的重视。

Java在当时很超前。它是第一个支持并发程序设计的主流语言。当时，多核处理器还很神秘，而Web编程才刚刚起步，处理器要花很长时间等待服务器响应，需要并发程序设计来确保用户界面不会“冻住”。

## 动态性

从很多方面来看，Java与C或C++相比更加具有动态性。他能够适应不断发展的环境。库中可以自由地添加新方法和实例变量，二对客户端却没有任何影响。下Java中找出运行时类型信息十分简单。

当需要为正在运行的程序添加代码时，动态性将是一个非常重要的特性。一个很好的例子：从Internet下载代码，然后再浏览器上运行。如果使用C或C++，这确实难度很大，不过Java设计者很清楚动态语言可以很容易地实现运行程序的演进。最终，他们将这一特性引入这个主流程序设计语言中。

> 小知识：Java成功地推出后不久，微软就发布了一个叫作J++的产品，它与Java有几乎相同的编程语言和虚拟机。现在，微软不再支持J++，取而代之的时另一个名为C#的语言。C#和Java有很多相似之处，不过在一个不同的虚拟机上运行。

## Java applet 与 Internet

这里的想法很简单：用户从Internet下载Java字节码，并在自己的机器上运行。在网页中运行的Java程序称为applet。而使用applet，只需要一个启用Java的Web浏览器，它会为你执行字节码。不需要安装任何软件。任何时候只要访问包含applet的网页，就会得到程序的最新版本。最重要的是，要感谢虚拟机的安全性，它让我们不必再担心来自而已代码的攻击。

## Java发展简史

Java的历史要追溯到1991年，由Patrick Naughton和James Gosling（一个全能的计算机奇才，Sun公司会士）带领的Sun的工程师小组想要设计一种小型的计算机语言，主要用于像有线电视转换盒这类消费设备。由于这些消费设备的处理能力和内存都很有限，所以语言必须非常小而能够生成非常紧凑的代码。另外，由于不同的厂商会选择不同的中央处理器（CPU），因此很重要的一点是这种语言不应与任何特定的体系结构绑定。这个项目被命名为“Green”。

代码短小，紧凑且与平台无关，这些要求促使开发团队设计出一个可移植的语言，可以为虚拟机生成中间代码。

不过，Sun公司的人都有UNIX的应用背景。因此，所开发的语言以C++为基础，而不是Lisp、Smalltalk或Pascal。不过，就像Gosling在专访中谈道：“毕竟，语言只是实现目标的工具，而不是目标本身。”Gosling把这种语言称为“Oak”。Sun公司的人后台发现，Oak是一种已有的计算机语言的名字，于是，将其改名为Java。

1992年，Green项目发布了它的第一个产品，称之为“*7”。这个产品可以提供非常智能的远程控制。遗憾的是，Sun公司对生产这个产品并不感兴趣，Green项目组的人员必须找出其他的方法来将他们的技术推向市场。然而，仍然没有一家标准消费品电子公司对此感兴趣。于是，Green项目组投标了一个设计有线电视盒的项目，它能提供视频点播等新型有线服务，但他们没能拿到这个合同。

Green项目（这时换了一个新名字——“First Person公司”）在1993年一整年以及1994年的上半年，一直在苦苦寻求买家购买他们的技术。然而，一个也没有找到。1994年First Person公司解散了。

当这一切在Sun公司发生的时候，Internet的万维网也在日渐发展壮大。万维网的关键是浏览器把超文本页面转换到屏幕上。1994年大多数人都在使用Mosaic，这是1993年出自伊利诺伊大学超级计算中心的一个非商业化的Web浏览器。

在接受SunWorld采访的时候，Gosling说，在1994年中期，Java语言的开发者意识到：“我们能够建立一个相当酷的浏览器。在客户/服务器主流框架中，浏览器恰好需要我们已经完成的一些工作：体系结构中立、实时、可靠、安全——这些问题在工作站环境并不太重要，所以，我们决定开发浏览器。”

实际的浏览器是由Patrick Naughton 和Jonathan Payne 开发的，并演变为HotJava浏览器。HotJava浏览器采用Java编写，以炫耀Java语言超强的能力。这个浏览器能够在网页中执行内嵌的Java代码。这一“技术证明”在1995年5月23日的SunWorld‘95大会上展示，同时引发了人们延续至今对Java的狂热追逐。

1996年年初，Sun发布了Java第一个版本-Java 1.0，但是Java1.0不能用来真正的应用开发。

1998年发布了Java 1.2版。这个版本早期玩具式的GPU和图形工具包代之以复杂而且可伸缩的工具包。

标准版的1.3和1.4版本对最初的Java2版本做出了增量式的改进，提供了不断扩展的标准类库，提高了性能，当然，还修正了一些bug。在此期间，原先对Java applet和客户端应用的炒作逐渐消退，但Java成为服务器端应用的首选平台。

5.0版是自1.1版以来第一个对Java语言做出重大改进的版本（这一版本原来定为1.5版，在2004年的JavaOne会议之后，版本号直接升至5.0）。经过了多年的研究，这个版本添加了泛型类型（generic type0，大致相当于C++的模板），其挑战性在于添加这一特性而不需要对虚拟机做出任何修改。另外，受到C#的启发，还增加了几个很有用的语言特性：“for each”虚幻、自动装箱和注解。

版本6（没有后缀.0）于2006年年末发布。同样，这个版本没有对语言方面再进行修改，而是做了其他性能改进，并增强了类库。

随着数据中心越来越依赖于商业硬件而不是专用服务器，Sun公司终于沦陷，于2009年被Oracle收购。Java的开发停止了很长一段时间。直到2011年Oracle发布了Java的一个新版本——Java 7，其中只做了一些简单的改进。

2014年，Java8终于发布，再近20年中这个版本发生的改变最大。Java 8 包含了一种“函数式”编程方式，可以很容易得表述并发执行的计算。所有编程语言都必须与时俱进，Java再这方面显示出了非凡的能力。

Java 9的主要特性要一直追溯到2008年。那时，Java平台首席工程师Mark Reinhold开始着力分解这个庞大的Java平台。为此引入了模块，模块是提供一个特定功能的自包含的代码单元。设计和实现一个适用于Java平台的模块系统前后用了11年，而它是否也适用于Java应用和类库还有待观察。Java9于2017年发布，它提供了另外一些吸引人的特性。

从2018年开始，每6个月就会发布一个Java版本，以支持更快地引入新特性。某些版本（如Java 11）设计为长期支持的版本。

# Java程序设计

## 安装Java开发工具包

Oracle公司为Linux、Mac OS、Solaris 和 Windows 提供了最新、最完备的Java开发工具包版本。对于很多其他平台，也有处于不同开发阶段的JDK版本，不过，这些版本要相应平台的开发商授权和分发。

## 下载JDK

想要下载Java开发工具包，可以访问Oracle公司的网站：https://www.oracle.com/java/technologies/downloads/

华为镜像网站：https://repo.huaweicloud.com/java/jdk/

在得到所需的软件之前，必须弄清楚大量专业术语：

![image-20220917003236028](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220917003236028.png)

![image-20220917003317331](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220917003317331.png)

你已经看到，JDK是Java Development Kit 的缩写。有点混乱的是：这个工具包的版本1.2~1.4被称为Java SDK。在某些场合下，还可以看到这个过时的术语。在Java 10之前，还有一个术语是Java运行时环境（JRE），它只包含虚拟机。这不是开发人员想要的，只是专门为不需要编译器的用户提供。

接下来，你会看到大量的Java SE，相对于Java EE和Java ME，Java SE是Java标准版。

Java2这种提法始于1998年。当时Sun公司的销售人员感觉以增加小数点后面数值的方式改变版本号并没有反映出JDK1.2的重大改进。但是，在于发布之后才意识到这个问题，所以他们决定开发工具包的版本号仍然沿用1.2，接下来的版本是1.3、1.4和5.0.不过，Java平台重新被命名为Java 2。因此，就有了Java 2 Standard Edition Software Development Kit（Java 2标准版软件开发包）5.0版，即J2SE SDK 5.0。

幸运的是，2006年版本号得到简化。Java标准版的下一个版本取名为Java SE 6，后来又有了Java SE 7和Java SE 8

不过，“内部”版本号分别是1.6.0、1.7.0和1.8.0.到了Java SE 9，这种混乱终于终结，版本号变为9，以及后来的9.0.1。（为什么没有使用9.0.0作为初始版本呢？为了保留一点兴奋感，版本号规范要求在主版本和第一次安全更新之间的短暂间隔中删除版本号末尾的零。）

> 注：在此后面的Java 9表示Java SE 9

在Java9之前，有32位和64位两个版本的Java开发工具包，现在Oracle公司不再开发32位版本。要使用Oracle JDK，你需要有一个64位的操作系统。

对于Linux，还可以在RPM文件和.tar.gz文件之间做出选择。我们建议使用后者，这样就可以在任何位置直接解压缩这个压缩包。

小结：

* 我们需要的是JDK（Java SE 开发工具包），而不是JRE。
* 对于Linux，选择 .tar.gz版本

> 注：取决于具体情况，Oracle公司可能会提供一个捆绑包，其中包含Java开发工具包（JDK）和 NetBeans 集成开发环境。建议现在不要安装任何捆绑包，目前只需要安装Java开发工具包。如果以后打算使用NetBeans，可以再从 http://netbeans.org 下载.

![image-20220917013821076](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220917013821076.png)

## 设置JDK

下载JDK之后，需要安装这个开发工具包并明确要在哪里安装，后面还会需要这个信息。

* 再Windows上，启动安装程序，会询问你要在哪里安装JDK。最好不要接收路径名称包含空格的默认位置，如 C:\Program Files\Java\jdk-11.0.x。取出路径名中的Program Files部分就可以了。

  ![image-20220917014833715](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220917014833715.png)

* 在Linux上，只需要把.tar.gz解压缩到你选择的某个位置，如你的主目录，或者/opt。如果从RPM文件安装，则要反复检查是否安装在/usr/java/jdk-11.0.x上。

环境变量配置：

* 在Linux中，需要在~/.bashrc或~/.bash_profile文件的最后增加这样一行：

  ~~~bash
  export PATH=jdk/bin:$PATH
  ~~~

  一定要使用JDK的正确路径，如/opt/jdk-11.0.4。

* 在Windows 10中，在搜索栏输入environment（环境），选择编辑账户的环境变量-环境变量。

* 在User Variables（用户变量）列表中找到并选择一个名为Path的变量。点击Edit（编辑）按钮，再点击New（新建）按钮，添加一个变量，值为jdk\bin目录![image-20220917020459628](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220917020459628.png)

* 打开一个终端窗口输入`javac --version`,来检查配置是否正确：

  ![image-20220917020829148](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220917020829148.png)

## 安装库源文件和文档

源文件：

>注：如果含有源文件可以跳过此步骤

![image-20220917022126431](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220917022126431.png)

类库源文件在JDK中以压缩文件lib/src.zip的形式发布，将其解压缩后才能够访问源代码。只需要完成以下步骤：

1. 确保JDK已经安装，而且jdk/bin目录在可执行路径中。

2. 在主目录中创建一个目录javasrc。如果愿意，可以从一个终端窗口完成这个步骤。

   ~~~shell
   mkdir javasrc
   ~~~

3. 在jdk/lib 目录下找到文件src.zip。

4. 将src.zip 文件解压到javasrc目录。在一个终端窗口中，可以指向以下命令：

   ~~~shell
   cd javasrc
   jar xvf jdk/lib/src.zip
   cd ...
   ~~~

> 提示：src.zip文件中包含了所有公共类库的源代码。要想获得更多源代码（例如编译器、虚拟机、原生方法以及私有辅助类），请访问网站 http://openjdk.java.net

文档：

文档包含在一个压缩文件中，它是一个独立于JDK的压缩文件。可以从网站 http://www.oracle.com/technetwork/java/javase/downloads 下载这个文档。

## 使用命令行工具

第一次安装Java时，需要先检查Java的安装是否正确。另外，通过自己执行这些基本步骤，可以更好得理解开发环境的后台工作。

在掌握了编译和运行Java程序的基本步骤之后，我们就需要使用专业的开发环境，让我们从基础开始吧：

首先介绍比较难的方法：从命令行编译并运行Java程序。

1. 打开一个终端窗口。

2. 进入 corejava\v1ch02\welcome目录（下载地址：[点我](https://horstmann.com/corejava/corejava11.zip)）

3. 输入下面的命令：

   ~~~shell
   javac Welcome.java
   java Welcome
   ~~~

   ![image-20220917031105650](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220917031105650.png)

如果成功输出如上结果，可喜可贺，我们已经编译了并运行了第一个Java程序。

那么，刚才发生了什么？javac程序是一个Java编译器，他将文件Welcome.java编译成Welcome.class。Java程序启动Java虚拟机，虚拟机执行编译器编译到类文件中的字节码。

~~~java
/**
 * This program displays a greeting for the reader.
 * @version 1.30 2014-02-27
 * @author Cay Horstmann
 */
public class Welcome
{
   public static void main(String[] args)
   {
      String greeting = "Welcome to Core Java!";
      System.out.println(greeting);
      for (int i = 0; i < greeting.length(); i++)
         System.out.print("=");
      System.out.println();
   }
}
~~~

在使用集成开发环境的年代，许多程序员对于在终端窗口中运行程序已经很生疏了。常常会出现很多错误，最终导致令人沮丧的结果。

一定要注意一下几点：

* 如果手工输入源程序，一定要注意正确地输入大小写。例如，类名为Welcome,而不是
  welcome或WELCOME,
* 编译器需要一个文件名(Welcome.java),而运行程序时，只需要指定类名(Welcome),不要带扩展名，.java或.class.
* 如果看到诸如Bad command or file name或javac:command not found之类的消息，就
  要返回去反复检查安装是否有问题，特别是可执行路径的设置。
* 如果javac报告了一个错误，指出无法找到Welcome.java,就应该检查目录中是否存在这个文件。
  * 在Linux环境下，检查Welcome.java是否以正确的大写字母开头。
  * 在Windows环境下，使用命令dir,而不要使用图形浏览器工具。有些文本编辑器(特别是Notepad)会在每个文件名后面添加扩展名 .txt。如果使用Notepad编辑
    Welcome.java,实际上会把它保存Welcome.java.txt。如果采用默认的Windows设置，浏览器会与Notepad“勾结”，隐藏，txt扩展名，因为这属于“已知的文件类型”。对于这种情况，需要使用命令ren重新命名这个文件，或是另存一次，在文件名两边加一对双引号，如："Welcome.java"。
 * 运行程序之后，如果收到关于java.lang.NoClassDefFoundError的错误消息，就应该仔细地检查出问题的类名。
   * 如果收到关于welcome(w为小写)的错误消息，就应该重新执行命令：java Welcome(W为大写)。记住，Java区分大小写。
   * 如果收到有关Welcome/java的错误信息，这说明你错误地键入了java Welcome.java,应该重新执行命令java Welcome.
 * 如果键入java Welcome,而虚拟机没有找到Welcome类，就应该检查是否有人设置了系统的CLASSPATH环境变量（将这个变量设置为全局并不是提倡的做法，然而，Windows中有些比较差的软件安装程序确实会这样做）。可以像设置PATH环境变量一样设置CLASSPATH,不过这里将删除这个设置。

> 注：在JDK 11中，单个源文件不再需要javac命令。这个特性是为了支持以”shebang“(#!)行(#!/path/to/java)开头的shell脚本。

接下来再来尝试一个图像化应用。这个程序是一个简单的图像文件查看器，可以加载和显示一个图像。与前面一样，从命令行编译和运行这个程序。

1. 打开一个终端窗口

2. 切换到目录corejava\v1ch02\ImageViewer

3. 输入以下命令：

   ~~~shell
   javac ImageViewer.java
   java ImageViewer
   ~~~

   ![image-20220917033710946](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220917033710946.png)

会弹出一个新的程序窗口（ImageViewer应用）。现在选择File->Open，找到一个要打开的图像文件。（这个目录下有两个示例文件。）然后会显示这个文件。![GIF 2022-9-17 3-40-35](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/GIF%202022-9-17%203-40-35.gif)

要关闭这个程序，可以点击标题栏上的关闭按钮，或者从菜单选择File->Exit。

~~~java
import java.awt.*;
import java.io.*;
import javax.swing.*;

/**
 * A program for viewing images.
 * @version 1.31 2018-04-10
 * @author Cay Horstmann
 */
public class ImageViewer
{
   public static void main(String[] args)
   {
      EventQueue.invokeLater(() -> {
         var frame = new ImageViewerFrame();
         frame.setTitle("ImageViewer");
         frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
         frame.setVisible(true);
      });
   }
}

/**
 * A frame with a label to show an image.
 */
class ImageViewerFrame extends JFrame
{
   private static final int DEFAULT_WIDTH = 300;
   private static final int DEFAULT_HEIGHT = 400;

   public ImageViewerFrame()
   {
      setSize(DEFAULT_WIDTH, DEFAULT_HEIGHT);

      // use a label to display the images
      var label = new JLabel();
      add(label);

      // set up the file chooser
      var chooser = new JFileChooser();
      chooser.setCurrentDirectory(new File("."));

      // set up the menu bar
      var menuBar = new JMenuBar();
      setJMenuBar(menuBar);

      var menu = new JMenu("File");
      menuBar.add(menu);

      var openItem = new JMenuItem("Open");
      menu.add(openItem);
      openItem.addActionListener(event -> {
         // show file chooser dialog
         int result = chooser.showOpenDialog(null);

         // if file selected, set it as icon of the label
         if (result == JFileChooser.APPROVE_OPTION)
         {
            String name = chooser.getSelectedFile().getPath();
            label.setIcon(new ImageIcon(name));
         }
      });

      var exitItem = new JMenuItem("Exit");
      menu.add(exitItem);
      exitItem.addActionListener(event -> System.exit(0));
   }
}
~~~

## 使用集成开发工具

我们已经了解如何从命令行编译和运行一个Java程序。这是一个很有用的排错技能，不过对于大多数日常工作来说，这还是应该使用集成开发环境。这些环境非常强大，非常方便，不使用这些集成环境简直有些不合情理。我们可以免费获得一些很棒的开发环境，如Eclipse、IntelliJ IDEA 和 NetBeans。

Eclipse下载地址：http://eclipse.org/downloads

下载之后运行安装程序，并选择Eclipse IDE for Java Developers。

![image-20220917034901867](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220917034901867.png)

下面是用Eclipse编写程序的一般步骤：

1. 启动Eclipse之后，从菜单选择File->New->Project
2. 从向导对话框中选择Java Project
3. 点击Next按钮，不选中”Use default location“复选框。点击Browse导航到core-java/v1ch02/Welcome目录。
4. 点击Finish按钮。这个工程已经创建完成了。
5. 点击工程窗口左边窗格中的三角，直到找到Welcome.java并双击这个文件。现在应该看到一个包含程序代码的窗格
6. 用鼠标右键点击左侧窗格中的工程名（Welcome），选择Run->Run As->Java Application。程序输出会显示在控制台窗格中。

![GIF 2022-9-17 4-13-36](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/GIF%202022-9-17%204-13-36.gif)

之前假定这个程序没有输入错误或bug（毕竟，这段代码只有几行）。为了说明问题，假设在代码中不小心出现了录入错误（或者甚至语法错误）。试着将原来的程序修改一下，让它包含一些录入错误，列入，将String的大小写弄错：

~~~java
string greeting = "Welcome to Core Java!";
~~~

![image-20220917042456384](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220917042456384.png)

注意string下面的波浪线。点击源代码下标签中的Problems，展开小三角，直到看到一个错误消息指出有一个未知的string类型。点击这个错误消息。光标会移到编辑窗格中相应的代码行，可以在这里纠正错误。利用这个特性可以快速地修正错误。

> 提示：通常，Eclipse错误报告会伴有一个灯泡图标。点击这个图标可以得到解决这个错误的建议方案列表。

## JShell

Java9进入了另一种使用Java的方式。JShell程序提供一个“读取-计算-打印循环”（Read-Evaluate-Print Loop。REPL）。键入一个Java表达式；JShell会评估你的输入，打印结果，等待你的下一个输入。

要启动JShell，只需要在终端窗口中键入jshell

JShell首先会向你显示一个问候语，后面是一个提示符：

![image-20220918232038432](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220918232038432.png)

现在键入一个表达式，如下：

~~~shell
"Core Java".length()
~~~

JShell会回应一个结果——在这里就是”Core Java“中的字符个数。

~~~shell
$1 ==> 9
~~~

注意，我们并没有输入System.out.println。JShell会自动打印你输入的每一个表达式的值。输出中的$1表示这个结果可以用来的计算。例如，如果你输入：

~~~shell
5 * $1 - 3
~~~

![image-20220918233146620](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220918233146620.png)

就会得到：

![image-20220918235210457](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220918235210457.png)

如果需要多次使用一个变量，可以给它们指定一个容易记忆的名字。不过，一定要遵循Java语法，需要指定类型和变量名。例如：

~~~shell
jshell> int answer = 6 * 7
answer ==> 42
~~~

另一个有用的特性是”tab补全“。如果输入：

~~~shell
Math.
~~~

然后再按一次Tab键。你就会得到可以在generator变量上调用的所有方法的一个列表：

![image-20220918234857491](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220918234857491.png)

现在输入l，然后再按一次Tab键。方法名会补全位log，现在你会得到一个比较小的列表：

![image-20220918235118413](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220918235118413.png)

接下来可以手动填入其余的部分：

~~~shell
jshell> Math.log10(0.001)
~~~

![image-20220919002342773](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220919002342773.png)

要重复运行一个命令，可以连续按↑键，知道看到想要重新运行或编辑的命令行。可以用←和→键移动命令行中的光标位置，然后添加或删除字符。编辑完命令后再按回车。例如，把命令行中的0.001替换为1000，然后按回车：

![image-20220919003005176](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220919003005176.png)

JShell会让Java语言和类库的学习变得轻松而有趣，它不要求你启动一个庞大的开发环境，不会让你再为public static void main而困扰。

# Java的基本程序设计结构

## 一个简单的Java应用程序

下面看一个最简单的Java应用程序，它只发送一条消息到控制台窗口中：

~~~java
public class FirstSample {
  public static void main(String[] args)
  {
    System.out.println("We will not use 'Hello,World!'");
  }
}
~~~

![image-20220919010043654](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220919010043654.png)

> 注：出于个人习惯，本人用的是IntelliJ IDEA，Eclipse IDE实在用不惯。

这个程序很简单，所有的Java应用程序都具有这种结构，因此还是值得花一些时间来研究的。首先，Java区分大小写。如果出现了大小写拼写错误（例如，将main拼写成Main），程序将无法运行。

下面逐行地查看这段源代码。关键字public称为访问修饰符（access modifier），这些修饰符用于控制程序的其他部分对这段代码的访问级别。关键字class表明Java程序中的全部内容的包括在类中。类是构建所有Java应用程序和applet的构建块。Java应用程序中的全部内容都必须放置在类中。

关键字class后面紧跟类名。Java中定义类名的规则很宽松。名字必须以字母开头，后面可以跟字母和数字的任意组合。长度基本上没有限制。但是不能用Java保留字（例如，public或class）作为类名。

类名是以大写字母开头的名词。如果名字是由多个单词组成，每个单词的第一个字母都应该大写（驼峰命名法）。

源代码的文件必须与公共类的名字相同，并用.java作为扩展名。因此，存储这段源代码的文件必须为FirstSample.java。

如果正确的命名了这个文件，并且源代码没有任何录入错误，在编译这段源代码之后就会得到一个包含这个类字节码的文件。Java编译器将字节码文件自动地命名为FirstSample.class，并存储在源文件的同一个目录下。

Java虚拟机总是从指定类中的main方法的代码开始执行（这里的”方法“就是Java中的”函数“），因此为了代码能够执行，在类的源文件中必须包含一个main方法。当然，也可以将用户自定义的方法添加到类中，并将main方法中调用这些方法。

需要注意源代码中的大括号{}.在Java中，像在C/C++中一样，用大括号划分程序的各个部分（通常称为块）。Java中任何方法的代码都用”{“ 开始，用 ”}“结束。

大括号的使用风格曾经引发过许多无意义的争论。我们的习惯是把匹配的大括号上下对齐。不过，由于空白符会被Java编译器忽略，可以选用自己喜欢的大括号风格。

我们暂时不用理睬关键字static void，而仅把它们当作编译Java 应用程序必须要的部分就行了。现在只需要机制：每个Java应用程序都必须有一个main方法，其声明格式如下所示：

~~~java
public class ClassName
{
    public static void main(String[] args)
    {
        program statements
    }
}
~~~

接下来研究以下代码：

~~~java
{
    System.out.printlun("We Will not use 'Hello, World!'");
}
~~~

一对大括号表示方法体的开始与结束，在这个方法中只包含一条语句。与大多数程序设计语言一样，可以将Java语句看成是语言中的句子。在Java中，每个句子必须用分号结束。特别需要说明，回车不是语句结束标志，因此，如果需要将一条语句写在多行上。

在上面这个main方法体中只包含了一条语句，其功能是将一个文本行输出到控制台上。

在这里，我们使用System.out对象并调用了它println方法。注意，点好（.）用于调用方法Java使用的通用语法是

~~~java
object.method(parameters)
~~~

这等价于函数调用。

在这个示例中，调用了println方法并传递给它一个字符串参数。这个方法将传递给它的字符串参数显示在控制台上。然后，终止是这个输出行，使得每次调用println都会在新的一行上显示输出。需要注意一点，Java与C/C++一样，都采用双引号界定字符串。

与其他程序设计语言的函数一样，Java中的方法可以没有参数，也可以有一个或者多个参数（实参）。即使一个方法没有参数，也需要需用空括号。例如，不带参数的println方法只打印一个空行。使用下面的语句来调用：

~~~java
System.out.println();
~~~

> 注：System.out 还有一个print方法，它不在输出之后增加换行符。例如，Ststem.out.print("Hello")打印"Hello"之后不换行，后面的输出紧跟在字母"o"之后。

## 注释

与大多数程序设计语言一样，Java中的注释也不会出现在可执行程序中。因此，可以在源程序中根据需要添加任意多的注释，而不必担心可执行代码会膨胀。在Java中，有3种标记注释的方式，最常用的方式是使用//，其注释内容从//开始到本行结尾。

~~~java
System.out.println("We will not use 'Hello, World!'"); //is this too cute?
~~~

当需要更长的注释时，既可以在每行的注释前面标记//。也可以使用/* 和 */注释界定符将一段比较长的注释括起来。

最后，第3种注释可以用来自动地生成文档。这种注释以`/**` 开始，以`*/`结束。

![image-20220920154243355](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220920154243355.png)

> 注：注释不能嵌套

## 数据类型

Java是一种强类型语言。这就意味着必须为每一个变量声明一种类型。在Java中，一共有8种基本类型（primitive type），其中有4种整数、2种浮点类型、1种字符类型char（用于表示Unicode编码的代码单元）和1种用于表示真值的boolean类型。

### 整数

整数用于表示没有小数的数值，允许是负数。Java提供了4种整型。

![image-20220920230124192](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220920230124192.png)

在通常情况下，int类型最常用。但如果想要表示整个地球的居住人口。就需要使用long类型了。byte和short类型主要用于特定的应用场合，例如，底层文件处理或者存储空间很宝贵时的大数组。

在Java中，整型的范围与运行Java代码的机器无关。这就解决了软件从一个平台移植到另一个平台，或者在同一个平台中的不同操作系统直接进行移植给程序员带来的诸多问题。与此相反，C和C++程序会针对不同的处理器选择最为高效的整数，这样就会造成一个32位处理器上运行很好的C程序在16位系统上运行时却发生整数溢出。由于Java程序必须保证在所有机器上都能得到相同的运行结果，所以各种数据类型的取值范围必须固定。

长整数数值有一个后缀L或l（如 4000000000L）。十六进制数值有一个前缀0x或0

X（如0xCAFE）。八进制有一个前缀0，例如，010对应十进制中的8。很显然，八进制表示法比较容易混淆，所以建议做好不要使用八进制常数。

从Java7开始，加上前缀0b或0B就可以写二进制数。列入，0b1001就是9.另外，同样是从Java7开始，还可以为数字字面量加下划线，如用1_000_000（或0B1111_0100_0010_0100_0000）表示100万。这些下划线只是为了让人更易读。Java编译器会去除这些下划线。

### 浮点类型

浮点类型用于表示有小数部分的数值。在Java中有两种浮点类型。

![image-20220921092809896](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220921092809896.png)

double表示这种类型的数值精度是float类型的两倍（双精度数值）。

float类型的数值有一个后缀F或f（例如，3.14F）。没有后缀F的浮点数值（如3.14）默认为double类型。当然，也可以在浮点数值后面添加后缀D或d（例如，3.14D）。

所有的浮点数值计算都遵循IEEE 754规范。具体来说，下面是用于表示溢出和出错情况的三个特殊的浮点数值：

* 正无穷大
* 负无穷大
* NaN（不是一个数字）

例如，一个正整数除以0的结果为正无穷大。计算0/0或者负数的平方根结果为NaN。

### char类型

char类型原本用于表示单个字符。不过，现在情况已经有所变化。如今，有些Unicode字符可以用一个char值描述，另外一些Unicode字符则需要两个char值。

char类型的字面量值要用单引号括起来。例如：“A”是编码值为65的字符常量。它与“A”不同，“A”是包含一个字符A的字符串。

![image-20220921141144002](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220921141144002.png)

在Java中，char类型描述了UTF-16编码中的一个代码单元。

强烈建议不要在程序中使用char类型，除非确实处理UTF-16代码单元，最好将字符串作为抽象数据类型处理。

### boolean 类型

boolean（布尔）类型有两个值：false和true，用来判定逻辑条件。整型值和布尔值之间不能进行相互转换。

## 变量与常量

与所有程序设计语言一样，Java也使用变量存储值。常量就是不变的变量。

### 声明变量

在Java中，每个变量都有一个类型（type）。在声明变量时，先指定变量的类型，然后是变量名。实例：

~~~java
double salary;
int varationDays;
long earthPopulation;
boolean done;
~~~

变量名必须是一个以字母开头并由字母或数字构成的序列。字母包括‘A’~‘Z’、‘a’~‘z’、‘_’、‘$’,或在某种语言中表示字母的任何Unicode字符。

不能使用Java保留字作为变量名。在Java9中，单下划线_不能作为变量名；

可以在一行中声明多个变量：

~~~java
int i,j;  //both are integers
~~~

不过，不提倡使用这种风格。逐一声明每一个变量可以提高程序的可读性。

### 变量初始化

声明一个变量之后，必须用赋值语句对变量进行显式初始化，千万不要使用未初始化的变量的值。例如，Java编译器认为下面的语句序列是错误的：

~~~Java
int vacationDays;
System.out.println(vacationDays); //ERROR--variable not initialized
~~~

想要对一个已经声明过的变量进行赋值，就需要将变量名放在等号（=）左侧，再把一个适当取值的Java表达式放在等号右侧。

~~~java
int vacationDays;
vacationDays = 12;
~~~

也可以将变量的声明和初始化放在同一行中。例如：

~~~java
int vacationDays = 12;
~~~

在Java中，变量的声明尽可能地靠近变量第一次使用的地方，这是一种良好的程序编写风格。

> 注：从Java10开始，对于局部变量，如果可以从变量初始值推断出它的类型，就不再需要声明类型。只需要使用关键字var而无需指定类型：
>
> ~~~java
> var vacationDays = 12;//vacationDays is an int
> var greeting = "Hello"; //greeting is a String
> ~~~

### 常量

在Java中，利用关键字final指示常量。例如：

~~~java
public class Constants {
  public static void main(String[] args){
    final double CM_PER_INCH = 2.54;
    double paperWidth = 8.5;
    double paperHeight = 11;
    System.out.println("Paper size in centimeters: " + paperWidth * CM_PER_INCH + "by" + paperHeight * CM_PER_INCH);
  }
}
~~~

关键字final表示这个变量只能被赋值一次。一旦被赋值之后，就不能够再更改了。习惯上，常量名使用全大写。

**类常量**（class constant）可以在一个类的多个方法使用。使用关键字static final设置一个类常量：

~~~java
public class Constants2 {
  public static final double CM_PER_INCH = 2.54;//类常量
  public static void main(String[] args)
  {
    double paperWidth = 8.5;
    double paperHeight = 11;
    System.out.println("Paper size in Centimeters:" + paperWidth * CM_PER_INCH + "by" + paperHeight * CM_PER_INCH);
  }
}
~~~

类常量的定义位于main方法的外部。因此，同一个类的其他方法中也可以使用这个常量。

### 枚举类型

枚举类型包括有限个命名的值。例如：

~~~java
enum Size { SMALL,MEDIUM,LARGE,EXTRA_LARGE };
~~~

声明这种类型变量：

~~~java
Size s = Size.MEDIUM;
~~~

Size类型的变量只能储存这个类型声明中给定的某个枚举值，或者特殊值null；

## 运算符

运算符用于连接值。Java提供了一组丰富的算数和逻辑运算符以及数学函数。

### 算数运算符

在Java中，使用算数运算符 +、-、*、/表示加、减、乘、除运算.当参与/运算的两个操作数都是整数时，表示整数除法：否则，表示浮点除法。整数的求余操作（有时候称为取模）用%表示。例如，15/2等于7，15%2等于1，15.0/2等于7.5。

需要注意，整数被除0会产生一个异常，而浮点数被0除将会得到无穷大或NaN的结果。

### 数学函数与常量

在Math类中，包含了各种各样的数学函数。

想要计算一个数值的平方根，可以使用sqrt方法：

~~~java
double x = 4;
double y = Math.sqrt(x);
System.out.println(y);  //prints 2.0
~~~

> 注：println方法处理System.out对象。Math类中的sqrt方法并不处理任何对象，这种方法被称为**静态**方法。

在Java中，没有幂运算，因此需要借助于Math类的pow方法。以下语句：

~~~JAVA
double y = Math.pow(x,a);
~~~

将y的值设置为x的a次幂（xᵃ）。pow方法有两个double类型的参数，其返回结果也为double类型。

Math类提供了一些常用的三角函数：

* Math.sin
* Math.cos
* Math.tan
* Math.atan
* Math.atan2

还有指数函数以及它的反函数-自然对数以及以10为底的对数：

* Math.exp
* Math.log
* Math.log10

最后，Java还提供了两个用于表示Π和e常量的最接近的近似值：

* Math.PI
* Math.E

### 数值类型之间的转换

我们经常需要将一种数值类型转换为另一种数值类型。

![image-20220922151739808](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220922151739808.png)

实线箭头表示无信息丢失的转换，虚线箭头，表示可能有精度损失的转换。

~~~java
int n = 123456789;
float f = n; //f is 1.23456792E8
~~~

### 强制类型转换

有时候可能损失信息的转换通过强制类型转换（cast）来完成。

强制类型转换的语法格式是在圆括号中给出想要转换的目标类型，后面紧跟待转换的变量名。例如：

~~~java
double x = 9.997;
int nx = (int)x; //nx is 9
~~~

这样，变量nx的值为9，因为强制类型转换通过截断小数部分将浮点值转换为整型。

如果想对浮点数进行舍入运算，以便获得到最接近的整数，那就需要用`Math.round`方法：

~~~java
double x = 9.997;
int nx = (int)Math.round(x); //nx is 10
~~~

当调用round的时候，仍需要使用强制类型转换（int）。其原因是round方法返回的结果为long类型，由于存在信息丢失的可能性，所以只有通过使用显式的强制类型转换才能够将long类型转换成int类型。

### 综合赋值和运算符

可以在赋值中使用二元运算符，这是一种很方便的简写形式。例如：

~~~java
x += 4;
~~~

等价于：

~~~java
x = x + 4;
~~~

 一般来说，要把运算符放在=号左边，如*=或%=.

> 注：如果运算符得到一个值，其类型与左侧操作数的类型不同，就会发生强制类型转换。例如，如果x是一个int，则以下语句
>
> ~~~java
> x += 3.5;
> ~~~
>
> 是合法的，将把x设置为(int)(x+3.5)。

### 自增与自减运算符

当然，程序员都知道加1、减1是数值变量最常见的操作。在Java中，借鉴了C和C++中的做法，也提供了自增、自减运算符：n++将变量n的当前值加1，n--则将n的值减1.例如：

~~~java
int n = 12;
n++;
~~~

将n的值改为13。由于这些运算符改变的是变量的值，所以它们不能应用于数值本身。例如，4++就不是一个合法的语句。

实际上，这些运算符有两种形式；除了上面的”后缀“形式，还有一种”前缀“形式：++n。后缀和前缀形式都会使变量值加1或减1。

前缀形式会先完成加1；而后缀形式会使用变量原来的值。

~~~java
int m = 7;
int n = 7;
int a = 2 * ++m; //now a is 16,m is 8
int b = 2 * m++; //new b is 14,m is 8
~~~

建议不要在表达式中使用++，因为这样的代码很容易让人困惑，而且会带来烦人的bug。

### 关系和boolean运算符

Java包含丰富的关系运算符。要检测相等性，可以使用两个等号 `==`。例如，`3 == 7`的值为false。

另外可以使用`!=`检测不相等。例如，`3 != 7`的值为true。

最后，还有经常使用的`<`、`>`、`<=`和`>=`运算符。

Java沿用了C++的做法，使用`&&`表示逻辑"与"运算符，使用`||`表示逻辑"或"运算符。从`!=`运算符可以想到，感叹号`!`就是逻辑非运算符。`&&`和`||`运算符是按照"短路"方式来求值的：如果第一个操作数已经能够确定表达式的值，第二个操作数就不必计算了。如果用`&&`运算符合并两个表达式，

~~~java
expression1 && expression2 //false
~~~

而且已经计算得到第一个表达式的真值为false，那么结果就不可能为true。因此，第二个表达式就不必计算了。可以利用这一点来避免错误。例如，在下面的表达式中：

~~~java
x != 0 && 1 / x > x + y //no division by 0
~~~

如果x等于0，那么第二部分就不会计算。因此，如果x为0，也就不会计算1/x，除以0的错误就不会出现。

类似地，如果第一个表达式为true，expression1 || expressopn2的值就自动为 true，而无需计算第二个表达式。

最后一点，Java支持三元操作符`?:`，这个操作符有时很有用。如果条件为true,下面的表达式

~~~java
condition ? expression1 : expression2
~~~

就为第一个表达式的值，否则计算为第二个表达式的值，例如，

~~~java
x < y ? x : y
~~~

会返回x和y中比较小的一个。

### 位运算符

处理整型类型时，可以直接对组成整数的各个位完成操作。这意味着可以使用掩码技术得到整数中的各个位，位运算符包括：

~~~java
&("and") |("or") ^("xor") ~("not")
~~~

这些运算符按位模式处理。例如，如果n是一个整数变量，而且用二进制表示的n从右边数第4位为1，则：

~~~java
int fourthBitFromRight = (n & 0b1000) /0b1000;
~~~

会返回1，否则返回0，利用&结合使用适当的2的幂，可以把其他位掩掉，而只留下其中的某一位。

另外，还有`>>`和`<<`运算符可以将位模式左移或右移。需要建立位模式来完成掩码时，这两个运算符会很方便：

~~~java
int fourthBitFromRight = (n & (1 <<3)) >> 3;
~~~

最后，>>>运算符会用0填充高位，这与>>不同，它会用符号位填充高位。不存在<<<运算符。

> 警告：位移运算符的右操作数要完成模32的运算（除非左操作数时long类型，在这种情况下需要对右操作数模64）。例如,1<<35的值等同于1<<3或8。

### 括号与运算符级别

![image-20220923093347065](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220923093347065.png)

## 字符串

从概念上讲，Java字符串就是Unicode字符序列。例如，字符串”Java\u2122“由5Unicode字符J、a、v、a和™组成。Java没有内置的字符串类型。而是在标准Java类库提供了一个预定义类，很自然地叫做String。每个用双引号括起来的字符串都是String类一个实例：

~~~java
String e = ""; // an empty string
String greeting = "Hello";
~~~

### 子串

String类的substring方法可以从一个较大的字符串提取出一个子串。例如：

~~~java
String greeting = "Hello";
String s = greeting.substring(0,3); 
~~~

创建一个由字符”Hel“组成的字符串。

> 注：类似于C和C++，Java字符串中的代码单元和代码点从0开始计数。

### 拼接

与绝大多数程序设计语言一样，Java语言允许使用+号连接（拼接）两个字符串。

~~~java
String expletive = "Expletive";
String PG13 = "deleted";
String message = expletive + PG13; //"Expletivedeleted"
~~~

当将一个字符串与一个非字符串的值进行拼接时，后者会转换成字符串。例如：

~~~java
int age = 13;
String rating = "PG" + age; //"PG13"
~~~

如果需要把多个字符串放在一起，用一个界定符分割，可以使用静态join方法：

~~~java
String all = String.join("-", "This", "is", "a", "String");
	//message returned is: "This-is-a-String"
~~~

在Java 11中，还提供了一个repeat方法：

~~~java
String repeated = "Java".repeat(3); //repeated is ”JavaJavaJava“
~~~

### 不可变字符串

String类没有提供修改字符串中某个字符的方法。如果希望将greeting的内容修改为”Hello“，可以提取想要保留的字串，再与希望替换的字符拼接：

~~~java
String greeting = "Help!"
greeting = greeting.substrung(0,3) + "lo"; //greeting is Hello
~~~

由于不能修改Java字符串中的单个字符。所以在Java文档中将String类对象称为是不可变的（immutable），字符串”Hello“永远包含字符H、e、l、l和o代码单元序列。虽然不能修改这些值，不过可以修改字符串变量greeting，让它引用另外一个字符串。

这样做是否会降低运行效率呢？看起来好像修改一个代码单元要比从头创建一个新字符串更加简洁。答案是：也对，也不对。的确，通过拼接”Hel“和”lo“来创建一个新的字符串的效率确实不高。但是，不可变字符串却有一个优点：编译器还可以让字符串共享。

### 检测字符串是否相等

可以使用equals方法检测两个字符串是否相等。对于表达式：

~~~java
s.equals(t)
~~~

如果字符串s与字符串t相等，则返回true；否则，返回false。需要注意的是，s与t可以是字符串变量，也可以是字符串字面量。例如，以下表达式是合法的：

~~~java
"Hello".equalsIgnoreCase("Hello")
~~~

一定不要使用==运算符检测两个字符串是否相等！这个运算符只能够确定两个字符串是否存放在同一个位置上。当然，如果字符串在同一个位置上，它们必然相等。但是，完全由可能将内容相同的多个字符串副本放置在不同的位置上。

~~~java
String greeting = "Hello"; //initialize greeting to a string
if (greeting == "Hello")...
    //probably true
if (greeting.substring(0,3) == "Hel")...
    //probably false
~~~

如果虚拟机始终将相同的字符串共享，就可以使用==运算符检测是否相等。但实际上只有字符串字面量是共享的，而+或substring等操作得到的字符串并不共享。因此，千万不要使用==运算符测试字符串的相等性。