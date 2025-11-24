using Tyuiu.GogolevVM.Sprint5.Task1.V0.Lib;
namespace Tyuiu.GogolevVM.Sprint5.Task1.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Home\source\repos\Tyuiu.GogolevVM.Sprint5\Tyuiu.GogolevVM.Sprint5.Task1.V0\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;

            bool wait = true;

            Assert.AreEqual(true, fileExists);

;
        }
    }
}
