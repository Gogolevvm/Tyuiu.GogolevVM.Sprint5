using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        string outputFile = "OutPutFileTask3.bin";
        double x3 = 4;
        double result10 = 2 *  Math.Pow(x3, 4) - 3 * Math.Pow(x3,3) + 5 * Math.Pow(x3,2) - 6 * x3 + 1 ;
        using (BinaryWriter writer = new BinaryWriter(File.Open(outputFile,FileMode.Append)))
        {
            writer.Write(result10);
        }



    }
}