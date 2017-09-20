using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStructs
{
    class Program
    {
        public struct aNewStruct
        {
            public int one;
            public void UpdateStruct(aNewStruct value)
            {
                value.one = 2;
                Console.WriteLine($"\n The new value is {value.one}.\n");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n Greetings user, welcome to our program.\n");
            aNewStruct num = new aNewStruct() {one = 1 };
            Console.WriteLine($"\n The present value of one is {num.one}\n");
            num.UpdateStruct(num);
            Console.WriteLine($"\n The present value of one is {num.one}\n");
        }
    }
}
