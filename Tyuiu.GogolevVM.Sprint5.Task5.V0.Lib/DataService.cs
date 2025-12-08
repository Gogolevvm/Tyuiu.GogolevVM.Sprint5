using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GogolevVM.Sprint5.Task5.V0.Lib
{
    public class DataService : ISprint5Task5V0
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            // потоковый способ чтение набора с файла (позволяет открыть файл, затем закрыть файл)
            using (StreamReader reader = new StreamReader(path))
            {
                // Будем помещать необходимые данные в string line.
                string line;
                // построчно считывает данные с файла (пока не конец файла, читаем построчно)
                while ((line = reader.ReadLine()) != null)
                {
                    // условие while
                    res = res + Convert.ToDouble(line);
                }
            }
            return res;
        }
    }
}
