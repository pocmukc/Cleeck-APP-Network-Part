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
            HTTPConnector connector = new HTTPConnector();
            Parallel.Invoke(() => 
                {
                    try
                    {
                        label1.Text = connector.request();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                });
        }
    }
}
