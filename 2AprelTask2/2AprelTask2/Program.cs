using System;
using ClassLibrary;
namespace _2AprelTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Write your name");
                string fullName = Console.ReadLine();

                Console.WriteLine("Write your age ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Write your GroupNo");
                string groupNo = Console.ReadLine();
 
            Student studentOne = new Student(fullName, age, groupNo);

            while (true)
            {
                if (fullName.CheckFullName() == false)
                {
                    Console.WriteLine("Write your Fullname is not true:");
                    fullName = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            while (true)
            {
                if (groupNo.CheckGroupNoo() == false )
                {
                    Console.WriteLine("Write your GroupNois not true:");
                    groupNo = Console.ReadLine();
                }
                else
                {
                    break;
                    
                }
            }

           
            Console.WriteLine($"Student fullname is-{fullName} GroupNo-{groupNo} Age-{age}");





        }
    }
}
