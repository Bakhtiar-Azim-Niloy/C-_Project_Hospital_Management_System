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
    public partial class PatientInfoForDoctor : UserControl
    {
        public PatientInfoForDoctor()
        {
            InitializeComponent();
        }

        private void btnPatientSearch_Click(object sender, EventArgs e)
        {
            if(this.txtPatientSearchForDoctor.Text=="")
            {
                MessageBox.Show("Please Provide Phone Number");
            }
            else
            {
                Patient patient = new Patient();
                patient.Phone = this.txtPatientSearchForDoctor.Text;
                PatientRepository patientRepository = new PatientRepository();
                patient = patientRepository.Get(patient);
                if (patient.Name == null)
                {
                    MessageBox.Show("No data");
                }
                else
                {

                    this.txtPatientName.Text = patient.Name;
                    this.txtPatientNumber.Text = patient.Phone;
                    this.txtPatientAge.Text = patient.Age.ToString();
                    this.txtPatientSymptoms.Text = patient.Sypmtoms;
                    this.txtPatientDiagnosis.Text = patient.Diagnosis;
                    this.cmbReadyToRelease.Text = patient.ReadyToRelease;



                }
            }
           
        }

        private void btnUpdatePatientForDoctor_Click(object sender, EventArgs e)
        {
            if(this.txtPatientName.Text==""|| this.txtPatientAge.Text==""|| this.txtPatientNumber.Text==""|| this.txtPatientSymptoms.Text==""|| this.txtPatientDiagnosis.Text=="")
            {
                MessageBox.Show("Search Patient and Provide Information");
            }
            else
            {
                Patient patient = new Patient();
                patient.Name = this.txtPatientName.Text;
                patient.Phone = this.txtPatientNumber.Text;
                patient.Age = Convert.ToInt32(this.txtPatientAge.Text);
                patient.Sypmtoms = this.txtPatientSymptoms.Text;
                patient.Diagnosis = this.txtPatientDiagnosis.Text;
                patient.ReadyToRelease = this.cmbReadyToRelease.Text;

                PatientRepository patientRepository = new PatientRepository();
                bool update = patientRepository.UpdateForDoc(patient);
                if (update)
                {
                    MessageBox.Show("updated");
                }
                else
                    MessageBox.Show("update failed");
            }
            
        }

        private void btnDeletePatientForDoctor_Click(object sender, EventArgs e)
        {
            if (this.txtPatientName.Text == "" || this.txtPatientAge.Text == "" || this.txtPatientNumber.Text == "")
            {
                MessageBox.Show("Search Patient");
            }
            else
            {
                Patient patient = new Patient();
                patient.Phone = this.txtPatientNumber.Text;

                PatientRepository pattientRepository = new PatientRepository();
                pattientRepository.Delete(patient);
                MessageBox.Show("Deleted");
            }

        }

        private void btnShpwInfoForDoctor_Click(object sender, EventArgs e)
        {
            PatientRepository patientRepository = new PatientRepository();
            dgvPatientInfoForDoctor.DataSource = patientRepository.GetAll();
        }
    }
}
