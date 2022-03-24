using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_dan_Object_taxi
{
    class Class_taxi
    {
        //set prop
        public string DrivName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassengger { get; set; }

        //set method
        public void TaxiInfo() //information about driver
        {
            Console.WriteLine("Driver Name  : {0}", DrivName);
            if (OnDuty == true) Console.WriteLine("On Duty  : Yes");
                else Console.WriteLine("On Duty     : No");
            Console.WriteLine("Number of Passengger : {0}", NumPassengger);
        }
        //information about driver statues
        public void PickUpPassengger()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0} sedang menjemput penumpang",DrivName);
        }
        public void DropOffPassengger()
        {
            Console.WriteLine("{0} sudah mengantar penumpang", DrivName);
        }
    }

}
