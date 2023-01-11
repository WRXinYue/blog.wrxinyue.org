## P1玩家输入模块
~~~c#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    // Varible
    public string keyUP = "w";
    public string keyDown = "s";
    public string keyLeft = "a";
    public string keyRight = "d"; //按下ctrl和鼠标左键能实现多行写入代码

    public float Dup;
    public float Dright;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Dup = (Input.GetKey(keyUP)?1.0f:0) - (Input.GetKey(keyDown)?1.0f:0);
        Dright = (Input.GetKey(keyRight)?1.0f:0 - (Input.GetKey(keyLeft)?1.0f:0));
    }
}

~~~

## P2输入衰减与使能旗标



## 更改材质密度大小

![image-20220702095845832](C:\Users\33225\AppData\Roaming\Typora\typora-user-images\image-20220702095845832.png)

## scene 中的gizmos设置

<img src="C:\Users\33225\AppData\Roaming\Typora\typora-user-images\image-20220702100025351.png" alt="image-20220702100025351"  />

3d lcons 调整场景图标大小

selection Qutline 取消显示模型外边框

### 移动两种形式

~~~c#
rb.position += vector3 * Time.fixedDeltaTime;
rb.velocity = new Vector3(vector3.x, 0, vector3.z);//XXXX
rb.velocity = new Vector3(vector3.x, rb.velocity.y, vector3.z);
~~~



### Inspector面板显示文字

~~~c#
[Header("===== key settings =====")]
~~~

![image-20220703191926312](C:\Users\33225\AppData\Roaming\Typora\typora-user-images\image-20220703191926312.png)

## 解决Trigge触发两次的bug

![image-20220704103357100](C:\Users\33225\AppData\Roaming\Typora\typora-user-images\image-20220704103357100.png)

在ground新建一个FAM Clear Signals脚本文件

![image-20220704104308207](C:\Users\33225\AppData\Roaming\Typora\typora-user-images\image-20220704104308207.png)

![image-20220704104250308](C:\Users\33225\AppData\Roaming\Typora\typora-user-images\image-20220704104250308.png)



## 速度曲线

![image-20220705154848720](C:\Users\33225\AppData\Roaming\Typora\typora-user-images\image-20220705154848720.png)

### 动画层级 Animator-Layers

新建AvatarMask文件夹，在里面放置人物的Avatar Mask

Larers层级权重

~~~c#
    public void OnAttack1hAEnter()
    {
        anim.SetLayerWeight(1, 1.0f);
    }
    public void OnAttackIdle()
    {
        anim.SetLayerWeight(1, 0);
~~~

