using System;
using System.Data;

namespace Lab_1___1156813
{
    class Program
    {
        static void Main(string[] args)
        {
            string regexp = Console.ReadLine();
            //Parse the expression
            Parser parser = new Parser();
            parser.Parse(regexp);
            Console.WriteLine("Expresion OK");
            //If it's valid then solve the arithmetic expression by using DataTable Compute
            object value = new DataTable().Compute(regexp, null);
            Console.WriteLine(value.ToString());
            
            Console.ReadLine();
        }
    }
}
