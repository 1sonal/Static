using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.Static1
{
    class StaticConstructor
    {
        static StaticConstructor()
        {
            Console.WriteLine("Instance constructor called");
        }
        public StaticConstructor()
        {
           Console.WriteLine("Instance constructor called");
        }
        public static void Display()
        {
            Console.WriteLine("Display method");
        }
        static void Main(String[] args)
        {
            // static constructor is called only once
            StaticConstructor obj1 = new StaticConstructor();
            StaticConstructor obj2 = new StaticConstructor();
            StaticConstructor.Display();
            StaticConstructor.Display();
        }
    }
}
