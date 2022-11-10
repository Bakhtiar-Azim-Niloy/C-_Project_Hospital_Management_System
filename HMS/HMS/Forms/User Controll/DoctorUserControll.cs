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
    public partial class DoctorUserControll : UserControl
    {
        public DoctorUserControll()
        {
            InitializeComponent();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            addNewDoctor1.Hide();
            dataGridView1.Show();
            DoctorRepository doctorRepository = new DoctorRepository();
            dataGridView1.DataSource = doctorRepository.GetAll();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.txtSearch.Text=="")
            {
                MessageBox.Show("Provide Phone Number");
            }
            else
            {
                Doctor doctor = new Doctor();
                doctor.Phone = this.txtSearch.Text;
                DoctorRepository doctorRepository = new DoctorRepository();
                doctor = doctorRepository.Get(doctor);
                if (doctor.Name == null)
                {
                    MessageBox.Show("No data found");
                }
                else
                {
                    this.txtAddress.Text = doctor.Address;
                    this.txtName.Text = doctor.Name;
                    this.txtPhone.Text = doctor.Phone;
                    this.txtSalary.Text = doctor.Salary.ToString();
                    this.txtWardId.Text = doctor.WId.ToString();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.txtAddress.Text == "" || this.txtName.Text == "" || this.txtPhone.Text == "" || this.txtSalary.Text == "" || this.txtWardId.Text=="")
            {
                MessageBox.Show(" Search");
            }
            else
            {
                Doctor doctor = new Doctor();
                doctor.Address = this.txtAddress.Text;
                doctor.Name = this.txtName.Text;
                doctor.Phone = this.txtPhone.Text;
                doctor.Salary = Double.Parse(this.txtSalary.Text);
                DoctorRepository doctorRepository = new DoctorRepository();
                bool update = doctorRepository.Update(doctor);
                if (update)
                {
                    MessageBox.Show("updated");
                }
                else
                    MessageBox.Show("update failed");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.txtAddress.Text == "" || this.txtName.Text == "" || this.txtPhone.Text == "" || this.txtSalary.Text == ""|| this.txtWardId.Text=="")
            {
                MessageBox.Show("Search");
            }
            else
            {
                Doctor doctor = new Doctor();
                doctor.Phone = this.txtPhone.Text;
                DoctorRepository doctorRepository = new DoctorRepository();

                bool delete = doctorRepository.Delete(doctor); ;
                if (delete)
                {
                    MessageBox.Show("deleted");
                }
                else
                    MessageBox.Show("delete failed");
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            addNewDoctor1.Show();
        }
    }
}
