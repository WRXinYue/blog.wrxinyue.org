---
title: File类 
date: 2022-11-03 18:47:55.459
categories: 
- WEBbackend
tags: 
- Java
updated: 2023-04-18 15:09:26
---

## 构造方法

```java
//方式1 new File(String pathname)	//根据文件路径名
String path = "D:\\Demo\\new.txt";
File file = new File(path); 

//方式2 new File(String parent, String child) //根据父目录+子路径构建
String parentPath = "D:\\Demo";
String fileName = "new.txt";
File file = new File(parentPath, fileName);

//方式3 new File(File parent,String child) //根据父目录文件+子路径构造
File parentFile = new File("D:\\Demo");
String fileName = "new.txt";
File file = new File(parentFile, fileName);
```

## 常用方法

```java
//创建文件对象
File file = new File(D:\\Demo\\new.txt);

//调用相应的方法，得到对应信息
System.out.println("文件名：" + file.getName());
System.out.println("文件绝对路径：" + file.getAbsolutePath());
System.out.println("文件父级目录：" + file.getParent());
System.out.println("文件大小(字节)：" + file.length());
System.out.println("文件是否存在：" + file.exists());
System.out.println("是不是一个文件：" + file.isFile());
System.out.println("是不是一个目录：" + file.isDirectory());
```

### 创建删除功能的方法

- `public boolean createNewFile()` ：文件不存在，创建一个新的空文件并返回`true`，文件存在，不创建文件并返回`false`。
- `public boolean delete()` ：删除由此File表示的文件或目录 （目录必须为空才能删除）
- `public boolean mkdir()` ：创建由此File表示的目录。
- `public boolean mkdirs()` ：创建由此File表示的多级目录（**开发中一般用**`mkdirs()`）

~~~java
//判断news1.txt 是否存在，如果存在就删除
public void  m1() {
    String parentPath = System.getProperty("user.dir") + "\\src";
    String fileName = "news1.txt";
    File file = new File(parentPath,fileName);
    if (file.exists()) {
        if(file.delete()){
            System.out.println(file.getName() + "删除成功");
        } else {
            System.out.println(file.getName() + "删除失败");
        }
    } else {
        System.out.println(file.getName() + "该文件不存在");
    }
}

//在Java中目录也当作文件，删除demo目录
public void m2() {
    String filePath = System.getProperty("user.dir");
    String fileName = "demo1";
    File file = new File(filePath,fileName);
    if (file.exists()){
        if(file.delete()){
            System.out.println(file.getName() + "删除成功");
        } else {
            System.out.println(file.getName() + "删除失败");
        }
    } else {
        System.out.println(file.getName() + "该文件夹不存在");
    }
}

//创建多级目录
public void m3() {
    String directoryPath = System.getProperty("user.dir") + "\\demo1\\1\\2\\3\\4\\5";
    File file = new File(directoryPath);
    if (file.exists()){
        System.out.println(file.getName() + "存在...");
    } else {
        if (file.mkdirs()) {
            System.out.println("目录" + file.getName() + "创建成功..");
        } else {
            System.out.println("目录" + file.getName() + "创建失败..");
        }
    }
}

//判断news1.txt 是否存在，如果存在就删除
public void  m1() {
    String parentPath = System.getProperty("user.dir") + "\\src";
    String fileName = "news1.txt";
    File file = new File(parentPath,fileName);
    if (file.exists()) {
        if(file.delete()){
            System.out.println(file.getName() + "删除成功");
        } else {
            System.out.println(file.getName() + "删除失败");
        }
    } else {
        System.out.println(file.getName() + "该文件不存在");
    }
}

//在Java中目录也当作文件，删除demo目录
public void m2() {
    String filePath = System.getProperty("user.dir");
    String fileName = "demo1";
    File file = new File(filePath,fileName);
    if (file.exists()){
        if(file.delete()){
            System.out.println(file.getName() + "删除成功");
        } else {
            System.out.println(file.getName() + "删除失败");
        }
    } else {
        System.out.println(file.getName() + "该文件夹不存在");
    }
}

//创建多级目录 mkdirs()可以创建多级目录比如//a//b//c，所以开发中一般用mkdirs()
public void m3() {
    String directoryPath = System.getProperty("user.dir") + "\\demo1\\1\\2\\3\\4\\5";
    File file = new File(directoryPath);
    if (file.exists()){
        System.out.println(file.getName() + "存在...");
    } else {
        if (file.mkdirs()) {
            System.out.println("目录" + file.getName() + "创建成功..");
        } else {
            System.out.println("目录" + file.getName() + "创建失败..");
        }
    }
}
~~~

## 目录的遍历

- `public String[] list()` ：返回一个String数组，表示该File目录中的所有子文件或目录。
- `public File[] listFiles()` ：返回一个File数组，表示该File目录中的所有的子文件或目录。

```java
public class FileFor {
    public static void main(String[] args) {
        File dir = new File("G:\光标");
      
      	//获取当前目录下的文件以及文件夹的名称。
		String[] names = dir.list();
		for(String name : names){
			System.out.println(name);
		}
        //获取当前目录下的文件以及文件夹对象，只要拿到了文件对象，那么就可以获取更多信息
        File[] files = dir.listFiles();
        for (File file : files) {
            System.out.println(file);
        }
    }
}
```

## 递归遍历文件夹下所有文件以及子文件

```javascript
package File;

import java.io.File;

//递归遍历文件夹下所有的文件
public class RecursionDirectory {
    public static void main(String[] args) {
      File file=new File("D:\\java专属IO测试");
        Recursion(file);
    }
    public static void Recursion(File file){
        //1、判断传入的是否是目录
        if(!file.isDirectory()){
            //不是目录直接退出
            return;
        }
        //已经确保了传入的file是目录
        File[] files = file.listFiles();
        //遍历files
        for (File f: files) {
            //如果该目录下文件还是个文件夹就再进行递归遍历其子目录
            if(f.isDirectory()){
                //递归
                Recursion(f);
            }else {
                //如果该目录下文件是个文件，则打印对应的名字
                System.out.println(f.getName());
            }

        }
    }
}
```

# 