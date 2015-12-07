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
        //string patientname;
        public LoadPatient()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listBoxPatients.Items.Add("This is a patient");
            printPatients();
        }

        public void printPatients()
        {
            ReadXmlNames reader = new ReadXmlNames();
            string element = reader.loadPatientsNames();
            listBoxPatients.Items.Add(element);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            //load selected patient
            this.Hide();
            AppointmentForm appform = new AppointmentForm();
            appform.Show();
            object patient = listBoxPatients.SelectedItem;
        }
    }
}
