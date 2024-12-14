using OrderDetailsMaintenance.Models.DataLayer;

namespace OrderDetailsMaintenance
{
    public partial class frmCustomerMaintenance : Form
    {
        private NorthwindContext _context;
        private Customer customer;
        public string customerKey;
        public frmCustomerMaintenance()
        {
            InitializeComponent();
        }

        private void frmCustomerMaintenance_Load(object sender, EventArgs e)
        {
            _context = new NorthwindContext();
            customer = _context.Customers.First();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            customer.ContactName = txtContact.Text;
            customer.Address = txtAddress.Text;
            customer.City = txtCity.Text;
            customer.Country = txtCountry.Text;
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            customerKey = txtCustomerId.Text;
            customer = _context.Customers.Single(b => b.CustomerId == customerKey);
            txtContact.Text = customer.ContactName;
            txtAddress.Text = customer.Address;
            txtCity.Text = customer.City;
            txtCountry.Text = customer.Country;
        }
        //Madelyn Lanier
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }





    }
}