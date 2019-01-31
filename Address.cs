using System;
using System.Collections.Generic;
using System.Text;

namespace LabOne
{
    public class Address
    {
        private uint houseNumber;
        private String streetName;
        private StreetType streetType;
        private String city;
        private String zipCode;
        private Dictionary<String, String> stateDictionary;

        public Address()
        {
            

        }

        public String GetRandomStateAbbr()
        {
            
        }

        public String GetStateName()
        {
            
        }

        public String GetStateAbbr()
        {

        }

        private String AssignStateName()
        {

        }

        private String AssignZipCode()
        {
            Random random = new Random();

            int randZip = random.Next(2000, 2999);

            string zipToString = (int)randZip.toString();

            return zipToString;

        }

        public String ToString()
        {
            return "Zip: " + AssignZipCode();
        }
    }

}
