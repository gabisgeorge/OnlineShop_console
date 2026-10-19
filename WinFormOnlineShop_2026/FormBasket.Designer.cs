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
            buttonConfirm = new Button();
            checkedListBoxBasketItems = new CheckedListBox();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(buttonConfirm);
            panel1.Controls.Add(checkedListBoxBasketItems);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(645, 311);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(143, 127);
            buttonConfirm.TabIndex = 1;
            buttonConfirm.Text = "Подтвердить заказ";
            buttonConfirm.UseVisualStyleBackColor = true;
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
            // button1
            // 
            button1.Location = new Point(282, 352);
            button1.Name = "button1";
            button1.Size = new Size(108, 86);
            button1.TabIndex = 2;
            button1.Text = "Удалить товар";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
        private Button button1;
    }
}