---
data: 2023-04-12 19:35:27
updated: 2023-04-12 19:35:27
---

### div盒子水平垂直居中

**FlexBox布局居中：**

通过设置父容器的 display: flex; 和 justify-content: center; align-items: center; 样式，即可实现将子元素水平垂直居中。
```html
<div class="parent">
  <div class="child">Hello World!</div>
</div>

<style>
  .parent {
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh; /* 可以根据实际需求调整 */
  }
</style>
```

**绝对定位居中：**

父容器添加 position: relative; 样式，并为子元素添加 position: absolute; 以将其从文档流中分离出来。然后可以使用 top, bottom, left, 和 right 属性，将子元素定位到父容器的中心
```html
<div class="parent">
  <div class="child">Hello World!</div>
</div>

<style>
  .parent {
    position: relative;
    height: 100vh; /* 可以根据实际需求调整 */
  }
  
  .child {
    position: absolute;
    top: 50%;
    left: 50%;
    transform: translate(-50%, -50%);
  }
</style>
```

**Flexbox“自动边距”（auto margin）居中：**

margin-top: auto; 和 margin-bottom: auto; 来实现元素在父容器中的垂直居中

```html
<div class="parent">
  <div class="child">Hello World!</div>
</div>

<style>
  .parent {
    height: 100vh;
    display: flex;
    flex-direction: column;
  }
  
  .child {
    margin-top: auto;
    margin-bottom: auto;
  }
</style>
```