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
    public partial class CheckOutUserControl : UserControl
    {
        public CheckOutUserControl()
        {
            InitializeComponent();
        }

        private void btnCheckoutSearch_Click(object sender, EventArgs e)
        {
            if(this.txtSearchCheckout.Text=="")
            {
                MessageBox.Show("Please provide phone Number");
            }
            else
            {
                Patient patient = new Patient();
                patient.Phone = this.txtSearchCheckout.Text;
                PatientRepository patientRepository = new PatientRepository();
                patient = patientRepository.Get(patient);
                if (patient.Name == null)
                {
                    MessageBox.Show("No data");
                }
                else
                {
                    this.txtReadyToRelease.Text = patient.ReadyToRelease;
                    this.txtPatientName.Text = patient.Name;
                    this.txtPatientPhoneNumber.Text = patient.Phone;
                    this.txtStatus.Text = patient.Status;
                   

                }
            }
           
        }

        private void btnShowInfoPatient_Click(object sender, EventArgs e)
        {
            PatientRepository patientRepository = new PatientRepository();
            dgvPatientCheckOut.DataSource = patientRepository.GetAll();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if(this.txtPatientName.Text==""|| this.txtPatientPhoneNumber.Text==""|| this.dtpCheckOutDate.Text=="")
            {
                MessageBox.Show("Search Patient and Change status");
            }
            else if(this.txtStatus.Text == "Invalid" )
            {
                if(this.txtReadyToRelease.Text == "Yes")
                {
                    Patient patient = new Patient();

                    patient.Name = this.txtPatientName.Text;
                    patient.Phone = this.txtPatientPhoneNumber.Text;
                    patient.Status = this.txtStatus.Text;
                    patient.CheckOutDate = this.dtpCheckOutDate.Text;
                    PatientRepository patientRepository = new PatientRepository();
                    bool update = patientRepository.UpdateCheckOut(patient);
                    if (update)
                    {
                        MessageBox.Show("Checkouted");
                    }
                    else
                        MessageBox.Show("Checkout Failed'");
                }
                else
                {
                    MessageBox.Show("Need Doctor Permission");
                }
               
            }
            else
            {
                MessageBox.Show("Set Status as 'Invalid'");

                
            }


        }          
    }
}