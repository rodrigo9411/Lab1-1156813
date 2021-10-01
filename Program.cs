using System;
using System.Data;

namespace Lab_1___1156813
{
    class Program
    {
        static void Main(string[] args)
        {
            string regexp = Console.ReadLine();
            object value = new DataTable().Compute(regexp, null);
            Console.WriteLine(value.ToString());
            Parser parser = new Parser();
            parser.Parse(regexp);
            Console.WriteLine("Expresion OK");
            
            Console.ReadLine();
        }
    }
}
