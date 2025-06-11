using System.Data.SQLite;
using System.Data;

namespace ERP
{
    public partial class HRForm : Form
    {
        public HRForm()
        {
            InitializeComponent();
            cmbStatus.Items.AddRange(new string[] { "Active", "Inactive" });
            cmbStatus.SelectedIndex = 0;
            LoadEmployees();
        }

        private int selectedEmployeeId = -1;
        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string position = txtPosition.Text.Trim();
            string department = txtDepartment.Text.Trim();
            DateTime hireDate = dtpHireDate.Value.Date;
            double salary = double.TryParse(txtSalary.Text, out double s) ? s : 0;
            string status = cmbStatus.SelectedItem?.ToString() ?? "Active";

            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Full name is required.");
                return;
            }

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SQLiteCommand cmd;

                if (selectedEmployeeId == -1)
                {
                    cmd = new SQLiteCommand(@"INSERT INTO Employees 
                        (FullName, Position, Department, HireDate, Salary, Status) 
                        VALUES (@FullName, @Position, @Department, @HireDate, @Salary, @Status)", conn);
                }
                else
                {
                    cmd = new SQLiteCommand(@"UPDATE Employees 
                        SET FullName = @FullName, Position = @Position, Department = @Department,
                            HireDate = @HireDate, Salary = @Salary, Status = @Status
                        WHERE Id = @Id", conn);
                    cmd.Parameters.AddWithValue("@Id", selectedEmployeeId);
                }

                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@Position", position);
                cmd.Parameters.AddWithValue("@Department", department);
                cmd.Parameters.AddWithValue("@HireDate", hireDate);
                cmd.Parameters.AddWithValue("@Salary", salary);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.ExecuteNonQuery();
            }

            LoadEmployees();
            ClearForm();
            MessageBox.Show("Employee record saved.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedEmployeeId == -1)
            {
                MessageBox.Show("Please select an employee to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    var cmd = new SQLiteCommand("DELETE FROM Employees WHERE Id = @Id", conn);
                    cmd.Parameters.AddWithValue("@Id", selectedEmployeeId);
                    cmd.ExecuteNonQuery();
                }

                LoadEmployees();
                ClearForm();
                MessageBox.Show("Employee deleted.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadEmployees();
            MessageBox.Show("Employee list refreshed.");
        }



        private void LoadEmployees()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT * FROM Employees", conn);
                var adapter = new SQLiteDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }

        }


        private void ClearForm()
        {
            txtFullName.Text = "";
            txtPosition.Text = "";
            txtDepartment.Text = "";
            txtSalary.Text = "";
            dtpHireDate.Value = DateTime.Today;
            cmbStatus.SelectedIndex = 0;
            selectedEmployeeId = -1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                selectedEmployeeId = Convert.ToInt32(row.Cells["Id"].Value);
                txtFullName.Text = row.Cells["FullName"].Value.ToString();
                txtPosition.Text = row.Cells["Position"].Value.ToString();
                txtDepartment.Text = row.Cells["Department"].Value.ToString();
                txtSalary.Text = row.Cells["Salary"].Value.ToString();
                dtpHireDate.Value = Convert.ToDateTime(row.Cells["HireDate"].Value);
                cmbStatus.SelectedItem = row.Cells["Status"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists("erp.db"))
                File.Delete("erp.db");

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open(); // Triggers CreateTables again
            }

            MessageBox.Show("Database recreated.");

        }
    }
}
