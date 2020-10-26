namespace CRUD
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnDeleteForm = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnAddNewMember = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvAllInfo = new System.Windows.Forms.DataGridView();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDayDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdButtonF = new System.Windows.Forms.RadioButton();
            this.rdButtonM = new System.Windows.Forms.RadioButton();
            this.txtBoxNumberPhone = new System.Windows.Forms.TextBox();
            this.txtBoxJob = new System.Windows.Forms.TextBox();
            this.dtmPickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtBoxAdress = new System.Windows.Forms.TextBox();
            this.txtBoxFullName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllInfo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(169)))), ((int)(((byte)(196)))));
            this.panel1.Controls.Add(this.lblFullName);
            this.panel1.Controls.Add(this.btnDeleteForm);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnShowAll);
            this.panel1.Controls.Add(this.btnAddNewMember);
            this.panel1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(691, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 531);
            this.panel1.TabIndex = 0;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(60, 46);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(0, 17);
            this.lblFullName.TabIndex = 5;
            // 
            // btnDeleteForm
            // 
            this.btnDeleteForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(163)))), ((int)(((byte)(161)))));
            this.btnDeleteForm.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteForm.Image")));
            this.btnDeleteForm.Location = new System.Drawing.Point(21, 393);
            this.btnDeleteForm.Name = "btnDeleteForm";
            this.btnDeleteForm.Size = new System.Drawing.Size(198, 78);
            this.btnDeleteForm.TabIndex = 4;
            this.btnDeleteForm.Text = "Delete Member";
            this.btnDeleteForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteForm.UseVisualStyleBackColor = false;
            this.btnDeleteForm.Click += new System.EventHandler(this.btnDeleteForm_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(163)))), ((int)(((byte)(161)))));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(21, 298);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(198, 78);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update Member";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(163)))), ((int)(((byte)(161)))));
            this.btnShowAll.Image = ((System.Drawing.Image)(resources.GetObject("btnShowAll.Image")));
            this.btnShowAll.Location = new System.Drawing.Point(21, 116);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(198, 77);
            this.btnShowAll.TabIndex = 2;
            this.btnShowAll.Text = "Show All Memebers";
            this.btnShowAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShowAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnAddNewMember
            // 
            this.btnAddNewMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(163)))), ((int)(((byte)(161)))));
            this.btnAddNewMember.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewMember.Image")));
            this.btnAddNewMember.Location = new System.Drawing.Point(21, 205);
            this.btnAddNewMember.Name = "btnAddNewMember";
            this.btnAddNewMember.Size = new System.Drawing.Size(198, 74);
            this.btnAddNewMember.TabIndex = 1;
            this.btnAddNewMember.Text = "Add New Member";
            this.btnAddNewMember.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddNewMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddNewMember.UseVisualStyleBackColor = false;
            this.btnAddNewMember.Click += new System.EventHandler(this.btnAddNewMember_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(169)))), ((int)(((byte)(196)))));
            this.panel2.Controls.Add(this.dgvAllInfo);
            this.panel2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(21, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 214);
            this.panel2.TabIndex = 1;
            // 
            // dgvAllInfo
            // 
            this.dgvAllInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(163)))), ((int)(((byte)(161)))));
            this.dgvAllInfo.ColumnHeadersHeight = 29;
            this.dgvAllInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullName,
            this.adress,
            this.birthDayDate,
            this.jobTitle,
            this.phoneNumber,
            this.sexe});
            this.dgvAllInfo.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvAllInfo.Location = new System.Drawing.Point(3, 3);
            this.dgvAllInfo.Name = "dgvAllInfo";
            this.dgvAllInfo.RowHeadersWidth = 51;
            this.dgvAllInfo.RowTemplate.Height = 24;
            this.dgvAllInfo.Size = new System.Drawing.Size(628, 208);
            this.dgvAllInfo.StandardTab = true;
            this.dgvAllInfo.TabIndex = 0;
            // 
            // fullName
            // 
            this.fullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fullName.HeaderText = "Full Name";
            this.fullName.MinimumWidth = 6;
            this.fullName.Name = "fullName";
            this.fullName.Width = 118;
            // 
            // adress
            // 
            this.adress.HeaderText = "Adress";
            this.adress.MinimumWidth = 6;
            this.adress.Name = "adress";
            this.adress.Width = 125;
            // 
            // birthDayDate
            // 
            this.birthDayDate.HeaderText = "BirthDay Date";
            this.birthDayDate.MinimumWidth = 6;
            this.birthDayDate.Name = "birthDayDate";
            this.birthDayDate.Width = 125;
            // 
            // jobTitle
            // 
            this.jobTitle.HeaderText = "Job Title";
            this.jobTitle.MinimumWidth = 6;
            this.jobTitle.Name = "jobTitle";
            this.jobTitle.Width = 125;
            // 
            // phoneNumber
            // 
            this.phoneNumber.HeaderText = "Number Phone";
            this.phoneNumber.MinimumWidth = 6;
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Width = 125;
            // 
            // sexe
            // 
            this.sexe.HeaderText = "Sexe";
            this.sexe.MinimumWidth = 6;
            this.sexe.Name = "sexe";
            this.sexe.Width = 125;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(169)))), ((int)(((byte)(196)))));
            this.panel3.Controls.Add(this.rdButtonF);
            this.panel3.Controls.Add(this.rdButtonM);
            this.panel3.Controls.Add(this.txtBoxNumberPhone);
            this.panel3.Controls.Add(this.txtBoxJob);
            this.panel3.Controls.Add(this.dtmPickerDateOfBirth);
            this.panel3.Controls.Add(this.txtBoxAdress);
            this.panel3.Controls.Add(this.txtBoxFullName);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F);
            this.panel3.Location = new System.Drawing.Point(21, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(630, 303);
            this.panel3.TabIndex = 2;
            // 
            // rdButtonF
            // 
            this.rdButtonF.AutoSize = true;
            this.rdButtonF.Location = new System.Drawing.Point(251, 255);
            this.rdButtonF.Name = "rdButtonF";
            this.rdButtonF.Size = new System.Drawing.Size(38, 21);
            this.rdButtonF.TabIndex = 14;
            this.rdButtonF.TabStop = true;
            this.rdButtonF.Text = "F";
            this.rdButtonF.UseVisualStyleBackColor = true;
            // 
            // rdButtonM
            // 
            this.rdButtonM.AutoSize = true;
            this.rdButtonM.Location = new System.Drawing.Point(190, 255);
            this.rdButtonM.Name = "rdButtonM";
            this.rdButtonM.Size = new System.Drawing.Size(38, 21);
            this.rdButtonM.TabIndex = 13;
            this.rdButtonM.TabStop = true;
            this.rdButtonM.Text = "M";
            this.rdButtonM.UseVisualStyleBackColor = true;
            // 
            // txtBoxNumberPhone
            // 
            this.txtBoxNumberPhone.Location = new System.Drawing.Point(174, 205);
            this.txtBoxNumberPhone.Name = "txtBoxNumberPhone";
            this.txtBoxNumberPhone.Size = new System.Drawing.Size(211, 25);
            this.txtBoxNumberPhone.TabIndex = 12;
            // 
            // txtBoxJob
            // 
            this.txtBoxJob.Location = new System.Drawing.Point(174, 158);
            this.txtBoxJob.Name = "txtBoxJob";
            this.txtBoxJob.Size = new System.Drawing.Size(211, 25);
            this.txtBoxJob.TabIndex = 11;
            // 
            // dtmPickerDateOfBirth
            // 
            this.dtmPickerDateOfBirth.Location = new System.Drawing.Point(174, 119);
            this.dtmPickerDateOfBirth.Name = "dtmPickerDateOfBirth";
            this.dtmPickerDateOfBirth.Size = new System.Drawing.Size(211, 25);
            this.dtmPickerDateOfBirth.TabIndex = 10;
            // 
            // txtBoxAdress
            // 
            this.txtBoxAdress.Location = new System.Drawing.Point(174, 69);
            this.txtBoxAdress.Name = "txtBoxAdress";
            this.txtBoxAdress.Size = new System.Drawing.Size(211, 25);
            this.txtBoxAdress.TabIndex = 9;
            // 
            // txtBoxFullName
            // 
            this.txtBoxFullName.Location = new System.Drawing.Point(174, 19);
            this.txtBoxFullName.Name = "txtBoxFullName";
            this.txtBoxFullName.Size = new System.Drawing.Size(211, 25);
            this.txtBoxFullName.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sexe :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phone Number :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Job :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date Of Birth :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Full Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adress :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(169)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(973, 593);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllInfo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvAllInfo;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnAddNewMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDayDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexe;
        private System.Windows.Forms.RadioButton rdButtonF;
        private System.Windows.Forms.RadioButton rdButtonM;
        private System.Windows.Forms.TextBox txtBoxNumberPhone;
        private System.Windows.Forms.TextBox txtBoxJob;
        private System.Windows.Forms.DateTimePicker dtmPickerDateOfBirth;
        private System.Windows.Forms.TextBox txtBoxAdress;
        private System.Windows.Forms.TextBox txtBoxFullName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeleteForm;
        private System.Windows.Forms.Label lblFullName;
    }
}

