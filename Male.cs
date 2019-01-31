using System;
using System.Collections.Generic;
using System.Text;

namespace LabOne
{
    class Male: Person
    {
        private MaleTitle maleTitle
        {
            get
            {
                
                Random random = new Random();

                Array maleTitles = Enum.GetValues(typeof(MaleTitle));
                
                MaleTitle randomMaleTitle = (MaleTitle) maleTitles.GetValue(random.Next(maleTitles.Length));


                return randomMaleTitle;
            }
            set { throw new NotImplementedException(); }
        }

        private MaleFirstName maleFirstName
        {
            get
            {
                Random random = new Random();

                Array maleFirstNames = Enum.GetValues(typeof(MaleFirstName));

                MaleFirstName randomMaleFirstName =
                    (MaleFirstName) maleFirstNames.GetValue(random.Next(maleFirstNames.Length));

                return randomMaleFirstName;
            }   
            set{ throw new NotImplementedException();}
        }

        public Male()
        {


            Console.WriteLine("Male Title: {0} \nMale First Name: {1}\nLast Name: {2}\nBirthdate: {3}", maleTitle, maleFirstName, GetLastName(), GetBirthdate());
            
            
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
