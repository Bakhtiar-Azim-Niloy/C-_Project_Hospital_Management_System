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
    public partial class AddNewPatient : UserControl
    {
        public AddNewPatient()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.txtSearch.Text =="")
            {
                MessageBox.Show("Please provide Phone number");
                
            }
            else
            {
                Patient patient = new Patient();
                patient.Phone = this.txtSearch.Text;
                PatientRepository patientRepository = new PatientRepository();
                patient = patientRepository.Get(patient);
                if (patient.Name == null)
                {
                    MessageBox.Show("No data");
                }
                else
                {
                    this.TxtPatientAddress.Text = patient.Address;
                    this. txtPatientName.Text = patient.Name;
                    this. txtPatientPhoneNumber.Text = patient.Phone;
                    this. txtPatientAge.Text = patient.Age.ToString();
                    this.txtPatientCharge.Text = patient.charge;
                    this.txtPatientConsultant.Text = patient.Consultant;
                    this.txtPatientConsultant.Text = patient.Consultant;
                    this.txtPatientRoomNo.Text = patient.RoomNo;
                    this.cmbPatientRoomType.Text = patient.RoomType;
                    this.cmbPatientType.Text = patient.PatientType;
                    this.dtpPatientInDate.Text = patient.ChckInDate;
                    patient.Gender = this.rbMale.Text;
                    patient.Gender = this.rbFemale.Text;
                }
            }
           
        }

        private void btnAddPatientSave_Click(object sender, EventArgs e)
        {
            if(this.txtPatientName.Text==""||this.txtPatientAge.Text==""||this.txtPatientCharge.Text==""||this.txtPatientConsultant.Text==""||this.txtPatientPhoneNumber.Text==""||
                this.txtPatientRoomNo.Text==""||this.TxtPatientAddress.Text==""||this.cmbPatientRoomType.Text==""||this.cmbPatientType.Text==""||this.dtpPatientInDate.Text=="")
            {
                MessageBox.Show("Please provide all information");
            }
            else
            {
                Patient patient = new Patient();
                patient.Name =this. txtPatientName.Text;
                patient.Address = this.TxtPatientAddress.Text;
                patient.ChckInDate = this.dtpPatientInDate.Text;
                patient.Phone =this. txtPatientPhoneNumber.Text;
                patient.Age = Convert.ToInt32(this.txtPatientAge.Text);
                patient.PatientType = this.cmbPatientType.Text;
                patient.RoomType =this. cmbPatientRoomType.Text;
                patient.RoomNo = this.txtPatientRoomNo.Text;
                patient.Consultant = this.txtPatientConsultant.Text;
                patient.charge =this. txtPatientCharge.Text;

                if (this.rbMale.Checked)
                {
                    patient.Gender = this.rbMale.Text;
                    PatientRepository adminRepository = new PatientRepository();
                    adminRepository.Insert(patient);
                    MessageBox.Show("Patient Created");



                }
                else if (this.rbFemale.Checked)
                {
                    patient.Gender = this.rbFemale.Text;
                    PatientRepository adminRepository = new PatientRepository();
                    adminRepository.Insert(patient);
                    MessageBox.Show("Patient Created");
                }
                else
                    MessageBox.Show("Choose a gender");
            }
          

        }

        private void btnPatinentUpdate_Click(object sender, EventArgs e)
        {
            if (this.txtPatientName.Text == "" || this.txtPatientAge.Text == "" || this.txtPatientCharge.Text == "" || this.txtPatientConsultant.Text == "" || this.txtPatientPhoneNumber.Text == "" ||
              this.txtPatientRoomNo.Text == "" || this.TxtPatientAddress.Text == "" || this.cmbPatientRoomType.Text == "" || this.cmbPatientType.Text == "" || this.dtpPatientInDate.Text == "")
            {
                MessageBox.Show(" For Update Search patient and Provide All Information");
            }
            else
            {
                Patient patient = new Patient();
                patient.Address = this.TxtPatientAddress.Text;
                patient.Name = this.txtPatientName.Text;
                patient.Phone = this.txtPatientPhoneNumber.Text;
                patient.Age = Convert.ToInt32(this.txtPatientAge.Text);
                patient.charge = this.txtPatientCharge.Text;
                patient.Consultant =this. txtPatientConsultant.Text;
                patient.RoomNo = this.txtPatientRoomNo.Text;
                patient.RoomType = this.cmbPatientRoomType.Text;
                patient.PatientType =this. cmbPatientType.Text;
                patient.ChckInDate = this.dtpPatientInDate.Text;
               // patient.Gender = rbMale.Text;
               // patient.Gender = rbFemale.Text;
                if (this.rbMale.Checked)
                {
                    patient.Gender =this. rbMale.Text;
                    PatientRepository adminRepository = new PatientRepository();
                    adminRepository.Update(patient);
                    MessageBox.Show("Patient Updated");



                }
                else if (this.rbFemale.Checked)
                {
                    patient.Gender = this.rbFemale.Text;
                    PatientRepository adminRepository = new PatientRepository();
                    adminRepository.Update(patient);
                    MessageBox.Show("Patient Updated");
                }
                else
                    MessageBox.Show("Choose a gender");

               /* PatientRepository patientRepository = new PatientRepository();
                bool update = patientRepository.Update(patient);
                if (update)
                {
                    MessageBox.Show("updated");
                }
                else
                    MessageBox.Show("update failed");*/
            }

           
        }

        private void btnPatientDelete_Click(object sender, EventArgs e)
        {
            if (this.txtPatientName.Text == "" ||this. txtPatientAge.Text == "" || this.txtPatientCharge.Text == "" || this.txtPatientConsultant.Text == "" || this.txtPatientPhoneNumber.Text == "" ||
            this.txtPatientRoomNo.Text == "" ||this.TxtPatientAddress.Text == "" ||this.cmbPatientRoomType.Text == "" || this.cmbPatientType.Text == "" || this.dtpPatientInDate.Text == "")
            {
                MessageBox.Show("For Delete Search patient");
            }
            else
            {

                Patient patient = new Patient();
                patient.Phone = this.txtPatientPhoneNumber.Text;

                PatientRepository pattientRepository = new PatientRepository();
                pattientRepository.Delete(patient);
                MessageBox.Show("Deleted");
            }
        }

        private void btnShowPatientReg_Click(object sender, EventArgs e)
        {
            PatientRepository patientRepository = new PatientRepository();
            dgvPatientReg.DataSource = patientRepository.GetAll();
        }
    }
}
