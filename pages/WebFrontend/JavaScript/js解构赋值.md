---
title: js解构赋值
date: 2022-08-18 23:39:39.0
updated: 2023-05-01 18:38:47
categories: 
- WebFrontend
tags: 
- javascript
---

# 解构赋值

结构赋值:ES6 允许按照一定模式，从数组和对象中提取值，对变量进行赋值，这被称为解构

## 一. 数组的结构赋值

### 1. 理解解构赋值

非常有用,特别在数据交互,ajax的时候,非常完美.

在ES 5中,我们想定义多个变量,同时各这些变量赋值我们可以多次声明,也可以一次声明

```js
// 多次声明
var a = 12;
var b = 5;
var c = 6;

// 一次声明过个变量
var a = 12,
	b = 5,
	c = 6;
```

在ES 6中,我们也可以采用一次声明多个变量

```js
let a = 12,
	b = 5,
	c = 6;
console.log(a,b,b);
```

但是你会发现很散,不够整齐划一,有的时候 我们需要把值存在数组中.

```js
let arr = [12,5,6];
console.log(arr[0],arr[1],arr[2])
// 你会发现不好用,还不如console a,b,c呢
// 我就想console.log(a,b,c);怎么办

let [a,b,c] = [12,5,6];  //右边是你的数据,左边是你的结构
console.log(a,b,c);    // 12,5,6
```

这就是解构赋值.

本质上，这种写法属于“模式匹配”，只要等号两边的模式相同，左边的变量就会被赋予对应的值。

> #### 注意:
>
> 1. 左右两边,结构格式要保持一致

比如:

```js
let [a,b,c] = [12,[5,6]];  //右边是你的数据,左边是你的解构
console.log(a,b,c);   
// 此时结构不对,a就是12 b是一个数组[5,6], c没有解构到值就是undefined

//如果希望数据对应,则需要结构一样
let [a,[b,c]] = [12,[5,6]];
console.log(a,b,c);   //12 5 6

let [foo, [[bar], baz]] = [1, [[2], 3]];
foo // 1
bar // 2
baz // 3

let [ , , third] = ["foo", "bar", "baz"];
third // "baz"

let [x, , y] = [1, 2, 3];
x // 1
y // 3
```

### 2. 不成功的解构赋值

如果解构不成功，变量的值就等于`undefined`。

```js
let [foo] = [];
let [bar, foo] = [1];
//foo 都是undefined
```

需要被赋值的数量少于接收值的变量

### 3. 不完全解构

另一种情况是不完全解构，即等号左边的模式，只匹配一部分的等号右边的数组。这种情况下，解构依然可以成功。

```js
let [x, y] = [1, 2, 3];
x // 1
y // 2

let [a, [b], d] = [1, [2, 3], 4];
a // 1
b // 2
d // 4

//上面两个例子，都属于不完全解构，但是可以成功。
```

简单理解,就是要被赋值的值数量多于接收值变量的数量

### 4. 如果模式不匹配,那么会报错

```js
// 报错
let [foo] = 1;
let [foo] = false;
let [foo] = NaN;
let [foo] = undefined;
let [foo] = null;
let [foo] = {};
```

### 5. 默认值

我们刚说过,我们如果定义的变量比较多,而又没有给这个变量赋值,那么这个变量就是undefined,但是有的时候我们不希望他是undefined,我们希望他是一个值

解构赋值允许指定默认值。

正常靠谱的后台都会给值,但是就怕不靠谱的后台,怎么办,所有我想要定义一个默认值,后台有用后台的值,没有,用默认值,

```js
let [a,b,c = "暂无数据"] = ["aa","bb"];  
console.log(a,b,c);    //aa bb 暂无数据
// 发现此时c就是默认值"暂无数据"

// 如果有值,就使用后台的值
let [a,b,c = "暂无数据"] = ["aa","bb","cc"];  
console.log(a,b,c);    // aa bb cc

// 如果后台穿过来的是undefined,还是表示没有值,用默认值,
let [a,b,c = "暂无数据"] = ["aa","bb",undefined];  
console.log(a,b,c);    //aa bb 暂无数据

// 如果后台传过来的是一个null,表示有值,null表示一个空对象
let [a,b,c = "暂无数据"] = ["aa","bb",null];  
console.log(a,b,c);    //aa bb null
```

注意，ES6 内部使用严格相等运算符（`===`），判断一个位置是否有值。所以，如果一个数组成员不严格等于`undefined`，默认值是不会生效的。

#### 5.1 如果默认值是一个表达式

如果默认值是一个表达式，那么这个表达式是惰性求值的，即只有在用到的时候，才会求值。

```js
function f() {
  console.log('aaa');
}

let [x = f()] = [1];
//等价于
let x;
if ([1][0] === undefined) {
  x = f();
} else {
  x = [1][0];
}
```

#### 5.2 默认值可以引用解构赋值的其他变量,

前提是该变量必须是已经声明的

```js
let [x = 1, y = x] = [];     // x=1; y=1
let [x = 1, y = x] = [2];    // x=2; y=2
let [x = 1, y = x] = [1, 2]; // x=1; y=2
let [x = y, y = 1] = [];     // ReferenceError
//上面最后一个表达式之所以会报错，是因为x用到默认值y时，y还没有声明
```

### 6. 利用解构赋值交换两个值

交换两个值的位置

```js
let a = 12;
let b = 5;
[a,b] = [b,c];
console.log(a,b);  //5 12
// 这里利用数组有序的特性和解构赋值的方式,交互两个数
```

## 二. 对象的结构赋值

### 1. 对象解构赋值

解构不仅可以用于数组，还可以用于对象。

```js
let json = {
    name: "wuwei",
    age: 18,
    sex: "男"
}
let {name,age,sex} = json;
console.log(name,age,sex);  // wuwei 18 男
```

### 2. 对象解构赋值属性名必须相同

对象的解构与数组有一个重要的不同。数组的元素是按次序排列的，变量的取值由它的位置决定；而对象的属性没有次序，变量必须与属性同名，才能取到正确的值。

```js
// 这里解构的属性名必须和对象的属性名相同,否则解不出来就全是undefined

let {nam,ag,se} = json;
console.log(nam,ag,se);  // undefined undefined undefined
```

### 3. 自定义变量名与属性名不同

```js
// 如果想自己定义更改属性名可以如下操作

let {name:nam,age:ag,sex:se} = json; // 这样依然可以改属性名,并打印了解构的值
console.log(nam,ag,se);  //wuwei 18 男
```

也就是说，对象的解构赋值的内部机制，是先找到同名属性，然后再赋给对应的变量。真正被赋值的是后者，而不是前者。

实际上说明，对象的解构赋值是下面形式的简写

```js
let {name:name,age:age,sex:sex} = json; // 这样依然可以改属性名,并打印了解构的值
console.log(nam,ag,se);  //wuwei 18 男
```

### 4. 解构可以用于嵌套结构

```js
let obj = {
  p: [
    'Hello',
    { y: 'World' }
  ]
};

let { p: [x, { y }] } = obj;
x // "Hello"
y // "World"
```

### 5. 对象的解构赋值也可以指定默认值

```js
var {x = 3} = {};
x // 3

var {x, y = 5} = {x: 1};
x // 1
y // 5

var {x: y = 3} = {};
y // 3

var {x: y = 3} = {x: 5};
y // 5

var { message: msg = 'Something went wrong' } = {};
msg // "Something went wrong"
```

默认值生效的条件是，对象的属性值严格等于`undefined`。

```js
var {x = 3} = {x: undefined};
x // 3

var {x = 3} = {x: null};
x // null
```

### 6. 数组也可以按照对象的方式解构

由于数组本质是特殊的对象，因此可以对数组进行对象属性的解构。

```js
let arr = [1, 2, 3];
let {0 : first, [arr.length - 1] : last} = arr;
first // 1
last // 3
```

### 7. 注意点:

```js
let {a} = {a : "apple"};
console.log(a);  //apple

// 这么写没什么问题

// 但是有人喜欢先定义,先定义一个变量a,在去解构
let a; 
{a} = {a : "apple"};
console.log(a);  //报错
//Uncaught SyntaxError: Unexpected token =
// 你会发现报语法所处,因为 {a}是不是有块级作用域啊,=赋值就是有问题的

// 我们可以加括变成表达式
let a; 
({a} = {a : "apple"});
console.log(a);  //apple

// 发现这么写没任何问题,但是这么写的意义在哪里了,所有强烈不建议你们这么写
```

因为这个花括号被当成解构,一旦用不好,就会被当成块作用域

### 例子:

```js
function getPos(){
	//....
    return {
		left:10,
        bottom:20
	}
}
let {left,bottom} = getPos();
console.log(left,bottom);  // 10, 20

// 这里不敢用top,因为全局的top会被当成window对象.所以这个时候就取名就显得格外重要

function getPos(){
	//....
    return {
		left:10,
        top:20
	}
}
let {left,top:t} = getPos();
console.log(left,t); //10 20
// 如果使用使用top,这里在全局环境下可以使用解构自己定义名字的方式
```

## 三. 字符串的解构赋值

```js
const [a, b, c, d, e] = 'hello';
a // "h"
b // "e"
c // "l"
d // "l"
e // "o"
```

字符串也可以看做是类数组,因为有length属性

类似数组的对象都有一个`length`属性，因此还可以对这个属性解构赋值。

```js
let {length : len} = 'hello';
len // 5
```

说明类数组可以按照正常的数组和对象方式解构

## 四.函数参数的解构赋值:

### 1. 函数参数的解构

```js
function add([a,b]){
  return a+b;
}
add([2,3])//5

function fn({a,b}){
	console.log(a,b); //1 2
}
fn({
	a: 1,
    b: 2
})
```

### 2. 函数参数解构的默认值

函数参数的解构也可以使用默认值。

```js
function move({x = 0, y = 0} = {}) {
  return [x, y];
}

move({x: 3, y: 8}); // [3, 8]
move({x: 3}); // [3, 0]
move({}); // [0, 0]
move(); // [0, 0]
```

### 3. 参数默认值的注意事项

```js
function move({x, y} = { x: 0, y: 0 }) {
  return [x, y];
}

move({x: 3, y: 8}); // [3, 8]
move({x: 3}); // [3, undefined]
move({}); // [undefined, undefined]
move(); // [0, 0]
```

上面代码是为函数`move`的参数指定默认值，而不是为变量`x`和`y`指定默认值，所以会得到与前一种写法不同的结果。

## 五. 数值和布尔值的解构赋值

解构赋值时，如果等号右边是数值和布尔值，则会先转为对象。

```js
let {toString: s} = 123;
s === Number.prototype.toString // true

let {toString: s} = true;
s === Boolean.prototype.toString // true
```

## 六. 关于圆括号的影响

解构赋值虽然很方便，但是解析起来并不容易。对于编译器来说，一个式子到底是模式，还是表达式，没有办法从一开始就知道，必须解析到（或解析不到）等号才能知道。

由此带来的问题是，如果模式中出现圆括号怎么处理。ES6 的规则是，只要有可能导致解构的歧义，就不得使用圆括号。

但是，这条规则实际上不那么容易辨别，处理起来相当麻烦。因此，建议只要有可能，就不要在模式中放置圆括号。

### 1. 不能使用圆括号的情况

以下三种解构赋值不得使用圆括号。

#### 1.1 变量声明语句

```js
// 全部报错
let [(a)] = [1];

let {x: (c)} = {};
let ({x: c}) = {};
let {(x: c)} = {};
let {(x): c} = {};

let { o: ({ p: p }) } = { o: { p: 2 } };
```

#### 1.2 函数的参数

函数参数也属于变量声明，因此不能带有圆括号。

```js
// 报错
function f([(z)]) { return z; }
// 报错
function f([z,(x)]) { return x; }
```

#### 1.3 赋值语句的模式

```js
// 全部报错
({ p: a }) = { p: 42 };
([a]) = [5];
//上面代码将整个模式放在圆括号之中，导致报错。
// 报错
[({ p: a }), { x: c }] = [{}, {}];
```

### 2. 可以使用圆括号的情况

可以使用圆括号的情况只有一种：赋值语句的非模式部分，可以使用圆括号。

```js
[(b)] = [3]; // 正确
({ p: (d) } = {}); // 正确
[(parseInt.prop)] = [3]; // 正确
```

上面三行语句都可以正确执行，因为首先它们都是赋值语句，而不是声明语句；其次它们的圆括号都不属于模式的一部分。第一行语句中，模式是取数组的第一个成员，跟圆括号无关；第二行语句中，模式是`p`，而不是`d`；第三行语句与第一行语句的性质一致。

## 七.解构的用途

1. 除了可以一次定义多个变量
2. 还可以让函数返回多个值
3. 可以方便地让函数的参数跟值对应起来
4. 提取json数据
5. 函数参数的默认值

## 八.函数默认值