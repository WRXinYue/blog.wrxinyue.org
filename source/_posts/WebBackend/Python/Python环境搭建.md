---
title: Python环境搭建
categories:
 - Python
tags:
 - ''
data: 2023-05-24 10:34:45
updated: 2023-05-25 18:57:09
---

## 安装CUDA + NVCC

```bash
nvidia-smi
```

[CUDA Toolkit](https://developer.nvidia.com/cuda-downloads)自带 NVIDIA CUDA 编译器（NVCC）

```bash
nvcc --version
```

安装Visual Studio，因为CUDA在安装时，需要VS的里面的工具包来编译。在安装过程中，会自动检测本机是否已经安装了配套的VS版本，如果VS版本和Cuda版本不匹配的话，安装无法进行

下载完安装包后双击，安装选项：工作负载处，勾选“C++的桌面开发（其他的可不勾选，若需要的话，后面可再次安装）

## 安装anconda

**查找路径：**
```bash
sudo find / -type d -iname 'anaconda3' 2>/dev/null
```

```bash
conda --version
anaconda --version
```

**更新：**
```bash
~/anaconda3/bin/conda update -n base conda
~/anaconda3/bin/conda update --all
```

## 安装pycharm

## 安装pytorch

```bash
pip install torch torchvision -f https://download.pytorch.org/whl/cu111/torch_stable.html
```

**版本查看：**
```python
import torch
print(torch.__version__) #注意是双下划线
```

nvcc可能不是强依赖，咱们安装2~4
安装pytorch参考
https://blog.csdn.net/qq_42257666/article/details/121361983?utm_medium=distribute.pc_relevant.none-task-blog-2~default~baidujs_baidulandingword~default-0-121361983-blog-127182762.235^v36^pc_relevant_default_base&spm=1001.2101.3001.4242.1&utm_relevant_index=3



## 更换下载源

1. 阿里云：http://mirrors.aliyun.com/pypi/simple/
2. 中国科技大学：https://pypi.mirrors.ustc.edu.cn/simple/
3. 豆瓣：http://pypi.douban.com/simple/
4. 清华大学：https://pypi.tuna.tsinghua.edu.cn/simple/
5. 中国科学技术大学：http://pypi.mirrors.ustc.edu.cn/simple/

更换pip源有两种方法：

1. 临时使用：在使用pip时加上`-i`参数，然后指定源。例如：
```
pip install scrapy -i https://pypi.tuna.tsinghua.edu.cn/simple
```

2. 永久修改：
   1. 在Linux系统中，修改`~/.pip/pip.conf`文件（若不存在则创建一个)，内容如下：
```
[global]
index-url = https://mirrors.aliyun.com/pypi/simple/
```
   2. 在Windows系统中，在用户目录下创建一个名为`pip`的文件夹（例如：`C:\Users\xx\pip`），新建文件`pip.ini`，内容如下：
```
[global]
index-url = https://pypi.tuna.tsinghua.edu.cn/simple
```

## 版本切换

https://blog.csdn.net/lly1122334/article/details/126846882




```
python3.8-distutils
```