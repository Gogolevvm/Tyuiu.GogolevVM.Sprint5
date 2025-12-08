using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GogolevVM.Sprint5.Task3.V0.Lib
{
    public class DataService : ISprint5Task3V0
    {
        public string SaveToFileBinaryData(int a, int b, int c)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.bin";

            double z = ((double)a + (double)b) / (double)c;

            z = Math.Round(z,2);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(z));
            }

            return path;
        }
    }
}
