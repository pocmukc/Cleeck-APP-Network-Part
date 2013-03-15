using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cleeck.sockets;


namespace Cleeck
{
    class MessageManager
    {
        public string msg;
        public void update(string val)
        {

        }
    }
    public partial class Cleeck : Form
    {

        public Cleeck()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HTTPConnector connector = new HTTPConnector();
            connector.msg = new MessageManager(){
                public void update(string msg)
                {
                    label1.Text = msg;
                }
            }
            connector.request();
        }
    }
}
