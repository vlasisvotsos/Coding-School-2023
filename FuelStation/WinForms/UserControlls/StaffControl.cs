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
    public partial class StaffControl : UserControl
    {
        public StaffControl()
        {
            InitializeComponent();
        }


        private void StaffControl_Load(object sender, EventArgs e)
        {
            populateData();
        }

        private void populateData()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7086/");

            var ItemsList = client.GetFromJsonAsync<List<ItemsDto>>("api/Items");
            dataGridView1.DataSource = ItemsList;
        }
    }
}
