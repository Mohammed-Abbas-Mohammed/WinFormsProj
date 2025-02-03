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
    public partial class OrderDetails : Form
    {
        IOrderServices OrdService;
        public OrderDetails()
        {
            InitializeComponent();
        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {
            var Container = AutoFac.Inject();
            OrdService = Container.Resolve<IOrderServices>();
            OrderGridView.DataSource = OrdService.GetAllItmes().ToList();
            OrderGridView.Columns["Customer"].Visible = false;
        }
    }
}
