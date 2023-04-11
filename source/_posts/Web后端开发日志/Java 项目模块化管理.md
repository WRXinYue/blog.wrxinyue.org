---
title: Java 项目模块化管理
date: 2023-4-4 19:50:16
updated: 2023-4-4 19:50:16
categories: 
- WEBbackend
tags: 
- java
---


## 父项目


## 子模块 

Git 子模块是一种特殊的 Git 仓库，它保存在主项目中的一个独立目录中。当您使用 `git submodule add` 命令添加一个子模块时，Git 会在主项目的 .gitmodules 文件中添加一个条目，用于记录子模块的 Git URL 和保存位置等信息。同时，Git 会将子模块的代码克隆到主项目的子目录中，这个子目录就是您指定的子模块保存位置。

因此，当您执行 Git 命令时，应该在主项目目录中执行命令，而不是在子模块目录或 .git 目录中执行。如果您需要在子模块中执行 Git 命令，可以使用 `cd` 命令切换到子模块目录中。

例如，如果您需要更新子模块的代码，可以按照以下步骤执行 Git 命令：

1.  切换到主项目目录中： `cd /path/to/main/project`
2.  初始化子模块： `git submodule init`
3.  拉取子模块的最新代码： `git submodule update`
4.  切换到子模块目录中： `cd path/to/submodule`
5.  在子模块目录中执行 Git 命令，例如： `git pull` 更新子模块的代码。

请注意，在使用 Git 子模块时，您需要额外注意子模块的版本控制。如果您更新了子模块的代码，您需要提交子模块的变更，并在主项目中提交对子模块的更新。


### 更新全部子模块

```bash
git submodule update --init --recursive
```


### 更新指定子模块

**更新单个子模块：如果您只想更新一个子模块，可以指定子模块的路径，例如：

-   `git submodule update --init path/to/submodule`
    
    在这个命令中，`path/to/submodule` 是要更新的子模块的路径。Git 将拉取该子模块的最新代码，并将其更新为子模块仓库中的默认分支或提交。
    
-   更新所有子模块中的特定分支：如果您希望更新所有子模块到一个特定的分支，可以使用 `--remote` 选项来拉取最新的远程分支代码，例如：

1.  `git submodule update --remote`
    
    在这个命令中，`--remote` 选项告诉 Git 拉取子模块的最新远程代码，而不是使用子模块仓库中的默认分支或提交。这将使得所有子模块更新到最新的远程分支代码。
    

请注意，在使用这些命令时，您需要在主项目中运行 Git 命令，并在执行命令前，确保您已经初始化了子模块。否则，命令将无法更新子模块。


### 父项目启动子项目

默认情况下，父项目启动时，子项目不会自动启动。子项目和父项目是两个独立的 Java 项目，需要分别进行构建和启动。然而，您可以使用 Maven 或其他构建工具来自动化这个过程，使得父项目能够启动子项目。

如果您使用 Maven 进行构建和依赖管理，可以将子项目作为父项目的子模块，并使用 Maven 的插件来自动化子项目的构建和部署。以下是一些常见的用例：

1.  在父项目的 pom.xml 文件中添加子模块依赖：

```xml
<modules>
  <module>submodule1</module>
  <module>submodule2</module>
  ...
</modules>
```

    在这个例子中，我们将子模块 submodule1 和 submodule2 添加为父项目的子模块。这将使 Maven 在构建父项目时，自动构建和打包子模块，并将其包含在父项目的 JAR 或 WAR 文件中。

-   在父项目的 pom.xml 文件中添加子模块构建插件：

```xml
<build>
  <plugins>
    <plugin>
      <groupId>org.apache.maven.plugins</groupId>
      <artifactId>maven-ejb-plugin</artifactId>
      <version>2.3</version>
      <executions>
        <execution>
          <id>ejb</id>
          <phase>package</phase>
          <goals>
            <goal>ejb</goal>
          </goals>
        </execution>
      </executions>
    </plugin>
    ...
  </plugins>
</build>
```

    在这个例子中，我们添加了一个 EJB 插件，用于构建子模块中的 EJB 代码。当父项目构建时，该插件将自动构建子模块，并将生成的 EJB JAR 文件包含在父项目的 WAR 文件中。

请注意，子模块和父项目是两个独立的 Java 项目，它们需要分别进行构建和部署。如果您使用 Maven 等构建工具，可以使用上述方法来自动化这个过程，以便父项目能够启动子项目。另外，如果您使用 Spring Boot 等框架，您可以使用 Spring Boot 的依赖管理和自动配置功能来管理子项目和父项目之间的依赖关系，并使得父项目能够启动子项目。
 
#### 详细教程：

https://iphysresearch.github.io/blog/post/programing/git/git_submodule/