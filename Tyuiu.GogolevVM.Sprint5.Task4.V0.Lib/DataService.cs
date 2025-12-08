using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GogolevVM.Sprint5.Task4.V0.Lib
{
    public class DataService : ISprint5Task4V0
    {
        public double LoadFromDataFile(string path)
        {
            // Обработает текст с файлв (Читает текст с указанного файла)
            string strX = File.ReadAllText(path);
            // Полученные значения возводит в квадрат и округляет до 3 знаков после запятой
            double res = Math.Round(Math.Pow(Convert.ToDouble(strX), 2), 3);
            return res;
        }
    }
}
