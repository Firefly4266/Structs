using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStructs
{
    class Methods
    {
        public static void UpdateStruct(int myNum)
        {
            myNum++;
            Console.WriteLine($"\n The value of myNum from the Update method is {myNum}\n");
        }
        public static void UpdateClass(int num)
        {
            num++;
            Console.WriteLine($"\n The value of classNum from the Update method is {num}\n");
        }
    }
}
