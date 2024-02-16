using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMApplicationCore.Domaine
{
    public class Passenger

    {
        public string PasswportNumber { get; set; }
        public string FirstName { get; set; }
        public string LasteName { get; set; }
        public DateTime BirthDate { get; set; }
        public int TelphoneNumber { get; set; }
        public string EmailAdress { get; set; }
        public ICollection<Flight> Flights { get; set; }

        //poly par signature
        public bool  checkProfile(string nom,string prenom)
        {
            return FirstName.Equals(nom) && LasteName.Equals(prenom);
        }

        public bool checkProfile(string nom, string prenom,string email)
        {
            return FirstName.Equals(nom) && LasteName.Equals(prenom) && EmailAdress.Equals(email);
        }

        public  virtual void PassengerType()
         {
          Console.WriteLine("I m passanger");
        }
    }

   
}
