---
title: Streamlit App with PyCharm and WSL2
categories:
 - Python
tags:
 - ''
data: 2023-05-28 20:46:27
updated: 2023-05-28 20:46:27
---

## 运行Python脚本

在 PyCharm 中运行 Streamlit 应用程序，需要更改运行配置。按照以下步骤操作：

1. 打开 PyCharm，并确保已打开您的项目。
2. 在顶部工具栏上找到“Run”菜单并点击“Edit Configurations...”。
3. 点击左上角的 "+" 按钮以创建一个新的配置。
4. 在弹出列表中选择 "Python"。
5. 为新配置命名，例如 "Streamlit App"。
6. 在 "Script path" 或 "Module name" 字段中输入：
```
streamlit
```

7. 在 "Parameters" 字段中输入：
```
run test.py [ARGUMENTS]
```
（如果有任何实际参数需要传递给应用，请替换 `[ARGUMENTS]`）

8. 在 "Python interpreter" 下拉菜单中选择在 WSL 中设置的 Python 解释器。

9. 点击 "OK" 以保存配置。

![image.png](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/202305282048933.png)
