---
title: Java练习题（office）
date: 2022-10-27 18:01:34.36
updated: 2022-10-27 18:01:34.36
url: /archives/java-lian-xi-ti-office
categories: 
- WEBbackend
tags: 
- javascript
- office
---

## 简单の比较运算问题

问题：输入单张机票的价格，再输入买几张。如果机票总价大于1万元，付款金额打八折；反之就是原价支付

我的方案：

~~~java
Scanner input = new Scanner(System.in);
System.out.println("请输入单张机票价格：");
double price = input.nextInt();
System.out.println("请输入购买数量：");
int quantity = input.nextInt();
double amount = price * quantity >= 10000 ? price * quantity * 0.8 : price * quantity;
System.out.println("付款金额" + amount);
~~~



问题：在控制台依次输入三个数比较返回最大数

我的方案：

~~~java
int x,y,z;
Scanner input = new Scanner(System.in);
System.out.println("请输入第一个数");
x = input.nextInt();
System.out.println("请输入第二个数");
y = input.nextInt();
System.out.println("请输入第三个数");
z = input.nextInt();
System.out.println("最大的数值为" + (x > y ? (x > z ? x : z):(y > z ? z : y)));
~~~



问题：红星玩具厂的一个生产小组生产一批玩具。原计划每天生产45件，4天做完。实际3天就做完成了任务。实际每天比原计划每天多做多少件玩具？

我的方案：

~~~java
System.out.println("每天生产件数：");
int every_make = input.nextInt();
System.out.println("原计划天数：");
int day = input.nextInt();
System.out.println("实际天数：");
int day2 = input.nextInt();
int make = (every_make * day / day2) - every_make;
System.out.println("实际每天比原计划每天多做" + make + "件");
~~~



问题：小明用一包绿豆做实验，其中发芽的种子有100粒，没有发芽的种子有25粒，求这包绿豆的发芽率（百分之多少）

我的方案：

~~~java
System.out.println("发芽种子数量：");
int seed_ger = input.nextInt();
System.out.println("未发芽种子数量：");
int seed_notger = input.nextInt();
double seed_total = seed_ger + seed_notger;
System.out.println("发芽率为：" + seed_ger / seed_total * 100 + "%");
~~~



问题：两筐苹果单价相同，甲筐苹果重64千克，乙筐苹果重48千克，两筐都卖出一部分后，剩下的苹果重量相等，已知乙筐比甲筐少卖了56元，甲筐苹果总共可卖多少元？

我的方案：

~~~java
System.out.println("甲框苹果重量(单位千克)：");
double a_weight = input.nextInt();
System.out.println("乙框苹果重量（单位千克）：");
double b_weight = input.nextInt();
System.out.println("乙比甲少买，还是多卖,输入true或false");
boolean apple_bool = input.nextBoolean();
System.out.println("多卖/少买多少元：");
int less = input.nextInt();
double money = apple_bool ? less / (a_weight - b_weight) * a_weight : less / (b_weight - a_weight) * a_weight;
System.out.println("甲框苹果总共可买" + money + "元");
~~~

