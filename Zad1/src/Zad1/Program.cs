using System;
using System.IO;
namespace Zad1
{
    public class Program
    {
        public static void Main(string[] Args) 
        {
            DirectoryInfo filesInformations;
            DateTime time = new DateTime();

            string[] fileList; //utworzenie tablicy w której będzie przechowywana lista plików w katalogu. 
            string directory = Directory.GetCurrentDirectory(); //pobranie katalogu w którym znajduje się aplikacja. 

            try
            {
                Console.WriteLine("Pierwsyz argument aplikajci: {0}\n\n", Args[0]); //Wyświetlenie pierwsego argumentu z konsoli 
            }
            catch(IndexOutOfRangeException)
            {
                string[] args = Environment.GetCommandLineArgs(); //pobranie argumentów konsoli. 
                Console.WriteLine("Pierwsyz argument aplikajci: {0}\n\n", args[0]); //Wyświetlenie pierwsego argumentu z konsoli \
            }
            
            if (Directory.Exists(directory)) //sprawdzanie czy katalog istnieje, jeśli istnieje wyświetlenie zawartości katalogu. 
            {
                Console.WriteLine("Katalog istnieje");
                fileList = Directory.GetFiles(directory); //Pobranie listy plików.  
               
                foreach (string file in fileList)
                {   
                    filesInformations = new DirectoryInfo(file); //obiekt klasy DirectoryInfo - do pobrania informacji o ppliku. 
                    time = filesInformations.CreationTime;
                    time.ToLocalTime();
                    Console.Write("+Nazwa pliku: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(""+filesInformations.Name);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(" -Rozszrzenie: ");
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
                Console.WriteLine("katalog nieistnieje.");
        }
    }
}
