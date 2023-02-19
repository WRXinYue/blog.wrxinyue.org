---
title: Unity2017教程笔记（P1到P23，unity页面介绍）
date: 2022-07-24 19:54:17.0
updated: 2022-10-26 22:42:42.724
url: /archives/Unity2017教程笔记
categories: 
- Unity/虚幻
tags: 
- unity
---

## 坐标

* 坐标：X红色、Y绿色、Z蓝色

  世界坐标 ： 整个场景的固定坐标，不随物体旋转而改变

  本地坐标 ：物体自身坐标，随旋转而改变

## 场景 Scenes

* 一组相关联的游戏对象的集合，通常游戏中每个关卡就是一个场景，用于展现当前关卡中的所有物体。

## 游戏对象 GameObject

* 运行时出现在场景中的游戏物体

  例如：人物、地形、数目......

* 是一种<u>容器</u>、可以挂载组件。

* 父、子物体

  在Hierarchy面板中。将一个物体拖拽到另外一个物体中。

  子物体将继承父物体的移动，旋转和缩放属性，但子物体不影响父物体。

## 组件 Component

* 是游戏对象的功能模块。
* 每个组件都是一个类的实例。
* Transform 变换组件：决定物体位置、旋转、缩放比。
* Mesh Filter 网络过滤器：用于从资源中获取网络信息。
* Mesh Renderer 网络渲染器 : 从网络过滤器中获得几何形状，对根据变化组件定义的位置进行渲染。
* 网格过滤器 与 网格渲染器 联合使用 ，使模型显示到屏幕上。

Project工程对象-Scene场景-GameObject游戏对象（容器）-Component组件（功能）

## 材质 Material

* 材质：物体的质地，指色彩、纹理、光滑度、透明度、反射率、发光度等。实际就是Shader的实例。
* Shader 着色器 ： 专门用来渲染3D图形的技术，可以使纹理以某种方式展现。实际就是一段嵌入到渲染管线中的程序，可以控制GPU运算图像效果的算法。
* Texture 纹理 ：附加到物体表面的贴图。

## 物理着色器

* 基于物理特性的Shader是Unity 5.x的重大革新之一,所谓物理着色器(Physically Based Shading,PBS)就是遵从物理学的能量守恒定律,可以创建出在不同光照环境下都接近真实的效果。

## 摄像机 Camera

### 简介

* 附加了摄像机Camera组件的游戏对象
* 向玩家捕获和现实世界的设备
* 场景中摄像机的数量不受限制

### 组件

* Transform 变换组件
* Camera 摄像机 ： 向玩家捕获和显示世界
* Flare Layer 耀斑层 : 激活可显示光源耀斑
* GUI Layer : 激活可渲染二维GUI元素
* Audio Listener视频监听器 ； 接收场景输入的音源Audio Source并通过计算机的扬声器播放声音。

### 属性

* Clear Flags清除标识:决定屏幕的空白部分如何处理
  Skybox天空盒:空白部分显示天空盒图案
  Solid Color纯色:空白部分显示背景颜色
  Depth Only仅深度:画中画效果时，小画面摄像机选

  择该项可清除屏幕空部分信息只保留物体颜色信息。
  Don' t Clear 不清除:不清除任何颜色或深度缓存。

* Background背景:所有元素绘制后，没有天空盒的情况
  下，剩余屏幕的颜色。

* Culling Mask选择遮蔽层:选择要照射的层Layer 。

* Projection投射方式: 
  Perspective透视:透视图,物体具有近大远小效果。
  Orthographic正交:摄像机会均匀地渲染物体,没有透视感,通常小地图使用。

* Size大小(正交模式) :摄影机视口的大小

* Field of view视野(透视模式) :设置相机视野的远近距离

* Field of view裁剪面:相机到开始和结束渲染的距离
  Near近:绘制的最近点。
  Far远:绘制的最远点。

* Viewport Rect视矩形:标明这台相机视图将会在屏幕
  上绘制的屏幕坐标。
  X:摄像机视图的开始水平位置。
  Y:摄像机视图的开始垂直位置。
  W宽度:摄像机输出在屏幕上的宽度。
  H高度:摄像机输出在屏幕上的高度。

* Depth深度:相机在渲染顺序上的位置。具有较低深度的
  摄像机将在较高深度的摄像机之前渲染。

## 天空盒 SkyBox

* 围绕整个场景的包装器，用于模拟天空的材质

* 天空和材质种类 ： 6 Sided ， Procedural ，Cubemap 。

### 6 Sided 属性

* Tint Color 色彩
* Exposure 亮度
* Rotation 旋转

### Procedural 属性

* Sun 太阳模式

  -- None 没有

  -- Simple 简单

  --Higth  Quality 高质量

* Atmoshpere Thickness 大气层厚度

* Ground 地面颜色

* 如果为Environment Lighting的Sun属性设置一 个平行光场景中会根据平行光角度自动创建太阳,并且位置随平行光旋转而改变。如果不设置,系统将默认选择场景中最亮的平行光。

### 使用太空盒

* 设置摄像机 Clear Flags 属性为Skybox。

* 方式以：摄像机添加组件 Skybox

* 方法二 ：光照窗口

  Window - Lighting - Environment Lighting -- Skybox
  可作为反射源将天空色彩反射到场景中物体。

## InstantOC

### 渲染管线

* 游戏数据在GPU上经过运算处理，最后输出到屏幕的过程
  $$
  绘制调用 Draw Call： 每次引擎准备数据并通知GPU的过程。通俗讲，每帧调用显卡渲染物体的次数
  $$
  游戏 —> 图形API —> CPU与GPU分界线 —> 顶点处理 —> 图元装配 —> 光栅化 —> 图像处理 —> 缓存

#### 顶点处理

* 接受模型顶点数据。（任何的一个图形都是若干个三角组成的,三角形定点坐标）
* 坐标系转换。

#### 图元装配

* 组装面 ： 连接相邻的顶点，绘制为三角面

#### 光栅化

* 计算三角面上的像素，并为后面着色阶段提供合理的插值参数。

#### 像素处理

* 对每个像素区域进行着色。
* 写入到缓存中

#### 缓存

* 一个存储像素数据的内存块，最重要的缓存时帧缓存与深度缓存
* 帧缓存 ：存储每个像素的色彩，即渲染后的图像。帧缓存常常在显存中，显卡不断读取并输出到屏幕中。
* 深度缓存 z-buffer : 存储像素的深度信息，即物体到摄像机的距离。光栅化时便计算各像素的深度值，如果新的深度值比现有值更近，则像素颜色被写到帧缓存，并替换深度缓存。

### 属性

*  Layer mask ：参与遮挡剔除的游戏对象层。

* IOC Tag ：将为指定标签的游戏对象自动添加IOClod脚本对象。

* Samples ： 每帧相机发射的射线数目。数量多剔除效果好，但性能开销大。通常在150-500之间。

* Rays FOV ： 射线视野，应大于摄像机事业Field of View。

* View Distance ： 试图距离 ， 射线长度。

  ​								将影响摄像机Clipping Planes -Far 数值。

* Hide Delay： 延迟隐藏，当物体被剔除时延迟的帧数，建议50-100之间。

* PreCull Check ： 检查采集信息，建议勾选，可以提高剔除效率。

* Realtime Shadows： 实时阴影，如果场景需要实时阴影，建议启用，确保剔除物体显示正常的阴影。

## Occlusion Culling

### 即时遮挡剔除

* 即使遮挡剔除 Instant Occlusion Culling
* 遮挡剔除 ： 当物体被送到渲染流水线之前，将摄像机视角内看不到的物体进行剔除，从而减少了每帧渲染数据量，提高渲染性能。

## LOD

### 多细节层次

* 多细节层次 Levels of Detail

  LOD技术指根据物体模型的节点在显示环境中所处的位置和重要程度，决定物体渲染的资源分配，降低非重要物体的面数和细节度，从而获得高效率的渲染运算。(根据距离进行资源渲染分配)  

## 光照系统

### Global Illumination

* 简称GI，即全局光照
* 能够计算直接光、间接光、环境光一级反射光的光照系统。
* 通过GI算法可以使渲染出来的光照效果更为真实丰富。

###  直接光照

* 从光源直接发出的光，通过Light组件实现。
* Type类型:灯光对象的当前类型
  * Directional Light平行光:平行发射光线,可以照射场
    景里所有物体,用于模拟太阳。
  * Point Light点光源:在灯光位置上向四周发射光线,可
    以照射其范围内的所有对象,用于模拟灯泡。
  * Spot Light聚光灯:在灯光位置上向圆锥区域内发射光
    线,只有在这个区域内的物体才会受到光线照射,用于模拟探
    照灯。
  * Area Light区域光:由一个面向一个方向发射光线,只
    照射该区域内物体,仅烘焙时有效，用在光线较为集中的区域。
  * Range范围:光从物体的中心发射的范围。仅适用于点光
    源和聚光灯。
  * Spot Angle聚光角度:灯光的聚光角度。只适用于聚光灯。
  * Color颜色:光线的颜色。
  * Intensity强度:光线的明亮程度。
  * Culling Mask选择遮蔽层:选择要照射的层Layer。

### 间接光照

* 物体表面在接受光照后反射出来的光。
* 通过Light组件中Bounce Intensity反弹强度控制。
* 可以通过Scene面板Irradiance模式查看间接光照。
* 注意:
  只有标记Lightmaping Static的物体才能产生间接反弹光照。

### 环境光照

* 作用于场景内所有物体的光照,通过Environment Lighting
  中Ambient控制。
* Ambient Source环境光源
  * Skybox通过天空盒颜色设置环境光照
  * Gradient梯度颜色
    Sky天空颜色、Equator 地平线颜色、Ground 地面颜色
  * Ambient Color纯色
  * Ambient Intensity环境光强度
  * Ambient GI环境光GI模式
    * Realtime实时更新，环境光源会改变选择此项。
    * Backed烘焙,环境光源不会改变选择此项。

### 反射光照

* 根据天空盒或立方体贴图计算的作用于所有物体的反射效
  果，通过Environment Lighting中Reflection控制。
* Reflection Source反射源
  * Skybox 天空盒
* Resolution分辨率Compression 是否压缩
  * Custom自定义
* Cubemap立方体贴图
* Reflection Intensity反射强度
* Reflection Bounces使用Reflection Probe后允许不同游
  戏对象间来回反弹的次数。

## 实时GI

### Realtime GI

* 所谓"实时"是指在运行期间任意修改光源,而所有的变化可
  以立即更新。
* 正是由于Unity 5引入了行业领先的实时全局光照技术
  Enlighten系统,才可以在运行时产生间接光照,使场景更
  为真实丰富。
  操作步骤:
  1. 游戏对象设置为Lightmaping Static
  2. 启用Lighting面板的Precomputed Realtime GI
  3. 点击Build按钮(如果勾选Auto编辑器会自动检测场景的改动修复光照效果)

## 烘焙GI

### 烘焙Lightmap

* 当场景包含大量物体时,实时光照和阴影对游戏性能有很大影响。
  使用烘焙技术,可以将光线效果预渲染成贴图再
  作用到物体上模拟光影,从而提高性能。适用于在性能较
  低的设备上运行的程序。
* Light 组件 Baking属性:烘培模式Realtime仅实时光照时起作用。
*  -Realtime 仅实时光照时起作用。
   -Baked仅烘焙时起作用。
   -Mixed 混合,烘焙与实时光照都起作用。
*  可以通过Scene面板Baked模式查看光照贴图。

## 声音

### 简介

* Unity支持的音频文件格式：

  mp3，ogg，wav，aif，mod，it，s3m，xm。

* 声音分为2D、3D两类

  3D声音 : 有空间感，近大远小。

  2D声音：适合背景音乐。

* 在场景中产生声音，主要依靠两个重要组件；

  Audio Listener音频监听器 ： 接收场景中音频源Audio

* Source发出的声音，通过计算机的扬声器播放声音

  Audio Source 音频源

### Audio Source

* 音频源 ：
  * Audio Clip 音频剪辑 ： 需要播放的音频资源。
  * Mute 静音 ： 如果启用，播放音频没有声音
  * Play On Awake 唤醒播放 ： 勾选后场景启动时自动播放。
  * Loop 循环 ： 循环播放音频
  * Volume 音量 ： 音量大小
  * Pitch 音调 ： 通过改变音调值调节音频播放速度。1是正常播放。
  * Stereo Pan ： 2D声音设置左右声道
  * Spatial Blend ： 2D与3D声音切换

### 3D Sound Settings

* 3D声音设置
  * Volume Rolloff 音量衰减方法
  * Min Distance 开始缩减距离
  * Max Distance 开始缩减距离
