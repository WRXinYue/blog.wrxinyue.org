---
title: Sentence Embeddings
categories:
 - WebBackend/Python/LLMOps
tags:
 - NLP
data: 2023-05-31 16:04:36
updated: 2023-05-31 16:04:36
---

## 关于Sentence Embeddings

句子嵌入（Sentence Embeddings）是将一个句子转换为向量表示的技术。这种向量表示捕捉了句子的语义信息和上下文，可以用于下游自然语言处理（NLP）任务，如分类、聚类、相似度计算等。
句子嵌入技术通常涉及将句子中的每个单词转换为向量，然后将这些向量汇总为代表整个句子的向量。有许多不同的方法可以生成句子向量，例如Word2Vec、GloVe、FastText模型以及最近的Transformer模型等。
将句子嵌入用作特征向量可以大大简化许多NLP任务，并提高模型的准确性和效率。

## OpenAI Embeddings API
OpenAI Embeddings API提供了一种方便、高效的方式来生成[文本表示](https://github.com/shibing624/nlp-tutorial/blob/main/01_word_embedding/01_%E6%96%87%E6%9C%AC%E8%A1%A8%E7%A4%BA.ipynb)

## 扩展阅读

1. [LangChain - 打造自己的GPT（五）拥有本地高效、安全的Sentence Embeddings For Chinese & English](https://zhuanlan.zhihu.com/p/622017658)