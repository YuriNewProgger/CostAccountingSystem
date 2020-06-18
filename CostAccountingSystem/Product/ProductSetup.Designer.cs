namespace CostAccountingSystem
{
    partial class ProductSetup
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
            this.label_NameProduct = new System.Windows.Forms.Label();
            this.textBox_ProductName = new System.Windows.Forms.TextBox();
            this.richTextBox_Discription = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Measures = new System.Windows.Forms.ComboBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_limit = new System.Windows.Forms.TextBox();
            this.checkBox_Splitting = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_Splitting = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Splitting)).BeginInit();
            this.SuspendLayout();
            // 
            // label_NameProduct
            // 
            this.label_NameProduct.AutoSize = true;
            this.label_NameProduct.Location = new System.Drawing.Point(10, 20);
            this.label_NameProduct.Name = "label_NameProduct";
            this.label_NameProduct.Size = new System.Drawing.Size(60, 13);
            this.label_NameProduct.TabIndex = 0;
            this.label_NameProduct.Text = "Название ";
            // 
            // textBox_ProductName
            // 
            this.textBox_ProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ProductName.Location = new System.Drawing.Point(145, 20);
            this.textBox_ProductName.Name = "textBox_ProductName";
            this.textBox_ProductName.Size = new System.Drawing.Size(200, 20);
            this.textBox_ProductName.TabIndex = 1;
            // 
            // richTextBox_Discription
            // 
            this.richTextBox_Discription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_Discription.Location = new System.Drawing.Point(145, 60);
            this.richTextBox_Discription.Name = "richTextBox_Discription";
            this.richTextBox_Discription.Size = new System.Drawing.Size(200, 96);
            this.richTextBox_Discription.TabIndex = 3;
            this.richTextBox_Discription.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Заметки";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Еденицы измерения";
            // 
            // comboBox_Measures
            // 
            this.comboBox_Measures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Measures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Measures.FormattingEnabled = true;
            this.comboBox_Measures.Items.AddRange(new object[] {
            "мл.",
            "гр."});
            this.comboBox_Measures.Location = new System.Drawing.Point(145, 225);
            this.comboBox_Measures.Name = "comboBox_Measures";
            this.comboBox_Measures.Size = new System.Drawing.Size(120, 21);
            this.comboBox_Measures.TabIndex = 8;
            // 
            // button_Add
            // 
            this.button_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Add.Location = new System.Drawing.Point(185, 290);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 11;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(270, 290);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 12;
            this.button_Cancel.Text = "Отменить";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Предел предупреждения";
            // 
            // textBox_limit
            // 
            this.textBox_limit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_limit.Location = new System.Drawing.Point(145, 260);
            this.textBox_limit.Name = "textBox_limit";
            this.textBox_limit.Size = new System.Drawing.Size(120, 20);
            this.textBox_limit.TabIndex = 10;
            // 
            // checkBox_Splitting
            // 
            this.checkBox_Splitting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Splitting.AutoSize = true;
            this.checkBox_Splitting.Location = new System.Drawing.Point(10, 175);
            this.checkBox_Splitting.Name = "checkBox_Splitting";
            this.checkBox_Splitting.Size = new System.Drawing.Size(135, 17);
            this.checkBox_Splitting.TabIndex = 4;
            this.checkBox_Splitting.Text = "Расходуется частами";
            this.checkBox_Splitting.UseVisualStyleBackColor = true;
            this.checkBox_Splitting.CheckedChanged += new System.EventHandler(this.CheckBox_Splitting_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "В одной штуке";
            // 
            // numericUpDown_Splitting
            // 
            this.numericUpDown_Splitting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_Splitting.Location = new System.Drawing.Point(145, 195);
            this.numericUpDown_Splitting.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Splitting.Name = "numericUpDown_Splitting";
            this.numericUpDown_Splitting.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Splitting.TabIndex = 6;
            // 
            // ProductSetup
            // 
            this.AcceptButton = this.button_Add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(356, 323);
            this.Controls.Add(this.numericUpDown_Splitting);
            this.Controls.Add(this.checkBox_Splitting);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.comboBox_Measures);
            this.Controls.Add(this.textBox_limit);
            this.Controls.Add(this.richTextBox_Discription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_ProductName);
            this.Controls.Add(this.label_NameProduct);
            this.MinimumSize = new System.Drawing.Size(372, 362);
            this.Name = "ProductSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка товара";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Splitting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_NameProduct;
        private System.Windows.Forms.TextBox textBox_ProductName;
        private System.Windows.Forms.RichTextBox richTextBox_Discription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Measures;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_limit;
        private System.Windows.Forms.CheckBox checkBox_Splitting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Splitting;
    }
}