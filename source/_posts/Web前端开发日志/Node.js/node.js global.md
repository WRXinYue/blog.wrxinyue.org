---
title: node.js global 
date: 2022-11-07 10:36:30.459
categories: 
- WEBbackend
tags: 
- java
---

* 在 Node.js 中有一个全局对象 `global`，它的作用类似于网页中的 `window`。
* 在全局中创建的变量都会作为 `global` 的属性保存。
* 在全局中创建的函数都会作为 `global` 的方法保存。
* 当 Node.js 执行模块中的代码时，它会在代码的最顶部添加如下代码：

```js
function (exports, require, module, _filename, _dirname){
    // module code
}
```

- 实际上模块中的代码都是包装在一个函数中执行的，并且在函数执行时，同时传递了5个实参：
  - `exports`：该对象用来将变量或函数暴露到外部。
  - `require`：函数，用来引入外部模块（只能使用 . 的方式向外暴露内部变量）
  - `module`:
    - `module` 代表的是当前模块本身。
    - `exports` 就是 `module` 的属性(既可以通过 . 的形式，也可以直接赋值)
    - 既可以使用 `exports` 导出，也可以使用 `module.exports` 导出。
  - `_filename`：当前模块的完整路径。
  - `_dirname`：当前模块所在文件夹的完整路径.