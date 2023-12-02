using System;
using System.IO;

class Program
{
    static void Main()
    {
        using (StreamReader file1 = new StreamReader("f1.txt"), file2 = new StreamReader("f2.txt"))
        {
            int lineNum = 0;
            string line1, line2;
            while ((line1 = file1.ReadLine()) != null && (line2 = file2.ReadLine()) != null)
            {
                lineNum++;
                if (line1 != line2)
                {
                    Console.WriteLine($"Расхождение обнаружено в строке {lineNum}:");
                    Console.WriteLine($"Файл 1: {line1}");
                    Console.WriteLine($"Файл 2: {line2}");
                }
            }
        }
    }
}
