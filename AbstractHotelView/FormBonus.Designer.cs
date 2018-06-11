namespace AbstractHotelView
{
    partial class FormBonus
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
            this.labelFIO = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.labelSum = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(11, 9);
            this.labelFIO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(37, 13);
            this.labelFIO.TabIndex = 7;
            this.labelFIO.Text = "ФИО:";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Enabled = false;
            this.textBoxFIO.Location = new System.Drawing.Point(81, 6);
            this.textBoxFIO.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(212, 20);
            this.textBoxFIO.TabIndex = 8;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(11, 40);
            this.labelSum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(66, 26);
            this.labelSum.TabIndex = 9;
            this.labelSum.Text = "Количество\r\nбонусов:";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(81, 46);
            this.textBoxSum.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(212, 20);
            this.textBoxSum.TabIndex = 10;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(81, 87);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(80, 24);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(213, 87);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(80, 24);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormBonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(309, 120);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.labelFIO);
            this.Name = "FormBonus";
            this.Text = "Бонусы";
            this.Load += new System.EventHandler(this.FormAddBonuses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}