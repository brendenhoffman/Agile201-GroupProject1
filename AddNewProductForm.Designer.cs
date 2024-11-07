namespace Agile201_GroupProject1
{
    partial class AddNewProductForm
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
            quantityTextBox = new TextBox();
            priceTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            nameTextBox = new TextBox();
            idTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            saveButton = new Button();
            clearButton = new Button();
            closeButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(quantityTextBox);
            groupBox1.Controls.Add(priceTextBox);
            groupBox1.Controls.Add(descriptionTextBox);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Controls.Add(idTextBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(26, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 332);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Product Data";
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(153, 257);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(142, 23);
            quantityTextBox.TabIndex = 9;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(153, 206);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(142, 23);
            priceTextBox.TabIndex = 8;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(153, 132);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(142, 46);
            descriptionTextBox.TabIndex = 7;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(153, 82);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(142, 23);
            nameTextBox.TabIndex = 6;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(153, 35);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(142, 23);
            idTextBox.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 260);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 4;
            label5.Text = "Quantity on Hand:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 209);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 3;
            label4.Text = "Product Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 135);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 85);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 1;
            label2.Text = "Product Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 38);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Product ID:";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(26, 386);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 1;
            saveButton.Text = "&Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(150, 386);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 2;
            clearButton.Text = "&Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(273, 386);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 3;
            closeButton.Text = "Cl&ose";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // AddNewProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 433);
            Controls.Add(closeButton);
            Controls.Add(clearButton);
            Controls.Add(saveButton);
            Controls.Add(groupBox1);
            Name = "AddNewProductForm";
            Text = "Add New Product Form";
            Load += AddNewProductForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox quantityTextBox;
        private TextBox priceTextBox;
        private TextBox descriptionTextBox;
        private TextBox nameTextBox;
        private TextBox idTextBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button saveButton;
        private Button clearButton;
        private Button closeButton;
    }
}