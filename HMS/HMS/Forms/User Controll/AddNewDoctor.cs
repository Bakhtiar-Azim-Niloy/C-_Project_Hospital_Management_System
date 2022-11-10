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
    public partial class AddNewDoctor : UserControl
    {
        public AddNewDoctor()
        {
            InitializeComponent();
        }

        private void btnAddAdminSave_Click(object sender, EventArgs e)
        {
            if(this.txtPhone.Text==""||this.txtPassword.Text==""||this.txtName.Text==""||this.txtAddress.Text==""||this.txtSalary.Text==""||this.txtWardId.Text==""||this.dateTimePicker1.Text=="")
            {
                MessageBox.Show("Provide all Information");
            }
            else
            {
                Doctor doctor = new Doctor();
                doctor.Name = this.txtName.Text;
                doctor.Address = this.txtAddress.Text;
                doctor.Dob = this.dateTimePicker1.Text;
                doctor.Phone = this.txtPhone.Text;
                doctor.Salary = Double.Parse(this.txtSalary.Text);
                doctor.WId = Int32.Parse(this.txtWardId.Text);
                doctor.Password = this.txtPassword.Text;
                if (this.rbMale.Checked)
                {
                    doctor.Gender =this.rbMale.Text;
                    DoctorRepository doctorRepository = new DoctorRepository();
                    bool insert = doctorRepository.Insert(doctor);
                    if (insert)
                    {
                        MessageBox.Show("Doctor Created");
                    }
                    else
                    {

                        MessageBox.Show("change phone number");
                    }



                }
                else if (this.rbFemale.Checked)
                {
                    doctor.Gender =this.rbFemale.Text;
                    DoctorRepository doctorRepository = new DoctorRepository();
                    doctorRepository.Insert(doctor);
                    bool insert = doctorRepository.Insert(doctor);
                    if (insert)
                    {
                        MessageBox.Show("Doctor Created");
                    }
                    else
                    {

                        MessageBox.Show("change phone number");
                    }
                }
                else
                    MessageBox.Show("Choose a gender");
            }
           
        }
    }
}
