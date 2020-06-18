namespace CostAccountingSystem
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Goods = new System.Windows.Forms.Button();
            this.button_Purchase = new System.Windows.Forms.Button();
            this.button_WriteOff = new System.Windows.Forms.Button();
            this.button_LeftOvers = new System.Windows.Forms.Button();
            this.button_Inventory = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Goods
            // 
            this.button_Goods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Goods.Location = new System.Drawing.Point(5, 10);
            this.button_Goods.Name = "button_Goods";
            this.button_Goods.Size = new System.Drawing.Size(245, 40);
            this.button_Goods.TabIndex = 0;
            this.button_Goods.Text = "Товары";
            this.button_Goods.UseVisualStyleBackColor = true;
            this.button_Goods.Click += new System.EventHandler(this.Button_Goods_Click);
            // 
            // button_Purchase
            // 
            this.button_Purchase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Purchase.Location = new System.Drawing.Point(5, 55);
            this.button_Purchase.Name = "button_Purchase";
            this.button_Purchase.Size = new System.Drawing.Size(120, 40);
            this.button_Purchase.TabIndex = 1;
            this.button_Purchase.Text = "Закупки";
            this.button_Purchase.UseVisualStyleBackColor = true;
            this.button_Purchase.Click += new System.EventHandler(this.Button_Purchase_Click);
            // 
            // button_WriteOff
            // 
            this.button_WriteOff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_WriteOff.Location = new System.Drawing.Point(130, 55);
            this.button_WriteOff.Name = "button_WriteOff";
            this.button_WriteOff.Size = new System.Drawing.Size(120, 40);
            this.button_WriteOff.TabIndex = 2;
            this.button_WriteOff.Text = "Списания";
            this.button_WriteOff.UseVisualStyleBackColor = true;
            this.button_WriteOff.Click += new System.EventHandler(this.Button_WriteOff_Click);
            // 
            // button_LeftOvers
            // 
            this.button_LeftOvers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_LeftOvers.Location = new System.Drawing.Point(5, 100);
            this.button_LeftOvers.Name = "button_LeftOvers";
            this.button_LeftOvers.Size = new System.Drawing.Size(245, 40);
            this.button_LeftOvers.TabIndex = 3;
            this.button_LeftOvers.Text = "Остатки";
            this.button_LeftOvers.UseVisualStyleBackColor = true;
            this.button_LeftOvers.Click += new System.EventHandler(this.Button_LeftOvers_Click);
            // 
            // button_Inventory
            // 
            this.button_Inventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Inventory.BackColor = System.Drawing.Color.LightCoral;
            this.button_Inventory.Location = new System.Drawing.Point(5, 145);
            this.button_Inventory.Name = "button_Inventory";
            this.button_Inventory.Size = new System.Drawing.Size(245, 40);
            this.button_Inventory.TabIndex = 4;
            this.button_Inventory.Text = "Инвентаризация";
            this.button_Inventory.UseVisualStyleBackColor = false;
            this.button_Inventory.Click += new System.EventHandler(this.Button_Inventory_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Exit.Location = new System.Drawing.Point(5, 225);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(245, 40);
            this.button_Exit.TabIndex = 5;
            this.button_Exit.Text = "Выход";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 279);
            this.Controls.Add(this.button_WriteOff);
            this.Controls.Add(this.button_Purchase);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Inventory);
            this.Controls.Add(this.button_LeftOvers);
            this.Controls.Add(this.button_Goods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(272, 318);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Goods;
        private System.Windows.Forms.Button button_Purchase;
        private System.Windows.Forms.Button button_WriteOff;
        private System.Windows.Forms.Button button_LeftOvers;
        private System.Windows.Forms.Button button_Inventory;
        private System.Windows.Forms.Button button_Exit;
    }
}

