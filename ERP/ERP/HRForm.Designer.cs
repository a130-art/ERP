namespace ERP
{
    partial class HRForm
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtDepartment = new TextBox();
            txtPosition = new TextBox();
            txtFullName = new TextBox();
            btnClear = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnAddOrUpdate = new Button();
            dtpHireDate = new DateTimePicker();
            cmbStatus = new ComboBox();
            label6 = new Label();
            txtSalary = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(12, 470);
            label5.Name = "label5";
            label5.Size = new Size(202, 46);
            label5.TabIndex = 28;
            label5.Text = "Date of Hire";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(12, 312);
            label4.Name = "label4";
            label4.Size = new Size(201, 46);
            label4.TabIndex = 27;
            label4.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(12, 234);
            label3.Name = "label3";
            label3.Size = new Size(139, 46);
            label3.TabIndex = 26;
            label3.Text = "Position";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(12, 165);
            label2.Name = "label2";
            label2.Size = new Size(325, 46);
            label2.TabIndex = 25;
            label2.Text = "Employee Full Name";
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(335, 316);
            txtDepartment.Multiline = true;
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(501, 47);
            txtDepartment.TabIndex = 23;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(335, 244);
            txtPosition.Multiline = true;
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(501, 47);
            txtPosition.TabIndex = 22;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(335, 165);
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(501, 47);
            txtFullName.TabIndex = 21;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 10F);
            btnClear.Location = new Point(640, 641);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(270, 60);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 720);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.Size = new Size(1468, 492);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F);
            label1.Location = new Point(281, 36);
            label1.Name = "label1";
            label1.Size = new Size(832, 76);
            label1.TabIndex = 18;
            label1.Text = "Human Resources Management";
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 10F);
            btnRefresh.Location = new Point(945, 641);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(270, 60);
            btnRefresh.TabIndex = 17;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10F);
            btnDelete.Location = new Point(335, 641);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(270, 60);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAddOrUpdate
            // 
            btnAddOrUpdate.Font = new Font("Segoe UI", 10F);
            btnAddOrUpdate.Location = new Point(30, 641);
            btnAddOrUpdate.Name = "btnAddOrUpdate";
            btnAddOrUpdate.Size = new Size(270, 60);
            btnAddOrUpdate.TabIndex = 15;
            btnAddOrUpdate.Text = "Add / Update";
            btnAddOrUpdate.UseVisualStyleBackColor = true;
            btnAddOrUpdate.Click += btnAddOrUpdate_Click;
            // 
            // dtpHireDate
            // 
            dtpHireDate.Location = new Point(335, 470);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(501, 47);
            dtpHireDate.TabIndex = 29;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(398, 554);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(359, 49);
            cmbStatus.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(12, 557);
            label6.Name = "label6";
            label6.Size = new Size(360, 46);
            label6.TabIndex = 31;
            label6.Text = "Status (Active/Inactive)";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(333, 384);
            txtSalary.Multiline = true;
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(503, 47);
            txtSalary.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(12, 385);
            label7.Name = "label7";
            label7.Size = new Size(108, 46);
            label7.TabIndex = 33;
            label7.Text = "Salary";
            // 
            // HRForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1468, 1212);
            Controls.Add(label7);
            Controls.Add(txtSalary);
            Controls.Add(label6);
            Controls.Add(cmbStatus);
            Controls.Add(dtpHireDate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDepartment);
            Controls.Add(txtPosition);
            Controls.Add(txtFullName);
            Controls.Add(btnClear);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnAddOrUpdate);
            Name = "HRForm";
            Text = "HRForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtDepartment;
        private TextBox txtPosition;
        private TextBox txtFullName;
        private Button btnClear;
        private DataGridView dataGridView1;
        private Label label1;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnAddOrUpdate;
        private DateTimePicker dtpHireDate;
        private ComboBox cmbStatus;
        private Label label6;
        private TextBox txtSalary;
        private Label label7;
    }
}