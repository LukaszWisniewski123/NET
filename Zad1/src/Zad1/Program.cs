using System;
using System.IO;
namespace Zad1
{
    public class Program
    {
        static void Main(string[] args) 
        {
            DirectoryInfo filesInformations;
            DateTime time = new DateTime();

            string[] fileList;
            string directory = "";

            try
            {
                directory = Path.GetDirectoryName(args[0]);
                Console.WriteLine("katalog args[0] {0}\n\n", directory);
            }
            catch (IndexOutOfRangeException)
            {
                args = Environment.GetCommandLineArgs();
                directory = Path.GetDirectoryName(args[0]);
                Console.WriteLine("katalog args[0] {0}\n\n", directory);
            }

            if (Directory.Exists(directory))
            {
                Console.WriteLine("Katalog istnieje");
                fileList = Directory.GetFiles(directory);

                foreach (string file in fileList)
                {
                    filesInformations = new DirectoryInfo(file);
                    time = filesInformations.CreationTime;
                    time.ToLocalTime();
                    Console.Write("+Nazwa pliku: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("" + filesInformations.Name);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("--Rozszerzenie: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("*" + filesInformations.Extension);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("--Sciezka: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("" + file);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("--Data utworzenia: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("" + time);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            else
                Console.WriteLine("katalog nie istnieje.");
        }
    }
}
