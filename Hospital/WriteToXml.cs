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
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + string.Format("//patient{0}.xml", name);
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

            xWriter.WriteStartElement("InsuranceInfo");
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
            xWriter.WriteEndElement();//end insurance info

            xWriter.WriteEndElement();//end patient info

            xWriter.Close();

            //have an entirely new section to look at all the previous appontments that that specific patient has had.
            //include the symptoms, doctor, date-time, diagnosis, outcome
        }
    }
}

/*
XmlDocument xmlDoc= new XmlDocument(); // Create an XML document object
xmlDoc.Load("yourXMLFile.xml"); // Load the XML document from the specified file

// Get elements
XmlNodeList girlAddress = xmlDoc.GetElementsByTagName("gAddress");
XmlNodeList girlAge = xmlDoc.GetElementsByTagName("gAge"); 
XmlNodeList girlCellPhoneNumber = xmlDoc.GetElementsByTagName("gPhone");

// Display the results
Console.WriteLine("Address: " + girlAddress[0].InnerText);
Console.WriteLine("Age: " + girlAge[0].InnerText);
Console.WriteLine("Phone Number: " + girlCellPhoneNumber[0].InnerText);


    */