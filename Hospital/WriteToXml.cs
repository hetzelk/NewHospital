using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace Hospital
{
    class WriteToXml
    {

        string name;
        string patientid;
        string birthdate;
        string gender;
        string phonenumber;
        string insuranceid;
        string insurancegroupid;
        string insurancetype;
        string insuranceprovider;

        public void getAllInfo(string Name, string PatientID, string BirthDate, string Gender, string PhoneNumber, string InsuranceID, string InsuranceGroupID, string InsuranceType, string InsuranceProvider)
        {
            name = Name;
            patientid = PatientID;
            birthdate = BirthDate;
            gender = Gender;
            phonenumber = PhoneNumber;
            insuranceid = InsuranceID;
            insurancegroupid = InsuranceGroupID;
            insurancetype = InsuranceType;
            insuranceprovider = InsuranceProvider;
            writeToXml();
        }

        public void writeToXml()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + string.Format("//patient{0}.xml", patientid);
            FileStream file = File.Create(path);

            XmlTextWriter xWriter = new XmlTextWriter(file, Encoding.UTF8);
            xWriter.Formatting = Formatting.Indented;
            xWriter.WriteStartElement("PatientInfo");
            xWriter.WriteStartElement("Name");
            xWriter.WriteString(name);
            xWriter.WriteEndElement();

            xWriter.WriteStartElement("PatientID");
            xWriter.WriteString(patientid);
            xWriter.WriteEndElement();

            xWriter.WriteStartElement("BirthDate");
            xWriter.WriteString(birthdate);
            xWriter.WriteEndElement();

            xWriter.WriteStartElement("Gender");
            xWriter.WriteString(gender);
            xWriter.WriteEndElement();

            xWriter.WriteStartElement("PhoneNumber");
            xWriter.WriteString(phonenumber);
            xWriter.WriteEndElement();
            
            xWriter.WriteStartElement("InsuranceID");
            xWriter.WriteString(insuranceid);
            xWriter.WriteEndElement();

            xWriter.WriteStartElement("InsuranceGroupID");
            xWriter.WriteString(insurancegroupid);
            xWriter.WriteEndElement();

            xWriter.WriteStartElement("InsuranceType");
            xWriter.WriteString(insurancetype);
            xWriter.WriteEndElement();

            xWriter.WriteStartElement("InsuranceProvider");
            xWriter.WriteString(insuranceprovider);
            xWriter.WriteEndElement();
            xWriter.WriteEndElement();

            xWriter.Close();



            //have an entirely new section to look at all the previous appontments that that specific patient has had.
            //include the symptoms, doctor, date-time, diagnosis, outcome
        }
    }
}