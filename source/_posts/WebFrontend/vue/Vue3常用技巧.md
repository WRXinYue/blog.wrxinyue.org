---
data: 2023-04-11 05:22:00
updated: 2023-04-11 14:50:36
---

### 执行所有异步函数并等待完成

```ts
onLoad(async () => {
	try {
		uni.showLoading({})
		
		await Promise.all([
		  getSalaries(),
		  getLanguage(),
		  getOutsiteExp(),
		  getPositionTree(),
		  getCustomerIntension()
		])
		uni.hideLoading()
		ShowPage.value = true
		
	} catch (error) {
		console.error(error)
	}
})
```