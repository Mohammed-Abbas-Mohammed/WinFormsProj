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
    public partial class AdminCategory : Form
    {
        ICategoryServices CatService;
        BindingSource CatBindingSource;
        public AdminCategory()
        {
            InitializeComponent();
        }



        private void AdminCategory_Load(object sender, EventArgs e)
        {
            var Container = AutoFac.Inject();
            CatService = Container.Resolve<ICategoryServices>();
            CatBindingSource = new BindingSource(CatService.GetAllItmes().ToList(), "");


            bttnDeleteCat.Hide();
            bttnUpdateCat.Hide();
            lblSelectCat.Hide();
        }

        private void bttnShowAll_Click(object sender, EventArgs e)
        {
            Category_Details category_Details = new Category_Details();
            category_Details.ShowDialog();
        }

        private void bttnEditCat_Click(object sender, EventArgs e)
        {
            bttnDeleteCat.Show();
            bttnUpdateCat.Show();
            lblSelectCat.Show();
            bttnEditCat.Hide();

            #region
            //CatBindingSource = new BindingSource(CatService.GetAllItmes().ToList(), "");

            txtCatName.DataBindings.Add("Text", CatBindingSource, "CategoryName");
            txtCatDesc.DataBindings.Add("Text", CatBindingSource, "Description");
            picCatDate.DataBindings.Add("Text", CatBindingSource, "Created");
            //txtCatName.DataBindings.Add("Text", ProBindingSource, "CategoryName");
            comboCatID.DataSource = CatBindingSource; ;
            comboCatID.DisplayMember = "CategoryId";

            comCatName.DataSource = CatBindingSource; ;
            comCatName.DisplayMember = "CategoryName";

            #endregion
        }

        private void bttnUpdateCat_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(comboCatID.Text);
                var item = comboCatID.SelectedItem as DTOS.CreatCategoryDTO;
                CatService.UpdateOne(id, item);
                MessageBox.Show("Category has Updated Successfully");
            }
            catch
            {
                MessageBox.Show("Try Again");
            }
        }

        private void bttnDeleteCat_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(comboCatID.Text);
                CatService.DeleteOne(id);
                MessageBox.Show("Category has Deleted Successfully");
            }
            catch
            {
                MessageBox.Show("Try Again");
            }
        }

        private void bttnAddCat_Click(object sender, EventArgs e)
        {
            try
            {
                CatService.AddOne(new DTOS.CreatCategoryDTO
                {
                    CategoryName= txtCatName.Text,
                    Description = txtCatDesc.Text,
                });
                MessageBox.Show("Category has Inserted Successfully");
            }
            catch
            {
                MessageBox.Show("Try Again");
            }
        }
    }
}
