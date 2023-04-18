---
title: js懒加载
date: 2022-08-26 10:16:28.0
categories: 
- WebFrontend
tags: 
- javascript
---

## 什么是懒加载

图片懒加载就是延迟加载，因为浏览器可视范围是有限的，所以网页的内容都是需要进行滚动才能完成浏览，既然要滚动到网页下面才能浏览到看不见的图片。

第一个方法：事件监听

监听scroll这个事件，鼠标滚动就触发，因此我们需要知道两个参数。首先是窗口显示区的高度`window.innerHeight`,以及图片到视窗上边的距离（高度）`getBoundingClientRect().top`。

![image-20220826223317761](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220826223317761.png)

如果图片还未能看见，也就是说图片距离视窗的距离大于窗口显示区的高度。

如果图片能看见，也就是说图片距离视窗的距离小于窗口显示区的高度。

## 代码实现

~~~html
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title>未遭拒绝的成功决不会长久。</title>
	</head>
	<body>
		<p>把脾气拿出来，那叫本能；把脾气压回去，才叫本事。</p>
		<p>人只要不失去方向，就不会失去自我。</p>
		<p>人们痛恨的不是改变，而是被改变。</p>
		<p>昨日的成功经验与辉煌可能是明天成功的阻碍。</p>
		<p>对于幸运者来说，一生都是短暂的；对于不幸者来说，一夜都是漫长的。</p>
		<p>不要着急，不要害怕，一步一个脚印，踩出自我的阳关大道。</p>
		<p>你说那里有你的梦想，你说只要你足够努力就能成功。</p>
		<p>只要是辛勤的蜜蜂，在生活的广阔原野里，到处都能够找到蜜源。</p>
		<p>拼命去争取成功，但不要期望一定会成功。</p>
		<p>这个社会，是赢家通吃，输者一无所有，社会，永远都是只以成败论英雄。</p>
		<p>生命的多少用时间计算，生命的价值用贡献计算。</p>
		<p>愿我们每个人都能深谙其道，也但愿我们每个人有时也都能忍耐一下。</p>
		<p>把脾气拿出来，那叫本能；把脾气压回去，才叫本事。</p>
		<p>人只要不失去方向，就不会失去自我。</p>
		<p>人们痛恨的不是改变，而是被改变。</p>
		<p>昨日的成功经验与辉煌可能是明天成功的阻碍。</p>
		<p>对于幸运者来说，一生都是短暂的；对于不幸者来说，一夜都是漫长的。</p>
		<p>不要着急，不要害怕，一步一个脚印，踩出自我的阳关大道。</p>
		<p>你说那里有你的梦想，你说只要你足够努力就能成功。</p>
		<p>只要是辛勤的蜜蜂，在生活的广阔原野里，到处都能够找到蜜源。</p>
		<p>拼命去争取成功，但不要期望一定会成功。</p>
		<p>这个社会，是赢家通吃，输者一无所有，社会，永远都是只以成败论英雄。</p>
		<p>生命的多少用时间计算，生命的价值用贡献计算。</p>
		<p>愿我们每个人都能深谙其道，也但愿我们每个人有时也都能忍耐一下。</p>
		<p>把脾气拿出来，那叫本能；把脾气压回去，才叫本事。</p>
		<p>人只要不失去方向，就不会失去自我。</p>
		<p>人们痛恨的不是改变，而是被改变。</p>
		<p>昨日的成功经验与辉煌可能是明天成功的阻碍。</p>
		<p>对于幸运者来说，一生都是短暂的；对于不幸者来说，一夜都是漫长的。</p>
		<p>不要着急，不要害怕，一步一个脚印，踩出自我的阳关大道。</p>
		<p>你说那里有你的梦想，你说只要你足够努力就能成功。</p>
		<p>只要是辛勤的蜜蜂，在生活的广阔原野里，到处都能够找到蜜源。</p>
		<p>拼命去争取成功，但不要期望一定会成功。</p>
		<p>这个社会，是赢家通吃，输者一无所有，社会，永远都是只以成败论英雄。</p>
		<p>生命的多少用时间计算，生命的价值用贡献计算。</p>
		<p>愿我们每个人都能深谙其道，也但愿我们每个人有时也都能忍耐一下。</p>
		<img data-src="img/1.webp" />
		<br />
		<img data-src="img/2.webp" />
		<br />
		<img data-src="img/3.webp" />
		<script>
			const images = document.querySelectorAll('img'); //获取所有image标签
			window.addEventListener('scroll', (e) => { //滚动事件
				//判断每张图片的位置是否出现在可视区域，使用forEach来进行遍历
				images.forEach(image => {
					//每次遍历的时候我们都获取每张图片到顶部的距离,并且进行if判断
					const imageTop = image.getBoundingClientRect().top;
					//如果图片距离视窗顶部的距离小于窗口显示区的高度，使得图片可以进行加载
					if(imageTop < window.innerHeight){
						//html部分：如果用户没滚到指定的位置，我们需要不加载图片，简单的方式使用自定义属性，使用data-*来进行表示
						//html部分：因此我们可以把src属性改为data-src，这样就相当于不知道要在哪里下载这些图片了
						const data_src = image.getAttribute('data-src')//获取刚刚自定义属性
						//然后把这个自定义属性赋值给原本的src属性
						image.setAttribute('src', data_src);
					};
					console.log('scroll触发');
				});
			});
		</script>
	</body>
</html>
~~~

我们打开控制台的Network选项，并勾选disable cache，也就是禁止缓存，然后是Fast 3G，也就是比较慢的网络环境来测试恶略的网络环境

![image-20220826233439021](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220826233439021.png)

现在我们看到加载内容里面没有图片，因为图片还没有出现在可视范围，当我们滚到图片区域，可以看到图片开始进行在加载了，也基本实现了懒加载的功能

![image-20220826233649891](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220826233649891.png)

虽然实现了懒加载，但是从控制台查看发现滚动事件触发了相当多次，页面加载很多内容就会导致任务的堆积，即使图片已经加载了还是会不断触发事件，非常消耗资源。因此目前最推荐使用的方法还是IntersectionObservers。

什么是IntersectionObservers？

IntersectionObservers（交叉观察）也就是目标元素和可视化窗口会产生交叉区域。IntersectionObservers是浏览器提供的构造函数，我们可以直接拿来使用（部分浏览器不兼容）。

既然是构造函数，所以需要new一个实例，我们可以用observer来表示实例，observer实例可以理解为一个用于观察的实例

~~~js
const observer = new IntersectionObservers
~~~

比如把observer实例想象为一个拿着望远镜的人，当这个人拿起望远镜就是进行观察。拿起望远镜就是使用了观察这个动作，也可以说是方法。我们就用observer.observe(DOM节点)来表示，具体要观察哪个DOM节点就在括号里面填写就行了。

当我们不用望远镜观察的时候，也就是一个取消的动作，一个取消的方法，就用observer.unobserve(DOM节点)来表示,这样我们就不用进行不断观察，因为图片已经被加载出来就没有必要观察了，实例可以进行开始和结束观察DOM节点,但是我们在观察到目标DOM节点的时候需要进行相应的动作，一般来说我们就需要函数来封装这些动作。

![image-20220827000108608](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220827000108608.png)

为此IntersectionObservers接收两个参数；第一个参数是一个回调函数，既然是回调函数就需要触发条件然后来执行的，这个回调函数一般触发两次，目标元素能看见触发一次，看不见又触发一次，有了这些基本概念就可以进行代码操作了；

~~~js
const images = document.querySelectorAll('img'); //获取所有image标签
			const callback = () => {
				console.log('看见了触发，看不见了再触发')
			};
			//使用IntersectionObserver来创建一个实例，并且传入参数callback
			const observer = new IntersectionObserver(callback);
			images.forEach(image =>{
				//使用forEach进行遍历,在每次循环的时候使用observer实例的observe方法来观察每一个img节点
				observer.observe(image);
			} );
~~~

现在我们在控制台试着上下滚动，因为没设置显示图片但是预留了图片的区域，每次进入或者离开图片区域都会触发这个回调函数。

~~~js
const images = document.querySelectorAll('img'); //获取所有image标签
const callback = entries => {
	console.log(entries)
};
~~~

回调函是接收一个参数的，这个参数是一个数组。我们用entries来表示这个数组，并且在控制台输出entries，因为有三张图片，所以数组的长度为3；

![image-20220827001823181](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220827001823181.png)

既然是数组我们依旧需要进行遍历，使用forEach来进行遍历，并且输出每一次触发的细节。

~~~js
const callback = entries => {
    entries.forEach(entry => {
        console.log(entry);
    });
};
~~~

![image-20220827002312091](https://cdn.jsdelivr.net/gh/WRXinYue/PictureCDN/img/image-20220827002312091.png)

这一次我们重点看一看数组里面的isIntersecting属性，从字面意思来看就是”是否交叉“，也就是是否进行到可视区域。还没滚动之前是false，滚动到图片区域isIntersecting属性就变成了true，有这个元素我们就可以判断该次触发回调函数时是否已经观察到了图片，从中可以看到控制台每次触发了三次回调函数。

可以使用target属性查看目标元素

https://www.bilibili.com/video/BV1FU4y157Li?spm_id_from=333.337.search-card.all.click&vd_source=1272b02e7a60d7fb8d81dfcdf529184e
