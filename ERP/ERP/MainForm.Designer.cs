namespace ERP
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            panel1 = new Panel();
            label3 = new Label();
            btnInventory = new Button();
            btnHR = new Button();
            btnSales = new Button();
            btnMRP = new Button();
            btnFinance = new Button();
            panel3 = new Panel();
            label2 = new Label();
            panel5 = new Panel();
            label1 = new Label();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(205, 178, 124);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 1455);
            panel2.Name = "panel2";
            panel2.Size = new Size(1918, 57);
            panel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Cursor = Cursors.IBeam;
            panel1.Location = new Point(381, 144);
            panel1.Name = "panel1";
            panel1.Size = new Size(1500, 1300);
            panel1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(205, 178, 124);
            label3.Location = new Point(44, 171);
            label3.Name = "label3";
            label3.Size = new Size(285, 62);
            label3.TabIndex = 4;
            label3.Text = "Menu Panel";
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.FromArgb(205, 178, 124);
            btnInventory.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnInventory.Location = new Point(45, 283);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(284, 66);
            btnInventory.TabIndex = 7;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnHR
            // 
            btnHR.BackColor = Color.FromArgb(205, 178, 124);
            btnHR.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnHR.Location = new Point(45, 389);
            btnHR.Name = "btnHR";
            btnHR.Size = new Size(284, 66);
            btnHR.TabIndex = 8;
            btnHR.Text = "HR";
            btnHR.UseVisualStyleBackColor = false;
            btnHR.Click += btnHR_Click;
            // 
            // btnSales
            // 
            btnSales.BackColor = Color.FromArgb(205, 178, 124);
            btnSales.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSales.Location = new Point(45, 496);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(284, 66);
            btnSales.TabIndex = 9;
            btnSales.Text = "Sales";
            btnSales.UseVisualStyleBackColor = false;
            btnSales.Click += btnSales_Click;
            // 
            // btnMRP
            // 
            btnMRP.BackColor = Color.FromArgb(205, 178, 124);
            btnMRP.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnMRP.Location = new Point(45, 604);
            btnMRP.Name = "btnMRP";
            btnMRP.Size = new Size(284, 66);
            btnMRP.TabIndex = 10;
            btnMRP.Text = "MRP";
            btnMRP.UseVisualStyleBackColor = false;
            btnMRP.Click += btnMRP_Click;
            // 
            // btnFinance
            // 
            btnFinance.BackColor = Color.FromArgb(205, 178, 124);
            btnFinance.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnFinance.Location = new Point(45, 713);
            btnFinance.Name = "btnFinance";
            btnFinance.Size = new Size(284, 66);
            btnFinance.TabIndex = 11;
            btnFinance.Text = "Finance";
            btnFinance.UseVisualStyleBackColor = false;
            btnFinance.Click += btnFinance_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(76, 89, 61);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(btnFinance);
            panel3.Controls.Add(btnMRP);
            panel3.Controls.Add(btnSales);
            panel3.Controls.Add(btnHR);
            panel3.Controls.Add(btnInventory);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1918, 1455);
            panel3.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(205, 178, 124);
            label2.Location = new Point(12, 1381);
            label2.Name = "label2";
            label2.Size = new Size(146, 50);
            label2.TabIndex = 12;
            label2.Text = "Logout";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(76, 89, 61);
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1918, 148);
            panel5.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(205, 178, 124);
            label1.Location = new Point(60, 26);
            label1.Name = "label1";
            label1.Size = new Size(517, 89);
            label1.TabIndex = 4;
            label1.Text = "ERP Dashboard";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1918, 1512);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "MainForm";
            Text = "ERP";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel1;
        private Label label3;
        private Button btnInventory;
        private Button btnHR;
        private Button btnSales;
        private Button btnMRP;
        private Button btnFinance;
        private Panel panel3;
        private Panel panel5;
        private Label label1;
        private Label label2;
    }
}
