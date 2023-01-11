# Day2

## fs模块（文件操作系统）

* node中想使用API
  * 需要进入引入对应的api模块（整体）
  * fs文件操作模块里面所有api都是用于操作文件系统的
  

### 删除文件

* 删除文件 => 推荐使用同步删除，超大文件使用异步删除
  * 异步执行
    * fs.unlink(path,callback) 删除对应文件，删除文件之后触发回调函数
      * path => 文件地址及后缀
      * callback => (err)=>{} || function(err){}
        * 回调函数参数 err:返回报错信息 || null
      * 实例：`fs.unlink("./1.txt",(err)=>{console.log("123node",err);})`
  * 同步执行
    * fs.unlinkSync(path)
      * path => 文件地址及后缀（路径）
    * 实例：`fs.unlinkSync("./1.txt")`

### 读取文件

* 读取文件

  * 异步
    * fs.readFile(path[,options]callback) => 读取对应文件之后，触发回调函数并且获取文件内部数据(buffer格式)
      * path => 文件地址及后缀(路径)
      * [,options] => 可选参数;"utf-8"
      * callback => (err)={} || function(err){}
        * 回调函数参数
          * err：返回报错信息 || null
          * data：返回获取文件的数据
      * 实例：`fs.readFile("./1.txt",(err,data)=>{console.long(err,data.toString());})`
      * 实例:`fs.readFile("./1.txt","utf-8",(err,data)=>{counsole.log(err,data)})`
  * 同步
    * fs.readFile(path[,options])
      * path => 文件地址及后缀(路径)
      * [,options] => 可选参数;"utf-8"
      * api执行结果是获取文件的数据内容
    * 实例：`let result = fs.readFileSync("./1.txt","utf-8")`
    * 实例：`let result = fs.readFileSync("./1.txt")`

  ### 修改文件

  * 写入文件内容
    * 功能
      * 创建文件 => 文件不存在则创捷文件，并且写入
      * 对应文件写入内容
      * 修改文件内容 => 没有设置options时：文件存在会重写文件内部内容
      * 修改文件内容 => 设置options时，文件存在并且在原有的基础进行添加内容
    * 异步
      * fs.writeFile(path,data[,options],callback) => 功能
      * path => 文件地址及后缀(路径)
      * options => {falg:"a"} 设置之后使用写入文件会在文件原有的基础上进行添加内容
      * data => 写入文件的数据，字符串，buffer...
      * callback => (err)=>{} || function(err){}
        * 回调函数参数 err:返回报错信息 || null
    * 同步
      * fs.writeFile(path,data[,options]) => 功能

### 创建文件夹

* 创建文件夹

  * 异步

    * fs.mkdir(pathName,callback) => 创建对应文件夹

      * pathName => 文件地址(路径)

      * callback => 回调函数(err)=>{} || function(err){}

        * 回调函数参数 err:返回报错信息 || null
      * 实例：`fs.mkdir("./xinyue",(err)=>{ console.log(err) })`
    
  * 同步
    * fs.mkdirSync(pathName)
      * pathName => 文件地址(路径)

### 删除文件夹

* 异步
  * fs.rmdir(pathName[,options],callback) => 删除对应文件夹
    * pathName => 文件夹地址(路径)
    * options => 设置{recursive:true} 之后强制文件夹内所有内容删除
    * callback => 回调函数(err)={} || function(err){}
      * 回调函数参数 err:返回报错信息 || nulll
  * 实例：`fs.rmdir("../reademe",(err)=>{ console.log(err) })`
  * 实例：`fs.rmdir("../reademe",{recursive:true},(err)=>{ console.log(err) })`
* 同步
  * fs.rmdirSync(pathName[,options])
    * pathName => 文件夹地址(路径)
    * options => 设置{recursive:true} 之后强制文件夹内所有内容删除

### 强制删除文件夹

* 异步
  * `fs.rm("./wrxinyue",{recursive:true},(err)=>{ console.log(err);})`
* 同步
  * `fs.rm("./wrxinyue",{recursive:true}) `
* 强制删除与删除fs.rmdir使用是一致的



### 读取文件夹

* 异步
  * fs.readdir(pathName,callback) => 获取文件夹目录的文件和文件的名称
    * pathName => 文件夹地址(路径)
    * callback => 回调函数(err,data)=>{} || function(err,data){}
      * 回调函数参数
        * err：返回报错信息 || null
        * data：获取一个数组格式数据(文件夹子目录的文件和文件夹的名称)
      * 实例：`fs.readdir("./wrxinyue",(err,data)=>{ console.log(err,data)}`
* 同步
  * fs.readdir(pathName)
    * pathName => 文件夹地址(路径)



### 判断文件夹和文件是否存在

* 同步
  * fs.existsSync(path)
    * path：文件或文件夹地址(路径)
    * API返回：Boolena布尔值
  * 实例：`let result = fs.existsSync("./inde.html") console.log(result);`



### 查看文件和文件夹信息

* 异步
  * fs.stat(path,callback)
    * path：文件或文件夹地址(路径)
    * callback => 回调函数(err,data)=>{} || function(err,data){}
      * 回调函数参数
        * err：返回报错信息 || null
        * data：获取文件和文件夹信息
* 同步
  * fs.statSync(path)
    * path：文件或文件夹地址(路径)
    * 返回值：获取文件和文件夹信息

### 修改文件和文件夹名称

* 功能
  * 剪切 => 设置oldPath和newPath的名称一直，通过设置修改达到剪切效果
  * 改名 => 设置oldPath和newPath的名称不一致
* 异步
  * fs.rename(oldPath,newPath,callback)
    * oldPath：选择将需要修改的文件或文件夹地址(需要文件后缀)
    * newPath：将选择文件或文件夹进行重命名，而且选择放置位置(路径-地址)
    * callback => 回调函数(err)=>{} || function(err){}
      * 回调函数参数 err:返回报错信息 || null
* 同步
  * fs.reanameSync(oldPath,newPath,callback)
    * oldPath：选择将需要修改的文件或文件夹地址(需要文件后缀)
    * newPath：将选择文件或文件夹进行重命名，而且选择放置位置(路径-地址)



### 监听文件或文件夹

* 监听文件或文件夹
  * 异步
    * fs.watch(path,callback) => 监听文件或文件夹,当文件或文件夹内部发生变化触发回调函数执行
      * path：文件或文件夹地址(路径)
      * callback => 回调函数(type,name)={} || function(type,name){}
        * type：触发的事件名称（change修改）（rename删除-添加）
        * name：是触发事件名字的名称


## js代码执行顺序

* 从上往下执行同步
* 再执行异步代码
  * ajax请求
  * 事件函数 onclick="事件函数"
  * 定时器
  * .then

## 可读可写流

流分为缓冲模式和对象模式，缓冲模式只能处理buffer或字符串，对象模式可以处理js对象。对象又分为四种类型：可读流、可写流、双工流和转换流

![img](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/10099568-7faba4c0900ac1a6.jpg)

计算程序的性能消耗时间

* 设置开始计时标记 console.time(标记)
* 设置结束计时标记 console.timeEnd(标记)
* 开始标记和结束标记是一致

rs.readFileSync 与 fs.writeFileSync是属于一次将所有的数据进行搬运，消耗内存越大执行时间越长



可读可写流

* 创建可读流 `let read = fs.createReadStream("./1.txt"); `
* 创建可写流 `let write = fs.createWriteStream("./2.txt");`
* 通过代理管道将数据移动 read.pipe(write)



~~~js
// 通过可读流事件开始读取数据
read.on('data',(val)=>{  // 进行存储数据
	write.write(val)
})
// 通过可读流事件结束触发函数
read.on("end",()=>{ console.log("可读流结束触发") })
~~~

~~~js
const fs = require("fs")

console.time("timetaken")

let read = fs.createReadStream("./1.txt");
let write = fs.createWriteStream("./2.txt");

read.on("end",()=>{
    console.log("可读流结束触发");
})
// 通过可读流事件开始读取数据
read.on('data',(val)=>{
    console.log(1);
    write.write(val)
})
console.timeEnd("timetaken")
~~~

## 模块系统

模块化 => reuqire()获取其他js文件数据 === 暴露数据(exports)将文件的数据放置外部,供别人获取

* 在node中,每一个js文件都是一个模块; (js文件 == 模块)
* require(模块名称) => 获取模块名称数据
  * 根据模块需要进行不同的写法,才能获取到数据
  * const qqq = require("./index")  获取的是一个对象
* 暴露数据 exports.变量 = 数据 



模块名称：

* 自定义模块 => 开发者写的模块(自己写的js文件---封装的js功能文件--) 
  * 获取自定义模块使用相对路径或者绝对路径地址进行访问 否则node会默认为你在获取内置模块或者第三方模块导致报错
  * const qwe = require("./index.js")
* 内置模块  => fs内置模块(path,url,http) => 获取内置模块写模块名称即可获取对应数据(API)
* 第三方模块 => 放置到node_modules里面(axios) => 其他程序猿写好放置网络上我们进行下载使用称第三方模块 => 下载成功之后与内置模块使用一致
  * const axios = require("axios")
* 易于维护与阅读,抽离合并,优化

```js
const fs = require("fs");
const {data} = require("./index");

function createFile(value){
    let url = value.dirName;
    let bol = fs.existsSync(url);  // 判断对应文件夹是否已经存在并且冲突了,
    if(bol)return; 
    fs.mkdirSync(url)       // 创建对应文件夹项目
    
    function add(val,url){
        val.forEach((item)=>{ // 根据数据为当前文件夹内部创建对应文件或者文件夹
            if(item.type == "dir"){  // 创建文件夹
                fs.mkdirSync(url + "/" + item.fileName)
                if(!item.dirNameChild) return; // 当前文件夹中不存在子目录,直接停止往下执行
                add(item.dirNameChild,url + "/" + item.fileName)
            }else{
                fs.writeFileSync(url + "/" + item.fileName + "." + item.type ,"")  // 创建文件
            }
        })
    }
    add(value.dirNameChild,url)
}
createFile(data)
```

# Day4

## 导入导出

```json
/*
    require(模块)
        - 自定义模块 => 开发者写的模块
        - 内置模块  => fs内置模块(path,url,http) 
        - 第三方模块 => axios 
        - 获取到数据格式为对象 {}
    
    exports暴露数据
        - exports.变量 = "数据"
        - exports.变量 = function(){} || ()=>{}
        - 暴露变量相同,后写覆盖前
        - module.exports 默认暴露;每个js文件只会暴露一个默认暴露,后写覆盖前
        - 设置默认暴露之后,以默认暴露数据为主
    
    导入数据 reuqire()
    导出数据 module.exports = {}; exports.变量
*/

const result = require("./02-暴露数据.js");

console.log(result);
```

## 暴露数据

~~~json
// a 自定义模块



// ------
let sss = 6666;
let qqq = 7777;

module.exports = {
    name:"默认暴露",
    sss,
    qqq
}

exports.name1 = "我叫路遥";
exports.name2 = "我叫丫丫";
exports.name3 = "我叫久违";

exports.fun = ()=>{
    console.log("我a.js中的函数");
}

console.log(arguments);
~~~

## 模块

~~~json
/*
    - node每个js文件都是一个模块 
    - node中每个js文件都被一个立执行函数包裹
        - arguments获取函数的所有的实参
        - 实参参数 => node通过对应形参进行接收
            - exports  暴露数据
            - require() 请求
            - Module    模块对象  
            - __filename 文件绝对路径地址
            - __dirname   当前文件的文件夹地址
    -   exports === module.exports
            -  exports只是引用了module.exports

*/

console.log(exports === module.exports, exports,module.exports);
~~~

## path

~~~json
/*
    内置模块 path => 处理路径
        - path.join()  合并路径

        - path.relative(form,to) 根据传入的参数,返回form到to工作目录相对路径
            1. form 起点目录 使用文件夹为地址
            2. to 目标目录
        - path.resolve(path)  根据参数进行解析返回绝对路径
            - 相当于内部自带了一个__dirname参数,进行处理传递的路径返回绝对路径地址
    
        - path.parse() 序列化对象 => 路径解析变成对象

*/

const path = require("path");

// let result= path.join("qweqwe","123")  

// let result = path.relative("./","./04")  

// let result = path.resolve("./04/yy")  

let result = path.parse(__filename)


console.log(result);
~~~

~~~json
/*
    npm => 网站 https://www.npmjs.com/  npm 包管理器 => 模块管理器
        
    进行管理
        1. 初始化 npm init 
            - 出现一个package.json的文件 => 项目配置信息(配置文件)
                - 文件详情 obj对象
            - 一键初始化 npm init -y 但是项目文件夹目录不能有中文存在
            - node_modules 存储下载的第三方模块
            - package-lock.json 锁定下载模块的版本所有依赖版本信息
        2. 项目环境
            - 开发环境
                1. 程序猿还在为项目发愁写代码的时候 => (项目还没有完成,还在研发中) 
            - 生产环境
                2. 项目研发完成,已经上线了(发布到网络,用户可以进行访问了)
            - 放置位置的区别
                开发环境的模块(包)不会被压缩进项目 => 项目研发完成之后该模块后续不需要== 打包(压缩将开发环境包丢弃) == 已达到整个减少项目大小的效果
                生产环境的模块(包)会压缩进项目 = 打包 =>  无论是开发还是研发完成之后都需要使用到的包;

                项目上线之后不需要进行使用的放置开发环境, 项目上线之后还需要进行使用的放置生产环境
                比如:   Chalk：在终端中设置输出样式;项目上线后完全用不到,只是在开发过程中进行辅助开发,可以放置开发环境
                比如:  axios: 无论开发还是项目上线之后都会发起网络请求,放置生产环境

        3.  npm 下载模块 
            - npm install 模块名 简写  npm i 模块名
                - npm i axios -D    ====  -D 开发环境 devDependencies
                - npm i axios       ====  默认就是生产环境 dependencies
                - npm i axios -S    ====  -S 默认就是生产环境dependencies
                
                - --save 简写 -S   ==== 生产环境 dependencies
                - --save -dev 简写 -D   ==== 开发环境 devDependencies
                - 默认下载最新版本
                
        4.  npm 删除模块 
            - npm uninstall 模块名   |简写|   npm un 模块名

        5.  npm 指定模块 版本
            - npm i axios@1.1.1  ==> npm i 模块名@版本号
        
        6.  npm 更新模块 
            - npm update axios   ==> npm update axios


            yarn pnpm都是需要进行安装才能使用的
*/

let obj = {
    "name": "ceshi",        // 项目名称
    "version": "1.0.0",     // 版本
    "description": "",      // 项目的描述
    "main": "index.js",     // 入口文件
    "scripts": {            // 测试, 启动位置
        "test": "echo \"Error: no test specified\" && exit 1"
    },
    "author": "路亚",   // 作者
    "license": "ISC",  // 协议
    "dependencies": {    // 生产环境
        "axios": "^1.1.3"
    },
    "devDependencies": {   // 开发环境
        "cors": "^2.8.5"
    }
}
~~~

