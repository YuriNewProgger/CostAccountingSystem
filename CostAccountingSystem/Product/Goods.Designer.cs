namespace CostAccountingSystem
{
    partial class Goods
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
            this.listView_Goods = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Change = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_ReturnToMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_Goods
            // 
            this.listView_Goods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Goods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView_Goods.FullRowSelect = true;
            this.listView_Goods.HideSelection = false;
            this.listView_Goods.Location = new System.Drawing.Point(10, 10);
            this.listView_Goods.Name = "listView_Goods";
            this.listView_Goods.Size = new System.Drawing.Size(595, 195);
            this.listView_Goods.TabIndex = 0;
            this.listView_Goods.UseCompatibleStateImageBehavior = false;
            this.listView_Goods.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Заметки";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Дробление";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Еденицы";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Кол-во";
            // 
            // button_Add
            // 
            this.button_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Add.Location = new System.Drawing.Point(615, 10);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(95, 23);
            this.button_Add.TabIndex = 1;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // button_Change
            // 
            this.button_Change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Change.Location = new System.Drawing.Point(615, 45);
            this.button_Change.Name = "button_Change";
            this.button_Change.Size = new System.Drawing.Size(95, 23);
            this.button_Change.TabIndex = 2;
            this.button_Change.Text = "Изменить";
            this.button_Change.UseVisualStyleBackColor = true;
            this.button_Change.Click += new System.EventHandler(this.Button_Change_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Delete.Location = new System.Drawing.Point(615, 80);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(95, 23);
            this.button_Delete.TabIndex = 3;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // button_ReturnToMainMenu
            // 
            this.button_ReturnToMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ReturnToMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_ReturnToMainMenu.Location = new System.Drawing.Point(615, 180);
            this.button_ReturnToMainMenu.Name = "button_ReturnToMainMenu";
            this.button_ReturnToMainMenu.Size = new System.Drawing.Size(95, 23);
            this.button_ReturnToMainMenu.TabIndex = 4;
            this.button_ReturnToMainMenu.Text = "Главное меню";
            this.button_ReturnToMainMenu.UseVisualStyleBackColor = true;
            this.button_ReturnToMainMenu.Click += new System.EventHandler(this.Button_ReturnToMainMenu_Click);
            // 
            // Goods
            // 
            this.AcceptButton = this.button_Add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_ReturnToMainMenu;
            this.ClientSize = new System.Drawing.Size(715, 215);
            this.Controls.Add(this.button_ReturnToMainMenu);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Change);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.listView_Goods);
            this.MinimumSize = new System.Drawing.Size(500, 254);
            this.Name = "Goods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.Goods_Load);
            this.Resize += new System.EventHandler(this.Goods_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_Goods;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Change;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_ReturnToMainMenu;
    }
}