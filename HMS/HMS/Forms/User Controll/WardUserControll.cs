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
    public partial class WardUserControll : UserControl
    {
        public WardUserControll()
        {
            InitializeComponent();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            addNewWard1.Hide();
            dataGridView1.Show();
            WardRepository wardRepository = new WardRepository();
            dataGridView1.DataSource = wardRepository.GetAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.txtSearch.Text == "")
            {
                MessageBox.Show("Provide Phone Number");
            }
            else
            {
                WardRepository wardRepository = new WardRepository();
                Ward ward = new Ward();
                ward.Id = Int32.Parse(this.txtSearch.Text);
                ward = wardRepository.Get(ward);

                this.txtId.Text = ward.Id.ToString();
                this.txtName.Text = ward.Name;
                this.txtBedCount.Text = ward.BedCount.ToString();
                this.txtPrice.Text = ward.Price.ToString();
            }

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            addNewWard1.Show();
        }
    }
}
