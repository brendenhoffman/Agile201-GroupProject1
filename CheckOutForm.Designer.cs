namespace Agile201_GroupProject1
{
    partial class CheckOutForm
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            orderListBox = new ListBox();
            addToOrderButton = new Button();
            readyToPayButton = new Button();
            printButton = new Button();
            saveAndCloseButton = new Button();
            label2 = new Label();
            label3 = new Label();
            idTextBox = new TextBox();
            unitsTextBox = new TextBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(unitsTextBox);
            groupBox1.Controls.Add(idTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(27, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 126);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Scan barcode or enter product id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 252);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 1;
            label1.Text = "Order Details:";
            // 
            // orderListBox
            // 
            orderListBox.FormattingEnabled = true;
            orderListBox.ItemHeight = 15;
            orderListBox.Location = new Point(27, 283);
            orderListBox.Name = "orderListBox";
            orderListBox.Size = new Size(372, 154);
            orderListBox.TabIndex = 2;
            // 
            // addToOrderButton
            // 
            addToOrderButton.Location = new Point(27, 180);
            addToOrderButton.Name = "addToOrderButton";
            addToOrderButton.Size = new Size(75, 44);
            addToOrderButton.TabIndex = 3;
            addToOrderButton.Text = "&Add to Order";
            addToOrderButton.UseVisualStyleBackColor = true;
            // 
            // readyToPayButton
            // 
            readyToPayButton.Location = new Point(128, 180);
            readyToPayButton.Name = "readyToPayButton";
            readyToPayButton.Size = new Size(75, 44);
            readyToPayButton.TabIndex = 4;
            readyToPayButton.Text = "&Ready to Pay";
            readyToPayButton.UseVisualStyleBackColor = true;
            // 
            // printButton
            // 
            printButton.Location = new Point(223, 180);
            printButton.Name = "printButton";
            printButton.Size = new Size(75, 44);
            printButton.TabIndex = 5;
            printButton.Text = "&Print Reciept";
            printButton.UseVisualStyleBackColor = true;
            // 
            // saveAndCloseButton
            // 
            saveAndCloseButton.Location = new Point(324, 180);
            saveAndCloseButton.Name = "saveAndCloseButton";
            saveAndCloseButton.Size = new Size(75, 44);
            saveAndCloseButton.TabIndex = 6;
            saveAndCloseButton.Text = "&Save && Close";
            saveAndCloseButton.UseVisualStyleBackColor = true;
            saveAndCloseButton.Click += saveAndCloseButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 34);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 0;
            label2.Text = "Product ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 77);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 1;
            label3.Text = "Units Sold:";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(160, 31);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(182, 23);
            idTextBox.TabIndex = 2;
            // 
            // unitsTextBox
            // 
            unitsTextBox.Location = new Point(160, 74);
            unitsTextBox.Name = "unitsTextBox";
            unitsTextBox.Size = new Size(67, 23);
            unitsTextBox.TabIndex = 3;
            // 
            // CheckOutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 450);
            Controls.Add(saveAndCloseButton);
            Controls.Add(printButton);
            Controls.Add(readyToPayButton);
            Controls.Add(addToOrderButton);
            Controls.Add(orderListBox);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "CheckOutForm";
            Text = "Check Out Form";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox unitsTextBox;
        private TextBox idTextBox;
        private Label label3;
        private Label label2;
        private ListBox orderListBox;
        private Button addToOrderButton;
        private Button readyToPayButton;
        private Button printButton;
        private Button saveAndCloseButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}