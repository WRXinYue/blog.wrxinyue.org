---
title: MVC设计模式
date: 2022-11-24 17:56:54.103
updated: 2022-12-07 11:18:17.943
url: /archives/mvc-she-ji-mo-shi
categories: 
- 其他
tags: 
- java
- 架构模式
---

## MVC介绍

**MVC(Model-View-Controller)**是一种**软件开发架构**模式，包含：**Observer(观察者模式)**,**Composite(组合模式)**和**Strategy(策略模式)** 



MVC 模式的基本思想是数据，显示和处理相分离。模型(Model)负责**数据管理**，视图(View)负责**数据显示**，控制器(Controller)负责**业务逻辑**和**响应策略**。

* **模型：** 代表应用的业务层。   它是一个携带数据的对象，如果数据发生变化，它还可以包含更新控制器的逻辑。 
* **视图：** 它代表应用程序的表示层。   它用于可视化模型包含的数据。 
* **控制器：** 它适用于模型和视图。   它用于管理应用程序流，即模型对象中的数据流，并在数据更改时更新视图。 

在 Java 编程中，模型包含简单的 Java 类 ，用于显示数据的视图和包含 servlet的控制器。   由于这种分离，用户请求的处理如下： 

![image-20221124122932487](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221124122932487.png)

1. 客户端（浏览器）向服务器端的控制器发送页面请求。 

2. 然后控制器调用模型。  它收集请求的数据。 

3. 然后控制器将检索到的数据传输到视图层。 

4. 现在结果由视图发送回浏览器（客户端）

![image-20221207111406179](https://wrxinyue.oss-cn-hongkong.aliyuncs.com/img/image-20221207111406179.png)

MVC架构把数据处理，程序输入输出控制及数据显示分离开来，并且描述了不同部件的对象间的通信方式。使得软件可维护性，可扩展性，灵活性以及封装性大大提高；

视图表示数据在屏幕上的显示。控制器提供处理过程控制，它在模型和视图之间起连接作用。控制器本身不输出任何信息和做任何处理，它只负责把用户的请求转成针对Model的操作，和调用相应的视图来显示Model处理后的数据。

## 为什么要在Web应用中使用MVC架构

### *提高代码重用率*

### *提高程序的可维护性*

### *有利于团队开发*



## Java简单实现MVC

* **Employee Class** —— model 

~~~java
//表示模型的类
public class Employee {
    //声明变量
    private String employeeName;
    private String employeeId;
    private String employeeDepartment;
    
    //定义get和set方法
    public String getEmployeeName() {
        return employeeName;
    }
    public void setEmployeeName(String employeeName) {
        this.employeeName = employeeName;
    }
    public String getEmployeeId() {
        return employeeId;
    }
    public void setEmployeeId(String employeeId) {
        this.employeeId = employeeId;
    }
    public String getEmployeeDepartment() {
        return employeeDepartment;
    }
    public void setEmployeeDepartment(String employeeDepartment) {
        this.employeeDepartment = employeeDepartment;
    }
}
~~~

* **EmployeeView Class** —— view

~~~java
//表示视图的类 
public class EmployeeView {
    
  //显示员工详细信息的方法
    public void printEmployeeDetails(String employeeName,String employeeId,String employeeDepartment) {
        System.out.println("Employee Details：");
        System.out.println("Name：" + employeeName);
        System.out.println("Employee ID：" + employeeId);
        System.out.println("Employee Department：" + employeeDepartment);
    }
}
~~~

* **EmployeeContoller Class** —— controller

~~~java
//代表控制器的类
public class EmployeeController {

    // 声明变量模型和视图  
    private Employee model;
    private EmployeeView view;
    
    // 要初始化的构造函数
    public EmployeeController(Employee model,EmployeeView view) {
        this.model = model;
        this.view = view;
    }
    
    // getter 和 setter 方法
    public void setEmployeeName(String name) {
        model.setEmployeeName(name);
    }
    
    public String getEmployeeName() {
        return model.getEmployeeName();
    }
    
    public void setEmployeeId(String id) {
        model.setEmployeeId(id);
    }
    
    public String getEmployeeId() {
        return model.getEmployeeId();
    }
    
    public void setEmployeeDepartment(String department) {
        model.setEmployeeDepartment(department);
    }
    
    public String getEmployeeDepartment() {
        return model.getEmployeeDepartment();
    }
    
    // 更新视图的方法
    public void updateView() {
        view.printEmployeeDetails(getEmployeeName(), getEmployeeId(), getEmployeeDepartment());
    }
}
~~~

* Main方法

~~~java
public class MVCMain {

    public static void main(String[] args) {
        // 根据 employee_id 从数据库中获取员工记录
        Employee model = retriveEmployeeFromDatabase();
        // 创建一个视图以在控制台上写入员工详细信息
        EmployeeView view = new EmployeeView();
        EmployeeController controller = new EmployeeController(model, view);
        controller.updateView();
        
        //更新模型数据
        controller.setEmployeeName("XinYue");
        System.out.println("\n" + "Employee Details after updating: ");
        controller.updateView();
    }
    
    private static Employee retriveEmployeeFromDatabase() {
        Employee employee = new Employee();
        employee.setEmployeeName("NaiYaZi");
        employee.setEmployeeId("7");
        employee.setEmployeeDepartment("Salesforce");
        return employee;
    }
}
~~~

*  输出：

~~~
Employee Details：
Name：NaiYaZi
Employee ID：7
Employee Department：Salesforce

Employee Details after updating: 
Employee Details：
Name：XinYue
Employee ID：7
Employee Department：Salesforce
~~~

