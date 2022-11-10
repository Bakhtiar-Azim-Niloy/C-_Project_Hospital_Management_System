
namespace HMS.Forms.User_Controll
{
    partial class Prescription
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowPatinetInfo = new System.Windows.Forms.Button();
            this.btnUpdatePrescription = new System.Windows.Forms.Button();
            this.txtPatientPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrescription = new System.Windows.Forms.TextBox();
            this.txtSearchPrescription = new System.Windows.Forms.TextBox();
            this.btnSearchPrescription = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvPrescription = new System.Windows.Forms.DataGridView();
            this.lblPrescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescription)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Search by Phone Number";
            // 
            // btnShowPatinetInfo
            // 
            this.btnShowPatinetInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShowPatinetInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPatinetInfo.Location = new System.Drawing.Point(551, 269);
            this.btnShowPatinetInfo.Name = "btnShowPatinetInfo";
            this.btnShowPatinetInfo.Size = new System.Drawing.Size(75, 24);
            this.btnShowPatinetInfo.TabIndex = 72;
            this.btnShowPatinetInfo.Text = "ShowInfo>>";
            this.btnShowPatinetInfo.UseVisualStyleBackColor = false;
            this.btnShowPatinetInfo.Click += new System.EventHandler(this.btnShowPatinetInfo_Click);
            // 
            // btnUpdatePrescription
            // 
            this.btnUpdatePrescription.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdatePrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePrescription.Location = new System.Drawing.Point(344, 236);
            this.btnUpdatePrescription.Name = "btnUpdatePrescription";
            this.btnUpdatePrescription.Size = new System.Drawing.Size(75, 29);
            this.btnUpdatePrescription.TabIndex = 71;
            this.btnUpdatePrescription.Text = "Update";
            this.btnUpdatePrescription.UseVisualStyleBackColor = false;
            this.btnUpdatePrescription.Click += new System.EventHandler(this.btnUpdatePrescription_Click);
            // 
            // txtPatientPhoneNumber
            // 
            this.txtPatientPhoneNumber.Location = new System.Drawing.Point(473, 66);
            this.txtPatientPhoneNumber.Name = "txtPatientPhoneNumber";
            this.txtPatientPhoneNumber.Size = new System.Drawing.Size(121, 20);
            this.txtPatientPhoneNumber.TabIndex = 70;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(140, 65);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(121, 20);
            this.txtPatientName.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 68;
            this.label1.Text = "Phone Number";
            // 
            // txtPrescription
            // 
            this.txtPrescription.Location = new System.Drawing.Point(187, 104);
            this.txtPrescription.Multiline = true;
            this.txtPrescription.Name = "txtPrescription";
            this.txtPrescription.Size = new System.Drawing.Size(450, 126);
            this.txtPrescription.TabIndex = 67;
            // 
            // txtSearchPrescription
            // 
            this.txtSearchPrescription.Location = new System.Drawing.Point(30, 24);
            this.txtSearchPrescription.Name = "txtSearchPrescription";
            this.txtSearchPrescription.Size = new System.Drawing.Size(121, 20);
            this.txtSearchPrescription.TabIndex = 66;
            // 
            // btnSearchPrescription
            // 
            this.btnSearchPrescription.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchPrescription.Location = new System.Drawing.Point(167, 22);
            this.btnSearchPrescription.Name = "btnSearchPrescription";
            this.btnSearchPrescription.Size = new System.Drawing.Size(94, 26);
            this.btnSearchPrescription.TabIndex = 65;
            this.btnSearchPrescription.Text = "Search";
            this.btnSearchPrescription.UseVisualStyleBackColor = false;
            this.btnSearchPrescription.Click += new System.EventHandler(this.btnSearchPrescription_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(27, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 16);
            this.label12.TabIndex = 64;
            this.label12.Text = "Patient Name";
            // 
            // dgvPrescription
            // 
            this.dgvPrescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrescription.Location = new System.Drawing.Point(3, 299);
            this.dgvPrescription.Name = "dgvPrescription";
            this.dgvPrescription.Size = new System.Drawing.Size(647, 103);
            this.dgvPrescription.TabIndex = 63;
            // 
            // lblPrescription
            // 
            this.lblPrescription.AutoSize = true;
            this.lblPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrescription.Location = new System.Drawing.Point(35, 155);
            this.lblPrescription.Name = "lblPrescription";
            this.lblPrescription.Size = new System.Drawing.Size(121, 24);
            this.lblPrescription.TabIndex = 62;
            this.lblPrescription.Text = "Prescription";
            // 
            // Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShowPatinetInfo);
            this.Controls.Add(this.btnUpdatePrescription);
            this.Controls.Add(this.txtPatientPhoneNumber);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrescription);
            this.Controls.Add(this.txtSearchPrescription);
            this.Controls.Add(this.btnSearchPrescription);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvPrescription);
            this.Controls.Add(this.lblPrescription);
            this.Name = "Prescription";
            this.Size = new System.Drawing.Size(653, 410);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowPatinetInfo;
        private System.Windows.Forms.Button btnUpdatePrescription;
        private System.Windows.Forms.TextBox txtPatientPhoneNumber;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrescription;
        private System.Windows.Forms.TextBox txtSearchPrescription;
        private System.Windows.Forms.Button btnSearchPrescription;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvPrescription;
        private System.Windows.Forms.Label lblPrescription;
    }
}
