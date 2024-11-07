namespace Agile201_GroupProject1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            AddNewProductForm addNewProductForm = new AddNewProductForm();
            addNewProductForm.ShowDialog();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateProductForm updateProductForm = new UpdateProductForm();
            updateProductForm.ShowDialog();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            DisplayProductForm displayProductForm = new DisplayProductForm();
            displayProductForm.ShowDialog();
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            CheckOutForm checkoutForm = new CheckOutForm();
            checkoutForm.ShowDialog();
        }
    }
}
