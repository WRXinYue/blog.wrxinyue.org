---
title: Docker
categories:
 - server
tags:
 - ''
data: 2023-07-09 23:57:43
updated: 2023-09-21 12:19:52
---

## 克隆与运行

**克隆Ubuntu为例：**
~~~
docker commit c7b1021e0e3c ubuntu-tem

docker run --name my_container -d -p 8002:22 ubuntu-tem /usr/sbin/sshd -D
~~~

### 快速ubuntu
~~~shell
docker run --name naiko_ub -t -i -d -p 3316:22 ubuntu

docker exec -it naiko_ub bash

sudo passwd root

# 安装更新ssh服务器
sudo apt-get install openssh-server

# 开启ssh服务
sudo service ssh start

# 设置开机自启ssh服务
sudo systemctl enable ssh

# 禁止开机启动ssh
sudo systemctl disable ssh

# 检查是否设置成功
sudo service ssh status
~~~

是的，如果您想允许外部访问你的 SSH 服务器，确实需要在 `/etc/ssh/sshd_config` 文件中进行相应的修改。

可以按照以下步骤操作：

1. 打开 sshd_config 文件：
```
sudo nano /etc/ssh/sshd_config
```

2. 定位到以下几个配置项并进行修改：

- `Port`: 默认为 22，您可以将其更改为其他不常用的端口以提高安全性。
```
Port 22
```

- `PermitRootLogin`: 将其设置为`yes`,开启root用户登陆
```
PermitRootLogin yes
```

- `PasswordAuthentication`: 设置为 `yes` 以允许使用密码登录，或 `no` 以仅允许使用密钥对登录。
```
PasswordAuthentication yes
```

- `AllowUsers` 或 `AllowGroups`: 如果您需要限制特定用户或用户组才能访问 SSH 服务，可以添加这些选项。例如：
```
AllowUsers user1 user2
AllowGroups group1 group2
```

3. 保存更改并退出编辑器。

4. 重启 SSH 服务以使更改生效：
```
sudo service ssh restart
```

5. 最后，请确保您的防火墙中也打开了相应的端口，以允许外部访问。如果您使用的是 `ufw`，可以按照以下示例打开（这里以默认的 22 端口为例）：
```
sudo ufw allow 22
```

完成以上步骤后，您的 SSH 服务器将可以接受外部访问。建议您根据自己的实际需要调整配置以保证安全性。


### Docker使用代理进行构建

~~~bash
sudo docker build . \
   --network host \
   --build-arg HTTP_PROXY=http://127.0.0.1:7890 \
   --build-arg HTTPS_PROXY=http://127.0.0.1:7890
~~~