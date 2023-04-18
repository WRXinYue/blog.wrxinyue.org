---
title: Java继承
date: 2022-11-10 19:59:51.163
updated: 2023-04-18 15:09:36
categories: 
- WEBbackend
tags: 
- java
---

## Introduction

继承（inheritance）。继承的基本思想是，可以基于已有的类创建新的类。继承已存在的类就是复用（继承）这些类的方法，而且可以增加一些新的方法和字段，是新类能够适应新的情况。

## Class、superclass and subclass

### 定义subclass

继承Employee类来定义Manager类，这里使用关键字`extends`表示继承。

~~~java
public class Manager extends Employee
{
    added methods and fields
}
~~~

>C++/C# 注：Java与C++定义继承的方式十分相似。Java用关键字替代了C++和C#中的冒号( : )。在Java中，所有继承都是公开继承。 

关键字`extends`表明正在构造的新类派生于一个存在的类。

已存在的类称为：**超类(superclass)**、**基类(base class)**或**父类(parent class)**;

新类称为：**子类(subclass)**、**派生类(derived class)**或**孩子类(child class)**

>注：前缀**超(super)**和**子(sub)**来源于计算机科学与数学理论中集合语言的术语。所有员工组成的集合包含所有经理组成的集合。即，员工集合是经理集合的超级，也可以说，经理集合是员工集合的子集。

在`Manager`类中增加一个用于存储奖金信息的字段，以及一个用于设置这个字段的新方法：

~~~java
public class Manager extends Employee
{
    private double bonus;
    ...
    public void setBonus(double bonus)
    {
        this.bonus = bonus;
    }
}
~~~

### override方法

超类中的有些方法对子类Manager不一定使用。具体来说，`Manager`类中`getSalary`方法应该返回薪水和奖金的总和。为此需要提供一个新的方法来**覆盖(override)**超类中的这个方法：

~~~java
public class Manager extends Employee
{
    ...
    public double getSalary()
    {
        double baseSalary = super.getSalary();
        return baseSalary + bonus;
    }
    ...
}
~~~

在这里，我们希望调用超类`Employee`中的`getSalary`方法，而不是当前类的这个方法。为此，可以使用特殊的关键字`super`解决这个问题:

> 注：有些人认为super与this引用是类似的概念，实际上，这样比较并不太恰当。这是因为super不是一个对象的引用，例如，不能将值super赋给另一个对象变量，它只是一个**指示编译器调用超类方法**的特殊关键字。

正像前面所看到的那样，在子类可以增加字段、增加方法或覆盖超类的方法，不过，继承绝不会删除任何字段或方法。

>C++注：在Java中使用关键字**super**调用超类的方法，而在C++中则采用超类名加`::`操作符的形式。例如，Manager类的`getSalary`方法要调用`Employee::getSalary`而不是`super.getSalarty`。

### subclass构造器

~~~java
public Manager(String name,double salary,int year,int month,int day)
{
    super(name,salary,year,month,day);
    bonus = 0;
}
~~~

这里的关键字super具有不同的含义。语句`super(name,salary,year,month,day);`是”调用超类**Employee**中带有name、salary、year、month和day参数的构造器“的简写形式。

由于**Manager**类的构造器不能访问**Employee**类的私有字段，所以必须通过一个构造器来初始化这些私有字段。可以利用特殊的`super`语法调用这个构造器。使用`super`调用构造器的语法句必须是子类构造器的第一条语句。

如果子类的构造器没有显式地调用超类的构造器，将自动地调用超类的无参数构造器。如果超类没有无参数的构造器，并且在子类的构造器中又没有显式地调用超类的其他构造器，Java编译器就会报告一个错误。

> 回想一下，关键字this有两个含义：一是指示隐式参数的引用，二是调用该类的其他构造器。
>
> 类似地，super关键字也有两个含义：一是调用超类的方法，二是调用超类的构造器。在调用构造器的时候，this和super这两个关键字紧密相关。调用构造器的语句只能作为另一个构造器的第一条语句出现。构造器参数可以传递给当前类(this)的另一个构造器，也可以传递给超类(super)的构造器。

创建一个新经理，并设置他的奖金：

~~~java
Manager boss = new Manager("Carl Cracker",80000,1987,12,15);
boss.setBonus(5000);
~~~

下面定义一个包含3个员工的数组：

~~~java
var staff = new Employee[3];
~~~

在数组中混合填入经理和员工：

~~~java
staff[0] = boss;
staff[1] = new Employee("Harry Hacker",50000,1989,10,1);
staff[2] = new Employee("Tony Tester",40000,1990,3,15);
~~~

输出每个人的薪水：

~~~java
for (Employee e : staff)
{
    System.out.println(e.getName() + " " + e.getSalary());
}
//输出：
//	Carl Cracker 85000.0
//	Harry Hacker 50000.0
//	Tommy Tester 40000.0
~~~

一个对象变量（例如，变量e）可以指示多种实际类型的现象称为**多态(polymorphism)**。在运行时能够自动地选择适当的方法，称为**动态绑定(dynamic binding)**。

> C++注：在C++中，如果希望实现动态绑定，需要将成员函数声明为**virtual**。在Java中，动态绑定是默认的行为。如果**不**希望让一个方法是虚拟的，可以将它标记为**final**

~~~java
/* File name: ManagerTest.java */
public class ManagerTest
{
    public static void main(String[] args)
    {
        // construct a Manager object
        var boss = new Manager("Carl Cracker",80000,1987,12,15);
        boss.setBonus(5000);
        
        var staff = new Employee[3];
        
        // fill the staff array with Manager and Employee objects
        
        staff[0] = boss;
        staff[1] = new Employee("Harry Hacker",50000,1989,10,1);
        staff[2] = new Employee("Tommy Tester",40000,1990,3,15);
        
        // print out information about all Employee objects
        for (Employee e : staff)
            System.out.println("name=" + e.getName() + ",salary=" + e.getSalary());
    }
}
~~~

~~~java
/* File name: Employee.java */
public class Employee
{
    private String name;
    private double salary;
    private LocalDate hireDay;
    
    public Employee(String name,double salary,int year,int month,int day)
    {
        this.name = name;
        this.salary = salary;
        hireDay = LocalDate.of(year,month,day);
    }
    
    public String getName()
    {
        return name;
    }
    
    public double getSalary()
    {
        return salary;
    }
    
    public LocalDate getHireDay()
    {
        return hireDay;
    }
    
    public void raiseSalary(double byPercent)
    {
        double raise = salary * byPercent / 100;
        salary += raise;
    }
}
~~~

~~~java
public class Manager extends Employee
{
    private double bonus;
    
    public Manager(String name,double salary,int year,int month,int day)
    {
        super(name,salary,year,month,day);
        bonus = 0;
    }
    
    public double getSalary()
    {
        double baseSalary = super.getSalary();
        return baseSalary + bonus;
    }
    
    public void setBonus(double b)
    {
        bonus = b;
    }
}
~~~

### 多态

有一个简单规则可以用来判断是否应该将数据设计为继承关系，这就是**is-a**规则，它指出子类的每个对象也是超类的对象

。例如，每个经理都是员工，因此，将Manager类设计为Employee类的子类是有道理的。

**is-a**规则的另一种表述是替换原则（substitution principle）。它指出程序中出现超类对象任何地方都可以使用子类对象替换。

例如，可以将子类的对象赋给超类变量：

~~~java
Employee e;
e = new Employee(...);	//Employee object expected
e = new Manager(...);	//OK,Manager can be used well
~~~

在Java程序设计语言中，对象变量是多态的（polymorphic）。一个Employee类型的变量即可以引用一个Employee类型的变量，也可以引用Employee类的任何一个子类的对象（例如，Manager、Executive、Secretary等）。

~~~java
Manager boss = new Manager(...);
Employee[] staff = new Employee[3];
staff[0] = boss;
~~~

在这个例子中，变量staff[0]与boss引用同一个对象。但编译器只将staff[0]看成是一个Employee对象。

~~~java
boss.setBonus(5000);		// OK
staff[0].setBonus(5000);	//ERROR
Manager m = staff[i];		//ERROR
~~~

### 理解方法调用

假设调用：

~~~java
x.f(atgs)
~~~

隐式参数x声明为类c的一个对象：

1. 编译器查看对象的声明类型和方法名。需要注意的是：有可能存在多个名字为f但参数类型不一样的方法。例如，可能存在方法f(int)和方法f(String)。编译器将会一一列举C类中所有名为f但参数类型不一样的方法。例如，可能存在方法f(int)和方法f(String)。

2. 接下来，编译器要确定方法调用中提供的参数类型。如果在所有名为f的方法中存在一个与所类型提供参数类型完全匹配的方法，就选择这个方法。这个过程称为重载解析(overloading resolution)

3. 如果是private方法、static方法、final方法 或者构造器，那么编译器将可以准确地知道应该调用哪个方法。这称为静态绑定(static binding)

4. 程序运行并且采用动态绑定调用方法时，虚拟机必须调用与x所引用对象的实际类型对应的那个方法。假设x的实际类型是D，它是C类的子类。如果D类定义了方法f(String), 就会调用这个方法；否则，将在D类的超类中寻找f(String)，以此类推。

   如果调用的是super.f(param)，那么编译器将对隐式参数超类的方法表进行搜索。

### 阻止继承：final 类和方法

有时候，我们可能希望阻止人们利用某个类定义子类。不允许扩展的类被称为final类。如果在定义类的时候使用了**final修饰符**就表明这个类是**final类**。例如，假设希望阻止人们派生Executive类的子类，就可以在声明这个类的时候使用final修饰符：

~~~java
public final class Executive extends Manager
{
    ...
}
~~~

类中的某个特定方法也可以被声明为final。如果这样做，子类就不能覆盖这个方法（final 类中的所有方法自动地称为final方法）。例如：

~~~java
public class Employee
{
    ...
    public final String getName()
    {
        return name;
    }
    ...
}
~~~

> 注：对于final字段来说，构造对象之后就不允许改变它们的值了。不过，如果将一个类声明为final，只有其中的方法自动地称为final，而不包括字段。

### 强制类型转换

Java程序设计语言为强制类型转换提供了一种特殊的表示法。例如：

~~~java
double x = 3.405;
int nx = (int) x;
~~~

有时候也可能需要将某个类的对象引用转换成另一个类的对象引用。语法和数值表达式的强制类型转换类似，例如：

~~~java
Manager boss = (Manager) staff[0];
~~~

### 抽象类

![image-20221114160122027](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221114160122027.png)

~~~java
public abstract String getDescroption();
	//no implementation required
~~~

为了提高程序的清晰度，包含一个或多个抽象方法的类本身必须被声明为抽象的。

~~~java
public abstract class Person
{
    ...
    public abstract String getDescription();
}
~~~

除了抽象方法之外，抽象类还可以包含字段和具体方法。例如，Person类还保存着一个人的姓名，另外有一个返回姓名的具体方法。

~~~java
public abstract class Person
{
    private String name;
    
    public Person(String name)
    {
        this.name = name;
    }
    
    public abstract String getDescription();
    
    public String getName()
    {
        return name;
    }
}
~~~

抽象方法充当着占位方法的角色，它们在子类中具体实现。扩展抽象类可以有两种选择。

一种是在子类中保留抽象类中的部分或所有抽象方法仍未定义，这样就必须将子类也标记为抽象类；

另一种做法是定义全部方法，这样一来，子类就不是抽象的了。

例如，通过扩展抽象Person类，并实现getDescription方法来定义Student类。由于在Student类中不再含有抽象方法，所以不需要将这个类声明为抽象类。

**抽象类不能实例化**

可以定义一个抽象类的对象变量，但是这样一个变量只能引用非抽象子类的对象。例如：

~~~java
Person p = new Student("Vince Vu","Economics");
~~~

这里的p是一个抽象类型Person的变量，它引用了一个非抽象子类Student的实例。

> `C++`注：在`C++`中，有一种抽象方法称为**纯虚函数**(pure virtual function)，要在末尾用 = 0 标记，例如：
>
> ~~~java
> class Person //C++
> {
>  public:
>  	virtual string getDescription() = 0;
>  	...
> };
> // 如果至少有一个纯虚函数，这个C++类就是抽象类。在C++中，没有提供用于表示抽象类的特殊关键字。
> ~~~
>
> 如果至少有一个纯虚构函数，这个C++类就是抽象类。C++中，没有提供用于表示抽象类的特殊关键字。

下面定义一个扩展抽象类Person的具体子类Student：

~~~java
public class Student extends Person
{
    private String major;
    
    public Student(String name,String major)
    {
        super(name);
        this.major = major;
    }
    
    public String getDescription()
    {
        return "a student majoring in " + major;
    }
}
~~~

Student 类定义了 getDescription 方法，在 Student 类中的全部方法都是具体的，这个类不再是抽象类。



~~~java
public class PersonTest
{
    public static void main(String[] args)
    {
        var people = new Person[2];
        
        // fill the people array with Student and Employee objects
        people[0] = new Employee("Harry Hacker",5000,1989,10,1);
        people[1] = new Student("Maria Morris","computer science");
        
        // print out names and descriptions of all Person objects
        for (Person p : people)
            System.out.println(p.getName() + ", " + p.getDescription)
    }
}
~~~

~~~java
public abstract class Person
{
    public abstract String getDescription();
    private String name;
    
    public Person(String name)
    {
        this.name = name;
    }
    
    public String getName()
    {
        return name;
    }
}
~~~

~~~java
public class Employee extends Person
{
    private double salary;
    private LocalDate hireDay;
    
    public Employee(String name,double salary,int year,int month,int day)
    {
        super(name);
        this.salary = salary;
        hireDay = LocalDate.of(year,month,day);
    }
    
    public double getSalary()
    {
        return salary;
    }
    
    public LocalDate getHireDay()
    {
        return hireDay;
    }
    
    public String getDescripting()
    {
        return String format("an employee with a salary of $%.2f",salary)
    }
    
    public void raiseSalary(double byPercent)
    {
        double raise = salary * byPercent / 100;
        salart += raise;
    }
}
~~~

~~~java
public class Student extends Person
{
    private String major;
    
    /**
     * @param name the student's name
     * @param major the student's major
     */
    public Student(String name,String major)
    {
        // pass name to superclass constructor
        super(name);
        this.major = major;
    }
    
    public String getDescription()
    {
        return "a student majoring in " + major;
    }
}
~~~

### 受保护访问

* 仅对本类可见 —— private
* 对外部完全可见 —— public
* 对本包和所有子类可见 —— protected
* 对本包可见 —— 默认，不需要修饰符

>  `C++`注：Java中的受保护部分对所有子类及同一个包中的所有其他类都可见。这与`C++`中的保护机制稍有不同，Java中的protected概念要比`C++`中的安全性差。

## Object：所有类的超类

Object类是Java中所有类的始祖，在Java中每个类都扩展了Object。但是并不需要这样写：

~~~java
public class Employee extends Object
~~~

如果没有明确地指出超类，Object就被认为是这个类的超类。

### Object类型的变量

可以使用Object类型的变量引用任何类型的对象：

~~~java
Object obj = new Employee("Harry Hacker",35000);
~~~

当然，Object类型的变量只能用于作为各种值的一个泛型容器。想要对其内容进行具体的操作，还需要清除对象的原始类型，并进行相应的强制类型转换：

~~~java
Employee e = (Employee) obj;
~~~

在Java中，只有基本类型（primitive）不是对象，例如，数值、字符和布尔类型的值都不是对象。

所有的数组类型，不管是对象数组还是基本类型的数组都扩展了Object类。

~~~Java
Employee[] staff = new Employee[10];
obj = staff;	//OK
obj = new int[10];	// OK
~~~

> `C++`注：在`C++`中没有所有类的根类，不过，每个指针都可以转换成`void*`指针。

### equals方法

Object类中的equals方法用于检测一个对象是否等于另外一个对象

### 相等测试与继承

如果隐式和显示的参数不属于同一个类equals方法就返沪false。

但是许多程序员却喜欢使用instanceof进行检测：

~~~java
if (!(otherObject instanceof Employee)) return false;
~~~

这样就允许otherObject属于一个子类。但是这种方法可能会招致一些麻烦。正因为这些麻烦，所以建议不要采用这种处理方式。Java语言规范要求equals方法具有下面的特性：

1. 自反性：对于任何非空引用x，x.equals(x) 应该返回true
2. 对称性：对于任何引用x和y，当且仅当y.equals(x) 返回 true时，x.equals(y) 返回 true
3. 传递性：对于任何引用x、y和z，如果x.equals(y)返回true，y.equals(z) 返回 true,x.equals(z) 也应该返回true 
4. 一致性：如果x和y引用的对象么有发生变化，反复调用x.equals(y)应该返回同样的结果



**equals 方法的建议：**

1. 显式参数命名为otherObject，稍后我们需要将它强制转换成另一个名为other的变量

2. 检测this与otherObject是否想等：

   ~~~java
   if (this == otherObject) return true;
   ~~~

3. 检测otherObject是否为null：

   ~~~java
   if (otherObject == null) return false;
   ~~~

4. 比较this与otherObject的类。如果equals的语句可以在子类中改变，就使用**getClass**检测：

   ~~~java
   if (getClass() != otherObject.getClass()) return false;
   ~~~

5. 将otherObject强制转换为对应类型的变量：

   ~~~java
   ClassName other = (ClassName) otherObject
   ~~~

6. 使用 == 比较基本类型字段，使用Objects，equals比较对象字段。如果所有的字段都匹配，就返回true；否则返回false

   ~~~java
   return field1 == ohter.field1
       && Objects.equals(field2,other.field2)
       && ...;
   ~~~

   如果在子类中重新定义equals，就要在其中包含一个super.equals(other)调用。

> 对于数组类型的字段，可以使用静态Arrays.equals方法检测相应的数组元素是否相等

### hashCode方法

散列码（hash code）是由对象导出的一个整型值。散列码是没有规律的。

如果x和y是两个不同的对象，x.hashCode() 与y.hashCode() 基本上不会相同。

String类使用以下算法计算散列码：

~~~java
int hash = 0;
for (int i = 0;i < length();i++)
    hash = 31 * hash + charAt(i);
~~~

由于hashCode方法定义在Object类中，因此每个对象都有默认的散列码，其值由对象的存储地址得出。

~~~java
var s = "Ok";
var sb = new StringBuilder(s);
System.out.println(s.hashCode() + " " + sb.hashCode()); //s 2556  sb 20526976
var t = = new String("Ok");
var tb = new StringBuilder(t);
System.out.println(t.hashCode() + " " + tb.hashCode()); //t 2556  tb 20527144
~~~

其中字符串s与t的散列码是由内容导出的。在StringBuilder类中没有定义hashCode方法，而Object类的默认hashCode方法会从对象的地址得出散列码。

如果重新定义了equal方法，就必须为用户可能插入散列表的对象重新定义hashCode方法。

hashCode方法应该返回一个整数（也可以是负数）。要合理地组合实例字段的散列码，以便能够让不同对象产生的散列码分布更加均匀。

例如，下面是Employee类的hashCode方法：

~~~java
public class Employee
{
    public int hashCode()
    {
        return Objects.hash(name,salary,hireDay);
    }
}
~~~

equals与hashCode的定义必须相容：如果x.equals(y)返回true，那么x.hashCode()就必须与y.hashCode()返回相同的值。例如，如果定义Employee.equals比较员工的ID，那么hashCode方法就需要散列ID，而不是员工的姓名或存储地址。



* 返回一个散列码，由提供的所有对象的散列码组合而得到

  ~~~java
  static int hash(Object...objects)
  ~~~

* 如果a为null返回0，否则返回a.hashCode()

  ~~~java
  static int hashCode(Object a)
  ~~~

* 返回给定值的散列码。这里xxx是对应给定包装器类型的基本类型。

  ~~~java
  static int hasCode(xxx value)
  ~~~

* 计算数组a的散列码。组成这个数组的元素类型xxx可以是object、int、long、short、char、byte、boolean、float或double。

###  toString方法

在Object中还有一个重要的方法，就是toString方法，它会返回表示对象值的一个字符串。

下面是一个典型的例子。Point类的toString方法将返回下面这样的字符串：

~~~java
java.awt.Point[x=10,y=20]
~~~

绝大多数（但不是全部）的toString方法都遵循这样的格式：类的名字，随后是一对方括号括起来的字段值。下面是Employee类中的toString方法的实现：

~~~java
public String toString()
{
    return "Employee[name=" + name
        + ",salart=" + salary
        + ",hireDay=" + hireDay
        + "]";
}
~~~

还可以设计得更好一些。最好通过**getClass().getName()**获得类名的字符串，但是不要将类名硬编码写道toString方法中。

~~~java
public String toString()
{
    return getClass().getName()
        + "[name=" + name
        + ",salary=" + salary
        + ",hireDay=" + hireDay
        + "]";
}
~~~

这样toString方法也可以由子类调用。

当然，设计子类的程序员应该定义自己的toString方法，并加入子类的字段。如果超类使用了`getClass().getName()`,那么子类只需要调用`super.toString()`就可以了。例如：

~~~java
public class Manager extends Employee
{
    ...
    public String toString()
    {
        return super.toString()
            + "[bonus=" + bonus
            + "]";
    }
}
~~~

> 可以不写`x.toString()`,而写作`”“ + x`。这条语句将一个空串与x的字符串表示(也就是`x.toString()`)相连接。与toString不用的是，即使x是基本类型，这条语句照样能够执行。

如果x是一个任意对象，并调用

~~~java
System.out.println(x);
~~~

println方法就会简单地调用`x.toString()`，并打印输出得到的字符串。

Object类定义了toString方法，可以打印对象的类名和散列码。例如：

~~~java
System.out.println(System.our)
~~~

输出：`java.io.PrintStream@626b2d4a`

之所以得到这样的结果，是因为PrintStream类的实现者没有覆盖toString方法。

> 警告：令人烦恼的是，数组继承了object类的toString方法，更有甚者，数组类型将采用一种古老的格式打印。例如：
>
> ~~~java
> int[] luckyNumbers = {2,3,5,7,11,13};
> String s = "" + luckyNumber;
> ~~~
>
> 会生成字符串`[I@626b2d4a`(前缀[I表明是一个整型数组])。补救的方法是调用静态方法Arrays.toString。代码：
>
> ~~~java
> String s = Arrays.toString(luckyNumber);
> ~~~
>
> 将生成字符串`[2, 3, 5, 7, 11, 13]`.
>
> 想要打印多维数组(即，数组的数组)，则需要调用`Arrays.deepToString`方法。
>
> ![image-20221116195859507](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221116195859507.png)

toString方法是一种非常有用的调试工具。在标准类库中，许多类都定义了`toString`方法，以便用户能够获得一些有关对象状态的有用信息：

~~~java
System.out.println("Current position = " + position);
~~~

更好的解决方法是使用Logger类的一个对象并调用：

~~~java
Logger.global.info("Current position = " + position);
~~~

> 最好为自定义的每一个类都添加toString方法

如下的程序测试了Employee类和Manager类的equals、hashCode和toString方法

~~~java
/* File name: EqualsTest.java */
public class EqualsTest {
    
    public static void main(String[] args) {
        var alice1 = new Employee("Alice Adams", 75000, 1987, 12, 15);
        var alice2 = alice1;
        var alice3 = new Employee("Bob Brandson", 75000, 1987, 12, 15);
        var bob = new Employee("Bob Brandson", 50000, 1989, 10, 1);
        
        System.out.println("alice1 == alice2: " + (alice1 == alice2));
        System.out.println("alice1 == alice3: " + (alice1 == alice3));
        System.out.println("alice1.equals(alice3): " + alice1.equals(alice3));
        System.out.println("alice1.equals(bob): " + alice1.equals(bob));
        System.out.println("bob.toString(): " + bob);
        
        var carl = new Manager("Carl Cracker", 80000, 1987, 12, 15);
        var boss = new Manager("Carl Cracker", 80000, 1987, 12, 15);
        boss.setBonus(5000);
        System.out.println("boss.toString(): " + boss);
        System.out.println("carl.equals(boss): " + carl.equals(boss));
        System.out.println("alice1.hashCode(): " + alice1.hashCode());
        System.out.println("alice3.hashCode(): " + alice3.hashCode());
        System.out.println("bob.hashCode(): " + bob.hashCode());
        System.out.println("carl.hashCode(): " + carl.hashCode());
    }
}

~~~

~~~java
/* File name: Employee.java */
import java.time.LocalDate;
import java.util.Objects;

public class Employee {

    private String name;
    private double salary;
    private LocalDate hireDay;
    
    public Employee(String name,double salary,int year,int month,int day)
    {
        this.name = name;
        this.salary = salary;
        hireDay = LocalDate.of(year, month, day);
    }
    
    public String getName()
    {
        return name;
    }
    
    public double getSalary()
    {
        return salary;
    }
    
    public LocalDate getHireDay()
    {
        return hireDay;
    }
    
    public void raiseSalary(double byPercent)
    {
        double raise = salary * byPercent / 100;
        salary += raise;
    }
    
    public boolean equals(Object otherObject) {
        // a quick test to see if the objects are identical
        if(this == otherObject) return true;
        
        // must return false if the explicit parameter is null
        if(otherObject == null) return false;
        
        // if the classes don't match,they can't be equal
        if(getClass() != otherObject.getClass()) return false;
        
        // now we know otherObject is a non-null Employee
        var other = (Employee) otherObject;
        
        // text whether the fields have identical values
        return Objects.equals(name, other.name)
                && salary == other.salary && Objects.equals(hireDay, other.hireDay);
    }
    
    public int hashCode() {
        return Objects.hash(name,salary,hireDay);
    }
    
    public String toString() {
        return getClass().getName() + "[name=" + name + ",salary=" + salary + ",hireDay="
                + hireDay + "]";
    }
}
~~~

~~~java
/* File name: Manager.java */
public class Manager extends Employee {
    private double bonus;
    public Manager(String name,double salary,int year,int month,int day) {
        super(name,salary,year,month,day);
        bonus = 0;
    }
    
    public double getSalary() {
        double baseSalary = super.getSalary();
        return baseSalary + bonus;
    }
    
    public void setBonus(double b) {
        bonus = b;
    }
    
    public boolean equals(Object otheObject) {
        if (!super.equals(otheObject)) return false;
        var other = (Manager) otheObject;
        // super.equals checked that this and other belong to the same class
        return bonus == other.bonus;
    }
    
    public int hashCode()
    {
        return java.util.Objects.hash(super.hashCode(),bonus);
    }
    
    public String toString() {
        return super.toString() + "[bonus=" + bonus + "]";
    }
}
~~~

* `Class getClass()`

  返回包含对象信息的类对象。

* `boolean equals(Object otherObject)`

  比较两个对象是否相等，如果两个对象指向同一块存储地区，方法返回true：否则方法返回false。要在自定义的类中覆盖这个方法。

* `String toString()`

  返回表示该对象的字符串。要在自定义的类中覆盖这个方法。

* `String getName()`

  返回这个类的名字。

* `Class getSuperclass()`

  以Class对象的形式返回这个类的超类。

## 泛型数组列表

在许多程序设计语言，特别是在C/C++语言中，必须在编译时就确定整个数组的大小。

在Java中，情况就好多了。它允许在运行时确定数组的大小。

~~~java
int actualSize = ...;
var staff = new Employee[actualSize];
~~~

当然，这段代码并没有完全解决运行时动态更改数组的问题。一旦确定了数组的大小，就不能很容易地改变它了。在Java中，解决这个问题最简单的方法就是使用Java中的另外一个类，名为`ArrayList`。`ArrayList`类类似于数组，但在添加或删除元素时，它能够自动地调整数组容量，而不需要为此编写任何代码。

`ArrayList`是一个有**类型参数(type parameter)**的**泛型类(generic class)**。为了指定数组列表保存的元素对象的类型，需要用一对尖括号将类名括起来追加刀`ArrayList`后面，例如：

~~~java
ArrayList<Employee>
~~~

### 声明数组列表

声明和构造一个保存`Employee`对象的数组列表：

~~~java
ArrayList<Employee> staff = new ArrayList<Employee>();
~~~

在Java10中，最好使用`var`关键字以避免重复写类名：

~~~java
var staff = new ArrayList<Employee>();
~~~

如果没有使用`var`关键字，可以省去右边的类型参数：

~~~java
ArrayList<Employee> staff = new ArrayList<>();
~~~

这称为"菱形"语法，因为空尖括号`<>` 就像是一个菱形。可以结合`new`操作符使用菱形语法。检查器会检查新值要做什么。如果赋值给一个变量，或传递给某个方法，或者从某个方法返回，检查器会检查这个变量、参数或方法的泛型类型，然后将这个类型放在`<>`中。在这个例子中，`new ArrayList<>`将赋值给一个类型为`ArrayList<Employee>`的变量，所以泛型类型为`Employee`。

> 如果使用var声明ArrayList，就不要使用菱形语法：
>
> ~~~java
> var elements = new ArrayList<>();
> ~~~
>
> 会生成一个`ArrayList<Object>`

使用add方法可以将元素添加到数组列表中：

~~~java
staff.add(new Employee("Harry Hacker",...));
staff.add(new Employee("Tony Tester",...));
~~~

如果调用add而内部数组已经满了，数组列表会自动地创建一个更大的数组，并将所有的对象从较小的数组中拷贝到较大的数组中。

如果已经知道或能够估计出数组可能存值的元素数量，就可以在填充数组之前调用ensureCapacity方法：

~~~java
staff.ensureCapacity(100);
~~~

这个方法调用将分配一个包含100个对象的内部数组。这样一来，前100次add调用不会带来开销很大的重新分配空间。

另外，还可以把初始容量传递给`ArrayList`构造器：

~~~java
ArrayList<Employee> staff = new ArrayList<>(100);
~~~

size方法将返回数组列表中包含的实际元素个数，等价于数组a的a.length。例如：

~~~java
staff.size()
~~~

* `ArrayList<E>()`

  构造一个空数组列表。

* `ArrayList<E>(int initialCapacity)`

  用指定容量构造一个空数组列表。

* `boolean add(E obj)`

  在数组列表的末尾追加一个元素。永远返回true。

* `int size()`

  返回当前存储在数组列表中的元素个数。(当然，这个值永远不会大于数组列表的容量。)

* `void ensureCapacity(int capacity)`

  确保数组列表在不重新分类内部存储数组的情况下有足够的内容存储给定数量的元素。

* `void trimToSize()`

  将数组列表的存储容量削减到当前大小。

### 访问数组列表元素

数组列表自动扩展容量的便利增加了访问元素语法的复杂程度。其原因是`ArrayList`类并不是Java程序设计语言的一部分；它只是由某个人编写并在标准库中提供的一个实用工具类。

不能使用`[]`语法格式访问或改变数组的元素，而要使用`get`和`set`方法。

* `E set(int index,E obj)`

  将值obj放置在数组列表的指定索引位置，返回之前的内容。

* `E get(int index)`

  得到指定索引位置存储的值。

* `void add(int index,E obj)`

  后移元素从而将obj插入到指定索引位置。

* `E remove(int index)`

  删除指定索引位置的元素，并将后面的所有元素前移。返回所删除的元素。

  

### 对象包装器与自动装箱

有时，需要将int这样的基本类型转换为对象。所有的基本类型都有一个与之对应的类。例如，`Integer`类对应基本类型`int`。通常，这些类称为`包装器(wrapper)`。这些包装器类有显而易见的名字：**Integer**、**Long**、**Float**、**Double**、**Short**、**Byte**、**Character**、**Boolean**(前6个类派生于公共的超类**Number**)。

声明`Integer`对象的数组列表：

~~~java
var list = new ArrayList<Integer>();
~~~

* `int intValue()`

  将这个Integer对象的值作为int返回（覆盖Number类中intValue方法）

* `static String toString(int i)`

  返回一个新的String对象，表示指定数值i的十进制表示

* `static String toString(int i,int radix)`

  返回数值i基于radix参数指定进制的表示

* `static int parseInt(String s)`

* `static int parseInt(String s,int radix)`

  返回字符串s表示的整数，指定字符串必须表示一个十进制整数（第一种方法），或者采用radix参数指定的进制（第二种方法）

* `static Integer valueOf(String s)`

* `static Integer valueOf(String s,int radix)`

  返回一个新的Integer对象，用字符串s表示的整数初始化。指定字符串必须表示一个十进制整数（第一种方法），或者采用radix参数指定的进制（第二种方法）

* `Number parse(String s)`

  返回数字值，假设给定的String表示一个值



## 学习效率太差，该笔记停止更新！！！