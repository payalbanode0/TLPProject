using System;

namespace TPLProject
{
     class Program
    {
       public static void Main(string[]args)
        {
            Console.WriteLine("# read data from CSV & write data in CSV");
            CsvHandler.ImplementCSVDataHandling();
            Console.WriteLine();
       }
    }
}
