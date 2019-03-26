using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    class Taxi
    {
        
        //properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        //method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name: {0}", DriverName);
            Console.WriteLine("On Duty: {0}", OnDuty ? "Yes" : "No");
            Console.WriteLine("Number of Passenger: {0}", NumPassenger);

        }

        public void PickUpPassenger()
        {
            if (OnDuty == true)
            { Console.WriteLine("\n{0} sedang menjemput penumpang", DriverName); }
            else
                if (OnDuty == false)
            { Console.WriteLine("\n{0} tidak sedang menjemput penumpang", DriverName); }
        }

        public void DropOffPassenger()
        {
            if (OnDuty == true)
            { Console.WriteLine("{0} selesai mengantar penumpang", DriverName); }
            else
                if (OnDuty == false)
            { Console.WriteLine("{0} belum selesai mengantar penumpang", DriverName); }
        }
    }
}
