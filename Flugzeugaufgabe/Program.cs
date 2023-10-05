using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flugzeugaufgabe
{
    internal class Program
    {
        static void Main(string[] args)
        {         
                Flugzeug flugzeug = new Flugzeug();
                flugzeug.OelDruckMesser += flugzeug.OnEventEintritt;
                flugzeug.FliegHerum();
        }
        

    }
    public enum Schalter { EIN, AUS };

    public class Bordbuch
    {
        public string Titel { get; set; }
    }
    public class MeineTransportklasse : EventArgs
    {
        public Bordbuch bordbuch { get; set; }
    }
}
