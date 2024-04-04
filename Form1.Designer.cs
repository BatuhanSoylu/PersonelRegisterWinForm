namespace PersonelRegisterWinForm
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
            this.dgwShowData = new System.Windows.Forms.DataGridView();
            this.groupRegister = new System.Windows.Forms.GroupBox();
            this.comboUserRoles = new System.Windows.Forms.ComboBox();
            this.checkEnabled = new System.Windows.Forms.CheckBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupNavbar = new System.Windows.Forms.GroupBox();
            this.checkHide = new System.Windows.Forms.CheckBox();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwShowData)).BeginInit();
            this.groupRegister.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupNavbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwShowData
            // 
            this.dgwShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwShowData.Location = new System.Drawing.Point(12, 128);
            this.dgwShowData.Name = "dgwShowData";
            this.dgwShowData.RowHeadersWidth = 51;
            this.dgwShowData.RowTemplate.Height = 24;
            this.dgwShowData.Size = new System.Drawing.Size(568, 496);
            this.dgwShowData.TabIndex = 8;
            // 
            // groupRegister
            // 
            this.groupRegister.Controls.Add(this.comboUserRoles);
            this.groupRegister.Controls.Add(this.checkEnabled);
            this.groupRegister.Controls.Add(this.txtEmail);
            this.groupRegister.Controls.Add(this.txtPhone);
            this.groupRegister.Controls.Add(this.txtDisplay);
            this.groupRegister.Controls.Add(this.txtUserName);
            this.groupRegister.Controls.Add(this.label7);
            this.groupRegister.Controls.Add(this.label6);
            this.groupRegister.Controls.Add(this.label5);
            this.groupRegister.Controls.Add(this.label4);
            this.groupRegister.Controls.Add(this.label3);
            this.groupRegister.Controls.Add(this.label2);
            this.groupRegister.Controls.Add(this.groupBox1);
            this.groupRegister.Location = new System.Drawing.Point(605, 128);
            this.groupRegister.Name = "groupRegister";
            this.groupRegister.Size = new System.Drawing.Size(561, 496);
            this.groupRegister.TabIndex = 7;
            this.groupRegister.TabStop = false;
            this.groupRegister.Visible = false;
            // 
            // comboUserRoles
            // 
            this.comboUserRoles.FormattingEnabled = true;
            this.comboUserRoles.Items.AddRange(new object[] {
            "Guest",
            "Admin",
            "Superadmin"});
            this.comboUserRoles.Location = new System.Drawing.Point(267, 330);
            this.comboUserRoles.Name = "comboUserRoles";
            this.comboUserRoles.Size = new System.Drawing.Size(160, 24);
            this.comboUserRoles.TabIndex = 13;
            // 
            // checkEnabled
            // 
            this.checkEnabled.AutoSize = true;
            this.checkEnabled.Location = new System.Drawing.Point(267, 378);
            this.checkEnabled.Name = "checkEnabled";
            this.checkEnabled.Size = new System.Drawing.Size(18, 17);
            this.checkEnabled.TabIndex = 12;
            this.checkEnabled.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(267, 289);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(160, 22);
            this.txtEmail.TabIndex = 10;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(267, 246);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(160, 22);
            this.txtPhone.TabIndex = 9;
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(267, 207);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(160, 22);
            this.txtDisplay.TabIndex = 8;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(267, 164);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(160, 22);
            this.txtUserName.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Enabled  : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "User Roles : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Display Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(188, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "New User";
            // 
            // groupNavbar
            // 
            this.groupNavbar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupNavbar.Controls.Add(this.checkHide);
            this.groupNavbar.Controls.Add(this.btnNewUser);
            this.groupNavbar.Controls.Add(this.btnSave);
            this.groupNavbar.Location = new System.Drawing.Point(12, 12);
            this.groupNavbar.Name = "groupNavbar";
            this.groupNavbar.Size = new System.Drawing.Size(1154, 100);
            this.groupNavbar.TabIndex = 6;
            this.groupNavbar.TabStop = false;
            // 
            // checkHide
            // 
            this.checkHide.AutoSize = true;
            this.checkHide.Location = new System.Drawing.Point(183, 33);
            this.checkHide.Name = "checkHide";
            this.checkHide.Size = new System.Drawing.Size(148, 20);
            this.checkHide.TabIndex = 2;
            this.checkHide.Text = "Hide Disabled User";
            this.checkHide.UseVisualStyleBackColor = true;
            this.checkHide.CheckedChanged += new System.EventHandler(this.checkHide_CheckedChanged);
            // 
            // btnNewUser
            // 
            this.btnNewUser.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNewUser.Location = new System.Drawing.Point(24, 21);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(119, 45);
            this.btnNewUser.TabIndex = 1;
            this.btnNewUser.Text = "+ New User";
            this.btnNewUser.UseVisualStyleBackColor = false;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Location = new System.Drawing.Point(999, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 45);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 646);
            this.Controls.Add(this.dgwShowData);
            this.Controls.Add(this.groupRegister);
            this.Controls.Add(this.groupNavbar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwShowData)).EndInit();
            this.groupRegister.ResumeLayout(false);
            this.groupRegister.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupNavbar.ResumeLayout(false);
            this.groupNavbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwShowData;
        private System.Windows.Forms.GroupBox groupRegister;
        private System.Windows.Forms.ComboBox comboUserRoles;
        private System.Windows.Forms.CheckBox checkEnabled;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupNavbar;
        private System.Windows.Forms.CheckBox checkHide;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Button btnSave;
    }
}

