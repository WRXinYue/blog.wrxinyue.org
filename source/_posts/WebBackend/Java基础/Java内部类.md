---
title: Java内部类
date: 2022-11-29 18:19:05.855
updated: 2023-04-18 15:09:29
url: /archives/java-inner-classes
categories: 
- WEBbackend
tags: 
- java
---

## Java Inner Classes (Nested Classes)

**内部类**又称**嵌套类**，是在类或接口内部声明的类，内部类可以访问外部类私有数据，但外部类不能访问内部类的成员，隐藏细节和内部结构封装性好

![image-20221129172214926](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221129172214926.png)

![image-20221129173253006](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221129173253006.png)

## Public Class

一个文件可以写多个类，但只能有一个public类

## Member Inner class(成员内部类)

成员内部类 ：

- 静态成员内部类：使用static修饰类；
- 非静态成员内部类：未用static修饰类，在没有说明是静态成员内部类时，默认成员内部类指的就是非静态成员内部类；

~~~java
class Outer {
    //code
    class Inner {
        //code
    }
}
~~~

## Local Inner Class(局部内部类)

定义在一个方法或者一个作用域里面的类

~~~java
public class locallnner1 {
    private int data = 30;  //instance variable
    void display() {
        class Local {
            void msg(){
                System.out.println(data);
            }
        }
        Local l = new Local();
        l.msg();
    }
    public static void main(String args[]){
        locallnner1 obj = new locallnner1();
        obj,display();
    }
}
~~~

## Anonymous Class(匿名类)

**匿名类是没有名字的内部类**

~~~java
public class Main {
    public static void main(String[] args) {
        Outer outer = new Outer("Nested"); // 实例化一个Outer
        Outer.Inner inner = outer.new Inner(); // 实例化一个Inner
        inner.hello();
    }
}

class Outer {
    private String name;

    Outer(String name) {
        this.name = name;
    }

    class Inner {
        void hello() {
            System.out.println("Hello, " + Outer.this.name);
        }
    }
}
~~~