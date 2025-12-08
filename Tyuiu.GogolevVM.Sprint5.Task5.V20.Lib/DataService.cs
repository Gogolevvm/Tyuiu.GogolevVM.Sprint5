using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GogolevVM.Sprint5.Task5.V20.Lib
{
    public class DataService : ISprint5Task5V20
    {
        public double LoadFromDataFile(string path)
        {
            double sum = 0;
            int count = 0;

            // Читаем весь файл
            string text = File.ReadAllText(path);

            // Разделяем по запятым (может быть одна строка: "1, 2, 3.25, 4, 5")
            string[] numbers = text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            // Используем инвариантную культуру для парсинга
            CultureInfo culture = CultureInfo.InvariantCulture;

            foreach (string numStr in numbers)
            {
                string trimmed = numStr.Trim();

                // Пробуем распарсить как double (и целые, и дробные)
                if (double.TryParse(trimmed, NumberStyles.Any, culture, out double number))
                {
                    sum += number;
                    count++;
                }
            }

            // Если чисел нет - возвращаем 0 вместо NaN
            if (count == 0)
                return 0;

            // Вычисляем среднее
            double average = sum / count;

            // Округляем до 3 знаков
            average = Math.Round(average, 3);

            return average;
        }
    }
}
