using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortalApp
{
    public partial class frm_Portal : Form
    {
        public frm_Portal()
        {
            InitializeComponent();
        }


        private void frm_OneThread_Click(object sender, EventArgs e)
        {
            while (true)
            {

            }
        }


        private async void btn_ManyThread_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                while (true)
                {

                }
            });
        }

        private void btn_OneSyncRequest_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:9971/api/");
                client.DefaultRequestHeaders.Clear();
                var responseTask = client.GetAsync(client.BaseAddress + "Sync");

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<string>>();
                    var res = readTask.Result;
                    PrintResult(res);
                }
                else
                {
                    throw new Exception("Error");
                }
            }
        }

        private void PrintResult(List<string> list)
        {
            foreach (var item in list)
            {
                lst_Result.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lst_Result.Items.Clear();
        }

        private async void btn_AsyncRequest_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:9971/api/");
                client.DefaultRequestHeaders.Clear();
                var responseTask = await client.GetAsync(client.BaseAddress + "Async");

                var result = responseTask;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<string>>();
                    var res = await readTask;
                    PrintResult(res);
                }
                else
                {
                    throw new Exception("Error");
                }
            }
        }

      
    }
}
