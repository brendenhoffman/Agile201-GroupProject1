namespace Agile201_GroupProject1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addProductButton = new Button();
            updateButton = new Button();
            displayButton = new Button();
            checkoutButton = new Button();
            exitButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // addProductButton
            // 
            addProductButton.Location = new Point(71, 126);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(75, 46);
            addProductButton.TabIndex = 0;
            addProductButton.Text = "&Add New Product";
            addProductButton.UseVisualStyleBackColor = true;
            addProductButton.Click += addProductButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(239, 126);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 46);
            updateButton.TabIndex = 1;
            updateButton.Text = "&Update Inventory";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // displayButton
            // 
            displayButton.Location = new Point(408, 126);
            displayButton.Name = "displayButton";
            displayButton.Size = new Size(75, 46);
            displayButton.TabIndex = 2;
            displayButton.Text = "&Display Inventory";
            displayButton.UseVisualStyleBackColor = true;
            displayButton.Click += displayButton_Click;
            // 
            // checkoutButton
            // 
            checkoutButton.Location = new Point(572, 126);
            checkoutButton.Name = "checkoutButton";
            checkoutButton.Size = new Size(75, 46);
            checkoutButton.TabIndex = 3;
            checkoutButton.Text = "Cashier Checkout";
            checkoutButton.UseVisualStyleBackColor = true;
            checkoutButton.Click += checkoutButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(71, 195);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(576, 46);
            exitButton.TabIndex = 4;
            exitButton.Text = "E&xit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Old English Text MT", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 45);
            label1.Name = "label1";
            label1.Size = new Size(642, 44);
            label1.TabIndex = 5;
            label1.Text = "Giant Bass Fish Toy Inventory System";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 302);
            Controls.Add(label1);
            Controls.Add(exitButton);
            Controls.Add(checkoutButton);
            Controls.Add(displayButton);
            Controls.Add(updateButton);
            Controls.Add(addProductButton);
            Name = "MainForm";
            Text = "Main Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addProductButton;
        private Button updateButton;
        private Button displayButton;
        private Button checkoutButton;
        private Button exitButton;
        private Label label1;
    }
}
