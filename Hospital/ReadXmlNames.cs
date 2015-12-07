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
        public string loadPatientsNames()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//patients/";
            foreach (string file in Directory.EnumerateFiles(path, "*.xml"))
            {

                XmlDocument doc = new XmlDocument();
                doc.Load(file);
                
                XmlNodeList PatientNames = doc.GetElementsByTagName("Name");
                if (PatientNames.Count <= 1)
                {
                    // The tag could not be found
                }
                else
                {
                    string element = PatientNames[0].InnerText;
                    return element;
                }
                
            }
            
            
            string el = "Keith Hetzel";
            return el;                
        }
    }
}

#region trial code, might work
/*

XDocument XMLDoc = XDocument.Load("test.xml");
string id = "123"; // id to be selected

XElement Contact = (from xml2 in XMLDoc.Descendants("Node")
                    where xml2.Element("ID").Value == id
                    select xml2).FirstOrDefault();

Console.WriteLine(Contact.ToString());

    */

/*
                string contents = File.ReadAllText(file);
                XmlDocument xmlDoc = new XmlDocument();
                XmlNodeList patientnamelist = xmlDoc.GetElementsByTagName("Name");
                string name = contents[0].InnerText;
                //XDocument xDoc = XDocument.Load(path);
                
                

                foreach (string element in patientnamelist)
                {
                   return(element);
                }*/
#endregion