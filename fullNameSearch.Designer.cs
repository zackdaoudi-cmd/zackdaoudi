namespace CRUD
{
    partial class fullNameSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fullNameSearch));
            this.txtBoxSearchByFullName = new System.Windows.Forms.TextBox();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxSearchByFullName
            // 
            this.txtBoxSearchByFullName.Location = new System.Drawing.Point(69, 119);
            this.txtBoxSearchByFullName.Name = "txtBoxSearchByFullName";
            this.txtBoxSearchByFullName.Size = new System.Drawing.Size(250, 22);
            this.txtBoxSearchByFullName.TabIndex = 0;
            // 
            // btnSearch1
            // 
            this.btnSearch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(163)))), ((int)(((byte)(161)))));
            this.btnSearch1.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch1.Image")));
            this.btnSearch1.Location = new System.Drawing.Point(89, 158);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(198, 78);
            this.btnSearch1.TabIndex = 4;
            this.btnSearch1.Text = "Update Member";
            this.btnSearch1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearch1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSearch1.UseVisualStyleBackColor = false;
            this.btnSearch1.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search By FullName :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Please Write Full Name :";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(216, 256);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(0, 17);
            this.lblTest.TabIndex = 7;
            // 
            // fullNameSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(169)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(386, 296);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch1);
            this.Controls.Add(this.txtBoxSearchByFullName);
            this.Name = "fullNameSearch";
            this.Text = " Search By Full Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxSearchByFullName;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTest;
    }
}