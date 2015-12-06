using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class LoadPatient : Form
    {
        string patientname;
        public LoadPatient()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ReadXmlNames reader = new ReadXmlNames();
            reader.loadPatientsNames();
            listBoxPatients.Items.Add("This is a patient");
        }

        public void printPatients(string PatientName)
        {
            listBoxPatients.Items.Add("Keithlol");

            string patientname = PatientName;
            listBoxPatients.Items.Add(patientname);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            printPatients(patientname);
        }
    }
}
