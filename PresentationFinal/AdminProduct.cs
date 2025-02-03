using AddPro;
using Autofac;
using MainAPP.SERVICES;
using Models;
using Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationFinal
{


    public partial class AdminProduct : Form
    {
        IProductServices ProdService;
        ICategoryServices CatService;
        BindingSource ProBindingSource;
        BindingSource CatBindingSource;

        public AdminProduct()
        {
            InitializeComponent();
        }

        private void AdminProduct_Load(object sender, EventArgs e)
        {

            var Container = AutoFac.Inject();
            ProdService = Container.Resolve<IProductServices>();
            ProBindingSource = new BindingSource(ProdService.GetAllItmes().ToList(), "");
            //CatBindingSource = new BindingSource(CatService.GetAllItmes().ToList(), "");

            //combCatName.DataSource = CatBindingSource;
            //combCatName.DisplayMember = "CategoryName";
            //combCatName.ValueMember = "CategoryId";

            bttnDelete.Hide();
            bttnUpdate.Hide();
            lblSelect.Hide();

        }


        private void bttnShowAll_Click(object sender, EventArgs e)
        {
            Product_Details product_Details = new Product_Details();
            product_Details.ShowDialog();
           
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(comboProID.Text);
                ProdService.DeleteOne(id);
                MessageBox.Show("Product has Deleted Successfully");
            }
            catch
            {
                MessageBox.Show("Try Again");
            }


        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ProdService.AddOne(new DTOS.AdminProductDTO
                {
                    ProductName = txtProName.Text,
                    UnitPrice = int.Parse(txtProPrice.Text),
                    UnitsInStock = int.Parse(txtProInStock.Text),
                    Category = new Category { CategoryName = txtCategoryName.Text }
                });
                MessageBox.Show("Product has Inserted Successfully");
            }
            catch
            {
                MessageBox.Show("Try Again");
            }

        }

        private void bttnEdit_Click(object sender, EventArgs e)
        {
            bttnDelete.Show();
            bttnUpdate.Show();
            lblSelect.Show();
            bttnEdit.Hide();

            #region
            

            txtProName.DataBindings.Add("Text", ProBindingSource, "ProductName");
            txtProPrice.DataBindings.Add("Text", ProBindingSource, "UnitPrice");
            txtProInStock.DataBindings.Add("Text", ProBindingSource, "UnitsInStock");

           

            comboProID.DataSource = ProBindingSource; ;
            comboProID.DisplayMember = "ProductID";

            #endregion
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(comboProID.Text);
                var item = comboProID.SelectedItem as DTOS.AdminProductDTO;
                ProdService.UpdateOne(id, item);
                MessageBox.Show("Product has Updated Successfully");
            }
            catch
            {
                MessageBox.Show("Try Again");
            }
            
        }
    }
}
