## 创建渲染管线
创建渲染管线的Pipeline Assset

![image-20220608155900608](C:\Users\33225\AppData\Roaming\Typora\typora-user-images\image-20220608155900608.png)

## 渲染管线的设置

![image-20220608160151003](C:\Users\33225\AppData\Roaming\Typora\typora-user-images\image-20220608160151003.png)



![image-20220608160215692](C:\Users\33225\AppData\Roaming\Typora\typora-user-images\image-20220608160215692.png)

![image-20220608160452830](C:\Users\33225\AppData\Roaming\Typora\typora-user-images\image-20220608160452830.png)

## 升级到URP

![image-20220608162109912](C:\Users\33225\AppData\Roaming\Typora\typora-user-images\image-20220608162109912.png)

![image-20220608162223480](C:\Users\33225\AppData\Roaming\Typora\typora-user-images\image-20220608162223480.png)

1.将整个project的materials都升级到URP
2.将当前材质材质升级到URP



## 地编工具

![image-20220609130040908](C:\Users\33225\AppData\Roaming\Typora\typora-user-images\image-20220609130040908.png)

![image-20220609134650349](C:\Users\33225\AppData\Roaming\Typora\typora-user-images\image-20220609134650349.png)

Use Pivot 防止浮空



#### 泛型的单例模式

 ~~~c#
 public static MouseManager Instance;   
 private void Awake()
     {
         if (Instance != null)
             Destroy(gameObject);
 
         Instance = this;
     }
 ~~~

