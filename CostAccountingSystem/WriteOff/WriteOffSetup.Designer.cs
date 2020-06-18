namespace CostAccountingSystem
{
    partial class WriteOffSetup
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
            this.dateTimePicker_WriteOfffDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_MasterName = new System.Windows.Forms.TextBox();
            this.listView_WriteOffItem = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_Count = new System.Windows.Forms.NumericUpDown();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_SaveAndExit = new System.Windows.Forms.Button();
            this.comboBox_Products = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_Measures = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Count)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Дата списания";
            // 
            // dateTimePicker_WriteOfffDate
            // 
            this.dateTimePicker_WriteOfffDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker_WriteOfffDate.Location = new System.Drawing.Point(145, 350);
            this.dateTimePicker_WriteOfffDate.Name = "dateTimePicker_WriteOfffDate";
            this.dateTimePicker_WriteOfffDate.Size = new System.Drawing.Size(215, 20);
            this.dateTimePicker_WriteOfffDate.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Мастер";
            // 
            // textBox_MasterName
            // 
            this.textBox_MasterName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_MasterName.Location = new System.Drawing.Point(145, 380);
            this.textBox_MasterName.Name = "textBox_MasterName";
            this.textBox_MasterName.Size = new System.Drawing.Size(215, 20);
            this.textBox_MasterName.TabIndex = 14;
            // 
            // listView_WriteOffItem
            // 
            this.listView_WriteOffItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_WriteOffItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_WriteOffItem.FullRowSelect = true;
            this.listView_WriteOffItem.HideSelection = false;
            this.listView_WriteOffItem.Location = new System.Drawing.Point(55, 15);
            this.listView_WriteOffItem.Name = "listView_WriteOffItem";
            this.listView_WriteOffItem.Size = new System.Drawing.Size(315, 320);
            this.listView_WriteOffItem.TabIndex = 1;
            this.listView_WriteOffItem.UseCompatibleStateImageBehavior = false;
            this.listView_WriteOffItem.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Товар";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Кол-во";
            this.columnHeader2.Width = 105;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Состав";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(370, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Добавить товар";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Товар";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Количество";
            // 
            // numericUpDown_Count
            // 
            this.numericUpDown_Count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_Count.Location = new System.Drawing.Point(445, 70);
            this.numericUpDown_Count.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Count.Name = "numericUpDown_Count";
            this.numericUpDown_Count.Size = new System.Drawing.Size(135, 20);
            this.numericUpDown_Count.TabIndex = 6;
            // 
            // button_Add
            // 
            this.button_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Add.Location = new System.Drawing.Point(465, 140);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(115, 35);
            this.button_Add.TabIndex = 9;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Delete.Location = new System.Drawing.Point(465, 185);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(115, 35);
            this.button_Delete.TabIndex = 10;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // button_SaveAndExit
            // 
            this.button_SaveAndExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SaveAndExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_SaveAndExit.Location = new System.Drawing.Point(385, 365);
            this.button_SaveAndExit.Name = "button_SaveAndExit";
            this.button_SaveAndExit.Size = new System.Drawing.Size(200, 35);
            this.button_SaveAndExit.TabIndex = 15;
            this.button_SaveAndExit.Text = "Сохранить и выйти";
            this.button_SaveAndExit.UseVisualStyleBackColor = true;
            this.button_SaveAndExit.Click += new System.EventHandler(this.Button_SaveAndExit_Click);
            // 
            // comboBox_Products
            // 
            this.comboBox_Products.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Products.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Products.FormattingEnabled = true;
            this.comboBox_Products.Location = new System.Drawing.Point(445, 35);
            this.comboBox_Products.Name = "comboBox_Products";
            this.comboBox_Products.Size = new System.Drawing.Size(135, 21);
            this.comboBox_Products.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Измерения";
            // 
            // comboBox_Measures
            // 
            this.comboBox_Measures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Measures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Measures.FormattingEnabled = true;
            this.comboBox_Measures.Items.AddRange(new object[] {
            "гр.",
            "мл."});
            this.comboBox_Measures.Location = new System.Drawing.Point(445, 100);
            this.comboBox_Measures.Name = "comboBox_Measures";
            this.comboBox_Measures.Size = new System.Drawing.Size(135, 21);
            this.comboBox_Measures.TabIndex = 8;
            // 
            // WriteOffSetup
            // 
            this.AcceptButton = this.button_SaveAndExit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_SaveAndExit;
            this.ClientSize = new System.Drawing.Size(591, 409);
            this.Controls.Add(this.comboBox_Measures);
            this.Controls.Add(this.comboBox_Products);
            this.Controls.Add(this.button_SaveAndExit);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.numericUpDown_Count);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView_WriteOffItem);
            this.Controls.Add(this.textBox_MasterName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker_WriteOfffDate);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(607, 448);
            this.Name = "WriteOffSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка списаний";
            this.Load += new System.EventHandler(this.WriteOffSetup_Load);
            this.Resize += new System.EventHandler(this.WriteOffSetup_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_WriteOfffDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_MasterName;
        private System.Windows.Forms.ListView listView_WriteOffItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_Count;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_SaveAndExit;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox comboBox_Products;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_Measures;
    }
}