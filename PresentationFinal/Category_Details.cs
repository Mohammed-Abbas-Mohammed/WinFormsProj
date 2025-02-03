using AddPro;
using Autofac;
using MainAPP.SERVICES;
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
    public partial class Category_Details : Form
    {
        ICategoryServices CatService;
        public Category_Details()
        {
            InitializeComponent();
        }

        private void Category_Details_Load(object sender, EventArgs e)
        {
            var Container = AutoFac.Inject();
            CatService = Container.Resolve<ICategoryServices>();
            gridCatDetails.DataSource = CatService.GetAllItmes().ToList();
        }
    }
}
