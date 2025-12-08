
namespace Tyuiu.GogolevVM.Sprint5.Task3.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Home\source\repos\Tyuiu.GogolevVM.Sprint5\Tyuiu.GogolevVM.Sprint5.Task3.V0\bin\Debug\OutPutFIleTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExcits = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExcits);

        }
    }
}
