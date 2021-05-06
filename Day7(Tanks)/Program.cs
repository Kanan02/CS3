using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib.WordOfTanks;
namespace Day7_Tanks_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "WordOfTanks";
            
            Tank[] tanks1 = new Tank[5]
            {
                new Tank("T-34"),
                new Tank("T-34"),
                new Tank("T-34"),
                new Tank("T-34"),
                new Tank("T-34")
            };
            Tank[] tanks2 = new Tank[5]
             {
                new Tank("Pantera"),
                new Tank("Pantera"),
                new Tank("Pantera"),
                new Tank("Pantera"),
                new Tank("Pantera")
             };
            
            for (int i = 0; i < tanks1.Length; i++)
            {
                Console.WriteLine(tanks1[i]*tanks2[i]);
            }
        }
    }
}
