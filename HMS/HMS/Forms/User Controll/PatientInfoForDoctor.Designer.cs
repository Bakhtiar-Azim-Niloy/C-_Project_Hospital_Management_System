
namespace HMS.Forms.User_Controll
{
    partial class PatientInfoForDoctor
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
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbReadyToRelease = new System.Windows.Forms.ComboBox();
            this.btnShpwInfoForDoctor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDeletePatientForDoctor = new System.Windows.Forms.Button();
            this.btnUpdatePatientForDoctor = new System.Windows.Forms.Button();
            this.dgvPatientInfoForDoctor = new System.Windows.Forms.DataGridView();
            this.txtPatientNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPatientDiagnosis = new System.Windows.Forms.TextBox();
            this.txtPatientSymptoms = new System.Windows.Forms.TextBox();
            this.txtPatientAge = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPatientSearchForDoctor = new System.Windows.Forms.TextBox();
            this.btnPatientSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientInfoForDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 13);
            this.label8.TabIndex = 100;
            this.label8.Text = "Search by Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(386, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 99;
            this.label3.Text = "Ready To Release";
            // 
            // cmbReadyToRelease
            // 
            this.cmbReadyToRelease.FormattingEnabled = true;
            this.cmbReadyToRelease.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbReadyToRelease.Location = new System.Drawing.Point(514, 141);
            this.cmbReadyToRelease.Name = "cmbReadyToRelease";
            this.cmbReadyToRelease.Size = new System.Drawing.Size(140, 21);
            this.cmbReadyToRelease.TabIndex = 98;
            // 
            // btnShpwInfoForDoctor
            // 
            this.btnShpwInfoForDoctor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShpwInfoForDoctor.Location = new System.Drawing.Point(649, 186);
            this.btnShpwInfoForDoctor.Name = "btnShpwInfoForDoctor";
            this.btnShpwInfoForDoctor.Size = new System.Drawing.Size(87, 23);
            this.btnShpwInfoForDoctor.TabIndex = 97;
            this.btnShpwInfoForDoctor.Text = "ShowInfo>>";
            this.btnShpwInfoForDoctor.UseVisualStyleBackColor = false;
            this.btnShpwInfoForDoctor.Click += new System.EventHandler(this.btnShpwInfoForDoctor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(288, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 20);
            this.label7.TabIndex = 96;
            this.label7.Text = "Patient Information";
            // 
            // btnDeletePatientForDoctor
            // 
            this.btnDeletePatientForDoctor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeletePatientForDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePatientForDoctor.Location = new System.Drawing.Point(249, 167);
            this.btnDeletePatientForDoctor.Name = "btnDeletePatientForDoctor";
            this.btnDeletePatientForDoctor.Size = new System.Drawing.Size(76, 28);
            this.btnDeletePatientForDoctor.TabIndex = 95;
            this.btnDeletePatientForDoctor.Text = "Delete";
            this.btnDeletePatientForDoctor.UseVisualStyleBackColor = false;
            this.btnDeletePatientForDoctor.Click += new System.EventHandler(this.btnDeletePatientForDoctor_Click);
            // 
            // btnUpdatePatientForDoctor
            // 
            this.btnUpdatePatientForDoctor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdatePatientForDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePatientForDoctor.Location = new System.Drawing.Point(110, 167);
            this.btnUpdatePatientForDoctor.Name = "btnUpdatePatientForDoctor";
            this.btnUpdatePatientForDoctor.Size = new System.Drawing.Size(76, 28);
            this.btnUpdatePatientForDoctor.TabIndex = 94;
            this.btnUpdatePatientForDoctor.Text = "Update";
            this.btnUpdatePatientForDoctor.UseVisualStyleBackColor = false;
            this.btnUpdatePatientForDoctor.Click += new System.EventHandler(this.btnUpdatePatientForDoctor_Click);
            // 
            // dgvPatientInfoForDoctor
            // 
            this.dgvPatientInfoForDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientInfoForDoctor.Location = new System.Drawing.Point(40, 215);
            this.dgvPatientInfoForDoctor.Name = "dgvPatientInfoForDoctor";
            this.dgvPatientInfoForDoctor.Size = new System.Drawing.Size(696, 157);
            this.dgvPatientInfoForDoctor.TabIndex = 93;
            // 
            // txtPatientNumber
            // 
            this.txtPatientNumber.Location = new System.Drawing.Point(514, 51);
            this.txtPatientNumber.Name = "txtPatientNumber";
            this.txtPatientNumber.Size = new System.Drawing.Size(140, 20);
            this.txtPatientNumber.TabIndex = 92;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(386, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 91;
            this.label6.Text = "Phone Number";
            // 
            // txtPatientDiagnosis
            // 
            this.txtPatientDiagnosis.Location = new System.Drawing.Point(514, 112);
            this.txtPatientDiagnosis.Name = "txtPatientDiagnosis";
            this.txtPatientDiagnosis.Size = new System.Drawing.Size(140, 20);
            this.txtPatientDiagnosis.TabIndex = 90;
            // 
            // txtPatientSymptoms
            // 
            this.txtPatientSymptoms.Location = new System.Drawing.Point(514, 83);
            this.txtPatientSymptoms.Name = "txtPatientSymptoms";
            this.txtPatientSymptoms.Size = new System.Drawing.Size(140, 20);
            this.txtPatientSymptoms.TabIndex = 89;
            // 
            // txtPatientAge
            // 
            this.txtPatientAge.Location = new System.Drawing.Point(168, 119);
            this.txtPatientAge.Name = "txtPatientAge";
            this.txtPatientAge.Size = new System.Drawing.Size(140, 20);
            this.txtPatientAge.TabIndex = 88;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(168, 93);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(140, 20);
            this.txtPatientName.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(386, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 86;
            this.label5.Text = "Diagnosis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(386, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 85;
            this.label4.Text = "Symptom\'s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 84;
            this.label2.Text = "Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 83;
            this.label1.Text = "Patient Name";
            // 
            // txtPatientSearchForDoctor
            // 
            this.txtPatientSearchForDoctor.Location = new System.Drawing.Point(55, 50);
            this.txtPatientSearchForDoctor.Name = "txtPatientSearchForDoctor";
            this.txtPatientSearchForDoctor.Size = new System.Drawing.Size(116, 20);
            this.txtPatientSearchForDoctor.TabIndex = 82;
            // 
            // btnPatientSearch
            // 
            this.btnPatientSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPatientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientSearch.Location = new System.Drawing.Point(189, 46);
            this.btnPatientSearch.Name = "btnPatientSearch";
            this.btnPatientSearch.Size = new System.Drawing.Size(69, 26);
            this.btnPatientSearch.TabIndex = 81;
            this.btnPatientSearch.Text = "Search";
            this.btnPatientSearch.UseVisualStyleBackColor = false;
            this.btnPatientSearch.Click += new System.EventHandler(this.btnPatientSearch_Click);
            // 
            // PatientInfoForDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbReadyToRelease);
            this.Controls.Add(this.btnShpwInfoForDoctor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDeletePatientForDoctor);
            this.Controls.Add(this.btnUpdatePatientForDoctor);
            this.Controls.Add(this.dgvPatientInfoForDoctor);
            this.Controls.Add(this.txtPatientNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPatientDiagnosis);
            this.Controls.Add(this.txtPatientSymptoms);
            this.Controls.Add(this.txtPatientAge);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPatientSearchForDoctor);
            this.Controls.Add(this.btnPatientSearch);
            this.Name = "PatientInfoForDoctor";
            this.Size = new System.Drawing.Size(776, 395);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientInfoForDoctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbReadyToRelease;
        private System.Windows.Forms.Button btnShpwInfoForDoctor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDeletePatientForDoctor;
        private System.Windows.Forms.Button btnUpdatePatientForDoctor;
        private System.Windows.Forms.DataGridView dgvPatientInfoForDoctor;
        private System.Windows.Forms.TextBox txtPatientNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPatientDiagnosis;
        private System.Windows.Forms.TextBox txtPatientSymptoms;
        private System.Windows.Forms.TextBox txtPatientAge;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPatientSearchForDoctor;
        private System.Windows.Forms.Button btnPatientSearch;
    }
}
