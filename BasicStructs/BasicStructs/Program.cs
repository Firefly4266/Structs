using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStructs
{
    public struct addStruct
    {
        public int myNum;
        public int MyNum { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Greetings user, welcome to my program.");
            addStruct sampleStruct = new addStruct {myNum = 10};
            addClass sampleClass = new addClass {classNum = 100};
            Console.WriteLine($"\n The value of myNum from initialization is {sampleStruct.myNum}\n");
            Methods.UpdateStruct(sampleStruct.myNum);
            Console.WriteLine($"\n The current value of mynum is {sampleStruct.myNum}");
            Console.WriteLine($"\n The value of classNum from initialization is {sampleClass.classNum}\n");
            Methods.UpdateClass(sampleClass.classNum);
            Console.WriteLine($"\n The current value of classNum is {sampleClass.classNum}\n");
        }
    }
}
