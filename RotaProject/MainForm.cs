using Microsoft.Data.SqlClient;
using RotaProject.DataAccess;
using RotaProject.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;


namespace RotaProject
{
    public partial class MainForm : Form
    {
        ProductsContext context = new();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AddItems();
            UpdateDataGrid();
            Task.Delay(3000);
            UpdateItems();
            UpdateDataGrid();
        }

        private async void AddItems()
        {
            /* Electronic */

            Category electronic = new Category()
            {
                Name = "Electronic",
                Products = new HashSet<Product>()
                {
                    new()
                    {
                        Name = "Computer 1",
                        Price = 100.5f,
                        StockBalance = 20.6f
                    },
                    new()
                    {
                        Name = "Computer 2",
                        Price = 150.8f,
                        StockBalance = 45.3f
                    },
                    new()
                    {
                        Name = "Computer 3",
                        Price = 205.4f,
                        StockBalance = 46.2f
                    }
                }
            };

            /* Home */

            Category home = new Category()
            {
                Name = "Home",
                Products = new HashSet<Product>()
                {
                    new()
                    {
                        Name = "Computer 1",
                        Price = 100.5f,
                        StockBalance = 20.6f
                    },
                    new()
                    {
                        Name = "Computer 2",
                        Price = 150.8f,
                        StockBalance = 45.3f
                    },
                    new()
                    {
                        Name = "Computer 3",
                        Price = 205.4f,
                        StockBalance = 46.2f
                    }
                }
            };

            await context.AddAsync(electronic);
            await context.AddAsync(home);
            await context.SaveChangesAsync();

        }

        private async void UpdateItems()
        {

            var categories = await context.Categories
                .Include(c => c.Products)
                .ToListAsync();

            Random random = new Random();

            foreach (var category in categories)
            {
                foreach (var product in category.Products)
                {
                    product.StockBalance = (float)random.NextDouble() * 100;
                }
            }

            await context.SaveChangesAsync();

        }

        private async void UpdateDataGrid()
        {
            var products = await context.Products.Include(p => p.Category).ToListAsync();

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            foreach (var product in products)
            {
                dataGridView1.Rows.Add(product.Name, product.Price, product.Category.Name, product.StockBalance);
            }
        }

    }
}
