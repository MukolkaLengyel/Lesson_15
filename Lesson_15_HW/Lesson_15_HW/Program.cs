using System;
using System.Threading;


namespace Lesson_15_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome into \"Voiting\" app!\n");
            Console.WriteLine("Please, write your topic for vote:");
            var optionTopic = Console.ReadLine();
            Console.WriteLine("Please, write first option for vote: ");
            var optionOne = Console.ReadLine();
            Console.WriteLine("Please, write second option for vote: ");
            var optionTwo = Console.ReadLine();
            Console.WriteLine("Please, write third option for vote: ");
            var optionThree = Console.ReadLine();
            
            Console.WriteLine($"Nice! Your Voiting \"{optionTopic}\" has started!");
            Console.WriteLine($"Please, enter '1': \"{optionOne}\", '2': \"{optionTwo}\" or '3': \"{optionThree}\" to cast your vote!");
            var input = Console.ReadLine();

            int optionOneCount = 0;
            int optionTwoCount = 0; 
            int optionThreeCount = 0;

            while (input != "")
            {
                if (input == "1")
                {
                    optionOneCount++;
                }

                else if (input == "2")
                {
                    optionTwoCount++;
                }

                else if (input == "3")
                {
                    optionThreeCount++;
                }
                
                else 
                {
                    input = Console.ReadLine();
                    Console.WriteLine("Vote has been ended! Here's result!");
                    Console.WriteLine($"{optionOne}: {optionOneCount}");
                    Console.WriteLine($"{optionTwo}: {optionTwoCount}");
                    Console.WriteLine($"{optionThree}: {optionThreeCount}");
                }

            }
        }

    }
}