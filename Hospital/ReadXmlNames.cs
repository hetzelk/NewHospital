using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace Hospital
{
    class ReadXmlNames
    {
        public void loadPatientsNames()
        {
            //LoadPatient loadpat = new LoadPatient();
            //loadpat.Show();

            LoadPatient load = new LoadPatient();
            string keith = "Keith Hetzelll";
            //load.printPatients();
            load.printPatients(keith);
            /*
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("//patient3.xml");
            //FileStream file = File.Read(path);

            //XmlTextWriter xWriter = new XmlTextWriter(file, Encoding.UTF8);
            XDocument xDoc = XDocument.Load(path);
            XmlDocument xmlDoc = new XmlDocument(); // Create an XML document object
            //xmlDoc.Load(@path); // Load the XML document from the specified file

            XmlNodeList patientname = xmlDoc.GetElementsByTagName("Name");
            
            //load.printPatients(patientname);
            */
            
        }
    }
}
/*

XDocument XMLDoc = XDocument.Load("test.xml");
string id = "123"; // id to be selected

XElement Contact = (from xml2 in XMLDoc.Descendants("Node")
                    where xml2.Element("ID").Value == id
                    select xml2).FirstOrDefault();

Console.WriteLine(Contact.ToString());

    */

