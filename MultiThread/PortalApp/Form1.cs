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
                // var result1 = responseTask.GetAwaiter().GetResult();

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

        private void btn_ConfigureAwait_Click(object sender, EventArgs e)
        {
            var result = GetSampleString().Result;
            lst_Result.Items.Add(result);
        }

        public async Task<string> GetSampleString()
        {
            await Task.Delay(2000);
            return "configure await result";
        }

        private void btnMultiThread_Click(object sender, EventArgs e)
        {
            var thread1 = new Thread(WorkThreadFunction);
            thread1.Name = "Thread 1";
            thread1.Start();

            var thread2 = new Thread(WorkThreadFunction);
            thread2.Name = "Thread 2";
            thread2.Start();

            var thread3 = new Thread(WorkThreadFunction);
            thread3.Name = "Thread 3";
            thread3.Start();

        }

        public void WorkThreadFunction()
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    var sssssssssssss = Thread.CurrentThread.Name;
                }
            }
            catch (Exception ex)
            {
                // log errors
            }
        }
    }


}
