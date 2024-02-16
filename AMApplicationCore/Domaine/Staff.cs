using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMApplicationCore.Domaine
{
    public class Staff :Passenger
    {
        public DateTime EmployementDate { get; set; }
        public Double Salary { get; set; }
        public string Function { get; set; }

        public override void PassengerType()
        {
            Console.WriteLine("i m staff");
            base.PassengerType();

        }
    }
}
