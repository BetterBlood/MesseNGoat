using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MesseNGoatServer
{
    public partial class Form1 : Form
    {
        Server _server;
        // Thread _threadListener; // ça ne marche pas je sais pas pk....
        public Form1()
        {
            InitializeComponent();

            _server = new Server(32123);
            labelServeurIP.Text = _server.GetIP();
        }

        private void buttonSetUpServer_Click(object sender, EventArgs e)
        {
            labelIsConnected.Text = "Connecting...";
            Thread _threadListener = new Thread(new ThreadStart(TryToConnect));
            _threadListener.Name = "test";
            _threadListener.Start();
        }
        
        private void TryToConnect()
        {
            _server.TryToConnect(this, labelIsConnected, richTextBoxCommunications);
        }

        private void buttonToShutDown_Click(object sender, EventArgs e)
        {
            labelIsConnected.Text = "ButtonClick";
        }
    }
}
