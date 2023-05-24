
---
title: Untitled
categories:
 - Scripts
tags:
 - ''
data: 2023-05-22 11:38:28
updated: 2023-05-22 11:38:28
---

清华大学公开了基于GLM的60亿参数预训练语言模型。通过组建个人语料库，研究人员可以对大语言模型进行微调，使其具备个性化特征。

大语言模型（例如GPT-3）是一种深度学习模型，通过学习大量文本数据来生成文本。这些模型可以理解和生成复杂的语言模式，包括语序、语法和词汇用法。通过训练这些模型，让它们学会备份者回答问题的方式，包括使用特定的逻辑和语言组织习惯。

进行模型微调的过程包括以下几个步骤：

1.  收集个人化语料库：包括文本、音频和视觉信息，这些信息可以反映一个人的语言特征和使用习惯。
2.  对大语言模型进行微调：使用个人化语料库训练模型，使其学会模仿目标个体的语言风格。
3.  文字转语音和视频：将生成的文本通过语音合成技术转换成音频，同时使用视频生成技术将语音与画面结合起来，创建逼真的对话效果。
4.  实时串流和播放：将音频和视频内容实时串流，以满足用户与模型进行实时互动的需求。

训练这样的模型需要大量的语料。在清华大学的案例中，研究人员使用了2小时以上的语音文件来对语音模型进行微调。

总之，清华大学公开了一个基于GLM的大型预训练语言模型，并通过组建个人语料库对其进行微调，使其具有个性化特征。这将有助于人们更好地与模型互动，获得具有备份者语言特点的回答。同时，通过将生成的文字转换为音频和视频并实时串流，用户可以更自然地参与到与模型的互动中。


## 了解DL-C框架 (Digiteal Life C)
DL-C框架（Digital Life C）是一种通过大语言模型实现数字生活备份的技术。为了实现这一目标，DL-C框架中采用了流式输出和优化并行处理的方法。在这个框架中，大语言模型并不是一次性生成所有的回答，而是先生成回答的一部分，迅速将这一部分传递给下面的流程，同时生成音频和视频。在生成音频和视频的同时，大语言模型会继续生成答案的下一个部分，从而实现更快的响应时间。

实现记忆备份的方法包括：增加一个选择器来判断是否需要调用记忆，以及加入自适应迭代机制（自感知、自适应、自组织，可重塑编译计算核心）。目前数字备份最大的问题是无法在训练好的基础上自主学习进行迭代。通过自适应迭代机制，可以实现更有效地实现数字生活备份。

本次开源的DL-B框架是一个基于ChatGLM、Wav2Lip、So-VITS-SVC的数字形象方案。实际使用时，可以根据具体需求选择合适的模型进行微调和优化。

记忆储存模块的设计则基于LangChain框架或Semantic Kernel实现。它通过构建一个外部知识库，在其中通过词向量索引相关记忆，再将相关的记忆片段作为材料输入给大语言模型。目前这种记忆备份方法虽然还很原始、简陋和低效，但在多模态模型逐渐成熟的未来，这一问题有望得到解决。另一种可能的方法是通过更先进的脑电技术直接链接大脑或者进行扫描备份。

数字孪生的核心在于基础数据的收集，AI只是实现虚拟人的一种手段。要实现数字永生，还需要考虑基础数据与自我迭代的关系，明确“像”与“是”的边界。虽然当前的AI技术已经超出了我们之前的认知，但仍然无法还原“灵魂”。为了获取灵魂的DNA，我们可能需要另一种理论来提取。
![image.png](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/202305221207075.png)

本次开源为DL-B,是一个基于ChatGLM、
Wav2Iip、so-vits-svc组建的数字形象方案。

### ChatGLM

ChatGLM 是一种强大的大型语言模型，可用于自然语言处理任务。对于这个模型，有多种微调方式可供选择。用户可以根据自己的实际需求选择合适的微调方法。在微调ChatGLM时，可以参考清华大学官方关于P-tuning的说明以及GitHub上的一些示例库，如以甄嬛为例的微调项目。

是自动下载的。如果网络环境较差，可以从 Hugging Face Hub 上下载模型。这需要先安装Git LFS，然后运行一些Git命令来下载模型及其参数。另外，如果希望保证兼容性，可以切换到固定版本的模型实现。

要使用自己的数据集进行微调，需要修改`train.sh`和`evaluate.sh`文件中的相关路径。对于多轮对话数据集的微调，可以按照指定的格式提供聊天历史，并在训练时指定`--history_column`为聊天历史的 key。

在进行模型微调时，可以根据需求选择单轮对话语料或多轮对话语料，也可以将它们混合使用。只需在训练数据中直接添加需要的对话模式即可。通过微调和训练，可以实现对ChatGLM的个性化定制，以满足不同场景和需求。

---

### so-vits-svc

So-VITS已经是一个非常成熟且火爆的模型，在B站上有很多教学视频供大家参考。例如，这个[教程](https://www.bilibili.com/video/BV1H24y187Ko)质量非常高，提纲挈领地介绍了So-VITS模型的训练方法。虽然此库中包含了So-VITS的基础训练和聚类训练代码，但这些代码并不是很适合普通用户。从今年3月份开始，这个库在DL-B中的内容就没有再进行更新。需要注意的是，这个库并没有包含数据处理和前期准备所需的工具。

补全模型文件的方法是：

1. 下载模型文件[checkpoint_best_legacy_500.pt](https://ibm.box.com/s/z1wgl1stco8ffooyatzdwsqn2psd9lrr)，将其放置在`hubert`文件夹下。
2. 下载两个预训练模型文件[G_0.pth](https://huggingface.co/justinjohn-03/so-vits-svc-4.0-v2-pretrained/resolve/main/G_0.pth)和[D_0.pth](https://huggingface.co/justinjohn-03/so-vits-svc-4.0-v2-pretrained/resolve/main/D_0.pth)，将它们分别放置在`.\module\So-VITS`和`pre_trained_model`文件夹下。

通过以上步骤，你可以顺利补全模型文件，开始使用So-VITS模型进行训练和研究。不过，由于此库可能不容易使用，你可能需要参考其他资料和教程来更好地理解So-VITS模型及其应用。

---

### Wav2Lip

这里是一个较为古早的方法，基于原始的[Wav2Lip](https://github.com/Rudrabha/Wav2Lip)制作。用户可以根据自己的需求选择不同的预训练模型权重。以下是一些模型及其描述和下载链接：

| 模型                     | 描述                    | 链接                                                                                                                                   |
|------------------------|-----------------------|-------------------------------------------------------------------------------------------------------------------------------------|
| Wav2Lip                | 高精度的唇同步           | [下载](https://iiitaphyd-my.sharepoint.com/:u:/g/personal/radrabha_m_research_iiit_ac_in/Eb3LEzbfuKlJiR600lQWRxgBIY27JZg80f7V9jtMfbNDaQ?e=TBFBVW)                       |
| Wav2Lip+GAN            | 口型稍差，但视觉质量较好  | [下载](https://iiitaphyd-my.sharepoint.com/:u:/g/personal/radrabha_m_research_iiit_ac_in/EdjI7bZlgApMqsVoEUUXpLsBxqXbn5z8VTmoxp55YNDcIA?e=n9ljGW)                       |
| Expert Discriminator   |                       | [下载](https://iiitaphyd-my.sharepoint.com/:u:/g/personal/radrabha_m_research_iiit_ac_in/EQRvmiZg-HRAjvI6zqN9eTEBP74KefynCwPWVmF57l-AYA?e=ZRPHKP)                       |
| Visual Quality Discriminator |                 | [下载](https://iiitaphyd-my.sharepoint.com/:u:/g/personal/radrabha_m_research_iiit_ac_in/EQVqH88dTm1HjlK11eNba5gBbn15WMS0B0EZbDBttqrqkg?e=ic0ljo)                       |

请将这些模型下载后，放置在`.\module\wav2lip`文件夹下。

为了使用这个库，你需要采集部分视频，例如使用手机、电脑或相机录制人面部信息。建议的视频格式为`.mp4`，分辨率为`720p`或`480p`。视频时长最好在5-10秒之间。你可以采集多个视频。然后把这些视频文件存放在`source`文件夹下。

关于Wav2Lip模型的优化，B站上有很多大佬已经分享了相关技巧。例如，下面这个[视频](https://www.bilibili.com/video/BV1g8411T7it)就提供了详细的教程。

此外，请注意还需要下载一个在推理过程中用到的模型[s3fd.pth](https://pan.baidu.com/s/1V4suCAbly7038xfGcFqO7Q?pwd=DLVB)，并将其放置在`.\face_detection\detection\sfd`文件夹下。

---