using BuildCustomTask;
using Microsoft.Build.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BuildCustomTaskTest
{
    [TestClass]
    public class MyCustomBuildTaskTest
    {
        [TestMethod]
        public void RunCustomBuildTaskTest()
        {
            var task = new MyCustomBuildTask();
            task.BuildEngine = new Mock<IBuildEngine>().Object;
            var result = task.Execute();

            Assert.IsTrue(result);
        }
    }
}
