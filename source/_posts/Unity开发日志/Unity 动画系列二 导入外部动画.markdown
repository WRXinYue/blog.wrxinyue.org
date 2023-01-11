原文：[Unity 动画系列二 导入外部动画 - 简书 (jianshu.com)](https://www.jianshu.com/p/d57628df2793)

# 动画模型

常见游戏动画一般分为两种：

* in place 动画（不带位的移动画）
* root motion动画（自带“跟位移”的动画）

好处：有效地避免了动画动画和实际位移不同步的现象



在Unity中只能制作比较简单的动画，要想要复杂的动画，比如人物跳舞的动画，那就得在外部的软件中制作并且导入到Unity中使用，那这个过程是什么呢？



##  Model页签

 ### 1.Scene部分

![img](https://upload-images.jianshu.io/upload_images/2354823-9e6fd82d9da77772.png?imageMogr2/auto-orient/strip|imageView2/2/w/267/format/webp)

- Scale Factor：调整模型在场景中的比例。   

> Unity3D中默认 1单位距离 = 1米。由于Maya中默认设置为 1单位距离 = 1厘米，所以Maya模型导出成.fbx以后再导入Unity3D，要设置scale为0.01，否则就会变得超级大。

- Convert Units：可以将模型中定义的单位转换为Unity中的单位。

- Import BlendShapes：导入Mesh上的BlendShapes。对于一些细微的表情等动作，使用骨骼有点过于复杂和浪费，可以预先设计几张表情，然后通过BlendShape来进行表情的过渡。

- Import Visibility：导入可见属性用以保证可以读取FBX中的可见属性来禁用或启用unity中的MeshRender组件去渲染物体。模型动画如果涉及了模型可见属性的改变则需要勾选，来保证unity正常读取可见属性。

- Import Cameras/Import Lights：是否导入摄像机/灯光。unity可以直接导入Fbx上的相机和灯光的参数。不推荐从3dMax中导入摄像机与灯光，而使用unity中创建的摄像机，灯光，来完成渲染。

- Preserve Hierarchy：如果不勾选，则unity会自行剔除模型中的所有空节点，对于那些只包含空节点用以表现模型动画的FBX文件来说，这会导致动画Rig不匹配。如果勾选，即使只有Root节点unity也会创建一个显示的预制根节点作为父物体。

  ![img](https:////upload-images.jianshu.io/upload_images/2354823-9d3ace40b0f7b550.png?imageMogr2/auto-orient/strip|imageView2/2/w/720/format/webp)

  勾选后unity为FBX中的模型创建了预制父物体，并自行添加了一个Animation组件用以记录模型动画，因为大多数情况勾选Preserve Hierarchy意味着这是一个只含动画的FBX模型


>并且我们发现3dMax中导出时的自动轴转转化设置在勾选了之后Preserve Hierarchy才会生效，但我们更推荐按3中提到的，来手动设置出合适轴向，**一般我们保持这一项不勾选**，所以导出时也不必在意是否勾选了自动轴转化，而使用我们手动旋转好的轴向。

  ### 2.Meshes

![img](https://upload-images.jianshu.io/upload_images/2354823-04d1230b09632592.png?imageMogr2/auto-orient/strip|imageView2/2/w/290/format/webp)

* MeshCompression:网格压缩，不建议开启。
* Read/Write Enabled：开启Read/Write Enabled一般是用于运行时修改Mesh的顶点数据，开启这个选项会导致Mesh的内存占用翻倍。**因此如果项目中不需要在运行时修改这些Mesh数据的话，我们建议把这个选项关闭。**
* Optimize Mesh:优化网格，如果开启，网格的定点和三角形会按照U3D既定的一套规则重新排序用以提高GPU性能。**看样子可以开启**
* Generate Collider 如果开启时，Mesh导入时会自动生成MeshCollider，这个比较适合环境中静态的物体，不适合那些有动作形变的物体。**人物模型不适合开启，建筑模型合适。**

### 3.Geometry

![img](https://upload-images.jianshu.io/upload_images/2354823-bcd817fbc9a15e5b.png?imageMogr2/auto-orient/strip|imageView2/2/w/284/format/webp)

- KeepQuads 保持四边形，不转换为三角形。我们在U3D中使用的网格，大部分是把所有的面都转换成了三角形，但是某些特定的需求下，四边形会得到更好的效果，例如Tessellation shaders（细分曲面着色器）。
- Weld Vertices 顶点焊接，合并处于同一位置的顶点，这样可以整体减少mesh的顶点数。通过顶点焊接可以优化顶点数量，获得更好的渲染性能。但如果需要脚本中动态控制网格，模型故意设有位置相同的顶点时应取消勾选
- Index Format unity在导入网格时使用的索引表示长度。通常Auto，在使用基于GPU的渲染管线编程时，通常使用32位。Auto时将取决于网格的大小；16bit时若网格顶点较多将进行顶点分块，分块后每个顶点块<64k个顶点，这是unity 2017.2或之前版本的设置；32bit时可确保所有网格使用相同的索引格式，这可以降低着色器顶点处理的复杂性。
- Swap uvs  这个选项只能交换第一套和第二套uv，如果导入的模型uv混乱可以试着勾选一下，如果fbx上有更多套uv，可能得通过代码来控制了。
- Generate LightMap Uvs 为模型展开一道UV以接受unity中的光照烘焙（非实时的渲染光照）效果，从而将烘焙光照以光照贴图的形式表现在模型表面。注意！！！场景中的静态物体模型，需要接受Unity光照烘焙的物体模型，一定要进行这个UV展开
- Normals：法线定义
  - Import：从模型中导入法线，如果模型不包含法线则会计算法线，这是默认选项
  - Caculate：根据 Normals Mode、Smoothness Source 和 Smoothing Angle属性来计算法线。
  - None:如果网格不需要法线贴图，也不受实时光照影响（各光照模型的计算都需要法线数据）应选择此项

> 导入模型时，可以选择直接导入模型中的法线和切线、也可以选择使用unity自动计算法线和切线、也可以不导入法线和切线。具体的参数，不太懂，如果美术资源提供了法线和切线、直接import就行了。

## Rig页签

![img](https://upload-images.jianshu.io/upload_images/2354823-bba4dff27b85f444.png?imageMogr2/auto-orient/strip|imageView2/2/w/394/format/webp)

### 1.Animation Tyoe

* None不导入动画。

* Legacy是4.0版本以前的动画系统，是比较老比较保险的动画系统，提供的功能比较少，但是也不会出什么错误，适合非常简单的游戏。**为了兼容Unity3.x旧版本，不建议使用**

* Generic和Humanoid是在4.0版本时同时推出的两套动画系统，他们有很多共性，比如都有自带的状态机、自带动画融合、自带Avatar等。**比较大的区别就是Humanoid这个动画系统是专门用来做类人型两足生物的，它提供了动画的重定向，就是说它提供了一套动画赋予给多个体型不同的模型的解决方案。**

### 2.Avatar Definition

![img](https://upload-images.jianshu.io/upload_images/2354823-194b1ae574dea319.png?imageMogr2/auto-orient/strip|imageView2/2/w/371/format/webp)

![img](https://upload-images.jianshu.io/upload_images/2354823-0a4a87645b2349c5.png?imageMogr2/auto-orient/strip|imageView2/2/w/251/format/webp)

**Avatar替身是unity为管理骨骼动画所创建的一种保持节点信息的文件**，通过在Animator中指定所需要用到的Avatar,Animator动画状态机在运行时就能根据Avatai中提供的节点信息，寻找子物体中的对应节点并对其赋予动画的控制，完成骨骼动画与含骨骼绑定的模型的适配。

这里的替身来源主要有两个，

- 从该模型创建出一个Avatar替身
- 使用其他模型配置好的Avatar替身

创建出的Avatat替身文件，尤其是人形骨骼的Avatar替身需要进行配置工作，绑定骨骼，设置初始T-Pos，通过复用其他模型创建好的Avatar替身可以减少繁杂的配置操作，尤其是我们导入只包含骨骼动画的FBX时，复用角色模型的Avatar替身就可以快速完成骨骼动画于人物模型的适配。



## Format格式

通用保存FBX格式

### Skin

下载模型的外观，还仅仅是动画

### Frames per Second动画的帧率

### Keyframe Reduction帧压缩

### Pose

下载模型