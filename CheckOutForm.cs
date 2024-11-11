using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agile201_GroupProject1
{
    public partial class CheckOutForm : Form
    {
        public CheckOutForm()
        {
            InitializeComponent();
        }
        Order order;
        List<Product> products = new List<Product>();
        List<Product> productsInOrder = new List<Product>();
        private void CheckOutForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("product.txt"))
            {
                using StreamReader sr =
                    new StreamReader("product.txt");
                string productId;
                while ((productId = sr.ReadLine()) != null)
                {
                    string name = sr.ReadLine();
                    string description = sr.ReadLine();
                    decimal price = decimal.Parse(sr.ReadLine());
                    int onHand = int.Parse(sr.ReadLine());
                    Product product = new Product(productId, name, description, price, onHand);
                    products.Add(product);
                }

            }
        }

        private void saveAndCloseButton_Click(object sender, EventArgs e)
        {
            using StreamWriter sr = File.CreateText("product.txt");
            foreach (Product product in products)
            {
                sr.WriteLine(product);
            }
            Close();
        }

        private void label2_Click(object sender, EventArgs e) //Ignore
        {

        }

        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            int unitSold = 0;
            if (products.Find(x => x.ProductId == idTextBox.Text) == null)
            {
                MessageBox.Show("ID does not exist");
                idTextBox.Focus();
                idTextBox.SelectAll();
            }
            else if (string.IsNullOrEmpty(idTextBox.Text) || !int.TryParse(unitsTextBox.Text, out unitSold) || unitSold < 1)
            {
                MessageBox.Show("Unit Sold must be a whole number");
                unitsTextBox.Focus();
                unitsTextBox.SelectAll();
            }
            else
            {
                int index = products.FindIndex(p => p.ProductId == idTextBox.Text);
                if (products[index].OnHand >= unitSold)
                {
                    products[index].UnitSold += unitSold;
                    products[index].OnHand -= unitSold;
                    products[index].IsInOrder = true;
                    orderListBox.Font = new Font("Courier New", 12);
                    orderListBox.Items.Add($"{products[index].Name}" + $" {unitSold} {unitSold * products[index].Price:C}");
                    idTextBox.Clear();
                    idTextBox.Focus();
                }
                else
                {
                    MessageBox.Show("Not enough inventory.");
                    unitsTextBox.Focus();
                    unitsTextBox.SelectAll();
                }
            }


        }

        private void readyToPayButton_Click(object sender, EventArgs e)
        {
            productsInOrder = products.Where(p => p.IsInOrder == true).ToList();
            orderListBox.Items.Clear();
            order = new Order(productsInOrder);
            orderListBox.Items.AddRange(order.ToString().Split('\n'));
            addToOrderButton.Enabled = false;

        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (order == null)
            {
                MessageBox.Show("Sorry, no orders found.");
            }
            else
            {
                e.Graphics.DrawString(order.ToString(), new
                    Font("Courier New", 12,
                    FontStyle.Regular), Brushes.Black, 50, 100);
            }
        }
    }
}
