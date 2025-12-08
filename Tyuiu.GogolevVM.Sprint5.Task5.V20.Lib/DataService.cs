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

            // Читаем все строки файла
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string trimmedLine = line.Trim();

                // Пропускаем пустые строки
                if (string.IsNullOrWhiteSpace(trimmedLine))
                    continue;

                // Пробуем распарсить как целое число
                if (int.TryParse(trimmedLine, out int intNumber))
                {
                    // Это целое число
                    sum += intNumber;
                    count++;
                }
                else
                {
                    // Пробуем как double, чтобы проверить, не дробное ли это число
                    if (double.TryParse(trimmedLine,
                        NumberStyles.Float | NumberStyles.AllowLeadingSign,
                        CultureInfo.InvariantCulture,
                        out double doubleNumber))
                    {
                        // Проверяем, целое ли число (с учетом погрешности округления)
                        if (Math.Abs(doubleNumber % 1) < 0.0000001)
                        {
                            sum += doubleNumber;
                            count++;
                        }
                    }
                }
            }

            // Если целых чисел не найдено, возвращаем 0
            if (count == 0)
                return 0;

            // Вычисляем среднее
            double average = sum / count;

            // Округляем до 3 знаков после запятой
            average = Math.Round(average, 3, MidpointRounding.AwayFromZero);

            return average;
        }
    }
}