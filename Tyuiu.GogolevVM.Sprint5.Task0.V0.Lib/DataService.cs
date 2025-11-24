using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.GogolevVM.Sprint5.Task0.V0.Lib
{
    public class DataService : ISprint5Task0V0
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double z = ((double)x);
            z = Math.Round(z,2);
            File.WriteAllText(path,Convert.ToString(z));
            return path;
        }
    }
}
