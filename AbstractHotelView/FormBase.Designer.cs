namespace AbstractHotelView
{
    partial class FormBase
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.админыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посетителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заблокироватьПосетителейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоОплатамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonRef = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.заблокироватьПосетителейToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.админыToolStripMenuItem,
            this.посетителиToolStripMenuItem,
            this.заказыToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // админыToolStripMenuItem
            // 
            this.админыToolStripMenuItem.Name = "админыToolStripMenuItem";
            this.админыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.админыToolStripMenuItem.Text = "Админы";
            this.админыToolStripMenuItem.Click += new System.EventHandler(this.админыToolStripMenuItem_Click);
            // 
            // посетителиToolStripMenuItem
            // 
            this.посетителиToolStripMenuItem.Name = "посетителиToolStripMenuItem";
            this.посетителиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.посетителиToolStripMenuItem.Text = "Посетители";
            this.посетителиToolStripMenuItem.Click += new System.EventHandler(this.посетителиToolStripMenuItem_Click);
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.заказыToolStripMenuItem.Text = "Заказы";
            this.заказыToolStripMenuItem.Click += new System.EventHandler(this.заказыToolStripMenuItem_Click);
            // 
            // заблокироватьПосетителейToolStripMenuItem
            // 
            this.заблокироватьПосетителейToolStripMenuItem.Name = "заблокироватьПосетителейToolStripMenuItem";
            this.заблокироватьПосетителейToolStripMenuItem.Size = new System.Drawing.Size(175, 20);
            this.заблокироватьПосетителейToolStripMenuItem.Text = "Заблокировать посетителей";
            this.заблокироватьПосетителейToolStripMenuItem.Click += new System.EventHandler(this.заблокироватьПосетителейToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетПоОплатамToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // отчетПоОплатамToolStripMenuItem
            // 
            this.отчетПоОплатамToolStripMenuItem.Name = "отчетПоОплатамToolStripMenuItem";
            this.отчетПоОплатамToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.отчетПоОплатамToolStripMenuItem.Text = "Отчет по оплатам";
            this.отчетПоОплатамToolStripMenuItem.Click += new System.EventHandler(this.отчетПоОплатамToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(263, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Услуги";
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(5, 57);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(572, 334);
            this.dataGridView.TabIndex = 12;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(594, 57);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 42);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpd
            // 
            this.buttonUpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpd.Location = new System.Drawing.Point(594, 121);
            this.buttonUpd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpd.Name = "buttonUpd";
            this.buttonUpd.Size = new System.Drawing.Size(125, 49);
            this.buttonUpd.TabIndex = 14;
            this.buttonUpd.Text = "Изменить";
            this.buttonUpd.UseVisualStyleBackColor = true;
            this.buttonUpd.Click += new System.EventHandler(this.buttonUpd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.Location = new System.Drawing.Point(594, 194);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(125, 54);
            this.buttonDel.TabIndex = 15;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonRef
            // 
            this.buttonRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRef.Location = new System.Drawing.Point(594, 274);
            this.buttonRef.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRef.Name = "buttonRef";
            this.buttonRef.Size = new System.Drawing.Size(125, 54);
            this.buttonRef.TabIndex = 16;
            this.buttonRef.Text = "Обновить";
            this.buttonRef.UseVisualStyleBackColor = true;
            this.buttonRef.Click += new System.EventHandler(this.buttonRef_Click);
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(727, 398);
            this.Controls.Add(this.buttonRef);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonUpd);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormBase";
            this.Text = "Гостинница";
            this.Load += new System.EventHandler(this.FormBase_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem админыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посетителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заблокироватьПосетителейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетПоОплатамToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonRef;
    }
}