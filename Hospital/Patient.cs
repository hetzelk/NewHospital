using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Patient : Person
    {
        List<Symptom> parientSymptoms = new List<Symptom>();
        //private string patientName;

        public void getSymptoms()
        {
            // do something with symptom list
        }

        public string patientName
        {
            get { return name; }
            set { name = value; }
        }
        // add rest of person info


    }
}
