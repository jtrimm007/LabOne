using System;
using System.Collections.Generic;
using System.Text;

namespace LabOne
{
    public abstract class Person: Address
    {
        private LastName LastName { get;  set; }
        private DateTime Birthdate { get; set; }
        private Address address { get; set; }

        public abstract void SetLastName(LastName lastName);

        public abstract void SetBirthdate(DateTime birthDate);

        public abstract void SetAddress(Address address);

        public Address GetAddress()
        {


        }

        public LastName GetLastName()
        {
            Array lastNames = Enum.GetValues(typeof(LastName));
            
            Random random = new Random();

            LastName LastName = (LastName) lastNames.GetValue(random.Next(lastNames.Length));
            
            return LastName;
        }

        public DateTime GetBirthdate()
        {

            DateTime today = DateTime.Today;

            DateTime Birthdate = today.AddDays(-GetAge());
            
            return Birthdate;
        }

        public int GetAge()
        {
            Random age = new Random();

            int randAge = age.Next((30 * 365), (60 * 365));

            return randAge;
        }

        public String ToString()
        {
            return "LastName: " + GetLastName() + " \nBirthdate: " + GetBirthdate() + " \nAge:" + GetAge(); 
        }
    }

}
