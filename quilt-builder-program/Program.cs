using System;

namespace quilt_builder_program
{
    class Program
    {
        static void Main(string[] args)
        {
            //            //This  method will be able to print the original design at 1 and loops to print the line the number of times 
            //            method quiltBuilder(userInput)
            //            {
            //                for (i = 0; i < userinput; i++)
            //                {
            //                    Enqueue each variable
            //                    Push each variable                
            //{
            //                        foreach (char top in topQuilt)
            //                        {
            //                            Console Log
            //                        }
            //                    }
            //                    Int userNumber;
            //                    usersNumber = Console.ReadLine;
            //                    While(userNumber < 1 || userNumber > 10) {
            //                        Console.WriteLine “Pick a Number Between 1 - 10”
            //                    usersNumber = Console.ReadLine;
            //                    }
            //                    if (userNumber > 0 || userNumber < 11)
            //                    {
            //                        invoke quilt method();
            //                        break;
            //                    }

            // Define all variables with patterns

            int userInput = 3;

            var topBottom = "#================#";
            var lineStart = "| <>";
            var lineEnd = "<> |";
            var line1 = "<><>";
            var line2 = "....";
            var line3 = "........";
            var line4 = "............";
            var line5 = "............";
            var line6 = "........";
            var line7 = "....";
            var line8 = "<><>";

            for(int i = 0; i < userInput; i++)
            {
                Console.Write(topBottom);
            }
            Console.Write("\n" + lineStart);
            for (int i = 0; i < userInput; i++)
            {
                Console.Write(line1);
            }

            Console.Write(lineEnd);

            Console.Write("\n" + lineStart);
            for (int i = 0; i < userInput; i++)
            {
                Console.Write(line2);
            }

            Console.Write(lineEnd);

            Console.Write("\n" + lineStart);

            for (int i = 0; i < userInput; i++)
            {
                Console.Write(line3);
            }

            Console.Write(lineEnd);

            Console.Write("\n" + lineStart);

            for (int i = 0; i < userInput; i++)
            {
                Console.Write(line4);
            }

            Console.Write(lineEnd);

            Console.Write("\n" + lineStart);

            for (int i = 0; i < userInput; i++)
            {
                Console.Write(line5);
            }

            Console.Write(lineEnd);

            Console.Write("\n" + lineStart);

            for (int i = 0; i < userInput; i++)
            {
                Console.Write(line6);
            }

            Console.Write(lineEnd);

            Console.Write("\n" + lineStart);

            for (int i = 0; i < userInput; i++)
            {
                Console.Write(line7);
            }

            Console.Write(lineEnd);

            Console.Write("\n" + lineStart);

            for (int i = 0; i < userInput; i++)
            {
                Console.Write(line8);
            }

            Console.Write(lineEnd);

            Console.Write("\n");

            for (int i = 0; i < userInput; i++)
            {
                Console.Write(topBottom);
            }





        }
    }
}
