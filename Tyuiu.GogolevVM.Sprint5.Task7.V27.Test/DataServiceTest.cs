using Tyuiu.GogolevVM.Sprint5.Task7.V27.Lib;
namespace Tyuiu.GogolevVM.Sprint5.Task7.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask7V27.txt";
            string pathSaveFile = ds.LoadDataAndSave(path);
            FileInfo file = new FileInfo(pathSaveFile);
            bool fileExists = file.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
