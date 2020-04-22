using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace MesseNGoatServer
{
    public partial class Server : Form
    {
        IPAddress[] _iPServer;
        private string _iPRunning;
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
            
            _iPServer = Dns.GetHostAddresses(Dns.GetHostName()); // récupère les adresses ip de la machine sur laquel est lancé le serveur

            _iPRunning = _iPServer[FindIPV4()].ToString();
            _tCPListener = new TcpListener(_iPServer[FindIPV4()], _port);

            //CreateHandle();
            InitByte();
            InitializeComponent();
        }

        public void InitByte()
        {
            _data = new byte[1500];
            _message = "";
        }

        private int FindIPV4()
        {
            int index = 0;
            bool find = false;

            foreach (IPAddress ip in _iPServer)
            {
                string tmp = ip.ToString();

                if (tmp.Split('.').Length == 4)
                {
                    find = true;
                    break;
                }
                index++;
            }
            return find ? index : -1;
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
            //a_label.ForeColor = Color.Black;
        }

        public void TryToConnect(Form1 a_form, Label a_label, RichTextBox a_textBox) // Label a_label, RichTextBox a_textBox
        {
            try
            {
                CreateHandle();
                _tCPListener.Start();

                while (true)
                {
                    while (!this.IsHandleCreated) // added 
                    {
                        System.Threading.Thread.Sleep(1000); //added 
                        Console.Beep();
                    }

                    Invoke(new Action<Form, Label, string, RichTextBox, string>(UpdateForm), a_form, a_label, "Connecting...", a_textBox, "");
                    
                    TcpClient tCPClient = _tCPListener.AcceptTcpClient();

                    Invoke(new Action<Form, Label, string, RichTextBox, string>(UpdateForm), a_form, a_label, "Connected", a_textBox, "un nouvel utilisateur c'est connecté");
                    
                    _message = null;

                    _stream = tCPClient.GetStream();

                    int i = 0;

                    string id = "";
                    string message = "";
                    string destination = "";
                    bool identificationOk = false;

                    while ((i = _stream.Read(_data, 0, _data.Length)) != 0)
                    {
                        _message = Encoding.ASCII.GetString(_data, 0, i);

                        string[] messageSplit = _message.Split('/');

                        id = messageSplit[0];
                        destination = messageSplit[1]; // mettre en place un système d'adresse intern permettant de savoir à qui est adressé le message
                        message = messageSplit[2]; // TODO : prendre le reste du tableau mais je sais plus comment faire

                        if (!identificationOk) // si l'identité de l'envoyeur n'as pas encore été vérifié
                        {
                            if (destination.Equals(_iPRunning)) // si le server est le destinataire du message
                            {
                                if (true && true) // TOTO : ici on vérifie que le pseudo correspond bien a qqn et que le mdp est correct :(mdp = messageSplit[3])
                                {
                                    identificationOk = true;
                                    _message = "goodID";
                                    Invoke(new Action<Form, Label, string, RichTextBox, string>(UpdateForm), a_form, a_label, "Connected", a_textBox, id + " register as : " + message);

                                }
                                else // TODO : faire le cas ou la vérification à échoué
                                {
                                    _message = "badID";
                                    Invoke(new Action<Form, Label, string, RichTextBox, string>(UpdateForm), a_form, a_label, "Connected", a_textBox, id + " trying to register as : " + message);
                                }
                            }

                            byte[] msg = Encoding.ASCII.GetBytes(_message);

                            _stream.Write(msg, 0, msg.Length);

                            Invoke(new Action<Form, Label, string, RichTextBox, string>(UpdateForm), a_form, a_label, "Connected", a_textBox, "Resended To [" + id + "] : " + _message);
                        }
                        else if (destination.Equals(_iPRunning)) // TODO : l'endroit où est géré la déconnection d'une personne (le false pour l'instant c'est que le serveur et la seul ip possible il faudra l'enlever après)
                        {
                            if (message.Equals("requestToLogOut"))
                            {
                                identificationOk = false;
                                Invoke(new Action<Form, Label, string, RichTextBox, string>(UpdateForm), a_form, a_label, "Connected", a_textBox, id + " logged Out !");
                            }
                            else
                            {
                                Invoke(new Action<Form, Label, string, RichTextBox, string>(UpdateForm), a_form, a_label, "Connected", a_textBox, "Received From [" + id + "] : " + message);

                                //_message = _message.ToUpper();

                                _message = "message received by server";

                                byte[] msg = Encoding.ASCII.GetBytes(_message);

                                _stream.Write(msg, 0, msg.Length);

                                Invoke(new Action<Form, Label, string, RichTextBox, string>(UpdateForm), a_form, a_label, "Connected", a_textBox, "Resended To [" + id + "] : " + _message);
                            }
                        }
                        else
                        {
                            Invoke(new Action<Form, Label, string, RichTextBox, string>(UpdateForm), a_form, a_label, "Connected", a_textBox, "Received From [" + id + "] : " + message);

                            //_message = _message.ToUpper();

                            _message = "message received by server";

                            byte[] msg = Encoding.ASCII.GetBytes(_message);

                            _stream.Write(msg, 0, msg.Length);

                            Invoke(new Action<Form, Label, string, RichTextBox, string>(UpdateForm), a_form, a_label, "Connected", a_textBox, "Resended To [" + id + "] : " + _message);
                        }
                    }

                    tCPClient.Close();
                }
            }
            catch (System.Threading.ThreadAbortException exep)
            {
                Console.WriteLine("Exception dans Server.cs : " + exep.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception dans Server.cs : " + e.Message);
            }
            finally
            {
                
            }
        }

        public void TryToDisconnect()
        {
            _tCPListener.Stop();
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
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Server
            // 
            this.ClientSize = new System.Drawing.Size(723, 458);
            this.Controls.Add(this.checkBox1);
            this.Name = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // TODO : enlever ça ça sert à rien je pense mais je sais pas comment l'enlever
        }
    }
}
