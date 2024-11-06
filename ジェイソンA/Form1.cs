namespace ジェイソンA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var product = new Product(
                Convert.ToInt32(ProductIdTextBox.Text),
                ProductNameTextBox.Text);

            string jsonString = System.Text.Json.JsonSerializer.Serialize(product);
            System.IO.File.WriteAllText("aaa.json",jsonString);


        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            string jsonString = File.ReadAllText("aaa.json");
            var product = System.Text.Json.JsonSerializer.Deserialize<Product>(jsonString);
            MessageBox.Show(product.ProductId.ToString());
            MessageBox.Show(product.ProductName);
        }
    }

    public class Product
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Product()
        {

        }

        public Product(int productId, string productName)
        {
            ProductId = productId;
            ProductName = productName;
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }

    }
}