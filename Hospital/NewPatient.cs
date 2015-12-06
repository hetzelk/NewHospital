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
    public partial class NewPatient : Form
    {
        public NewPatient()
        {
            InitializeComponent();
        }

        public string genderValue()
        {
            string value = "";
            bool isChecked = radioMale.Checked;
            if (isChecked)
                value = radioMale.Text;
            else
                value = radioFemale.Text;
            return value;
        }

        private void buttonCreateFile_Click(object sender, EventArgs e)
        {
            FrontDesk frontdesk = new FrontDesk();
            string name = textBoxName.Text;
            string patientid = textBoxPatientID.Text;
            string birthdate = textBoxBirthDate.Text;
            string gender = genderValue();
            string phonenumber = textBoxPhone.Text;
            string insuranceid = textBoxInsuranceID.Text;
            string insurancegroupid = textBoxInsuranceGroupID.Text;
            string insurancetype = textBoxInsuranceType.Text;
            string insuranceprovider = textBoxInsuranceProvider.Text;

            frontdesk.retrieveAll(name, patientid, birthdate, gender, phonenumber, insuranceid, insurancegroupid, insurancetype, insuranceprovider);

        }

        private void buttonLoadCreatedPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            loadThisPatient();
        }

        public void loadThisPatient()
        {
            LoadPatient loadpat = new LoadPatient();
            loadpat.Show();
        }
    }
}
//create the new patient and then close that file, but open up the load patient form so that the user can load that patient information and create an appointment instance for them
//in each new appointment instance include the symptoms, doctor, time-date, diagnosis, and outcome
//in the appointment creator allow the user to click a button to load all of their previous appointments, this would just open up a new form that includes all of the appointments in a list, then when the user clicks on that list, it displays - the symptoms, doctor, date-time, diagnosis, and outcome
//patient is set up like
//<patient><name></name></patient>
//set up appointments in the same file like
//<allappointments><appointment><date>2/8/8</date><time>tick</time><etc>etc</etc></appointment><appointment><date>2/8/9</date><time>tock<time><etc>etc</etc></appointment></allappointments>