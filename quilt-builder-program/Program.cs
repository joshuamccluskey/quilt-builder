using System;
using System.Collections;
using System.Collections.Generic;

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

            int userInput = 1
                ;

            Stack<string> quiltStack = new Stack<string>();

            var space = " ";
            var pipe = "|";
            var nBreak = "\n";
            var newLine = nBreak + pipe;
            var brackets = "<>";
            var topBottom = "#================#";
            var line2 = "....";
            var line3 = "........";
            var line4 = "............";



            //Line 1


            
            for (int i = 0; i < userInput; i++)
            {
                quiltStack.Push(topBottom);
                Console.Write(topBottom);
                
            }
            quiltStack.Push(nBreak);
            Console.Write(nBreak);
            quiltStack.Push(pipe);
            Console.Write(pipe);
            for (int i = 0; i < userInput * 6; i++)
            {
                quiltStack.Push(space);
                Console.Write(space);
            }

            
            for (int i = 0; i < userInput; i++)
            {
                quiltStack.Push(brackets);
                Console.Write(brackets);
                quiltStack.Push(brackets);
                Console.Write(brackets);
            }

            for (int i = 0; i < userInput * 6; i++)
            {
                quiltStack.Push(space);
                Console.Write(space);
            }
            quiltStack.Push(pipe);
            Console.Write(pipe);
            quiltStack.Push(nBreak);

            //Line 2
            
            Console.Write(nBreak);
            quiltStack.Push(pipe);
            Console.Write(pipe);
            for (int i = 0; i < userInput * 4; i++)
            {
                quiltStack.Push(space);
                Console.Write(space);
            }
            quiltStack.Push(brackets);
            Console.Write(brackets);
            for (int i = 0; i < userInput; i++)
            {
                quiltStack.Push(line2);
                Console.Write(line2);

            }
            quiltStack.Push(brackets);
            Console.Write(brackets);

            for (int i = 0; i < userInput * 4; i++)
            {
                quiltStack.Push(space);
                Console.Write(space);
            }

            quiltStack.Push(pipe);
            Console.Write(pipe);
            quiltStack.Push(nBreak);



            // Line 3

            Console.Write(nBreak);
            quiltStack.Push(pipe);
            Console.Write(pipe);
            for (int i = 0; i < userInput * 2; i++)
            {
                quiltStack.Push(space);
                Console.Write(space);
            }
            quiltStack.Push(brackets);
            Console.Write(brackets);
            for (int i = 0; i < userInput; i++)
            {
                quiltStack.Push(line3);
                Console.Write(line3);

            }
            quiltStack.Push(brackets);
            Console.Write(brackets);

            for (int i = 0; i < userInput * 2; i++)
            {
                quiltStack.Push(space);
                Console.Write(space);
            }

            quiltStack.Push(pipe);
            Console.Write(pipe);
            quiltStack.Push(nBreak);

            // Line 4
            
            Console.Write(nBreak);
            quiltStack.Push(pipe);
            Console.Write(pipe);
            for (int i = 0; i < userInput * 0; i++)
            {
                quiltStack.Push(space);
                Console.Write(space);
            }
            quiltStack.Push(brackets);
            Console.Write(brackets);
            for (int i = 0; i < userInput; i++)
            {
                quiltStack.Push(line4);
                Console.Write(line4);

            }
            quiltStack.Push(brackets);
            Console.Write(brackets);

            for (int i = 0; i < userInput * 0; i++)
            {
                quiltStack.Push(space);
                Console.Write(space);
            }

            quiltStack.Push(pipe);
            Console.Write(pipe);
            quiltStack.Push(nBreak);

            while (quiltStack.Count > 0)
                

                Console.Write(quiltStack.Pop());

        }
    }
}
