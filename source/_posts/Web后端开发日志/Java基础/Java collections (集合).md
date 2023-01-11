---
title: Java collections (集合)
date: 2022-11-28 15:17:35.226
updated: 2022-12-06 16:55:22.855
categories: 
- WEBbackend
tags: 
- java
---

## 数组

### 声明数组变量

~~~java
dataType[] arrayRefVar;   // Java风格，首选方法
dataType arrayRefVar[];   // C、C++风格，可以用但不是首选
~~~

### 创建数组

~~~java
arrayRefVar = new dataType[arraySize];
//1、使用 dataType[arraySize] 创建了一个数组。
//2、把新创建的数组的引用赋值给变量 arrayRefVar
~~~

数组变量声明和创建数组一条语句实现

~~~java
dataType[] arrayRefVar = new dataType[arraySize];

dataType[] arrayRefVar = {value0, value1, ..., valuek};
~~~

### For-Each循环

~~~java
for(type element: array)
{
    System.out.println(element);
}
~~~

**等价于：**

~~~java
for(type element = 0; element < array.size(); i++){
    type element2 = array.get(element);
}
~~~



### 多维数组初始化

~~~java
type[][] typeName = new type[typeLength1][typeLength2];
~~~

type 可以为基本数据类型和复合数据类型，typeLength1 和 typeLength2 必须为正整数，typeLength1 为行数，typeLength2 为列数

## List

![image-20221128103642624](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221128103642624.png)

List表示一种有序列表，会根据放入元素先后顺序存放，可以包含重复的元素。

List 实现了 Collection 接口，它主要有两个常用的实现类：ArrayList 类和 LinkedList 类

|                     | ArrayList        | LinkedList           |
| ------------------- | ---------------- | -------------------- |
| 获取指定元素        | 速度很快         | 需要从头开始查找元素 |
| 添加元素到末尾      | 速度很快         | 速度很快             |
| 在指定位置添加/删除 | 需要移动元素     | 不需要移动元素       |
| 内存占用            | 少               | 较大                 |
| 实现方式            | 动态数组数据结构 | 链表数据结构         |

高运行速度往往是以牺牲空间为代价的，而节省占用空间往往是以牺牲运行速度为代价的，所谓“鱼与*熊掌*不可得兼”

### ArrayList类

~~~java
import java.util.List;
import java.util.ArrayList;

class Main {

    public static void main(String[] args) {
        //使用ArrayList类创建列表
        List<Integer> numbers = new ArrayList<>();

        //将元素添加到列表
        numbers.add(1);
        numbers.add(2);
        numbers.add(3);
        System.out.println("List: " + numbers);

        //从列表中访问元素
        int number = numbers.get(2);
        System.out.println("访问元素: " + number);

        //从列表中删除元素
        int removedNumber = numbers.remove(1);
        System.out.println("删除元素: " + removedNumber);
    }
}
~~~

输出结果：

~~~java
List: [1, 2, 3]
访问元素: 3
删除元素: 2
~~~

### LinkedList类

LinkedList底层的数据结构是基于双向循环链表，且头结点中不存放数据

![image-20221128114729288](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221128114729288.png)

既然是双向链表，那么必定存在一种数据结构——我们可以称之为节点，节点实例保存业务数据，前一个节点的位置信息和后一个节点位置信息，如：

![image-20221128114850541](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221128114850541.png)

~~~java
List<Integer> numbers = new LinkedList<>();
~~~

## Map

![image-20221128151006577](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221128151006577.png)

~~~java
HashMap<Integer, String> Sites = new HashMap<Integer, String>();
~~~

## Properties(属性)

Properties 继承于 Hashtable，其作用用来读写以`.properties`为扩展名的配置文件。每行以`key=value`表示，以之前的连接池笔记为例：

![image-20221206142119783](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221206142119783.png)

![image-20221206141345604](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221206141345604.png)

`Properties`读取配置文件，一共有三步：

1. 创建`Properties`实例；
2. 调用`load()`读取文件；
3. 调用`getProperty()`获取配置。

## Set

List接口和Set接口都继承了Collection接口。 但是，它们之间存在一些差异。

- List可以包含重复的元素。但是，Set不能有重复的元素。
- List中的元素以某种顺序存储。但是，Set中的元素以组的形式存储，就像数学中的集合一样。

## Queue

表示先进先出（FIFO：First In First Out）的有序表

- 通过`add()`/`offer()`方法将元素添加到队尾；
- 通过`remove()`/`poll()`从队首获取元素并删除；
- 通过`element()`/`peek()`从队首获取元素但不删除。

## PriorityQueue

`PriorityQueue`实现了一个优先队列：从队首获取元素时，总是获取优先级最高的元素。

`PriorityQueue`默认按元素比较的顺序排序（必须实现`Comparable`接口），也可以通过`Comparator`自定义排序算法（元素就不必实现`Comparable`接口）

## Deque

`Deque`实现了一个双端队列（Double Ended Queue），它可以：

- 将元素添加到队尾或队首：`addLast()`/`offerLast()`/`addFirst()`/`offerFirst()`；
- 从队首／队尾获取元素并删除：`removeFirst()`/`pollFirst()`/`removeLast()`/`pollLast()`；
- 从队首／队尾获取元素但不删除：`getFirst()`/`peekFirst()`/`getLast()`/`peekLast()`；
- 总是调用`xxxFirst()`/`xxxLast()`以便与`Queue`的方法区分开；
- 避免把`null`添加到队列

## Stack(栈)

栈（Stack）是一种后进先出（LIFO）的数据结构，操作栈的元素的方法有：

- 把元素压栈：`push(E)`；
- 把栈顶的元素“弹出”：`pop(E)`；
- 取栈顶元素但不弹出：`peek(E)`。

在Java中，我们用`Deque`可以实现`Stack`的功能，注意只调用`push()`/`pop()`/`peek()`方法，避免调用`Deque`的其他方法。

最后，不要使用遗留类`Stack`

## Iterator

Iterator（迭代器）不是一个集合，它是一种用于访问集合的方法，可用于迭代   `ArrayList`和 `HashSet`等集合，比如我们之前的增强for就是迭代器简化的书写格式（增强for循环的底层使用了迭代器遍历）

## Collections

`Collections`类提供了一组工具方法来方便使用集合类：

- 创建空集合；
- 创建单元素集合；
- 创建不可变集合；
- 排序／洗牌等操作。