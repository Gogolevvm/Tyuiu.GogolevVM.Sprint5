namespace Tyuiu.GogolevVM.Sprint5.Task5.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V20.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileexits = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileexits);
        }
    }
}
