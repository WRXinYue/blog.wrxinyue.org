---
title: FAISS
categories:
 - WebBackend/Python/gpt
tags:
 - ''
data: 2023-05-29 22:16:05
updated: 2023-05-29 22:16:05
---


为什么用到FAISS，假设你有一个向量数据需要查询，但是几百和几千个虽然没多大问题，如果是几万或者几百万个，那对性能浪费是非常可怕的了


 FAISS（Facebook AI Similarity Search）是Facebook开源的一个用于高效相似性搜索和聚类的库。它主要是为了解决深度学习中大规模向量检索的问题，适用于向量索引和相似性搜索等场景。FAISS库提供了一系列高效的索引算法和检索方法，比如Inverted File、Product Quantization和PCA-IVF等，可以快速处理百万级别的向量数据，并支持多种相似性度量方式，如余弦相似度、欧几里得距离等。在Facebook内部，FAISS被广泛应用于图像和视频搜索、语义搜索、推荐系统等领域，在业界也得到了广泛的应用和认可。