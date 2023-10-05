using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hobbit
{
    internal class Program
    {
        delegate void RingHandler();
        static void Main(string[] args)
        {
            Hobbit frodo = new Hobbit() { Name = "Frodo", IsSichtbar = true };
            frodo.GefahrExistent += frodo.RingAufsetzen;
            frodo.GefahrVorüber += frodo.RingAbnehmen;
            frodo.leben();

            Console.Read();
        }
    }
}
