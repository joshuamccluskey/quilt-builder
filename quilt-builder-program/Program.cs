using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace quilt_builder_program
{
    class Program
    {


        static void Main(string[] args)
        {

            var space = " ";
            var pipe = "|";
            var nBreak = "\n";
            var newLine = nBreak + pipe;
            var brackets = "<>";
            var topBottom = "#================#";
            var dot = ".";
            string userInput;


            Stack<string> quiltStack = new Stack<string>();
            Console.WriteLine("Welcome to Tina\'s Quilts! I'm glad you're here!");

            Console.Write(nBreak);

            Console.Write("What size quilt would you like");

            Console.Write(nBreak);

            userInput = Console.ReadLine();

            while (userInput.All(char.IsDigit) == false) {
                Console.WriteLine("Pick a number!");
                userInput = Console.ReadLine();
            };

            int userNum = Convert.ToInt32(userInput);

            try
            {
                while (userNum < 1)
                {
                Console.WriteLine("Pick a number greater than 0!");
                userInput = Console.ReadLine();
                userNum = Convert.ToInt32(userInput);

                if (userNum > 0 || userNum < 11)
                {

                }
            }

            }catch (FormatException e)
            {
                Console.WriteLine("Pick a number!", e);
                userInput = Console.ReadLine();
                while (userInput.All(char.IsDigit) == false)
                {
                    Console.WriteLine("Pick a number greater than 0!");
                    userInput = Console.ReadLine();
                };

                userNum = Convert.ToInt32(userInput);
                while (userNum < 1)
                {
                    Console.WriteLine("Pick a number greater than 0!");
                    userInput = Console.ReadLine();
                    userNum = Convert.ToInt32(userInput);

                    if (userNum > 0 || userNum < 11)
                    {

                    }
                }
            }


            Console.Write(nBreak);

            Console.Write("Sure! Coming right up...");


            Console.Write(nBreak);

            //////////////////////////// Line 1 //////////////////////////////


            for (int i = 0; i < userNum; i++)
            {
                quiltStack.Push(topBottom);
                Console.Write(topBottom);

            }
            quiltStack.Push(nBreak);
            Console.Write(nBreak);
            quiltStack.Push(pipe);
            Console.Write(pipe);
            for (int i = 0; i < userNum * (1 * -2 + 8); i++)
            {
                quiltStack.Push(space);
                Console.Write(space);
            }

            
            for (int i = 0; i < userNum; i++)
            {
                quiltStack.Push(brackets);
                Console.Write(brackets);
                quiltStack.Push(brackets);
                Console.Write(brackets);
            }

            for (int i = 0; i < userNum * (1 * -2 + 8); i++)
            {
                quiltStack.Push(space);
                Console.Write(space);
            }
            quiltStack.Push(pipe);
            Console.Write(pipe);
            quiltStack.Push(nBreak);

            //////////////////////////// Line 2 //////////////////////////////

            Console.Write(nBreak);
            quiltStack.Push(pipe);
            Console.Write(pipe);
            for (int i = 0; i < userNum * ( 2 * -2 + 8); i++)
            {
                quiltStack.Push(space);
                Console.Write(space);
            }
            quiltStack.Push(brackets);
            Console.Write(brackets);
            for (int i = 0; i < userNum * (4 * 2 - 4); i++)
            {
                quiltStack.Push(dot);
                Console.Write(dot);

            }
            quiltStack.Push(brackets);
            Console.Write(brackets);

            for (int i = 0; i < userNum * (2 * -2 + 8); i++)
            {
                quiltStack.Push(space);
                Console.Write(space);
            }

            quiltStack.Push(pipe);
            Console.Write(pipe);
            quiltStack.Push(nBreak);



            //////////////////////////// Line 3 //////////////////////////////

            Console.Write(nBreak);
            quiltStack.Push(pipe);
            Console.Write(pipe);
            for (int i = 0; i < userNum * (3 * -2 + 8); i++)
            {
                quiltStack.Push(space);
                Console.Write(space);
            }
            quiltStack.Push(brackets);
            Console.Write(brackets);
            for (int i = 0; i < userNum * (4 * 3 - 4); i++)
            {
                quiltStack.Push(dot);
                Console.Write(dot);

            }
            quiltStack.Push(brackets);
            Console.Write(brackets);

            for (int i = 0; i < userNum * (3 * -2 + 8); i++)
            {
                quiltStack.Push(space);
                Console.Write(space);
            }

            quiltStack.Push(pipe);
            Console.Write(pipe);
            quiltStack.Push(nBreak);

            //////////////////////////// Line 4 //////////////////////////////

            Console.Write(nBreak);
            quiltStack.Push(pipe);
            Console.Write(pipe);
            for (int i = 0; i < userNum * (4 * -2 + 8); i++)
            {
                quiltStack.Push(space);
                Console.Write(space);
            }
            quiltStack.Push(brackets);
            Console.Write(brackets);
            for (int i = 0; i < userNum * (4 * 4 - 4); i++)
            {
                quiltStack.Push(dot);
                Console.Write(dot);

            }
            quiltStack.Push(brackets);
            Console.Write(brackets);

            for (int i = 0; i < userNum * (4 * -2 + 8); i++)
            {
                quiltStack.Push(space);
                Console.Write(space);
            }

            quiltStack.Push(pipe);
            Console.Write(pipe);
            quiltStack.Push(nBreak);

            //////////////////////////// Pop Stack ////////////////////////////
            while (quiltStack.Count > 0)
                

                Console.Write(quiltStack.Pop());
            Console.ReadKey();
        }
    }
}
