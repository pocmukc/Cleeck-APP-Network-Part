using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cleeck.sockets;
using System.Threading.Tasks;


namespace Cleeck
{
    public partial class Cleeck : Form
    {
        public Cleeck()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HTTPConnector connector = new HTTPConnector(
                "90.188.1.11",
                35555,
                TypeOfConnect.Mobile
                );
            Task<string> task = new Task<string>(() => connector.request());
            task.Start();
            label1.Text = task.Result;
        }
    }
}
