namespace Agile201_GroupProject1
{
    partial class UpdateProductForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            findButton = new Button();
            updateButton = new Button();
            clearButton = new Button();
            saveAndCloseButton = new Button();
            idTextBox = new TextBox();
            nameTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            priceTextBox = new TextBox();
            quantityTextBox = new TextBox();
            newQuantityTextBox = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(newQuantityTextBox);
            groupBox1.Controls.Add(quantityTextBox);
            groupBox1.Controls.Add(priceTextBox);
            groupBox1.Controls.Add(descriptionTextBox);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Controls.Add(idTextBox);
            groupBox1.Controls.Add(findButton);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(31, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(361, 333);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Update Product";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 35);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Product ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 79);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 1;
            label2.Text = "Product Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 125);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 194);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 3;
            label4.Text = "Product Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 241);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 4;
            label5.Text = "Quantity On Hand:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 290);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 5;
            label6.Text = "New Quantity:";
            // 
            // findButton
            // 
            findButton.Location = new Point(269, 31);
            findButton.Name = "findButton";
            findButton.Size = new Size(75, 23);
            findButton.TabIndex = 6;
            findButton.Text = "&Find";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(31, 394);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(95, 23);
            updateButton.TabIndex = 1;
            updateButton.Text = "&Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(166, 394);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(95, 23);
            clearButton.TabIndex = 2;
            clearButton.Text = "&Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // saveAndCloseButton
            // 
            saveAndCloseButton.Location = new Point(297, 394);
            saveAndCloseButton.Name = "saveAndCloseButton";
            saveAndCloseButton.Size = new Size(95, 23);
            saveAndCloseButton.TabIndex = 3;
            saveAndCloseButton.Text = "&Save && Close";
            saveAndCloseButton.UseVisualStyleBackColor = true;
            saveAndCloseButton.Click += saveAndCloseButton_Click;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(135, 32);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(100, 23);
            idTextBox.TabIndex = 7;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(135, 76);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(187, 23);
            nameTextBox.TabIndex = 8;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(135, 122);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(187, 46);
            descriptionTextBox.TabIndex = 9;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(135, 191);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(187, 23);
            priceTextBox.TabIndex = 10;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(135, 238);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.ReadOnly = true;
            quantityTextBox.Size = new Size(187, 23);
            quantityTextBox.TabIndex = 11;
            // 
            // newQuantityTextBox
            // 
            newQuantityTextBox.Location = new Point(135, 287);
            newQuantityTextBox.Name = "newQuantityTextBox";
            newQuantityTextBox.Size = new Size(187, 23);
            newQuantityTextBox.TabIndex = 12;
            // 
            // UpdateProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 450);
            Controls.Add(saveAndCloseButton);
            Controls.Add(clearButton);
            Controls.Add(updateButton);
            Controls.Add(groupBox1);
            Name = "UpdateProductForm";
            Text = "Update Product Form";
            Load += UpdateProductForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button findButton;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button updateButton;
        private Button clearButton;
        private Button saveAndCloseButton;
        private TextBox newQuantityTextBox;
        private TextBox quantityTextBox;
        private TextBox priceTextBox;
        private TextBox descriptionTextBox;
        private TextBox nameTextBox;
        private TextBox idTextBox;
    }
}