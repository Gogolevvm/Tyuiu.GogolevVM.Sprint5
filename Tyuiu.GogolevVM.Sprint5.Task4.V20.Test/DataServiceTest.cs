namespace Tyuiu.GogolevVM.Sprint5.Task4.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V0.txt";
            FileInfo file = new FileInfo(path);
            bool fileExits = file.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExits);
        }
    }
}
