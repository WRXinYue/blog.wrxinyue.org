---
title: js基础语法
date: 2022-08-09 19:47:30.0
updated: 2022-10-27 00:13:42.092
url: /archives/js-ji-chu-yu-fa
categories: 
- WebFrontend
tags: 
- javascript
---

# JavaScript简介

## 什么是JavaScript

前端 : 广义上就是所有用户界面都是前端, 狭义上就是网页上展示的内容

html : 构建页面的结构

css : 描述元素的展示效果

js : 响应用户行为, 交互等复杂操作

## JavaScript的发展历史

1. 1990年欧洲核能研究院在互联网上发明了万维网（规范制定了html）
2. 1992年美国超级电脑应用中心（NCSA）开发了人类历史上的第一个浏览器 `Mosaic` (浏览器风波)
3. 1994年 `Netscape Navigator1.0` 版浏览器问世
4. 1995年JavaScript 问世 = **布兰登 艾奇** self c js的优秀之处就是他并非原创,他的原创并不优秀
5. 1996年微软抢占市场 ie `Jscript`
6. 1997年JavaScript提交给了ECMA(欧洲计算机制造商协会) 制定了一个国际化的标准JavaScript进入标准化时代 ECMA-262发布
7. 2009年 ECMAScript 5.0发布 & node.js诞生 2008年的 浏览器引擎v8的诞生
8. 2010年 Express 发布 & angular发布 NPM、BackboneJS和RequireJS 诞生

## JavaScript的特点

1. 解释性的语言
2. 动态语言(弱类型语言) let a = 123 a = 'asdf'
3. 语法结构 和 c 和 java 非常相似
4. 基于原型的面向对象

## JavaScript的运行环境

运行在网页中, 在浏览器中运行,他是一个脚本语言, js是一个不需要编译就能运行的语言, 他是嵌套进了html在浏览器中运行的语言, 它不仅仅只可以在浏览器中运行 , 也可以在任何搭载js引擎的地方运行 ,

- V8 --- chrome , opear edge
- SpiderMonkey -- firefox
- 还有一些代号 chakra 用于 ie

### 引擎的工作原理

1. 引擎读取脚本
2. 将脚本转换为机器语言
3. 机器语言快速执行

## js的组成部分

1. ECMScript : js的语法规范
2. DOM : 文档对象模型, 描述处理网页页面和接口, 操作页面中的元素
3. BOM : 浏览器对象模型, 提供了浏览器的操作的方法

## 为什么要学习JavaScript？

js在网页中的优势

- 与html/css完美集成
- 简单的事情,简单的完成
- 被所有浏览器支持并且默认开启

js是将这三件事完美结合到一起的**唯一**的浏览器技术

此外js还可以用于创建服务器和移动端的应用程序

## 无可替代的js

每个程序员都有自己的开发习惯和项目需求,对语言和有一定的要求, 所以市面上也会出现许多新的语言能来实现网页的脚本 , 但是这些语言在浏览器执行之前**都会被编译成为js**

例如

- typeScript : 有更加严格的数据类型的js
- coffeeScript
- flow
- dart
- brython

## js能做啥

> Atwood定律：“**任何可以使用JavaScript来编写的应用，最终会由JavaScript编写**。
>
> 根据JavaScript具备的语言特性，他能做的事情将超乎你的想象，

## js能做啥

**前端领域**

- 有dom 可以操作 html页面结构样式 ui动画
- 有bom 可以响应浏览器的事件，操作浏览器
- 根据dom实现的用户行为交互
- 前端数据的验证
- 前后端数据的交互 （ajax，axios）

**后端领域**

> V8 JIT NodeJS 让JavaScript可以在服务端崭露头角，打破了JavaScript只能寄生在浏览器上的魔咒。CouchDB mongodb等基于JSON格式的NoSQL类型的数据库诞生，让JavaScript也可以在DB操作上大展身手。

- web服务框架 express/koa
- 数据库编写 mongodb
- 自动化构建领领域。gulp

**手机端**

**桌面应用**

**图形/游戏**

**嵌入式开发与iot开发**

# JS声明变量关键词

变量用于存储数据

需要先声明变量，才能使用

声明变量使用关键词主要有三个：`let、const、var`

> var关键词是老版本（ES5）JS所使用，现在已经淘汰

## let

let是新版本用于声明变量的关键词，**let声明的变量为普通变量**

用法：

```js
let a = 1

// 或者

let a

a = 1
```

上述使用`let`声明一个变量，变量名为`a`，值为1

## 变量的使用

正确用法：

```js
// 先声明变量【此为注释】
let a = 1 // 声明时进行赋值

// 后使用变量
alert(a) // 此处浏览器弹窗：1
```

上述代码也可以

```js
let a // let变量可以声明时不赋值

a = 1 // 对变量a进行赋值

alert(a) // 弹窗：1
```

错误用法：

```js
// 此处先使用变量
alert(a) // 此处会报错
// 后进行声明，为错误用法，因为在使用时，变量未被声明，所以会报错
let a = 1
```

> 结论：
>
> **变量必须先声明后使用！！！**
>
> 先使用，后声明会报错

## 变量的声明

**在同一环境中（同一作用域内）所有变量名称不能冲突，否则报错**

```js
let a = 1

// 此处为其他代码

let a = 1 // 此处会报错
```

> 结论：
>
> **变量禁止在同一作用域内重复声明**

*作用域的概念在后续章节进行讲解*

## 更改变量值

let声明的变量的值可以进行更改

```js
let a = 1
alert(a) // 此处弹窗：1

a = 2 // 此处更改了变量a的值为2，后续再使用a时，值就是a
alert(a) // 此处弹窗：2
```

> 结论：
>
> 更改已声明变量的值时，直接对变量赋值即可，无需写声明关键词

## const

`const`所声明的变量为**常量**，而非**普通变量**

常量：常量是一种特殊的变量，该变量的值必须在声明时就设置，且后续无法进行更改。

```js
const a = 1 // 声明常量a，值为1

a = 2 // 此处修改常量的值是违规操作，所以会报错
```

除此之外，`const`常量的特性跟`let`变量一致。

# 数据类型

数据类型是字面含义，表示各种数据的类型。在任何语言中都存在数据类型，因为数据是各种各样的。

JavaScript主要包含8种数据类型，8种数据类型可以分为基础类型和引用型两个分类：

- 基础型数据类型
  1. number 数字（包含整数和浮点数）
  2. string 字符串
  3. boolean 布尔值
  4. undefined 未定义
  5. null 空指针
  6. symbol 符号
  7. bigint 大整数
- 引用型数据类型
  1. object 对象

通常可以使用`typeof`操作符查看数据类型，但是请注意，在检测`null`值时返回的不是null类型，而是object类型，这是一个特例。

## Number

JavaScript不区分整数、浮点数等，统一都叫Number。`typeof 100` 得到 `"number"`。

- 数值字面量

  `10、1.5、-20`

- 浮点数精度问题

  `console.log(0.1+0.2);`

  `console.log(0.7*100);`

  JavaScript中采用 [IEEE 754 标准 (opens new window)](https://zh.wikipedia.org/wiki/IEEE_754)的 64 位双精度浮点数。数值的运行会先将数值转为二进制，而这种标准下小数可能会出现表示不全的情况，从而最终的结果出现误差。（有汇编基础的同学可以自行进一步了解）

  如果为了得到相对准确的结果，一般会将小数转为整数之后再进行运行，最后除以倍数。例如：`console.log( (0.1*100+0.2*100)/100 );`

- 数值范围

  根据标准，64位浮点数的指数部分的长度是11个二进制位，意味着指数部分的最大值是2047（2的11次方减1）。也就是说，64位浮点数的指数部分的值最大为2047，分出一半表示负数，则 JavaScript 能够表示的数值范围为21024到2-1023（开区间），超出这个范围的数无法表示。

  如果一个数大于等于2的1024次方，那么就会发生“正向溢出”，即 JavaScript 无法表示这么大的数，这时就会返回`Infinity`。相反，最大负数为 `-Infinity`。

  `Infinity` 和 `-Infinity` 也是数字的一种。

- 特殊值

  `NaN`是一个特殊的值，它的类型是`number`，表示一个损坏的数值，通常出现在**有不能转换为数字的数据参与运算时**产生。

## String

用来放一段文字。`typeof "文字文字"` 得到 `"string"`。

- 字符串字面量

  ```js
  "文字" // 双引号
  'ababa' // 单引号
  `abcd` // 反引号
  ```

  三种引号都可以用来表示字符串数据。

- 转义字符

  如果想在字符串使用引号文字：

  ```js
  console.log(  "It's an apple."  ); //一种引号里面使用其他两种引号没有问题
  
  console.log( "John:\"I love you.\"" ); //内部使用字面量相同的引号，则需要使用 \ 转义符号
  ```

  其他转义含义：

  ![img](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/2-1.png)

- 字符串拼接

  进行 `+` 运算时，两边任意一边的数据是字符串的话，则是拼接的功能

  ```js
  console.log("123" + "4"); //"1234"
  console.log("123" + 4); //"1234"
  console.log("zzt" + "666"); //"zzt666"
  ```

## Boolean

布尔值类型只有两个值：真`true` 和 假`false`。用于判断。

`typeof true`得到`"boolean"`。

## Undefined

未定义类型的值为`undefined`。

在变量没有被赋值时，默认值也为`undefined`。

`typeof undefined`得到`"undefined"`。

## Null

`null` 和 `undefined` 意义很接近，都表示“没有”。`null`可以理解为一个“空”对象，但是并不占据内存空间。通常在一个变量即将在后续的逻辑中被赋予一个对象值，但是刚开始定义的时候不能确定到底是哪个对象值时，赋予它初始值`null`。

**注意：**`typeof null`得到`"object"`。

## Symbol

> symbol是一种运用场景极少的数据类型，该类型数据在开发中，基本不会使用。所以了解即可

**Symbol值不可以进行运算**

Symbol实际上是ES6引入的一种原始数据类型，用它来产生一个独一无二的值。在JS中，基础数据类型通常只要“长得一样”在判断相等时，就是`true`，而在某些特定场合下，我们可能会需要一些独一无二的值来保证程序正常运行，比如给对象创建属性时，不会覆盖已有属性的情况。此时就需要Symbol.

```js
let s1 = Symbol() // 通过Symbol函数创建一个symbol数据

let s2 = Symbol() // 再创建一个

console.log(s1) // 输出结果：Symbol()
console.log(s2) // 输出结果：Symbol()

// 它们俩长得一样，但是却不相等
s1 == s2 // false
```

结论：每次调用`Symbol()` 都会在程序中，创建一个独一无二的值

## BigInt

> 该数据类型是在ES2020版本才加入的，所以2020之前的浏览器环境是不支持的。

JavaScript在数字上一直都很糟糕，因为在没有bigint类型之前，数字只能表示`-(2^53-1)`至 `2^53-1` 范围的值，即`Number.MIN_SAFE_INTEGER` 至`Number.MAX_SAFE_INTEGER`，超出这个范围的整数计算或者表示会丢失精度。

```js
var num = Number.MAX_SAFE_INTEGER;  // -> 9007199254740991

num = num + 1; // -> 9007199254740992

// 再次加 +1 后无法正常运算
num = num + 1; // -> 9007199254740992

// 两个不同的值，却返回了true
9007199254740992 === 9007199254740993  // -> true
```

于是 BigInt 应运而生，**它是第7个原始类型，可安全地进行大数整型计算**。 你可以在BigInt上使用与普通数字相同的运算符，例如 +, -, /, *, %等等。

创建 BigInt 类型的值也非常简单，只需要在数字后面加上 n 即可。例如，123 变为 123n。也可以使用全局方法 BigInt(value) 转化，入参 value 为数字或数字字符串。

```js
const aNumber = 111;
const aBigInt = BigInt(aNumber);
aBigInt === 111n // true
typeof aBigInt === 'bigint' // true
typeof 111 // "number"
typeof 111n // "bigint"
```

只要在数字末尾加上 n，就可以正确计算大数了：

```js
1234567890123456789n * 123n;
// -> 151851850485185185047n
```

不过有一个问题，在大多数操作中，不能将 BigInt与Number混合使用。比较Number和 BigInt是可以的，但是不能把它们相加。

```js
1n < 2 
// true

1n + 2
// Uncaught TypeError: Cannot mix BigInt and other types, use explicit conversions
```

BigInt的支持情况：

![img](https://user-gold-cdn.xitu.io/2020/1/18/16fb8c682a33ffd1?imageView2/0/w/1280/h/960/format/webp/ignore-error/1)

## Object类型

JavaScript中`object`类型包含的数据有很多，数组、普通对象、DOM节点、内置对象、函数等等都属于`obejct`类型。

- 数组

  一个数组中可以存放一组数据。

  - 取值使用 `[数字序号]` 下标，序号从0开始计数。取值超出序号最大值时，得到`undefined`。

    ```js
    let arr = [10,50,true,"Fly"];
    
    console.log(arr[2]); //true
    console.log(arr[6]); //undefined
    ```

  - 数组中可以存放数组。

    ```js
    let arr = [
        10,
        [
            "夏栀",
            "锦鲤",
            [
                true,
                false
            ]
        ]
    ];
    
    console.log(arr[0]); //10
    console.log(arr[1][0]); //"夏栀"
    console.log(arr[2][1]); //false
    ```

  - 数组拥有 `length` 属性，可以得到数组存放的数据的个数。

    ```js
    let a = [10,20];
    let b = [7,8,9];
    let c = [4,5,,6,];
    
    console.log(a.length); //2
    console.log(b.length); //3
    console.log(c.length); //4 最后一个,后面没有值的话，不算个数，中间的,之间即使没有数据也算个数
    ```

  - 数组可以取值，可以修改值或者新增值

    ```js
    let arr = [4,5];
    arr[0] = 44;
    arr[2] = 6;
    console.log(arr); // [44,5,6]
    
    let arr2 = [7,8,9];
    arr2.length = 2;
    console.log(arr2); //[7,8]
    ```

- 普通对象

  - 对象以**键值对**的形式存储数据。键也就是对象的属性，值就是一个具体的数据。

    属性的命名规则和变量命名规则有点相似，但是属性名更宽松。属性名允许是数字，不规范的属性名字可以加`" "`变成一个正确的属性名。

    ```js
    let xz = {
        name : "夏栀",
        "age" : 18,    //属性可以加 "" 类似字符串的写法，也可以不加
        "a b c" : true, //不规则的属性名，必须加 ""，不加会报错
        20 : null //自然数数字可以充当属性名，不必加 ""
    };
    ```

  - 取值时使用 `.` 操作符。

    ```js
    let xz = {
        name : "夏栀",
        age : 18,
        marry : false,
        friends : ["锦鲤","思思"]
    };
    
    console.log( xz.age ); //18
    console.log( xz.friends[0] ); //"锦鲤"
    console.log( xz.hobby ); //undefined
    ```

  - 当属性是一个数据时，使用 `[]` 来取值

    ```js
    let xz = {
        name : "夏栀",
        age : 18,
        marry : false,
        friends : ["锦鲤","思思"]
    };
    
    console.log( xz.name ); //"夏栀"
    console.log( xz["name"] ); //"夏栀"
    
    let a = "age";
    console.log( xz[a] ); //18
    console.log( xz.a ); //undefined
    ```

  - 对象可以取值，也可以重新赋值，也可以新增属性

    ```js
    let obj = {a : 10};
    
    obj.a = 20;
    obj.b = 30;
    
    console.log(obj); // {a:20,b:30} 
    ```

- 内置对象

  JavaScript语法中本来已经存在的对象，称之为内置对象。这些对象一般都已经包含了很多属性和方法，功能健全丰富，我们可以直接哪来使用。例如 `window` `document` `Math`。

- 函数

  JavaScript中函数也是对象类型，是一个极为特殊的对象。

  - 定义函数

    ```js
    let a = function(){
        //这里可以写任意js代码
    };
    
    function b(){
        //这里可以写任意js代码
    }
    ```

  - 函数执行

    ```js
    function fn(){
        alert(123);
    }
    //函数不执行是，内部函数不会运行。
    
    //函数加 () 可以自执行
    fn();
    ```

  - 更多函数相关的知识在后续章节会详细介绍

object类型的数据，`typeof`会得到`object`，但是函数在`typeof`时得到`function`。

# 运算符

## 算术运算符

```
加(+) 减(-) 乘(*) 除(/) 取余(%) 乘方(**)
// 加法运算
let a = 1
let b = a + 2 // 此时b等于3

// 减、乘、除同理
```

重点说下取余运算

取余运算即是字面含义，取除运算的余数，有时也叫模运算

```js
// 例如：5 除以 3  商为1   余数为2
let a = 5 % 3 // 此时a存储的就是5除以3的余数2

let b = 6 % 2 // 此时能整除，所以余数为0，则b的值为0

// 小模大的余数
// 例如：3 除以 5，因为被除数比除数小，所以此时商为0，余数为3
let c = 3 % 5 // 此时 c = 0

let d = 2 % 10 // d = 0
// 所以：小值对大值取余运算时，余数为小值
```

接着来看乘方运算，乘方运算就是计算某个数的`n`次方的结果

```js
// 例如：计算5的平方
let a = 5 ** 2 // 等同于 a = 5 * 5 ==>  a = 25

let b = 4 ** 4 // b = 256

let c = 2 ** 3 // c = 8
```

## 赋值运算符

```
等于(=) 加等于(+=) 减等于(-=) 乘等于(*=) 除等于(/=) 取余等于(%=) 乘方等于(**=)
```

看起来虽然多，但是比较比较容易理解

> 通常看到等号，要先计算等号右边

```js
// 等于 以下两种都是等于运算，简单来说 就是对变量赋值
let a = 1 
let b = 1 + 3

// 后续的带了运算符的都是同一个原理
// 例如: +=
let a = 1
a += 1 // 此时a=2，因为a += 1等价于 a = a + 1

// 其他同理
```

比较特殊的两个赋值运算符`自增1(++)、自减1(--)`

```js
let a = 1
a++ // 此时a = 2，因为a的自增1运算，可以理解为 a += 1，也就是 a = a + 1

// 同理
let b = 3
b-- // 此时b = 2，因为b的自减1运算，可以理解为 b -= 1，也就是 b = b - 1
```

所以自增和自减，是在自身原始值的基础上，进行增1或者减1计算，并且会改变自身的值，有赋值运算的效果

需要注意的是，自增和自减还有一些需要注意的地方，以自增为例

```js
let a = 1

let b = a++ // 请注意，此时 b = 1
```

原因是自增和自减，有两种情况，一种为后置自增或后置自减，另外一种为前置自增和前置自减，写法就是符号写在后面和前面的区别：前置自增：`++a`、后置自增：`a++`，自减同理。

接下来我们来看下上述为何b=1，而不是2，原因是**后置自增和后置自减参与其他运算时，是先将原始值完整参与其他运算后，才进行自增；而前置自增和前置自减，是先将原始值自增或自减后，才参与其他运算。**有一个先后顺序的问题。

```js
let a = 1

let b = a++ // 此时 b = 1，a = 2
```

是因为这里有一个自增运算，同时还有一个赋值的等于运算，而a的自增是后置的，所以此处程序先将a的原始值1参与其他运算（此处是赋值运算）后才会自增，所以b接收到的是原始值1，而后，a自增为2。所以结果为：`b=1 a=2`，自增运算同理。

```js
let a = 1
let b = ++a // a = 2  b = 2
```

根据上述原理，此时a的前置自增，会先进行自增，后参与赋值运算，所以`a=2 b=2`

> 赋值运算符是非常简单的运算符，唯一需要关注的是自增和自减的情况。自增和自增还有一个特殊的功能，后一个章节讲解

## 比较运算符

```
大于(>)、小于(<)、相等(==)、不相等(！=)、全等(===)、不全等(!==)、大于等于(>=)、小于等于(<=)
```

比较运算符的结算结果，永远都是一个布尔值，条件成立为`true`，不成立为`false`

```js
let a = 2 > 1 	// a = true
let b = -5 > 1 	// b = false
```

需要注意的是相等和全等的区别（不相等和不全等同理）

相等判断运算时，如果两个运算数类型不相同时，会先转换为同一个类型，再进行比较，如果相等则结果为`true`，反之`false`，而不全等运算时，如果两个运算数类型不相同，则立刻返回`false`，不进行任何类型转换，如果类型相同，则正常比较，根据结果返回值。

```js
let a = 1 == "1"	// 请注意，第一个运算数是数字1，第二个则是字符串1
// 此时 a = true，由于此时是相等比较，所以会将字符串1转换为数字后进行比较。

let b = 1 === "1" // b = false
// 此时，由于两个数类型不同，所以全等运算时，直接返回false

// 不相等和不全等同理
```

字符串再比较大小时，是按位比较各自的编码。`"3">"20"`得到`true`

对象在做相等判断时，比较的是内存地址。

关于不同类型的值进行比较运算时，类型的转换规则参考下表：

| 值                       | 字符串操作环境            | 数字运算环境             | 逻辑运算环境 | 对象操作环境 |
| :----------------------- | :------------------------ | :----------------------- | :----------- | :----------- |
| undefined                | "undefined"               | NaN                      | false        | Error        |
| null                     | "null"                    | 0                        | false        | Error        |
| 非空字符串               | 不转换                    | 字符串对应的数字值       | True         |              |
| 空字符串                 | 不转换                    | 0                        | false        | String       |
| 0                        | "0"                       | 不转换                   | false        | Number       |
| NaN                      | "NaN"                     | 不转换                   | false        | Number       |
| Infinity                 | "Infinity"                | 不转换                   | true         | Number       |
| Number.POSITIVE_INFINITY | "Infinity"                | 不转换                   | true         | Number       |
| Number.NEGATIVE_INFINITY | "-Infinity"               | 不转换                   | true         | Number       |
| Number.MAX_VALUE         | "1.7976931348623157e+308" | 不转换                   | true         | Number       |
| Number.MIN_VALUE         | "5e-324"                  | 不转换                   | true         | Number       |
| 其他所有数字             | "数字的字符串值"          | 不转换                   | true         | Number       |
| true                     | "true"                    | 1                        | 不转换       | Boolean      |
| false                    | "false"                   | 0                        | 不转换       | Boolean      |
| 对象                     | toString()                | value()或toString()或NaN | true         | 不转换       |
| Symbol                   | toString()                | Error                    | true         | Symbol       |
| BigInt                   | toString()                | 不转换                   | 除0n都是true | BigInt       |

## 逻辑运算符

```
与(&&)、或(||)、非(!)
```

> 与运算和或运算可以理解为一个管道

与是和的意思，`true`能通过，`false`不通过

或就是或者, `false`通过，`true`不通过

非也叫取反。

逻辑运算符在运算时，会在计算时，**临时**将运算数转换为布尔值。

```js
let a = 1

let b = 2

let c = a && b // 此时 c = 2
```

与运算时，a被转为布尔值`true`，根据与运算符的特性，`true`通过了，所以取到右边的值。c就等于右边的值2

```js
let a = 0

let b = 2

let c = a && b // c = 0
```

此时a转为布尔值`false`，`false`不能通过`&&`，所以停下来了，就取到了a的值，所以c等于0

或运算跟与运算则行为相反

关于各种值转为布尔值的情况，记住以下几个值即可：

JS中所有的值只有如下6个值可以转为`false`，除了这6个值，其他的都是转为`true`

1. 数字：`NaN`
2. 空指针：`null`
3. 未定义：`undefined`
4. 数字：`0`
5. 布尔值：`false`
6. 空字符串：`“”`

非运算是将运算符之后的值临时转为布尔值后，取其相反值

```js
let a = 1

let b = !a // b = false
```

a是数字1，转为布尔值为`true`，所以相反值为`false`，则`b = false`

```js
let a = 0

let b = !a // b = true
let a = ""

let b = !a // b = true
let a = "JavaScript真是太简单了"

let b = !a // b = false
```

## 运算符优先级

[运算符优先级](https://baike.baidu.com/item/运算符优先级/4752611?fr=aladdin)

## 拓展知识（不用掌握）

### 位运算

位运算直接对内存中表示数据的位进行操作，所以运算效率是最高的。

位运算时会将数值转换为32位整型来进行运算，所以位运算遇到小数时，直接处理掉小数部分当成整数来运算。并且*要是一个数的二进制表示超过32位，或者运算完后超过32位，那么就会出问题。所以不是所有的情况都适用位运算*。

32位中，前31位表示数值，第32位表示符号，例如：**3** 的32位表示为：`00000000 00000000 00000000 00000011`。（PS：短除法求二进制）。

负数会以**二进制补码**的形式来表示，规则是：

```js
//以 -3 为例子

//第一步：取负数对应的正数的二进制码，例子中取 3 的二进制码
00000000 00000000 00000000 00000011 //3的二进制码

//第二步：取得到的二进制码的反码，0变1  1变0
11111111 11111111 11111111 11111100 //二进制反码

//第三步：反码加1
11111111 11111111 11111111 11111101 //得到-3的二进制表示
```

位运算操作符：按位非`~` 、按位与`&`、按位或`|`、按位异或`^`、左移`<<`、无符号右移`>>>`、有符号右移`>>`。

- **~ 按位非**

每一位取反，例：

```js
let a = 12;
let b = ~a;

// 12的二进制表示：     00000000 00000000 00000000 00001100
// 按位非得到最终结果： 11111111 11111111 11111111 11110011  

//因为 第32位是1，代表负数，那这个负数是多少呢？按照上面的办法我们可以反推回来：
//负数码减-1：         11111111 11111111 11111111 11110010
//结果取反码：         00000000 00000000 00000000 00001101
//表示的正数是：13，所以该负数为  -13

alert(b); //验证一下
```

所以按位非的结果为 该数负数减1， `~12 === -13` `~-5 === 4`

- **& 按位与**

与是两个数之间的操作，两个数每一位的值 1 1 得1 1 0得0 0 1得0 0 0得0，例：

```js
let a = 11 & 4;

//11的二进制  00000000 00000000 00000000 00001011
//4 的二进制  00000000 00000000 00000000 00000100
//按位与      00000000 00000000 00000000 00000000
//结果为 0

alert( a ); //验证一下
```

- **| 按位或 ^ 按位异或**

这就和上面一个道理了，或都应该能理解 11得1 10得1 01得1 00得0，

异或：11得0 10得1 01得1 00得0

- **<< 左移**

二进制码左移几位，右边的空位补0

```js
let a = 4 << 2;

//4的二进制码： 00000000 00000000 00000000 00000100
//左移2位：  00 00000000 00000000 00000000 000100    //左边超过32的就不用管了，右边少于8位的补0    
//得到：        00000000 00000000 00000000 00010000  // 16

alert(a); //验证一下
```

左移是*不会改变符号位*的，相当于原来的数乘以 2的几次方。

- **>>> 无符号右移 >> 有符号右移**

有符号右移：不动符号位，二进制码右移，左侧补0，原理和上述一样。

无符号右移：移动所有位包括符号位，整体右移，左侧补0，所以如果负数进行无符号右移，会得到一个很蛋疼的数。

- 位运算的运用

左移右移来进行相对于 2的乘方 运算。

强制取整，位运算直接会舍弃小数，例如：`let a = 12.12 | 0;`，直接舍弃小数位，并且或上0不会影响整数位。

判断奇偶，奇数 & 1 一定是 1 偶数 & 1一定是 0

# 类型转换

类型转换是将某个数据转换为其他类型的数据的操作。

可以参考表格

| 值                       | 字符串操作环境            | 数字运算环境             | 逻辑运算环境 | 对象操作环境 |
| :----------------------- | :------------------------ | :----------------------- | :----------- | :----------- |
| undefined                | "undefined"               | NaN                      | false        | Error        |
| null                     | "null"                    | 0                        | false        | Error        |
| 非空字符串               | 不转换                    | 字符串对应的数字值       | True         |              |
| 空字符串                 | 不转换                    | 0                        | false        | String       |
| 0                        | "0"                       | 不转换                   | false        | Number       |
| NaN                      | "NaN"                     | 不转换                   | false        | Number       |
| Infinity                 | "Infinity"                | 不转换                   | true         | Number       |
| Number.POSITIVE_INFINITY | "Infinity"                | 不转换                   | true         | Number       |
| Number.NEGATIVE_INFINITY | "-Infinity"               | 不转换                   | true         | Number       |
| Number.MAX_VALUE         | "1.7976931348623157e+308" | 不转换                   | true         | Number       |
| Number.MIN_VALUE         | "5e-324"                  | 不转换                   | true         | Number       |
| 其他所有数字             | "数字的字符串值"          | 不转换                   | true         | Number       |
| true                     | "true"                    | 1                        | 不转换       | Boolean      |
| false                    | "false"                   | 0                        | 不转换       | Boolean      |
| 对象                     | toString()                | value()或toString()或NaN | true         | 不转换       |
| Symbol                   | toString()                | Error                    | true         | Symbol       |
| BigInt                   | toString()                | 不转换                   | 除0n都是true | BigInt       |

## 显示类型转换

转换方法：

- 转数字：`Number()`
- 转字符串：`String()`
- 转布尔值：`Boolean()`
- 转字符：`Symbol()`基本没有该需求
- 转大数字：`BigInt()`

常见需求是在数字、布尔值、字符串三者之间进行转换

```js
let a = 1

let r1 = String(a) // 将a转换为字符串
let r2 = Boolean() // 将a转换为布尔值

let b = "123"

let r3 = Number(b) // 将b转换为数字，请注意，如果字符串内不全是数字字符时会转换成坏值NaN
let r4 = Boolean(b) // 将b转为布尔值

// 布尔值转换为数字时，true转为1 false转为0，转为字符串时相当于给对应的值加上引号
```

> 以上通过对应的数据类型的接口转换的方式叫显示类型转换

## 隐式类型转换

隐式转换是在使用非上面的接口转换时的叫法，通常这些转换情况容易被人忽略，所以叫隐式转换

### 1. 转数字

上一章提到的自增和自减，就具有隐式类型转换的功能，会将变量转换为数字

```js
let a = '123' // 此时a是字符串，而不是数字
a++  // 此时 a = 124，
```

因为自增和自减具备类型转换的功能，会先将a转换为数字，再进行自增

同时在比较大于、小于、小于等于、大于等于时，有数字参与的比较，也会将另外一个非数字转换为数字

### 2.转字符串

当有字符串参与的加法运算时，非字符串数据会被转换成字符串，然后将两个字符串合并

```js
let a = "123"
let b = true
let c = a + b
// c = "123true"
```

# 判断

判断是代码流程控制的一个重要环节，绝大多数逻辑的实现都离不开判断。

## 1. if判断

写法：

```js
//单个if
if( 条件 )
{
    //条件为真时执行的代码
}

//if else
if( 条件 )
{
    //条件为真时执行的代码
}
else
{
    //条件为假时执行的代码
}

//多个else
if( 条件1 )
{
    //条件1为真时执行的代码
}
else if( 条件2 )
{
    //条件1假 条件2真时执行的代码
}
else if( 条件3 )
{
    //条件1条件2都为假 条件2为真时执行的代码
}
//可以一直列下去，可以if(){}结束，也可以else{}结束。
```

## 2. 三目运算

真语句为一条，假语句也只有一条时，我们可以将这种if else改为三目写法；

```ini
条件 ? 真执行的语句 : 假执行的语句;
//设 前文已定义变量 a  b
//if
if( a > b ){
    oBox.className = "goudan";
}else{
    oBox.className = "dachui";
}

//三目
 oBox.className = a>b ? "goudan" : "dachui";
```

三目不一定比if好，有些时候看起来三目比if更直观，但是有些时候if看起来会比三目更直观。

- () 结合三目的使用

真语句或者假语句不止一条时，是不是不能用三目呢，不一定哈，比如：

```js
//ifelse
if(2>5){
    console.log(1);
    console.log(1);
    console.log(1);
}else{
    console.log(2);
    console.log(3);
    console.log(4);
}

//改成三目
2>5?(
    console.log(1),
    console.log(1),
    console.log(1)
	):
	(
    console.log(2),
    console.log(3),
    console.log(4)
	);
```

## 3. switch

特殊形式的ifelse可以改写为switch，更清晰。

例： （注意关键词 switch case break default）

```js
//设 前文已定义变量a
//if else
if( a === "阿飞" ){
    //code1
}else if( a === "风屿"  ){
    //code2
}else if( a === "夏栀" ){
    //code3
}else{
    //code4
}

//switch
switch( a ){
    case "阿飞":
    	//code1
    	break;
    case "风屿":
    	//code2
    	break;
    case "夏栀":
    	//code3
    	break;
    default:
    	//code4
    	break;
}
```

## 4. 使用 && || 来代替判断

有时候会用到，

例：

```js
//设前文已定义变量a b


//if
if(a){
    somecode;
}

//逻辑
a && somecode;




//if
if( a > b ){
    console.log(2);
}else{
    console.log(3);
}

//三目
console.log(   a>b?2:3   );

//逻辑运算
console.log(    a>b && 2 || 3    );
```

# 循环

## for

循环是任何一门语言都会有个命令，用于反复执行某段代码。

例如，循环代码块5次：

```js
for (let i = 0; i < 5; i++) {
  let text = `当前数字为${i}`
  console.log(text)
}

// 输出结果：
当前数字为0
当前数字为1
当前数字为2
当前数字为3
当前数字为4
```

此例中，`let i = 0`是声明循环的计次变量，`i < 5`是循环终止条件，`i++`是计次变量更新步长，`{}`内的所有代码为循环体内代码块。

具体流程是：计次变量进行终止条件判断运算，如果结果为true，则循环体执行，结束后进行步长更新运算，从而得到新的结果再次参与判断；如果结果为false，则立刻终止循环；

所以想要控制循环次数，可以通常改变判断条件实现，如果循环条件永远为`true`，则就是一个**死循环**。

## for-in

for-in循环是一种特殊循环，可用于循环对象或数组（通常循环数组，使用for-of）

```js
let o = {
  name: 'dapiaoliang',
  age: 18,
  sex: 'woman'
}

// 将对象内的所有键值对循环输出, 此时可以使用for-in
for (let key in o) {
  let text = `当前属性名：${key}, 值：${o[key]}`
}

// 结果（这种循环输出顺序可能会不一样，但数量不变）
当前属性名：name, 值：dapiaoliang
当前属性名：age, 值：18
当前属性名：sex, 值：woman
```

由此可见，for-in 用于循环对象内所有的键值对，具体输出顺序可能会发生变化，但是每个键值对都会被循环一次。

## for-of

for-of时一种专门用于循环数组或类似数组结构（Iterator接口）的循环命令

```js
let arr = ["dapiaoliang", 18, 'woman']

for (let value of arr) {
  let text = `当前值是：${value}`
  console.log(text)
}

// 结果
当前值是：dapiaoliang
当前值是：18
当前值是：woman
```

类似for-in，可直接循环数组的每一项数据

## while

while是for的一个变种。（不常用）

```js
while (条件) {
	循环体
}
```

当条件为true，循环体就会执行，这种循环没有计次变量，不需要更新步长。所以条件通常需要是一个可变参数，如果不是可变参数，就需要在循环体内，有明确的终止条件

## do-while

do-while是一种特殊的while循环（不常用）

```js
do {
  循环体
}while(条件)
```

看起来是将while的条件和循环体交换了位置，所以这种循环体，在第一次时，是不需要进行判断条件就会执行，执行结束后，再进行判断，判断结果决定下一次是否会循环

> 所以，do-while的条件是决定下一次是否循环，而第一次永远都会执行，所以可以理解为至少执行一次的while循环

### 跳出循环

如果在循环体内由于某些原因，需要在代码块内跳出循环，可以使用对应的关键字。

`break`用于永久终止此循环，`continue`用于终止当前这次循环（立刻进入下一次）

例如，跳过`i = 3`时情况

```js
for (let i = 0; i < 5; i++) {
  if (i === 3) {
    continue
  }
  let text = `当前数字为${i}`
  console.log(text)
}
当前数字为0
当前数字为1
当前数字为2
当前数字为4
```

上述例子，在`i=3`时，循环体内判断为真，执行`continue`，那么此次后续两行代码不会执行，会立刻进入下一次循环。

```js
for (let i = 0; i < 5; i++) {
  if (i === 3) {
    break
  }
  let text = `当前数字为${i}`
  console.log(text)
}
当前数字为0
当前数字为1
当前数字为2
```

此时判断内是break，那么当`i=3`时，执行了break，那么后续所有次数的循环都不会执行。break会把整个循环全部关闭。

# 函数

函数是由事件驱动的或者当它被调用时执行的可重复使用的代码块。通俗的说，函数是利用特定语法，将一段代码打包在一起，每次调用函数就可以让这个代码块内的代码全部执行，复用代码。

> 要注意的是，函数跟循环不相似，循环是重复一定次数的执行代码，函数虽然可以重复执行代码，但是它很灵活，可以任意决定它调用的时机

## 声明函数

声明函数有两种方式

```js
// 方式一
let fn1 = function () {
  // 代码块
}

// 方式二
function fn2 () {
  // 代码块
}
```

fn1和fn2都是函数名字，这是两种不同声明方式写的位置不同。

> 函数体内的代码，在声明时不会执行的。必须在调用函数后，才能执行

## 调用函数

函数调用只需要将函数名字加括号即可，一个函数可以重复调用无数次

```js
let fn = function () {
  // 代码块
}

fn()
```

调用后，函数内的代码块就会执行

例如：计算1 + 2的值，并且输出

```js
let add = function () {
  let res = 1 + 2
  console.log(res)
}

// 第一次调用
add() // 此时函数调用，函数体内的代码执行，输出3

// 还可以再次调用
add() // 此时再次调用，继续执行代码，输出3
...
```

这样我们就可以得到一个能自动计算1+2值的函数，但是这样很蠢…因为每次都只会计算1+2，计算其他值，就需要再写函数，很麻烦。所以…看下面

## 函数参数

为了不让函数内部的代码全部都固定死、每次执行都是固定结果，所以函数可以在调用时，可以从外部注入数据到内部使用，这种行为是通过函数参数完成的。

**想要使用函数参数功能，从外部注入数据，那么函数内就需要提前有占位的符号，这种符号就类似变量功能，称为形参，而注入的数据成为实参**

```js
// 例如计算，1 + n的结果

// 此时函数内需要一个n作为占位符，那么n需要提前声明
let add = function (n) { // 这个n是声明函数内会使用n（n就是形参）
  let res = 1 + n // 这里使用n占位
  console.log(res)
}
// 调用时，可以传入不同的数据，作为此次调用n的实际数据，
add(5) // 此时n=5，则执行后，输出：6 （传入的5就是此次传入的实参）

add(10) // 输出：11

...
add(-10) // -9
```

这样就得到一个能计算1+n的函数，如果需要的参数很多，依次写上占位符，将实参一次写在调用的括号内即可

> 实参和形参的顺序是对应的，第一个形参接收第一个实参…以此类推
>
> 形参需要遵守变量命名规范

```js
let fn = function (a,b,c,d,e) {}

fn(1,2,3,4,5)
```

虽然形参和实参可以让函数使用起来非常灵活，但是这样并不是万能的。

例如，需要计算所有传入的实参的和。

```js
let add = function (a， b, c){
  // 如果实参个数不确定，那么形参就不好写，因为写少了，多出来的实参就无法接收，写多了，可能又会没有值传入
  let res = a + b + c
}

add(1, 2) // 此时传入2个实参，形参3个，那么最后一个c就没有值就是undefined，此时进行运算会得到NaN
```

通过上面例子，发现形参实参通常实在个数确定的时候使用，如果数量不确定就很尴尬…所以请看下面

## Rest参数

rest是剩余的意思，rest参数是用于函数参数不确定，每次传入的数量都不同，或者函数参数过多，但是又不想写那么多形参的情况，那么rest可以一次性全部接收

```js
// 例如，计算传入的所有数据
let add = function (...rest) {
  let res = 0
  for (let value of rest) {
    res += value
  }
  console.log(res)
}

add(1, 2) // 实参2个，此时rest接收到就是两个数据，  输出 3

add (3, 5, 4) // 实参3个，rest内就是3个数据。输出 12
```

通过上面例子，可以看出，rest非常灵活，可以用于接收所有实参

如果需要接收部分参数，也可以这么做

```js
let add = function (a, b, ...rest) {}

add(1,2,3,4,5) // 此时 a = 1 b = 2 rest = [3,4,5]
```

> 所以，rest是用于接收剩余没有被形参所接收的全部参数的。如果一个形参都没有，只有rest，那么rest接收所有，如果rest前面有形参，则先优先其他形参接收，剩余没有被接收的都在rest内。所以rest的名字非常形象【剩余参数】

请注意的是，rest必须是最后一个参数，rest参数后面不能写其他形参。下面的写法都是错误的

```js
let fn = function (...rest, a){}

let fn1 = function (a, ...rest, b){}

let fn2 = function (...rest, ...rest2) {}
// 这三种都是错的。
```

## 返回值

上面的所有函数，数据只能从外传入内，然后在内部使用。无法将函数内的运算结果返回出外部使用。这是因为函数没有设置返回值。

函数设置返回值使用`return`命令，`return`的作用是停止函数执行，并立刻返回后面的值

```js
let add = function () {
  let res = 1 + 3
  return res
}

add() // 4
```

函数内一旦执行到`return`的行，就会立刻返回值。下一行之后的代码都永远不会执行。

## 箭头函数

箭头函数是`function`函数在某些情况的特殊写法

```js
let fn = function () {
  return 1 + 3
}

// 上面fn函数执行后，立刻返回1+3的值，对应的箭头函数写法
let afn = () => 1 + 3
```

箭头函数`=>`之后的内容就相当于`function`函数return之后的内容。但是这种写法只适合上面的情况。

```js
let fn = function () {
  let a = 3
  let b = 2
  let c = a ** b
  return c
}

// 上面的函数，函数体内有多条语句时，需要下面写法
let afn = () => {
  let a = 3
  let b = 2
  let c = a ** b
  return c
}
```

通过上面两个例子可以发现，如果箭头函数内有多条语句时，需要写花括号。没有花括号的适合，箭头后只能写一条语句，并且语句的结果会默认被return，有花括号时，如果需要返回值，需要明确写上return

如果需要传参时：

```js
let add = function (a, b, ...rest) {
  let res = a + b
  for(let value of rest) {
    res += value
  }
  return res
}

// 以上函数等价于下面箭头函数
let fn = (a, b, ...rest) => {
  let res = a + b
  for(let value of rest) {
    res += value
  }
  return res
}
```

所以参数写法跟function函数是完全一致的。

## 函数在对象内的简洁写法

如果一个函数是对象内的某个属性的值，可以有简洁写法

```js
let o = {
  fn: function () {
    
  }
}

// 以上是正常写法，跟下方写法完全等价
let o1 = {
  fn () {
    
  }
}
```

# 作用域

作用域通俗的说，是变量起作用的范围。因为每个变量都有对应的“生活环境”

JavaScript中作用域主要分为以下几种：

- 全局作用域（即script标签内的空间）
- 函数作用域（每个函数的花括号内的部分）
- 块作用域（除函数外，其他的花括号空间都是块作用域，如if的花括号）

**变量只提供给当前环境和当前环境的子环境进行使用。**

```js
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title>Examples</title>

	</head>
	<body>
		<script>
			// 此时这里是script内部，所以这个空间是一个全局作用域，在此环境声明的变量为全局变量
			
			let a = 1 // a 为全局变量

			let fn = function () {
				// 这是函数体内，所以这个小空间是函数作用域
				let a = 2 // 此时这个变量a服务与这个空间和这个空间的子空间
				console.log(a) // 当前使用的a在这个环境中存在，所以输出 2

				{
					// 此处，直接写了一个花括号，那么就开启一个独立的空间
					console.log(a) // 此时当前空间没有a，所以向上个空间查找，就找到函数内的a，所以输出 2
				}
			}


			console.log(a)  // 此时的console语句是在全局环境执行，所以这里的a不是函数内的，而是全局环境的a  所以输出 1

			let fn2 = function () {

				{
					console.log(a)
					// 此时这个块作用域自身空间没有a，向上级空间查找，上级空间是fn2的函数空间，也没有找到，继续向上级查找，在全局空间找到了，所以输出 1
				}

			}



		</script>
	</body>
</html>
```

上图作用域结构如下图所示

查找的规则是，先查找自身，如果查找到就用，就不在向上查找，如果没有依次向上层作用域找，直到找到为止。如果找到全局都没有找到对应名称的变量，则抛出错误`xxx is not defined`。这就是作用域的规则。

# 常用API

## Number

### toFixed()

四舍五入指定小数位数，返回结果为字符串

```js
let num = 3.1415926
// 保留两位小数
let str1 = num.toFixed(2) // 3.14
// 保留三位小数
let str2 = num.toFixed(3) // 3.142
```

### Number.isNaN()

判断一个数是否是NaN

```js
Number.isNaN('123') // false 

Number.isNaN(456) // false

Number.isNaN(true) // false

Number.isNaN(NaN) // true
```

### Number.isFinite()

检测某个值是否是有限数字

```js
Number.isFinite(123) // true
Number.isFinite(12346546546545646546464646465456456456) // true
Number.isFinite(true) // false
Number.isFinite('abd') // false
Number.isFinite(NaN) // false
```

### Number.isInteger()

检测某个值是否为整数

```js
Number.isInteger(123) // true
Number.isInteger(123.0) // true
Number.isInteger(123.1) // false
Number.isInteger('abc') // false
```

### Number.parseInt()

parseInt() 函数可解析一个字符串，并返回一个整数。

```js
Number.parseInt('123.456') // 123
Number.parseInt('123aaa') // 123
Number.parseInt('123.456aaa') // 123
Number.parseInt('a123') // NaN
```

### Number.parseFloat()

parseInt() 函数可解析一个字符串，并返回一个浮点数。

```js
Number.parseFloat('123.456') // 123.456
Number.parseFloat('123aaa') // 123
Number.parseFloat('123.456aaa') // 123.456
Number.parseFloat('a123') // NaN
```

## String

### charCodeAt()

返回指定位置的字符串unicode编码

```js
let str = "abcde"
str.charCodeAt(2)   // 99 
```

### String.fromCharCode()

通过unicode编码排序值返回对应的字符

```js
String.fromCharCode(99) // c
```

### substring()

substring( startNum , endNum ) 截取字符串

```js
let str = "hello"
str.substring(1,2) // e
// startNum 参数为起始位置(包含), endNum 参数结束位置(不包含)
// endNum 参数不写 默认截取所有的
```

### substr( )

substr(startNum, length) 截取字符串

```js
let str = "hello"
str.substr(1,2) //el
// startNum 参数为起始位置(包含), length 参数截取长度
// length 参数不写 默认截取所有的
```

### slice( )

slice 使用与substring 相同

### trim()

清除左右空格

```js
let str = " hello  "
str.trim() // "hello"
```

### replace()

replace( str , repStr ) 替换字符串

```js
let str = "12345abcdef"
let str1 = str.replace(2,4)
console.log(str1) // 14345abcdef
// str 参数为查找字符的被替换字符, repStr 参数值 将替换str值
// 如果没有查询到将返回原字符串
```

### split()

字符串切割成数组,从选择器切割

```js
let str = "hello"
console.log(str.split("e"))  // ["h", "llo"]
```

### indexOf()

indexOf( Str[,num]) 查找到字符串返回下标,否则返回-1,

```js
let str="hello"
console.log(str.indexOf("e")) // 1
// Str 参数为查找字符, num 参数为查找开始位置
// num参数不写 默认从0开始
```

### lastIndexOf()

返回结果与indexOf相同, 检索方向为从后往前;

### includes(),startsWith(),endsWith()

> includes((str[,num]) 返回布尔值，表示是否找到了参数字符串
>
> startsWith((str[,num]) 返回布尔值，表示参数字符串是否在原字符串的头部
>
> endsWith((str[,num]) 返回布尔值，表示参数字符串是否在原字符串的尾部

```js
let str = "apple banana";
str.includes("apple") // true


let str = "http://www.baidu.com";
str.startsWith("http");      // true
str.startsWith("https");      // false

let str = "http://www.baidu.com";
str.endsWith("com");      // true
str.endsWith("cn");      // false

// Str 参数为查找字符, num 参数为查找开始位置
// num参数不写 默认从0开始
```

### repeat()

repeat(n) 将字符串重复n次

```js
let str = "夏栀";
let repstr = str.repeat(3);
console.log(repstr);  //夏栀夏栀夏栀
// n 参数为重复几次   参数如果是小数，会被向下取整
```

## Array

### push()

push(data[,data]) 依次往数组最后添加数组项 ,可以添加多个

```javascript
let arr = [1,2,3]
let arr1 = arr.push(4,5)
console.log(arr)  // [1,2,3,4,5]  
// 返回值新数组的length    改变原数组
```

### pop()

删除数组最后一项

```javascript
let arr = [1,2,3]
let arr1 = arr.pop()
console.log(arr) // [1,2]
// 返回值是删除的数值  改变原数组
```

### shift()

移除数组中第一项并返回该项

```javascript
let arr = [1,2,3]
let arr1 = arr.shift()
console.log(arr)     // [2,3]
// 返回值是删除的数值   改变原数组
```

### unshift()

在数组前添加任意数组项,可以添加多个

```javascript
let arr = [1,2,3]
let arr1 = arr.unshift(0)    // 改变原数组       
console.log(arr) // [0,1,2,3] 
// 返回值新数组的length          改变原数组
```

### splice()

splice(index,num,info) 具有截取,替换,添加方法

```javascript
//- index 从数组第几个项开始
//- num  截取的数量 
//- info 从截取位置开始添加数组项
//- 会改变原数组  返回截取的数组

let arr = [1,2,3,4,5]
arr.splice(2,3,"a","b")
console.log(arr)

//1)截取方法     截取数量
let arr = [1,2,3,4]
arr.splice(1,2)

//2)添加方法    截取数量为零
arr.splice(1,0,1)
arr.splice(1,0,1,2,3)  // 添加多个  

//4)替代方法    截取数量与添加相同
arr.splice(0,0,5)
```

### sort()

sort( function ) 数组排序

```javascript
// function 参数为一个函数体   函数体接收两个形参
// 不传参数 根据ASCII码表 来比较数组中的第一个值排序

let arr = [22,44,11,33,55]
arr.sort(function(a,b){
    return a - b //从小到大排列
    return b - a //从达到小排列
})
console.log(arr)

/*
函数 return正数 不换位置
	返回大于0 换位置
	小于0 不会位置
	与每一项比较
*/
```

### concat()

合并两个数组为一个新的数组 不改变原数组

```javascript
let arr1 = [1,2,3]
let arr2 = ["a","b","c"]
let arr = arr1.concat(arr2)
console.log(arr)
```

### join()

join(str) 根据参数规则返回新的字符串 不改变原数组

```javascript
let arr = [1,2,3,4]
let arr1 = arr.join("-")
console.log(arr1) // 1-2-3-4
// 将数组合并成字符串
```

### reverse()

数组反向排序 改变原数组

```js
let arr = [1,2,3,4]
let arr1 = arr.reverse()
console.log(arr1)  // [4, 3, 2, 1]
```

### slice()

slice(startNum,endNum) 截取数组

```js
let arr = [1,2,3,4]
arr.slice(1,3)
// startNum 参数为起始位置(包含), endNum 参数结束位置(不包含)
// endNum 参数不写 默认截取所有的
```

### Array.isArray()

判断是否是数组

```js
let arr = [1,2,3]
console.log(Array.isArray(arr))//true
```

### Array.from()

把类数组(获取一组元素,arguments)对象转成数组

### indexOf(Str[,num])

查找到数组项返回下标, 否则返回-1, 与字符串使用一样

```js
let arr = [1,2,3]
arr.indexOf(2)
// Str 参数为查找字符, num 参数为查找开始位置
// num参数不写 默认从0开始
```

### includes()

查看数组中是否包含参数的值,返回布尔值

```js
var arr = ["apple" , "origan","banana"];
var a = arr.includes("apple");
console.log(a);   // true

var b = arr.includes("apple2");
console.log(b);   // false
```

### forEach

循环数组,无返回值

```js
var arr = ["a","b","c","d"]
arr.forEach(function(value,index,arr){
    console.log(value,index,arr);
})
```

### map

正常情况下,需要配合return使用,返回新数组,如果没有return,这个就相当于forEach

map如果没有return 则返回元素项数个undefined组成的新数组

```js
// 整理数据结构
let arr= [
    {title: "aa",read: 100},
    {title: "bb",read: 20},
    {title: "cc",read: 50}
]
let newArr = arr.map((item,index,arr) => {
    let json = {};
    json.shop = `*${item.title}--`;
    json.price = `￥${item.read}元`
    return json;
})
console.log(arr);
console.log(newArr);
```

### reduce

用的极少,比如求数组的和,阶乘都可以

```js
let arr = [1,2,3,4,5,6,7,8,9,10]
let res = arr.reduce((prev,cur,index,arr) => {
    return prev + cur;
})
console.log(res);  //55
// prev是上一次的运算结果,cur是当前的值,index是当前的下标,arr是当前的数组
```

### Object

Object.assign(目标对象,需要合并的对象)

```js
let json = {a:1};
let json2 = {b:2};
let json3 = {c:3};

let obj = Object.assign({},json,json2,json3);
console.log(obj);     // {a: 1, b: 2, c: 3}
```

# 定时器

1. setTimeout() 用来指定某个函数或字符串在指定的毫秒数之后执行 **只执行一次**

   - clearTimeout() 清除定时器

   ```javascript
   /*setTimeout() 有两个参数
   	1.执行体 注意:函数传递参数可以把实参放在时间参数的后面(不兼容IE9及以下)
   	2.时间 多久执行*/
   let a=0
   let fun =()=>{
       a++
       console.log(a)
       setTimeout(fun,1000)
   }
   setTimeout(fun,1000)
   
   //clearTimeout() //参数是定时器的名称
   let timer = 0
   let a = 0
   let fun=()=>{
       a++
       console.log(a)
       timer = setTimeout(fun,1000)
   }
   fun()
   
   document.onclick = ()=>{
       console.log("定时器停止了")
       clearTimeout(timer)
   }
   ```

2. setInterval() 用来指定某个函数或字符串在指定的毫秒数之后执行 **无限循环**

   - clearInterval() 清除定时器

   ```javascript
   //传递参数是一样的结构
   let timer = setInterval(function(){
       console.log(1)
   },1000)
   document.onclick = ()=>{
       console.log("定时器停止了")
       clearInterval(timer)
   }
   ```

3. requestAnimationFrame() 浏览器专门为动画提供的API 浏览器会自动优化方法的调用 页面不是激活的状态下 动画暂停 有效节省CPU开销 用法与setTimeout相似 只是不需要设置时间间隔

   - cancelAnimationFrame()

   ```javascript
   //复合动画帧的计时器,使得动画更流畅,也只是执行一次
   let timer = 0
   let a = 0
   function fun(){
       a++
       console.log(a)
       timer = requestAnimationFrame(fun)
   }
   fun()
   document.onclick=()=>{
       console.log("定时器停止了")
       cancelAnimationFrame(timer)
   }
   ```

# 内置对象

内置对象是系统预先提供的一些特殊对象，能实现不同的功能

## Math

Math是数学对象，跟数学相关的api都在其身上

下面来了解些常用对象

- Math.random() 随机生成0到1之间的数 包括0不包括1

  ```javascript
  document.onclick = ()=>{
      console.log(Math.random())
  }
  
  //生成任意范围的随机数
  let getRandom = (min,max)=> Math.random()*(max-min)+min
  document.onclick =()=>{
      let x = getRandom(5,10)
      console.log(x)
  }
  ```

- Math.ceil() 向上取整(天花板值) 遇到小数向上取整

  ```javascript
  console.log(Math.ceil(1.1)) //2
  ```

- Math.floor() 向下取整(地板值) 遇到小数向下取整

  ```javascript
  console.log(Math.floor(1.9)) //1
  
  //返回整数部分
  function getInt(x){
      x = Number(x)
      return x<0?Math.ceil(x):Math.floor(x)
  }
  document.onclick = function(){
      console.log(getInt(0.5))
  }
  //返回任意范围的随机整数
  function getIntRadom(min,max){
      return Math.floor(Math.random()*(max-min)+min)
  }
  console.log(getIntRandom(2,6))
  ```

- Math.round() 四舍五入

- Math.max() 取得最大值

- Math.min() 取得最小值

  ```javascript
  //随机排序
  let arr = [2,4,8,7,1,6,9]
  document.onclick = function(){
      arr.sort(function(){
      	return Math.random()-0.5
  	})
  	console.log(arr)
  }
  ```

- Math.pow() 指数 第一个参数为底数 第二个参数为幂

### 数学弧度与角度

```javascript
//60° = π/3
//90° = π/2  角度转弧度

//弧度 = 角度 * π/180
//求一个半径为5的圆心面积
let x = 5
let y = Math.PI*Math.pow(x,2) // 圆心面积算法
注意:JS三角函数里面的参数值不是角度 是角度对应的弧度值

//30度角对应的弧度制
let angle = 30
let randian = angle*Math.PI/180  //角度转换成弧度

x/30
```

### 三角函数

- Math.sin() 返回正弦 参数为弧度值
- Math.cos() 返回余弦
- Math.tan() 返回正切
- Math.asin() 返回反正弦
- Math.atan() 返回反正切
- Math.acos() 返回反余弦

其他API可参考[MDN](https://developer.mozilla.org/zh-CN/docs/Web/JavaScript/Reference/Global_Objects/Math)

### 第三方插件：mathjs

#### 安装

```html
<script src='https://cdn.bootcdn.net/ajax/libs/mathjs/9.3.2/math.min.js'></script>
```

上面代码放到head标签中即可

该插件方法集成在对象`math`上，请注意`math`不是`Math`

大写Math是内置的，math是插件

该插件功能较多，建议查看官网：[mathjs](https://mathjs.org/)

#### 方法

这里主要讲几个常用的api

#### 计算表达式结果

```js
math.evaluate('1 + 2 * 3') // 7
math.evaluate('(1 + 2) * 3') // 9
math.evaluate('1 + 2^2') // 5
math.evaluate('1 - sqrt(4)') // -1            sqrt(4)开平方根
```

#### 解决0.1+0.2问题

JS中的数字是用[IEEE 754 双精度 64 位浮点数](http://en.wikipedia.org/wiki/Floating_point#Internal_representation)来存储的，它由64位组成，这种方式当十进制小数的二进制表示的有限数字超过 52 位时，在 JavaScript 里是不能精确存储的，这时候就存在舍入误差

所以很多采用双精度64位浮点数方式存储数字的语言都是这个结果`0.1+0.2=0.30000000000000004`

此时可以用mathjs提供的大数字进行运算，就能解决这种问题

```js
math.config({
  number: 'BigNumber',
  precision: 64
})
math.evaluate('0.1+0.2').toString() // 0.3   
//此时evaluate返回是一个对象，想要得到能理解的结果，调用toString方法即可
```

#### 随机数

正常来说，原生`Math.random`只能随机0到1之间的数字，用起来很不方便

`math.random(min, max)`可随机指定区间的任意数字，min指定最小边界，max最大边界，区间为左闭又开

```js
math.random(1, 5) // 随机1到5区间任意数字
```

`math.randomInt(min, max)`，可随机指定区间的任意**整数**，min指定最小边界，max最大边界，区间为左闭又开

```js
math.randomInt(1, 5) // 随机1到5之间任意整数
```

#### 四舍五入

`math.round(浮点数，保留位数)`保留小数位四舍五入

```js
// 保留三位小数
math.round(3.1415926, 3) // 3.142  
```

原生`Math`上的方法在`mathjs`上也存在，功能基本一致。

## 日期对象

### 创建日期对象

```javascript
//Date() 当前电脑时间戳
console.log(Date())
let nowT = new Date() //new一个时间对象,可以接受参数来设置时间戳
console.log(nowT) //返回当前时间
let nowT = new Date(123456789) //这个参数是一个毫秒值 从1970年1月1日00:00:00开始加上这个一个毫秒值
let nowT = new Date("January 6,2014") //参数为日期字符串
let nowT = new Date(2019,5,1,19,30,50,20) //参数为多个整数包括:年 月 日 时 分 秒 毫秒  注意:这里的月份是从0开始的
let nowT = new Date("2019-5-1")
let nowT = new Date("2019/5/1")
//注意:字符串参数是时间节点 数字参数会默认为毫秒值
```

### 日期对象运算

```javascript
let nowT1 = new Date(2019,5,1)
let nowT2 = new Date()
console.log(nowT1 - nowT2) //得到的是一个毫秒值
console.log(nowT1 + nowT2) //字符串的拼接
```

### 日期对象的静态方法

```javascript
let nowT = Date.now() //返回当前事件距离1970年1月1日00:00:00之间的时间戳距离
let nowT = Date.parse(2019,5,1) //接收一个日期字符串 返回从1970-1-1 00:00:00到该日期的毫秒数
let noeT = Date.UTC(2019,5,1) //接收以逗号隔开的日期参数 返回从1970-1-1 00:00:00到该日期的毫秒数 接收的月份是0-11
```

### 日期格式化方法

1. toDateString() 返回的是星期 月 日 年

   ```javascript
   let nowT = new Date()
   let Time = nowT.toDateString()
   console.log(Time)
   ```

2. toTimeString() 返回的是时 分 秒 时区

   ```javascript
   let nowT = new Date()
   let Time = nowT.toTimeString()
   console.log(Time)
   ```

3. toLocaleDateString() 返回的是年 月 日

   ```javascript
   let nowT = new Date()
   let Time = nowT.toLocaleDateString()
   console.log(Time)
   ```

4. toLocaleTimeString() 返回本地时 分 秒

   ```javascript
   let nowT = new Date()
   let Time = nowT.toLocaleTimeString()
   console.log(Time)
   ```

5. toUTCString() 返回对应的UTC时间 也就是国际标准时间 比北京晚8个小时

   ```javascript
   let nowT = new Date()
   let Time = nowT.toUTCString()
   console.log(Time)
   ```

6. toLocaleString() 返回本地时间

   ```javascript
   let nowT = new Date()
   let Time = nowT.toLocaleString()
   console.log(Time)
   ```

### 日期方法

1. getTime() 返回一个毫秒值 到时间零点的距离
2. getFullYear() 返回年
3. getMonth() 返回月 注意:得到的月份是从0开始 要返回当前月需要加1
4. getDate() 返回日期
5. getHours() 返回小时
6. getMinutes() 返回分钟
7. getSeconds() 返回秒
8. getDay() 返回星期
9. getTimezoneOffset() 返回是当前事件与UTC的时区差异 以分钟数表示(考虑夏令营时)

### 获取当前时间

```javascript
let nowT = setInterval(()=>{
    let oWrap = document.getElementById("wrap")
    let date = new Date(),
    	oYear = date.getFullYear(),
    	oMonth = date.getMonth(),
    	oDate = date.getDate(),
    	oHours = date.getHours(),
    	oMinut = date.getMinutes(),
    	oSecond = date.getSeconds(),
    	oDay = date.getDay(),
    	aDayArr = ["日","一","二","三","四","五","六"];
    oWrap.innerHTML = `现在的时间是${oYear}年${oMonth}月${oDate}日,星期${aDayArr[oDay]},${oHours}时${oMinut}分${oSecond}秒`
},1000)

let add0 = n => n=n<10?"0"+n:n+""
```

### 第三方插件：date.js

#### 安装

Datejs是一个用来操作日期的库，官方网站为[datejs.com](http://www.datejs.com/)。

下载后插入网页，就可以使用。

```html
<script src="https://cdn.bootcdn.net/ajax/libs/datejs/1.0/date.min.js"></script>
```

官方还提供多种语言的版本，可以选择使用。

```html
// 美国版
<script type="text/javascript" src="date-en-US.js"></script>

// 中国版
<script type="text/javascript" src="date-zh-CN.js"></script>
```

#### 方法

Datejs在原生的Date对象上面，定义了许多语义化的方法，可以方便地链式使用。

#### 日期信息

```js
Date.today() // 返回当天日期，时间定在这一天开始的00:00 

Date.today().getDayName() // 今天是星期几

Date.today().is().friday()      // 今天是否为星期五，返回true或者false
Date.today().is().fri()         // 等同于上一行

Date.today().is().november()    // 今天是否为11月，返回true或者false
Date.today().is().nov()         // 等同于上一行

Date.today().isWeekday() // 今天是否为工作日（周一到周五）
```

#### 日期的变更

```js
Date.today().next().friday()    // 下一个星期五
Date.today().last().monday()    // 上一个星期一

new Date().next().march()       // 下个三月份的今天
new Date().last().week()        // 上星期的今天

Date.today().add(5).days() // 五天后

Date.friday() // 本周的星期五

Date.march() // 今年的三月

Date.january().first().monday() // 今年一月的第一个星期一

Date.dec().final().fri() // 今年12月的最后一个星期五

// 先将日期定在本月15日的下午4点30分，然后向后推90天
Date.today().set({ day: 15, hour: 16, minute: 30 }).add({ days: 90 })

(3).days().fromNow() // 三天后

(6).months().ago() // 6个月前

(12).weeks().fromNow() // 12个星期后

(30).days().after(Date.today()) // 30天后
```

#### 日期的解析

```js
Date.parse('today')
 
Date.parse('tomorrow')
 
Date.parse('July 8')

Date.parse('July 8th, 2007')

Date.parse('July 8th, 2007, 10:30 PM')

Date.parse('07.15.2007')
```

#### 获取想要的格式

```js
// 想要拿到当前时间的格式：2021-05-22 17:00:00
new Date().toString('yyyy-MM-dd HH:mm:ss')
```

#### 参数写法参考

| Format | Description                                                  | Example                   |
| ------ | ------------------------------------------------------------ | ------------------------- |
| s      | The seconds of the minute between 0-59.                      | `0` to `59`               |
| ss     | The seconds of the minute with leading zero if required.     | `00` to `59`              |
| m      | The minute of the hour between 0-59.                         | `0` or `59`               |
| mm     | The minute of the hour with leading zero if required.        | `00` to `59`              |
| h      | The hour of the day between 1-12.                            | `1` to `12`               |
| hh     | The hour of the day with leading zero if required.           | `01` to `12`              |
| H      | The hour of the day between 0-23.                            | `0` to `23`               |
| HH     | The hour of the day with leading zero if required.           | `00` to `23`              |
| d      | The day of the month between 1 and 31.                       | `1` to `31`               |
| dd     | The day of the month with leading zero if required.          | `01` to `31`              |
| ddd    | Abbreviated day name. Date.CultureInfo.abbreviatedDayNames.  | `Mon` to `Sun`            |
| dddd   | The full day name. Date.CultureInfo.dayNames.                | `Monday` to `Sunday`      |
| M      | The month of the year between 1-12.                          | `1` to `12`               |
| MM     | The month of the year with leading zero if required.         | `01` to `12`              |
| MMM    | Abbreviated month name. Date.CultureInfo.abbreviatedMonthNames. | `Jan` to `Dec`            |
| MMMM   | The full month name. Date.CultureInfo.monthNames.            | `January` to `December`   |
| yy     | Displays the year as a two-digit number.                     | `99` or `07`              |
| yyyy   | Displays the full four digit year.                           | `1999` or `2007`          |
| t      | Displays the first character of the A.M./P.M. designator. Date.CultureInfo.amDesignator or Date.CultureInfo.pmDesignator | `A` or `P`                |
| tt     | Displays the A.M./P.M. designator. Date.CultureInfo.amDesignator or Date.CultureInfo.pmDesignator | `AM` or `PM`              |
| S      | The ordinal suffix of the current day.                       | `st`, `nd`, `rd`, or `th` |

# Class面向对象

## 用法

**class跟let、const一样：不存在变量提升、不能重复声明...**

es5面向对象写法跟传统的面向对象语言（比如 C++ 和 Java）差异很大，很容易让新学习这门语言的程序员感到困惑。

ES6 提供了更接近传统语言的写法，引入了 Class（类）这个概念，作为对象的模板。通过`class`关键字，可以定义类。

ES6 的`class`可以看作只是一个语法糖，它的绝大部分功能，ES5 都可以做到，新的`class`写法只是让对象原型的写法更加清晰、更像面向对象编程的语法而已。

```js
//es5
function Fn(x, y) {
  this.x = x;
  this.y = y;
}

Fn.prototype.add = function () {
  return this.x + this.y;
};
//等价于
//es6
class Fn{
  constructor(x,y){
    this.x = x;
    this.y = y;
  }
  
  add(){
    return this.x + this.y;
  }
}

var F = new Fn(1, 2);
console.log(F.add()) //3
```

构造函数的`prototype`属性，在 ES6 的“类”上面继续存在。事实上，类的所有方法都定义在类的`prototype`属性上面。

```js
class Fn {
  constructor() {
    // ...
  }

  add() {
    // ...
  }

  sub() {
    // ...
  }
}

// 等同于

Fn.prototype = {
  constructor() {},
  add() {},
  sub() {},
};
```

类的内部所有定义的方法，都是不可枚举的（non-enumerable），这与es5不同。

```js
//es5
var Fn = function (x, y) {
  // ...
};

Point.prototype.add = function() {
  // ...
};

Object.keys(Fn.prototype)
// ["toString"]
Object.getOwnPropertyNames(Fn.prototype)
// ["constructor","add"]

//es6
class Fn {
  constructor(x, y) {
    // ...
  }

  add() {
    // ...
  }
}

Object.keys(Fn.prototype)
// []
Object.getOwnPropertyNames(Fn.prototype)
// ["constructor","add"]
```

## 严格模式

类和模块的内部，默认就是严格模式，所以不需要使用`use strict`指定运行模式。只要你的代码写在类或模块之中，就只有严格模式可用。

考虑到未来所有的代码，其实都是运行在模块之中，所以 ES6 实际上把整个语言升级到了严格模式。

## constructor

`onstructor`方法是类的默认方法，通过`new`命令生成对象实例时，自动调用该方法。一个类必须有`constructor`方法，如果没有显式定义，一个空的`constructor`方法会被默认添加。

```js
class Fn {
}

// 等同于
class Fn {
  constructor() {}
}
```

`constructor`方法默认返回实例对象（即`this`），完全可以指定返回另外一个对象。

```js
class Foo {
  constructor() {
    return Object.create(null);
  }
}

new Foo() instanceof Foo
// false
//constructor函数返回一个全新的对象，结果导致实例对象不是Foo类的实例。
```

## 类必须使用new调用

类必须使用`new`调用，否则会报错。这是它跟普通构造函数的一个主要区别，后者不用`new`也可以执行。

```js
class Foo {
  constructor() {
    return Object.create(null);
  }
}

Foo()
// TypeError: Class constructor Foo cannot be invoked without 'new'
```

## Class 表达式

与函数一样，类也可以使用表达式的形式定义。

```js
const MyClass = class Me {
  getClassName() {
    return Me.name;
  }
};
```

上面代码使用表达式定义了一个类。需要注意的是，这个类的名字是`MyClass`而不是`Me`，`Me`只在 Class 的内部代码可用，指代当前类。

```js
let inst = new MyClass();
inst.getClassName() // Me
Me.name // ReferenceError: Me is not defined
```

如果类的内部没用到的话，可以省略`Me`，也就是可以写成下面的形式。

```js
const MyClass = class { /* ... */ };
```

采用 Class 表达式，可以写出立即执行的 Class。

```js
let person = new class {
  constructor(name) {
    this.name = name;
  }

  sayName() {
    console.log(this.name);
  }
}('张三');

person.sayName(); // "张三"
```

上面代码中，`person`是一个立即执行的类的实例。

## 私有方法和私有属性

私有方法/私有属性是常见需求，但 ES6 不提供，只能通过变通方法模拟实现。（以后会实现）

通常是在命名上加以区别。

```js
class Fn {

  // 公有方法
  foo () {
    //....
  }

  // 假装是私有方法（其实外部还是可以访问）
  _bar() {
    //....
  }
}
```

## 原型的属性

class定义类时，只能在constructor里定义属性，在其他位置会报错。

如果需要在原型上定义方法可以使用：

1. Fn.prototype.prop = value;
2. Object.getPrototypeOf()获取原型，再来扩展
3. Object.assign(Fn.prototype,{在这里面写扩展的属性或者方法})

## Class 的静态方法

类相当于实例的原型，所有在类中定义的方法，都会被实例继承。

如果在一个方法前，加上`static`关键字，就表示该方法不会被实例继承，而是直接通过类来调用，这就称为“静态方法”。

ES6 明确规定，Class 内部只有静态方法，没有静态属性。

```js
class Foo {
  static classMethod() {
    return 'hello';
  }
}

Foo.classMethod() // 'hello'

var foo = new Foo();
foo.classMethod()
// TypeError: foo.classMethod is not a function

//静态属性只能手动设置
class Foo {
}

Foo.prop = 1;
Foo.prop // 1
```

## get、set

存值函数和取值函数，不多说，看代码

```js
class Fn{
	constructor(){
		this.arr = []
	}
	get bar(){
		return this.arr;
	}
	set bar(value){
		this.arr.push(value)
	}
}


let obj = new Fn();

obj.menu = 1;
obj.menu = 2;

console.log(obj.menu)//[1,2]
console.log(obj.arr)//[1,2]
```

## 继承

### 用法

```js
class Fn {
}

class Fn2 extends Fn {
}
```

### 注意

1. 子类必须在`constructor`方法中调用`super`方法，否则新建实例时会报错。这是因为子类没有自己的`this`对象，而是继承父类的`this`对象，然后对其进行加工。如果不调用`super`方法，子类就得不到`this`对象。

```js
class Point { /* ... */ }

class ColorPoint extends Point {
  constructor() {
    super()//必须调用
  }
}

let cp = new ColorPoint(); // ReferenceError
```

1. 父类的静态方法也会被继承。

> 嗯！就是这么让人绝望

## Object.getPrototypeOf()

`Object.getPrototypeOf`方法可以用来从子类上获取父类。

```js
Object.getPrototypeOf(Fn2) === Fn
// true
```

因此，可以使用这个方法判断，一个类是否继承了另一个类。

## super 关键字

```
super方法就是用来创建父类this对象的。 如果子类没有定义constructor方法，constructor方法会被默认创建，并默认调用super函数
```

`super`这个关键字，既可以当作函数使用，也可以当作对象使用。在这两种情况下，它的用法完全不同。

第一种情况，`super`作为函数调用时，代表父类的构造函数。ES6 要求，子类的构造函数必须执行一次`super`函数。

> 作为函数时，`super()`只能用在子类的构造函数之中，用在其他地方就会报错。

```js
class A {}

class B extends A {
  constructor() {
    super();
  }
}
```

上面代码中，子类`B`的构造函数之中的`super()`，代表调用父类的构造函数。这是必须的，否则 JavaScript 引擎会报错。

注意，`super`虽然代表了父类`A`的构造函数，但是返回的是子类`B`的实例，即`super`内部的`this`指的是`B`，因此`super()`在这里相当于`A.prototype.constructor.call(this)`。

第二种情况，`super`作为对象时，在普通方法中，指向父类的原型对象；在静态方法中，指向父类。

```js
class A {
  p() {
    return 2;
  }
}

class B extends A {
  constructor() {
    super();
    console.log(super.p()); // 2
  }
}

let b = new B();
```

上面代码中，子类`B`当中的`super.p()`，就是将`super`当作一个对象使用。这时，`super`在普通方法之中，指向`A.prototype`，所以`super.p()`就相当于`A.prototype.p()`。

由于`this`指向子类，所以如果通过`super`对某个属性赋值，这时`super`就是`this`，赋值的属性会变成子类实例的属性。

```js
class A {
  constructor() {
    this.x = 1;
  }
}

class B extends A {
  constructor() {
    super();
    this.x = 2;
    super.x = 3;
    console.log(super.x); // undefined
    console.log(this.x); // 3
  }
}

let b = new B();
```

上面代码中，`super.x`赋值为`3`，这时等同于对`this.x`赋值为`3`。而当读取`super.x`的时候，读的是`A.prototype.x`，所以返回`undefined`。

### 