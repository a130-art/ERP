namespace ERP
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();


        private void LoadForm(Form form)
        {
            panel1.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.Show();
        }


        private void btnInventory_Click(object sender, EventArgs e)
        {
            //Inventory f = new Inventory();
            //f.Show();
            LoadForm(new InventoryForm());

        }

        private void btnHR_Click(object sender, EventArgs e)
        {
            LoadForm(new HRForm());
        }

        private void btnSales_Click(object sender, EventArgs e)
        {

            LoadForm(new SalesForm());

        }

        private void btnMRP_Click(object sender, EventArgs e)
        {
            LoadForm(new MRPForm());
        }

        private void btnFinance_Click(object sender, EventArgs e)
        {
            LoadForm(new FinanceForm());
        }
    }
}
