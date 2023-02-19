---
title: C#高级
date: 2022-02-19 06:04:14.0
updated: 2022-02-19 06:04:14.0
categories: 
- C#/.NET
tags: 
- c#
---

## 封装

把一个，或者多个项目，封闭在一个物理，或者逻辑的包中。

C#封装 ，可以设置访问权限，通过访问修饰符来实现。

访问修饰符，定义一个类成员的范围和可见性。

C#支持的访问修饰符：

* public : 所有对象都可以访问
* private ：对象本身在内部可以访问
* protected : 这类，及其子类可以访问。
* internal : 同一程序集的对象可以访问。
* protected internal : 当前程序集，或派生自包括类的类型。

![image-20220625100647126](C:\Users\33225\AppData\Roaming\Typora\typora-user-images\image-20220625100647126.png)

## 结构体（Struct）

在 C# 中，结构体是值类型数据结构。它使得一个单一变量可以存储各种数据类型的相关数据。**struct** 关键字用于创建结构体。

```c#
using System;
using System.Text;

struct Books
{
    public string title;
    public string author;
    public string subject;
    public int book_id;
};

public class testStructure
{
    public static void Main(string[] args)
    {
      Books Book1;        /* 声明 Book1，类型为 Books */
      Books Book2;        /* 声明 Book2，类型为 Books */
      /* book 1 详述 */
      Book1.title = "C Programming";
      Book1.author = "Nuha Ali";
      Book1.subject = "C Programming Tutorial";
      Book1.book_id = 6495407;

      /* book 2 详述 */
      Book2.title = "Telecom Billing";
      Book2.author = "Zara Ali";
      Book2.subject =  "Telecom Billing Tutorial";
      Book2.book_id = 6495700;

      /* 打印 Book1 信息 */
      Console.WriteLine("Book 1 title : {0}", Book1.title); //{0}是占位符 用于格式化输出字符串
      Console.WriteLine("Book 1 author : {0}", Book1.author);
      Console.WriteLine("Book 1 subject : {0}", Book1.subject);
      Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);

      /* 打印 Book2 信息 */
      Console.WriteLine("Book 2 title : {0}", Book2.title);
      Console.WriteLine("Book 2 author : {0}", Book2.author);
      Console.WriteLine("Book 2 subject : {0}", Book2.subject);
      Console.WriteLine("Book 2 book_id : {0}", Book2.book_id);      

      Console.ReadKey();
    }
}
```



**结构和类的区别：**

- 1、结构是值类型，它在栈中分配空间；而类是引用类型，它在堆中分配空间，栈中保存的只是引用。
- 2、结构类型直接存储成员数据，让其他类的数据位于堆中，位于栈中的变量保存的是指向堆中数据对象的引用。

C# 中的简单类型，如int、double、bool等都是结构类型。如果需要的话，甚至可以使用结构类型结合运算符运算重载，再为 C# 语言创建出一种新的值类型来。

由于结构是值类型，并且直接存储数据，因此在一个对象的主要成员为数据且数据量不大的情况下，使用结构会带来更好的性能。

因为结构是值类型，因此在为结构分配内存，或者当结构超出了作用域被删除时，性能会非常好，因为他们将内联或者保存在堆栈中。当把一个结构类型的变量赋值给另一个结构时，对性能的影响取决于结构的大小，如果结构的数据成员非常多而且复杂，就会造成损失，接下来使用一段代码来说明这个问题。

结构和类的适用场合分析：

-  1、当堆栈的空间很有限，且有大量的逻辑对象时，创建类要比创建结构好一些；
-  2、对于点、矩形和颜色这样的轻量对象，假如要声明一个含有许多个颜色对象的数组，则CLR需要为每个对象分配内存，在这种情况下，使用结构的成本较低；
- 3、在表现抽象和多级别的对象层次时，类是最好的选择，因为结构不支持继承。
- 4、大多数情况下，目标类型只是含有一些数据，或者以数据为主。

## 枚举（Enum）

枚举是一组命名整型常量。枚举类型是使用 **enum** 关键字声明的。
C# 枚举是值类型。换句话说，枚举包含自己的值，且不能继承或传递继承。

```c#
using System;

public class EnumTest
{
    enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

    static void Main()
    {
        int x = (int)Day.Sun;
        int y = (int)Day.Fri;
        Console.WriteLine("Sun = {0}", x);
        Console.WriteLine("Fri = {0}", y);
    }
}
```

## 继承

继承允许我们根据一个类来定义另一个类，这使得创建和维护应用变得更容易，利于重用代码和节省开发时间。

已有的类被称为 基类 ，这个新的类被称为 派生类。

继承的思想实现了 属于 （IS-A）关系。例如，哺乳动物属于 （IS-A） 动物，狗属于 （IS-A）哺乳动物，因此狗 属于 （IS-A）动物。

### 一、基类和派生类

一个类可以派生自多个类或接口。

语法：

```c#
<访问修饰符> class <基类/父类>
{
    ...
}
class <派生类/子类> ; <基类/父类>
{
    ...
```

### 二、基类的初始化

派生类继承了基类成员变量和成员方法，因此父亲对象应在子类对象创建之前创建。

可以在 成员初始化列表 中进行父类的初始化。99

### 三、C#多重继承

多重继承指的是一个类别可以同时从多于一个父类继承行为与特征的功能。与单一继承相对，单一继承指一个类别只可以继承自一个父类。C# 不支持多重继承。但是可以使用接口实现多重继承。

## C# 多态性

**多态：**一个接口多个功能。

**静态多态性：**编译时发生函数响应（调用）；

**动态多态性：**运行时发生函数响应。

**静态绑定（早期绑定）：**编译时函数和对象的连接机制。 两种技术实现静态多态性：函数重载/运算符重载。

**函数重载：**在同一范围内对相同函数名有多个定义，可以是参数类型或参数个数的不同，但不许只有返回值类型不同。

**运算符重载：**

关键字 abstract 声明抽象类：用于接口部分类的实现（派生类继承抽象类时，实现完成）。抽象类包含抽象方法，抽象方法可被派生类实现。

抽象类规则：

-  1.不能创建抽象类的实例
- 2.不能在抽象类外定义抽象方法
- 3.不能把抽象类声明为sealed（类前带关键字sealed代表该类是密封类，不能被继承）

关键字virtual声明虚方法:用于方法在继承类中的实现（在不同的继承类中有不同的实现）。

抽象类和虚方法共同实现动态多态性。

注：继承类中的重写虚函数需要声明关键字 override，在方法参数传入中写（类名 形参名）例如 public void CallArea(Shape sh)，意思是传入一个 shape 类型的类。

