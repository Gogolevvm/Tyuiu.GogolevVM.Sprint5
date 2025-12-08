using System;
using System.Globalization;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GogolevVM.Sprint5.Task4.V20.Lib
{
    public class DataService : ISprint5Task4V20
    {
        public double LoadFromDataFile(string path)
        {
            // Читаем файл
            string strX = File.ReadAllText(path, Encoding.UTF8);

            // Убираем все возможные лишние символы
            strX = strX.Trim('\uFEFF', '\u200B', ' ', '\t', '\n', '\r');

            // Заменяем запятые на точки (на всякий случай)
            strX = strX.Replace(',', '.');

            // Преобразуем с инвариантной культурой
            double x = double.Parse(strX, CultureInfo.InvariantCulture);

            // Вычисляем результат
            double res = Math.Pow(((x * x) / Math.Sin(x)), 3);
            res = Math.Round(res, 3);

            return res;
        }
    }
}