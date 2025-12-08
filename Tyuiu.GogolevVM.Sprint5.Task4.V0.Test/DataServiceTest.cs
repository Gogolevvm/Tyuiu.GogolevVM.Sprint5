namespace Tyuiu.GogolevVM.Sprint5.Task4.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Создаём путь к файлу
            string path = @"C:\Users\Home\source\repos\Tyuiu.GogolevVM.Sprint5\Tyuiu.GogolevVM.Sprint5.Task4.V0\bin\Debug\InPutFileTask4.txt";
            // Собираем информацию о файле
            FileInfo fileinfo = new FileInfo(path);
            // Проверяет наличие файла
            bool FileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, FileExists);
        }
    }
}
