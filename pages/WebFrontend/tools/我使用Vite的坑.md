---
title: 我使用Vite的坑
categories:
 - /
tags:
 - ''
data: 2023-04-11 11:48:23
updated: 2023-04-18 14:41:55
---

### 部分热重载失效问题

如果您修改了一个组件的模板代码，但是在修改后，浏览器没有自动更新，这可能是因为该模板代码包含了组件实例状态（例如 `v-model` 绑定或者 `ref` 引用），导致组件无法被热更新。这种情况下，您可以尝试在组件模板外面添加一个包装元素，以将状态提取到外层组件，从而使得内层组件可以被热更新。

例如，在以下示例中，我们将 `v-model` 绑定添加到一个名为 `value` 的属性上：

```vue
<template>
  <input :value="value" @input="$emit('update:value', $event.target.value)">
</template>
```

在这种情况下，如果您想要热更新组件，您可以尝试在组件模板外面添加一个 `<div>` 元素，从而将 `value` 提取到外层组件中：

```vue
<template>
  <div>
    <input :value="value" @input="$emit('update:value', $event.target.value)">
  </div>
</template>
```
这将使得组件可以被热更新，并且您可以在修改代码后立即看到效果。

请注意，这种情况只适用于修改了组件模板的情况。如果您修改了组件的 JavaScript 代码，那么您需要确保修改的代码可以被正确编译和加载，并且没有错误或运行时异常。