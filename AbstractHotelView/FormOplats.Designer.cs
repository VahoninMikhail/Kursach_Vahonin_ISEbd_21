namespace AbstractHotelView
{
    partial class FormOplats
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
            this.labelFrom = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.labelTo = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonSendCreadits = new System.Windows.Forms.Button();
            this.buttonPdf = new System.Windows.Forms.Button();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(11, 13);
            this.labelFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(14, 13);
            this.labelFrom.TabIndex = 8;
            this.labelFrom.Text = "C";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(29, 9);
            this.dateTimePickerFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerFrom.TabIndex = 9;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(184, 13);
            this.labelTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(19, 13);
            this.labelTo.TabIndex = 10;
            this.labelTo.Text = "по";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(207, 9);
            this.dateTimePickerTo.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerTo.TabIndex = 11;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(373, 9);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(110, 23);
            this.buttonCreate.TabIndex = 12;
            this.buttonCreate.Text = "Сформировать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonSendCreadits
            // 
            this.buttonSendCreadits.Location = new System.Drawing.Point(496, 9);
            this.buttonSendCreadits.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSendCreadits.Name = "buttonSendCreadits";
            this.buttonSendCreadits.Size = new System.Drawing.Size(135, 23);
            this.buttonSendCreadits.TabIndex = 13;
            this.buttonSendCreadits.Text = "Разослать долги";
            this.buttonSendCreadits.UseVisualStyleBackColor = true;
            this.buttonSendCreadits.Click += new System.EventHandler(this.buttonSendCreadits_Click);
            // 
            // buttonPdf
            // 
            this.buttonPdf.Location = new System.Drawing.Point(647, 10);
            this.buttonPdf.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPdf.Name = "buttonPdf";
            this.buttonPdf.Size = new System.Drawing.Size(87, 23);
            this.buttonPdf.TabIndex = 14;
            this.buttonPdf.Text = "В Pdf";
            this.buttonPdf.UseVisualStyleBackColor = true;
            this.buttonPdf.Click += new System.EventHandler(this.buttonPdf_Click);
            this.buttonPdf.Move += new System.EventHandler(this.buttonPdf_Click);
            // 
            // reportViewer
            // 
            this.reportViewer.BackColor = System.Drawing.Color.LightGray;
            this.reportViewer.LocalReport.ReportEmbeddedResource = "AbstractHotelView.ReportOplats.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(1, 36);
            this.reportViewer.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(748, 406);
            this.reportViewer.TabIndex = 15;
            // 
            // FormOplats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(751, 444);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.buttonPdf);
            this.Controls.Add(this.buttonSendCreadits);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.labelFrom);
            this.Name = "FormOplats";
            this.Text = "Оплата заказов";
            this.Load += new System.EventHandler(this.FormOplats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonSendCreadits;
        private System.Windows.Forms.Button buttonPdf;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
    }
}