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
        string appointmentdate;
        string appointmenttime;
        string appointmentdoctor;
        string appointmentsymptoms;

        public void getPath()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        public void getPatientInfo(string Name, string PatientID, string BirthDate, string Gender, string PhoneNumber)
        {
            name = Name;
            patientid = PatientID;
            birthdate = BirthDate;
            gender = Gender;
            phonenumber = PhoneNumber;
            
            writePatientToXml();
        }

        public void getInsuranceInfo(string InsuranceID, string InsuranceGroupID, string InsuranceType, string InsuranceProvider)
        {
            insuranceid = InsuranceID;
            insurancegroupid = InsuranceGroupID;
            insurancetype = InsuranceType;
            insuranceprovider = InsuranceProvider;
            writeInsuranceToXml();
        }

        public void getAppointmentInfo(string AppDate, string AppTime, string AppDoctor, string AppSymptoms)
        {
            appointmentdate = AppDate;
            appointmenttime = AppTime;
            appointmentdoctor = AppDoctor;
            appointmentsymptoms = AppSymptoms;
            writeAppointmentToXml();
        }

        public string getMainPath()
        {
            var path = /*Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +*/ string.Format("C:/Users/Keith Hetzel/Documents/patients/patient{0}.xml", patientid);
            //FileStream filepath = File.Create(path);
            //filepath.Close();
            //FileStream fpath = File.Create(path);
            return path;
        }

        public void writePatientToXml()
        {
            string filepath = getMainPath();
            XmlDocument doc = new XmlDocument();
            //doc.Load(filepath);
            
            XmlElement parentElement = (XmlElement)doc.CreateElement("PatientInfo");
            XmlElement newChildElement = doc.CreateElement("Name");
            XmlElement newSomethingElement = doc.CreateElement(name);
            newChildElement.AppendChild(newSomethingElement);
            XmlElement newChildElement2 = doc.CreateElement("PatientID");
            XmlElement newSomethingElement2 = doc.CreateElement(patientid);
            newChildElement2.AppendChild(newSomethingElement2);
            XmlElement newChildElement3 = doc.CreateElement("BirthDate");
            XmlElement newSomethingElement3 = doc.CreateElement(birthdate);
            newChildElement3.AppendChild(newSomethingElement3);
            XmlElement newChildElement4 = doc.CreateElement("Gender");
            XmlElement newSomethingElement4 = doc.CreateElement(gender);
            newChildElement4.AppendChild(newSomethingElement4);
            XmlElement newChildElement5 = doc.CreateElement("PhoneNumber");
            XmlElement newSomethingElement5 = doc.CreateElement(phonenumber);
            newChildElement5.AppendChild(newSomethingElement5);

            doc.AppendChild(parentElement);

            parentElement.AppendChild(newChildElement);
            parentElement.AppendChild(newChildElement2);
            parentElement.AppendChild(newChildElement3);
            parentElement.AppendChild(newChildElement4);
            parentElement.AppendChild(newChildElement5);

            doc.Save(filepath);
        }

        public void writeInsuranceToXml()
        {
            string filepath = getMainPath();
            XmlDocument doc = new XmlDocument();
            //doc.Load(filepath);

            XmlElement parentElement = (XmlElement)doc.CreateElement("InsuranceInfo");
            XmlElement newChildElement = doc.CreateElement("InsuranceID");
            XmlElement newSomethingElement = doc.CreateElement(insuranceid);
            newChildElement.AppendChild(newSomethingElement);
            XmlElement newChildElement2 = doc.CreateElement("InsuranceGroupID");
            XmlElement newSomethingElement2 = doc.CreateElement(insurancegroupid);
            newChildElement2.AppendChild(newSomethingElement2);
            XmlElement newChildElement3 = doc.CreateElement("InsuranceType");
            XmlElement newSomethingElement3 = doc.CreateElement(insurancetype);
            newChildElement3.AppendChild(newSomethingElement3);
            XmlElement newChildElement4 = doc.CreateElement("InsuranceProvider");
            XmlElement newSomethingElement4 = doc.CreateElement(insuranceprovider);
            newChildElement4.AppendChild(newSomethingElement4);
            doc.AppendChild(parentElement);
            parentElement.AppendChild(newChildElement);
            parentElement.AppendChild(newChildElement2);
            parentElement.AppendChild(newChildElement3);
            parentElement.AppendChild(newChildElement4);

            doc.Save(filepath);
        }

        public void writeAppointmentToXml()
        {
            string filepath = getMainPath();
            XmlDocument doc = new XmlDocument();
            //doc.Load(filepath);

            XmlElement parentElement = (XmlElement)doc.CreateElement("AppointmentInfo");
            XmlElement newChildElement = doc.CreateElement("AppointmentDate");
            XmlElement newSomethingElement = doc.CreateElement(appointmentdate);
            newChildElement.AppendChild(newSomethingElement);
            XmlElement newChildElement2 = doc.CreateElement("AppointmentTime");
            XmlElement newSomethingElement2 = doc.CreateElement(appointmenttime);
            newChildElement2.AppendChild(newSomethingElement2);
            XmlElement newChildElement3 = doc.CreateElement("AppointmentDoctor");
            XmlElement newSomethingElement3 = doc.CreateElement(appointmentdoctor);
            newChildElement3.AppendChild(newSomethingElement3);
            XmlElement newChildElement4 = doc.CreateElement("AppointmentSymptoms");
            XmlElement newSomethingElement4 = doc.CreateElement(appointmentsymptoms);
            newChildElement4.AppendChild(newSomethingElement4);

            doc.AppendChild(parentElement);
            parentElement.AppendChild(newChildElement);
            parentElement.AppendChild(newChildElement2);
            parentElement.AppendChild(newChildElement3);
            parentElement.AppendChild(newChildElement4);

            doc.Save(filepath);
        }
    }
}
#region trial code, might work
/*
XmlDocument xd = new XmlDocument();
xd.Load("employees.xml");
XmlNode nl = xd.SelectSingleNode("//Employees");
XmlDocument xd2 = new XmlDocument();
xd2.LoadXml("<Employee><ID>20</ID><FirstName>Clair</FirstName><LastName>Doner</LastName><Salary>13000</Salary></Employee>");
XmlNode n = xd.ImportNode(xd2.FirstChild,true);
nl.AppendChild(n);
xd.Save(Console.Out);

    
    or


XmlDocument doc = new XmlDocument();
doc.LoadXml("before.xml");
//XmlNode root = doc.DocumentElement;

//Create a new node.
XmlElement elem = doc.CreateElement("entry");
elem.InnerText="";
//Add the node to the document.
//root.AppendChild(elem);

//Console.WriteLine("Display the modified XML...");

doc.LastChild.AppendChild(elem);

doc.Save("before.xml");'

    */
#endregion