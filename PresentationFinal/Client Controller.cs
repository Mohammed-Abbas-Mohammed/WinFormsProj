using AddPro;
using Autofac;
using Categoryy.FForm;
using MainAPP.SERVICES;
using Models;
using PresentationFinal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Presentation
{
    public partial class ClientController : Form
    {
        IProductServices ProdService;
        IOrderServices OrdService;
        ICustomerServices CustService;

        BindingSource ProBindingSource;
        BindingSource OrdBindingSource;
        BindingSource CustBindingSource;
        BindingSource CartBindingSource;
        public ClientController()
        {
            InitializeComponent();
        }

        private void bttnShowAll_Click(object sender, EventArgs e)
        {
            Product_Details ProductD = new Product_Details();
            ProductD.ShowDialog();
        }

        private void ClientController_Load(object sender, EventArgs e)
        {
            var Container = AutoFac.Inject();
            ProdService = Container.Resolve<IProductServices>();
            ProBindingSource = new BindingSource(ProdService.GetAllItmes().ToList(), "");


            txtProName.DataBindings.Add("Text", ProBindingSource, "ProductName");
            txtProPrice.DataBindings.Add("Text", ProBindingSource, "UnitPrice");
            comboProName.DataSource = ProBindingSource; ;
            comboProName.DisplayMember = "ProductName";
            //picProduct.DataBindings.Add("Image", ProBindingSource, "ProductImage");

            lblCat.Hide();
            lblPrice.Hide();
            lblProName.Hide();
            txtCatName.Hide();
            txtProName.Hide();
            txtProPrice.Hide();
            picProduct.Hide();
            gridSearchResult.Hide();
            gridCustomerPros.Hide();
        }

        private void comboProID_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCat.Show();
            lblPrice.Show();
            lblProName.Show();
            txtCatName.Show();
            txtProName.Show();
            txtProPrice.Show();
            picProduct.Show();
            gridSearchResult.Hide();
        }

        private void bttnSearch_Click(object sender, EventArgs e)
        {
            string searchWord = txtSearchWord.Text;
            gridSearchResult.DataSource = ProdService.Search(searchWord).ToList();
            gridSearchResult.Show();
            lblCat.Hide();
            lblPrice.Hide();
            lblProName.Hide();
            txtCatName.Hide();
            txtProName.Hide();
            txtProPrice.Hide();
            picProduct.Hide();

        }

        BindingList<object> list = new BindingList<object>();
        int count = 0;
        private void bttnAddToCart_Click(object sender, EventArgs e)
        {
            list.Add(comboProName.SelectedItem);
            count++;
            lblCounter.Text = count.ToString();

        }

        private void gridCustomerPros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bttnShowCart_Click(object sender, EventArgs e)
        {
         
            gridCustomerPros.Show();
            gridCustomerPros.DataSource = list;
            CartBindingSource = new BindingSource(list, "");
            gridCustomerPros.Columns["Category"].Visible = false;

            DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn
            {
                Name = "Quantity",
                HeaderText = "Quantity",
                ValueType = typeof(int)

            };

            DataGridViewTextBoxColumn totalPriceColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Total Price",
                Name = "TotalPrice",
                Visible = false
            };
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "Action",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };

            gridCustomerPros.Columns.Add(quantityColumn);
            gridCustomerPros.Columns.Add(totalPriceColumn);
            gridCustomerPros.Columns.Add(deleteButtonColumn);


            gridCustomerPros.CellValueChanged += DataGridView1_CellValueChanged;
            gridCustomerPros.CellEndEdit += DataGridView1_CellEndEdit;
            gridCustomerPros.CellContentClick += GridCustomerPros_CellContentClick;
            gridCustomerPros.CellContentClick += GridCustomerPros_CellContentClick;

        }
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UpdateTotalPrice(e.RowIndex);
                CalculateTotalSum();
            }
        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UpdateTotalPrice(e.RowIndex);
                CalculateTotalSum();
            }
        }

        private void GridCustomerPros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == gridCustomerPros.Columns["Delete"].Index)
            {
                
                if (gridCustomerPros.IsCurrentRowDirty)
                {
                    gridCustomerPros.EndEdit();
                }

               
                if (gridCustomerPros.Rows[e.RowIndex].IsNewRow)
                {
                    return; 
                }

               
                list.RemoveAt(e.RowIndex);

            
                count = list.Count;
                lblCounter.Text = count.ToString();
            }
        }

        private void UpdateTotalPrice(int rowIndex)
        {
            DataGridViewRow row = gridCustomerPros.Rows[rowIndex];

            int quantity = Convert.ToInt32(row.Cells["Quantity"].Value ?? 0);
            int unitPrice = Convert.ToInt32(row.Cells["UnitPrice"].Value ?? 0);

            int totalPrice = quantity * unitPrice;
            row.Cells["TotalPrice"].Value = totalPrice;
        }

        private void CalculateTotalSum()
        {
            decimal totalSum = 0;

            foreach (DataGridViewRow row in gridCustomerPros.Rows)
            {
                if (row.Cells["TotalPrice"].Value != null)
                {
                    int totalPrice = Convert.ToInt32(row.Cells["TotalPrice"].Value);
                    totalSum += totalPrice;
                }
            }

            lblTotalPrice.Text = totalSum.ToString();

        }

        private void bttnConfirm_Click(object sender, EventArgs e)
        {
            CustomerInsertion dilaog = new CustomerInsertion();
            dilaog.ShowDialog();

            var Container = AutoFac.Inject();
            OrdService = Container.Resolve<IOrderServices>();
            OrdBindingSource = new BindingSource(OrdService.GetAllItmes().ToList(), "");

            var ContainerCust = AutoFac.Inject();
            CustService = ContainerCust.Resolve<ICustomerServices>();
            CustBindingSource = new BindingSource(CustService.GetAllItmes().ToList(), "");

            OrdService.AddOne(new DTOS.OrderDTO
            {
                TotalPrice = int.Parse(lblTotalPrice.Text),
                Customer = new Customer()
                {
                    FirsName = dilaog.FirstName,
                    LastName = dilaog.LastName,
                    PhoneNumber = int.Parse(dilaog.Phone),
                    Address = dilaog.Address,
                    Email = dilaog.Email,
                }

            });
            Close();
        }
    }
}
