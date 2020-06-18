namespace CostAccountingSystem
{
    partial class PurchaseSetup
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
            this.dateTimePicker_Pay = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Received = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_DeleteFromList = new System.Windows.Forms.Button();
            this.button_AddToList = new System.Windows.Forms.Button();
            this.listView_Orders = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_CountProduct = new System.Windows.Forms.NumericUpDown();
            this.button_SaveExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.comboBox_Product = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CountProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_Pay
            // 
            this.dateTimePicker_Pay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker_Pay.Location = new System.Drawing.Point(150, 330);
            this.dateTimePicker_Pay.Name = "dateTimePicker_Pay";
            this.dateTimePicker_Pay.Size = new System.Drawing.Size(205, 20);
            this.dateTimePicker_Pay.TabIndex = 12;
            // 
            // dateTimePicker_Received
            // 
            this.dateTimePicker_Received.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker_Received.Checked = false;
            this.dateTimePicker_Received.Location = new System.Drawing.Point(150, 370);
            this.dateTimePicker_Received.Name = "dateTimePicker_Received";
            this.dateTimePicker_Received.ShowCheckBox = true;
            this.dateTimePicker_Received.Size = new System.Drawing.Size(205, 20);
            this.dateTimePicker_Received.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Дата оплаты";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Дата получения";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Товар";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Количество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Состав";
            // 
            // button_DeleteFromList
            // 
            this.button_DeleteFromList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_DeleteFromList.Location = new System.Drawing.Point(465, 200);
            this.button_DeleteFromList.Name = "button_DeleteFromList";
            this.button_DeleteFromList.Size = new System.Drawing.Size(115, 35);
            this.button_DeleteFromList.TabIndex = 10;
            this.button_DeleteFromList.Text = "Удалить";
            this.button_DeleteFromList.UseVisualStyleBackColor = true;
            this.button_DeleteFromList.Click += new System.EventHandler(this.Button_DeleteFromList_Click);
            // 
            // button_AddToList
            // 
            this.button_AddToList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_AddToList.Location = new System.Drawing.Point(465, 155);
            this.button_AddToList.Name = "button_AddToList";
            this.button_AddToList.Size = new System.Drawing.Size(115, 35);
            this.button_AddToList.TabIndex = 9;
            this.button_AddToList.Text = "Добавить ";
            this.button_AddToList.UseVisualStyleBackColor = true;
            this.button_AddToList.Click += new System.EventHandler(this.Button_AddToList_Click);
            // 
            // listView_Orders
            // 
            this.listView_Orders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Orders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_Orders.FullRowSelect = true;
            this.listView_Orders.HideSelection = false;
            this.listView_Orders.Location = new System.Drawing.Point(50, 10);
            this.listView_Orders.Name = "listView_Orders";
            this.listView_Orders.Size = new System.Drawing.Size(305, 300);
            this.listView_Orders.TabIndex = 1;
            this.listView_Orders.UseCompatibleStateImageBehavior = false;
            this.listView_Orders.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Товар";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Штук";
            this.columnHeader2.Width = 100;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(355, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Добавить товар";
            // 
            // numericUpDown_CountProduct
            // 
            this.numericUpDown_CountProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_CountProduct.Location = new System.Drawing.Point(425, 70);
            this.numericUpDown_CountProduct.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_CountProduct.Name = "numericUpDown_CountProduct";
            this.numericUpDown_CountProduct.Size = new System.Drawing.Size(160, 20);
            this.numericUpDown_CountProduct.TabIndex = 6;
            // 
            // button_SaveExit
            // 
            this.button_SaveExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SaveExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_SaveExit.Location = new System.Drawing.Point(380, 350);
            this.button_SaveExit.Name = "button_SaveExit";
            this.button_SaveExit.Size = new System.Drawing.Size(200, 40);
            this.button_SaveExit.TabIndex = 15;
            this.button_SaveExit.Text = "Сохранить и выйти";
            this.button_SaveExit.UseVisualStyleBackColor = true;
            this.button_SaveExit.Click += new System.EventHandler(this.Button_SaveExit_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Цена";
            // 
            // textBox_Price
            // 
            this.textBox_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Price.Location = new System.Drawing.Point(425, 100);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(160, 20);
            this.textBox_Price.TabIndex = 8;
            // 
            // comboBox_Product
            // 
            this.comboBox_Product.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Product.FormattingEnabled = true;
            this.comboBox_Product.Location = new System.Drawing.Point(425, 40);
            this.comboBox_Product.Name = "comboBox_Product";
            this.comboBox_Product.Size = new System.Drawing.Size(160, 21);
            this.comboBox_Product.TabIndex = 4;
            // 
            // PurchaseSetup
            // 
            this.AcceptButton = this.button_SaveExit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_SaveExit;
            this.ClientSize = new System.Drawing.Size(591, 409);
            this.Controls.Add(this.comboBox_Product);
            this.Controls.Add(this.button_SaveExit);
            this.Controls.Add(this.button_AddToList);
            this.Controls.Add(this.button_DeleteFromList);
            this.Controls.Add(this.numericUpDown_CountProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listView_Orders);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_Received);
            this.Controls.Add(this.dateTimePicker_Pay);
            this.MinimumSize = new System.Drawing.Size(607, 448);
            this.Name = "PurchaseSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Закупка";
            this.Load += new System.EventHandler(this.PurchaseSetup_Load);
            this.Resize += new System.EventHandler(this.PurchaseSetup_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CountProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_Pay;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Received;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_DeleteFromList;
        private System.Windows.Forms.Button button_AddToList;
        private System.Windows.Forms.ListView listView_Orders;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown_CountProduct;
        private System.Windows.Forms.Button button_SaveExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.ComboBox comboBox_Product;
    }
}