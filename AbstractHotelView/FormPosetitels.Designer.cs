namespace AbstractHotelView
{
    partial class FormPosetitels
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonBonus = new System.Windows.Forms.Button();
            this.buttonShtraf = new System.Windows.Forms.Button();
            this.buttonAccount = new System.Windows.Forms.Button();
            this.buttonRef = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(1, 1);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(488, 337);
            this.dataGridView.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(504, 11);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(110, 28);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpd
            // 
            this.buttonUpd.Location = new System.Drawing.Point(504, 54);
            this.buttonUpd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpd.Name = "buttonUpd";
            this.buttonUpd.Size = new System.Drawing.Size(110, 34);
            this.buttonUpd.TabIndex = 11;
            this.buttonUpd.Text = "Изменить";
            this.buttonUpd.UseVisualStyleBackColor = true;
            this.buttonUpd.Click += new System.EventHandler(this.buttonUpd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(504, 102);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(110, 33);
            this.buttonDel.TabIndex = 12;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonBonus
            // 
            this.buttonBonus.Location = new System.Drawing.Point(504, 150);
            this.buttonBonus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBonus.Name = "buttonBonus";
            this.buttonBonus.Size = new System.Drawing.Size(110, 35);
            this.buttonBonus.TabIndex = 13;
            this.buttonBonus.Text = "Начислить бонусы";
            this.buttonBonus.UseVisualStyleBackColor = true;
            this.buttonBonus.Click += new System.EventHandler(this.buttonBonus_Click);
            // 
            // buttonShtraf
            // 
            this.buttonShtraf.Location = new System.Drawing.Point(504, 199);
            this.buttonShtraf.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShtraf.Name = "buttonShtraf";
            this.buttonShtraf.Size = new System.Drawing.Size(110, 34);
            this.buttonShtraf.TabIndex = 14;
            this.buttonShtraf.Text = "Начислить штраф";
            this.buttonShtraf.UseVisualStyleBackColor = true;
            this.buttonShtraf.Click += new System.EventHandler(this.buttonShtraf_Click);
            // 
            // buttonAccount
            // 
            this.buttonAccount.Location = new System.Drawing.Point(504, 247);
            this.buttonAccount.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(110, 34);
            this.buttonAccount.TabIndex = 16;
            this.buttonAccount.Text = "Отправить счет";
            this.buttonAccount.UseVisualStyleBackColor = true;
            this.buttonAccount.Click += new System.EventHandler(this.buttonAccount_Click);
            // 
            // buttonRef
            // 
            this.buttonRef.Location = new System.Drawing.Point(504, 294);
            this.buttonRef.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRef.Name = "buttonRef";
            this.buttonRef.Size = new System.Drawing.Size(110, 34);
            this.buttonRef.TabIndex = 17;
            this.buttonRef.Text = "Обновить";
            this.buttonRef.UseVisualStyleBackColor = true;
            this.buttonRef.Click += new System.EventHandler(this.buttonRef_Click);
            // 
            // FormPosetitels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(633, 339);
            this.Controls.Add(this.buttonRef);
            this.Controls.Add(this.buttonAccount);
            this.Controls.Add(this.buttonShtraf);
            this.Controls.Add(this.buttonBonus);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonUpd);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormPosetitels";
            this.Text = "Посетители";
            this.Load += new System.EventHandler(this.FormPosetitels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonBonus;
        private System.Windows.Forms.Button buttonShtraf;
        private System.Windows.Forms.Button buttonAccount;
        private System.Windows.Forms.Button buttonRef;
    }
}