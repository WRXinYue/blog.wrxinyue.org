---
data: 2023-04-12 00:23:42
updated: 2023-04-12 00:23:42
---
# 关于我为什么使用NAS

在家办公的时候常常会遇到存储空间不足硬盘爆满的问题，因为我的电脑不支持加机械硬盘，换固态又太贵。家里还有个几年前拆机留下来的机械硬盘，然后为了外接机械硬盘在拼多多买了个双盘硬盘阵列，时间长了就会发现-阵列完全不够用，还有各种散热减震的问题。于是我去网上找更好的硬盘阵列，最后发现了一个名为NAS的东西...

# 什么是NAS

在入坑NAS之前，我们得先了解NAS是什么以及它的作用，还有一点就是，不是所有人都需要个NAS，是否使用NAS取决于你是否使用它的功能，毕竟它们的价格是非常高昂的。

NAS，全称Network Attached Storage，它提供数据文件的存储与管理, 并通过以太网传输



# 成品 Or DIY

DIY一台NAS是一件很折腾的事情，如果没有耐性和强大的学习能力建议直接买现成的。

我们这里主要详细讲DIY一个NAS系统，毕竟自身也是程序员，从个人角度出发。

## 成品NAS

![image-20220927154548248](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20220927154548248.png)

如果是用于干活办公的话，就要选择一套稳定的硬件，上面例举了一些品牌。

如果是随便玩玩，去某鱼整个几百块钱的星际蜗牛就可以了。

## DIY NAS

### cpu

基本没有DIY NAS用AMD处理器的，各种兼容性问题，很麻烦。

另外CPU需要具备“虚拟化技术”。嘤特尔上有个VT-D（VirtualzationTechnology for Directed），这是IO层/芯片层的虚拟化；还有个叫VT-X是CPU层的虚拟化。

推荐：

> 入门级：如赛扬，用J1900、J3455、J4105、J5005之类，功耗也会非常低。但要注意，J1900只支持VT-X，并不具备VT-D功能。J3455及以上，就都支持VT-D了
>
> 酷睿处理器方面，从第四代酷睿（Haswell）以后的CPU大部分都支持VT-D。如果作All in On，或多开虚拟机，一般推荐使用intel四代以后的i5和i7或者八代以后的i3以上级别CP

### 主板

NAS能安装硬盘的数量取决于主板SATA接口数量以及PCI-E扩展口的数量，主板型号一般会选择MATX或ITX。

MATX主板优势：

6个SATA接口，新一些还有2个M.2的SSD、接口。2条PCIE*16的插槽（一般一个是x16、一个是x4），方便再扩展万兆网卡，多口千兆网卡，以及SATA扩展卡。适合打造多盘位+双m.2 + 多千兆网口 + 万兆网口的强悍NAS主机。缺点就是体积会比较大。

ITX主板优势：

相对于MATX主板，体积小，但是扩展性相对较差，价格高，SATA接口相对较少

### 内存

内存一般为8~16（建议16），频率方面2400MHz或2666MHz就可以

### 硬盘

NAS专用硬盘（酷狼、红盘等）和企业硬盘会比较贵，别买SMR盘就行，即叠瓦盘。

### 散热器

能压住CPU即可

### 机箱

便宜点的有蜗牛星际那种廉价的机箱，NAS机箱和普通机箱都可以，本人NAS是放在桌子上的就选择了体积小的NAS机箱。

# 低功耗 x86 4-Bay NAS

| Model     | Synology DS920+     | QNAP TS-453D        | DIY 1                       |
| --------- | ------------------- | ------------------- | --------------------------- |
| CPU       | Intel Celeron J4125 | Intel Celeron J4125 | Intel Celeron J5005         |
| RAM       | 1x 2 GB             | 1x 4 GB             | 1x 8 GB DDR4 2400MHz (~250) |
| MB        | -                   | -                   | ASRock J5005-ITX (~860)     |
| PSU       | -                   | -                   | Flex 150W (~$100)           |
| CASE      | -                   | -                   | 蜗牛星际 4-Bay (~$150)      |
| Network   | 一个 1GbE           | 两个 2.5GbE         | 一个 1GbE                   |
| Interface | 两个 M.2 NVME       | 一个 PCIe 2.0 x2    | 一个 M.2 Key E, PCIe 2.0 x1 |
| Price     | $4520               | $3599               | $1360                       |

**Table 1: 4-Bay x86 NAS 規格及價錢比較**

| Model          | Synology DS-1821+   | QNAP TS-873A-8G     | DIY 2                                                        |
| -------------- | ------------------- | ------------------- | ------------------------------------------------------------ |
| CPU            | AMD Ryzen V1500B    | AMD Ryzen V1500B    | Intel i3-10105 (~$850)                                       |
| RAM            | 1x 4 GB (最大 32GB) | 1x 8 GB (最大 64GB) | 1x 8 GB DDR4 2666MHz (~$250)                                 |
| MB             | -                   | -                   | MSI H510M BOMBER (~$420)                                     |
| PSU            | -                   | -                   | SilverStone 300W SFX SST-SX300-B 80Plus Bronze (~$350)       |
| CASE           | -                   | -                   | 8-Bay 伺服器塔式機箱 (~$350)                                 |
| Network        | 四個 1GbE           | 兩個 2.5GbE         | 一個 1GbE                                                    |
| Interface      | 兩個 M.2 NVME       | 兩個 PCIe 3.0 x4    | 一個 M.2 NVME, 一個 PCIe 3.0 x16, 一個 M.2 Key E, 一個 PCIe 3.0 x1 |
| Expansion card | -                   | -                   | 一張 PCIe 3.0 x1 轉四口 SATA 卡 (~$60)                       |
| Price          | $8462               | $8178               | $2280                                                        |

**Table 2: 8-Bay x86 NAS 規格及價錢比較**

一台NAS需要的核心硬件：CPU、RAID、

# 查阅资料：

[2022年品牌NAS入坑指南|快速找到适合你的NAS型号|群晖威联通推荐](https://zhuanlan.zhihu.com/p/361125179)