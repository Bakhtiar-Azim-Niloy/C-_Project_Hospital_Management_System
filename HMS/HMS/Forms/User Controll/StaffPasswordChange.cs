using HMS.Entities;
using HMS.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Forms.User_Controll
{
    public partial class StaffPasswordChange : UserControl
    {
        public StaffPasswordChange()
        {
            InitializeComponent();
        }
        public Staff Staff1 { get; set; }
        public Admin Admin1 { get; set; }
        public Doctor Doctor1 { get; set; }

    

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
                Staff patient = new Staff();
                patient.Phone = Staff1.Phone;
                StaffRepository patientRepository = new StaffRepository();

                if (cPass == newPass)
                {
                    patient.Password = newPass;
                    patientRepository.UpdatePass(patient);
                    MessageBox.Show("password Updated");
                }
                else
                    MessageBox.Show("password did not match");
            }
           
        }
    }
}
