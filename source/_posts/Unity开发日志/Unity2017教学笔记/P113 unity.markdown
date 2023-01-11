## 脚本介绍

### 脚本

* 脚本是附加在游戏体上用于定义游戏对象行为的指令代码。

* Unity支持三种高级编程语言 ：

  C#、JavaScript和Bool Script

### 语法结构

~~~c#
using 命名空间；
public class 类名 ： MonoBehaviour
{
    void 方法名()
    {
		Debug.Log("调试显示信息")
        prit("本质就是Debug.Log方法")
    }
}
~~~

* 文件名与类名必须一致
* 写好的脚本必须附加到物体上才执行
* 附加到游戏物体的脚本类必须从MonoBehaviour类继承



### 编译过程

* 编译运行过程：

  源代码--（CLS）->中间语言--(Mono Runtime)->机械码

## 开发工具

### MonoDevelop

* Unity 自带脚本编辑器，创建Mono应用程序，适用于Linux、Mac OS X和windows的继承开发环境，支援C#、BOO 和JavaScript等高级编程语言。

### Visual Studio

* 微软公司的开发工具包，包括了整个软件生命周期中需要的大部分工具，如团队开发工具、集成开发环境等等。
* 在unity中通过菜单设置修改默认的脚本编辑器：
* Edit-Preferences-External Tools-External Script Editor

## 脚本生命周期

### 简介

* Unity 脚本从唤醒到销毁的过程。
* 必然事件。
* 消息：当满足某种条件 Unity 引擎自动调用函数。

### 初始阶段

* Awake 唤醒：

  当物体才入时立即调用1次 ； 常用于在游戏开始前进行初始化，可以判断当满足某种条件执行此脚本 this.enable=true。

* OnEnable 当可用 ：

  每当脚本对象启用时调用。
  
* Start 开始 ：
  
  物体载入且脚本对象启用时被调用1次。常用于数据或游戏逻辑初始化，执行时机晚于Awake。

### 物理阶段

* FixedUpdate 固定更新 ：

  脚本启用后，固定时间被调用，适用于对游戏对象做物理操作，例如移动等。

* OnCollisionXXX 碰撞：

  当满足碰撞条件时调用。

* OnTriggerXXX 触发 ：

  当满足触发条件时调用。

~~~c#
//****************物理阶段*****************************
//执行时机 ： 每隔固定时间执行一次（时间可以修改）
//适用性 ： 适合对物体做物理操作（移动、旋转.....），不会受到渲染影响

private void FixedUpdate()
{//渲染时间不固定（每帧渲染量、机器性能不同）
	Debug.Log(Time.time);
}

//执行时机 ： 渲染帧执行 ，执行间隔不固定
//适用性 ： 处理游戏逻辑
private void Update()
{
    
}
~~~

### 游戏逻辑

* Update 更新 :

​		脚本启用后每次渲染场景时调用，频率与设备性能及渲染量有关。

* LateUpdate 延迟更新：

​		在UPdate 函数被调用后执行，用于跟随逻辑。

### 输入事件

* OnMouseEnter鼠标移入 ：

  鼠标移入当前Collider时调用。
  
* OnMouseOver 鼠标经过：

  鼠标经过当前 Collider时调用。

* OnMouseExit 鼠标离开：

  鼠标离开当前 Collider 时调用。

* OnMouseDown鼠标按下：

  鼠标按下当前Collider时调用。

* OnMouseUp鼠标抬起：

  鼠标在当前Collider上抬起时调用

### 场景渲染

* OnBecameVisible 当可见

  当 Mesh Renderer 在任何相机上可见时调用。

* OnBecameInvisible 当不可见：

  当Mesh Renderer 在任何相机上都不可见时调用。

### 结束阶段

* OnDisable当不可用

  对象变为不可用或附属游戏对象非激活状态时此函数被调用。

* OnDestroy当销毁：

  当脚本销毁或附属的游戏游戏对象被销毁时被调用。

* OnApplicationQuit 当程序结束 ：

  应用程序退出时被调用。

 ## 常用API

Component

Transform

GameObject

Object

Time

