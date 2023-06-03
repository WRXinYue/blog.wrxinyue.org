---
title: Vector database
categories:
 - WebBackend/Python/gpt
tags:
 - LLM
data: 2023-05-29 22:30:33
updated: 2023-05-29 22:30:33
---

## 向量数据库是什么？ (What are Vector database?)

1. 向量定义：  
    向量是一种数学概念，在二维或三维空间中表示方向和大小的物体。它通常用箭头表示，箭头指向表示方向，箭头的长度表示大小。两个向量可以相加或相减，也可以与一个数相乘。向量在计算机科学中被广泛应用，例如计算机图形学、机器学习和搜索引擎等领域。
    
2. 向量数据库索引和存储方式：  
    向量数据库是一种专门存储和检索向量的数据库。它可以高效地索引大量向量数据，并通过特定的算法来进行搜索。通常，向量数据库将数据分布在多维空间中，使用空间数据结构（例如KD树、R树等）进行索引，以提高搜索效率。
    
3. 向量检索与优化方式：  
    向量检索是指在向量数据库中根据给定向量查找最相似向量的过程。它使用一种度量方法（如欧氏距离或余弦相似性）来衡量不同向量之间的相似度，并返回相似度最高的向量。

向量数据库用于存储和检索向量嵌入（embeddings），以便于高速查找和相似性搜索。一些常见的向量数据库有：

- Milvus（[https://github.com/milvus-io/milvus）](https://github.com/milvus-io/milvus%EF%BC%89)
- Pinecone（[https://www.pinecone.io/）](https://www.pinecone.io/%EF%BC%89)
- Qdrant（[https://github.com/qdrant/qdrant）](https://github.com/qdrant/qdrant%EF%BC%89)
- Weaviate（[https://github.com/weaviate/weaviate）](https://github.com/weaviate/weaviate%EF%BC%89)
- Chroma（[https://github.com/chroma-core/chroma）](https://github.com/chroma-core/chroma%EF%BC%89)
对比：[向量数据库大PK｜来自百万级数据的基准测试](https://mp.weixin.qq.com/s/8ptKCO7HHElGJCn5JFgScA)


### 向量检索和优化方式 (Vector Retrieval and Optimization)

**GPTCache**（[https://github.com/zilliztech/GPTCache](https://link.zhihu.com/?target=https%3A//github.com/zilliztech/GPTCache)）。
它使用向量数据库技术为各种 LLM 应用提供一层语义缓存，能够存储 LLM 响应，从而显著减少检索数据所需的时间、降低 API 调用开销、提升应用可扩展性。
**有了 GPTCache，受制于性能优化与成本的 LLM 应用，可以挣脱这些束缚，真正做到省钱、省时、省力了**。
GPTCache 项目由全球领先的向量数据库提供商 Zilliz 开发，该团队开源了首个向量数据库项目 Milvus，并推出了云端全托管的向量数据库服务 Zilliz Cloud。
GPTCache 的灵感源于解决开源项目知识库应用 OSSChat 的性能瓶颈和成本问题，通过添加语义缓存层，提升响应速度并节省成本。

![image.png](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/202305292239230.png)


GPTCache 的灵感起源于开发团队在回答开源项目 Milvus 社区用户的问题时遇到的重复性问题和非实时反馈的问题。为了解决这些问题，团队创建了OSSChat，一个基于ChatGPT的集成开源项目知识库。OSSChat旨在快速、有效地帮助用户解决在GitHub上开源项目中遇到的各种基础问题，如文档查找、安装指南等，提高用户的问题解决效率，并减轻开发团队的负担。

OSSChat 是一款旨在帮助开发者解决开源项目问题的应用，但随着用户数量的增加，团队意识到了基于 ChatGPT 的性能和成本限制。为了提升 OSSChat 的性能并降低使用成本，团队开始寻找解决方案。

![image.png](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/202305300029372.png)


在一次午饭闲聊中，团队讨论了计算机发展历程中缓存层的重要性。他们意识到通过添加一个缓存层来存储 LLM 生成的响应，可以显著提高 OSSChat 的响应速度并节省成本。这个想法最终演变成了 GPTCache 项目，它成功地解决了 OSSChat 面临的挑战。

因此，GPTCache 的起源与团队在开发 OSSChat 过程中遇到的性能和成本问题密切相关，其解决方向是引入缓存层以优化系统性能。

![image.png](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/202305292242977.png)


如果需要对存量的大规模文档进行vector存储的话，可能使用基于磁盘（disk-based）的数据库进行缓存可能是更好的选择。  
GPTCache是基于此概念搭建的，而且也是面向LLM专门搭建的，功能性上可能是开箱即用的。([https://github.com/zilliztech/GPTCache](https://github.com/zilliztech/GPTCache))

可以降低调用GPT token耗费、提高GPT响应速度的库。它使用语义缓存的方式将历史提问记录到本地，再下次提问相似问题时可直接返回而不走大语言模型。


#### 向量索引 (Vector Indexing)

向量索引是一种查找和检索向量的方法，可以快速找到与给定向量最相似的向量。常见的向量索引方法有：

- 树索引 (Tree Index)
- 量化索引 (Quantization Index)
- 图索引 (Graph Index)

这些方法的目标是尽可能减少访问向量的次数或者使计算距离更快。详细对比可参考：[https://github.com/erikbern/ann-benchmarks/](https://github.com/erikbern/ann-benchmarks/)


##### 树索引 (Tree Index)

树索引通常不是一个好的选择，因为在高维空间中，它容易受到维数诅咒的影响。
![image.png](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/202305292245966.png)

##### 量化索引 (Quantization Index)

量化索引通过降维来加速距离计算，从而提高搜索速度。


![image.png](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/202305292250008.png)


##### 图索引 (Graph Index)

图索引是一种利用图数据结构来进行搜索的方法，如 HNSW（Hierarchical Navigable Small World）
![image.png](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/202305292257890.png)


![image.png](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/202305292259290.png)
![image.png](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/202305292301015.png)

### HNSW

![image.png](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/202305292302891.png)


### 向量搜索的高级功能 (Advanced Features of Vector Search)

向量搜索不仅限于最近邻查找（ANN），还可以实现一些高级功能：

- 带过滤条件的向量搜索 (Vector search with filter)
- 带关键字的向量搜索 (Vector search with keyword)
- 多向量搜索 (Multi-vector search)

此外，还可以使用联合嵌入（Joint embedding）和多流检索（Multi-streamed retrieval）等技术，以提高大规模检索的效果。
![image.png](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/202305292304972.png)


Vector search with keyword
![image.png](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/202305292309571.png)



### Multi-vector search

![image.png](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/202305292312079.png)


Illustration of splitting or chunking of Wikipedia articles into multiple paragraphs to overcome model length
limitations.There are several strategies for chunking longer text,from simple splitting to more advanced methods
using sliding windows,so the generated chunks have overlapping wordpieces


Joint embedding
Multi-streamed retrieval

![image.png](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/202305292314569.png)
