using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public abstract class Person
    {
        public List<string> symptom = new List<string>();
        public string name;
        public int age;
        public int phoneNumber;
        public bool healthInsurance;

        public string getName()
        {
            return name;
        }
        public int getAge()
        {
            return age;
        }

        public int getPhoneNumber()
        {
            return phoneNumber;
        }
        public bool checkInsurance()
        {
            return healthInsurance;
        }

        
    }
}
