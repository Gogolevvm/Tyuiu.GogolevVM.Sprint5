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

            string text = File.ReadAllText(path);
            string[] strings = text.Split(new char[] { ',' },
                                          StringSplitOptions.RemoveEmptyEntries);

            foreach (string str in strings)
            {
                string trimmedStr = str.Trim();

                if (double.TryParse(trimmedStr,
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out double number))
                {
                    // Проверка, что число целое
                    if (Math.Abs(number % 1) < 0.000001)
                    {
                        sum += number;
                        count++;
                    }
                }
            }

            return count > 0 ? sum / count : 0;
        }
    }
}
