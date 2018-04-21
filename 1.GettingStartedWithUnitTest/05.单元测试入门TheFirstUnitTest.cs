//Q: 应该使用什么工具进行单元测试？
//A: 主要有三种工具：老牌的NUnit，微软的MSTest和xUnit。个人建议使用NUnit，但是本篇以VS自带的MSTest开始，在后面的章节引入NUnit。

//Q: 如何使用MSTest进行单元测试？
//A: 单元测试的对象为类中的方法执行单元测试跟随以下步骤：
    //1.新建测试类；
    //2.梳理受测方法的逻辑、输入情景和期望输出；
    //3.以输入情景为单位，在测试类中为每一种情景建立一个测试方法；
    //4.点击测试 => 运行 => 所有测试，进行测试；
    //5.在测试浏览器中观察测试结果。

//Q: 如何新建测试类？
//A: 正如之前所说，使用单元测试的项目由两部分组成，一个是产品代码，一个是测试代码。首先为解决方案新增一个测试项目。
  //右键解决方案浏览器中的解决方案，选择添加一个Unit Test Project，默认自带一个测试类文件如下：

    [TestClass]   //测试特性，运行测试时被该特性标记的类会执行测试
    public class UnitTest1
    {
        private TestContext testContextInstance;

        [TestMethod]    //测试特性，在测试类下的测试方法将会执行测试
        public void TestMethod1()
        {
            //
            // TODO: Add test logic here
            //
        }
    }//只有被测试特性标记的类、方法才会执行测试。

  //测试类命名约定为[受测类名]+Tests

//Q: 如何梳理受测类的逻辑、输入情景和期望输出？
//A: 这一步是为了确认受测类的功能。假设有如下类：

    public class Reservation
    {
        public User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            return (user.IsAdmin || MadeBy == user);
        }
    }

  //这个类只有一个CanBeCancelledBy()方法，一个方法就是一个单元，针对这个方法可以写一个单元测试。
  




