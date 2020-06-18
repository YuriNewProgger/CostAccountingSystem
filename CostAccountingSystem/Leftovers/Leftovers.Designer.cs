namespace CostAccountingSystem
{
    partial class Leftovers
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
            this.listView_LeftoversProduct = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_ReturnToMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_LeftoversProduct
            // 
            this.listView_LeftoversProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_LeftoversProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_LeftoversProduct.FullRowSelect = true;
            this.listView_LeftoversProduct.HideSelection = false;
            this.listView_LeftoversProduct.Location = new System.Drawing.Point(10, 10);
            this.listView_LeftoversProduct.Name = "listView_LeftoversProduct";
            this.listView_LeftoversProduct.Size = new System.Drawing.Size(595, 195);
            this.listView_LeftoversProduct.TabIndex = 0;
            this.listView_LeftoversProduct.UseCompatibleStateImageBehavior = false;
            this.listView_LeftoversProduct.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Товар";
            this.columnHeader1.Width = 395;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Осталось, шт";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Осталось, вес";
            this.columnHeader3.Width = 100;
            // 
            // button_ReturnToMainMenu
            // 
            this.button_ReturnToMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ReturnToMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_ReturnToMainMenu.Location = new System.Drawing.Point(615, 10);
            this.button_ReturnToMainMenu.Name = "button_ReturnToMainMenu";
            this.button_ReturnToMainMenu.Size = new System.Drawing.Size(95, 23);
            this.button_ReturnToMainMenu.TabIndex = 1;
            this.button_ReturnToMainMenu.Text = "Главное меню";
            this.button_ReturnToMainMenu.UseVisualStyleBackColor = true;
            this.button_ReturnToMainMenu.Click += new System.EventHandler(this.Button_ReturnToMainMenu_Click);
            // 
            // Leftovers
            // 
            this.AcceptButton = this.button_ReturnToMainMenu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_ReturnToMainMenu;
            this.ClientSize = new System.Drawing.Size(715, 215);
            this.Controls.Add(this.button_ReturnToMainMenu);
            this.Controls.Add(this.listView_LeftoversProduct);
            this.MinimumSize = new System.Drawing.Size(500, 254);
            this.Name = "Leftovers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Остатки";
            this.Load += new System.EventHandler(this.Leftovers_Load);
            this.Resize += new System.EventHandler(this.Leftovers_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_LeftoversProduct;
        private System.Windows.Forms.Button button_ReturnToMainMenu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}