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
using Cleeck.Data;

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
            string res = connector.request();
            label1.Text = res;
            //JSONParser jsn = new JSONParser();
            //Dictionary<string, string> dict = jsn.parse(res);
            //JSONSocket sock = new JSONSocket(dict["ip"], dict["port"]);
            //sock.connect();
            //string auth = "{auth, 156165, \"asdfsgdf\", \"asdfg\"}";
            //{auth, 1234, anonymous}
            //MessageBox.Show(sock.Send(auth));
        }
    }
}
