## Updata 和 FixedUpdata

rigbody组件不能写在Update函数里，要写在FixedUpdata里面

* Update()：每帧被调用一次
* FixedUpdate()：每隔Time.fixedDeltaTime被调用一次。
* MonoBehaviour.LateUpdate  晚于更新   当Behaviour启用时，其LateUpdate在每一帧被调用。
  LateUpdate是在所有Update函数调用后被调用。这可用于调整脚本执行顺序。例如:当物体在Update里移动时，跟随物体的相机可以在LateUpdate里实现。

### Update 和 FixedUpdate 区别

update跟当前平台的帧数有关，而FixedUpdate是真实时间，所以处理物理逻辑的时候要把代码放在FixedUpdate而不是Update.

​     Update是在每次渲染新的一帧的时候才会调用，也就是说，这个函数的更新频率和设备的性能有关以及被渲染的物体（可以认为是三角形的数量）。在性能好的机器上可能fps 30，差的可能小些。这会导致同一个游戏在不同的机器上效果不一致，有的快有的慢。因为Update的执行间隔不一样了。

​     而FixedUpdate，是在固定的时间间隔执行，不受游戏帧率的影响。有点想Tick。所以处理Rigidbody的时候最好用FixedUpdate。

​     PS：Time.fixedDeltaTime默认是0.02s，可以通过Edit->ProjectSettings->Time来设置

###  Update和 LateUpdate的区别

​     在圣典里LateUpdate被解释成一句话：LateUpdate是在所有Update函数调用后被调用。这可用于调整脚本执行顺序。例如:当物体在Update里移动时，跟随物体的相机可以在LateUpdate里实现。这句我看了云里雾里的，后来看了别人的解释才明白过来。

​     LateUpdate是晚于所有Update执行的。例如：游戏中有2个脚步，脚步1含有Update和LateUpdate，脚步2含有Update，那么当游戏执行时，每一帧都是把2个脚步中的Update执行完后才执行LateUpdate 。虽然是在同一帧中执行的，但是Update会先执行，LateUpdate会晚执行。

​     现在假设有2个不同的脚本同时在Update中控制一个物体，那么当其中一个脚本改变物体方位、旋转或者其他参数时，另一个脚步也在改变这些东西，那么这个物体的方位、旋转就会出现一定的反复。如果还有个物体在Update中跟随这个物体移动、旋转的话，那跟随的物体就会出现抖动。 如果是在LateUpdate中跟随的话就会只跟随所有Update执行完后的最后位置、旋转，这样就防止了抖动。

​     做一个相机跟随主角的功能时，相机的位置调整写在LateUpdate（），老是不明白，看官方的SmoothFollow相机跟随写在Update（）中

 **资料参考链接：**[**http://www.cnblogs.com/zhaoqingqing/p/3454091.html**](http://www.cnblogs.com/zhaoqingqing/p/3454091.html)

​                       [**http://www.cnblogs.com/zhaoqingqing/p/3296086.html**](http://www.cnblogs.com/zhaoqingqing/p/3296086.html)