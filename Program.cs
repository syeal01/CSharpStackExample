// Coded by: Aliabbas Syed

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<string> stack = new Stack<string>();
            stack.Push("Pushed 1");
            stack.Push("Pushed 2");
            stack.Push("Pushed 3");

            foreach (var item in stack)
                Console.WriteLine(item);

            Console.WriteLine("----------");

            try
            {
                stack.Pop();
                stack.Pop();
                stack.Pop();

                // Add another Pop() to catch exception
                // stack.Pop();

                foreach (var item in stack)
                    Console.WriteLine(item);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Stack is empty");
            }
            finally
            {
                Console.WriteLine("stack done");
            }
        }
    }
}
