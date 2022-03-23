using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_dan_Object_taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            //set ObjProp
            Class_taxi taxi = new Class_taxi();

            //set ValueProp
            taxi.DrivName = "Frand Odi Anggoro";
            taxi.OnDuty = true;
            taxi.NumPassengger = 10;

            //calling method

            taxi.TaxiInfo();
            taxi.PickUpPassengger();
            taxi.DropOffPassengger();

            Console.ReadKey();
        }
    }
}
