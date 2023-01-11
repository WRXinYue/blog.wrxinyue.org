## Unity动画系统

* 动画片段 Animation Clips

​		动画片段是对物体变化情况的一种展示

​		动画片段可以由外部导入（导入教程https://www.bilibili.com/video/BV1y44y147e7/?spm_id_from=pageDriver&vd_source=1272b02e7a60d7fb8d81dfcdf529184e），也可以在unity中制作

* 动画状态机 Animator Controller

​		在为某个游戏对象，比如玩家角色准备好动画片段之后，就可以放入动画状态机进行管理

​		动画状态机会帮助我们跟踪当前动画的播放状态，并且根据我们的设置决定何时以及如何切换动画片段

* 动画组件 Animator Component（状态机）

​		animator contarller 其实是unity动画状态机的一种图形化交互页面

![image-20220622113806977](C:\Users\33225\AppData\Roaming\Typora\typora-user-images\image-20220622113806977.png)

​		layer一般用于组合动画，比如当你需要角色身体不同部分播放不同的动画片段时会使用到这里的功能

parameters是用来控制动画状态的参数

* 替身 Avatar （人型动画）

  人型动画骨骼标准，所有按照同一标准配置好的人形角色都可以播放同一套动画

  如果我们要播放的是使用了avatar系统的人形动画，那么我们就在这里放上对应的avatar

  如果我们没有使用avatar，那么animator组件会严格按照动画片段里记录的path，去寻找对应的游戏对象并播放动画。

