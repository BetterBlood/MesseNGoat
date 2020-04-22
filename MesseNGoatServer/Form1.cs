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
        Thread _threadListener;

        public Form1()
        {
            InitializeComponent();
            labelServerPort.Text = "32123"; // TODO : ptetre mettre ça en textBox pour entrer le port soit-même

            _server = new Server(Convert.ToInt32(labelServerPort.Text));
            labelServerIP.Text = _server.GetIP();
        }

        private void buttonSetUpServer_Click(object sender, EventArgs e)
        {
            // TODO : vérifier si le thread est utile ici (j'ai pas compris à quoi ça sert un thread je crois....)
            _threadListener = new Thread(new ThreadStart(TryToConnect));
            _threadListener.Name = "test";
            _threadListener.Start();

            //TryToConnect();
        }
        
        private void TryToConnect()
        {
            _server.TryToConnect(this, labelIsConnected, richTextBoxCommunications);
        }

        private void buttonToShutDown_Click(object sender, EventArgs e)
        {
            labelIsConnected.Text = "Disconnected";
            labelIsConnected.ForeColor = Color.Black;
            _server.TryToDisconnect();

            if (_threadListener != null)
            {
                _threadListener.Abort();
            }

            Application.Exit();
        }
    }
}
