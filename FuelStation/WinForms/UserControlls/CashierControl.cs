using BlazorWasm.Shared.Customer;
using BlazorWasm.Shared.Transaction;
using BlazorWasm.Shared.TransactionLine;
using EF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.UserControlls
{
    public partial class CashierControl : UserControl
    {
        public CashierControl()
        {
            InitializeComponent();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7086/");

            var CustomersList = client.GetFromJsonAsync<List<CustomerDto>>("api/Customer");
            dataGridView1.DataSource = CustomersList;

            var TransactionList = client.GetFromJsonAsync<List<TransactionDto>>("api/Transaction");
            dataGridView2.DataSource = TransactionList;

            var TransactionLineList = client.GetFromJsonAsync<List<TransactionLineDto>>("api/TransactionLine");
            dataGridView3.DataSource = TransactionLineList;

        }

        private void CashierControl_Load(object sender, EventArgs e)
        {
            
        }
    }
}
