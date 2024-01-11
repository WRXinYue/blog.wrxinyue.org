---
title: LangChain通过LLM实现QA
categories:
 - WebBackend/Python/LLMOps
tags:
 - ''
data: 2023-06-08 11:20:09
updated: 2023-06-12 18:24:41
---

## 向量化: HuggingFaceEmbeddings

```python
# Embedding running device
EMBEDDING_DEVICE = 'cuda' if torch.cuda.is_available() else 'mps' if torch.backends.mps.is_available() else 'cpu'

# 加载本地向量编码器  
model_name = "sentence-transformers/all-mpnet-base-v2"  
model_kwargs = {'device': EMBEDDING_DEVICE}  
embeddings = HuggingFaceEmbeddings(model_name=model_name, model_kwargs=model_kwargs)
```


## 向量化存储(FAISS)

### 初始化

* 创建词嵌入模型（embedding model）  
* 可以参考以下链接获取模型：https://huggingface.co/spaces/mteb/leaderboard
* 你也可以使用以下链接中的模型：https://www.sbert.net/index.html 
* docs 为传入文本

会创建新表，并插入数据，表字段是除pk与vactor外，其他需要metadata字段设置好
```python
# vector_store = FAISS.from_documents(docs, embeddings)
# vector_store = FAISS.from_texts(docs, embeddings)

vector_store = Milvus.from_documents(  
	chunks,  # 切片文本
	embeddings_decoder,  
	connection_args=DEFAULT_MILVUS_CONNECTION,  
	collection_name="zhltest1234"  
)
```

### 新增单个文档（add_document)

```python
# vector_store.add_documents(doc)
# vector_store.save_local(self.vector_store_path)

vector_store = Milvus(  
	connection_args=DEFAULT_MILVUS_CONNECTION,  
	embedding_function=embeddings,  
	collection_name="zhl3"
)
vector_store.add_texts(["你好"],metadatas=[{'source': './test.txt'}])
```

### 批量直接导入embedding（函数：load_vector_store）

```python
# FAISS.load_local(self.vector_store_path, self.embeddings)
```

### 连接指定的表（collection_name）进行查询

目前langchain封装的查询接口参数两类，字符串与编码后的向量
相似度查询两类 similarity_search与max_marginal_relevance_search

```python
query = "需要常驻于内存?"  
query_embedding = embeddings.embed_query(query)  
docs1 = vector_store.similarity_search(query)  
docs2 = vector_store.similarity_search_with_score(query)  
docs3 = vector_store.similarity_search_by_vector(query_embedding, k=2)  
docs4 = vector_store.similarity_search_with_score_by_vector(query_embedding, k=2)  
docs5 = vector_store.max_marginal_relevance_search(query, k=30)  
docs6 = vector_store.max_marginal_relevance_search_by_vector(query_embedding, k=30)
```


## 建立MILVUS数据库连接参数

```python
DEFAULT_MILVUS_CONNECTION = {  
	"host": "127.0.0.1",  
	"port": 19530,  
	"user": "",  
	"password": "",  
	"secure": False,  
}
```






```md
# 插入数据，参数要求是列表，metadatas要求与表中字段一致。  
# pk是主键，vector FloatVector向量类型，维度要与编码器的输出维度一致，openai是1500多，目前本地是768维
```