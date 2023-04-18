---
title: 微信小程序技术
date: 2023-3-11 11:39:00
categories: 
- WEBbackend
tags: 
- 移动应用
data: 2023-04-11 14:47:04
updated: 2023-04-11 14:47:04
---


## 简介
小程序本质来说是前端，都是开发页面交互，以及数据请求业务逻辑

### 如何学习
看开发文档是最好且最快的学习方式，其次就是官方的视频教程，生动有趣

### APP常用开发模式
* Native App -- 原生开发
* WebApp -- H5应用
* Hyriid App -- 混合开发
* 

### 微信小程序技术栈
* ui库：WeUI，有赞的vantUI
* Vue框架：腾讯**Wepy**，**Uniapp**，美团**MpVue**(停止维护)
* react框架(多端支持)：阿里**Remax**，京东**Taro**
* 跨端开发：**Uniapp**，**Chameleon**
* 其它：低代码、云开发



```java

@GetMapping("/getSrmAreaTemplateByProjectId")  
@ApiOperation("获得SRM区域数据映射列表")  
@PreAuthorize("@ss.hasPermission('biz:srm-area:query')")  
public CommonResult<List<SrmAreaRespVO>> getSrmAreaTemplateByProjectId(@RequestParam("projectId") Long projectId) {
	/** 根据项目 ID 获取 SRM 区域数据映射列表 */
    List<SrmAreaDO> list = srmAreaService.getSrmAreaTemplateByProjectId(projectId);  
    /** 将 `SrmAreaDO` 列表转换为 `SrmAreaRespVO` 列表。 */
    List<SrmAreaRespVO> resp = SrmAreaConvert.INSTANCE.convertList(list);  
    for (SrmAreaRespVO vo: resp) {  
        vo.setFlag(true);  
        vo.setTriggerFlag(false);  
    }  
    return success(bulidTree(resp));  
}  
  
  
private static List<SrmAreaRespVO> buildTree(List<SrmAreaRespVO> treeList) {
    Map<Long, SrmAreaRespVO> idToNodeMap = new HashMap<>();
    // 将所有节点放入 idToNodeMap 中，方便后面查找父子关系
    for (SrmAreaRespVO node : treeList) {
        idToNodeMap.put(node.getId(), node);
    }
    List<SrmAreaRespVO> resultList = new LinkedList<>();
    for (SrmAreaRespVO node : treeList) {
        if (node.getParentId() == 0L) {
            resultList.add(node);
        } else {
            SrmAreaRespVO parentNode = idToNodeMap.get(node.getParentId());
            if (parentNode != null) {
                parentNode.getChildren().add(node);
            }
        }
    }
    return resultList;
}



```


首先要确认，我们要循环什么，