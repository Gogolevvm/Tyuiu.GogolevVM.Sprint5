using Tyuiu.GogolevVM.Sprint5.Task0.V0.Lib;
namespace Tyuiu.GogolevVM.Sprint5.Task0.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Home\source\repos\Tyuiu.GogolevVM.Sprint5\Tyuiu.GogolevVM.Sprint5.Task0.V0\bin\Debug\OutPutFileTask0.txt";
            FileInfo FileInfo = new FileInfo(path);
            bool fileExists = FileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(true, fileExists);


        }
    }
}
