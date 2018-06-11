namespace AbstractHotelView
{
    partial class FormPosetitelZakaz
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxXls = new System.Windows.Forms.CheckBox();
            this.checkBoxDoc = new System.Windows.Forms.CheckBox();
            this.buttonSend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 1);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(720, 354);
            this.dataGridView.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.checkBoxXls);
            this.groupBox1.Controls.Add(this.checkBoxDoc);
            this.groupBox1.Location = new System.Drawing.Point(742, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(76, 67);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Формат";
            // 
            // checkBoxXls
            // 
            this.checkBoxXls.AutoSize = true;
            this.checkBoxXls.Location = new System.Drawing.Point(14, 38);
            this.checkBoxXls.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxXls.Name = "checkBoxXls";
            this.checkBoxXls.Size = new System.Drawing.Size(41, 17);
            this.checkBoxXls.TabIndex = 1;
            this.checkBoxXls.Text = ".xls";
            this.checkBoxXls.UseVisualStyleBackColor = true;
            // 
            // checkBoxDoc
            // 
            this.checkBoxDoc.AutoSize = true;
            this.checkBoxDoc.Location = new System.Drawing.Point(14, 17);
            this.checkBoxDoc.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxDoc.Name = "checkBoxDoc";
            this.checkBoxDoc.Size = new System.Drawing.Size(47, 17);
            this.checkBoxDoc.TabIndex = 0;
            this.checkBoxDoc.Text = ".doc";
            this.checkBoxDoc.UseVisualStyleBackColor = true;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(742, 99);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(76, 32);
            this.buttonSend.TabIndex = 7;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // FormPosetitelZakaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(836, 358);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormPosetitelZakaz";
            this.Text = "Заказы посетителей";
            this.Load += new System.EventHandler(this.FormPosetitelZakaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxXls;
        private System.Windows.Forms.CheckBox checkBoxDoc;
        private System.Windows.Forms.Button buttonSend;
    }
}