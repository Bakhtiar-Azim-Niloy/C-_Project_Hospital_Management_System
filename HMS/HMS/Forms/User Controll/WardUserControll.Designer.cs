
namespace HMS.Forms.User_Controll
{
    partial class WardUserControll
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoadData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.txtBedCount = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblBedCount = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.addNewWard1 = new HMS.Forms.User_Controll.AddNewWard();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(346, 38);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(64, 20);
            this.btnLoadData.TabIndex = 54;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(346, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(417, 225);
            this.dataGridView1.TabIndex = 53;
            // 
            // btnAddNew
            // 
            this.btnAddNew.AccessibleName = "btnAddNew";
            this.btnAddNew.Location = new System.Drawing.Point(26, 33);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(64, 20);
            this.btnAddNew.TabIndex = 52;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // txtBedCount
            // 
            this.txtBedCount.AccessibleName = "tbBedCount";
            this.txtBedCount.Location = new System.Drawing.Point(94, 177);
            this.txtBedCount.Name = "txtBedCount";
            this.txtBedCount.ReadOnly = true;
            this.txtBedCount.Size = new System.Drawing.Size(146, 20);
            this.txtBedCount.TabIndex = 51;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(94, 140);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(146, 20);
            this.txtName.TabIndex = 50;
            // 
            // lblBedCount
            // 
            this.lblBedCount.AutoSize = true;
            this.lblBedCount.Location = new System.Drawing.Point(27, 177);
            this.lblBedCount.Name = "lblBedCount";
            this.lblBedCount.Size = new System.Drawing.Size(57, 13);
            this.lblBedCount.TabIndex = 49;
            this.lblBedCount.Text = "Bed Count";
            // 
            // lblName
            // 
            this.lblName.AccessibleName = "lblName";
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(27, 140);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 48;
            this.lblName.Text = "Name";
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleName = "btnSearch";
            this.btnSearch.Location = new System.Drawing.Point(245, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(53, 20);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AccessibleName = "tbSearch";
            this.txtSearch.Location = new System.Drawing.Point(94, 63);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(146, 20);
            this.txtSearch.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Search";
            // 
            // txtPrice
            // 
            this.txtPrice.AccessibleName = "tbAddress";
            this.txtPrice.Location = new System.Drawing.Point(93, 217);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(146, 20);
            this.txtPrice.TabIndex = 56;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(26, 217);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 55;
            this.lblPrice.Text = "Price";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(32, 108);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 57;
            this.lblId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(96, 109);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(142, 20);
            this.txtId.TabIndex = 58;
            // 
            // addNewWard1
            // 
            this.addNewWard1.Location = new System.Drawing.Point(346, 65);
            this.addNewWard1.Name = "addNewWard1";
            this.addNewWard1.Size = new System.Drawing.Size(404, 287);
            this.addNewWard1.TabIndex = 59;
            this.addNewWard1.Visible = false;
            // 
            // WardUserControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addNewWard1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.txtBedCount);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblBedCount);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Name = "WardUserControll";
            this.Size = new System.Drawing.Size(789, 404);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox txtBedCount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblBedCount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private AddNewWard addNewWard1;
    }
}
