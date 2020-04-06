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

        // ptetre faire une liste ? jsp
        Thread _threadListener; // ça ne marche pas je sais pas pk.... en fait ça marche, ptetre j'avais pas compillé le code
        public Form1()
        {
            InitializeComponent();

            _server = new Server(32123);
            labelServeurIP.Text = _server.GetIP();
        }

        private void buttonSetUpServer_Click(object sender, EventArgs e)
        {
            labelIsConnected.ForeColor = Color.Red;
            labelIsConnected.Text = "Connecting...";

            // TODO : vérifier si le thread est utile ici (j'ai pas compris à quoi ça sert un thread je crois....)
            //_threadListener = new Thread(new ThreadStart(TryToConnect));
            //_threadListener.Name = "test";
            //_threadListener.Start();

            TryToConnect();
        }
        
        private void TryToConnect()
        {
            _server.TryToConnect(this, labelIsConnected, richTextBoxCommunications);
        }

        private void buttonToShutDown_Click(object sender, EventArgs e)
        {
            labelIsConnected.Text = "Disconnected";
            labelIsConnected.ForeColor = Color.Black;
            _threadListener.Abort();
            _server.Close();
        }
    }
}
