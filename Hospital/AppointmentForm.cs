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
    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
            #region Appointment Times
            listBoxTime.Items.Add("8:00 am");
            listBoxTime.Items.Add("8:30 am");
            listBoxTime.Items.Add("9:00 am");
            listBoxTime.Items.Add("9:30 am");
            listBoxTime.Items.Add("10:00 am");
            listBoxTime.Items.Add("10:30 am");
            listBoxTime.Items.Add("11:00 am");
            listBoxTime.Items.Add("11:30 am");
            listBoxTime.Items.Add("12:01 pm");
            listBoxTime.Items.Add("12:30 pm");
            listBoxTime.Items.Add("1:00 am");
            listBoxTime.Items.Add("1:30 pm");
            listBoxTime.Items.Add("1:00 pm");
            listBoxTime.Items.Add("2:30 pm");
            listBoxTime.Items.Add("2:00 pm");
            listBoxTime.Items.Add("3:30 pm");
            listBoxTime.Items.Add("3:00 pm");
            listBoxTime.Items.Add("4:30 pm");
            listBoxTime.Items.Add("5:00 pm");
            #endregion
            listBoxDoctors.Items.Add("Dr. Quack");
            listBoxDoctors.Items.Add("Dr. Mudd");
            listBoxDoctors.Items.Add("Dr. Spiker");
            listBoxDoctors.Items.Add("Dr. Pepper");
            listBoxDoctors.Items.Add("Dr. Kill");
            listBoxDoctors.Items.Add("Dr. Star");
            listBoxDoctors.Items.Add("Dr. Doom");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            NewPatient patname = new NewPatient();
            patname.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string appDate = dateTimePicker1.Value.ToShortDateString();
            string appTime = listBoxTime.GetItemText(listBoxTime.SelectedItem);
            string appDoctor = listBoxDoctors.GetItemText(listBoxDoctors.SelectedItem);
            string appSymptoms = textBoxSymptoms.Text;

            WriteToXml write = new WriteToXml();
            write.getAppointmentInfo(appDate, appTime, appDoctor, appSymptoms);
        }
    }
}
