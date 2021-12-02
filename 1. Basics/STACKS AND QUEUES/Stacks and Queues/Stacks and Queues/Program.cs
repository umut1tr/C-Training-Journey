using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            //defining a new stack
            Stack<int> stack = new Stack<int>();

            //add elements to the stack using Push()
            //peek() will return the element at the top of the stack without removing it
            
            

            stack.Push(1);
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());
            stack.Push(2);
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());
            stack.Push(3);                     
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());

            while (stack.Count > 0)
            {
                Console.WriteLine("Popping value {0}" , stack.Pop());
                             
            }
            Console.WriteLine("POPPED ALL ITEMS");
                      

            int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2 };
            List<int> numbersReversed = new List<int>();
            //defining a new stack of int
            Stack<int> myStack = new Stack<int>();


            Console.WriteLine("The numbers in the array are: ");
            foreach (int number in numbers)
            {
                // print it 
                Console.Write(number + " ");
                // push it into our stack(add)
                myStack.Push(number);
            }

            Console.WriteLine("");
            Console.WriteLine("The numbers in reverse : ");
            while(myStack.Count > 0)
            {
                // pop it and store it in a variable
                int number = myStack.Pop();
                // print the value we popped
                Console.Write(number + " ");
                numbersReversed.Add(number);                
                                               
            }
            Console.WriteLine();
            Console.WriteLine("_____________________");

           foreach(int number in numbersReversed)
            {
                Console.Write(number);
            }

            Console.ReadLine();

        }
    }
}
