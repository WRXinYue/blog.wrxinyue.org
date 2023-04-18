---
title: 微信小程序Uni-app笔记
categories:
 - WebFrontend/移动应用
tags:
 - ''
data: 2023-04-10 12:24:21
updated: 2023-04-18 15:30:59
---

## 全局配置

### pages.json

pages.josn 文件用来对uni-app进行全局配置，决定页面文件的路径、窗口表现、设置多tab等。

-   `globalStyle`设置默认页面的窗口表现。
-   `pages` 设置页面路径及窗口表现。
-   `tabBar` 设置底部 tab 的表现


### 获取元素节点

```ts
    const query = uni.createSelectorQuery()

    query.select('#ion-heade').boundingClientRect()

    query.exec(res => {

        headerOffsetH.value = res[0].height

    })
```

#### Toast

```js
        Toast('获取项目列表失败!')
```

```js
        uni.showLoading({

            title: '请选择期望职位',

        })
```

### 获取元素节点

```html
<view id="ion-heade">1234</view>
```

```typescript
const query = uni.createSelectorQuery()
query.select('#ion-heade').boundingClientRect()
query.exec(res => {
	console.log('元素信息：', res[0])
})
```

> 注意事项：要在页面加载之后进行获取


#### 组件传参

```js

<template>
  <div>{{ message }}</div>
  <button @click="setMessage">Change Message</button>
</template>

<script>
import { useMyStore } from '@/store/myStore'

export default {
  setup() {
    const store = useMyStore()

    const message = computed(() => store.getMessage())

    function setMessage() {
      store.setMessage('New message from component!')
    }

    return {
      message,
      setMessage
    }
  }
}
</script>

```

```js
<template>
  <div>{{ message }}</div>
  <button @click="setMessage">Change Message</button>
</template>

<script lang="ts" setup>
import { useMyStore } from '@/store/myStore'
import { defineComponent, computed } from 'vue'

const store = useMyStore()

const message = computed(() => store.getMessage())

function setMessage() {
  store.setMessage('New message from component!')
}
</script>

```

### 小程序双向数据绑定


> 最好不要使用v-model，使用v-bind 和 v-on

```vue
<input :value="textValue" @input="inputChange" maxlength="500" placeholder="请用一段简短的文字描述一下自己吧" />
<view>{{ description }}/500 字</view>
```

```typescript
let description = ref('')
```


### 多行文本

```vue
<textarea :value="textValue" @input="inputChange" maxlength="500" placeholder="请用一段简短的文字描述一下自己吧" />
<view>{{ description }}/500 字</view>
```

```ts
const textValue = ref('')
let description = ref(0)
const _ParameterPassingService = new ParameterPassingService()
const inputChange = (event: any) => {
    description.value = event.detail.cursor
}
```

> 在 UniApp 中，`v-model` 指令不能直接应用于 `textarea` 组件，因为 UniApp 会对 Vue.js 的语法进行编译，生成多端应用代码，而不同平台对于表单组件的处理方式可能有所不同。例如，在微信小程序中，`textarea` 组件的双向数据绑定需要使用 `value` 属性和 `bindinput` 事件，而在其他平台上，可能需要使用不同的属性和事件来实现相同的功能。
> 因此，为了确保跨平台的兼容性，UniApp 建议使用 `v-bind` 和 `v-on` 指令来实现 `textarea` 组件的双向数据绑定，而不是直接使用 `v-model` 指令。
> 如果组件无法输入：尝试添加高度


### uniapp css 修改
```scss
::v-deep .uni-select {

    border: none;

    text-align: right;

    right: 0px;

}
```


### 弹窗显示

```ts
uni.showToast({
	title: '',
})
```


### 下拉菜单

```vue
<picker @change="bindPickerChange" :value="selectedSalary" :range="salariesOptions" range-key="ItemName">
	<view class="uni-input">{{ salariesOptions[selectedSalary]?.ItemName }}</view>
</picker>

<script setup lang="ts">
const selectedSalary: any = ref(0)
const salariesOptions: Ref<any[]> = ref([])

	const bindPickerChange = (e: any) => {
		selectedSalary.value = e.detail.value
	}
</script>
```


###  页面传参


**跳转页面：**

```ts
uni.navigateTo({
	url: `/pages/boss/interview-worker/interview-worker?id=${offerId}&title=${title}&flag=${flag}`,
})
```

**被跳转的页面：**

```ts
onLoad(query => {
	reqId.value = query?.id || ''
	title.value = query?.title || ''
	flag.value = query?.flag || ''
})
```

