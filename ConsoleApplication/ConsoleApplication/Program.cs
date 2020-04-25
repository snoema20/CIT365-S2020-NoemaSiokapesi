using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My name is Pesi + And I am from Seattle!");
            string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
            Console.WriteLine("The current date is {0}", date);
           
         
        }
       
    }
}
