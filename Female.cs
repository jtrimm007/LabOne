using System;
using System.Collections.Generic;
using System.Text;

namespace LabOne
{
    class Female: Person
    {
        private FemaleTitle femaleTitle
        {
            get
            {
                
                Random random = new Random();

                Array femaleTitles = Enum.GetValues(typeof(FemaleTitle));
                
                FemaleTitle randomFemaleTitle = (FemaleTitle) femaleTitles.GetValue(random.Next(femaleTitles.Length));


                return randomFemaleTitle;
            }
            set { throw new NotImplementedException(); }
        }

        private FemaleFirstName femaleFirstName
        {
            get
            {
                Random random = new Random();

                Array femaleFirstNames = Enum.GetValues(typeof(FemaleFirstName));

                FemaleFirstName randomFemaleFirstName =
                    (FemaleFirstName) femaleFirstNames.GetValue(random.Next(femaleFirstNames.Length));

                return randomFemaleFirstName;
            }   
            set{ throw new NotImplementedException();}
        }

        public Female()
        {


            Console.WriteLine("Female Title: {0} \nFemale First Name: {1}\nLast Name: {2}\nBirthdate: {3}", femaleTitle, femaleFirstName, GetLastName(), GetBirthdate());
            
            
        }

        public override void SetLastName(LastName lastName)
        {
            throw new NotImplementedException();
        }

        public override void SetBirthdate(DateTime birthDate)
        {
            throw new NotImplementedException();
        }
    }
}
