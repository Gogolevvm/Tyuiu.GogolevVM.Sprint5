using System.Reflection.PortableExecutable;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GogolevVM.Sprint5.Task5.V20.Lib
{
    public class DataService : ISprint5Task5V20
    {
        public double LoadFromDataFile(string path)
        {
            int count = 0;
            double res = 0;

            string text = File.ReadAllText(path);

            string[] strings = text.Split(' ');
            List<string> wholeNumbers = new List<string>();
            foreach (string str in strings)
            {
                if (int.TryParse(str.Trim(), out int number) && Math.Abs(number % 1) == 0)
                {

                    wholeNumbers.Add(str);
                    count++;
                }
            }
            File.WriteAllLines(path, wholeNumbers);

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (int.TryParse(line.Trim(), out int number) && Math.Abs(number%1) == 0)
                    {
                        // условие while
                        res = res + Convert.ToDouble(line);
                        count++;
                    }

                    
                }
            }
            res = res / count;
            res = Math.Round(res,3);
            return res;
            


        }
    }
}
