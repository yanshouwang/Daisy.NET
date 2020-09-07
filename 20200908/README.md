### 表达式定义

- 什么是表达式
    - Experessions, together with commands and declarations, are one of the basic components of every programming language. We can say that expressions are the essential component of every language.
    - An expressions is a syntactic entity whose evaluation either produces a value or fails to terminate, in which case the expression is undefined.
    - 各种编程语言对表达式的实现不尽相同，但大体上都符合这个定义
- C# 语言对表达式的定义
    - An expression is a sequence of one or more operands and zero or more operators that can be evaluated to a single value, object, method or namespace. Expressions can consist of a literal value, a method invocation, an operator and it's operands, or a simple name. Simple names can be the name of a variable, type member, method parameter, namespace or type.
    - 算法逻辑的最基本（最小）单元，表达一定的算法意图
    - 因为操作符有优先级，所以表达式也有了优先级

### 各类表达式概览

- C# 语言中表达式的分类
    - A value.
    - A variable.
    - A namespace.
    - A type.
    - A method group.
    - A null literal.
    - An anonymous function.
    - A property access.
    - An event access.
    - An indexer access.
    - Nothing
- 复合表达式的求值
    - 注意操作符的优先级和同优先级操作符的运算方向
- 参考 C# 语言定义文档
    - 仅作参考，不必深究
        
### 语句的定义

- Wikipedia 对语句的定义
    - In computer programming a statement is the smallest standalone element of an imperative programming language which expresses some action to be carried out. A program written in such a language is formed by a sequence of one or more statements. A statement will have internal components(e.g., expressions).
    - 语句是高级语言的语法 —— 编译语言和机器语言只有指令（高级语言中的表达式对应低级语言中的指令），语句等价于一个或一组有明显逻辑关联的指令。举例：求圆柱体积。
- C# 语言对语句的定义
    - The actions that a program takes are expressed in statements. Common actions include declaring variables, assigning values, calling methods, looping through collections, and branching to one or another block of code, depending on a given condition. The order in which statements are executed in a program is called the flow of control or flow of execution. The flow of control may vary every time that a program is run, depending on how the program reacts to input that it receives at runtime.
    - C# 语言的语句除了能够让程序员“顺序地”表达算法思想，还能通过条件判断、跳转和循环等方法控制程序逻辑的走向
    - 简而言之就是：陈述算法思想，控制逻辑走向，完成有意义的动作
    - C# 语言的语句有分号结尾，但由分号结尾的不一定都是语句
    - 语句一定是出现在方法体里

### 语句详解

- 声明语句
- 表达式语句
- 块语句（变量的作用域）
- 选择（判断、分支）语句
- 迭代（循环）语句
- 跳转语句（尽早return）
- try...catch...finally 语句
- using 语句
- yield 语句
- checked / unchecked 语句
- lock 语句
- 标签语句
- 空语句