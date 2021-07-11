using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void AddListBox()
        {

        }
    }
}
