---
title: yapf代码格式化
categories:
 - WebBackend/Python
tags:
 - ''
data: 2023-07-01 15:17:21
updated: 2023-07-01 15:17:21
---

## 配置设置

创建一个名为`.style.yapf`的文件，并将其放在项目的根目录中

~~~
[style]

based_on_style = google

indent_width = 2

column_limit = 120

split_before_logical_operator = true
~~~


## 格式化全部代码

**PowerShell：**

```powershell
Get-ChildItem -Path . -Filter *.py -Recurse | ForEach-Object { yapf -i --style=.style.yapf $_.FullName }
```

~~~powershell
Get-ChildItem -Path . -Filter *.py -Recurse -Exclude (Get-ChildItem -Path .\venv\ -Recurse -Include *.py | ForEach-Object { $_.FullName }) | ForEach-Object { yapf -i --style=.style.yapf $_.FullName }
~~~

**Linux：**

```bash
find . -iname "*.py" -exec yapf -i --style=.style.yapf {} \;
```