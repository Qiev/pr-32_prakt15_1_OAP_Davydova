using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Threading.Tasks;

namespace two
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("t.txt",true);
            string str = sr.ReadToEnd();
            sr.Close();
            Stack stack = new Stack();
            bool flag = true;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(') stack.Push(i);
                else if (str[i] == ')')
                {
                    if (stack.Count == 0)
                    { flag = false; Console.WriteLine("Возможно в позиции " + i + " лишняя скобка"); }
                    else stack.Pop();
                }
            }
            if (stack.Count == 0) { if (flag) Console.WriteLine("скобки сбалансированы"); }
            {
                Console.Write("Возможно лишняя ( скобка в позиции:");
                while (stack.Count != 0)
                {
                    Console.Write("{0} ", (int)stack.Pop());
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
