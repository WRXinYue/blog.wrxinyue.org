---
title: WSL
categories:
 - 其它
tags:
 - ''
data: 2023-04-19 14:57:25
updated: 2023-05-25 22:39:07
---

# 常用WSL命令

## ssh连接WSL2

**重装SSH：**
```bash
sudo apt-get remove openssh-server
sudo apt-get install openssh-server
```

**编辑 shd_config**
```bash
sudo vi /etc/ssh/sshd_config
```

添加：
```
Port 22
PermitRootLogin yes
PasswordAuthentication yes
```

**编辑sudo vim /etc/hosts.allow**
```bash
sudo vim /etc/hosts.allow
```

添加：
```
sshd: ALL
```

**重启ssh服务：**
```bash
sudo service ssh --full-restart
```

**查看wsl IP地址**
```bash
ifconfig
```

**powershell输入命令将端口转发到WSL2：**
```bash
netsh interface portproxy add v4tov4 listenaddress=0.0.0.0 listenport=22 connectaddress=xxx.xxx.xxx.xxx connectport=22
```
此处xxx.xxx.xxx.xxx替换成wsl的IP地址，如172.18.195.3

然后就可以通过127.0.0.1或者localhost连接到wsl2

## WSL2设置代理

### 单次配置

**HTTP协议：**
```bash
export hostip=$(cat /etc/resolv.conf |grep -oP '(?<=nameserver\ ).*')
export https_proxy="http://${hostip}:10811";
export http_proxy="http://${hostip}:10811";
```

**socket5协议：**
```bash
export http_proxy="socks5://${hostip}:10810"
export https_proxy="socks5://${hostip}:10810"
```

**其他和验证：**

端口相同可以合并一段话
```bash
export all_proxy="socks5://${hostip}:7890"
```

使用`curl`即可验证代理是否成功，如果有返回值则说明代理成功：
```bash
curl www.google.com
```

## 设置开机自启

打开命令提示符（不用使用管理员权限），然后运行以下命令：
```bash
wsl --list --verbose
```

找到正确的发行版名称后，使用以下命令替换`YourDistroName`：

```bash
C:\Windows\System32\wsl.exe -d YourDistroName -- sudo service ssh start
```

将此命令添加到开机自启动，请按照以下步骤操作：

1. 按住 `Win` 键，然后按 `R` 键，输入 `shell:startup` 回车。这将打开"启动" 文件夹。
2. 在"启动"文件夹中，右键单击空白处，选择 "新建" > "快捷方式"。
3. 在 "创建快捷方式" 对话框中，将正确的命令粘贴到 "位置" 栏，然后单击 "下一步" 。
4. 输入一个名称以识别该快捷方式，例如 `C:\Windows\System32\wsl.exe -d Ubuntu -- sudo service ssh start`，然后单击 "完成"。

现在，将自动运行此快捷方式，启动 WSL 中的 SSH 服务器。

# 扩展阅读

1.  [为 WSL2 一键设置代理](https://zhuanlan.zhihu.com/p/153124468)
2. [WSL2配置代理 - Leaos - 博客园](https://www.cnblogs.com/tuilk/p/16287472.html)
3. [使用 WSL 在 Windows 上安装 Linux](https://learn.microsoft.com/zh-cn/windows/wsl/install#step-1---enable-the-windows-subsystem-for-linux)
4. [如何用笔记本ssh连接局域网内其他电脑上的wsl2 ubuntu](https://zhuanlan.zhihu.com/p/357038111)
5. [在 适用于 Linux 的 Windows 子系统 上运行 Linux GUI 应用](https://learn.microsoft.com/zh-cn/windows/wsl/tutorials/gui-apps)
6. [Window10 建置Ubuntu(WSL2)與GUI桌面配置筆記](https://hackmd.io/@JYU/B1zmv1MCU)