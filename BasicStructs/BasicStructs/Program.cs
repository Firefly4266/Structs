using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStructs
{
    public struct aNewStruct
    {
        public int x;
        public int y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Greetings user, welcome to our program.\n");
            aNewStruct newStruct = new aNewStruct(){x = 6, y = 5};
            aNewStruct swap = newStruct;
            swap.x = 5;
            swap.y = 6;
            Console.WriteLine($"\n newStruct values: x = {newStruct.x}, y = {newStruct.y}\n");
            Console.WriteLine($"\n swap values: x = {swap.x}, y = {swap.y}\n");
        }
    }
}
