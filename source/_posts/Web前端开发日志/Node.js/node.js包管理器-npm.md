---
data: 2023-04-11 14:40:30
updated: 2023-04-11 14:40:30
---
### 包 package

* CommonJS的包规范允许我们将一组相关的模块组合到一起，形成一组完整的工具。
* CommonJS的包规范由**包结构**和**包描述文件**两个部分构成。
* 包结构：用于组织包中的各种文件
* 包描述文件：描述包的相关信息，以供外部读取分析

### NPM(Node Package Manager)

* CommonJS包规范是理论，NPM是其中一种实践。
* 对于Node而言，NPM帮助其完成了第三方模块的发布、安装和依赖等。借助NPM，Node与第三方模块之间形成了很好的一个生态系统。

### NPM命令

查看npm版本

~~~shell
npm -v
~~~

查看所有模块的版本

~~~shell
npm version
~~~



帮助说明

~~~shell
npm
~~~

搜索模块包

~~~shell
npm search 包名
~~~

在当前目录安装包

~~~shell
npm install 包名
npm i 包名
~~~

下载当前项目所依赖的包

~~~shell
npm install
~~~



在当前目录安装包并添加到依赖中

~~~shell
npm install 包名 --save 安装包并添加到依赖中
~~~

删除当前目录包

~~~shell
npm remove / r 包名
~~~

全局模式安装包

~~~shell
npm install 包名 -g
~~~

