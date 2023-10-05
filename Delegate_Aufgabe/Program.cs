using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Aufgabe
{
    delegate double Calculate(double x, double y);
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate calk;

            calk = new Calculate(Methoden.Division);

            calk(8, 4);

            Console.WriteLine(calk);
            Console.ReadLine();
        }
    }
}
