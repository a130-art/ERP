using System;
using System.Data.SQLite;
using System.IO;

public static class DatabaseHelper
{
    private static string dbFile = "erp.db";
    private static string connStr = $"Data Source={dbFile};Version=3;";

    public static SQLiteConnection GetConnection()
    {
        if (!File.Exists(dbFile))
        {
            SQLiteConnection.CreateFile(dbFile);
            CreateTables();
        }

        return new SQLiteConnection(connStr);
    }

    private static void CreateTables()
    {
        using (var conn = new SQLiteConnection(connStr))
        {
            conn.Open();

            string[] tableCommands =
            {
                // Inventory Module
                @"CREATE TABLE IF NOT EXISTS Products (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Category TEXT,
                    Quantity INTEGER,
                    UnitPrice REAL
                );",

                // HR Module
                @"CREATE TABLE IF NOT EXISTS Employees (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    FullName TEXT NOT NULL,
                    Position TEXT,
                    Department TEXT,
                    HireDate TEXT,
                    Salary REAL,
                    Status TEXT
                );",

                // Sales Module
                @"CREATE TABLE IF NOT EXISTS Customers (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Email TEXT,
                    Phone TEXT,
                    Address TEXT
                );",

                @"CREATE TABLE IF NOT EXISTS Sales (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    CustomerId INTEGER,
                    ProductId INTEGER,
                    Quantity INTEGER,
                    TotalPrice REAL,
                    SaleDate TEXT,
                    FOREIGN KEY (CustomerId) REFERENCES Customers(Id),
                    FOREIGN KEY (ProductId) REFERENCES Products(Id)
                );",

                // Finance Module (Cari Hesap)
                @"CREATE TABLE IF NOT EXISTS Transactions (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    CustomerId INTEGER,
                    Date TEXT,
                    Description TEXT,
                    Amount REAL,
                    Type TEXT,
                    FOREIGN KEY (CustomerId) REFERENCES Customers(Id)
                );",

                // MRP Module
                @"CREATE TABLE IF NOT EXISTS Materials (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Stock INTEGER,
                    Unit TEXT
                );",

                @"CREATE TABLE IF NOT EXISTS ProductionPlans (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    MaterialId INTEGER,
                    PlannedQuantity INTEGER,
                    ScheduledDate TEXT,
                    FOREIGN KEY (MaterialId) REFERENCES Materials(Id)
                );"
            };

            foreach (var cmdText in tableCommands)
            {
                using (var cmd = new SQLiteCommand(cmdText, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }

            InsertSampleData(conn);
        }
    }

    private static void InsertSampleData(SQLiteConnection conn)
    {
        // Insert Products
        var checkProducts = new SQLiteCommand("SELECT COUNT(*) FROM Products", conn);
        if (Convert.ToInt32(checkProducts.ExecuteScalar()) == 0)
        {
            var insertProducts = new SQLiteCommand(@"INSERT INTO Products (Name, Category, Quantity, UnitPrice) VALUES
                ('Hammer', 'Tools', 50, 12.99),
                ('Aluminum Sheet', 'Raw Material', 200, 20.50),
                ('Office Chair', 'Furniture', 30, 89.99);", conn);
            insertProducts.ExecuteNonQuery();
        }

        // Insert Employees
        var checkEmployees = new SQLiteCommand("SELECT COUNT(*) FROM Employees", conn);
        if (Convert.ToInt32(checkEmployees.ExecuteScalar()) == 0)
        {
            var insertEmployees = new SQLiteCommand(@"INSERT INTO Employees (FullName, Position, Department, HireDate, Salary, Status) VALUES
                ('John Doe', 'Manager', 'Sales', '2022-01-10', 5000, 'Active'),
                ('Jane Smith', 'Technician', 'Production', '2021-05-15', 3500, 'Active');", conn);
            insertEmployees.ExecuteNonQuery();
        }

        // Insert Customers
        var checkCustomers = new SQLiteCommand("SELECT COUNT(*) FROM Customers", conn);
        if (Convert.ToInt32(checkCustomers.ExecuteScalar()) == 0)
        {
            var insertCustomers = new SQLiteCommand(@"INSERT INTO Customers (Name, Email, Phone, Address) VALUES
                ('Acme Corp', 'contact@acme.com', '1234567890', '123 Acme St'),
                ('GlobalTech', 'sales@globaltech.com', '9876543210', '456 Global Ave');", conn);
            insertCustomers.ExecuteNonQuery();
        }

        // Insert Materials
        var checkMaterials = new SQLiteCommand("SELECT COUNT(*) FROM Materials", conn);
        if (Convert.ToInt32(checkMaterials.ExecuteScalar()) == 0)
        {
            var insertMaterials = new SQLiteCommand(@"INSERT INTO Materials (Name, Stock, Unit) VALUES
                ('Steel Rod', 150, 'Kg'),
                ('Plastic Granule', 300, 'Kg');", conn);
            insertMaterials.ExecuteNonQuery();
        }
    }
}
