using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a class Hospital with HospitalDetails() method.Create another
//classes Apollo, Wockhardt, Gokul_Superspeciality which overrides
//HospitalDetails() method.
namespace Lab_4
{
    internal class Hospital
    {
        public virtual void HospitalDetails()
        {
            Console.WriteLine("Hospital Detailsc Hear");
        }
    }

    class Wockhardt : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Wockhardt Details");
        }
    }

    class Apollo : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Apollo Details");
        }
    }

    class Gokul_Superspeciality : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Gokul_Superspeciality Details");
        }
    }
}
