using System;
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

            string text = File.ReadAllText(path);

            // Разделяем по запятым, удаляя пустые элементы
            string[] strings = text.Split(new char[] { ',' },
                                        StringSplitOptions.RemoveEmptyEntries);

            // Используем инвариантную культуру (точка как разделитель дробей)
            CultureInfo culture = CultureInfo.InvariantCulture;

            foreach (string str in strings)
            {
                string trimmedStr = str.Trim();

                // Пропускаем полностью пустые строки
                if (string.IsNullOrWhiteSpace(trimmedStr))
                    continue;

                // Пробуем преобразовать в double
                if (double.TryParse(trimmedStr,
                    NumberStyles.Float | NumberStyles.AllowThousands,
                    culture,
                    out double number))
                {
                    sum += number;
                    count++;
                }
            }

            // Если чисел не найдено - возвращаем 0
            if (count == 0)
                return 0;

            // Возвращаем среднее арифметическое
            return sum / count;
        }
    }
}