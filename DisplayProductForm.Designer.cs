namespace Agile201_GroupProject1
{
    partial class DisplayProductForm
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
            label1 = new Label();
            inventoryListBox = new ListBox();
            closeButton = new Button();
            printButton = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 33);
            label1.Name = "label1";
            label1.Size = new Size(137, 15);
            label1.TabIndex = 0;
            label1.Text = "All Products In Inventory";
            // 
            // inventoryListBox
            // 
            inventoryListBox.FormattingEnabled = true;
            inventoryListBox.ItemHeight = 15;
            inventoryListBox.Location = new Point(33, 69);
            inventoryListBox.Name = "inventoryListBox";
            inventoryListBox.Size = new Size(445, 304);
            inventoryListBox.TabIndex = 1;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(71, 403);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 2;
            closeButton.Text = "Cl&ose";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // printButton
            // 
            printButton.Location = new Point(370, 403);
            printButton.Name = "printButton";
            printButton.Size = new Size(75, 23);
            printButton.TabIndex = 3;
            printButton.Text = "button2";
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += printButton_Click;
            // 
            // DisplayProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 450);
            Controls.Add(printButton);
            Controls.Add(closeButton);
            Controls.Add(inventoryListBox);
            Controls.Add(label1);
            Name = "DisplayProductForm";
            Text = "Display Product Form";
            Load += DisplayProductForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox inventoryListBox;
        private Button closeButton;
        private Button printButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}