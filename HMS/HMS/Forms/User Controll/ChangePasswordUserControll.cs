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
    public partial class ChangePasswordUserControll : UserControl
    {
        public ChangePasswordUserControll()
        {
            InitializeComponent();
        }

        public Admin Admin1 { get; set; }
        public Staff Staff1 { get; set; }
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
                Admin admin = new Admin();
                admin.Phone = Admin1.Phone;
                AdminRepository adminRepository = new AdminRepository();

                if (cPass == newPass)
                {
                    admin.Password = newPass;
                    adminRepository.UpdatePass(admin);
                    MessageBox.Show("password Updated");
                }
                else
                    MessageBox.Show("password did not match");
            }
           

  
        }
    }
}
