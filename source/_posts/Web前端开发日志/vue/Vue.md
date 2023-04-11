### 双向数据绑定

简单的双向数据绑定： 

~~~vue
<div id="app">
    <input type="text" v-model="school.name">
    <div>{{school.name}}</div>
    <div>{{school.age}}</div>
</div>
<script src="./node_modules/vue/dist/vue.js"></script>
<script>
	let vm = new Vue({
        el:"#app",
        data:{
            school:{
                name: '张三',
                age: 3
            }
        }
    })
</script>
~~~

![GIF 2-18-2023 10-09-29 PM](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/GIF%202-18-2023%2010-09-29%20PM.gif)

拿到El当前模板,获取文本节点：

~~~html
<body>
  <div id="app">
    <input type="text" v-model="school.name">
    <div>{{school.name}}</div>
    <div>{{school.age}}</div>
  </div>
</body>
<script src="MVVM.js"></script>
<script>
	let vm = new Vue({
        el:"#app",
        data:{
            school:{
                name: '张三',
                age: 3
            }
        }
    })
</script>
~~~

```js
//基类 调度
class Compiler {
    constructor(el, vm) {
        // 判断el属性 是不是一个元素 如果不是元素 那就获取
        this.el = this.isElementNode(el)?el:document.querySelector(el);
        // 把当前节点中的元素获取到内存中
    }
    isElementNode(node) {
        return node.nodeType === 1;
    }
}
class Vue {
    constructor(options) {
        // this.$el $data $options
        this.$el = options.el;
        this.$data = options.data;
        // 这个根元素如果存在 就编译模板
        if(this.$el) {
            new Compiler(this.$el, this);
        }
    }
}
```

![image-20230219115734467](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230219115734467.png)

获取节点到内存中,渲染模板进行替换

~~~js
//基类 调度
class Compiler {
    constructor(el, vm) {
        // 判断el属性 是不是一个元素 如果不是元素 那就获取
        this.el = this.isElementNode(el)?el:document.querySelector(el);
        
        // 把当前节点的元素 获取到 内存中
        let fragment = this.node2fragment(this.el);

        // 把节点中的内容进行替换

        // 编译模板 用数据编译
        
        // 把内容塞到页面中
        this.el.appendChild(fragment);
    }
    //  把节点移动到哦内存中
    node2fragment(node) {
        // 创建一个文档碎片
        let fragment = document.createDocumentFragment();
        let firstChild;
        while(firstChild = node.firstChild) {
            // appendChild具有移动性
            fragment.appendChild(firstChild);
        }
        return fragment
    }
    isElementNode(node) {
        return node.nodeType === 1;
    }
}
class Vue {
    constructor(options) {
        // this.$el $data $options
        this.$el = options.el;
        this.$data = options.data;
        // 这个根元素如果存在 就编译模板
        if(this.$el) {
            new Compiler(this.$el, this);
        }
    }
}
~~~

![image-20230219121041390](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230219121041390.png)

![image-20230219121519435](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230219121519435.png)

编译内存dom节点

~~~js
//基类 调度
class Compiler {
    constructor(el, vm) {
        // 判断el属性 是不是一个元素 如果不是元素 那就获取
        this.el = this.isElementNode(el)?el:document.querySelector(el);
        
        // 把当前节点的元素 获取到 内存中
        this.vm = vm;
        let fragment = this.node2fragment(this.el);

        // 把节点中的内容进行替换

        // 编译模板 用数据编译
        this.compile(fragment);

        // 把内容塞到页面中
        this.el.appendChild(fragment);
    }
    //  编译内存中的dom节点
    compile(node) {
        let childNodes = node.childNodes;
        console.log(childNodes);
    }
    //  把节点移动到哦内存中
    node2fragment(node) {
        // 创建一个文档碎片
        let fragment = document.createDocumentFragment();
        let firstChild;
        while(firstChild = node.firstChild) {
            // appendChild具有移动性
            fragment.appendChild(firstChild);
        }
        return fragment
    }
    isElementNode(node) {
        return node.nodeType === 1;
    }
}
class Vue {
    constructor(options) {
        // this.$el $data $options
        this.$el = options.el;
        this.$data = options.data;
        // 这个根元素如果存在 就编译模板
        if(this.$el) {
            new Compiler(this.$el, this);
        }
    }
}
~~~

![image-20230219122809452](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230219122809452.png)

深度遍历子节点

~~~js
//基类 调度
class Compiler {
    constructor(el, vm) {
        // 判断el属性 是不是一个元素 如果不是元素 那就获取
        this.el = this.isElementNode(el)?el:document.querySelector(el);
        
        // 把当前节点的元素 获取到 内存中
        this.vm = vm;
        let fragment = this.node2fragment(this.el);

        // 把节点中的内容进行替换

        // 编译模板 用数据编译
        this.compile(fragment);

        // 把内容塞到页面中
        this.el.appendChild(fragment);
    }
    //  编译内存中的dom节点
    compile(node) {
        let childNodes = node.childNodes;
        //[...childNodes] 相当于 Array.from(childNodes)
        [...childNodes].forEach(child=> {
            //判断当前节点是否未元素
            if(this.isElementNode(child)) {
                console.log('element', child)
            }else {
                console.log('text', child)
            }
        });
    }
    //  把节点移动到哦内存中
    node2fragment(node) {
        // 创建一个文档碎片
        let fragment = document.createDocumentFragment();
        let firstChild;
        while(firstChild = node.firstChild) {
            // appendChild具有移动性
            fragment.appendChild(firstChild);
        }
        return fragment
    }
    isElementNode(node) {
        return node.nodeType === 1;
    }
}
class Vue {
    constructor(options) {
        // this.$el $data $options
        this.$el = options.el;
        this.$data = options.data;
        // 这个根元素如果存在 就编译模板
        if(this.$el) {
            new Compiler(this.$el, this);
        }
    }
}
~~~

![image-20230219123820597](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230219123820597.png)

转换为数组，获取属性

~~~js
//基类 调度
class Compiler {
    constructor(el, vm) {
        // 判断el属性 是不是一个元素 如果不是元素 那就获取
        this.el = this.isElementNode(el)?el:document.querySelector(el);
        
        // 把当前节点的元素 获取到 内存中
        this.vm = vm;
        let fragment = this.node2fragment(this.el);

        // 把节点中的内容进行替换

        // 编译模板 用数据编译
        this.compile(fragment);

        // 把内容塞到页面中
        this.el.appendChild(fragment);
    }
    //  编译元素,如果是元素则取v-model
    compileElement(node) {
        let attributes = node.attributes;   //类数组
        console.log(attributes);

    }
    //  编译文本，如果是文本则取{{}}的内容
    compileText() {

    }
    //  编译内存中的dom节点
    compile(node) {
        let childNodes = node.childNodes;
        //[...childNodes] 相当于 Array.from(childNodes)
        [...childNodes].forEach(child=> {
            //判断当前节点是否未元素
            if(this.isElementNode(child)) {
                this.compileElement(child);
            }else {
                this.compileText(child);
            }
        });
    }
    //  把节点移动到哦内存中
    node2fragment(node) {
        // 创建一个文档碎片
        let fragment = document.createDocumentFragment();
        let firstChild;
        while(firstChild = node.firstChild) {
            // appendChild具有移动性
            fragment.appendChild(firstChild);
        }
        return fragment
    }
    isElementNode(node) {
        return node.nodeType === 1;
    }
}
class Vue {
    constructor(options) {
        // this.$el $data $options
        this.$el = options.el;
        this.$data = options.data;
        // 这个根元素如果存在 就编译模板
        if(this.$el) {
            new Compiler(this.$el, this);
        }
    }
}
~~~

![image-20230219124900495](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230219124900495.png)

~~~js
    //  编译元素
    compileElement(node) {
        let attributes = node.attributes;   //类数组
        [...attributes].forEach(attr=> {    //则取v-model
            console.log(attr);
        });
    }
~~~

![image-20230219125232004](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230219125232004.png)

```js
    //  编译元素
    compileElement(node) {
        let attributes = node.attributes;   //类数组
        // type="text" v-model="school.name"
        [...attributes].forEach(attr=> {
            let {name,value} = attr;
            console.log(name, value);
        });
    }
```

![image-20230219125549748](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230219125549748.png)

获取v-开头属性元素

```js
    isDirective(attrName) {
        return attrName.startsWith('v-');
    }
    //  编译元素
    compileElement(node) {
        let attributes = node.attributes;   //类数组
        // type="text" v-model="school.name"
        [...attributes].forEach(attr=> {
            let {name,value} = attr;
            if(this.isDirective(name)) {
                console.log(node)
            }
        });
    }
```

![image-20230219130035735](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230219130035735.png)

编译文本，获取{{}}

```java
    //  编译文本，判断文本节点的内容是否包含{{}}
    compileText(node) {
        let content = node.textContent;
        console.log(content);
    }
    //  编译内存中的dom节点
    compile(node) {
        let childNodes = node.childNodes;
        //[...childNodes] 相当于 Array.from(childNodes)
        [...childNodes].forEach(child=> {
            //判断当前节点是否未元素
            if(this.isElementNode(child)) {
                this.compileElement(child);
                // 如果是元素的话，就需要把自己传进去 再去遍历子节点
                this.compile(child);;
            }else {
                this.compileText(child);
            }
        });
    }
```

![image-20230219131442101](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230219131442101.png)

~~~js
    //  编译文本，判断文本节点的内容是否包含{{}}
    compileText(node) {
        let content = node.textContent;
        if(/\{\{(.+?)}\}/.test(content)) {
            console.log(content);
        }
    }
~~~

![image-20230219132046811](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230219132046811.png)

https://www.bilibili.com/video/BV1o4411T7ib/?spm_id_from=333.788.recommend_more_video.3&vd_source=1272b02e7a60d7fb8d81dfcdf529184e

![image-20230219195517537](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20230219195517537.png)
