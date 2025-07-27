namespace MCGI_Attendance_System
{
    partial class Update_Information
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEditChurchStatus = new System.Windows.Forms.ComboBox();
            this.dtpEditDateOfBaptism = new System.Windows.Forms.DateTimePicker();
            this.dtpEditDateofBirth = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpldoadPic = new System.Windows.Forms.Button();
            this.pictBoxReg = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEditChuchID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEditFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEditMemberID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxReg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtEditChurchStatus);
            this.groupBox1.Controls.Add(this.dtpEditDateOfBaptism);
            this.groupBox1.Controls.Add(this.dtpEditDateofBirth);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnUpldoadPic);
            this.groupBox1.Controls.Add(this.pictBoxReg);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEditChuchID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEditFullName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEditMemberID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(33, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 652);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Information";
            // 
            // txtEditChurchStatus
            // 
            this.txtEditChurchStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtEditChurchStatus.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditChurchStatus.FormattingEnabled = true;
            this.txtEditChurchStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.txtEditChurchStatus.Location = new System.Drawing.Point(472, 516);
            this.txtEditChurchStatus.Name = "txtEditChurchStatus";
            this.txtEditChurchStatus.Size = new System.Drawing.Size(303, 33);
            this.txtEditChurchStatus.TabIndex = 19;
            // 
            // dtpEditDateOfBaptism
            // 
            this.dtpEditDateOfBaptism.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpEditDateOfBaptism.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEditDateOfBaptism.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEditDateOfBaptism.Location = new System.Drawing.Point(472, 371);
            this.dtpEditDateOfBaptism.Name = "dtpEditDateOfBaptism";
            this.dtpEditDateOfBaptism.Size = new System.Drawing.Size(303, 29);
            this.dtpEditDateOfBaptism.TabIndex = 18;
            this.dtpEditDateOfBaptism.Value = new System.DateTime(2025, 7, 6, 14, 9, 38, 0);
            // 
            // dtpEditDateofBirth
            // 
            this.dtpEditDateofBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpEditDateofBirth.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEditDateofBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEditDateofBirth.Location = new System.Drawing.Point(83, 516);
            this.dtpEditDateofBirth.Name = "dtpEditDateofBirth";
            this.dtpEditDateofBirth.Size = new System.Drawing.Size(303, 29);
            this.dtpEditDateofBirth.TabIndex = 17;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(242, 588);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 33);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Cancel";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(169)))), ((int)(((byte)(92)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(472, 588);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 33);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Update";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpldoadPic
            // 
            this.btnUpldoadPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(62)))), ((int)(((byte)(131)))));
            this.btnUpldoadPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpldoadPic.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpldoadPic.ForeColor = System.Drawing.Color.White;
            this.btnUpldoadPic.Location = new System.Drawing.Point(334, 287);
            this.btnUpldoadPic.Name = "btnUpldoadPic";
            this.btnUpldoadPic.Size = new System.Drawing.Size(144, 33);
            this.btnUpldoadPic.TabIndex = 13;
            this.btnUpldoadPic.Text = "Upload Picture";
            this.btnUpldoadPic.UseVisualStyleBackColor = false;
            this.btnUpldoadPic.Click += new System.EventHandler(this.btnUpldoadPic_Click);
            // 
            // pictBoxReg
            // 
            this.pictBoxReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictBoxReg.Location = new System.Drawing.Point(281, 19);
            this.pictBoxReg.Name = "pictBoxReg";
            this.pictBoxReg.Size = new System.Drawing.Size(250, 250);
            this.pictBoxReg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBoxReg.TabIndex = 12;
            this.pictBoxReg.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(468, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date of Baptism:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 487);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Date of Birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(468, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Church Status:";
            // 
            // txtEditChuchID
            // 
            this.txtEditChuchID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditChuchID.Location = new System.Drawing.Point(472, 440);
            this.txtEditChuchID.Name = "txtEditChuchID";
            this.txtEditChuchID.Size = new System.Drawing.Size(303, 32);
            this.txtEditChuchID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(468, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Church ID:";
            // 
            // txtEditFullName
            // 
            this.txtEditFullName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditFullName.Location = new System.Drawing.Point(83, 441);
            this.txtEditFullName.Name = "txtEditFullName";
            this.txtEditFullName.Size = new System.Drawing.Size(303, 32);
            this.txtEditFullName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Full Name:";
            // 
            // txtEditMemberID
            // 
            this.txtEditMemberID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditMemberID.Location = new System.Drawing.Point(83, 368);
            this.txtEditMemberID.Name = "txtEditMemberID";
            this.txtEditMemberID.Size = new System.Drawing.Size(303, 32);
            this.txtEditMemberID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member ID:";
            // 
            // Update_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 701);
            this.Controls.Add(this.groupBox1);
            this.Name = "Update_Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Information";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Update_Information_FormClosed);
            this.Load += new System.EventHandler(this.Update_Information_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxReg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txtEditChurchStatus;
        private System.Windows.Forms.DateTimePicker dtpEditDateOfBaptism;
        private System.Windows.Forms.DateTimePicker dtpEditDateofBirth;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpldoadPic;
        private System.Windows.Forms.PictureBox pictBoxReg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEditChuchID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEditFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEditMemberID;
        private System.Windows.Forms.Label label1;
    }
}