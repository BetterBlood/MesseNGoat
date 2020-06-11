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

            // TODO : tester FindIPV4() avant de le donner en index !!! (si jamais aucune adresse n'est trouvée la méthode renvoie -1)
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
                //string tmp = ip.ToString();

                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    find = true;
                    break;
                }

                //if (tmp.Split('.').Length == 4)
                //{
                //    find = true;
                //    break;
                //}
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

                    string messageOrigin = "";
                    string message = "";
                    string destination = "";
                    bool identificationOk = false;

                    string users = File.ReadAllText(Form1.PATH_USERS); // récupération du fichier utilisateurs
                    string[] usersSplit = users.Split('/');

                    while ((i = _stream.Read(_data, 0, _data.Length)) != 0)
                    {
                        _message = Encoding.ASCII.GetString(_data, 0, i);

                        string[] messageSplit = _message.Split('/');

                        messageOrigin = messageSplit[0];
                        destination = messageSplit[1]; // mettre en place un système d'adresse intern permettant de savoir à qui est adressé le message
                        string ipDestination = "";
                        message = messageSplit[2]; // TODO : prendre le reste du tableau mais je sais plus comment faire

                        if (Convert.ToInt32(destination) == 0)
                        {
                            ipDestination = _iPRunning;
                        }
                        else if (usersSplit[Convert.ToInt32(destination) - 1].Split('=')[3].Equals("online"))
                        {
                            ipDestination = usersSplit[Convert.ToInt32(destination) - 1].Split('=')[4];
                        }

                        if (!identificationOk) // si l'identité de l'envoyeur n'as pas encore été vérifié
                        {
                            if (ipDestination.Equals(_iPRunning)) // si le server est le destinataire du message
                            {
                                string reason = messageSplit[4]; // vérifier si c'est le bon indice

                                Console.WriteLine("debug ?");

                                if (reason.Equals("newUser"))
                                {
                                    string pseudo = messageSplit[2];
                                    string mdp = messageSplit[3];
                                    // on vérifie que le pseudo n'est pas déjà dans la liste d'utilisateur
                                    // s'il n'y est pas on l'y inscrit avec son mot de passe
                                    // sinon on envoie un message d'erreur
                                    
                                    bool newUser = true;
                                    string listUsers = ""; 

                                    foreach (string user in usersSplit)
                                    {
                                        string[] infoUser = user.Split('=');

                                        listUsers += "/" + infoUser[0];

                                        if (infoUser[0].Equals(pseudo))
                                        {
                                            newUser = false;
                                            break;
                                        }
                                    }

                                    if (newUser)
                                    {
                                        _message = "goodID" + listUsers;
                                        File.WriteAllText(Form1.PATH_USERS, users + "/" + pseudo + "=" + mdp); // TODO ne pas oublier le cryptage des infos !
                                        Invoke(new Action<Form, Label, string, RichTextBox, string>(UpdateForm), a_form, a_label, "Connecting...", a_textBox, messageOrigin + " new User register as : " + pseudo);
                                    }
                                    else
                                    {
                                        _message = "badID/";
                                    }
                                }
                                else if (reason.Equals("connection"))
                                {
                                    // on vérifie que le pseudo est dans la liste d'utilisateur
                                    // on vérifie que le mdp correspond (ptetre avec une méthode => plus modilable si on change de syseme d'encryption)
                                    // si c'est bon on connect !

                                    string pseudo = messageSplit[2];
                                    string mdp = messageSplit[3];

                                    bool canConnect = false;
                                    string listUsers = "";
                                    int j = 0;

                                    foreach (string user in usersSplit)
                                    {
                                        string[] infoUser = user.Split('=');

                                        listUsers += "/" + infoUser[0];

                                        if (infoUser[0].Equals(pseudo))
                                        {
                                            if (infoUser[1].Equals(mdp))
                                            {
                                                canConnect = true;
                                                infoUser[3] = "online";
                                                infoUser[4] = messageOrigin;
                                                usersSplit[j] = infoUser[0] + "=" + infoUser[1] + "=" + infoUser[2] + "=" + infoUser[3] + "=" + infoUser[4];
                                            }
                                        }
                                        j++; // normal qu'il n'y est pas de break, c'est pour construire la liste d'utilisateur (listUsers)
                                    }

                                    if (canConnect)
                                    {
                                        users = "";

                                        foreach(string user in usersSplit)
                                        {
                                            users += user + "/";
                                        }
                                        users.Remove(users.Length - 1);

                                        File.WriteAllText(Form1.PATH_USERS, users);

                                        identificationOk = true;
                                        _message = "goodID" + listUsers;
                                        Invoke(new Action<Form, Label, string, RichTextBox, string>(UpdateForm), a_form, a_label, "Connected", a_textBox, messageOrigin + " register as : " + pseudo);
                                    }
                                    else
                                    {
                                        _message = "badID/";
                                        Invoke(new Action<Form, Label, string, RichTextBox, string>(UpdateForm), a_form, a_label, "Connected", a_textBox, messageOrigin + " trying to register as : " + pseudo);
                                    }
                                }
                            }

                            byte[] msg = Encoding.ASCII.GetBytes(_message);

                            _stream.Write(msg, 0, msg.Length);

                            Invoke(new Action<Form, Label, string, RichTextBox, string>(UpdateForm), a_form, a_label, "Connected", a_textBox, "Resended To [" + messageOrigin + "] : " + _message);
                        }
                        else if (ipDestination.Equals(_iPRunning)) // TODO : l'endroit où est géré la déconnection d'une personne (le false pour l'instant c'est que le serveur et la seul ip possible il faudra l'enlever après)
                        {
                            if (message.Equals("requestToLogOut"))
                            {
                                identificationOk = false;

                                users = "";

                                foreach(string user in usersSplit)
                                {
                                    if (user.Split('=')[4].Equals(messageOrigin))
                                    {
                                        user.Split('=')[3] = "offline";
                                    }
                                    users += user + "/";
                                }
                                users.Remove(users.Length - 1);

                                Invoke(new Action<Form, Label, string, RichTextBox, string>(UpdateForm), a_form, a_label, "Connected", a_textBox, messageOrigin + " logged Out !");
                            }
                            else
                            {
                                Invoke(new Action<Form, Label, string, RichTextBox, string>(UpdateForm), a_form, a_label, "Connected", a_textBox, "Received From [" + messageOrigin + "] : " + message);

                                //_message = _message.ToUpper();

                                _message = "message received by server";

                                byte[] msg = Encoding.ASCII.GetBytes(_message);

                                _stream.Write(msg, 0, msg.Length);

                                Invoke(new Action<Form, Label, string, RichTextBox, string>(UpdateForm), a_form, a_label, "Connected", a_textBox, "Resended To [" + messageOrigin + "] : " + _message);
                            }
                        }
                        else
                        {
                            // TODO : trouver la personne a qui envoyer le message reçu !!!!!
                            Invoke(new Action<Form, Label, string, RichTextBox, string>(UpdateForm), a_form, a_label, "Connected", a_textBox, "Received From [" + messageOrigin + "] : " + message);

                            //_message = _message.ToUpper();

                            _message = "message received by server";

                            byte[] msg = Encoding.ASCII.GetBytes(_message);

                            _stream.Write(msg, 0, msg.Length);

                            Invoke(new Action<Form, Label, string, RichTextBox, string>(UpdateForm), a_form, a_label, "Connected", a_textBox, "Resended To [" + messageOrigin + "] : " + _message);
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
