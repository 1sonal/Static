using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.Static1
{
    class TestStatic
    {
        static void Main(String[] args)
        {
            
            ClassStatic.num1 = 3;
            ClassStatic.num2 = 2.0f;
            Console.WriteLine(ClassStatic.Sum());
            
        }
    }
}
