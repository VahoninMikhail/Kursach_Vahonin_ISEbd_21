namespace AbstractHotelView
{
    partial class FormShtraf
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
            this.labelShtraf = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
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
            this.labelFIO.TabIndex = 13;
            this.labelFIO.Text = "ФИО:";
            // 
            // labelShtraf
            // 
            this.labelShtraf.AutoSize = true;
            this.labelShtraf.Location = new System.Drawing.Point(11, 39);
            this.labelShtraf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelShtraf.Name = "labelShtraf";
            this.labelShtraf.Size = new System.Drawing.Size(49, 26);
            this.labelShtraf.TabIndex = 15;
            this.labelShtraf.Text = "Сумма\r\nштрафа:";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Enabled = false;
            this.textBoxFIO.Location = new System.Drawing.Point(64, 9);
            this.textBoxFIO.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(190, 20);
            this.textBoxFIO.TabIndex = 16;
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(64, 45);
            this.textBoxSum.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(190, 20);
            this.textBoxSum.TabIndex = 17;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(64, 79);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(80, 24);
            this.buttonSave.TabIndex = 18;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(174, 79);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(80, 24);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormShtraf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(266, 109);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.labelShtraf);
            this.Controls.Add(this.labelFIO);
            this.Name = "FormShtraf";
            this.Text = "Штраф";
            this.Load += new System.EventHandler(this.FormShtraf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelShtraf;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}