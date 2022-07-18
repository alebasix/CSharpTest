using System;
using System.Globalization;

namespace HelloWorld
{
    class MainClass
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            double number = double.Parse(str, CultureInfo.InvariantCulture);
             
            Console.WriteLine(number + 1);
        
        }  
    }
}