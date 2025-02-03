
using AddPro;

using Autofac;
using DbCont;
using DTOS;
using MainAPP.SERVICES;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Product_Details : Form
    {
        IProductServices ProdService;
        //ProCon ProContext;
        public Product_Details()
        {
            InitializeComponent();
        }



        private void Product_Details_Load(object sender, EventArgs e)
        {
            var Container = AutoFac.Inject();
            ProdService = Container.Resolve<IProductServices>();
            ProductGridView.DataSource = ProdService.GetAllItmes().ToList();
            ProductGridView.Columns["Category"].Visible = false;
        }

   
        //private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    AdminProductDTO adminProductDTO = new AdminProductDTO({
        //        ProductID = ,
        //        ProductName = ,
        //        UnitPrice = ,
        //        UnitsInStock = ,
        //        Category = new Models.Category { CategoryName = "" }
        //    });
        //    ProdService.UpdateOne(adminProductDTO);
        //}

        
    }
}
