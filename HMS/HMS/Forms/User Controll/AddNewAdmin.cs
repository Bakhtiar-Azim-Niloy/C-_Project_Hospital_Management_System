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
    public partial class AddNewAdmin : UserControl
    {
        public AddNewAdmin()
        {
            InitializeComponent();
        }

        private void btnAddAdminSave_Click(object sender, EventArgs e)
        {
            if(this.txtPassword.Text=="" || this.txtName.Text=="" ||this. txtAddress.Text=="" || this.txtPhone.Text=="" || this.txtSalary.Text=="" ||this. txtPhone.Text=="")
            {
                MessageBox.Show("Proovide All Information");
            }
            else
            {
                Admin admin = new Admin();
                admin.Name =this.txtName.Text;
                admin.Address = this.txtAddress.Text;
                admin.Dob = this.dateTimePicker1.Text;
                admin.Phone = this.txtPhone.Text;
                admin.Salary = Double.Parse(this.txtSalary.Text);
                admin.Password =this. txtPassword.Text;
                if (rbMale.Checked)
                {
                    admin.Gender =this. rbMale.Text;
                    AdminRepository adminRepository = new AdminRepository();
                    adminRepository.Insert(admin);
                    MessageBox.Show("Admin Created");

                }
                else if (rbFemale.Checked)
                {
                    admin.Gender =this. rbFemale.Text;
                    AdminRepository adminRepository = new AdminRepository();
                    adminRepository.Insert(admin);
                    MessageBox.Show("Admin Created");
                }
                else
                    MessageBox.Show("Choose a gender");

            }



        }
    }
}
