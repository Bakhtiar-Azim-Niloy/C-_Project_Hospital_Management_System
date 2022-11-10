
namespace HMS.Forms.User_Controll
{
    partial class CheckOutUserControl
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
            this.btnShowInfoPatient = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtPatientPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchCheckout = new System.Windows.Forms.TextBox();
            this.btnCheckoutSearch = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvPatientCheckOut = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReadyToRelease = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientCheckOut)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowInfoPatient
            // 
            this.btnShowInfoPatient.Location = new System.Drawing.Point(507, 35);
            this.btnShowInfoPatient.Name = "btnShowInfoPatient";
            this.btnShowInfoPatient.Size = new System.Drawing.Size(75, 23);
            this.btnShowInfoPatient.TabIndex = 114;
            this.btnShowInfoPatient.Text = "ShowInfo>>";
            this.btnShowInfoPatient.UseVisualStyleBackColor = true;
            this.btnShowInfoPatient.Click += new System.EventHandler(this.btnShowInfoPatient_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(395, 280);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(94, 28);
            this.btnCheckout.TabIndex = 113;
            this.btnCheckout.Text = "Check Out";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(395, 228);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(121, 20);
            this.txtStatus.TabIndex = 112;
            // 
            // txtPatientPhoneNumber
            // 
            this.txtPatientPhoneNumber.Location = new System.Drawing.Point(117, 225);
            this.txtPatientPhoneNumber.Name = "txtPatientPhoneNumber";
            this.txtPatientPhoneNumber.Size = new System.Drawing.Size(121, 20);
            this.txtPatientPhoneNumber.TabIndex = 102;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(117, 185);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(121, 20);
            this.txtPatientName.TabIndex = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 96;
            this.label4.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "Patient Name";
            // 
            // txtSearchCheckout
            // 
            this.txtSearchCheckout.Location = new System.Drawing.Point(13, 38);
            this.txtSearchCheckout.Name = "txtSearchCheckout";
            this.txtSearchCheckout.Size = new System.Drawing.Size(121, 20);
            this.txtSearchCheckout.TabIndex = 93;
            // 
            // btnCheckoutSearch
            // 
            this.btnCheckoutSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCheckoutSearch.Location = new System.Drawing.Point(140, 38);
            this.btnCheckoutSearch.Name = "btnCheckoutSearch";
            this.btnCheckoutSearch.Size = new System.Drawing.Size(86, 20);
            this.btnCheckoutSearch.TabIndex = 92;
            this.btnCheckoutSearch.Text = "Search";
            this.btnCheckoutSearch.UseVisualStyleBackColor = false;
            this.btnCheckoutSearch.Click += new System.EventHandler(this.btnCheckoutSearch_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(248, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 20);
            this.label14.TabIndex = 91;
            this.label14.Text = "Check Out";
            // 
            // dgvPatientCheckOut
            // 
            this.dgvPatientCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientCheckOut.Location = new System.Drawing.Point(3, 64);
            this.dgvPatientCheckOut.Name = "dgvPatientCheckOut";
            this.dgvPatientCheckOut.Size = new System.Drawing.Size(597, 103);
            this.dgvPatientCheckOut.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 117;
            this.label3.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 119;
            this.label2.Text = "Checkout Date";
            // 
            // dtpCheckOutDate
            // 
            this.dtpCheckOutDate.CustomFormat = "dd-MM-yyy";
            this.dtpCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckOutDate.Location = new System.Drawing.Point(396, 184);
            this.dtpCheckOutDate.Name = "dtpCheckOutDate";
            this.dtpCheckOutDate.Size = new System.Drawing.Size(120, 20);
            this.dtpCheckOutDate.TabIndex = 120;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 122;
            this.label6.Text = "Ready To  Release";
            // 
            // txtReadyToRelease
            // 
            this.txtReadyToRelease.Location = new System.Drawing.Point(117, 262);
            this.txtReadyToRelease.Name = "txtReadyToRelease";
            this.txtReadyToRelease.ReadOnly = true;
            this.txtReadyToRelease.Size = new System.Drawing.Size(121, 20);
            this.txtReadyToRelease.TabIndex = 121;
            // 
            // CheckOutUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtReadyToRelease);
            this.Controls.Add(this.dtpCheckOutDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnShowInfoPatient);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtPatientPhoneNumber);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchCheckout);
            this.Controls.Add(this.btnCheckoutSearch);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dgvPatientCheckOut);
            this.Name = "CheckOutUserControl";
            this.Size = new System.Drawing.Size(603, 364);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientCheckOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowInfoPatient;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtPatientPhoneNumber;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchCheckout;
        private System.Windows.Forms.Button btnCheckoutSearch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvPatientCheckOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpCheckOutDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReadyToRelease;
    }
}
