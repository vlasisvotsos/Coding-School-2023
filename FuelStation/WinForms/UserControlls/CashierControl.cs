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

            var responseEmp = client.GetAsync("api/Customer").Result;
            var emp = responseEmp.Content.ReadFromJsonAsync<IEnumerable<CustomerDto>>().Result;
            dataGridView1.DataSource = emp;

            var responseTra = client.GetAsync("api/Transaction").Result;
            var tra = responseTra.Content.ReadFromJsonAsync<IEnumerable<TransactionDto>>().Result;
            dataGridView2.DataSource = tra;

            var responseLine = client.GetAsync("api/TransactionLine").Result;
            var line = responseLine.Content.ReadFromJsonAsync<IEnumerable<TransactionLineDto>>().Result;
            dataGridView3.DataSource = line;

        }
    }
}
