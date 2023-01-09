---
title: hugo+github+vercel导航搭建
date: 2023-01-09 23:51:12
categories: 
- 博客搭建
tags: 
- 博客
- github
---

## 安装hugo

注：再此之前需要安装choco包管理器

~~~powershell
choco install hugo -confirm
~~~



## 使用Hugo创建博客

~~~powershell
# 创建名为navigation的博客
hugo new site navigation
~~~



## 下载博客主题

1. 进入**themes**文件夹，并打开cmd

2. 输入`git clone https://github.com/shenweiyan/WebStack-Hugo.git`

3. themes/WebStack-Hugo/exampleSite 目录下的所有文件复制到 hugo 站点根目录

   `copy WebStack-Hugo/exampleSite/* .. -force && cd..`

此时我们回到根目录发现，我们的文件已经复制成功。（ps：个人还是比较习惯用命令端）

![image-20230106105546449](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230106105546449.png)

## 删除.git文件夹(如果有)

> 注：如果git的主题有.git和.github文件夹，我们就需要手动删除，否则在推送的时候主题就会出现问题

~~~shell
# 删除 .git 和 .github 文件,注意！这里我用的是powershell，cmd命令：
# rd /s /q .git && rd /s /q .github
Remove-Item -Recurse -Force .git && Remove-Item -Recurse -Force .github
~~~


![image-20230106151544960](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230106151544960.png)

## 启动Hugo预览服务器

~~~powershell
hugo.exe server
~~~

![image-20230106105906332](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230106105906332.png)

点击并进入 http://localhost:1313/ ，进入之后就可以看到我们的站点创建成功了！

![image-20230106110117114](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230106110117114.png)



## 具体步骤

~~~powershell
# 创建名为navigation的博客
hugo new site navigation
cd navigation\themes
# 下载博客主题
git clone https://github.com/shenweiyan/WebStack-Hugo.git
cd WebStack-Hugo/
# 复制文件到根目录
copy exampleSite/* ..\.. -force
# 删除 .git 和 .github 文件
# rd /s /q .git && rd /s /q .github
Remove-Item -Recurse -Force .git && Remove-Item -Recurse -Force .github
cd ..\..
# 启动Hugo预览服务器
hugo.exe server
~~~

# 使用说明

官方文档：[WebStack-Hugo | 一个静态响应式网址导航主题 (yuque.com)](https://www.yuque.com/shenweiyan/cookbook/webstack-hugo)

详细说明我就不写了，官方文档都有，我们来简单配置一下，在根目录data创建一个**webstack.yml**的文件配置如下:

~~~yml
- taxonomy: 科研办公
  icon: fas fa-flask fa-lg
  list:
    - term: 生物信息
      links:
        - title: NCBI
          logo: ncbi.jpg
          url: https://www.ncbi.nlm.nih.gov/
          description: National Center for Biotechnology Information.
        - title: Bioconda
          logo: bioconda.jpg
          url: https://anaconda.org/bioconda/
          description: "Bioconda :: Anaconda.org."
    - term: 云服务器
      links:
        - title: 阿里云
          logo: 阿里云.jpg
          url: https://www.aliyun.com/
          description: 上云就上阿里云。
        - title: 腾讯云
          logo: 腾讯云.jpg
          url: https://cloud.tencent.com/
          description: 产业智变，云启未来。
~~~

# github+vercel网页托管

## 创建仓库

正常创建仓库即可，这里我可见选择的是**Private**

![image-20230106111615936](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230106111615936.png)

## 提交仓库

创建成功之后，我们把仓库地址复制一些，然后回到我们的shell窗口把项目提交到仓库

![image-20230106112130392](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230106112130392.png)



**具体命令如下：**

~~~shell
git init
git add .
git commit -m "first commit"
git checkout -b main
git remote add origin https://github.com/WRXinYue/navigation.git
git push -u origin main
~~~



## vercel

关于注册我就不详细说了网上教程一大堆，我们直接快速进入；

1. 点击**Add New...**,进入页面之后登录GitHub账号进行导入

   ![image-20230106113546800](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230106113546800.png)

2. 找到我们仓库的项目，然后点击**Import**导入

   ![image-20230106113635403](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230106113635403.png)

3. Framework Preset选择**Hugo**，然后点击**Deploy**进行部署

   ![image-20230106113759267](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230106113759267.png)

4. 部署成功!是不是很easy呢，之后可以根据自己的喜爱进行修改域名以及样式

