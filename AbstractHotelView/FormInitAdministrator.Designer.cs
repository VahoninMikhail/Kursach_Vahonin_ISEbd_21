namespace AbstractHotelView
{
    partial class FormInitAdministrator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxConfimPassword = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "ФИО: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Логин: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Пароль: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 26);
            this.label4.TabIndex = 28;
            this.label4.Text = "Подтверждение\r\nпароля:";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(108, 9);
            this.textBoxFIO.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(191, 20);
            this.textBoxFIO.TabIndex = 29;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(108, 38);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(191, 20);
            this.textBoxLogin.TabIndex = 30;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(108, 71);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.MaxLength = 15;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(191, 20);
            this.textBoxPassword.TabIndex = 31;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxConfimPassword
            // 
            this.textBoxConfimPassword.Location = new System.Drawing.Point(108, 107);
            this.textBoxConfimPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxConfimPassword.MaxLength = 15;
            this.textBoxConfimPassword.Name = "textBoxConfimPassword";
            this.textBoxConfimPassword.Size = new System.Drawing.Size(191, 20);
            this.textBoxConfimPassword.TabIndex = 32;
            this.textBoxConfimPassword.UseSystemPasswordChar = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(108, 141);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(78, 21);
            this.buttonSave.TabIndex = 33;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(221, 141);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(78, 21);
            this.buttonCancel.TabIndex = 34;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormInitAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(319, 172);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxConfimPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormInitAdministrator";
            this.Text = "Регистрация администратора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxConfimPassword;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}