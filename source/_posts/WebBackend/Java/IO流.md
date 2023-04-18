---
title: IO流
date: 2022-12-09 11:18:38.189
updated: 2023-04-18 15:09:28
url: /archives/io-liu
categories: 
- WEBbackend
tags: 
- Java
---

 IO概述

Java中I/O操作主要是指使用`java.io`包下的内容，进行输入、输出操作。**输入也叫做读取数据，输出也叫做作写出数据**。

## IO的分类

根据数据的流向分为：**输入流** 和 **输出流**。

|        | 输入流                     | 输出流                      |
| ------ | -------------------------- | --------------------------- |
| 字节流 | 字节输入流 **InputStream** | 字节输出流 **OutputStream** |
| 字符流 | 字符输入流 **Reader**      | 字符输出流 **Writer**       |

- Input指从外部读入数据到内存，例如，把文件从磁盘读取到内存，从网络读取数据到内存等等。
- Output指把数据从内存输出到外部，例如，把数据从内存写入到文件，把数据从内存输出到网络等等。

根据数据的类型分为：**字节流** 和 **字符流**。

- **字节流** ：以字节为单位，读写数据的流。
- **字符流** ：以字符为单位，读写数据的流。

![image-20221208190049353](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221208190049353.png)
![image-20221208190118586](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221208190118586.png)

![在这里插入图片描述](https://img-blog.csdnimg.cn/20191014111930276.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3FxXzQ0NTQzNTA4,size_16,color_FFFFFF,t_70)

## 字节流

## 字节输出流（OutputStream）

**字节输出流的基本共性功能方法**:

1. `public void close()` ：关闭此输出流并释放与此流相关联的任何系统资源。
2. `public void flush() ` ：刷新此输出流并强制任何缓冲的输出字节被写出。
3. `public void write(byte[] b)`：将 b.length个字节从指定的字节数组写入此输出流。
4. `public void write(byte[] b, int off, int len)` ：从指定的字节数组写入 len字节，从偏移量 off开始输出到此输出流。  **也就是说从off个字节数开始读取一直到len个字节结束**
5. `public abstract void write(int b)` ：将指定的字节输出流。

> **以上五个方法则是字节输出流都具有的方法，由父类OutputStream定义提供，子类都会共享以上方法**

#### FileOutputStream类

`OutputStream`有很多子类，我们从最简单的一个子类FileOutputStream开始。看名字就知道是文件输出流，用于将数据写出到文件。

#### FileOutputStream构造方法

1. `public FileOutputStream(File file)`：根据File对象为参数创建对象。 
2. `public FileOutputStream(String name)`： 根据名称字符串为参数创建对象。

**第二种构造方法开发常用：**

```java
public class FileOutputStreamConstructor throws IOException {
    public static void main(String[] args) {
   	 	// 使用File对象创建流对象
        File file = new File("G:\\自动创建的文件夹\\a.txt");
        FileOutputStream fos = new FileOutputStream(file);
      
        // 使用文件名称创建流对象
        FileOutputStream fos = new FileOutputStream("G:\\b.txt");
    }
}
```

#### FileOutputStream写出字节数据

使用FileOutputStream写出字节数据主要通过`Write`方法，而`write`方法分如下三种

```javascript
public void write(int b)
public void write(byte[] b)
public void write(byte[] b,int off,int len)  //从`off`索引开始，`len`个字节
```

1. **写出字节**：`write(int b)` 方法，每次可以写出一个字节数据，代码如下：

```java
public class IoWrite {
    public static void main(String[] args) throws IOException {
        // 使用文件名称创建流对象
        FileOutputStream fos = new FileOutputStream("fos.txt");     
      	// 写出数据
      	fos.write(97); // 写出第1个字节
      	fos.write(98); // 写出第2个字节
      	fos.write(99); // 写出第3个字节
      	// 关闭资源
        fos.close();
    }
}
```

**写出字节数组**：`write(byte[] b)`，每次可以写出数组中的数据，代码使用演示：

```java
public class FOSWrite {
    public static void main(String[] args) throws IOException {
        // 使用文件名称创建流对象
        FileOutputStream fos = new FileOutputStream("fos.txt");     
      	// 字符串转换为字节数组
      	byte[] b = "麻麻我想吃烤山药".getBytes();
      	// 写出字节数组数据
      	fos.write(b);
      	// 关闭资源
        fos.close();
    }
}
```

1. **写出指定长度字节数组**：`write(byte[] b, int off, int len)` ,每次写出从`off`索引开始，`len`个字节，代码如下：

```java
public class FOSWrite {
    public static void main(String[] args) throws IOException {
        // 使用文件名称创建流对象
        FileOutputStream fos = new FileOutputStream("fos.txt");     
      	// 字符串转换为字节数组
      	byte[] b = "abcde".getBytes();
		// 写出从索引2开始，2个字节。索引2是c，两个字节，也就是cd。
        fos.write(b,2,2);
      	// 关闭资源
        fos.close();
    }
}
```

#### FileOutputStream实现数据追加续写、换行

1、`public FileOutputStream(File file, boolean append)`

2、`public FileOutputStream(String name, boolean append)`

这两个构造方法，第二个参数中都需要传入一个boolean类型的值，`true` 表示追加数据，`false` 表示不追加也就是清空原有数据。

实现数据追加续写代码如下：

```java
public class FOSWrite {
    public static void main(String[] args) throws IOException {
        // 使用文件名称创建流对象
        FileOutputStream fos = new FileOutputStream("fos.txt"，true);     
      	// 字符串转换为字节数组
      	byte[] b = "abcde".getBytes();
		// 写出从索引2开始，2个字节。索引2是c，两个字节，也就是cd。
        fos.write(b);
      	// 关闭资源
        fos.close();
    }
}
```

Windows系统里，换行符号是`\r\n` ,具体代码如下：

```java
public class FOSWrite {
    public static void main(String[] args) throws IOException {
        // 使用文件名称创建流对象
        FileOutputStream fos = new FileOutputStream("fos.txt");  
      	// 定义字节数组
      	byte[] words = {97,98,99,100,101};
      	// 遍历数组
        for (int i = 0; i < words.length; i++) {
          	// 写出一个字节
            fos.write(words[i]);
          	// 写出一个换行, 换行符号转成数组写出
            fos.write("\r\n".getBytes());
        }
      	// 关闭资源
        fos.close();
    }
}
```

## 字节输入流（InputStream）

`java.io.InputStream `抽象类是表示**字节输入流**的所有类的**超类**（父类），可以读取字节信息到内存中。它定义了字节输入流的基本共性功能方法。

**字节输入流的基本共性功能方法**:

1. `public void close()` ：关闭此输入流并释放与此流相关联的任何系统资源。
2. `public abstract int read()`： 从输入流读取数据的下一个字节。
3. `public int read(byte[] b)`： 该方法返回的int值代表的是读取了多少个字节，读到几个返回几个，读取不到返回-1

#### FileInputStream类

`java.io.FileInputStream `类是文件输入流，从文件中读取字节。

#### 构造方法

1. `FileInputStream(File file)`： 通过打开与实际文件的连接来创建一个 FileInputStream ，该文件由文件系统中的 File对象 file命名。
2.  `FileInputStream(String name)`： 通过打开与实际文件的连接来创建一个 FileInputStream ，该文件由文件系统中的路径名name命名。

同样的，推荐使用第二种构造方法：

```javascript
 FileInputStream inputStream = new FileInputStream("a.txt");
```

```java
public class FileInputStreamConstructor throws IOException{
    public static void main(String[] args) {
   	 	// 使用File对象创建流对象
        File file = new File("a.txt");
        FileInputStream fos = new FileInputStream(file);
      
        // 使用文件名称创建流对象
        FileInputStream fos = new FileInputStream("b.txt");
    }
}
```

#### FileInputStream读取字节数据

1. **读取字节**：`read`方法，每次可以读取一个字节的数据，提升为int类型，读取到文件末尾，返回`-1`，代码测试如下【read.txt文件中内容为abcde】：

```java
public class FISRead {
    public static void main(String[] args) throws IOException{
      	// 使用文件名称创建流对象
       	FileInputStream fis = new FileInputStream("read.txt");//read.txt文件中内容为abcde
      	// 读取数据，返回一个字节
        int read = fis.read();
        System.out.println((char) read);
        read = fis.read();
        System.out.println((char) read);
        read = fis.read();
        System.out.println((char) read);
        read = fis.read();
        System.out.println((char) read);
        read = fis.read();
        System.out.println((char) read);
      	// 读取到末尾,返回-1
       	read = fis.read();
        System.out.println( read);
		// 关闭资源
        fis.close();
    }
}
```

循环改进读取方式，代码使用演示：

```java
public class FISRead {
    public static void main(String[] args) throws IOException{
      	// 使用文件名称创建流对象
       	FileInputStream fis = new FileInputStream("read.txt");
      	// 定义变量，保存数据
        int b ；
        // 循环读取
        while ((b = fis.read())!=-1) {
            System.out.println((char)b);
        }
		// 关闭资源
        fis.close();
    }
}
```

1. **使用字节数组读取**：`read(byte[] b)`，每次读取b的长度个字节到数组中，返回读取到的有效字节个数，读取到末尾时，返回`-1` ，代码使用演示：

```java
public class FISRead {
    public static void main(String[] args) throws IOException{
      	// 使用文件名称创建流对象.
       	FileInputStream fis = new FileInputStream("read.txt"); // read.txt文件中内容为abcde
      	// 定义变量，作为有效个数
        int len ；
        // 定义字节数组，作为装字节数据的容器   
        byte[] b = new byte[2];
        // 循环读取
        while (( len= fis.read(b))!=-1) {
           	// 每次读取后,把数组变成字符串打印
            System.out.println(new String(b));
        }
		// 关闭资源
        fis.close();
    }
}
```

由于`read.txt`文件中内容为`abcde`，而错误数据`d`，是由于最后一次读取时，只读取一个字节`e`，数组中，上次读取的数据没有被完全**替换**【注意是替换，看下图】，所以要通过`len` ，获取有效的字节
 ![在这里插入图片描述](https://img-blog.csdnimg.cn/20191015160242904.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3FxXzQ0NTQzNTA4,size_16,color_FFFFFF,t_70)
 代码如下：

```java
public class FISRead {
    public static void main(String[] args) throws IOException{
      	// 使用文件名称创建流对象.
       	FileInputStream fis = new FileInputStream("read.txt"); // 文件中为abcde
      	// 定义变量，作为有效个数
        int len ；
        // 定义字节数组，作为装字节数据的容器   
        byte[] b = new byte[2];
        // 循环读取
        while (( len= fis.read(b))!=-1) {
           	// 每次读取后,把数组的有效字节部分，变成字符串打印
            System.out.println(new String(b，0，len));//  len 每次读取的有效字节个数
        }
		// 关闭资源
        fis.close();
    }
}
```

在开发中一般强烈推荐使用数组读取文件，代码如下：

```javascript
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;

public class input2 {
    public static void main(String args[]){
        FileInputStream inputStream = null;
        try {
            inputStream = new FileInputStream("a.txt");
            int len = 0 ;
            byte[] bys = new byte[1024];
            while ((len = inputStream.read(bys)) != -1) {
                System.out.println(new String(bys,0,len));
            }
        
        } catch (IOException e) {
            e.printStackTrace();
        }finally {
            try {
                inputStream.close();
            } catch (IOException e) {
                e.printStackTrace();
            }
        }
    }
}
```

#### 字节流FileInputstream复制文件

**原理**
 ![在这里插入图片描述](https://img-blog.csdnimg.cn/20191013204020152.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3FxXzQ0NTQzNTA4,size_16,color_FFFFFF,t_70)

**代码实现**

复制文件，代码如下：

```java
public class Copy {
    public static void main(String[] args) throws IOException {
        // 1.创建流对象
        // 1.1 指定数据源
        FileInputStream fis = new FileInputStream("D:\\test.jpg");
        // 1.2 指定目的地
        FileOutputStream fos = new FileOutputStream("test_copy.jpg");

        // 2.读写数据
        // 2.1 定义数组
        byte[] b = new byte[1024];
        // 2.2 定义长度
        int len;
        // 2.3 循环读取
        while ((len = fis.read(b))!=-1) {
            // 2.4 写出数据
            fos.write(b, 0 , len);
        }

        // 3.关闭资源
        fos.close();
        fis.close();
    }
}
```

# 字符流

> 字符流 = 字节流 + 编码表

使用字符流：

```javascript
public class CharaterStream {
    public static void main(String[] args) throws Exception {

        FileInputStream inputStream = new FileInputStream("a.txt");
        byte[] bytes = new byte[1024];
        int len;
        while ((len=inputStream.read(bytes))!=-1){
           System.out.print(new String(bytes,0,len));
        }
    }
}
```

# 字符输入流（Reader）

`java.io.Reader`抽象类是**字符输入流**的所有类的**超类**（父类），可以读取字符信息到内存中。它定义了字符输入流的基本共性功能方法。

**字符输入流的共性方法**：

1. `public void close()` ：关闭此流并释放与此流相关联的任何系统资源。
2.  `public int read()`： 从输入流读取一个字符。
3. `public int read(char[] cbuf)`： 从输入流中读取一些字符，并将它们存储到字符数组 `cbuf`中

### FileReader类

`java.io.FileReader `类是读取字符文件的便利类。构造时使用系统默认的字符编码和默认字节缓冲区。

### 构造方法

1. `FileReader(File file)`： 创建一个新的 FileReader ，给定要读取的**File对象**。
2. `FileReader(String fileName)`： 创建一个新的 FileReader ，给定要读取的文件的**字符串名称**。

```java
public class FileReaderConstructor throws IOException{
    public static void main(String[] args) {
   	 	// 使用File对象创建流对象
        File file = new File("a.txt");
        FileReader fr = new FileReader(file);
      
        // 使用文件名称创建流对象
        FileReader fr = new FileReader("b.txt");
    }
}
```

### FileReader读取字符数据

```java
public class FRRead {
    public static void main(String[] args) throws IOException {
      	// 使用文件名称创建流对象
       	FileReader fr = new FileReader("new.txt");
      	// 定义变量，保存数据
        int b ；
        // 循环读取
        while ((b = fr.read())!=-1) {
            System.out.println((char)b);
        }
		// 关闭资源
        fr.close();
    }
}
```

# 字符输出流（Writer）

`java.io.Writer `抽象类是**字符输出流**的所有类的**超类**（父类），将指定的字符信息写出到目的地。它同样定义了字符输出流的基本共性功能方法。

**字符输出流的基本共性功能方法**：

1. `void write(int c)` 写入单个字符。
2. `void write(char[] cbuf) `写入字符数组。
3. `abstract  void write(char[] cbuf, int off, int len) `写入字符数组的某一部分,off数组的开始索引,len写的字符个数。
4. `void write(String str) `写入字符串。
5. `void write(String str, int off, int len)` 写入字符串的某一部分,off字符串的开始索引,len写的字符个数。
6. `void flush() `刷新该流的缓冲。
7. `void close()` 关闭此流，但要先刷新它。

## FileWriter类

`java.io.FileWriter `类是写出字符到文件的便利类。构造时使用系统默认的字符编码和默认字节缓冲区。

### 构造方法

1、 `FileWriter(File file)`： 创建一个新的 FileWriter，给定要读取的File对象。
 2、`FileWriter(String fileName)`： 创建一个新的 FileWriter，给定要读取的文件的名称。

```java
public class FileWriterConstructor {
    public static void main(String[] args) throws IOException {
   	 	// 第一种：使用File对象创建流对象
        File file = new File("a.txt");
        FileWriter fw = new FileWriter(file);
      
        // 第二种：使用文件名称创建流对象
        FileWriter fw = new FileWriter("b.txt");
    }
}
```

### FileWriter写出数据

**写出字符**：`write(int b)` 方法，每次可以写出一个字符数据，代码使用演示：

```java
public class FWWrite {
    public static void main(String[] args) throws IOException {
        // 使用文件名称创建流对象
        FileWriter fw = new FileWriter("fw.txt");     
      	// 写出数据
      	fw.write(97); // 写出第1个字符
      	fw.write('b'); // 写出第2个字符
      	fw.write('C'); // 写出第3个字符
      	
        //关闭资源时,与FileOutputStream不同。 如果不关闭,数据只是保存到缓冲区，并未保存到文件。
        // fw.close();
    }
}
```

> **注：关闭资源时,与FileOutputStream不同。 如果不关闭,数据只是保存到缓冲区，并未保存到文件。**

### 关闭close和刷新flush

因为内置缓冲区的原因，如果不关闭输出流，无法写出字符到文件中。但是关闭的流对象，是无法继续写出数据的。如果我们既想写出数据，又想继续使用流，就需要`flush` 方法了。

`flush` ：刷新缓冲区，流对象可以继续使用。
`close ` ：先刷新缓冲区，然后通知系统释放资源。流对象不可以再被使用了。

```java
public class FWWrite {
    public static void main(String[] args) throws IOException {
        // 使用文件名称创建流对象
        FileWriter fw = new FileWriter("fw.txt");
        // 写出数据，通过flush
        fw.write('刷'); // 写出第1个字符
        fw.flush();
        fw.write('新'); // 继续写出第2个字符，写出成功
        fw.flush();
      
      	// 写出数据，通过close
        fw.write('关'); // 写出第1个字符
        fw.close();
        fw.write('闭'); // 继续写出第2个字符,【报错】java.io.IOException: Stream closed
        fw.close();
    }
}
```

### FileWriter的续写和换行

```java
public class FWWrite {
    public static void main(String[] args) throws IOException {
        // 使用文件名称创建流对象，可以续写数据
        FileWriter fw = new FileWriter("new.txt"，true);     
      	// 写出字符串
        fw.write("Hello");
      	// 写出换行
      	fw.write("\r\n");
      	// 写出字符串
  		fw.write("World");
      	// 关闭资源
        fw.close();
    }
}
```

### FileReader和FileWriter类完成文本文件复制

```javascript
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

public class CopyFile {
    public static void main(String[] args) throws IOException {
        //创建输入流对象
        FileReader fr=new FileReader("F:\\新建文件夹\\aa.txt");//文件不存在会抛出java.io.FileNotFoundException
        //创建输出流对象
        FileWriter fw=new FileWriter("C:\\copyaa.txt");
        /*创建输出流做的工作：
         *      1、调用系统资源创建了一个文件
         *      2、创建输出流对象
         *      3、把输出流对象指向文件        
         * */
        //文本文件复制，一次读一个字符
        copyMethod1(fr, fw);
        //文本文件复制，一次读一个字符数组
        copyMethod2(fr, fw);
        
        fr.close();
        fw.close();
    }

    public static void copyMethod1(FileReader fr, FileWriter fw) throws IOException {
        int ch;
        while((ch=fr.read())!=-1) {//读数据
            fw.write(ch);//写数据
        }
        fw.flush();
    }

    public static void copyMethod2(FileReader fr, FileWriter fw) throws IOException {
        char chs[]=new char[1024];
        int len=0;
        while((len=fr.read(chs))!=-1) {//读数据
            fw.write(chs,0,len);//写数据
        }
        fw.flush();
    }
}
```

### IO异常的处理

```java
public class HandleException1 {
    public static void main(String[] args) {
      	// 声明变量
        FileWriter fw = null;
        try {
            //创建流对象
            fw = new FileWriter("fw.txt");
            // 写出数据
            fw.write("哥敢摸si"); //哥敢摸si
        } catch (IOException e) {
            e.printStackTrace();
        } finally {
            try {
                if (fw != null) {
                    fw.close();
                }
            } catch (IOException e) {
                e.printStackTrace();
            }
        }
    }
}
```

# 缓冲流

## 概述

首先我们来认识认识一下缓冲流,也叫高效流，是对4个`FileXxx` 流的“增强流”。

**缓冲流的基本原理**：

1. 使用了底层流对象从具体设备上获取数据，并将数据存储到缓冲区的数组内。
2. 通过缓冲区的read()方法从缓冲区获取具体的字符数据，这样就提高了效率。
3. 如果用read方法读取字符数据，并存储到另一个容器中，直到读取到了换行符时，将另一个容器临时存储的数据转成字符串返回，就形成了readLine()功能。

## 字节缓冲流

### 构造方法

- `public BufferedInputStream(InputStream in)` ：创建一个新的缓冲输入流，注意参数类型为**InputStream**。
- `public BufferedOutputStream(OutputStream out)`： 创建一个新的缓冲输出流，注意参数类型为**OutputStream**。

构造举例代码如下：

```java
//构造方式一： 创建字节缓冲输入流【但是开发中一般常用下面的格式申明】
FileInputStream fps = new FileInputStream(b.txt);
BufferedInputStream bis = new BufferedInputStream(fps)

//构造方式一： 创建字节缓冲输入流
BufferedInputStream bis = new BufferedInputStream(new FileInputStream("b.txt"));

///构造方式二： 创建字节缓冲输出流
BufferedOutputStream bos = new BufferedOutputStream(new FileOutputStream("b.txt"));
```

### 感受缓冲流的高效

缓冲流读写方法与基本的流是一致的，我们通过复制370多MB的大文件，测试它的效率。

1. 基本流，代码如下：

```java
public class BufferedDemo {
    public static void main(String[] args) throws FileNotFoundException {
        // 记录开始时间
      	long start = System.currentTimeMillis();
		// 创建流对象
        try (
        	FileInputStream fis = new FileInputStream("py.exe");//exe文件够大
        	FileOutputStream fos = new FileOutputStream("copyPy.exe")
        ){
        	// 读写数据
            int b;
            while ((b = fis.read()) != -1) {
                fos.write(b);
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
		// 记录结束时间
        long end = System.currentTimeMillis();
        System.out.println("普通流复制时间:"+(end - start)+" 毫秒");
    }
}
不好意思十分钟过去了还在玩命复制中...
```

1. 缓冲流，代码如下：

```java
public class BufferedDemo {
    public static void main(String[] args) throws FileNotFoundException {
        // 记录开始时间
      	long start = System.currentTimeMillis();
		// 创建流对象
        try (
         BufferedInputStream bis = new BufferedInputStream(new FileInputStream("py.exe"));
	     BufferedOutputStream bos = new BufferedOutputStream(new FileOutputStream("copyPy.exe"));
        ){
        // 读写数据
            int b;
            while ((b = bis.read()) != -1) {
                bos.write(b);
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
		// 记录结束时间
        long end = System.currentTimeMillis();
        System.out.println("缓冲流复制时间:"+(end - start)+" 毫秒");
    }
}

缓冲流复制时间:8016 毫秒
```

想要更快可以使用数组的方式，代码如下：

```java
public class BufferedDemo {
    public static void main(String[] args) throws FileNotFoundException {
      	// 记录开始时间
        long start = System.currentTimeMillis();
		// 创建流对象
        try (
		 BufferedInputStream bis = new BufferedInputStream(new FileInputStream("py.exe"));
		 BufferedOutputStream bos = new BufferedOutputStream(new FileOutputStream("copyPy.exe"));
        ){
          	// 读写数据
            int len;
            byte[] bytes = new byte[8*1024];
            while ((len = bis.read(bytes)) != -1) {
                bos.write(bytes, 0 , len);
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
		// 记录结束时间
        long end = System.currentTimeMillis();
        System.out.println("缓冲流使用数组复制时间:"+(end - start)+" 毫秒");
    }
}
缓冲流使用数组复制时间:521 毫秒  
```

## 字符缓冲流

### 构造方法

相同的来看看其构造，其格式以及原理和字节缓冲流是一样一样的！

- `public BufferedReader(Reader in)` ：创建一个新的缓冲输入流，注意参数类型为**Reader**。
- `public BufferedWriter(Writer out)`： 创建一个新的缓冲输出流，注意参数类型为**Writer**。

构造举例，代码如下：

```java
// 创建字符缓冲输入流
BufferedReader br = new BufferedReader(new FileReader("b.txt"));
// 创建字符缓冲输出流
BufferedWriter bw = new BufferedWriter(new FileWriter("b.txt"));
```

### 字符缓冲流特有方法

字符缓冲流的基本方法与普通字符流调用方式一致，这里不再阐述，我们来看字符缓冲流具备的**特有**方法。

- BufferedReader：`public String readLine()`: **读一行数据**。 读取到最后返回null
- BufferedWriter：`public void newLine()`: **换行**,由系统属性定义符号。

`readLine`方法演示代码如下：

```java
public class BufferedReaderDemo {
    public static void main(String[] args) throws IOException {
      	 // 创建流对象
        BufferedReader br = new BufferedReader(new FileReader("a.txt"));
		// 定义字符串,保存读取的一行文字
        String line  = null;
      	// 循环读取,读取到最后返回null
        while ((line = br.readLine())!=null) {
            System.out.print(line);
            System.out.println("------");
        }
		// 释放资源
        br.close();
    }
}
```

`newLine`方法演示代码如下：

```java
public class BufferedWriterDemo throws IOException {
  public static void main(String[] args) throws IOException  {
    	// 创建流对象
  	BufferedWriter bw = new BufferedWriter(new FileWriter("b.txt"));
    	// 写出数据
      bw.write("He);
    	// 写出换行
      bw.newLine();
      bw.write("ll");
      bw.newLine();
      bw.write("o");
      bw.newLine();
      bw.write("World");
      bw.newLine();
  		// 释放资源
      bw.close();
  }
}
```

## 字符缓冲流练习

~~~javascript
6.你说你的程序叫简单，我说我的代码叫诗篇
1.一想到你我就哦豁豁豁豁豁豁豁豁豁豁....哦nima个头啊，完全不理人家受得了受不了
8.Just 简单你和我  ，Just 简单程序员
3.约了地点却忘了见面 ，懂得寂寞才明白浩瀚
5.沉默是最大的发言权
2.总是喜欢坐在电脑前，  总是喜欢工作到很晚
7.向左走 又向右走，我们转了好多的弯
4.你从来就不问我，你还是不是那个程序员
~~~

### 代码实现

```java
public class BufferedTest {
    public static void main(String[] args) throws IOException {
        // 创建map集合,保存文本数据,键为序号,值为文字
        HashMap<String, String> lineMap = new HashMap<>();

        // 创建流对象  源
        BufferedReader br = new BufferedReader(new FileReader("a.txt"));
        //目标
        BufferedWriter bw = new BufferedWriter(new FileWriter("b.txt"));

        // 读取数据
        String line  = null;
        while ((line = br.readLine())!=null) {
            // 解析文本
            String[] split = line.split("\\.");
            // 保存到集合
            lineMap.put(split[0],split[1]);
        }
        // 释放资源
        br.close();

        // 遍历map集合
        for (int i = 1; i <= lineMap.size(); i++) {
            String key = String.valueOf(i);
            // 获取map中文本
            String value = lineMap.get(key);
          	// 写出拼接文本
            bw.write(key+"."+value);
          	// 写出换行
            bw.newLine();
        }
		// 释放资源
        bw.close();
    }
}
```

运行效果：

```javascript
1.一想到你我就哦豁豁豁豁豁豁豁豁豁豁…哦nima个头啊，完全不理人家受得了受不了
2.总是喜欢坐在电脑前， 总是喜欢工作到很晚
3.约了地点却忘了见面 ，懂得寂寞才明白浩瀚
4.你从来就不问我，你还是不是那个程序员
5.沉默是最大的发言权
6.你说你的程序叫简单，我说我的代码叫诗篇
7.向左走 又向右走，我们转了好多的弯
8.Just 简单你和我 ，Just 简单程序员
```

# 转换流

字符流=字节流+编码表

```java
String(byte[] bytes, String charsetName):通过指定的字符集解码字节数组
byte[] getBytes(String charsetName):使用指定的字符集合把字符串编码为字节数组

编码:把看得懂的变成看不懂的
String -- byte[]

解码:把看不懂的变成看得懂的
byte[] -- String
```

- **字符编码** `Character Encoding`: 就是一套自然语言的字符与二进制数之间的对应规则。

  而**编码表**则是生活中文字和计算机中二进制的对应规则

### 字符集

- **字符集** `Charset`：也叫**编码表**。是一个系统支持的所有字符的集合，包括各国家文字、标点符号、图形符号、数字等。

计算机要准确的存储和识别各种字符集符号，需要进行字符编码，一套字符集必然至少有一套字符编码。常见字符集有`ASCII`字符集、`GBK`字符集、`Unicode`字符集等。
 ![字符编码](https://img-blog.csdnimg.cn/20191016090127127.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3FxXzQ0NTQzNTA4,size_16,color_FFFFFF,t_70)

- ASCII字符集 ：

  - ASCII（American Standard Code for Information  Interchange，美国信息交换标准代码）是基于拉丁字母的一套电脑编码系统，用于显示现代英语，主要包括控制字符（回车键、退格、换行键等）和可显示字符（英文大小写字符、阿拉伯数字和西文符号）。
  - 基本的ASCII字符集，使用7位（bits）表示一个字符，共128字符。ASCII的扩展字符集使用8位（bits）表示一个字符，共256字符，方便支持欧洲常用字符。

- ISO-8859-1字符集 ：

  - 拉丁码表，别名Latin-1，用于显示欧洲使用的语言，包括荷兰、丹麦、德语、意大利语、西班牙语等。
  - ISO-8859-1使用单字节编码，兼容ASCII编码。

- GBxxx字符集 ：

  - GB就是国标的意思，是为了显示中文而设计的一套字符集。
  - **GB2312**：简体中文码表。一个小于127的字符的意义与原来相同。但两个大于127的字符连在一起时，就表示一个汉字，这样大约可以组合了包含7000多个简体汉字，此外数学符号、罗马希腊的字母、日文的假名们都编进去了，连在ASCII里本来就有的数字、标点、字母都统统重新编了两个字节长的编码，这就是常说的"全角"字符，而原来在127号以下的那些就叫"半角"字符了。
  - **GBK**：最常用的中文码表。是在GB2312标准基础上的扩展规范，使用了双字节编码方案，共收录了21003个汉字，完全兼容GB2312标准，同时支持繁体汉字以及日韩汉字等。
  - **GB18030**：最新的中文码表。收录汉字70244个，采用多字节编码，每个字可以由1个、2个或4个字节组成。支持中国国内少数民族的文字，同时支持繁体汉字以及日韩汉字等。

- Unicode字符集 ：

  - Unicode编码系统为表达任意语言的任意字符而设计，是业界的一种标准，也称为统一码、标准万国码。
  - 它最多使用4个字节的数字来表达每个字母、符号，或者文字。有三种编码方案，UTF-8、UTF-16和UTF-32。最为常用的UTF-8编码。
  - UTF-8编码，可以用来表示Unicode标准中任何字符，它是电子邮件、网页及其他存储或传送文字的应用中，优先采用的编码。互联网工程工作小组（IETF）要求所有互联网协议都必须支持UTF-8编码。所以，我们开发Web应用，也要使用UTF-8编码。它使用一至四个字节为每个字符编码，编码规则：
    1. 128个US-ASCII字符，只需一个字节编码。
    2. 拉丁文等字符，需要二个字节编码。
    3. 大部分常用字（含中文），使用三个字节编码。
    4. 其他极少使用的Unicode辅助字符，使用四字节编码。

## InputStreamReader类(字节流到字符流的桥梁)

转换流`java.io.InputStreamReader`，是`Reader`的子类，从字面意思可以看出它是从字节流到字符流的桥梁。它读取字节，并使用指定的字符集将其解码为字符。它的字符集可以由名称指定，也可以接受平台的默认字符集。

### 构造方法

> `InputStreamReader(InputStream in)`: 创建一个使用默认字符集的字符流。
> `InputStreamReader(InputStream in, String charsetName)`: 创建一个指定字符集的字符流。

```java
InputStreamReader isr = new InputStreamReader(new FileInputStream("in.txt"));
InputStreamReader isr2 = new InputStreamReader(new FileInputStream("in.txt") , "GBK");
```

### 使用转换流解决编码问题

```java
public class ReaderDemo2 {
    public static void main(String[] args) throws IOException {
      	// 定义文件路径,文件为gbk编码
        String FileName = "C:\\A.txt";
      	// 创建流对象,默认UTF8编码
        InputStreamReader isr = new InputStreamReader(new FileInputStream(FileName));
      	// 创建流对象,指定GBK编码
        InputStreamReader isr2 = new InputStreamReader(new FileInputStream(FileName) , "GBK");
		// 定义变量,保存字符
        int read;
      	// 使用默认编码字符流读取,乱码
        while ((read = isr.read()) != -1) {
            System.out.print((char)read); // �����ʺ      
        }
        isr.close();
      
      	// 使用指定编码字符流读取,正常解析
        while ((read = isr2.read()) != -1) {
            System.out.print((char)read);// 美丽水世界
        }
        isr2.close();
    }
}
```

## OutputStreamWriter类(字符流到字节流的桥梁)

### 构造方法

> `OutputStreamWriter(OutputStream in)`: 创建一个使用默认字符集的字符流。
> `OutputStreamWriter(OutputStream in, String charsetName)`: 创建一个指定字符集的字符流。

构造举例，代码如下：

```java
OutputStreamWriter isr = new OutputStreamWriter(new FileOutputStream("a.txt"));
OutputStreamWriter isr2 = new OutputStreamWriter(new FileOutputStream("b.txt") , "GBK");
```

### 指定编码构造代码

```java
public class OutputDemo {
    public static void main(String[] args) throws IOException {
      	// 定义文件路径
        String FileName = "C:\\s.txt";
      	// 创建流对象,默认UTF8编码
        OutputStreamWriter osw = new OutputStreamWriter(new FileOutputStream(FileName));
        // 写出数据
      	osw.write("哥敢"); // 保存为6个字节
        osw.close();
      	
		// 定义文件路径
		String FileName2 = "D:\\A.txt";
     	// 创建流对象,指定GBK编码
        OutputStreamWriter osw2 = new OutputStreamWriter(new FileOutputStream(FileName2),"GBK");
        // 写出数据
      	osw2.write("摸屎");// 保存为4个字节
        osw2.close();
    }
}
```

![在这里插入图片描述](https://img-blog.csdnimg.cn/20191016100612927.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3FxXzQ0NTQzNTA4,size_16,color_FFFFFF,t_70)
 为了达到**最高效率**，可以考虑在 `BufferedReader` 内包装 `InputStreamReader`

```javascript
BufferedReader in = new BufferedReader(new InputStreamReader(System.in))；
```

# 序列化流

## 概述

Java 提供了一种对象**序列化**的机制。用一个字节序列可以表示一个对象，该字节序列包含该`对象的数据`、`对象的类型`和`对象中存储的属性`等信息。字节序列写出到文件之后，相当于文件中**持久保存**了一个对象的信息。

反之，该字节序列还可以从文件中读取回来，重构对象，对它进行**反序列化**。`对象的数据`、`对象的类型`和`对象中存储的数据`信息，都可以用来在内存中创建对象。看图理解序列化：
 ![在这里插入图片描述](https://img-blog.csdnimg.cn/20191016100818120.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3FxXzQ0NTQzNTA4,size_16,color_FFFFFF,t_70)

## ObjectOutputStream类

`java.io.ObjectOutputStream ` 类，将Java对象的原始数据类型写出到文件,实现对象的持久存储。

### 构造方法

`public ObjectOutputStream(OutputStream out) `： 创建一个指定OutputStream的ObjectOutputStream。

构造代码如下：

```java
FileOutputStream fileOut = new FileOutputStream("aa.txt");
ObjectOutputStream out = new ObjectOutputStream(fileOut);
```

### 序列化操作

1. 一个对象要想序列化，必须满足两个条件:

该类必须实现`java.io.Serializable ` 接口，`Serializable` 是一个标记接口，不实现此接口的类将不会使任何状态序列化或反序列化，会抛出`NotSerializableException` 。

该类的所有属性必须是可序列化的。如果有一个属性不需要可序列化的，则该属性必须注明是瞬态的，使用`transient` 关键字修饰。

```java
public class Employee implements java.io.Serializable {
    public String name;
    public String address;
    public transient int age; // transient瞬态修饰成员,不会被序列化
    public void addressCheck() {
      	System.out.println("Address  check : " + name + " -- " + address);
    }
}
```

2.写出对象方法

`public final void writeObject (Object obj)` : 将指定的对象写出。

```java
public class SerializeDemo{
   	public static void main(String [] args)   {
    	Employee e = new Employee();
    	e.name = "zhangsan";
    	e.address = "beiqinglu";
    	e.age = 20; 
    	try {
      		// 创建序列化流对象
          ObjectOutputStream out = new ObjectOutputStream(new FileOutputStream("employee.txt"));
        	// 写出对象
        	out.writeObject(e);
        	// 释放资源
        	out.close();
        	fileOut.close();
        	System.out.println("Serialized data is saved"); // 姓名，地址被序列化，年龄没有被序列化。
        } catch(IOException i)   {
            i.printStackTrace();
        }
   	}
}
输出结果：
Serialized data is saved
```

## ObjectInputStream类

ObjectInputStream反序列化流，将之前使用ObjectOutputStream序列化的原始数据恢复为对象。

### 构造方法

`public ObjectInputStream(InputStream in) `： 创建一个指定InputStream的ObjectInputStream。

### 反序列化操作1

如果能找到一个对象的class文件，我们可以进行反序列化操作，调用`ObjectInputStream`读取对象的方法：

- `public final Object readObject ()` : 读取一个对象。

```java
public class DeserializeDemo {
   public static void main(String [] args)   {
        Employee e = null;
        try {		
             // 创建反序列化流
             FileInputStream fileIn = new FileInputStream("employee.txt");
             ObjectInputStream in = new ObjectInputStream(fileIn);
             // 读取一个对象
             e = (Employee) in.readObject();
             // 释放资源
             in.close();
             fileIn.close();
        }catch(IOException i) {
             // 捕获其他异常
             i.printStackTrace();
             return;
        }catch(ClassNotFoundException c)  {
        	// 捕获类找不到异常
             System.out.println("Employee class not found");
             c.printStackTrace();
             return;
        }
        // 无异常,直接打印输出
        System.out.println("Name: " + e.name);	// zhangsan
        System.out.println("Address: " + e.address); // beiqinglu
        System.out.println("age: " + e.age); // 0
    }
}
```

**对于JVM可以反序列化对象，它必须是能够找到class文件的类。如果找不到该类的class文件，则抛出一个 `ClassNotFoundException` 异常。**

### 反序列化操作2

另外，当JVM反序列化对象时，能找到class文件，但是class文件在序列化对象之后发生了修改，那么反序列化操作也会失败，抛出一个`InvalidClassException`异常。发生这个异常的原因如下：

1. 该类的序列版本号与从流中读取的类描述符的版本号不匹配
2. 该类包含未知数据类型
3. 该类没有可访问的无参数构造方法

`Serializable` 接口给需要序列化的类，提供了一个序列版本号。`serialVersionUID` 该版本号的目的在于验证序列化的对象和对应类是否版本匹配。

```java
public class Employee implements java.io.Serializable {
     // 加入序列版本号
     private static final long serialVersionUID = 1L;
     public String name;
     public String address;
     // 添加新的属性 ,重新编译, 可以反序列化,该属性赋为默认值.
     public int eid; 

     public void addressCheck() {
         System.out.println("Address  check : " + name + " -- " + address);
     }
}
```

## 序列化集合练习

1. 将存有多个自定义对象的集合序列化操作，保存到`list.txt`文件中。
2. 反序列化`list.txt` ，并遍历集合，打印对象信息。

### 案例分析

1. 把若干学生对象 ，保存到集合中。
2. 把集合序列化。
3. 反序列化读取时，只需要读取一次，转换为集合类型。
4. 遍历集合，可以打印所有的学生信息

### 案例代码实现

```java
public class SerTest {
	public static void main(String[] args) throws Exception {
		// 创建 学生对象
		Student student = new Student("老王", "laow");
		Student student2 = new Student("老张", "laoz");
		Student student3 = new Student("老李", "laol");

		ArrayList<Student> arrayList = new ArrayList<>();
		arrayList.add(student);
		arrayList.add(student2);
		arrayList.add(student3);
		// 序列化操作
		// serializ(arrayList);
		
		// 反序列化  
		ObjectInputStream ois  = new ObjectInputStream(new FileInputStream("list.txt"));
		// 读取对象,强转为ArrayList类型
		ArrayList<Student> list  = (ArrayList<Student>)ois.readObject();
		
      	for (int i = 0; i < list.size(); i++ ){
          	Student s = list.get(i);
        	System.out.println(s.getName()+"--"+ s.getPwd());
      	}
	}

	private static void serializ(ArrayList<Student> arrayList) throws Exception {
		// 创建 序列化流 
		ObjectOutputStream oos = new ObjectOutputStream(new FileOutputStream("list.txt"));
		// 写出对象
		oos.writeObject(arrayList);
		// 释放资源
		oos.close();
	}
}
```

# 打印流

## 概述

平时我们在控制台打印输出，是调用`print`方法和`println`方法完成的，各位用了这么久的输出语句肯定没想过这两个方法都来自于`java.io.PrintStream`类吧，哈哈。该类能够方便地打印各种数据类型的值，是一种便捷的输出方式。

**打印流分类**：

> 字节打印流PrintStream，字符打印流PrintWriter

**打印流特点**：

> A:只操作目的地,不操作数据源
> B:可以操作任意类型的数据
> C:如果启用了自动刷新，在调用println()方法的时候，能够换行并刷新
> D:可以直接操作文件

这个时候有同学就要问了，哪些流可以直接操作文件呢?答案很简单，**如果该流的构造方法能够同时接收File和String类型的参数，一般都是可以直接操作文件的**！

PrintStream是OutputStream的子类，PrintWriter是Writer的子类，两者处于对等的位置上，所以它们的API是非常相似的。二者区别无非一个是字节打印流，一个是字符打印流。

## 字节输出打印流PrintStream复制文本文件

```javascript
import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.io.PrintStream;

public class PrintStreamDemo {
    public static void main(String[] args) throws IOException {
        BufferedReader br=new BufferedReader(new FileReader("copy.txt"));
        PrintStream ps=new PrintStream("printcopy.txt");
        String line;
        while((line=br.readLine())!=null) {
            ps.println(line);
        }
        br.close();
        ps.close();
    }
}
```

## 字符输出打印流PrintWriter复制文本文件

```javascript
import java.io.BufferedReader;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
/**
 * 使用打印流复制文本文件
 */
public class PrintWriterDemo {
    public static void main(String[] args) throws IOException {
        BufferedReader br=new BufferedReader(new FileReader("aa.txt"));
        PrintWriter pw=new PrintWriter("printcopyaa.txt");
        String line;
        while((line=br.readLine())!=null) {
            pw.println(line);
        }
        br.close();
        pw.close();
    }
}
```