---
title: js(学习日志)
date: 2022-08-20 18:31:22.0
updated: 2022-10-27 00:11:11.794
url: /archives/js-xue-xi-ri-zhi-
categories: 
- WebFrontend
tags: 
- javascript
---

## day01-开班典礼

## day02-基础知识

### js代码书写位置

~~~html
<!-- 
        js的书写位置
        - 页面的 script 标签书写
        - 外部js文件引入
            1. 需要提前准备好一个js的文件
            2. 通过script标签的src引入
        - 标签内书写js代码
            不推荐使用
     -->
     <!-- script 书写 -->
    <script>
        //js代码书写位置
        console.log('hello word')
    </script>

    <!-- 老版本的script引入方式 -->
    <script type="text/javascript" >
        console.log('hello word')
    </script>

    <!-- 写法 -->
    <script language="javascript">
         console.log('hello word')
    </script>


    <!-- 外部js文件引入 -->
    <script src="./bendi.js">
        // 外部引入文件的js 标签内是不允许再书写js代码的
        console.log('我是外部js标签内的代码')//不能识别
    </script>
~~~

### 简单交互行为

~~~html
 //弹窗功能 alert(msg)  msg你需要弹出的内容
// alert('你好 嘻嘻嘻')

//确认弹窗 跟普通弹窗一样, 知识多了个选项,可以选择确定或者取消confirm(qus) qus 需要用户确认的内容 也是一个字符串
//confirm('你确定要进入这个网站吗')

        /* 
            prompt(msg,default) 
            msg : 给用户的提示语
            default : 默认值
            带有交互确认弹窗, 用于收集用户信息的弹窗
        */

//prompt('你今年多大了?',18)

//打印日志, 打印的内容会在控制台中展示通常用于代码调试
//console.log('打印的内容')
~~~

### js的代码结构

~~~
    /* 
        语句
        语句就是我们刚才所看到的 console.log() alert() 就是所有的语句
        一句代码就是一条语句

        分号
        分号作为代码结束的标识符
        但是分号不是必须加的  js 会隐式的将换行理解为分号

        大部分情况下都是可以不加分号的 
        看一个特殊情况
        alert(3 +
    3)  进行运算的时候 换行不会被解析为分号

        必须加分号的情况

        养成加分号的习惯


        注释的写法
        注释的作用 方便多人协作, 写注释后期你还能知道自己在干嘛
        单行注释
            写法 //需要注释的代码 快捷键 是 ctrl + /  command+/
        多行注释
            书写方式 /* * /  快捷键  可以自己设置, 设置---快捷键--搜索注释  默认是 shift+alt+a
            需要注意多行注释里面不能再嵌套多行注释
            
    */
    //alert('hello world')

    // alert('hello');
    // alert('world');

    // alert('hello')  
    // alert('world')
    // alert(3 +
    // 3)


    //必须加分号的情况
    // alert('接下来给大家表演弹出123');
    // [1,2,3].forEach(alert);

    // alert('接下来给大家表演弹出123')[1,2,3].forEach(alert);

    /* 
        undefined[1,2,3].forEach(alert);
    */
~~~

### 严格模式

~~~html
 'use strict';
    /* 
        开启严格模式 
        开启方式 在js代码的最顶层写上 'use strict';
        开启严格模式以后代码就会按照最新的标签去解析
    */

    // x = 123
    // console.log(x) //非严格模式下可以访问 x
    // console.log(x) //严格模式下会报错 报错x未定义


    // function fn(){
    //     console.log(this) //非严格模式是 window 对象
    //     console.log(this) // 严格模式下 this 等于 undefined
    // }
    // fn()
~~~

### 变量

~~~html
'use strict';
    /* 
        变量
        在做开发的时候我们可能会遇到的一些项目
        1. 开发一个游戏 
            1.1 应该有每个英雄的基本信息 ,生命值 , 护甲值.....
            1.2 还需要用到 攻击力, 防御力的变化
            1.3 装备系统
        2. 开发个聊天软件
            2.1 考虑用户的信息
            2,2 用户发送的信息
        3. 开发个网上商城
            3.1 商品信息
            3.2 商品价格
            3.3 用户信息
    */

    //创建一个容器来存储留言信息  
    //在js中存储信息靠的就是变量  变量也称为标识符
    //创建变量  需要用到关键词 let
    //创建
    let message; //创建了一个名字叫message的变量

    //存储数据
    message = '你好' //变量赋值操作, 为message变量存储数据
    message = '嘻嘻嘻'

    console.log('你好')
    console.log(message) //嘻嘻嘻

    //创建一个生命值的变量
    //创建变量的同事进行赋值
    let hp = 100
    //修改变量的值
    hp = 90
    console.log(hp) // 90


    //变种写法
    // let user = 'wuxian';
    // let age = 19;
    // let sex = '男';
    //简写
    // let user = '七喜',age = 50,sex = '女';

    // let user = '七喜'
    // ,age = 50
    // ,sex = '女';

    //先创建再赋值
    // let user,age,sex;
    // user = '七喜';
    // age = 19;
    // sex = '女'
    // console.log(user,age,sex)



    //老版本创建变量的方式 var 用法和let 一模一样  不推荐使用
    // console.log(age) //undefined
    // var age = 19
    // var age = 18
    // console.log(age)

    //let 不允许声明前调用也不允许重复声明
    // console.log(goudan) //报错
    // let goudan = '狗蛋';
    // let goudan = '狗蛋';

    // console.log(goudan)

    /* 
        变量命名的规范
        1. 变量名称只能包含数字,字母符号,$和,_
        2. 首字母必须是非数字
        3. 严格区分大小写, 不能使用关键词(保留词)
        4. 见名知意

        优秀的命名
        如果命名包含多个单词 通常采用驼峰命名的规则命名,驼峰的规则就是首个单词字母小写后续单词的首字母统一大写
        userName
        productPic
        myVeryGoodName
        backgroundColor
        
    */

    //正确的示范
    let _age,$123,abcd,goudan,你好;
    // console.log(你好)

    //错误的示范
    // let 1age,max-age,(sex,let,window,return,***;
~~~

### 常量

~~~
    'use strict';
        
    /* 
        1. 使用变量
        要求
        1 声明两个变量 admin 和 name
        2.将值 无限 赋值给 name
        3. 从name变量中将值拷贝给 admin
        4. 使用弹窗alert 显示出 admin 的值


        2. 根据需求自定义一个优秀的命名
        1. 将我们所居住的星球创建一个变量 
        2. 创建一个用于存储当前浏览者的名称 
    */
~~~

## day03-数据类型

###  专业术语

~~~html
    'use strict';
    /* 
        数据类型
        数据类型值得是一门语言中对不同的数据的划分, 在js中有8种数据类型
        数据类型可以分为两类
        - 基本类型(值类型)
        - 引用类型(对象类型)
    */

    // 语句 字面量 表达式
    let age = 18;
    age = 18 + 1 ;
    /* 
        let age = 18;
        let 变量声明 
        age 变量标识符
        =  赋值操作
        18 字面量 常见的就是数值字面量 字符串字面量 等等..

        18 + 1  表达式 , 表达式通常为一个运算公式或者一个函数执行,最终表达式一定会得到一个结果 赋值给变量

        语句   let age = 18; 完整的一条代码就是一条语句
        还有 if for流程控相关的都成为语句
    */
~~~

### 基础类型之数值

~~~js
    'use strict';
    /* 
        数据类型
        数据类型值得是一门语言中对不同的数据的划分, 在js中有8种数据类型
        数据类型可以分为两类
        - 基本类型(值类型)
        - 引用类型(对象类型)
    */

    //Number 类型 
    /* 
        Number 类型表示一个数值类型,在js中数值类型是不区分整数,浮点数的统一都叫number 类型,一切数字都是数值类型(十进制,二进制,十六进制)指数类型
    */

    //创建一个数值类型
    //字面量创建数值类型
    let integer = 666 //创建了一个十进制的整数数值类型
    let decimal = 3.1415 //创建了一个小数的数值类型

    //通过内置方法创建数值
    let num = Number(10) 

    //内置方法的应用
    // let userAge = prompt('你今年多大',19)
    // let user_age = Number(userAge)

    //一些列的进制展示 , 0b开头表示他是一个二进制的数值, 0x开头表示他是一个十六进制的数值, 0o开头表示他是一个8进制的数值
    //存储可以用进制存储, 但是在页面中展示一定是会被转换为十进制展示的
    let bin = 0b1101  //13 对应的二进制
    let hex = 0xa3 // 163 对应的十六进制
    let bahe = 0o12 //10 的八进制    
    let index = 5e6 //e表示指数 表示5*10的6次方


    /* 
        关于小数的问题
        js中小数计算的时候会被转为二进制进行存储所以在计算的时候可能会出现计算误差的情况
    */
    let result = 0.1 + 0.2 //0.30000000000000004

    //解决方法, 让小数转换为整数再进行计算
    let result2 = (0.1*100 + 0.2*100) / 100

    /* 
        特殊数值 
        除了常见的数值类型的以外js中还存在两个特殊的数值类型
        - infinity
            表示一个无穷大的数值,在js存储数据标准的问题, 在存储数据的时候如果存储的数值超过他能存储的最大范围就会出现正向溢出反之则是反向溢出, js中能展示的最大数值 为 2**1024
        - NaN
            not a number  表示一个不合法的数字,通常是由计算错误得到的结果
    */
    let maxNum = -(2**1024) //2的1024次方
    let jsMaxNum = Number.MAX_VALUE //最大值
    let num2 = 1 / 0 //Infinity
    let num3 = Infinity //Infinity 也可以作为值赋值给变量


    let res1 = '你好' / 2 //计算错误得到的结果就为 nan
    let res2 = NaN + 1 //只要是跟NaN进行就计算得到的结果永远都是NaN
    let nn = NaN //也可以用做值赋值给变量

    //console.log(NaN**0) //1 特殊情况 NaN的0次方等于1

    //js中的数学运算中有NaN这个值是非常好的一件事, 有他的存在就能保证在js中做数学运算他一定是非常安全的, 因为你无论怎么计算他都能得到一个结果不会报错,最坏的结果就是 NaN


    /* 
        最大安全整数值
        也是由于js存储数据的规则问题, 在js中会出现精度确实的问题, 当计算超出 2**53-1的值的时候, 再进行运算就会出现计算错误
        9007199254740991
    */

    let maxInt = 2**53-1//9007199254740991
    maxInt = maxInt + 2 //9007199254740992

    console.log(Number.MAX_SAFE_INTEGER)//9007199254740991
~~~

### 基础类型binint

```js
 'use strict';
    /* 
        bigint类型 超大整数类型
        由于最大安全整数的存在计算会出现精度确实, 所有es6以后引入了一个新的数据类型叫做bigint 专门用于超大的整数计算

        注意事项
        进行数学运算的时候必须两个值都为超大整数类型才可以计算
    */
   
    //创建方式 1. 字面量创建 在数值末尾加上一个n表示一个bigint类型
    let bigInt = 9007199254740991n // 123n

    //2 通过 内置方法创建 bigint
    let big2 = BigInt(2) // 2n

    let result = bigInt + big2 //9007199254740993n

    console.log(3 > big2) // 3 > 2n  可以跟基础数值类型做比较
```

### 基础类型string

~~~js
    'use strict';
    /* 
        String类型  字符串类型
        用于存储一段文字信息
        字面量创建有三种形式
        1. 单引号
        2. 双引号
        3. 反引号
    */
    
    //创建方式1  字面量方式创建
    let str = '你好'
    let str1 = "嘻嘻嘻"
    let str2 = `你好你好嘻嘻嘻`

    //反引号也称为模板字符串(功能扩展引号) 他跟普通的引号有一定的区别, 模板字符串内可以通过 ${} 插入变量或者是表达式

    let myName = 'yaya';
    let age = 18;
    // alert(`大家好我叫 ${myName}`) //大家好我叫yaya
    // alert(`大家好我叫 ${myName},我今年${age+1}岁`) //大家好我叫yaya
    // alert("大家好我叫 ${myName}") //大家好我叫 ${myName}

    //+ 号在于字符串运算的时候会进行字符串的拼接
    let result = '大家好我叫' + myName + '我今年'+(age+1)+'岁'


    //引号嵌套引号的情况 的解决方法
    let str3 = '鲁迅说:"今年很开心"';
    let str4 = `'鲁迅说':"今年很开心"`;
    //使用转移符号解决
    let str5 = '鲁迅说:\'今年很开心\'';

    /* 
        转移符号的扩展
        \ 普通的转移符号
        \n 表示换行符
        \r 表示回车符
        \t 表示一个制表符
        \b 表示一个退格符
        \f 表示换页符号
    */
~~~

### 基础类型boolean类型

~~~js
    'use strict';
    /* 
        Boolean 类型（布尔值类型 || 逻辑类型）
        该数据类型里面一共就两个值 true 和 false 
        这种类型的值通常用语表示 yes 或者no , true 表示正确 ,false表示失败
    */
   
    //创建布尔值
    let bool = true
    let bool2 = false

    //内置方法创建
    let bool3 = Boolean(true)

    //应用场景 ,通常用于记录一系列的状态
    let is180 = false

    //布尔值通常出现于数值比较的结果
    console.log(5 > 3) //true
~~~

### 基础类型null-undefined

~~~js
    'use strict';
    /* 
        null 类型 (值)
        null 类型存储的值只有一个null 他自己就是一个数据类型同时值也就他一个
        null 类型表示空对象或者是空值
        其他语言成为空指针

        应用场景就是用来释放内存
    */

    let age = null; //表示 age 存储的值是一个空值,或者是一个未知的值,通常情况null 的应用场景就是用来释放内存

    /* 
        undefined 类型(值)
        跟null一样自成一派,自己就是一个数据类型,值也就只有自己

        特殊值表示 值未被赋值 
        如果一个变量或者对象的属性创建了但是你没有为它赋值,那他默认就是undefined
    */

    let sex;
    // console.log(sex) //undefined
    // console.log(window.adsfsadf)//undefined

    let myName = 'xuxing';
    //过了一段时间不需要这个值了怎么处理
    myName = null;
~~~

### 基础类型symbol

~~~js
'use strict';
    /* 
        symbol 类型
        应用场景比较少,一般用于一些架构的设计,或者底层代码
        
        symbol类型的值是不可以进行运算的
        他的应用场景是用于创建一个独一无二的值
    */
   
    //创建方式
    let  s1 = Symbol() //创建一个独一无法的symbol数据
    let  s2 = Symbol() //创建一个独一无法的symbol数据
    // let  s3 = s1

    console.log(s1 === s2) //false

    /* Object 类型 引用类型, , 后续再探讨引用类型 */
~~~

### typeof运算符

~~~js
 'use strict';
    /* 
        typeof 运算符
        专用用于检测数据类型的运算符
        语法 typeof 需要检测的数据
    */

    console.log(typeof '23') //string
    console.log(typeof 12) //number
    console.log(typeof true) //boolean
    console.log(typeof 123n) //bigint
    console.log(typeof Symbol()) //symbol
    console.log(typeof undefined) //undefined
    

    //其他类型
    console.log(typeof null) //object  type判断null的结构是object这是一个typeof 的错误判断,问题源自js早期兼容问题保留下来的 null 绝对不是一个对象
    console.log(typeof alert) //function 判断alert得到的结果是 function 需要注意 function 不是一个数据类型他属于对象类型,这是一个非常好的错误

    console.log(typeof window) //object


    //typeof 的另一种写法 语法 typeof(需要检测的值)
    console.log(typeof(1))//number
~~~

## day04-类型转换与运算符

### 数据类型转换

~~~js
    'use strict';
    /* 
        数据类型转换
        
        大多数情况下运算和函数会自动的将值转换成不同的类型 比如 alert 会将传入的值转换为字符串
        还有prompt会将收集到的值也转换为字符串, 这种转换方式我们称为 隐式类型转换

        很多需求下我们是需要手动的将值转换为我们需要的一个数据类型 , 这时候就需要用一些特定的方法进行数据类型的转换, 这种转换方式我们称为 显示类型转换
    */

    // let age = prompt('你今年多大了',19)
    // console.log(typeof age) // string

    //需求是 增加用户的年龄增大一岁
    // console.log(age+1)//191

    //转换为字符串
    /* 
        将其他数据类型转换为字符串
    */

    let num = 5;
    console.log(typeof num)
    //将5数值转换为字符串
    // 语法 xx.toString()   xx 表示你需要进行转换的变量
    console.log(num.toString()) // 5
    console.log(NaN.toString()) // NaN
    console.log(Symbol().toString()) // Symbol()
    console.log(Infinity.toString()) // Infinity
    /* 
        toSting 有个问题就是不能转换 undefined 和 null , 转换就报错
    */
    // console.log(undefined.toString()) // 报错
    // console.log(null.toString()) // 报错

    /* 
        String(xx)  xx需要转换为字符串的值
    */

    console.log(String(123))
    console.log(String(undefined))//undefined
    console.log(String(null))//null

    /* 
        还可以通过 +号运算跟字符串做运算 也能转换为字符串
        进行+号运算的时候有个规则, 只要运算符两边有一个字符串就会进行字符串拼接
    */

    let und = undefined
    console.log(typeof und) // undefined
    und = und+''
    console.log(typeof und) //string

    let x = 100 + '' + 100 //100100
    let y = 100 + 100 + '' + 100 //200100
~~~

### 转换为数值类型

~~~js
    'use strict';
    /*
    转换为数值
    将其他类型转换为数值 

    - Number(value) value你需要转换为数值的值
    number一定会转换成数值,如果不是一个合法的数值或者特殊值那就直接转换为NaN

    特殊值, null 和 false在转为数值的时候会被转为0 , true在做转换的时候会被转换为 1
    undefined 转为数值为 NaN

    string 转为数值的时候如果他是一个合法的数值字符串是可以进行转换的
    什么是合法的数值字符串: 字符串掐头去尾(指的是去除开头和结束的空格字符串)剩下的都是数值字符串中间都没有空格的情况就为合法数值字符串

    空字符串转为数值等于 0
    */

    //合法的数值字符串
    let str = '123'
    console.log(typeof str)//string
    str = Number(str)
    console.log(typeof str)//number

    //不是一个合法的数值字符串
    let str1 = '123abc'
    str1 = Number(str1)// 123 A 1 B  NaN C

    //其他数据类型转换为字符串 
    // console.log(Number(Symbol()))
    //特殊值
    console.log(Number(undefined))//NaN
    console.log(Number(null))//0
    console.log(Number(false))//0
    console.log(Number(true))//1
    console.log(Number(''))//0

    //字符串的特殊情况
    console.log(Number('          123'))//123
    console.log(Number('          123    '))//123
    console.log(Number('          1 23    '))//NaN
~~~

### 转换为布尔值

~~~js
    'use strict';
    /* 
        转换为布尔值
        语法  Boolean(xx)  把xx的数据转换为布尔值
        布尔值的转换规则
        - 除了以下的6个值以外其他的所有值都转换为 true
        - '' 0 false null undefined NaN
    */

    let bool = true;
    let bool2 = Boolean()
    console.log(Boolean(1))//true
    console.log(Boolean(null))//false
    console.log(Boolean(5+3))// true
    console.log(Boolean([]))// true
    console.log(Boolean(sessionStorage))// true
    console.log(Boolean(NaN))// false
    console.log(Boolean(' '))// true
    console.log(Boolean(''+0))// true
    console.log(Boolean('0'))// true
    console.log(Boolean(3*'abc'))// false



    // console.log(Boolean(undefined))//false
    // console.log(Number(undefined))//NaN
~~~

### 运算符

~~~js
    'use strict';
    /* 
        js中的运算符一共有5中
        1. 算术运算符 + - * / ** /%
        2. 赋值运算符 = += -= *=
        3. 关系(比较)运算符 > < >= <= != 
        4. 逻辑运算符 && || ! ??
        5. 自增自减运算符  ++ -- 
    */

    /* 
        专业术语
        运算元  -- 运算元应用的对象 比如 乘法 3 * 4 里面就有两个运算元, 左运算元叫3 右运算元叫 4 , 大部分人称它为 参数
        一元运算符  运算符旁边只有一个运算元,就叫一元运算符  -5 +3
        二元运算符  运算符旁边有两个运算元就叫 二元运算 3 * 4  就是二元运算
    */

    let w = 100
    //希望将w取相反的负数
~~~

### 算术运算符

~~~js
    'use strict';
    /* 
        算术运算符 就是一个数学运算符号
        +
        -
        * 乘
        / 除
        ** 求幂
        % 取余

        运算规则
        加法的规则, 只有两边都是数值的时候才会进行数学加法运算,如果有一边为字符串就进行字符串拼接

        除了加法运算以为其他运算
        跟其他类型进行数学运算的时候 会优先加其他类型的值转换为数值再进行数学运算
        如果转换的值为nan那结果就一定是nan (nan 跟任何值做数学运算的时候结果都是nan)

        运算符优先级 : https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Operator_Precedence
    */
        
    console.log(3 % 5) //3
    console.log(5 % 3) //2
    console.log(5 / 3) //1.6666666666666667
    console.log(2**3) //8
    console.log(2**(1/3))//1.2599210498948732

    console.log(undefined+undefined)//NaN
    console.log(null+null,'null+null')//0 

    //二元运算的 加法
    //数值跟字符串做加法运算的情况
    console.log(5+'3')//53

    //数值跟数值做加法
    console.log(5+3)//8

    //跟特殊值运算
    console.log(5+null)//5
    console.log(5*'3') // 5 * 3 = 15
    console.log(5+4+'3') // 9+'3' = '93'
    console.log(3-true+'1') // 3-1+'1' = 2+'1' = '21'
    console.log(3+undefined*5-3) // NaN
    console.log('6'*'3') // 18
    console.log('5'+undefined)//5undefined

    //计算错误的情况 需要注意 跟 undefined 和 nan计算的时候得到的结构一定是nan
   
    console.log(+true) //一元运算会隐式的将运算符旁边的值转换为数值

    //应用场景
    let a = '4'
    let b = '5'
    //需求计算 a 加 b 的值 期望得到数值9

    // console.log(a+b)//'45'
    //方式一
    console.log(Number(a)+Number(b))//9

    //方式二 利用一元运算
    console.log(+a + +b)//9

    // let age = +prompt('今年多大')
    // console.log(typeof age) //number

    let res = (5 + 2) * 3
    console.log(res)//31
~~~

### 赋值运算符

~~~js
 'use strict';
    /* 
        赋值运算符 = 
        let x = 2+2 先计算2+2 在进行赋值运算 将4赋值给 x
    */

    let w = 7
    let x = 3
    let c = 11 - (w = x * 2)
    console.log(w) //? 6
    console.log(c) //? 11 - 6 = 5

    //链式赋值
    let a,b,d;
    //期望a和b和d 都相等都等于20
    //方案一
    // a = 20;
    // b = 20;
    // c = 20;
    // a = 20
    // b = a
    // d = b

    //链式赋值
    a = b = d = 20;

    //原地修改
    let money = 1000;

    //常规写法
    // money = money + 1000;

    //赋值并且修改 在原有值的基础上进行修改
    money += 1000 // ==> money = money + 1000;
    money += 1000 // ==> money = money + 1000;
    money *= 2 // ==> money = money * 2;
    money *= 5-2 // ==> money = money * 2;
~~~

### 数据类型总结

```html
 'use strict';
    /* 
        ### 总结
            JavaScript 中有八种基本的数据类型（译注：前七种为基本数据类型，也称为原始类型，而 `object` 为复杂数据类型）。

            -   `number` 用于任何类型的数字：整数或浮点数，在 `±(253-1)` 范围内的整数。
            -   `bigint` 用于任意长度的整数。
            -   `string` 用于字符串：一个字符串可以包含 0 个或多个字符，所以没有单独的单字符类型。
            -   `boolean` 用于 `true` 和 `false`。
            -   `null` 用于未知的值 —— 只有一个 `null` 值的独立类型。
            -   `undefined` 用于未定义的值 —— 只有一个 `undefined` 值的独立类型。
            -   `symbol` 用于唯一的标识符。
            -   `object` 用于更复杂的数据结构。

            我们可以通过 `typeof` 运算符查看存储在变量中的数据类型。

            -   通常用作 `typeof x`，但 `typeof(x)` 也可行。
            -   以字符串的形式返回类型名称，例如 `"string"`。
            -   `typeof null` 会返回 `"object"` —— 这是 JavaScript 编程语言的一个错误，实际上它并不是一个 `object`。
    */
```

## day05-运算符续集

### 自增自减运算

~~~js
    'use strict';
    /* 
        自增自减运算
        在原有的数值基础上增加1或者是减少1
    
        语法分为
         ++变量/--变量
        后置自增/自减  变量++ 前置自增/自减/变量--

        前置++ 和后置++的区别
        最终所实现的效果是一模一样的都是在原变量的基础上进行自增或者自减
        区别在于 后置++ 会将原变量变化前的值返回出来 
        前置++ 会将改变后的值返回出来

        前置++返回的是最新的值,后置++返回的是变化前一次的值
    */
   
    let num = 19
    //方式一
    // console.log(num+=1)
    //方式 后置++
    let addNum = num++ //后置自增运算
    console.log(num)//20
    num--
    console.log(num)//19

    //前置++
    ++num
    console.log(num) // 20


    let height = 150;//151 152 
    // console.log(height++)// 150 先进行赋值再去原有变量上进行+1
    // console.log(height++)// 151 先进行赋值再去原有变量上进行+1
    // console.log(height)// 152 先进行赋值再去原有变量上进行+1

    // console.log(++height)//151 先改变变量再进行赋值

    let age = 1
    let result = age++ + ++age * age++ ;
    /* 
        age = 4
        1 + 3 * 3
        1+9
        10
    */
    // console.log(19++) //报错, 自增自检只能用于变量

    let aa = 2
    let res = '5' + 3 * ++aa - 2 + aa++ + ++aa + '4';
    /* 
        aa =5
        '5' + 3 * 3 - 2 + 3 + 5 +'4'
        '5'+9-2 + 3 + 5 +'4'
        65+'4'
        654
    */
~~~

### 位运算

~~~js
 'use strict';
    /* 
        位运算
        位运算会先把运算元做成32位二进制来表示
        根据位运算符的规则进行进制的变化

        位运算
       **~ 按位非**
       **& 按位与**
       **| 按位或 ^ 按位异或**
       **>>> 无符号右移 >> 有符号右移**
    */

    let a = 12;
    let b = ~a;

    // 12的二进制表示：     00000000 00000000 00000000 00001100
    // 按位非得到最终结果： 11111111 11111111 11111111 11110011  

    //因为 第32位是1，代表负数，那这个负数是多少呢？按照上面的办法我们可以反推回来：
    //负数码减-1：         11111111 11111111 11111111 11110010
    //结果取反码：         00000000 00000000 00000000 00001101
    //表示的正数是：13，所以该负数为  -13

    // alert(b); //验证一下

    let c = 123.2564564565
    //去除小数
    console.log(~~c) // 123
~~~

### 逗号运算符

~~~js
    'use strict';
    /* 
        逗号运算符,

        逗号运算符可以将多条语句分隔开,每一条语句都会执行,并且会返回最后一个逗号执行的结果

        逗号运算符优先级非常低, 通常应用的时候都会加上括号
    */

    // let a = (1+2,3+4)//7

    // let b = 3 // 4 7
    // let c = 4
    // let d = (++b,b+=3,c+b)// 4 + 7
    // console.log(b,c,d) // 7 4 11



    // let a,b,c;
    // //高级用法
    // for (a=1,b=3,c=a*b; a < 10; a++,c=a*b) {
    //     console.log(c)
    // }
~~~

### 比较运算符

~~~js
    'use strict';
    /* 
        比较运算符用于比较两个值的大小 或者是关系
        用于做判断
        大于小于 > <
        大于等于小于等于 >= <=
        检测相等 == 一个等号表示赋值两个等号表示判断 a == b 表示a和b想不想等
        检测两个值不相等  在js中的表示形式为 !=  比如 a != b a是不是不等于b 

        比较运算符组成的表达式返回值永远是一个布尔值
        - ture 成立
        - false 不成立

        字符串之间的比较
        规则是根据字符串对应的 unicode 编码顺序(存储的值是一个数值)来进行比较
        如果是单个字符串之间的比较就直接比较他的编码顺序
        如果是多个字符串之间的比较
    */

    //数值之间的比较
    // console.log(2 > 1)//true
    // console.log(2 == 1)// flse
    // console.log(2 >= 2)// true
    // console.log(3 != 2)// true

    //字符串跟字符串比较
    // let a = 'abd'
    // let b = 'abcsdfafd'
    // console.log(a > b) //true
    // //获取unicode中对应的编码顺序
    // console.log(a.charCodeAt(2))
    // console.log(b.charCodeAt(2))

    //不同类型之间的比较
    //不同类型js会优先转为数值在进行比较
    // console.log(5 > '4') // 5 > 4 = true
    // //NaN 跟任何值做比较运算的时候得到的结果都为false
    // console.log('s4' > 5) // false
    // //Undefined 在做除了 == 判断的时候跟任何值做比较较运算都为false
    // console.log(undefined > 5) // false
    // console.log( 5 > true) // true


    /* 
        相等== 和 全等===
        js 在做比较的时候分为两种情况相等和全等
        相等就是只要长得一样那就相等
            相等的规则是优先将两个不同的类型转换为数值类型再做比较
        全等必须数据类型并且值一样才叫全等
    */
    // console.log(5 == '5')//true

    let a = 0
    // console.log(Boolean(a)) // false
    let b = '0'
    // console.log(Boolean(b)) //true
    // console.log(a == b)//true
    // console.log(true == 1)//true
    // console.log(true == '1')//true


    //全等比较
    // console.log('1' === '2')//false
    // console.log('1' === 1)//false

    //!= 表示不等于 跟相等的规则是一样的  !== 表示不全等于 规则跟全等一样的
    // console.log('1' != 1)//false
    // console.log('1' !== 1)//true


    //特殊情况
    // console.log(undefined == undefined)//true
    // console.log(NaN == NaN)//false

    // console.log(null == null)//true

    // console.log(undefined == null)//true js设计的时候认为两个值都表示空,所有在比较的时候就当做空来比较

    console.log(null > 0)//false
    console.log(null == 0)//false null在做相等比较的时候不会转换为数值
    console.log(null < 0)//false
    //做大于等于运算的时候 是优先进行大于的运算 null = 0 然后再做等于判断 0 == 0 true
    console.log(null >= 0)//true
    console.log(null <= 0)//true
~~~

### 逻辑运算符

~~~js
    'use strict';
    /* 
        逻辑运算符
        js中一共有四种逻辑运算
        || 或
        && 与
        ! 非
        ?? 空值合并

        逻辑运算符是可以用于任意的数据类型并不仅仅只有布尔值

        逻辑或 ||
        书写格式 a || b
        规则 在做逻辑运算的时候会临时将运算符两边的值转换为布尔值,再进行逻辑运算
        逻辑或运算的规则就是 逐个判断,找到第一个为true 的值然后就停止后续的判断直接返回 为 true 的值,如果都不为true就返回最有一个值 
    */

    let a = 'xixixi';
    let b = false
    // console.log(a || b) // true || false
    // console.log(1 || 0) // true || false = 1 
    // console.log(null || undefined || 18 || 24) // 18
    // console.log(null || undefined ) // undefined

    //应用场景  如果用户输入了名字就用他自己的名字,如果没有输入就用默认的昵称
    // let name = prompt('你叫什么名字?') || '狗蛋'

    // alert(`${name}登录成功`)

    /* 
        逻辑与
        书写方式 a && b
        规则临时转换为布尔值 依次判断 如果遇到结果为 false 的值,就停止计算并且返回第一个为false的值
        如果都为ture就返回最后ture
    */

    console.log(1 && 2 ) //2
    console.log(1 && 'xixixi' && undefined ) //undefined


    //例 判断的用户的年龄 如果满足18以上就给用户一个弹窗
    // let age = +prompt('你今年多大')

    // let result =  age > 18 && alert('恭喜你进入了这个网站')

    //优先级的问题,  在逻辑判断的时候 逻辑 && 比逻辑 || 优先级更高
    console.log(null || 2 && 3 || 4)
    /* 
        null || 3 || 4
        3
    */
    /* 
        逻辑非
        书写方式 !
        表示取反 非运算符得到的结果一定是一个布尔值
    */

    console.log(!'123') // false
    console.log(!!'123')//ture

     //应用场景 需要将ss 变量的值转换为布尔值
    let ss ='asdkfjhkasfd'
    console.log(Boolean(ss))
    console.log(!!ss)
~~~

### 类型转换与与运算符总结

#### 数据类型总结

有三种常用的类型转换：转换为 string 类型、转换为 number 类型和转换为 boolean 类型。

**字符串转换** —— 转换发生在输出内容的时候，也可以通过 `String(value)` 进行显式转换。原始类型值的 string 类型转换通常是很明显的。

**数字型转换** —— 转换发生在进行算术操作时，也可以通过 `Number(value)` 进行显式转换。

数字型转换遵循以下规则：

| 值        | 转换后                                                       |
| --------- | ------------------------------------------------------------ |
| undefined | NaN                                                          |
| null      | 0                                                            |
| true      | 1                                                            |
| false     | 0                                                            |
| string    | 去掉首尾空格后的纯数字字符串中含有的数字。如果剩余字符串为空，则转换结果为 0。否则，将会从剩余字符串中“读取”数字。当类型转换出现任何一个 非数字 时返回 `NaN `。 |

“按原样读取”字符串，两端的空白会被忽略。空字符串变成 `0`。转换出错则输出 `NaN`。

**布尔型转换** —— 转换发生在进行逻辑操作时，也可以通过 `Boolean(value)` 进行显式转换。

布尔型转换遵循以下规则： 除了 `0`, `null`, `undefined`, `NaN`, `""`

```
false
```

其他值都为

```
true
```

上述的大多数规则都容易理解和记忆。人值得注意的例子有以下几个：

- 对 `undefined` 进行数字型转换时，输出结果为 `NaN`，而非 `0`。
- 对 `"0"` 和只有空格的字符串（比如：`" "`）进行布尔型转换时，输出结果为 `true`。

我们在本小节没有讲 object 类型的转换。在我们学习完更多关于 JavaScript 的基础知识后，我们会在专门介绍 object

#### 算术运算小总结

- 如果一个侧为NaN，则结果为NaN
- 如果两侧都是数字，则进行加法运算
- 如果两侧都是字符串则进行字符串连接
- 如果一侧为字符串，另一侧是其他类型，则转成字符串之后，然后进行字符串连接
- `只要 + 旁边有一个为字符串就会变成字符串拼接`
- 除了加法以为其他的数学运算符都会转为数字进行计算，无法计算的都返回`NaN`

## day06-控制流程

### 空值合并运算

~~~js
 'use strict';
    /* 
        空值合并运算符
        语法 a ?? b
        空值合并是专门用于区分undefined 和 null 这两个特殊值的
        运算流程 如果当前不是undefined 和 null 就返回当前值,如果是undefined 和 null就继续下一次判断,如果都是undefined 和 null就返回最后一个结果
    */

    // console.log(undefined ?? 123)//123
    // console.log(undefined ?? null)//null
    // console.log(123 ?? null)//123
    // console.log(undefined ?? null ?? 456)//456
    // console.log(NaN ?? 123)//NaN


    //应用场景
    let userName = 0;

    //保护用户的昵称,如若用户没有输入昵称就给他个默认昵称
    console.log(userName || '默认昵称') //默认昵称
    console.log(userName ?? '默认昵称') //0


  
    let a = 0;
    let b;

    //计算他们的乘积 如果没有值就用默认值 1计算
    console.log(a ?? 1 * b ?? 1)//0
    console.log(a || 1 * b || 1) //1

    // 空值合并 不可以和逻辑运算 && || 一起运算
    // let xxx = 1 && (2 ?? 3);
~~~

### 流程控制语句

~~~js
    'use strict';
    /* 
        流程控制语句
        用于控制代码走向的语句
        1. 顺序结构
            代码从上到下执行
        2. 分支结构
            根据不同的情况执行不同的代码
        3. 循环结构
            重复的做某一些事情
    */
   /* 
        条件语句 if

        写法一
        if(表达式){
            代码块
        }
        如果表达式成立那就执行代码块里的代码

        写法二
        if(表达式){
            //条件满足代码块
        }else{
            //条件不满足执行的代码块
        }

        写法三
         if(表达式){
            //条件满足代码块
        }else if(){
            //第二次判断
        }else{

        }

        分支语句永远只会执行一个结果内的代码
    */

    //张三遇到一个喜欢的妹妹 ,追求妹妹 , 如果张三有 1000块钱就可以约到心意的妹妹出来吃饭
    let money = 5000 //张三的钱
    let key = false //是否有钻戒 true有false表示没有
    // if(money > 1000){
    //     console.log('约会成功')
    // }
    //如果约会不成功的话需要给出反馈比如骂张三一顿

    // if(money > 1000){
    //     console.log('约会成功')
    // }else{
    //     console.log('今天身体不舒服不去了')
    // }

    //张三要进行求婚 
    /* 
        求婚需要准备一个戒指
        还需要准备2w块钱
        1. 如果你有2w块钱就可以去求婚
        2. 如果你有5000块 并且 你有一个钻戒也可以考虑考虑
        3. 如果你5000都没有那就求婚失败
    */

    // if(money >= 20000){
    //     console.log('求婚成功')
    // }else if(money >= 5000 && key){
    //     console.log('考虑一下')
    // }else{
    //     console.log('求婚失败嘻嘻嘻')
    // }


    let grade = -120 //分数
    /* 
        考试评分 
        grade > 90 给出评分 A
        grade > 80 给出评分 B
        grade > 70 给出评分 C
        grade > 60 给出评分 D
        grade < 60 给出评分 E

        把最难实现的放到判断的最前面
    */

    //错误示范
    // if(grade > 60){
    //     console.log('E')
    // }else if(grade > 70){
    //     console.log('D')
    // }

    //正确示范
    // if(grade >= 90){
    //     console.log('A')
    // }else if(grade >= 80){
    //     console.log('B')
    // }else if(grade >= 70){
    //     console.log('C')
    // }else if(grade >= 60){
    //     console.log('D')
    // }else {
    //     console.log('E')
    // }

    let result = 'E'
    if(grade <= 100 && grade >= 0){
        if(grade >= 90){
            result = 'A'
        }else if(grade >= 80){
            result = 'B'
        }else if(grade >= 70){
            result = 'C'
        }else if(grade >= 60){
            result = 'D'
        }else {
            result = 'E'
        }
    }
    console.log(result)
~~~

### 三目表达式

~~~js
    'use strict';
    /* 
        三目运算 || 三元运算符
        就是 if else 的简写方案

        语法 表达式 ? 表达式成立结果 : 表达式失败的结果
    */

    // let age = +prompt('age',19)

    //if写法
    // if(age > 18){
    //     console.log('成年人')
    // }else{
    //     console.log('未成年')
    // }

    //优化1
    // age > 18 ? console.log('成年人') :  console.log('未成年')
    //优化2
    // console.log(age > 18?'成年人':'未成年')

    //多个 ? 一起使用, 循环判断 , 判断年龄阶段 age < 3 就是婴儿, age < 18 未成年 age < 25 青年 , age < 50 中年 ,age < 100 老年

    let message = ''
    // if(age <= 3){
    //     message = '婴儿'
    // }else if(age <= 18){
    //     message = '未成年'
    // }else if(age <= 25){
    //     message = '青年'
    // }else if(age <= 50){
    //     message = '中年'
    // }else{
    //     message = '老年'
    // }

    //优化
    // message = (age <= 3) ? '婴儿' : (age <= 18) ?  '未成年':(age <= 25)? '青年' : '其他情况'

    // console.log(message)


     /*  
        if(a){
            code
        } 
    
        //逻辑运算写法
        a && code

        if(a > b){
            c
        }else{
            d
        }
        //三目
        a>b?c:d
        //逻辑运算
        a && c || d
    */

    //应用场景  数字补0
    let num = 8 // 补0以后 01   10 补0 = 10
    //if写法 
    // if(num < 10){
    //     num = '0'+num
    // }else{
    //     num = String(num)
    // }
    //三目
    // num < 10 ? num = '0'+num : num = String(num)
    // num = num < 10 ? '0'+num : String(num)

    //逻辑运算
    // num = num < 10 && '0'+num || String(num)
~~~

### swith语句

```js
    'use strict';
    /* 
        swith 语句可以用于替代多个if的判断
        swith 语句是大量分支语句组成的一种语句, 比if更加直观

        语法
        swith(判断的值)
            case vlaue1 //判断 值是否等于 value1
                代码块 // 如果满足条件就执行代码块的内容
            break//跳出当前case判断
            case vlaue2 //下一次判断该值是否等于 vlaue2
            break


        break 是跳出当次判断, 这个值不是必须的, 可以不写,不写就是落空的情况, 落空可以用于多次判断 可以理解为逻辑或
    */

    //数字转大写 输入 1 最终转换为 一 输入2 转换为二
    let num = 1
    let result = '一';
    // if(num === 1){
    //     result = '一'
    // }else if(num === 2){
    //     result = '二'
    // }else if(num === 3){
    //     result = '三'
    // }

    //swith 写法
    // switch(num){
    //     case 1: //if(num === 1)
    //         result = '一' 
    //     break //跳出当次判断
    //     case 2://num === 2
    //         result = '二'
    //     break
    //     case 3:
    //         result = '三'
    //     break
    // }


    //num 表示星期几 输入是否是工作日
    switch(num){
        case 1: 
        case 2://当num 为1或者num 为2 的时候执行代码块的内容
            console.log('上班')
        break
        case 3:
            console.log('解答')
        break
        case 4:
        case 5:
            console.log('上班')
        break
        case 6:
        case 7:
            console.log('休息')
        break
    }


    //非主流的玩法
    //switch 的值可以传入一个布尔值true ,无论什么情况都能进入swithc 

    let jifen = 100000
    switch (true) {
        case jifen > 10000: //swith为true 的情况内部的case可以为表达式
            console.log('贵族5')
            break;
        case jifen > 8000:
            console.log('贵族4')
            break;
       case jifen > 5000:
            console.log('贵族3')
            break;
        case jifen > 2000:
            console.log('贵族2')
            break;
        case jifen > 1000:
            console.log('贵族1')
            break;
        default: //default 最终值,如果上面的所有case都没成功就会走 defalut 的结果
            console.log('重置1000以上才有贵族')
            break;
    }
```

### 运算符总结

- 比较运算符始终返回布尔值。
- 字符串的比较，会按照“词典”顺序逐字符地比较大小。
- 当对不同类型的值进行比较时，它们会先被转化为数字（不包括严格相等检查）再进行比较。
- 在非严格相等 `==` 下，`null` 和 `undefined` 相等且各自不等于任何其他的值。
- 在使用 `>` 或 `<` 进行比较时，需要注意变量可能为 `null/undefined` 的情况。比较好的方法是单独检查变量是否等于 `null/undefined`。`null`是可以在比较的时候转为数值的,但是`undefined`不可以
- `NaN `跟任何值都想等

#### 逻辑运算总结

- 逻辑运算 `&& 和 ||` 在运算的时候 会将运算元 **临时转换为布尔值**
- 逻辑`&&` 如果条件为真走下一次判断,如果条件为假返回当前结果并且停止后续判断,全为真返回最后一次判断的结果
- 逻辑`||` 如果条件为假走下一次判断,如果条件为真返回当前结果并且结束后续判断,全为假返回最后一次判断的记过
- 逻辑`!` 将运算的值转换为布尔值并且取相反的结果

## day07-循环语句

### 循环语句

~~~js
    'use strict';
    /* 
        循环语句
        应用场景 适用于处理一些需要重复执行的操作, 比如打印1-10的所有整数
        循环就是一种重复运行同一个代码的方法

        循环在js中一共有
        for
        while
        do while
        //讲对象和数组的时候讲
        for in
        for of

        while 循环
        语法
        while(condition){ // condition 判断条件
            //body 代码块区域
        }
        当判断条件为真的时候执行代码块区域的所有代码 为假跳出循环
        循环体的单词执行就称为一次迭代
    */

    //例如输入1-10之间的整数
    // let index = 0 // 1 2 9 10 11
    // while (index <= 10) { //条件必须要有机会能成为false 不然就会死循环
    //     console.log(index)//0 1 9 10 
    //     index++  // 9 10 11 // 必须有改变判断条件的语句 ,改变的目的是为了让循环能有终止的情况
    // }
    // console.log(index)//11

    //循环的判断条件不一定非要是表达式, 也可以是一个变量,当然你要确定这个变量有机会转换为布尔值 false,  0 null false undefined '' NaN

    //打印10-1之间的所有整数
    // let index = 10
    // while (index) {
    //     console.log(index--) //10 9 .... 1
    // }

    /* while (index) (console.log(index), index--); */


  
    //循环内还可以嵌套其他任何语句
    //打印1-100之间的所有偶数
    // let indx = 0
    // while(indx <= 100){
    //     // if(indx % 2 == 0){ //满足 % 2等于0 说明是偶数
    //     //     console.log(indx)
    //     // }
    //     console.log(indx)
    //     indx+=2
    // }


    /* 
        do while 语句
        跟 while 语句非常类似 , 但是它的代码块区域不在whiel的{}内,而是在do的花括号内
        do {
            //body循环体代码块区域
        } while (condition);//condition 终止条件

        跟while的区别在于 dowhile会先进行一次代码块的执行再进行条件判断
    */

    // let index = 0
    // do {
    //     //body循环体代码块区域
    //     //改变条件的值 
    //     index++
    //     console.log(index)
    // } while (index <= 10);//condition 终止条件
~~~

### for循环

~~~js
    'use strict';
     /* 
        for 循环 
        语法
        for(begin;condition;step){
            //body
        }
        begin 初始化表达式
        condition 判断条件
        step 更新初始值
        body 循环体
     */

     //打印 0 - 3 之间的整数 ,不包含3 , 一共需要迭代3次
    //  let index = 3
    //  while (index <= 0) {
    //     index--
    //     console.log('你好')
    //  }

    // for (let index = 0; index < 3; index++) {
    //     console.log(index)// 0 1 2 
    // }
    //内置变量 , 循环内初始表达式创建的变量外部是无法访问的
    // console.log(index)

    //执行规则
    /* 
    第一次迭代
    - 初始化变量 let index = 0
    - 判断表达式是否成立 index < 3 , 如果成立就运行body
    - 执行 更新初始值index++

    第二次迭代
    - 判断表达式是否成立 index < 3 , 如果成立就运行body
    - 执行 更新初始值index++
    */

    //初始化变量
    // let index = 0
    // //判断条件是否为真
    // if(index < 3){ console.log(index);index++}
    // if(index < 3){ console.log(index);index++}
    // if(index < 3){ console.log(index);index++}

    //for 循环的每一个区域都可以省略 或者抽离出来
    // let index = 0//初始化表达式抽离到外面
    // for (;index < 3 ;index++ ) {
    //    console.log(index,'循环体内')
    // }
    // console.log(index,'循环外')

    // for (let index = 0; ;index++ ) {
    //    if(index < 3){
    //     console.log(index)
    //    }else{
    //      break
    //    }
    // }


    //省略step 
    // for (let index = 0; index < 3; ) {
    //     console.log(index)
    //     index++
    // }


    //3条语句都省略 就是一个死循环 , 但是不能省略分号
    // for (;;) {
        
    // }

    //嵌套循环 10*10 = 100
    for (let index = 0; index < 10; index++) { // 0 1 2
        for (let k = 0; k < 10; k++) { // 1 - 10 1-10  1-10 
            console.log ('坐标',index,k)
        }
    }
~~~

### for循环break

~~~js
    'use strict';
    /* 
        循环控制语句
        当你需要手动提前从循环过程中结束或者跳出的时候就可以使用循环控制语句
        分别是
        continue 表示跳出当次循环继续下一次循环
        break 表示跳出整个循环
    */

    //找 0 - 100 之间第一个能被13整除的数, 除了13自身以外
    let num = 0//记录已经找到了几个 满足条件
    for (let i = 1; i <= 100; i++) {
        if(i % 13 == 0 && i != 13){
            console.log(i)
            num++ //更新当前找到了几个
            //找到第一个以后停止后续循环
            //新增需求, 我还需要找到第二个能被13整除的数怎么操作
            if(num == 2){
                break //跳出了所有的循环
            }
        }
    }

    //跳出当次循环 ,应用场景  找50-100的所有偶数
    for (let i = 50; i <= 100; i++) {
        if(i % 2 != 0){
            continue //如果他不是偶数就跳出当次循环
        }
        console.log(i)
    }
~~~

## day08-函数基础

### 函数基础

~~~js
'use strict';
    /* 
        函数基础
        函数的主要作用就是用于构建模块, 函数可以使一段大量的代码存储到一起, 在合适的地方执行

        通俗一点函数就是一堆语句的集合, 可以独立执行的程序单元, 本质上就是一个子程序, 函数是js的核心

        创建语法
        function fnName(){  // fnName 表示函数的名称
            //函数体内的代码
        }
    */
   
    ///创建函数 函数声明
    // function name(){
    //     //函数体代码块区域
    //     console.log('123')
    //     console.log('446')
    //     let age = 18
    //     console.log(age)
    // }

    // //执行函数
    // name() 
    // console.log(typeof alert) //function


    //自己写一个log方法用于简化console.log

    let age = 19
    function log(){
        //函数体内是一个全新的环境
        let age = 18 //内部变量和外部变量相同时我们称为变量遮罩,出现这种情况的时候函数会优先使用内部的变量
        console.log('123',age) //函数内是可以访问函数外部的变量
    }
    log()
    log()
    // console.log(age)// 函数外是无法访问函数内的变量
~~~

### 函数的参数

~~~js
'use strict';
    /* 
        函数的参数
        形参  形式参数 , 在函数创建的时候可以以变量的形式接受外界传递过来的一些数据
        实参  实际参数, 在函数调用的时候传递过去的数据,对应的是函数的形参接受

        语法 
        function fnName(parme1,parme2....){ //形参

        }
        fnName(parme1,parme2....)//实参
        实参跟形参必须一一对应
    */

    // function log(txt){ // txt 表示一个形参变量
    //     // let txt = '123'
    //     console.log(txt)
    // }
    // // console.log('123')
    // log('123') //123就是实参数


    //需求 需要一个函数 用于计算 1+1 的结果
    function sum(){
        let ss = 1 + 1
        console.log(ss)
    }
    //需求, 计算3+4怎么办
    function sum2(){
        let ss = 3 + 4
        console.log(ss)
    }
    //计算99+33呢
    function sumPam(a,b,c){
        //形参没有对应的实参接受 , 他的默认值就是undefined
        console.log(c)// undefined
        //a = 33 b = 99
        let ss = a + b 
        console.log(ss)
    }
    // sum()
    // sum2()
    // sumPam(33,99)
    // sumPam(123,456)
    // sumPam(123)


    //函数参数默认值 es6 可以支持设置参数默认值
    // function sumPam2(a=0,b=1){//b 参数的默认值为1 , 没有实参对应就用默认值
    //     let ss = a * b 
    //     console.log(ss)
    // }
    // sumPam2(1,2)
    // sumPam2()


    //后备参数
    function sumPam2(a,b){//b 参数的默认值为1 , 没有实参对应就用默认值
        //解决方案1
        a = a || 0
        //b = b || 1 //存在一个问题就是无法判断0
        //解决方法
        // if(typeof b != 'number'){
        //     b = 1
        // }
        b = b ?? 0
        let ss = a * b 
        console.log(ss)
    }
    sumPam2(1,1)
~~~

### 断点测试

~~~js
'use strict';
     let num = 0 
    for (let big = 0; big <= 50; big++) { // 1 2 
      //中马
        for (let middle = 0; middle <= 100; middle++) { //1
            //小马
            for (let small = 0; small <= 200; small++) { // 1 - 200
                // debugger
                if(small+middle+big == 100 && small*0.5+middle*1 + big*2 == 100){
                    ///最优分配方法
                    console.log(`大马用了${big}头,中马用了${middle},小马用了${small}头`)
                    num++
                }
            }
        }
    }
    console.log(num)
~~~

### 循环总结

~~~js
三种循环：

while(){} —— 每次迭代之前都要检查条件。
do{}..while() —— 每次迭代后都要检查条件。
for (1begin;2con;3step){4} —— 每次迭代之前都要检查条件，可以使用其他设置。
通常使用 while(true) 来构造“无限”循环。这样的循环和其他循环一样，都可以通过 break 指令来终止。

如果我们不想在当前迭代中做任何事，并且想要转移至下一次迭代，那么可以使用 continue 指令。
~~~

## day09-继续函数学习

### 函数的命名

~~~js
'use strict';
    /* 
        函数通常是用于标识某个行为, 一般情况他们的命名都是动词加名词的组成

        例
        get -- 获取或者是返回某个值
        calc -- 用于计算某些内容
        create -- 创建某些内容
        check -- 检测内容返回布尔值
        is -- 判断内容漫步满足条件 返回布尔值
        .....

        showMessage() 
        calcSum()
        createTable()
        checkUser()
        checkAdmin()
    */
~~~

### 函数的返回值

~~~js
'use strict';
    /* 
        函数返回值
        函数返回值 可以将函数内部的值作为函数表达式的结果返回出去
        默认情况下函数没有手动指定返回值的时候默认是返回 undefined

        借助关键词return 可以再函数内部任意的位置执行,当执行到return语句的时候 会立马终止函数的执行,并且将return关键词后面的表达式或者字面量内容作为表达式的结果返回出去
    */

    //函数声明  = 函数表达式
    function fn(){
        let  message = '123'

        return 123 //函数停止执行 并且将 123 这个数值作为结果返回出去
        console.log(456)// 不会打印
    }

    let fnRes = fn()
    console.log(fn()) // 123
    console.log(fnRes) // 123

    let age = 13
    // let age = +prompt('你今年多大')

    function isAdult(age){
        //期望函数检测年龄是否成年,并且返回一个布尔值
        // return num >= 18 ? true : false

        // if(age >= 18){
        //     return true
        // }else{
        //     return confirm('你父母是否在旁边陪同')
        // }
    }
    // console.log(isAdult(1))

    // if(isAdult(age)){
    //     alert('欢迎用户进入')
    // }else{
    //     alert('未成年人进制入内')
    // }
~~~

### 函数表达式

~~~js
'use strict';
    //函数声明
    function fn1(){
        console.log('123')
    }

    //函数表达式创建
    let fn2 = fn1 
    //函数表达式创建2  格式 let fnname = 匿名函数
    let fn3 = function(){
        console.log('456')
    }

    // fn1()
    // fn2()
    // fn3()

    //函数声明和函数表达式的区别
    // fff()//函数声明创建的函数可以再创建函数之前调用函数
    function fff(){
        console.log('ffff')
    }

    // kkk()//函数表达式创建的函数不可以在创建之前调用
    let kkk = function(){
        console.log('kkkk')
    }
    // kkk()



    let age = 14

    //用户年龄检测的程序, 根据用户年龄的大小决定欢迎语句
    // if(age < 18){

    //     function welcome(){
    //         console.log('欢迎小朋友光临')
    //     }
    // welcome()
        
    // }else{
    //     //函数只在内部能访问到
    //     function welcome(){
    //         console.log('欢迎光临')
    //     }
    // }
    // // welcome()// 报错

    let welcome;
    if(age < 18){

        welcome =  function (){
            console.log('欢迎小朋友光临')
        }

    }else{
        //函数只在内部能访问到
        welcome =  function (){
            console.log('欢迎光临')
        }
    }
    welcome()
~~~

### 箭头函数

~~~js
    'use strict';
    /* 
        箭头函数 
        箭头函数就是普通函数的另一种写法 , 而且这种写法比普通的函数表达式效果更好
        箭头函数就是普通函数的简写方案

        标准简化规则
        1. 省略function关键词和函数名称
        2. 保留函数参数部分
        3. 参数部分新增一个 箭头写法 =>
        4. 箭头后面书写代码块和代码块内的内容
    */

    // function fn(a,b,c){
    //     console.log('1asdf')
    //     return true
    // }

    //标准简化
    // let fn =  (a,b,c)=>{
    //     console.log('1asdf')
    //     return true
    // }

    // let fn2 =  function(){
    //     console.log('1asdf')
    //     return true
    // }

    //简化
    // let fn2 = ()=>{
    //     console.log('1asdf')
    //     return true
    // }

    // fn2()


    //变种写法
    //1. 当传递参数只有一个的时候 是可以省略括号的
    // let ff2 = function(a){
    //     console.log(a)
    //     return a
    // }

    // let ff22 = a=>{console.log(a);return a }
    // ff22(1)

    //2.当函数体内只有一条语句的的时候可以省略花括号
    // let ff3 = function(a){
    //     console.log(a)
    // }
    // ff3(1)

    // let ff33 = a=>console.log(a);

    //3. 可以通过逗号运算符进行大量的简化
    let ff4 = function(x,y){
        x = x+2
        y = x * y
        return y
    }

    let ff44 = (x,y)=>(x = x+2,y = x * y,y)

    console.log(ff4(3,4))
    console.log(ff44(3,4))S
~~~

### 回调函数

~~~js
        'use strict';
        /* 
            回调函数
            当函数作为参数传递给另一个函数的时候,我们就称这个函数的参数为回调函数
        */

        // function fn(cb){//cb对应的函数 就称为回调函数
        //     console.log(cb) // function...
        //     cb()
        // }

        // let f = function(){
        //     console.log('回调函数执行成功')
        // }

        // fn(f)


        //编辑问答函数 ask(question,yes,no) 
        /* 
            question 提问的问题
             yes 回答正确需要做的事情
             no 回答错误需要做的事情
        */

        function showYes() {
            for (let index = 0; index < 5; index++) {
                console.log('我吃了我吃了')
                console.log('我吃了我吃了')
            }
        }

        function showYes2() {
            for (let index = 0; index < 5; index++) {
                console.log('睡醒了睡醒了')
                console.log('睡醒了睡醒了')
            }
        }

        function showNo2(){
            for (let index = 0; index < 5; index++) {
                console.log('还没睡醒')
                console.log('还没睡醒')
            }
        }

        function showNo() {
            for (let index = 0; index < 5; index++) {
                console.log('还没吃饱还没吃饱')
                console.log('还没吃饱还没吃饱')
            }
        }

        function ask(question,yes,no) {
            if (confirm(question)) {
                //选择正确
                yes()
            } else {
                //选择错误
                no()
            }
        }

        ask('你吃饭了吗',showYes,showNo)
        ask('你睡着了吗',showYes2,showNo2)
~~~

### 纯函数和非纯函数

~~~js
'use strict';
    /* 
        纯函数 : 函数的执行的过程中不会影响到到外界环境中的变量只依赖于自身函数内的数据执行的函数就称为纯函数

        非纯函数 : 函数的内部的执行需要依赖外界的参数或者函数的执行会改变外检的参数 就叫非纯函数
    */
   
    //纯函数
    function padLeft(num){
        return num < 10? '0'+num : num
    }
    console.log(padLeft(3))
    console.log(padLeft(10))

    //非纯函数
    let result = 0
    function sum(a,b){
        result = a+b
    }
    sum(2,3)

    console.log(result)
~~~

### 柯里化函数

~~~js
'use strict';
    /* 
        柯理化 currying
        当函数的返回值还是一个函数的时候,那这个函数就称为柯理化函数

        柯理化函数的应用场景是用于将复杂的功能分解成多个小功能
    */

    function add(x,y){
        return x+y
    }
    console.log(add(3,3))

    function addCury(x){
        return function(y){
            return x+y 
        }
    }

    //需求每次计算的值都是 125 加y的值
    console.log(add(125,5))
    console.log(add(125,6))
    console.log(add(125,10))


    // console.log(addCury(1)(2))

    let curAdd = addCury(125) // function(y){return x+y }
    console.log(curAdd(5))
    console.log(curAdd(6))
    console.log(curAdd(123))

    /* 
        更多的高级函数 后续了解 工厂函数 ,偏函数, 递归函数....
    */
~~~

## day10-对象与数组

### 对象

~~~js
    'use strict';
    /* 
        基础数据类型 number null undefined string.... 
        引用数据类型 Object

        万物皆对象

        对象是一个无序的集合, 用于存储一堆杂乱的数据
        创建方式 
        1. 通过字面量创建 let xx =  {}

        js中的对象分为三种
        - 内置对象(Number Boolean,Array,Math ...)
        - 浏览器对象(XMLM , window , Navigator,...)
        - 自定义对象(构造函数对象)


        对象中的属性名只能是一个字符串
    */
   
    //对象的创建 内置方法创建
    let obj = new Object()
    obj.age = 19

    //字面量创建对象
    let yaSuo = {}

    // console.log(obj)
    // console.log(xx)

    //对象数据的新增  对象内数据的存储都是以键值对的形式作为存储 格式属性名 : 属性值
    //通过 .操作符存储数据
    yaSuo.ph = 100 // 在yasuo变量中存储了一个属性叫ph 值为 100
    yaSuo.name = '疾风剑豪' // 在yasuo变量中存储了一个属性叫name 值为 '疾风剑豪'
    // yaSuo.font-size = 200 //错误写法不能用点操作符存储 有连字符的属性名

    //中括号存储数据 语法 obj[string] = xxx  存储的string 就表示在obj对象中的属性名  中括号可以解析变量
    yaSuo['max-ph'] = 200;
    let heightName = 'height' 
    yaSuo[heightName] = '200px'; //yaSuo['height'] = '200px';

    let ageName = 'age'
    yaSuo.ageName = '123'//在yaSuo变量中存储一个 ageName 的属性名值为 123
    yaSuo[ageName] = '16'


    //对象的取值 , 语法  不赋值直接访问对象的属性名就是取值
    console.log(yaSuo.age) //16

    console.log(yaSuo["max-ph"])//200
    console.log(yaSuo[heightName])//200px


    //可以创建的时候就添加对象的值
    let teacher = {
        name : '夏栀',
        age : 18,
        marry : false,
        fd : {
            xuxing : {
                name : 'xuxing',
                age : 39
            },
            luyao : {
                name : 'luyao',
                age : 19
            },
            afei : {
                name : 'afei',
                age : 20
            }
        }
    }
    //嵌套结构访问规则 必须层访问
    console.log(teacher.fd.xuxing.age)

    //访问对象中不存在的值默认是undefined
    console.log(teacher.color)//undefined 

    //重复添加相同的属性名会覆盖
    //对象的修改值
    teacher.color = 'blue'
    teacher.color = 'red'
    teacher['age'] += 1 

    //对象删除属性 语法  delete obj.attr 删除obj下的attr属性
    delete teacher.color;
    delete teacher.fd;
    // delete teacher; //错误示范, 不可以直接删除对象

    //删除整个对象
    // teacher = null


    //对象属性的计算属性

    let ballName = 'lnaqiu';

    let ball = {
        [ballName+'Count'] : 6
    }
~~~

### 对象的简写方案

~~~js
    'use strict';
    /* 
    对象的简写
    */

    function makeUser(name,age){
        // return {
        //     "name" : name,
        //     "age" : age
        // }
        //属性值和属性名相同的时候可以简写为只写一个属性值
        return {
            name,
            age
        }
    }

    let user1 = makeUser('xuxing',20)
    let user2 = makeUser('xiazhi',19)

    //对象新增属性
    user1.sex = 'sex'

    //特殊值 __proto__ 不可以用于做属性名
    // user1.__proto__ = '123'


    //为用户添加一个id值, 如果用户已经有了id值就不能再添加
    function setId(obj,idStr){
        // if(!obj.id){
        //     //不存在id值
        //     obj.id = idStr
        //     console.log('添加成功')
        // }else{
        //     console.log('id已经存在不要重复添加')
        // }

        //检测对象中是否存在 该属性 语法 attr in obj 检测 attr属性是否存在于obj   attr 必须是一个字符串 ,返回值是一个布尔值存在返回true
        if(!('id' in obj)){
            //不存在id值
            obj.id = idStr
            console.log('添加成功')
        }else{
            console.log('id已经存在不要重复添加')
        }
        
    }

    user2.id = undefined;
    console.log( 'id' in user2)//ture
    console.log( 'id123' in user2) //false

    setId(user1,'xxxxx')
    setId(user1,'kkkk')
    setId(user2,'23324')
~~~

### 对象遍历

~~~js
    'use strict';
    /* 
        for in 循环用于专门遍历对象的一个循环

        语法
        for (let key in object) { //key表示属性名 object需要遍历的对象
    
        }
    */

    let user = {
        name : 'xuxing',
        age : 19,
        sex : 'nan',
        isAdmin : true
    }

    for (const key in user) {
        console.log(key,'属性名')//name age sex isAdmin
        // console.log(user[key],'属性值')//xuxing 19
    }

    //遍历的顺序  , 如果属性名都是合法的数值字符串就会按照数值字符串的大小进行顺序迭代 从小到大的顺序, 不满足这个条件就会根据创建属性的先后顺序遍历

    let idObj = {
        '12':'xxxx',
        '23':'yyyy',
        '15':'wwww',
        '88':'dddd',
    }

    for (const key in idObj) {
        console.log(key,'属性名')
    }
~~~

### 对象与基础类型的区别

~~~js
    'use strict';

    /* 关于数据类型的引用和复制 */
    let message = 'hello'
    let copyMes = message //hello


    //修改copyMes的内容
    copyMes = 'word'
    console.log(message,copyMes)


    //引用类型
    let  user = {name:'xuxing'}
    let  copyUser = user

    //需要给copyUser新增一个年龄属性
    copyUser.age = 19
    user.sex = '男'

    // console.log(user === copyUser)

    /* 
        js存储数据的规则
        - 基础类型
        1. 在内存中的栈内存中直接存储变量的标识符和变量的值
        2. 基础类型是可以直接访问内存中存储的实际值
        3. 不能给基础类型添加属性和方法
        - 引用类型
        1. 引用类型是按照引用地址来进行存储的
        2. 引用类型有自己的属性和方法, 并且是可以动态修改的
        3. 引用类型的存储数据会同时使用到栈内存和堆内存
        4. 会在栈内存中存储数据的引用地址,真实数据存储于堆内存中
    */
    let obj111 = {}
    let obj222 = {}

    let str1 = '123'
    let str2 = 123
    // console.log(obj111 === obj222)//false
    // console.log(obj111 == obj222)//fasle
    // console.log(str1 == str2)

    //浅拷贝, 需求拷贝一个对象, 并且不和原有的对象有关联

    let xuxing = {
        name : 'xuxing',
        age : 10,
        sex : '男',
        fd : {
            name : '123'
        }
    }

    // let copyX = {}
    // copyX.name = xuxing.name
    // console.log(xuxing == copyX)

    //浅拷贝对象
    function coypeObj(obj){
        let newObj = {}

        //方案一利用循环拷贝
        //将obj对象的属性和值添加到 newObj中
        // for (const key in obj) {
        //    newObj[key] = obj[key]
        // }

        //方案二利用 Object.assgin() 方法
        /* 
         Object.assgin(target,obj1,obj2...)用于做对象合并 
         作用将 obj1 和 obj2 对象合并到 target对象
        */
        Object.assign(newObj,obj)
        return newObj
    }

    let coyX = coypeObj(xuxing)
    coyX.height = 150
    console.log(coyX === xuxing) //ture

    //浅拷贝无法切断对象嵌套对象的情况
    console.log(coyX.fd === xuxing.fd) //ture
~~~

### 函数基础总结

#### 函数总结

函数就是一堆 **语句**的集合， 可以独立执行的程序单元

- 函数是值。它们可以在代码的任何地方被分配，复制或声明。
- 如果函数在主代码流中被声明为单独的语句，则称为“函数声明”。
- 如果该函数是作为表达式的一部分创建的，则称其“函数表达式”。
- 在执行代码块之前，内部算法会先处理函数声明。所以函数声明在其被声明的代码块内的任何位置都是可见的。
- 函数表达式在执行流程到达时创建。
- 函数执行一定会有一个返回值默认是 `undefined` 可以使用关键词`return`手动指定返回的内容

在大多数情况下，当我们需要声明一个函数时，最好使用函数声明，因为函数在被声明之前也是可见的。这使我们在代码组织方面更具灵活性，通常也会使得代码可读性更高。

#### 箭头函数总结

对于一行代码的函数来说，箭头函数是相当方便的。它具体有三种种：

1. 不带花括号：`(...args) => expression` — 右侧是一个表达式：函数计算表达式并返回其结果。
2. 带花括号：`(...args) => { body }` — 花括号允许我们在函数中编写多个语句，但是我们需要显式地 `return` 来返回一些内容。
3. 不带参数括号 `a=>{body}` 当传递的参数只有一个时可以省略括号

## day11-深入对象

### 垃圾回收

~~~js
    'use strict';
    /* 
        垃圾回收
        js中的内存管理是自动打开的 , 在js中垃圾回收是自动执行的

        执行上下文
        值得就是代码当前执行阶段 , 执行完成以后,js就需要对不在需要的变量进行一些列的回收操作

        当程序结束不在需要用到内存的时候,就需要及时的释放内存,如果没有释放,就会造成内存泄漏

        垃圾回收是一个定期性周期性执行的程序,他会自动去找不再需要使用的内存(变量)然后释放他的内存
        常见的垃圾回收机制有两种, 引用计数 标记清除
    */

    //引用计数
    /* 
        规则当数据存储到变量中的时候,就为变量添加一个引用计数为1,当他的数据拷贝给别人重复建立引用的时候 引用计数就+1 ,较少一个引用 计数-1
        当引用计数为0的时候就将这个变量进行回收
    */
    // let obj1 = {name : 'xixi'}; // 对象的引用计数 2 - 1  // 1
    // let obj2 = obj1 // 此时obj2引用了obj1的数据,此时的引用计数就增加1 ,变为 2  自身引用为1
    // // 接触obj2的引用 
    // obj2.sex = '男'
    // obj2 = null // obj2 没有引用对象
    // obj1 = null // obj1的引用设置为 0 

    //标记清除
    /* 
        当变量进入环境的时候, 给变量做上一个标记,标记为进入环境
        当环境不存在的时候,就将变量标记为离开环境
        内存定期去清空标记为离开环境的变量
    */

    // function go(){
    //     let a = 1 //标记为进入
    //     let b = 'hello' //标记为进入

    //     return//表示函数执行完成  将内部的变量标记为离开环境
    // }
    // go()
    // console.log(a)


    /* 
        可达性
        js内存管理的一个概念
        可达性值得就是可以以为某种方式访问到或者使用到这个内存中的值,我们就认为这个数据是可达的

        当一个数据不可达的时候js就会自动进行垃圾回收

        js中有个跟对象叫做全局对象 global
    */

    let user = {
        name : '快乐的小树'
    }
    
    // console.log(window) // global
    // console.log(window.user) // global
    // console.log(window.alert) // global
    // console.log(window.fnfn) // global

    //user不需要
    user = null


    let student = {
        name : '葡萄哥'
    }

    //存储谁是管理员
    let admin = student

    //取消了student对象
    student = null

    // console.log(admin)


    //复杂情况的垃圾回收案例
    function marry(man,woman){
        woman.husband = man //女方的老公是 man
        man.wife = woman //男方的老婆是 woman
        return{
            father : man,
            mother : woman
        }
    }

    //女
    let lin = {
        name : '林晨曦'
    }

    //男
    let tang = {
        name : '汤子星'
    }

    let family = marry(tang,lin)
    console.log(family)


    //汤子星去世了
    // delete family.father
    // delete family.mother.husband

    let san = {
        name : '三月尽',
        friend : tang
    }
    //家庭删除
    family = null
    console.log(family)
    console.log(san)
~~~

### 对象的this

~~~js
    'use strict';

    let user = {
        name : '罗超',
        age : 18,
        money : 200,
        say : function(){
            //函数内内的 this , this表示当前函数的调用主体
            // console.log(`my name is ${user.name}`)
            console.log(this.name)

            // function setSex(){
            //     this.sex = 'nan'
            // }
            // setSex()
        },
        buy : function(){
            this.money -= 20
            console.log(`购买了一个奥特曼花了20块钱还剩下${this.money}`)
        },
        //函数在对象内的简写方案
        getAge(){
            console.log(this.age)
        }
    }
    //编程的时候通常将事物抽象成一个对象, 分别用属性来描述他的特征,函数来标识事物的行为
    user.say()
    user.buy()
    user.getAge()

    //坑坑
    let getBuy = user.buy // 你把user下面的函数拷贝了一份过来
    // getBuy() //this =  undefined
    
    // let fn =  function(){
    //     console.log(this) //undefined 
    //     // console.log('韩式执行')
    // }
    // fn()

    /* 
        1. this 是函数内的一个关键词 ,表示调用函数的主体对象
        2. this 创建的时候是不确定的, 是在函数执行的过程中获取的
        3. 没有明确的调用主体this指向undefined(严格模式下)
    */
~~~

### 箭头函数的this

~~~js
    'use strict';

    let user = {
        name : '于森',
        sayHi(){
            console.log('你好')

            // let sayName = function(){
            //     console.log(this.name) //报错
            // }

            //箭头函数是没有this,如果在箭头函数中使用了this那他他会去找外层环境中的this
            // let sayName = ()=>{
            //     console.log(this.name)//于森
            // }

            //this 是一个值可以存储起来
            let _this = this
            let sayName = function(){
                console.log(_this.name) //报错
            }
            sayName()
        }
    }

    user.sayHi()
~~~

### symbol作为属性名

~~~js
    'use strict';
    
    // const symbol = Symbol()

    // let obj = {
    //     [symbol] : '123'
    // }

    // console.log(obj['Symbol()'])//undefined
    // console.log(obj.Symbol())//报错
    // console.log(obj[symbol])//报错

    // function creatObje(){
    //     let obj = {}
    //     let obj2 = {}

    //     obj.name = '徐星'
    //     obj.age = 19

    //     //期望外界只能看到obj 不能修改obj
    //     let symbol = Symbol()
    //     obj2[symbol] = obj

    //     return obj2
    // }

    // let obj = creatObje()
~~~

### 对象总结

对象是具有一些特殊特性的关联数据集合。

它们存储属性（键值对），其中：

- 属性的键必须是字符串或者 symbol（通常是字符串）。
- 值可以是任何类型。

我们可以用下面的方法访问属性：

- 点符号: `obj.property`。
- 方括号 `obj["property"]`，方括号允许从变量中获取键，例如 `obj[varWithKey]`。

其他操作：

- 删除属性：`delete obj.prop`。
- 检查是否存在给定键的属性：`"key" in obj`。
- 遍历对象：`for(let key in obj)` 循环。

我们在这一章学习的叫做“普通对象（plain object）”，或者就叫对象。

JavaScript 中还有很多其他类型的对象：

- `Array` 用于存储有序数据集合，
- `Date` 用于存储时间日期，
- `Error` 用于存储错误信息。
- ……等等。

它们有着各自特别的特性，我们将在后面学习到。有时候大家会说“Array 类型”或“Date 类型”，但其实它们并不是自身所属的类型，而是属于一个对象类型即 “object”。它们以不同的方式对 “object” 做了一些扩展。

JavaScript 中的对象非常强大。这里我们只接触了其冰山一角。在后面的学习中，我们将频繁使用对象进行编程，并学习更多关于对象的知识。

## day12_数组与函数进阶

### 构造函数

~~~js
    'use strict'

    // let cat1 = {
    //     name : 'xuxing',
    //     color : 'red',
    //     age : 2,
    //     like : '小鱼干',
    //     speak : function(){
    //         console.log('喵喵喵')
    //     }
    // }

    // let cat2 = {
    //     name : 'jiuwei',
    //     color : 'blue',
    //     age : 3,
    //     like : '小鱼干',
    //     speak : function(){
    //         console.log('喵喵喵')
    //     }
    // }

    //工厂函数创建对象
    function createCat(name,color,age){
        let obj = new Object()
        obj.name = name;
        obj.color = color
        obj.age = age
        obj.like = '小鱼干';
        obj.speak = function(){
            console.log('喵喵喵')
        }
        return obj
    }

    let  xuxing =  createCat('xuxing','red',2)
    let  jiuwei =  createCat('jiuwei','blue',3)

    /* 
        new 操作符的作用
        1. 用于调用函数创建一个新的对象

        构造函数约定函数的首字母必须大写
    */
   
    //构造函数  
    function CreateCat(name,age,color){

        // 用于检测是否是通过new 调用的该函数
        if(new.target === undefined){
            //是通过普通函数调用
            return createCat(name,color,age)
        }
        // this 就指向new 创建出来的对象
        // let this = {}
        this.name = name;
        this.color = color
        this.age = age
        this.like = '小鱼干';
        this.speak = function(){
            console.log('喵喵喵')
        }
        //构造函数内的return 默认是返回this,也可以手动指定返回一个对象
        // return this
        /* 
            new 操作符调用函数的时候会执行3个步骤
            1. 在函数内创建一个空对象并且分配给this
            2. 可以直接通过修改this的内容为对象添加新的属性或者方法
            3. 返回this
        */
    }
    let wuxian = CreateCat('wuxian',2,'pink')

    //实例化对象 new操作符创建的对象称为实例化对象
    let yaya = new CreateCat('yaya',1,'blue')
    let goudan = new CreateCat('goudan',1,'blue')

    goudan.goujiao = function(){
        console.log('汪汪汪')
    }
~~~

### 可选链操作符

~~~js
    'use strict';

    let user = {
        address : {
            street : {
                name : '123'
            }
        }
    }

    // console.log(user.address) // undefined
    // console.log(user.address.street) // 报错
    // console.log(user.like.animal) //报错

    //解决方案
    // let street = user.address ? user.address.street : undefined;

    //逻辑运算
    let street = user.address && user.address.street && user.address.street.name
        
    //可选链 vlaue?.prop
    /* 
        - 如果 vlaue存在则结果与value.prop相同
        - 如果value 不存在为 undefined或者null时 就直接返回 undefined
        可选链是一种安全访问对象属性的最好方法
    */

    let  stet =  user?.address?.street?.name


    //变体写法
    //短路操作
    // let abc = null
    // let x = 1
    // abc?.sayHi(x++)

    //安全的调用函数
    let admin = {
        setAdmin(){
            console.log('设置成功')
        }
    }

    let uu = {}
    uu?.setAdmin?.()
    admin?.setAdmin()

    //访问属性
    let uu2 = {
        name : 'xuxing',
        address : {
            street:'123'
        }
    }

    let kye = 'age'

    console.log(uu2?.[kye])

    //删除属性
    delete uu2?.address?.street

    console.log(typeof uu2)
    console.log(String(uu2)) //[object Object]
    console.log(Number(uu2)) //[object Object]
    console.log(Boolean(uu2)) //[object Object]
~~~

### 数组

~~~js
    'use strict';
    /* 
        数组
        当我们需要一些有序的集合的时候就可以用数组来创建
        数组是属于object类型的其中一个数据结构 Array

        数组存储的值没有属性名只需要存储单个值就可以了
    */

    //创建方式 构造函数
    let arr = new Array('luyao','yaya','xiazhi')
    //字面量创建
    let arr2 = ['1','2','3']

    //取值  arr[index] 表示取arr数组中的第几个数据, 数据是从0开始计算
    let name1 = arr[0] //luyao
    let name2 = arr[1] //yaya

    //修改值和新增值
    arr2[0] = '一'
    // arr2[5] = '五'

    //length 的属性 用于获取数组的长度 , 长度是从1开始计数
    console.log(arr2.length)
    arr2[arr2.length] = '六'
    arr2[arr2.length] = {
        name : 'xuxing',
        age : 123
    }

    console.log(arr2[4].age)

    //下标的长度默认是根据创建的值自动计算生成,当然也可以手动来设置长度
    //以下的方法都是一些不好的做法,不推荐这样使用
    arr2.length = 200
    arr2[999] = '九九九'
    arr2.age = '18'


    //length修改值的应用场景 length 的值是会自动更新数据
    let fruits = ['apple','banana','orange']
    //length 小于数组内的数据, 他就会自动去更新数据把多余的部分进行删除
    fruits.length = fruits.length - 1
    //清空数组
    // fruits = []
    // fruits.length = 0
    // fruits = null
~~~

### 数组遍历

~~~js
    'use strict';

    let arr = ['一','二','三','四','五']

    //for of 遍历数组 这个遍历方法只能用于数组
    for (const item of arr) {
        console.log(item)
    }

    //for in 进行遍历
    for (const key in arr) {
      console.log(arr[key])
    }

    //for 循环遍历
    for (let index = 0; index < arr.length; index++) {
        console.log(arr[index])
    }


    //数据类型转换
    console.log(String(arr)) //一,二,三,四,五
    console.log(Number(arr)) //NaN
    console.log(Number(['2'])) //1 数组中只有一个数值或者空值的时候是可以直接转换为数值的
    console.log(Boolean(['123123','123213']))//ture

    console.log([] == []) //false
    console.log(0 == []) //true
~~~

### 复习

~~~js
    'use strict';

     /* 
        1. this 是函数内的一个关键词 ,表示调用函数的主体对象
        2. this 创建的时候是不确定的, 是在函数执行的过程中获取的
        3. 没有明确的调用主体this指向undefined(严格模式下)
    */
    
    var obj = {
        name : 'obj',
        fn : function(){
            console.log(this === obj)
        },
        bb : {
            name : 'bb',
            cc : {
                name : 'cc',
                dd : function(){
                    console.log(this)
                }
            }
        }
    }

    obj.ff = obj.bb.cc.dd
    let nice = obj.bb.cc.dd

    nice()//undefined

    obj.ff() // obj 函数的this是调用的时候确定

    obj.bb.cc.dd() // cc

    function aa(){
        console.log(this)
    }

    //没有明确的调用主体就是window调用, this指向window(非严格模式, 如果在严格模式下指向undefined)
    aa()

    console.log(aa == window.aa) //ture

    obj.fn()

    //函数的调用主体就是函数执行前的那个对象
    window.obj.fn()
~~~

## day13-函数进阶

### 感受递归

~~~js
    'use strict';
    /* 
        递归函数 就是函数自身调用自身
    */

    //pow(x,n) 计算x的n次方
    //普通函数
    function pow(x,n){
        let result = 1
        for (let i = 0; i < n; i++) {
            result *= x
        }
        console.log(result)
    }
    pow(2,3)

    //递归函数
    function pow2(x,n){
        //递归一定要有个终点, 每次递归都会逐渐的接近终点
        if(n == 1){
            return x
        }else{
            return x * pow2(x,n-1)
        }
    }
    console.log(pow2(2,3)) // 2*2*2  2 * pwo(2,2)  2 * pow2(x,1) = x

    /* 
    1. pow(2,3) = 2 * pow2(2,2) = 8
    2. pow2(2,2) = 2 * pow2(2,1)  = 4
    3. pow2(2,1) = 2

    递归调用次数我们称为递归的深度, 深度是有限制的,不能大于10000
    */
~~~

### 执行上下文

~~~js
   'use strict';
    /* 
        执行上下文 是js代码执行前, js引擎需要做的准备工作 , 创建执行上下文

        js的上下文分为3了类
        - 全局执行上下文
        - 函数上下文
        - eval 上下文
    */
    // console.log(eval('1*3+6'))

    //全局执行上下文 , 就是所谓的全局对象
    // console.log(window)
    // function fu(){

    // }
    // var a = 1

    //函数执行上下文
    // let a = 1
    // function fn(){
    //     let a = 2
    //     console.log(a)
    // }
    // fn()

    //执行栈 
    /* 
        执行上下文栈也叫执行栈,执行栈用于存储函数执行期间的上下文
        栈是一个数据结构 具备 LIFO 先进后出 的特性

        js首次执行的时候就会创建一个执行栈, 并且最先把全局执行上下文压栈,之后如果有新的函数调用,就会把函数的执行上下文压入栈中

        当函数内嵌套函数调用的时候
        - 当前函数暂停执行
        - 与他关联的上下文会被执行栈中保存起来(压栈)
        - 执行嵌套函数
        - 嵌套函数结束后,在从堆栈中恢复之前的上下文, 并从停止的位置恢复函数的执行(出栈)

        创建上下文做的事情
        1. 确定this
        2. 词法环境组件
            1. 就是一个包含标量标识符的映射结构
            2. 全局的词法环境组件 : 建立词法环境的引用 null
            3. 函数词法环境组件 建立外部词法环境的引用关系
        3. 变量环境组件
            规定变量生效的范围,也具备记录外部变量的引入
    */

    let a = 1
    function f1(){
        f2()
        console.log(1,a)
    }

    function f2(){
        f3()
        console.log(2)
    }

    function f3(){
        console.log(3)
    }

    f1() // 

    /* 
        f1  = f2 = 1
        f2 = f3 = 2
        f3 = 3
    */
~~~

### 继续研究递归

~~~js
    'use strict';

    function nice(x){
        if(x === 1)return 1;
        console.log(x) // 654312  进栈
        nice(x-1)
        console.log(x) // 123456  出栈
    }
    nice(4)

    /* 
    进栈
    nice(4) == console.log(4),nice(3)
    nice(3) == console.log(3),nice(2)
    nice(2) =  console.log(2),nice(1)
    nice(1) =  return 1

    出栈
    2
    3
    4
    */
~~~

### 作用域

~~~js
    'use strict';
    /* 
        作用域就是变量生效的范围

        js每次执行或者{}的创建都会被称为一个词法环境的组件, 内部隐藏的映射关联对象就会产生

        词法环境由两个部分组成
        - 环境记录  存储所有局部变量作为其属性 包括this
        - 外部词法环境的引用  建立与外部词法环境的关联

        js中有三种作用域
        - 全局作用域
        - 函数作用域
        - 块级作用域
    */

    //块级作用域 如果在代码块 {} 内部创建了变量,name这个变量所在的花括号内就是块级作用域

    {
        //块级作用域
        let message = 'hello' //只在花括号内能访问 
        // var hello = '123'
    }

    // console.log(hello)

    //if语句
    if(true){
        let message = 'hello' //只在花括号内能访问 
    }

    for (let i = 0; i < 2; i++) {
        let message = 'hello' //只在花括号内能访问 
    }

    //函数作用域 函数内部的变量就是函数作用域 ,函数内部的变量只在函数内部能访问到, 函数的作用域是创建的时候就已经确定的
    let name = 'global'
    function fn(){
        let name = 'infn' // out就是一个函数作用域
        console.log(name)
    }
    fn()

    /* 
    作用域存在的机制
    1. 使用变量
        当访问变量的时候有限查看自身作用域有没有,有就用,没有就向外查找
        如果最顶层都没有就报错 xxx is not defined
    2. 赋值变量
        跟访问同理
    */
~~~

### 作用域练习

~~~js
    'use strict';
    // let num = 22
    // function fn1(){
    //     let num = 666
    //     console.log(num)//666
    // }
    // fn1()


    // let num = 22
    // function fn1(){
    //     num = 666
    // }
    // console.log(num)//22
    // fn1()



    // let num = 22
    // function fn1(){
    //     let num = 666
    // }
    // fn1()
    // console.log(num)//22







    // let num = 22
    // function fn1(){
    //     console.log(num)//
    //     let num = 666
    // }
    // fn1()



    
    // let num = 22
    // function fn1(){
    //     let num = 666
    //     fn2()
    //     console.log(num) // 666
    // }

    // function fn2(){
    //     num = 567
    // }
   
    // fn1()
    // console.log(num) // 567
~~~

### 作用链接

~~~js
    'use strict';
    /* 
        只有函数会产生作用域结构, 每一个函数的创建都是一个作用域, 当作用域嵌套作用域的时候, 组成的结构结构就叫作用域链

        变量的访问规则,自身作用域没有就会沿着作用域链向上查找上一个作用域中有没有
    */

    let xxx = '123'
    function fn(){
        let width = '123'
        function fn2(){
            xxx = 789
        }
        fn2()
    }
    fn()
    console.log(xxx)
~~~

## day14-函数补充

### 递归练习

~~~js
    'use strict';

    /* 
        深拷贝练习
        深拷贝就是 复制一个引用类型,并且切断与原有变量的引用关系
    */

    let user = {
        name : '张宏杨',
        age : 21,
        say : function(){console.log('hello')},
        friend : ['三月尽','葡萄哥','林晨曦'],
        like : {
            game : ['lol','cf'],
            eat : true
        }
    }

    let coypUsr = Object.assign({},user)
    //浅拷贝
    console.log(coypUsr.like.game === user.like.game ) // true
    

    // let depUser = deepClone(user)

    //深拷贝函数
    function deepClone(obj){
        //返回一个拷贝后的结果
        let result; //{name,age ,say,fired:[xxx,xxx],like:{game:[xxx],ett}}
        //判断数据类型
        if(typeof obj === 'object'){
            //说明是数组或者对象
            result = Array.isArray(obj)?[]:{} //判断是不是一个数组
            //是引用类型
           for (const key in obj) {
             result[key] = deepClone(obj[key])
           }
        }else{
            //不是引用类型
            result = obj
        }
        return result
    }

    let oo = {
        name : 'xuxing',
        like : {
            eat : true,
            fd : {
                name : '123'
            }
        }
    }
    console.log(deepClone(oo).like === oo.like)
    console.log(deepClone(user).like.game === user.like.age)
~~~

### 闭包

~~~js
    'use strict';
    /* 
        执行上下文有一个生命周期, 
        创建阶段 == 进行预编译 ,预解析
        执行阶段 == 根据上下文顺序执行代码
        回收阶段 == 垃圾回收
    */

    //复杂情况
    function f(){
        let value = 1 
        return function inner(){ //闭包函数
            console.log(++value)//value访问了外层函数的变量,导致外侧函数变量被保留了下来
        }
    }

    /* 
        内部函数使用了外部作用域的变量,导致变量没有被垃圾回收这种情况就称闭包
    */

    // f()() // 2
    // f()() // 2
    // f()() // 2


    // let ff = f() //得到的是f的返回函数inner  {value:1 , inner(){}}
    // ff() // 2
    // ff() // 3
    // ff() // 4


    //购买东西的函数
    function xuxingBuy(){
        let money = 100 //总金额
        return function buy(name,pic){
            money -= pic //更新总金额
            console.log(`徐星购买了${name},花费了${pic},还剩下${money}`)
        }
    }

    //购买东西
    let buyXuxing = xuxingBuy()// money = 100
    buyXuxing('美女写真',60) //40
    buyXuxing('奥特曼',20) //20
    
    function qiXiBuy(){
        let money = 100 //总金额
        return function buy(name,pic){
            money -= pic //更新总金额
            console.log(`七喜购买了${name},花费了${pic},还剩下${money}`)
        }
    }
    let buyQixi =  qiXiBuy()
    buyQixi('牙刷',5)
    buyQixi('牙膏',15)
~~~

### 参数rest参数与spread

~~~js
    'use strict';
    /* 
        rest 参数 和 spread 语法
    */

    // function max(){
    //     let maxNum = -Number.MAX_SAFE_INTEGER
    //     console.log(arguments) //存储已经接收到的所有参数
        
    //     for (const num of arguments) {
    //         if(num > maxNum){
    //             maxNum = num
    //         }
    //     }
    //     return maxNum
    // }

    // console.log(max(5,6,567,567,87))


    // function sum(name,sex){
    //     let sum = 0
    //     console.log(arguments) //存储已经接收到的所有参数
        
    //     for (let i = 1; i < arguments.length; i++) {
    //         sum += arguments[i]
    //     }
    //     console.log(sum)
    //     return sum
    // }

    // //求和函数, 第一个参数用户的名称, 后续参数是用户的工资, 要求用户的所有工资之和
    // sum('程力',100,200,500,1000,2000)
    // // sum('程力','男',100,200,500,1000,2000)


    /* 
        ...rest 用作参数的时候表示剩余参数 , 会将参数剩余的部分整合成一个数组
    */
    function sum(name,sex,...rest){ //接受name参数和sex参数剩余的参数统一 为 rest接受
        let sum = 0
        console.log(name,sex,rest)
   
        for (const iterator of rest) {
            sum += iterator
        }

        console.log(name,sum)
        return sum
    }

    //求和函数, 第一个参数用户的名称, 后续参数是用户的工资, 要求用户的所有工资之和
    // sum('程力','男',100,200,500,1000,2000)


    // function fn(...rest){
    //     console.log(rest)
    // }
    // fn(1,23,12,31,2312,3)

    /* 
        arguments 获取到的是所有参数的集合 ,不可以手动规定范围
        ...rest 获取的是剩余参数集合, 可以手动规定从什么位置开始获取剩余参数

        注意
        ...rest 后面不允许再出现形参
    */

    // function fnfn(...rest,age){} //错误写法


    /* 
     spread 语法(扩展运算)
    */

    function max(){
        let maxNum = -Number.MAX_SAFE_INTEGER    
        if(typeof arguments[0] === 'object'){
            for (const num of arguments[0]) {
                if(num > maxNum){
                    maxNum = num
                }
            }
        }else{
            for (const num of arguments) {
                if(num > maxNum){
                    maxNum = num
                }
            }
        }
        console.log(maxNum)
        return maxNum
    }


    function max2(){
        let maxNum = -Number.MAX_SAFE_INTEGER
        for (const num of arguments) {
            if(num > maxNum){
                maxNum = num
            }
        }
        console.log(maxNum)
        return maxNum
    }


    //传入的参数是数组
    let age = [1,23234,34,53,45,243,52,436,456,34,6554,76,6587]
    //找到age中最大的年龄
    max(age)
    // max(1,23,1,23)


    /* 
        扩展运算
        通过 ...arr的形式将数组的每一项单词拆解出来
    */
    console.log(...age) //1 23234 34 53 45 243 52 436 456 34 6554 76 6587

    let age2 = [32432,345,34,6456,9999999]
    max2(...age)//23234
    max2(...age,...age2,82379847298437928374)//9999999


    //花样玩法 合并数组
    let arr1 = [1,2,3]
    let arr2 = [4,5,6]

    // for (const value of arr1) {
    //     arr2[arr2.length] = value
    // }

    let arr3 = [...arr1,...arr2,...'axadsfasdf'] // [1, 2, 3, 4, 5, 6]
~~~

### var创建变量

~~~js
 'use strict';
    /* 
        var跟let 类似都是创建变量的方式
    */

    //1. var 没有块级作用域
    {
        var messge = '123'
    }
    console.log(messge)

    for (var index = 0; index < 5; index++) {
        // console.log(index)
    }
    // console.log(index)//5

    // let ali =  document.querySelectorAll('li')

    // var i = 0//5
    // for (let i = 0; i < ali.length; i++) {
    //     ali[i].onclick = function(){
    //         console.log(i)
    //         ali[i].style.background = 'red'
    //     }
    // }

    //2. 变量可以重复声明
    // var index = 1
    // var index = 2


    //3. 变量可以声明前使用
    // console.log(age)
    // var age = 19


    //4. 变量存储的位置是window
    // var age = 19
    // console.log(window.age)
    // console.log(window.age = 20)
    // let sex = '男' // let存储的位置是 script标签内部
    // console.log(window.sex)


    //函数声明提升
    /* 
        函数声明会出现作用域提升,会将函数声明提升到作用域的最顶层
    */
    fn()
    function fn(){
        console.log('fnnfnfnf')
    }
~~~

## day15-解答课

### case01

~~~js
    'use strict';
    // function fn(){
        
    // }
    // console.log(typeof fn) //function
    // console.log(typeof null) //object
    // console.log(new fn()) //{}

    /* 
        循环使用来批量多次的执行某一些代码或者是行为
        循环还可以用来获取对象或者数组中的每个值(遍历)

        while(表达式){ 代码块 }
        do{代码块} while(表达式)
        for(初始化变量;循环终止条件;更新初始值){代码块}

        当表达式为真的时候执行代码块的内容
        forin 遍历对象的循环
        forof 遍历数组的循环
    */

    let obj = {
        name : 'xuxing',
        age : 19,
        sex : '男'
    }
    
    let arr = ['123','456','asfd']
    // console.log(obj.name)
    // console.log(obj.age)
    // console.log(obj.sex)


    for (const key in obj) {
        console.log(key,obj[key])
    }

    for (const key in arr) {
        console.log(key,arr[key])
    }

    for (const value of arr) {
        console.log(value)
    }

    let index = 0
    while (index != arr.length) {
        console.log(arr[index])
        index++
    }

    let str = '按时发大水发打算复读'
    for (const valu of str) {
        console.log(valu)
    }

    /* 
        深拷贝和浅拷贝

        浅拷贝只会拷贝对象中的基础数据类型,引用类型的数据拷贝会建立引用关系
        深拷贝将对象中的所有类型都进行拷贝,并且切断引用关系
    */

    // let obj1 = {name:1}
    // let obj2 = obj1


    // for (let i = 0; i < 5; i++) { // 5
    //     for (let k = 0; k < 5; k++) { // 5 5*5  25
    //       //6  5*5*6
    //     }
    // }

    /* 
        var 的特征
        1. 不会创建快级作用域
        2. 会变量声明提升
        3. 变量可以重复命名
        4. 变量挂在的位置是window

        let
        1. 会创建快级作用域
        2. 不会变量提升
        3. 变量不能重复命名
        4. 变量存储的位置在全局global标签内部
    */

        let  message = '123'


        /* 
            作用域

            本质就是规定变量生效的范围
            作用域是一个静态的存在,函数在创建的时候作用域就已经创建好了

            作用域有3
            全局作用域
            函数作用域
            快级作用域
            建立当前作用域与外部作用域的关联

            作用域可能会有多层的嵌套, 多层嵌套称为作用域链
        */



        let age = 123
        function fn1(){
            fn2()
            let age = 19
            console.log(age) // 19
        }

        function fn2(){
            age = 456
            console.log(age) // 456
        }
        fn1()
~~~

### case02

~~~js
    'use strict';
    /* 
        预解析的原理
        预解析是代码执行的顺序
        1. 语法分析 ,快速的检查你的js代码,有没有语法错误,或者单词拼写错误
        2. js预解析, 在这个阶段js 会去创建A0对象和GO对象
        3. 解释性执行代码,代码逐条执行

        js预解析(代码执行前做的一件事)
        1. 创建AO对象 指的是活性对象,也叫作执行上下文,也可以说是创建作用域,AO表示创建函数执行的上下文和作用域
        2. 找函数形参和函数内部的变量声明,将形参和变量声明作为AO对象的属性名,并且赋值为undefined
        3. 将实参形参进行统一,实参赋值给形参
        4. 在函数体内找函数声明,值赋值给函数体
    */

    // for (let index = 0; index < 1000000; index++) {
    //     console.log(index)
    // }
    // let message = '123'
    // let message = '123'


    function nice(){
        let good = 20
        console.log(good)
    }
    // nice()
    /* 
    

    GO对象 全局执行上下文
    GO = {

    }
    2. 找参数和变量
    GO = {
        nice = undefined
    }
    3. 统一参数
    GO = {
        nice = function
    }
    4. 变量声明
    5. 执行上下文代码逐条执行

    1. 创建AO对象
    AO = {

    }
    2/ 找函数的形参和内部变量赋值为undefined
    AO = {
        good : undefined
    }
    3. 实参形参统一
    AO = {
        good : 20
    }
    4. 在函数体内找函数声明

    5. 执行上下文代码逐条执行

    */


    function fn(a){
        console.log(a) //ƒ a(){}
        a = 123;
        console.log(a)//123
        function a(){} 
        console.log(a) // 123
        // a()
        let b = function b(){}
    }
    fn(1)

    /* 
        1. 创建AO对象
        AO = {}

        2. 找函数形参和内部的变量声明赋值undefined
        AO = {
            a : undefined,
            b : undefined
        }

        3. 实参形参统一
        AO = {
            a : 1,
            b : undefined
        }

        4. 函数内部的函数声明和赋值
        AO = {
            a : function,
            b : function b(){}
        }

        5. 代码执行, 预解析就是为变量设置初始值
        a = 123
        console.log(a) // func
        a = 123;
        console.log(a)//123
        function a(){} 
        console.log(a) // 123
    */
~~~

### case03-自执行函数IIFE

~~~js
    'use strict';
        
    /* 
        IIFE 叫自执行函数 也就是自己会执行的函数,不需要额外调用, 或者说是自己创建的时候就已经调用的函数
    */

    // function fn(){
    //     let aa = 1
    //     console.log(aa)
    // }
    // fn()

    //自执行函数
    (function(){
        var aa = 1
        console.log(aa)
    })();

    let cc =  (function(){
        var aa = 2
        console.log(aa)

        return function(){
            aa++
            console.log(aa)
        }
    })();
    // cc()
    // cc()


    //iife函数的其他写法
    (function(){
        console.log('aaa')
    })();

    (function(){
        console.log('bbb')
    }());

    !function(){
        console.log('ccc')
    }();

    +function(){
        console.log('ddd')
    }();

    -function(){
        console.log('eee')
    }();
~~~

### case04-函数的NFE

~~~js
    'use strict';
    /* 
        函数本身就是一个对象
    */

    sayHi.age = 1
    function sayHi(){
        console.log('hi',sayHi.age++)
    }   

    //name 属性表示函数的名称
    console.log(sayHi.name)//sayHi
    sayHi()
    sayHi()
    sayHi()
    console.log(sayHi.age)


    let ss = {
        sayHi (){
            console.log('hi')
        },
        sayBye (a,b,c,...rest){
            console.log('bye')
        }
    }

    console.log(ss.sayBye.length)//3  函数一共接受多少个参数
~~~

### case05

~~~js
    'use strict';
    
    //阶乘递归  fn(5) = 5*3*2*1

    // function fn(x){
    //     //递归的出口
    //     if(x === 1)return 1;
    //     return x * fn(x-1)
    // }
    // console.log(fn(5))

    

    function showYes() {
            for (let index = 0; index < 5; index++) {
                console.log('我吃了我吃了')
                console.log('我吃了我吃了')
            }
        }

        function showYes2() {
            for (let index = 0; index < 5; index++) {
                console.log('睡醒了睡醒了')
                console.log('睡醒了睡醒了')
            }
        }

        function showNo2(){
            for (let index = 0; index < 5; index++) {
                console.log('还没睡醒')
                console.log('还没睡醒')
            }
        }

        function showNo() {
            for (let index = 0; index < 5; index++) {
                console.log('还没吃饱还没吃饱')
                console.log('还没吃饱还没吃饱')
            }
        }

        function ask(question,yes,no) {
            if (confirm(question)) {
                //选择正确
                yes()
            } else {
                //选择错误
                no()
            }
        }

        // ask('你吃了吗',showYes,showNo)
        ask('你睡着了吗',showYes2,showNo2)
~~~

## day16-api

### 常用api-数值

~~~js
    'use strict';
    /* 
        api 就是js 向开发人员提供的一些列处理数据类型的方法(function)

        学习api的时候需要关注三个信息
        - api 的作用
        - 是否会改变原数据
        - api 的返回值是什么
    */

    let num = 1_000_00_0 //_可以用在数值让数值可读性更强不影响数值的具体指

    //num.toFixed(index) 作用将数值小数部分超出index位的部分删除,不会改变元数据
    let num1 = 123123.345354653657

    // console.log(num1.toFixed(2)) //123123.35

    //自己封装
    function tofixed(num,index){
        let str = ''
        let i = 0
        let numStr = String(num)
        //检索下标
        function indexOf(str,ta){
            for (let k = 0; k < str.length; k++) {
                if(str[k] === ta){
                    return k
                }
            }
            return -1
        }
        //获取到点后面的index位
        let max = indexOf(numStr,'.')+index
       
        for (let k = 0; k <= max; k++) {
           str += numStr[k]
        }
        console.log(str)
    }
    // tofixed(num1,2)


    //num.toString(base) 方法将数值转换为字符串 , base 表示进制,以某种进制进行转换为字符串 , 返回值是字符串
    // console.log(num.toString(2))//11110100001001000000
    // console.log(num.toString(10))//1000000
    // console.log(num.toString(16))//f4240

    //Number.parseInt(str) 方法会将str取整数,抹去小数部分,返回值是一个数值 , 从第一个数值开始转换转换到第一个不是数值的字符串就停止
    // console.log(Number.parseInt(123.123))
    // console.log(Number.parseInt('123.456'))
    // console.log(Number.parseInt('adsf')) //nan
    // console.log(Number.parseInt('123a')) //123
    // console.log(Number.parseInt('123$')) //123


    //Number.parseFloat(str) 保留小数 逐个转换,保留第一个.以后后续再出现其他的非数值字符串就停止转换
    console.log(parseFloat('123.456')) //123.456
    // console.log(Number.parseFloat('123.456a1')) //123.456
    // console.log(Number.parseFloat('123.45.6a1')) //123.456
    // console.log(Number.parseFloat('123a456a1')) //123


    //isFinte 和 isNaN 专门用于检测值是不是一个finte或者是一个nan
    // console.log(isNaN(123))//false
    // console.log(isNaN('a1sfd'))//true
    // console.log(isNaN(NaN))//true

    // console.log(isFinite(123.123))//true
    // console.log(isFinite('1asdfa'))//false
    // console.log(isFinite(39489083495435)) //true
    // console.log(isFinite(true)) // treu
    // console.log(isFinite(Infinity)) // false


    // let  arr = ['123','465','78.9',NaN,123,Infinity]

    // let sum = 0
    // for (let i = 0; i < arr.length; i++) {
    //     if(isFinite(arr[i])){
    //         sum += Number(arr[i])
    //     }   
    // }
~~~

### 常用api-字符串

~~~js
    'use strict';
    
     let str = 'asdfasfdAAAA'
     //字符串长度
    //  console.log(str.length) //字符串长度
    //  console.log(str[1]) //访问字符串的某个值


    //str.charAt(index) 访问字符串中的第几个字符串
    // console.log(str.charAt(1)) //s

    //str.charCodeAt(index) 返回字符串的第index字符的 unicode 编码
    // console.log(str.charCodeAt(0)) //97
    // console.log(str.charCodeAt(1)) //115
    let name = '徐星'
    // console.log(name.charCodeAt(1)) //26143

    //String.fromCharCode(unicode) 将unicode准换为字符串
    // console.log(String.fromCharCode(26143)) // s


    //字符串大小写之间的转换  toLowerCase()字符串全转小写 toUpperCase() 字符串全转大写
    // console.log(str.toUpperCase())
    // console.log(str.toLowerCase())


    //substring(indexStart,[,indexEnd]) 截取字符串 indexStart开始下标indexEnd结束的下标 , 范围包含起始不包含结束
    let stt = '徐星真是太可爱了'
    // console.log(stt.substring(5,7))//可爱
    // console.log(stt.substring(0,2))//徐星
    // console.log(stt.substring(3)) //是太可爱了
    // console.log(stt.substring(5,3)) //是太
    // console.log(stt.substring(3,5)) //是太
    // console.log(stt.substring(-3,5)) //徐星真是太
    // console.log(stt.substring(-5,3)) //徐星真
    /* 
        只有start的时候表示从开始截取到结束
        参数内部会进行一个调整,如果参数第一个大于第二个,在内部会将参数统一为第一个小于第二个
        如果传入的值小于0 或者是NaN会被当做0处理
    */


    //substr(startIndex,[,length]) 从 startIndex 下标开始,截取 length 位
    // console.log(stt.substr(0,2)) //徐星
    // console.log(stt.substr(5,3)) //可爱了
    // console.log(stt.substr(2)) //真是太可爱了


    //slice(startIndex,[,endIndex]) 跟 substing 参数一模一样
    //参数如果是负数值 ,表示 str.length-Index
    // let str2 = '今天真的太开心了' // 8 - 2 = 6  // 2
    // console.log(str2.slice(2,4)) // 真
    // console.log(str2.slice(-3,6)) // 开


    // split(string,[,lenght]) 将字符串以为string字符作为切割,切割为一个数组 , length 转换后的数组保留几个
    let str3 = '张三|男|16|180'
    // console.log(str3.split('|',2))//['张三', '男', '16', '180']
    // console.log(str3.split('|'))//['张三', '男', '16', '180']
    // console.log(str3.split())//['张三|男|16|180']
    // console.log(str3.split(''))//['张', '三', '|', '男', '|', '1', '6', '|', '1', '8', '0']


    //trim() 清除字符串左右两边的空格
    // let ueerName = prompt('你的网名是什么','张三')

    // if(ueerName.trim() === '张三'){
    //     console.log('欢迎张三进入直播间')
    // }


    //检索字符串的方法
    /* 
        str.indexOf(searchEle,[,fromeIndex])
        - searchEle 表示需要检索的字符串或者元素
        - fromeIndex 从第几个开始检索
        返回值找到第一个满足的就返回他的下标位置
        如果找不到返回 -1 


        str.lastIndexOf(searchEle,[,fromeIndex]) 跟indexof一样不过他是反着回去找
    */

    let str5 = '你好我叫徐星,我今年8岁'
    // console.log(str5.indexOf('我')) //2 默认从下标0开始找,找到第一个满足的就返回他的下标位置
    // console.log(str5.indexOf('我',3)) //7
    // console.log(str5.lastIndexOf('我')) //7

    /* 
        str.includes(ele) 检索字符串中是否存在ele元素 
        str.startsWith(ele) 检索字符串中的开头字符换是不是ele
        str.endsWith(ele) 检索字符串中的结尾字符换是不是ele

        返回值为布尔值 有就返回true
    */
   
    // console.log(str5.includes('徐星')) //true
    // console.log(str5.includes('许星')) //false
    // console.log(str5.includes('许星')) //false

    let urlStr = 'https://www.baidu.com'
    // console.log(urlStr.startsWith('https')) // true
    // console.log(urlStr.startsWith('http')) // true
    // console.log(urlStr.endsWith('com')) // true
    // console.log(urlStr.endsWith('cn')) // false
    // console.log(urlStr.endsWith('png')) // false

    //str.repeat(index) 将str重复拼接index次 ,返回一个新的字符串
    // console.log(str5.repeat(10))

    /* 
        replace(seStr,newstr) || replaceAll
        seStr 需要替换的值
        newstr 替换后的值

        作用 将 seStr 选中的字符串替换为 newstr 字符串
        返回值是一个新的字符串

        replace只能替换满足条件的第一个 , replaceAll替换满足条件的所有
    */

    let str6 = '徐星真可爱,超级可爱'
    console.log(str6.replace('可爱','丑陋')) //只会替换第一个满足条件的选项

    //全部替换
    while (str6.includes('可爱')) {
        str6 = str6.replace('可爱','丑陋')   
    }

    //全部替换
    console.log(str6.replaceAll('丑陋','美丽')) 
~~~

### 常用api-数组类型

~~~js
    'use strict';

    //Array.isArray(ele) 用于判断ele是不是一个数组,如果是返回true
    // console.log(Array.isArray('123'))// fase
    // console.log(Array.isArray([]))// fase

    //Array.from(iterEle) 将iterEle数据转换为一个数组 
    // console.log(Array.from('123')) //['1', '2', '3']
    // function fn(){
    //     console.log(arguments)
    //     console.log(Array.from(arguments))// ['123', 123, 12, 31, 23, 1]
    // }
    // fn('123',123,12,31,23,1)

    /* 
        数组增删四件套
        push(..data) 为数组最后一项添加一个或者多个data数据,返回值是数组的长度
        pop()删除数组中最后一项数据, 返回值是删除的那个值

        unshift(...date) 头部添加一个或者多个数据,回值是数组的长度
        shift() 删除第一个数据返回删除的数据
        重点该系列的方法都会改变原数据
    */

    let arr = [1,2,3]

    //push(...data) 为数组的最后一项添加一个data数据
    // console.log(arr.push(4)) // 4
    // console.log(arr.push(5,6)) //6
    // console.log(arr.push('7')) //7

    //删除最后一项
    console.log(arr.pop())

    arr.unshift('5','6','7')
    arr.shift()
~~~

## day17-api下

### 数组api

~~~js
 <script>
    'use strict';
    /* 
        concat(arr1,[,arr2,....]) 数组合并 
        作用: 将多个数组合并为一个数组
        返回值是合并后的新数组,不会改变原数据
    */
    let arr1 = [123,45]
    let arr2 = [65,77]
    // let newArr1 = [].concat(arr1,arr2)
    let newArr2 = arr1.concat(arr2)//[123, 45, 65, 77]


    /* 
        flat(num) 数组降维
        将多维数组降低num维度
    */

    let arr3 = [123,456] //一维数组
    let arr4 = [123,456,[67,89]] //二维数组
    let arr5 = [123,456,[67,[56,67],89]] //三维数组
    let arr7 = [123,456,[67,[56,[565665,[123123,[12313,[213]]]],67],89]] //三维数组
    let arr6 = [[1,1],[1,2],[9,9]] //二维数组

    // console.log(arr4.flat(1))
    // console.log(arr5.flat(2))
    // //降低到一维数组
    // console.log(arr7.flat(Infinity))


    /* 
        join(str) 方法
        作用:将数组以str作为分隔拼接成为一个字符串
        不会改变原数组
    */

    let arr8 = ['你好','我好','大家好']
    // console.log(arr8.join('')) //你好我好大家好
    // console.log(arr8.join('-')) //你好-我好-大家好


    /* 
    slice(beginIndex,[,endIndex])
    数组切割 从 beginIndex 开始切割到 endIndex 包含起点不包含终点
    不会改变原数组
    */
   
    // console.log(arr8.slice(0,2))
    // console.log(arr8.slice(1,2))

    /* 
        splice(startIndex,deleteCount,[,item1,...item2n])
        既可以截取也可以替换还可以用来新增数据
        - startIndex 从什么位置开始截取
        - deleteCount 截取几位
        - item1-itemn 需要替换的数据


        会改变原数据
        返回值是截取部分的内容
    */

    let numArr = [7,56,234,54,875,9,0,2,354,7]

    //截取功能
    // console.log(numArr.splice(2,2)) //[234, 54]

    //替换 将截取部分的内容换为你传入的替换内容
    numArr.splice(2,2,'234','54','78') // [7, 56, '234', '54', '78', 875, 9, 0, 2, 354, 7]

    //添加
    numArr.splice(3,0,'你好')


    // //pop()
    numArr.splice(numArr.length-1,1)

    //shift()
    numArr.splice(0,1)

    //unshift()
    numArr.splice(0,0,'unshift')

    //push()
    numArr.splice(numArr.length,0,'push')


    /* 
        reverse()
        翻转数组
        123 => 321
        会改变原数组
    */
    // console.log(arr8.reverse())
        
    </script>
~~~

### 数组api2

~~~js
    <script>
    'use strict';
    /* 
        数组遍历高级方法
        arr.forEach(callback,thisArg)
        callback(item,index,arr) 
        - 接受一个回调函数作为参数
        - 该回调函数的参数分别为 item 表示当前数组的每一项值,index 当前数组值对应的下标, arr 当前遍历的数组

        thisArg 手动指定 this
        默认 thisArg 是undefined
        可以手动指定回调函数内部的this
        回调函数是普通函数的时候第二个参数才有用

        foreach没有返回值
    */

    let arr = [6,4,7,8,45,66,789,46]
    let arr2 = [999,888]

    let arr3 = ['name','age','sex']
    let arr4 = ['程力',18,'未知']
    let obj = {}

    // arr.forEach((item,index,arr)=>{
    //     console.log(item)
    //     // console.log(index,'值对应的下标')
    //     // console.log(arr,'当前遍历的数组')
    // })

    arr3.forEach( function(item,index,arr){
        obj[item] = this[index]
        // console.log(index,'值对应的下标')
        // console.log(arr,'当前遍历的数组')
    },arr4)

    /* 
        map 参数跟foreach一模一样
        map的返回值是每个数据都进行一次回调函数处理后的新数组
    */

    let ageArr = [23,5,45,78,12,8]

    //期望值将 agearr = > ['23岁','5岁'...]
    let newAgeArr = ageArr.map((item,index)=>{
        // return item+'岁'
        return item+'岁'
    })



    //手写一个map
    function myMap(arr,callback,thisArg){
        let newArr = []
        for (let i = 0; i < arr.length; i++) {
            let newItem =  callback(arr[i],i,arr)
            newArr.push(newItem)
        }
        return newArr
    }
    let newAge =  myMap(ageArr,function(item,index,arr){
        // console.log(item)
        return item+'岁'
    })
    </script>
~~~

## day18-api下下

### 数组api

~~~js
    <script>
    'use strict';
    /* 
        filter()传入的参数和foreach一样
        返回值是一个新的数组, 这个数组是满足filter回调函数返回值的所有结果组成的一个新数组
    */
   let ageArr = [17,78,45,67,12,,'123','465',3,4,69,55,8,0]
   //删选出小于18岁的用户年龄


   //原生写法
//    let arr = []
//    for (let index = 0; index < ageArr.length; index++) {
//         const element = ageArr[index];
//         if(element < 18){
//             arr.push(element)
//         }
//    }


    //高级方法
    let newArr =  ageArr.filter(item=>{
        //return 一定还要返回一个表达式,如果表达式成立就会将这个值作为新数组的一项返回出去
        // return item < 18 //返回item小于18的值,组成一个新的数组
        return typeof item === 'string'
    })


    //手写一个myFilter
    function myFilter(arr,callback,thisArg){

        let newArr = [] //新数组

        for (let i = 0; i < arr.length; i++) {

            let bol =  callback(arr[i],i,arr)

            bol && newArr.push(arr[i]) //item满足条件就添加
        }
        return newArr
    }

    let arrNew = myFilter(ageArr,item=>{
        return  typeof item === 'string'
    })



    let str = "张三|男|李四|女|王五|男|赵六|女|田七|女"

    //首先考虑改为数组处理
    //过滤出所有用户名
    let strArr = str.split('|').filter((item,index)=>{
        // return item.length > 1
        return index % 2 == 0
    })


    /* 
        reduce(callback,Initialvalue) 归并
        callback(acc,curr,index,arr)
        - acc 初始值
        - curr 当前值
        - index 当前值的下标
        - arr 当前遍历的数组

        Initialvalue 初始值

        返回值是最终归并后的结果 也就是acc的值
    */

    let numArr = [1,2,3,4]

    //计算数组中所有数值的和
    //原生的写法
    function renduce(arr){
        let  result = 0

        for (const vlaue of arr) {
            result += vlaue
        }
        return result
    }
    renduce(numArr)
    

    //reduce 写法
    let sum =  numArr.reduce((acc,curr,indx,arr)=>{
        
        return acc + curr
    },0)





    //原理
    function myReduce(aThis,callback,Initialvalue){//1

        for (let i = 0; i < aThis.length; i++) {
            
            Initialvalue =  callback(Initialvalue,aThis[i],i)

        }
    }

    let result =  myReduce(numArr,(acc,curr,indx,arr)=>{

        return acc + curr
    },0)



    let url = 'https://www.baidu.com?name=afei&age=18&sex=nan'
    function parseUrl(urlStr){
        return urlStr.split('?')[1].split('&').reduce((acc,curr)=>{
            let paramArr = curr.split('=')
            acc[paramArr[0]] = paramArr[1]
            return acc
        },{})
    }
    // console.log(parseUrl(url))


    /* 
        some() 参数和foreach一样
        返回值: 数组中至少有一个元素通过some回调函数返回值的测试,就返回true,否则返回false

        检测数组中有没有满足条件(回调函数的返回值)的值,有一个满足就返回true
    */

    //检测数组中有没有值大于18
    let res =  [1,3,4,546,657,34,2].some(item=>{
        return item > 18 //返回条件,如果有元素满足这个条件就返回true
    })

    /* 
        every() 写法和some一模一样,区别在于some是只要有一个满足条件就返回true
        every是必须每个元素都满足条件才会返回ture
    */

    let res1 =  [1,3,4,546,657,34,2].every(item=>{
        return item > 0 //如果每个元素的值都大于0就返回true
    })

    /* 
        find 和 findIndex
        find() 跟some 很像,区别在于他返回的值是满足条件的第一个值,没有满足条件的值返回 undefined 

        findIndex() 跟find功能一样,但是返回的值是满足调价你的第一个值的下标
    */


    let res2 =  [34,456,456,34,3,5,7].find(item=>{
        return item > 300//返回第一个满足条件的值
    })

    let res3 =  [34,456,456,34,3,5,7].findIndex(item=>{
        return item > 300//返回第一个满足条件的下标
    })
    </script>
~~~

### 数组api

~~~js
    <script>
        'use strict';
        /* 
            [1,2,3,4,5].reverse() 数组翻转
    
            会改变原数组
        */
        // let arr = [1,2,3,4,5]
        // arr.reverse()


        /* 
            sort(callback) 数组排序
            callback(a,b) 
            a 表示第一个用于比较的值
            b 表示第二个用于比较的值
    
            calllback 返回值 为 a - b 那就是升序排列
                    返回值 b - a 那就是降序排列
    
            根据callback 返回值决定第一个比较的值和第二个比较的值是否需要更换位置 如果 小于0不更换位置, 大于0互换位置
    
            会改变原数组
        */

        let arr = [5, 1, 3, 2, 4]

        // arr.sort((a,b)=>{
        //     // return a - b //升序排列
        //     return b - a //降序排列
        // })

        //冒泡排序
        /* 
            实现的逻辑
            1. 让数组的每一个数据与他的后方一个数据进行比较
                - 用循环让他们进行一次对比
                - 判断当前项和下一项的大小关系
            2. 如果当前数据大于后面的数据那就互换位置
                - 如果当前值大于后面的值需要借助中间变量进行值的交换
                - 循环为每一个数据进行比较
        */

        let temp = null

        for (let index = 0; index < arr.length; index++) {
            for (let i = 0; i < arr.length - index; i++) {
                if (arr[i] > arr[i + 1]) {
                    //当前项大于后面的值
                    //互换位置
                    //借助一个中间变量临时存储一个值
                    temp = arr[i]
                    arr[i] = arr[i + 1]
                    arr[i + 1] = temp
                }
            }

        }
    </script>
~~~

## day19-api下下下

### 对象api

~~~js
    <script>
    'use strict';
    /* 
        对象就是一系列无序的属性和方法的集合
    */
    
    //1. 字面量
    let myCat = {
        name:'无限',
        color:'black',
        speak:function(){
            console.log('喵喵喵')
        }
    }
    //2. 通过原生构造函数创建一个对象
    let xuxingCat = new Object()
    xuxingCat.name = '嘻嘻'
    xuxingCat.color = 'red'
    xuxingCat.speak = function(){
        console.log('喵喵喵')
    }

    //3. 工厂函数
    function createCat(name,color){
        let xuxingCat = new Object()
        xuxingCat.name = name
        xuxingCat.color = color
        xuxingCat.speak = function(){
            console.log('喵喵喵')
        }
        return xuxingCat
    }

    let jiuweiCat = createCat('jiujiu','blue')

    //4. 构造函数创建对象
    function Cat(name,color){
        this.name = name
        this.color = color
        this.speak = function(){
            console.log('喵喵喵')
        }
    }
    
    let zhuqueCat = new Cat('miaomiao','pink')

    //instanceof 关键词用于检测该对象是属于哪个构造函数创建的
    console.log(zhuqueCat instanceof String ) //false
    console.log(zhuqueCat instanceof Cat ) //true
    console.log(zhuqueCat instanceof Object ) //true

    let str = '123'
    let ssttrr = new String('adsfafds')
    console.log(str instanceof String) // false
    console.log(ssttrr instanceof String) // false

    /* 
    hasOwnProperty(prop)
    obj.hasOwnProperty(prop) 作用是检测属性prop是否在obj对象中
    */

    let obj = {
        name : 'xuixing',
        age : 18
    }
    
    console.log(obj.sex)
    // console.log(obj.__proto__)
    console.log(obj.hasOwnProperty('sex')) //fasle
    console.log(obj.hasOwnProperty('age')) //true
    console.log(obj.hasOwnProperty('__proto__')) //true


    /* 
        in 操作符
        语法 prop in obj
        检测prop属性(包含原型上看不到的属性)是否存在于obj对象中
    */
   console.log('__proto__' in obj) //true
   console.log('toLocaleString' in obj) // true
   console.log('hasOwnProperty' in obj) // true


   /* 
        assgin(obj1,obj2,obj3) 方法 
        作用将 多个对象合并到第一个参数的对象身上
   */

   let a = {name:'a'}
   let b = {age:'12'}
   let c = {sex:'nan'}

//    console.log(Object.assign(a,b,c))//{name: 'a', age: '12', sex: 'nan'} a对象也被修改了
   console.log(Object.assign({},a,b,c))//{name: 'a', age: '12', sex: 'nan'} a对象也被修改了
        
    </script>
~~~

### 对象api

~~~js
    <script>
    'use strict';
    /* 
        Object.is(value1,value2)
        作用 : 用于做值的比较,比较value1和value2是不是同一个值
    */

    // console.log('123' == 123)
    // console.log(Object.is('123',123))//false
    // console.log(Object.is(0,false))//false

    // console.log(Object.is(NaN,NaN))//true
    // console.log(Object.is(NaN,123-'asdf'))//true

    // console.log(undefined == null)//true
    // console.log(Object.is(undefined,null))//false

    // console.log(-0 == +0)//true
    // console.log(-0 === +0) //true
    // console.log(Object.is(-0,+0)) //false


    /* 
        Object.keys(obj)
        作用将对象中的所有属性名抽离出来返回一个数组
    */
   
    let obj = {
        name : 'xuxing',
        age : 19,
        sex : '男',
        like : ['唱歌','跳舞','rap','打篮球']
    }

    let objKeyArr = Object.keys(obj)

    objKeyArr.forEach(item=>{
        // console.log(obj[item])
    })

    /* 
        Object.values()
        作用将对象中的所有属性值抽离出来返回一个数组
    */
    let objValueArr = Object.values(obj)

    /* 
        Object.entries(obj)
        作用:将obj对象的属性名和属性值组合成一个数组,最终返回一个二维数组
    */
    let entries = Object.entries(obj)

    entries.forEach(item=>{
        // console.log(item[0],item[1])
    })




    let data = {name: "afei", age: "18",sex:'nan'}

    //地址栏优化
    function disUrl(data){
        return Object.entries(data).map(item=>item.join('=')).join('&')
    }

    disUrl(data)

    /* 
        Object.freeze(obj)
        作用:用于将obj对象进行冻结,冻结以后的对象不可以再进行任何的修改
        返回值就是冻结后的对象
    */

    Object.freeze(data)

    /* 
        Object.isFrozen(obj)
        检测对象是否是冻结的对象
        返回值布尔值,true表示已经被冻结
    */
   
    console.log(Object.isFrozen(data)) // treu


    /* 
        obj.valueOf()
        方法会返回指定对象的原始值
    */

    let arr = [1,'2',false]
    console.log(arr.valueOf()) // [1, '2', false]

    let date = new Date(2013,10,1)
    console.log(date.valueOf()) // 1383235200000
        
    </script>
~~~

### json对象

~~~js
    <script>
        'use strict';
        /* 
            JSON 对象,表示对象的通用格式,(对象的标准写法)
    
            总结, JSON 就是对象的标准版写法,用于不同语言的数据传输
    
            josn对象的写法
            对象的属性名必须是一个字符串
            例如 "name" : "xuxing"
            每个数据之间必须有逗号隔开
            使用大括号保存对象,对象可以包含若干数据
            使用方括号保存数组, 数组用,进行分割
    
            JONS的方法
            JSON.stringfy()将对象转换为 JSON 字符串
            JSON.pares() 将JSON格式的字符串转换为普通对象
            
    
            JSON格式支持的数据类型
            - Object {}
            - Arrays []
            - 原始类型
                string
                number
                boolean
                null
        */

        let data = {
            name: "afei", 
            age: 18, 
            sex: 'nan', 
            eat : {
                xixi : '苹果'
            },
            marry : undefined,
            say() {
                console.log('xixixi')
            }, 
            like: ['唱歌','跳'],
            Symbol : Symbol()
        }

        let dataJSON = JSON.stringify(data)


        console.log(JSON.parse(dataJSON))

        //循环引用无法转换JOSN格式
        let user = {
            name : 'afei'
        }

        let admin = {
            jiuwei : {
                name : 'jiuwei'
                ,age : 19
            }
        }

        //建立循环引用
        admin.afei = user
        user.jiuwei = admin

        // console.log(JSON.stringify(admin)) //报错


        //数组去重
        let arr = [1,2,3,1,2,,NaN,3,NaN,null,null,{a:1},{a:1}]

        function unique(arr){
            let newArr = []
            let tempARr = []//存储json格式的数据
            arr.forEach(element => {
                if(!newArr.includes(element)){
                    if(!tempARr.includes(JSON.stringify(element))){
                        newArr.push(element)//真实数据添加到newArr
                        tempARr.push(JSON.stringify(element))//存储json字符串格式的数据
                    }
                }
            });
            console.log(newArr)
        }

        unique(arr)



        //数组去重
        let newARr = arr.filter((item,index)=>{
            return arr.indexOf(item) === index// 当前遍历的下标和他在数组中第一次出现的下标相同,我就保留
        })


        //去重2
        function uniq(arr){
            return arr.reduce((acc,curr)=>{
                acc.some(item=>Object.is(item,curr))?acc:acc.push(curr)
                return acc//[]
            },[])
        }

        console.log(uniq(arr))
    </script>
~~~

## day20-内置对象

### 数学对象

~~~js
    <script>
    'use strict';
        /* 
            Math 数学对象

            Math 对象下存储了一些列处理数学计算的一些方法和一些常用的数学特殊值
        */

        //静态方法
        Math.E  //属性表示自然对数的底数（或称为基数），e，约等于 2.718。
        Math.LN10 //属性表示 10 的自然对数，约为 2.302：
        Math.LN2 // 属性表示 2 的自然对数，约为 0.693：
        Math.LOG10E //属性表示以 10 为底数，e 的对数，约为 0.434：
        Math.LOG2E //属性表示以 2 为底数，e 的对数，约为 1.442：
        Math.PI //表示一个圆的周长与直径的比例，约为 3.14159：
        Math.SQRT1_2 // 属性表示 1/2 的平方根，约为 0.707：
        Math.SQRT2 //属性表示 2 的平方根，约为 1.414：

        //数学方法
        //Math.abs(num) 用于取一个数值的绝对值
        // console.log(Math.abs(1)) //1
        // console.log(Math.abs(-10)) // 10
        // console.log(Math.abs(null))//0
        // console.log(Math.abs('abc'))//NaN
        // console.log(Math.abs('-123'))//123
        // console.log(Math.abs('-123abc'))//NaN

        /* 
            Math.cos(x) 余弦值
            Math.sin(x) 正弦值
            Math.tan(x) 正切值
            
            x 参数需要传入一个弧度值
            返回值就是 -1 - 1 之间的数值 ,单位弧度
        */

        // console.log(Math.cos(1)) //0.5403023058681398
        // console.log(Math.sin(1)) //0.8414709848078965
        // console.log(Math.tan(0.5)) //0.5463024898437905


        /* 
            Math.pow(base,exp)
            函数返回bae的exp次幂的结果
        */

        // console.log(Math.pow(2,3))//8
        // console.log(Math.pow(10,3))//1000\


        /* 
            Math.sqrt(x) 平方根 开方
            函数返回一个数的平方根的结果 ,  a*a + b*b = Math.sqrt(a*a + b*b ) 
        */

        // console.log(Math.sqrt(9)) //3
        // console.log(Math.sqrt(1)) //1


        //勾股定理
        function calcGouGu(a,b){
            return Math.sqrt((a*a)+(b*b))
        }

        // console.log(calcGouGu(5,12)) //13
        // console.log(calcGouGu(5,5)) //7.0710678118654755


        /* 
            Math.floor() 向下取整数
            Math.ceil() 向上取整
            Math.round() 四舍五入
        */

        // console.log(Math.floor(3.5))//3
        // console.log(Math.floor(3.6))//3
        // console.log(Math.floor(-3.5))//-4
        // console.log(Math.ceil(2.4))//3
        // console.log(Math.ceil(-2.9))//-2

        // console.log(Math.round(3.5))//4
        // console.log(Math.round(3.3))//3
        // console.log(Math.round(3.4))//3
        // console.log(Math.round(-3.4))//-3
        // console.log(Math.round(-3.6))//-4



        /* 
            Math.max(p1,p2....pn)
            Math.min(p1,p2....pn)
            获取最大值和最小值
            返回值是传入的所有值里面的最大值或者最小值
        */

        // console.log(Math.max(1,2,3,46,65,2))
        // console.log(Math.min(1,2,3,46,65,2))
        // let xxx = 100
        // console.log(Math.min(xxx,200))


        // let age = [12,45,34,78,3,5,67]
        // console.log(Math.max(age[0],age[1]))
        // console.log(Math.max(...age))//78


        /* 
            Math.random() 随机数
            方法会返回一个小数,该小数产生的范围是0-1之间随机产生一个小数值,
            包含0 但是不包含1
        */

        let nameArr = ['林晨曦','缇按','汤子星','王旭','刘学云','张辉','快乐的小数','徐星']

        //需要随机生成一个 0 - 6之间的整数
        // let  index =  parseInt(Math.random()*7)
        // let  index =  parseInt(Math.random()*nameArr.length)
        // console.log(nameArr[index])


        //生成一个范围的随机值  5-10 之间的随机值  (10 - 5+1)
        let  index =  parseInt(Math.random()*6+5)
        console.log(index)

        function getRandomInt(min,max){
            return parseInt(Math.random()*(max-min+1)+min)
        }
        console.log(getRandomInt(200,205))
        console.log(nameArr[getRandomInt(3,7)])
    </script>
~~~

### 日期对象

~~~js
    <script>
    'use strict';
    /* 
        Date对象
        创建一个日期时间, Date对象获取到的时间是基于1970年1月1日到至今的毫秒数,又称为世界标准时间,协调世界时间
    */

    //创建和获取时间
    let dateNow = new Date()//获取当前计算机时间

    //手动设置一个时间
    /* 
        设置时间的参数
        - new Date(年,月,日,时,分,秒) 不传递的参数默认是0 
        通过参数设置的月份会比原来更大1 ,因为时间的月份是从0开始计算的

        - 通过日期对象能识别的字符串格式传递 
            - 年-月-日
            - 年/月/日
            - 通过字符串形式设置的日期月份不会+1
    */
    let oldDay = new Date(2022,7,25)
    let oldDay2 = new Date('2022/8/25')
    let oldDay4 = new Date('1970/1/2')
    let oldDay3 = new Date('2022-8-25')//Thu Aug 25 2022 00:00:00 GMT+0800 (中国标准时间)

    //Date.parse() 解析时间日期字符串并且返回毫秒数
    console.log(Date.parse('2022-1-1')) //1640966400000
    console.log(Date.parse('Thu Aug 25 2022 21:39:30 GMT+0800 (中国标准时间)')) //1640966400000

    //Date.now() 获取当前的时间戳
    console.log(Date.now())
    console.log(oldDay4.valueOf())

    console.log(dateNow)

    //访问时间
    console.log(dateNow.getTime(),'将日期转换为毫秒数')
    console.log(dateNow.getFullYear(),'日期的年')
    console.log(dateNow.getMonth()+1,'日期的月') //获取到的月份是从0开始计算需要+1
    console.log(dateNow.getDate(),'日期的日')
    console.log(dateNow.getDay(),'星期几')
    console.log(dateNow.getHours(),'小时')
    console.log(dateNow.getMinutes(),'分钟')
    console.log(dateNow.getSeconds(),'秒钟')


    //设置日期 方法跟 get系列一模一样, 但是换成了 set系列
    console.log(dateNow.setFullYear(2023),'将日期转换为毫秒数')
    </script>
~~~

### 日期对象

~~~js
    <script>
    'use strict';
    /* 
        日期对象的运算

        data获取到的时间都是可以转换为时间戳进行运算的,
        时间对象在做运算的时候会默认调用valueOf转换为时间戳数值进行计算
    */

    let now = new Date()//获取当前时间
    let guoqing = new Date('2022-10-1')

    // now.valueOf()
    // now.getTime()
    // console.log(+now) //1661435643079
    let timeG = guoqing - now
    //将毫秒值转换为年月日
    // console.log(timeG / 1000 / 60 / 60 / 24) //天
    // console.log(timeG / 1000 / 60 / 60 % 24 ) //小时
    // console.log(timeG / 1000 / 60 % 60 ) //分钟
    // console.log(timeG / 1000 % 60 ) //分钟


    //时间格式化
    //1. toDateString() 返回的是星期,月,日,年
    console.log(now.toDateString())
    //2 toTimerString() 返回时分秒时区
    console.log(now.toTimeString())
    //3, toLocaleDateString() 返回年月日
    console.log(now.toLocaleDateString())//2022/8/25

    //5, toLocaleTimerString() 时分秒
    console.log(now.toLocaleTimeString())//22:01:53

    //6 toUTCString() 返回对应的utc时间,也就是国际标准时间
    console.log(now.toUTCString())

    //tolocalesting() 格式化本地时间
    console.log(now.toLocaleString())//2022/8/25 22:04:37

    //时间戳可以进行比较运算
    console.log(now > guoqing)
    </script>
~~~

### map集合

~~~js
    <script>
    'use strict';
    /* 
        对象 存储无序结合通过键值对
        数组 存储有序结合, 直接存储具体的值

        map数据结构
        对象属性名只能存在字符串,map集合可以允许在数据结构中以 任意类型的数据作为键名进行存储
        mpa就是一个带键值对存储数据的集合,  和object 一样,但是他可以用任意数据类型作为属性名进行存储,并且每个属性名只能存在一个

        自带的方法
        - 创建map  new Map()
        - map.set(key,value) 新增数据
        - map.get(key) 获取数据
        - map.delete(key) 删除数据
        - map.has(key) 检索数据是否存在
        - map.ckear() 清空集合
        - map.size  当前集合一共有多少条数据
    */

    let map = new Map()
    //新增数据
    map.set('a','113')
    map.set(true,'adf')
    let fn = function(){}
    map.set(fn,'baffd')
    map.set([1,23,4],'arrr')


    //取值
    // console.log(map.get('a'))
    // console.log(map.get(true))
    // console.log(map.get(fn)) //baffd
    
    //检索值是否存在
    // console.log(map.has(fn))//true

    //删除一个值
    map.delete(true)

    //删除所有值
    // map.clear()

    //检查数据长度
    // console.log(map.size)



    //创建并且存储值
    let map1 = new Map([
        ['key','vlaue'],
        [false,'boolean'],
        [function(){},'function'],
    ])


    let obj  = {
        name : '徐星',
        age : 19,
        sex : '男'
    }
    //将对象转换为map集合
    let map2 = new Map(Object.entries(obj))

    map2.set('name','afei')

    //遍历map集合
    /* 
        keys() 遍历所有的键名
        values() 遍历所以逇值
        entries() 
        返回值是一个可迭代对象, 可以用forof来进行遍历
    */

    // for (const item of map2.keys()) {
    //     console.log(item)
    // }

    // for (const item of map2.values()) {
    //     console.log(item)
    // }

    // for (const item of map2.entries()) {
    //     console.log(item)//['name', 'afei']
    // }

    // for (const item of map2) {
    //     console.log(item)//['name', 'afei']
    // }
    

    // map2.forEach(item=>{
    //     console.log(item)//只能获取到属性值
    // })



    //利用map进行数组去重
    let arrr = [1,1,2,2,{a:1},{a:2},{a:1},NaN,NaN,undefined,undefined,function a(){},function a(){},function b(){}]

    function uniqu(arr){
        //新数组和map集合
        let newArr = [],map = new Map()

        for (let i = 0; i < arr.length; i++) {
            if(typeof arr[i] === 'object'){
                ///是一个对象\
                let deep = JSON.stringify(arr[i])
                //将数据存储到map集合中
                map.set(deep,arr[i])
            }else{
                //不是引用类型
                map.set(`${arr[i]}`,arr[i])
            }
        }

        //把map中的所有值添加到数组
        for (const item of map.values()) {
            newArr.push(item)
        }

        console.log(newArr)
    }
    uniqu(arrr)
    </script>
~~~

## day21-map-set解构赋值

### set集合

~~~html
<!DOCTYPE html>
<html lang="zh-cn">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
          *{margin: 0;padding: 0;}
    </style>
</head>
<body>
    <div id="app"></div>
    <script>
    'use strict';
    /* 
        set 也是一个特殊的集合 , 这个集合跟map类型但是他没有key值 , 存储的方式类似于数组, set集合中的值永远只能出现一次, 可以理解为set集合就是一个自带去重效果的类数组

        方法集合
        - new Set() 创建set集合
        - set.add(value) 添加一个value值, value值可以是任意类型的值
        - set.delete(value) 删除value值
        - set.has(value) 检测value是否存在
        - set.clear() 清空集合
        - set.size  返回元素个数
    */

    let set = new Set()



    //创建的同时添加数据
    let set1 = new Set([1,2,2,3,4])
    

    //遍历set集合
    /* 
        keys()
        values()
        entries()
    */
    
   

    //存储值
    set.add('xuxing')
    set.add('jiuwei')
    set.add('wuxian')
    set.add('wuxian') //重复添加没有效果
    set.add('qixi')
    set.add({a:1}) 

    let arr = []
    arr.push(1)
    arr.push(1) // [1,1]

    //删除值
    set.delete('jiuwei')

    //检测
    set.has('jiuwei') //fasle

    
    //数组去重
    let oob = {a:1}
    let arrr = [1,1,2,2,oob,oob,{a:1},NaN,NaN,undefined,undefined,function a(){},function a(){},function b(){}]

    //利用set进行数组去重方案一
    let set2 = new Set(arrr)
    let newArr = []
    for (const item of set2) {
        newArr.push(item)
    }

    //数组去重方案二
    let newArr2 = [...new Set(arrr)]

    // console.log([...'asdfsafd'])

    </script>
</body>
</html>
~~~

### weakMap

~~~html
<!DOCTYPE html>
<html lang="zh-cn">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
          *{margin: 0;padding: 0;}
    </style>
</head>
<body>
    <div id="app"></div>
    <script>
    'use strict';
    /* 
        set 也是一个特殊的集合 , 这个集合跟map类型但是他没有key值 , 存储的方式类似于数组, set集合中的值永远只能出现一次, 可以理解为set集合就是一个自带去重效果的类数组

        方法集合
        - new Set() 创建set集合
        - set.add(value) 添加一个value值, value值可以是任意类型的值
        - set.delete(value) 删除value值
        - set.has(value) 检测value是否存在
        - set.clear() 清空集合
        - set.size  返回元素个数
    */

    let set = new Set()



    //创建的同时添加数据
    let set1 = new Set([1,2,2,3,4])
    

    //遍历set集合
    /* 
        keys()
        values()
        entries()
    */
    
   

    //存储值
    set.add('xuxing')
    set.add('jiuwei')
    set.add('wuxian')
    set.add('wuxian') //重复添加没有效果
    set.add('qixi')
    set.add({a:1}) 

    let arr = []
    arr.push(1)
    arr.push(1) // [1,1]

    //删除值
    set.delete('jiuwei')

    //检测
    set.has('jiuwei') //fasle

    
    //数组去重
    let oob = {a:1}
    let arrr = [1,1,2,2,oob,oob,{a:1},NaN,NaN,undefined,undefined,function a(){},function a(){},function b(){}]

    //利用set进行数组去重方案一
    let set2 = new Set(arrr)
    let newArr = []
    for (const item of set2) {
        newArr.push(item)
    }

    //数组去重方案二
    let newArr2 = [...new Set(arrr)]

    // console.log([...'asdfsafd'])

    </script>
</body>
</html>
~~~

### weakMap练习

~~~html
<!DOCTYPE html>
<html lang="zh-cn">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
          *{margin: 0;padding: 0;}
    </style>
</head>
<body>
    <div id="app"></div>
    <script>
    'use strict';
    /* /
        记录用户访问次数的函数

        创建一个集合 用于存储用户的信息, 和用户访问的次数

        当用户访问的时候记录用户访问了几次
        用户重复访问的时候更新用户访问的次数
        用户注销了账号,清空用户的所有访问记录
    */

    let userCountMap = new WeakMap()

    let tangzixing = {name : '汤子星'}

    //记录和更新用户放的次数
    function countSet(user){
        //检测用户是否访问过,如果访问过就增加一次访问次数,没有访问过就设置默认1
        let count =  userCountMap.get(user) || 0
        userCountMap.set(user,count+1)
    }

    countSet(tangzixing)
    countSet(tangzixing)
    countSet(tangzixing)
    countSet(tangzixing)

    //tangzixing注销了账号
    tangzixing = null


    //WeakSet 存储方式跟 set 一模一样, 区别就是 弱映射和强映射, 存储的值也必须是对象

    let xx = {name:'xx'}
    let yy = {name:'yy'}

    let weakSet = new WeakSet()
    weakSet.add(xx)
    weakSet.add(yy)

    yy = null
        
    </script>
</body>
</html>
~~~

### 解构赋值

```html
<!DOCTYPE html>
<html lang="zh-cn">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
          *{margin: 0;padding: 0;}
    </style>
</head>
<body>
    <div id="app"></div>
    <script>
    'use strict';
    /* 
        解构赋值
        解构赋值是一种特殊语法, 可以方便快速的对数组或者对象进行取值的一种方式,
        也可以为对象数组设置初始值
    */

    let userListLoginArr = ['徐星','久违']

    //将数组中的两个值分别取出来方便后续使用
    let xuxing1 = userListLoginArr[0]
    let jiuwei1 = userListLoginArr[1]

    //解构取值 解构的顺序必须一一对应
    let [xuxing2,jiuwei2] = userListLoginArr//解构出来的值就是一个变量

    //解构出来的结果不会影响原数据
    xuxing2 = null

    //如果我只想拿到久违,不想解构徐星 
    // , 作为站位符跳过某个数据
    let [,jiuwe3] = userListLoginArr

    //可以解构的对象非常多, set 集合也可以结构
    let set = new Set(['aaa','bbb'])

    let [aaa] = set;


    //先声明变量再进行结构
    let jiu,xu;
    [xu,jiu] = userListLoginArr


    //解构的过程中设置默认值
    let arr1 = ['xuxing','18'] //用户信息

    //当解构的值不存在 可以使用 = 赋值一个默认值
    let [name,age,sex='nan'] = arr1

    //参数过多也可以使用 rest 参数进行接受
    let [praName,...rest] = ['奥特曼','199','180cm','60kg','balck']


    //对象遍历
    let user = {
        name : 'xxx',
        age : 11,
        sex : 'anan'
    }

    //应用场景1
    for (const [key,value] of Object.entries(user)) {
        console.log(key,value)//name xxx
    }

    //应用场景2 user转换为地址栏拼接格式
    let pareUrl = Object.entries(user).map(([key,value])=>{
        return key+'='+value
    }).join('&')


    //变量位置交换
    let a = 1;
    let b = 2;
    //中间变量的写法
    // let temp = a;
    // a = b
    // b = temp
    //应用场景3 解构交换位置
    [a,b] = [b,a]


    let arrList = [1,3,[3,4,[5]]]

    //嵌套结构
    let [,,[,,[five]]] = arrList




        
    </script>
</body>
</html>
```

### 对象类型结构

~~~html
<!DOCTYPE html>
<html lang="zh-cn">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
          *{margin: 0;padding: 0;}
    </style>
</head>
<body>
    <div id="app"></div>
    <script>
    'use strict';

    /* 
    对象解构赋值 语法  let {val1,val2} = {val2,val1}
    解释 创建一个变量val1 和 val2 赋值为对象 中的 属性叫 val1的值和 val2的值
    */

    let option = {
        title : 'Menu',
        width : 100,
        height : 200,
        color : undefined
    }

    //解构取值
    // let {height,width,title} = option

    //重命名
    // let {height:h,width:w,title:t} = option

    //设置默认值
    // let {height:h,width:w,title:t,color='black'} = option

    //设置剩余参数
    // let {title,...rest} = option //rest 就是剩余所有值组成的一个对象

    //对象申明解构需要加括号
    let title,height;
    ({title,height} = option)

    //函数参数结构
    function showMenu({w,h=1}){
        // obj.h = obj.h || 1
        // console.log(obj.w * obj.h)
        console.log(w * h)
    }

    showMenu({
        w : 100,
        h : undefined
    })
        
    </script>
</body>
</html>
~~~

## day22-面向对象

### 什么是面向对象

~~~html
<!DOCTYPE html>
<html lang="zh-cn">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
          *{margin: 0;padding: 0;}
    </style>
</head>
<body>
    <div id="app"></div>
    <script>
    'use strict';

    /* 
        js 中 任务事物都可以抽象成为一个对象, 行为, 特征
        行为 : 用function表示
        特征 : 对象的属性名和属性值

        编程模式
        1. 面向对象 OOP
        2. 面向过程 POP

        区分面向对象和面向过程
        大象 装 冰箱 (业务需求)

        代码实现大象装冰箱的过程
        1. 面向过程的形式来实现 将需求分析出几个步骤,按照函数一步一步的实现, 最终有条有序的执行完成效果
            1.1 打开冰箱门(代码实现)
            1.2 把大象放进去
            1.3 冰箱门关闭
            
        2. 面向对象 面向对象首先要将需要处理事物抽象成为一个对象, 然后对象之间分工明确合作完成效果
            2.1 抽象出大象的对象
                - 大象有体貌特征的属性
                - 大象要有一个移动的行为

            2.2 抽象出冰箱的对象
                - 冰箱有尺寸大小的属性
                - 冰箱有打开冰箱门的行为
                - 关闭冰箱门的行为

            执行大象装冰箱的行为 , 执行冰箱打开门的行为 - 执行大象移动的行为 - 执行冰箱关闭门的行为

            面向对象是以功能进行划分,而不是步骤进行划分

        面向对象的特征
        1. 抽象对象的公共属性和行为封装成为一个类
        2. 对象的实例化 获取类的实例化对象

        面向对象的特征
        - 封装性
        - 继承性
        - 多态性  同一个对象在不同的状态下有不同的效果

        面向对象和面向过程对比

        面向过程: 
        优点:性能高,适合跟硬件相关的程序,单片机
        缺点:不容易维护,不方便扩展和复用

        
        面向对象
        优点:方便复用和维护,方便扩展 
        缺点:性能比较低


        创建一个空调a
        新增空调a温度控制的功能(){}
        创建一个遥控
        打开空调a(){}
        关闭空调a的函数(){}
        新增为空调a增加温度的功能(){}


        空调 = {

        }
        
        遥控器 = {
            打开空调(){}
            关闭空调(){}
            温度增加(){}
            温度减少(){}
        }

    */
        
    </script>
</body>
</html> 
~~~

### 面向对象es5

~~~html
<!DOCTYPE html>
<html lang="zh-cn">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
          *{margin: 0;padding: 0;}
    </style>
</head>
<body>
    <div id="app"></div>
    <script>
    'use strict';
    /* 
        方式一 let obj = {}
        方式二 let obj = new Object()

        需要大量创建对象的时候
        方式一 工厂函数创建对象
        方式二 new关键词配合构造函数创建对象
    */

    //创建一个学生类
    function Student(name,age){
        //学员共有特征
        this.name = name
        this.age = age
        //共有的行为
        this.say = function(){
            console.log(`我是${this.name},我今年${this.age}岁`)
        }
    }
    
    //创建类的实例化对象
    let xuxing = new Student('xuxing',19)
    let wuxian = new Student('wuxian',18)
    xuxing.say()
    wuxian.say()
    console.log(xuxing.name === wuxian.name)//false
    console.log(xuxing.say === wuxian.say) //fase

        
    </script>
</body>
</html>
~~~

### 静态成员实例成员es5

~~~html
<!DOCTYPE html>
<html lang="zh-cn">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
          *{margin: 0;padding: 0;}
    </style>
</head>
<body>
    <div id="app"></div>
    <script>
    'use strict';
    /* 
        类的成员分为两类
        - 静态成员

        - 动态成员(实例成员)
            1. 类中挂载到this上的所有属性和方法
            2. 实例成员只能通过实例化出来的对象才能访问
    */
    //创建一个学生类
    function Student(name,age){
        //实例成员(动态成员)
        this.name = name
        this.age = age
        //共有的行为
        this.say = function(){
            console.log(`我是${this.name},我今年${this.age}岁`)
        }
    }

    //在构造函数下直接挂载属性
    //类的静态成员
    Student.height = '180cm'
    
    //创建类的实例化对象
    let xuxing = new Student('xuxing',19)
    let wuxian = new Student('wuxian',18)
    xuxing.say()
    wuxian.say()
    console.log(Student.name)//Student
    console.log(Student.age)//undefined
    console.log(Student.height)//180cm

        
    </script>
</body>
</html>
~~~

### 原型对象和对象原形

~~~html
<!DOCTYPE html>
<html lang="zh-cn">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
          *{margin: 0;padding: 0;}
    </style>
</head>
<body>
    <div id="app"></div>
    <script>
    'use strict';

     //函数每次实例化出来得都是一个全新的函数, 但是每个函数的功能都是一模一样的, 存在一个浪费空间的问题, 希望函数是同一个函数
    //全局创建了一个函数
    // function sayInfo(){
    //     console.log(`我是${this.name},我今年${this.age}岁`)
    // }
    

    //创建一个学生类
    function Student(name,age){
        this.name = name
        this.age = age
        //共有的行为
        // this.sayHi = Student.sayHi  //每次实例化都添加的同一个函数
        this.say = Student.fnObj.sayInfo  //每次实例化都添加的同一个函数
        this.sayHi = Student.fnObj.sayHi  //每次实例化都添加的同一个函数
        this.sayLength = Student.fnObj.length  //每次实例化都添加的同一个函数
    }

    //添加静态属性
    /*   Student.sayInfo =  function sayInfo(){
            console.log(`我是${this.name},我今年${this.age}岁`)
        }
        Student.sayHi =  function(){
            console.log(`Hi我是${this.name}`)
        } */

    //共有方法
    Student.fnObj = {
        sayInfo(){
            console.log(`我是${this.name},我今年${this.age}岁`)
        },
        length(){
            console.log('我是length')
        },
        sayHi : function(){
            console.log(`Hi我是${this.name}`)
        }
    }

    //为学生类添加共有方法 在原型对象下 prototype
    Student.prototype.sayName = function(){
        console.log(this)
    }
    
    //创建类的实例化对象
    let xuxing = new Student('xuxing',19)
    let wuxian = new Student('wuxian',18)
    xuxing.say()
    wuxian.say()
    wuxian.sayHi()
    wuxian.sayLength()

    console.log(xuxing.say === wuxian.say)

    //原型对象, 和 对象原型
    //原型对象是 每个构造函数(函数) 内都有的一个对象 叫做 prototype
    /* 
    constructor 构造器 存储一个指针,指向原型对象的创建者

    挂载到原型对象下的方法是所有实例化出来的对象都能访问到的
    */

    let arr1 = new Array(1,2,3)
    console.log(arr1.join('-'))

    console.log(Student.prototype)
    console.log(Array.prototype)

        
    </script>
</body>
</html>
~~~

### 原型对象和对象原形2

~~~html
<!DOCTYPE html>
<html lang="zh-cn">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
          *{margin: 0;padding: 0;}
    </style>
</head>
<body>
    <div id="app"></div>
    <script>
    'use strict';
    
    //原型对象, 和 对象原型
    /* 
    原型对象是 每个构造函数(函数) 内都有的一个对象 叫做 prototype
    -  constructor 构造器 存储一个指针,指向原型对象的创建者

    对象原型 每个对象下都有的一个对象(实例化对象)__proto__就叫做对象原型
    - 对象原型存储的就是原型对象
    - constructor 属性指向创建该对象的构造函数\

    原型链
    规定原型和对象原型下的查找规则
    1. 自身对象下有没有这个方法,有就用没有就继续往下查找
    2. 自身对象的对象原型下有没有这个方法,没有就根据对象原型下的constructor 找到创建他的构造函数身上的原型对象继续查找
    3. 如果自身有那就用自己身上的


    挂载到原型对象下的方法是所有实例化出来的对象都能访问到的
    */


    //创建一个学生类
    function Student(name,age){
        this.name = name
        this.age = age
    }
    //为学生类添加共有方法 在原型对象下 prototype
    // Student.prototype.sayName = function(){
    //     console.log(this.name) //指向实例化出来的对象
    // }
    //多个共有方法的添加 方式一 继续使用.操作添加

    //方式二利用对象覆盖批量添加

    /* 
        批量添加会存在一个问题就是会丢失constructor属性
    */
    Student.prototype = {
        //手动添加回constructor
        constructor : Student,
        sayName(){
            console.log(this.name) //指向实例化出来的对象
        },
        sayAge(){
            console.log(this.age) //指向实例化出来的对象
        }
    }


    //创建类的实例化对象
    let xuxing = new Student('xuxing',19)
    let wuxian = new Student('wuxian',18)

    xuxing.__proto__.aaa = function(){
        console.log('aaa')
    }
    xuxing.aaa()
    wuxian.aaa()

    //当你访问的方法或者属性是自身实例化没有的,那他就会根据原型链往上一次进行查找
    console.log(wuxian.toString())//[object Object]

    //调用共有方法
    xuxing.sayName()
    xuxing.sayAge()

    let arr = []

    // console.log(xuxing.say === wuxian.say)
    // console.log(xuxing.sayName === wuxian.sayName)

    console.log(xuxing.__proto__ === Student.prototype) //true
    console.log(Object.prototype.__proto__) //null 原型链的尽头


  

        
    </script>
</body>
</html>
~~~

### 继承

~~~html
<!DOCTYPE html>
<html lang="zh-cn">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
          *{margin: 0;padding: 0;}
    </style>
</head>
<body>
    <div id="app"></div>
    <script>
    'use strict';
    /* 
        对象的继承 就是将父类的属性和方法继承给子类
    */

    //父类
    function Father(name,age,money){
        this.age = age
        this.name = name
        this.money = money
    }
    //父类的方法
    Father.prototype.say = function(){
        console.log(this.name,'我是父类的方法')
    }

    //子类
    function Son(name,age,sex){
        //继承父类的属性
        Father.call(this,name,age) //属性继承
        //子类独有的属性
        this.sex = sex
    }
    //方法继承 方式一 , 缺点就是建立了引用关系,子类更新会影响到父类
    // Son.prototype = Father.prototype

    //方式二 利用__proto__继承 缺点就是会把属性也给继承到自身的原型上
    // Son.prototype = new Father()
    // Son.prototype.constructor = Son

    //方式三 创建一个新的类,类专门用来继承
    // function Fn(){

    // }
    // Fn.prototype = Father.prototype //自身原型的值设置为父类的值
    // Son.prototype = new Fn()
    // Son.prototype.constructor = Fn

    //方式四 Object.assgin()对象合并
    Object.assign(Son.prototype,Father.prototype)


    //希望子类能继承父类的属性

    let  f = new Father('路遥')
    let  s = new Son('徐星',19,'nan')
    f.say()
    s.say()
        
    </script>
</body>
</html>
~~~

### es6类

~~~html
<!DOCTYPE html>
<html lang="zh-cn">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
          *{margin: 0;padding: 0;}
    </style>
</head>
<body>
    <div id="app"></div>
    <script>
    'use strict';
    /* 
        es6 新增了一个关键词叫做class 作用就是创建一个类
        class 运用的不是一个新的技术他就是es5原型方式的一个简写方案(语法糖)

    */

    //创建类
    class Animal{
        static sex = 'nan'
        //书写代码的方式就是正常书写,不要把它当做对象来书写
        constructor(name,age){
            //构造器 存储的就是类的动态成员
            this.name = name
            this.age = age
        }
        //类的行为
        say(){
            console.log(`may name is ${this.name}`)
        }
    }

    //创建类的实例化
    let dog = new Animal('徐星',2)
    let cat = new Animal('无限',1)
    dog.say()

    //es6类的继承只需要借助 extends 关键词就可以了

    class Dog extends Animal{
        constructor(name,age,color){
            //super关键词等价于拿到父类方法,可以执行表示拿到父类的const,也可以当做对象访问父类的方法
            //super关键词继承属性的时候必须写到私有属性之前
            super(name,age)//继承父类的属性
            this.color = color //私有属性

            super.say()
        }
        //方法是默认继承的
    }

    // console.log(dog.__proto__)

    let wuxian = new Dog('无限',1,'black')
    wuxian.say()

    console.log(dog.say === cat.say)//true

    //访问静态属性
    // console.log(Animal.sex)
      
    </script>
</body>
</html>
~~~

