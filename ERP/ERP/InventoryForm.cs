using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class InventoryForm : Form
    {
        private int selectedProductId = -1;


        public InventoryForm()
        {
            InitializeComponent();
            LoadProducts();
        }


        private void LoadProducts()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT * FROM Products", conn);
                var adapter = new SQLiteDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void ClearForm()
        {
            txtName.Text = "";
            txtCategory.Text = "";
            txtQuantity.Text = "";
            txtUnitPrice.Text = "";
            selectedProductId = -1;
        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string category = txtCategory.Text.Trim();
            int quantity = int.TryParse(txtQuantity.Text, out int q) ? q : 0;
            decimal unitPrice = decimal.TryParse(txtUnitPrice.Text, out decimal p) ? p : 0;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Product name is required.");
                return;
            }

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SQLiteCommand cmd;

                if (selectedProductId == -1)
                {
                    // Add new product
                    cmd = new SQLiteCommand("INSERT INTO Products (Name, Category, Quantity, UnitPrice) VALUES (@Name, @Category, @Quantity, @UnitPrice)", conn);
                }
                else
                {
                    // Update existing product
                    cmd = new SQLiteCommand("UPDATE Products SET Name = @Name, Category = @Category, Quantity = @Quantity, UnitPrice = @UnitPrice WHERE Id = @Id", conn);
                    cmd.Parameters.AddWithValue("@Id", selectedProductId);
                }

                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Category", category);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);

                cmd.ExecuteNonQuery();
            }

            LoadProducts();
            ClearForm();
            MessageBox.Show("Product saved.");
        }

    
        

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (selectedProductId == -1)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    var cmd = new SQLiteCommand("DELETE FROM Products WHERE Id = @Id", conn);
                    cmd.Parameters.AddWithValue("@Id", selectedProductId);
                    cmd.ExecuteNonQuery();
                }

                LoadProducts();
                ClearForm();
                MessageBox.Show("Product deleted.");
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            LoadProducts();
            MessageBox.Show("Product list refreshed.");
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                selectedProductId = Convert.ToInt32(row.Cells["Id"].Value);
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtCategory.Text = row.Cells["Category"].Value.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
                txtUnitPrice.Text = row.Cells["UnitPrice"].Value.ToString();
            }
        }
    }
}




