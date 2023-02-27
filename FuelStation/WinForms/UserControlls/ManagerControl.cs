using BlazorWasm.Shared.Customer;
using BlazorWasm.Shared.Items;
using BlazorWasm.Shared.Transaction;
using BlazorWasm.Shared.TransactionLine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.UserControlls
{
    public partial class ManagerControl : UserControl
    {
        public ManagerControl()
        {
            InitializeComponent();
        }



        private void ManagerControl_Load(object sender, EventArgs e)
        {
            populateData();
        }

        private void populateData()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7086/");

            var CustomersList = client.GetFromJsonAsync<List<CustomerDto>>("api/Customer");
            dataGridView1.DataSource = CustomersList;

            var TransactionList = client.GetFromJsonAsync<List<TransactionDto>>("api/Transaction");
            dataGridView3.DataSource = TransactionList;

            var TransactionLineList = client.GetFromJsonAsync<List<TransactionLineDto>>("api/TransactionLine");
            dataGridView4.DataSource = TransactionLineList;

            var ItemsList = client.GetFromJsonAsync<List<ItemsDto>>("api/Items");
            dataGridView2.DataSource = ItemsList;
        }
    }
}
