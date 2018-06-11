namespace AbstractHotelView
{
    partial class FormZakaz
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
            this.labelPosetitel = new System.Windows.Forms.Label();
            this.comboBoxPosetitel = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRef = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonUpd = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelPogashenie = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.dateTimePickerCredit = new System.Windows.Forms.DateTimePicker();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxOplata = new System.Windows.Forms.TextBox();
            this.labelOplata = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPosetitel
            // 
            this.labelPosetitel.AutoSize = true;
            this.labelPosetitel.Location = new System.Drawing.Point(11, 9);
            this.labelPosetitel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPosetitel.Name = "labelPosetitel";
            this.labelPosetitel.Size = new System.Drawing.Size(70, 13);
            this.labelPosetitel.TabIndex = 2;
            this.labelPosetitel.Text = "Посетитель:";
            // 
            // comboBoxPosetitel
            // 
            this.comboBoxPosetitel.FormattingEnabled = true;
            this.comboBoxPosetitel.Location = new System.Drawing.Point(84, 6);
            this.comboBoxPosetitel.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPosetitel.Name = "comboBoxPosetitel";
            this.comboBoxPosetitel.Size = new System.Drawing.Size(176, 21);
            this.comboBoxPosetitel.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.buttonRef);
            this.groupBox1.Controls.Add(this.buttonDel);
            this.groupBox1.Controls.Add(this.buttonUpd);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Location = new System.Drawing.Point(11, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(540, 284);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Услуги";
            // 
            // buttonRef
            // 
            this.buttonRef.Location = new System.Drawing.Point(422, 190);
            this.buttonRef.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRef.Name = "buttonRef";
            this.buttonRef.Size = new System.Drawing.Size(110, 40);
            this.buttonRef.TabIndex = 19;
            this.buttonRef.Text = "Обновить";
            this.buttonRef.UseVisualStyleBackColor = true;
            this.buttonRef.Click += new System.EventHandler(this.buttonRef_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(422, 134);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(110, 37);
            this.buttonDel.TabIndex = 18;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonUpd_Click);
            // 
            // buttonUpd
            // 
            this.buttonUpd.Location = new System.Drawing.Point(422, 75);
            this.buttonUpd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpd.Name = "buttonUpd";
            this.buttonUpd.Size = new System.Drawing.Size(110, 40);
            this.buttonUpd.TabIndex = 17;
            this.buttonUpd.Text = "Изменить";
            this.buttonUpd.UseVisualStyleBackColor = true;
            this.buttonUpd.Click += new System.EventHandler(this.buttonUpd_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(422, 17);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(110, 43);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 17);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(418, 267);
            this.dataGridView.TabIndex = 0;
            // 
            // labelPogashenie
            // 
            this.labelPogashenie.AutoSize = true;
            this.labelPogashenie.Location = new System.Drawing.Point(11, 334);
            this.labelPogashenie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPogashenie.Name = "labelPogashenie";
            this.labelPogashenie.Size = new System.Drawing.Size(94, 13);
            this.labelPogashenie.TabIndex = 5;
            this.labelPogashenie.Text = "Дата погашения:";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(11, 363);
            this.labelSum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(44, 13);
            this.labelSum.TabIndex = 6;
            this.labelSum.Text = "Сумма:";
            // 
            // dateTimePickerCredit
            // 
            this.dateTimePickerCredit.Location = new System.Drawing.Point(109, 329);
            this.dateTimePickerCredit.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerCredit.Name = "dateTimePickerCredit";
            this.dateTimePickerCredit.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerCredit.TabIndex = 7;
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(109, 363);
            this.textBoxSum.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(151, 20);
            this.textBoxSum.TabIndex = 8;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(336, 379);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(93, 39);
            this.buttonSave.TabIndex = 32;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(458, 379);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(93, 38);
            this.buttonCancel.TabIndex = 33;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxOplata
            // 
            this.textBoxOplata.Location = new System.Drawing.Point(109, 394);
            this.textBoxOplata.Name = "textBoxOplata";
            this.textBoxOplata.Size = new System.Drawing.Size(151, 20);
            this.textBoxOplata.TabIndex = 34;
            // 
            // labelOplata
            // 
            this.labelOplata.AutoSize = true;
            this.labelOplata.Location = new System.Drawing.Point(11, 397);
            this.labelOplata.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOplata.Name = "labelOplata";
            this.labelOplata.Size = new System.Drawing.Size(84, 13);
            this.labelOplata.TabIndex = 35;
            this.labelOplata.Text = "Сумма оплаты:";
            // 
            // FormZakaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(566, 426);
            this.Controls.Add(this.labelOplata);
            this.Controls.Add(this.textBoxOplata);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.dateTimePickerCredit);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.labelPogashenie);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxPosetitel);
            this.Controls.Add(this.labelPosetitel);
            this.Name = "FormZakaz";
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.FormZakaz_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPosetitel;
        private System.Windows.Forms.ComboBox comboBoxPosetitel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRef;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonUpd;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelPogashenie;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.DateTimePicker dateTimePickerCredit;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxOplata;
        private System.Windows.Forms.Label labelOplata;
    }
}