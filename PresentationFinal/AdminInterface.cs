using PresentationFinal;

namespace Presentation
{
    public partial class AdminInterface : Form
    {
        public AdminInterface()
        {
            InitializeComponent();
        }

        private void bttnGoToProduct_Click(object sender, EventArgs e)
        {
            AdminProduct product = new AdminProduct();
            product.Show();
            Hide();
        }

        private void bttnGoToCategory_Click(object sender, EventArgs e)
        {
            AdminCategory category = new AdminCategory();
            category.Show();
            Hide();
        }

        private void bttnGoToOrder_Click(object sender, EventArgs e)
        {
            OrderDetails OrderDetails = new OrderDetails();
            OrderDetails.ShowDialog();
        }

        private void bttnGoToCustomer_Click(object sender, EventArgs e)
        {

            CustomerDetails CustDetails = new CustomerDetails();
            CustDetails.ShowDialog();
        }
    }
}
