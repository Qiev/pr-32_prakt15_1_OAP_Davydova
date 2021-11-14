using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace one
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int a = int.Parse(Console.ReadLine());
            Stack stack = new Stack();
            for (int i = 1; i <= a; i++)
                stack.Push(i);
            Console.WriteLine("Размерность стека " + stack.Count);

            Console.WriteLine("Верхний элемент стека = " + stack.Peek());
            Console.WriteLine("Размерность стека " + stack.Count);

            Console.Write("Содержимое стека = ");
            while (stack.Count != 0)
                Console.Write("{0} ", stack.Pop());
            Console.WriteLine("\nНовая размерность стека " + stack.Count);
            Console.ReadLine();
        }
    }
}
