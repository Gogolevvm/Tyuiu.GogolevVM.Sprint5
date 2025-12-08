using System;
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

            // ТОЛЬКО ЧТЕНИЕ, никакой записи!
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Trim();
                    if (string.IsNullOrEmpty(line))
                        continue;

                    // Пытаемся распарсить как целое число
                    if (int.TryParse(line, out int number))
                    {
                        sum += number;
                        count++;
                    }
                }
            }

            if (count == 0)
                return 0;

            double average = sum / count;
            return Math.Round(average, 3);
        }
    }
}