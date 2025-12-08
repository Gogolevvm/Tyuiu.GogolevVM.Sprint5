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
            string text = File.ReadAllText(path);

            // Заменяем возможные запятые-разделители дробей на точки
            string normalizedText = text.Replace(',', '.');

            // Разделяем по запятым (как разделителям элементов)
            string[] parts = normalizedText.Split(new char[] { ',' },
                                                 StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;
            int count = 0;

            foreach (string part in parts)
            {
                string trimmed = part.Trim();
                if (double.TryParse(trimmed,
                    NumberStyles.Any,
                    CultureInfo.InvariantCulture,
                    out double number))
                {
                    sum += number;
                    count++;
                }
            }

            return count > 0 ? sum / count : 0;
        }
    }
}