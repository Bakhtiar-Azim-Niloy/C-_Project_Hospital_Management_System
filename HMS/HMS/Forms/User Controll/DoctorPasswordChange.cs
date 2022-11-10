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
    public partial class DoctorPasswordChange : UserControl
    {
        public DoctorPasswordChange()
        {
            InitializeComponent();
        }
       
        public Admin Admin1 { get; set; }
        public Doctor Doctor1 { get; set; }
        public Staff Staff1 { get; set; }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(this.txtCPassword.Text==""|| this.txtNewPassword.Text=="")
            {
                MessageBox.Show("Provide Password");
            }
            else
            {
                string cPass = this.txtCPassword.Text;
                string newPass = this.txtNewPassword.Text;
                Doctor doctor = new Doctor();
                doctor.Phone = Doctor1.Phone;
                DoctorRepository patientRepository = new DoctorRepository();

                if (cPass == newPass)
                {
                    doctor.Password = newPass;
                    patientRepository.UpdatePass(doctor);
                    MessageBox.Show("password Updated");
                }
                else
                    MessageBox.Show("password did not match");
            }
           
        }
    }
}
