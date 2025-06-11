namespace ERP
{
    partial class InventoryForm
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
            btnAddOrUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnClear = new Button();
            txtName = new TextBox();
            txtCategory = new TextBox();
            txtQuantity = new TextBox();
            txtUnitPrice = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAddOrUpdate
            // 
            btnAddOrUpdate.Font = new Font("Segoe UI", 10F);
            btnAddOrUpdate.Location = new Point(25, 465);
            btnAddOrUpdate.Name = "btnAddOrUpdate";
            btnAddOrUpdate.Size = new Size(270, 60);
            btnAddOrUpdate.TabIndex = 0;
            btnAddOrUpdate.Text = "Add / Update";
            btnAddOrUpdate.UseVisualStyleBackColor = true;
            btnAddOrUpdate.Click += btnAddOrUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10F);
            btnDelete.Location = new Point(330, 465);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(270, 60);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 10F);
            btnRefresh.Location = new Point(940, 465);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(270, 60);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F);
            label1.Location = new Point(540, 18);
            label1.Name = "label1";
            label1.Size = new Size(619, 76);
            label1.TabIndex = 4;
            label1.Text = "Inventory Management";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 557);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.Size = new Size(1468, 655);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 10F);
            btnClear.Location = new Point(635, 465);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(270, 60);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click_1;
            // 
            // txtName
            // 
            txtName.Location = new Point(288, 126);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(501, 47);
            txtName.TabIndex = 7;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(288, 205);
            txtCategory.Multiline = true;
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(501, 47);
            txtCategory.TabIndex = 8;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(288, 283);
            txtQuantity.Multiline = true;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(501, 47);
            txtQuantity.TabIndex = 9;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(288, 356);
            txtUnitPrice.Multiline = true;
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(501, 47);
            txtUnitPrice.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(114, 126);
            label2.Name = "label2";
            label2.Size = new Size(109, 46);
            label2.TabIndex = 11;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(107, 207);
            label3.Name = "label3";
            label3.Size = new Size(156, 46);
            label3.TabIndex = 12;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(114, 285);
            label4.Name = "label4";
            label4.Size = new Size(149, 46);
            label4.TabIndex = 13;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(114, 356);
            label5.Name = "label5";
            label5.Size = new Size(164, 46);
            label5.TabIndex = 14;
            label5.Text = "Unit Price";
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1468, 1212);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtCategory);
            Controls.Add(txtName);
            Controls.Add(btnClear);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnAddOrUpdate);
            Name = "InventoryForm";
            Text = "InventoryForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddOrUpdate;
        private Button btnDelete;
        private Button btnRefresh;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnClear;
        private TextBox txtName;
        private TextBox txtCategory;
        private TextBox txtQuantity;
        private TextBox txtUnitPrice;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}