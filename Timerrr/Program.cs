using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timerrr
{
    internal class Program
    {
        static void Main(string[] args)
 {
            Console.Write("введите часы: "); 
            int hours = int.Parse(Console.ReadLine()); 

            Console.Write("введите минуты: ");
            int minutes = int.Parse(Console.ReadLine());

            Console.Write("введите секунды: ");
            int seconds = int.Parse(Console.ReadLine());

            Timer timer = new Timer(hours, minutes, seconds); 
            timer.Start(); 
            Console.ReadKey(); 

        }
    }
}
