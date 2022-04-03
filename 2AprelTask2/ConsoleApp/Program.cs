using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            if (name.Split(" ").Length == 2 )
            {        
                Console.WriteLine(name[1]);
            }
            
        }
    }
}
