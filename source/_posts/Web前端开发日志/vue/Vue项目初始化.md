

安装vue-cli工具

```shell
npm install -g @vue/cli
```

生成项目(Vue CLI 2.x 版本)

~~~shell
vue init webpack my-project
~~~

生成项目(Vue CLI 3.x 版本)

~~~shell
vue create my-project
~~~

安装依赖

~~~shell
npm install
~~~

启动项目

~~~shell
npm run dev
~~~



```she
npm init vite@latest shop-admin -- --template vue
```



```shell
# npm 6.x
npm init @vitejs/app my-vuetify-app --template vue

# npm 7+, extra double-dash is needed:
npm init @vitejs/app my-vuetify-app -- --template vue

# yarn
yarn create @vitejs/app my-vuetify-app --template vue
```

并应替换为：

```shell
# npm 6.x
npm create vite@latest my-vue-app --template vue

# npm 7+, extra double-dash is needed:
npm create vite@latest my-vue-app -- --template vue

# yarn
yarn create vite my-vue-app --template vue

# pnpm
pnpm create vite my-vue-app -- --template vue
```
