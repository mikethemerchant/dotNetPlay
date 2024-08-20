using System;
using System.IO;
using System.Text;

class Program
{
        static void Main()
        {
            string folderPath = @"C:\Temp\Tow Reports";
            var csv = new StringBuilder();
            string filePath = @"C:\Temp\list.csv";
            

            string[] files = Directory.GetFiles(folderPath, "*", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                csv.AppendLine(file);
            }

            File.WriteAllText(filePath, csv.ToString());

            Console.WriteLine("done");
        }
    
}