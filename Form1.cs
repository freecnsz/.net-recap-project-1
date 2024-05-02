namespace RecapProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This is the event handler for the combobox. It will be triggered when the selected index of the combobox changes.
            try
            {
                ListProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {

            }

        }

        // This is the event handler for the text box. It will be triggered when the text in the text box changes.
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            // If the text in the text box is empty, call ListProducts() to list all products. Otherwise, call ListProductsProductName() to list products by name.
            string key = tbxSearch.Text;
            if (string.IsNullOrEmpty(key))
            {
                ListProducts();
            }
            else
            {
                ListProductsProductName(tbxSearch.Text);
            }

        }

        // This is the event handler for the form. It will be triggered when the form is loaded.
        private void Form1_Load(object sender, EventArgs e)
        {
            ListCategories();
            ListProducts();

        }

        // This method lists all products.
        private void ListProducts()
        {
            // Create a new instance of the NorthwindContext class.
            using (NorthwindContext context = new NorthwindContext())
            {
                // Set the DataSource property of the DataGridView to the list of products in the database.
                dgwProduct.DataSource = context.Products.ToList();
            }
        }

        // This method lists products by category.
        private void ListCategories()
        {
            // Create a new instance of the NorthwindContext class.
            using (NorthwindContext context = new NorthwindContext())
            {
                // Set the DataSource property of the ComboBox to the list of categories in the database. Set the DisplayMember property to "CategoryName" and the ValueMember property to "CategoryId".
                cbxCategory.DataSource = context.Categories.ToList();
                cbxCategory.DisplayMember = "CategoryName";
                cbxCategory.ValueMember = "CategoryId";
            }
        }

        // This method lists products by category.
        private void ListProductsByCategory(int categoryId)
        {
            // Create a new instance of the NorthwindContext class.
            using (NorthwindContext context = new NorthwindContext())
            {
                // Set the DataSource property of the DataGridView to the list of products in the database where the CategoryId is equal to the categoryId parameter.
                dgwProduct.DataSource = context.Products.Where(p => p.CategoryId == categoryId).ToList();
            }
        }

        // This method lists products by name.
        private void ListProductsProductName(string key)
        {
            // Create a new instance of the NorthwindContext class.
            using (NorthwindContext context = new NorthwindContext())
            {
                // Set the DataSource property of the DataGridView to the list of products in the database where the ProductName contains the key parameter.
                dgwProduct.DataSource = context.Products.Where(p => p.ProductName.Contains(key)).ToList();
            }
        }
    }
}
