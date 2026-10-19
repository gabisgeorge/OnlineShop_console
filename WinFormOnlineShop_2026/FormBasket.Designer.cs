namespace WinFormOnlineShop_2026
{
    partial class FormBasket
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
            panel1 = new Panel();
            buttonDelete = new Button();
            buttonConfirm = new Button();
            checkedListBoxBasketItems = new CheckedListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(buttonConfirm);
            panel1.Controls.Add(checkedListBoxBasketItems);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(282, 352);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(108, 86);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Удалить товар";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += button1_Click;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(645, 311);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(143, 127);
            buttonConfirm.TabIndex = 1;
            buttonConfirm.Text = "Подтвердить заказ";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // checkedListBoxBasketItems
            // 
            checkedListBoxBasketItems.Dock = DockStyle.Left;
            checkedListBoxBasketItems.FormattingEnabled = true;
            checkedListBoxBasketItems.Location = new Point(0, 0);
            checkedListBoxBasketItems.Name = "checkedListBoxBasketItems";
            checkedListBoxBasketItems.Size = new Size(276, 450);
            checkedListBoxBasketItems.TabIndex = 0;
            // 
            // FormBasket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FormBasket";
            Text = "FormBasket";
            Load += FormBasket_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonConfirm;
        public CheckedListBox checkedListBoxBasketItems;
        private Button buttonDelete;
    }
}