using Northwind.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Northwind.Controllers;

namespace Northwind.Views.Category
{
    public partial class CategoryInsert : Form
    {
        public CategoryInsert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            CategoryController.Add(new Models.Category { CategoryName = txtCategoryName.Text , Description = txtDescription.Text });
            
        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {

        }

        private void CategoryInsert_Load(object sender, EventArgs e)
        {

        }
    }
}
