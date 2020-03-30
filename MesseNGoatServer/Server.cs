using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace MesseNGoatServer
{
    public partial class Server : Form
    {
        IPAddress[] _iPServer;
        private string _iPRunning;
        private const int _ipv4index = 5;
        string _message;
        int _port;

        TcpListener _tCPListener;
        Stream _stream;
        private CheckBox checkBox1;
        byte[] _data;

        public Server(int a_port)
        {
            // TODO : gestion des erreurs
            _port = a_port;
            
            _iPServer = Dns.GetHostAddresses(Dns.GetHostName()); // récupère l'adresse ip de la machine sur laquel est lancé le serveur

            if(_iPServer.Length > _ipv4index)
            {
                _iPRunning = _iPServer[_ipv4index].ToString(); // _iPRunning = _iPServer[_ipv4index].ToString();
                _tCPListener = new TcpListener(_iPServer[_ipv4index], _port); // _iPServer[_ipv4index]
            }
            else
            {
                _iPRunning = _iPServer[1].ToString();
                _tCPListener = new TcpListener(_iPServer[1], _port);
                //Console.WriteLine("problème d'ip");
            }

            InitByte();
            InitializeComponent();
        }

        public void InitByte()
        {
            _data = new byte[1500];
            _message = "";
        }

        public string GetIP()
        {
            return _iPRunning;
        }

        private void UpdateForm(Form a_form, Label a_label, string a_messageForLabel, RichTextBox a_textBox, string a_messageForTextBox)
        {
            a_label.ForeColor = Color.Black;

            if (a_messageForLabel.Length != 0)
            {
                if (a_messageForLabel.Equals("Connected"))
                {
                    a_label.ForeColor = Color.Green;
                }
                else if (a_messageForLabel.Equals("Connecting..."))
                {
                    a_label.ForeColor = Color.Red;
                }
                a_label.Text = a_messageForLabel;
            }

            if (a_messageForTextBox.Length != 0)
            {
                a_textBox.Text += a_messageForTextBox + "\n";
            }

            a_form.Update();
        }

        public void TryToConnect(Form1 a_form, Label a_label, RichTextBox a_textBox) // Label a_label, RichTextBox a_textBox
        {
            try
            {
                _tCPListener.Start();

                while (true)
                {
                    Invoke(new Action<Form, Label, string, RichTextBox, string>(UpdateForm), a_form, a_label, "Connecting...", a_textBox, "");
                    
                    TcpClient _tCPClient = _tCPListener.AcceptTcpClient();

                    Invoke(new Action<Form, Label, string, RichTextBox, string>(UpdateForm), a_form, a_label, "Connected", a_textBox, "ptetre voir pour mettre ici l'ip de la personne se connectant");
                    
                    _message = null;

                    _stream = _tCPClient.GetStream();

                    int i = 0;

                    while ((i = _stream.Read(_data, 0, _data.Length)) != 0)
                    {
                        _message = Encoding.ASCII.GetString(_data, 0, i);
                        Invoke(new Action<Form, Label, string, RichTextBox, string>(UpdateForm), a_form, a_label, "", a_textBox, "Received From [idSender] : " + _message);

                        //_message = _message.ToUpper();

                        _message = "message received by server";

                        byte[] msg = Encoding.ASCII.GetBytes(_message);

                        _stream.Write(msg, 0, msg.Length);

                        Invoke(new Action<Form, Label, string, RichTextBox, string>(UpdateForm), a_form, a_label, "", a_textBox, "Resended To [idDestination] : " + _message);

                    }

                    _tCPClient.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception ? : " + e.Message);
            }
            finally
            {
                _tCPListener.Stop();
            }
        }

        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(107, 70);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Server
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.checkBox1);
            this.Name = "Server";
            this.ResumeLayout(true);
            this.PerformLayout();
            Show();
            Hide();
        }
    }
}
