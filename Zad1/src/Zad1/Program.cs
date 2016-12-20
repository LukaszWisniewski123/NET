using System;
using System.IO;
namespace Zad1
{
    public class Program
    {
        public static void Main(params string[] args) 
        {
            
            DirectoryInfo filesInformations;
            DateTime time = new DateTime();
            
            string[] fileList; 
            string directory = Directory.GetCurrentDirectory(); 

            try
            {
                Console.WriteLine("Pierwszy argument aplikajci: {0}\n\n", args[0]); 
            }
            catch(IndexOutOfRangeException)
            {
                string[] Args = Environment.GetCommandLineArgs(); 
                Console.WriteLine("Pierwszy argument aplikajci: {0}\n\n", Args[0]); 
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
                    Console.WriteLine(""+filesInformations.Name);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(" -Rozszerzenie: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("" + filesInformations.Extension);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(" -Sciezka: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("" + file);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(" -Data utworzenia: ");
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
