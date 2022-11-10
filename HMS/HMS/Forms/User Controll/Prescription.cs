using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS.Entities;
using HMS.Repository;

namespace HMS.Forms.User_Controll
{
    public partial class Prescription : UserControl
    {
        public Prescription()
        {
            InitializeComponent();
        }

        private void btnSearchPrescription_Click(object sender, EventArgs e)
        {
            if(this.txtSearchPrescription.Text=="")
            {
                MessageBox.Show("Please Provide Phone Number");
            }
            else
            {
                Patient patient = new Patient();
                patient.Phone = this.txtSearchPrescription.Text;
                PatientRepository patientRepository = new PatientRepository();
                patient = patientRepository.Get(patient);
                if (patient.Name == null)
                {
                    MessageBox.Show("No data");
                }
                else
                {

                    this.txtPatientName.Text = patient.Name;
                    this.txtPatientPhoneNumber.Text = patient.Phone;
                    this.txtPrescription.Text = patient.Prescription;

                }
            }
           
        }

        private void btnUpdatePrescription_Click(object sender, EventArgs e)
        {
            if(txtPatientName.Text==""||txtPatientPhoneNumber.Text==""||txtPrescription.Text=="")
            {
                MessageBox.Show("Search Patient amd Provide prescription");
            }
            else
            {
                Patient patient = new Patient();

                patient.Name = txtPatientName.Text;
                patient.Phone = txtPatientPhoneNumber.Text;
                patient.Prescription = txtPrescription.Text;

                PatientRepository patientRepository = new PatientRepository();
                bool update = patientRepository.UpdatePrescription(patient);
                if (update)
                {
                    MessageBox.Show("updated");
                }
                else
                    MessageBox.Show("update failed");
            }
           
        }

        private void btnShowPatinetInfo_Click(object sender, EventArgs e)
        {
            PatientRepository patientRepository = new PatientRepository();
            dgvPrescription.DataSource = patientRepository.GetAll();
        }
    }
}
