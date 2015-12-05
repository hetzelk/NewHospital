using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Windows.Forms;

namespace Hospital
{
    public class FrontDesk
    {

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NewLoad());
        }

        public void retrieveAll(string Name, string PatientID, string BirthDate, string Gender, string PhoneNumber, string InsuranceID, string InsuranceGroupID, string InsuranceType, string InsuranceProvider)
        {
            string name = Name;
            string patientid = PatientID;
            string birthdate = BirthDate;
            string gender = Gender;
            string phonenumber = PhoneNumber;
            string insuranceid = InsuranceID;
            string insurancegroupid = InsuranceGroupID;
            string insurancetype = InsuranceType;
            string insuranceprovider = InsuranceProvider;

            WriteToXml write = new WriteToXml();
            write.getAllInfo(name, patientid, birthdate, gender, phonenumber, insuranceid, insurancegroupid, insurancetype, insuranceprovider);
        }

        
    }
}
