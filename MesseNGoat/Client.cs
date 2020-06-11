using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using MesseNGoatCrypto;

namespace MesseNGoat
{
    public class Client
    {
        IPAddress[] _iPAppli;
        private string _iPRunning;

        string _serveurIP;
        string _message;
        int _port;

        TcpClient _tCPClient;
        Stream _stream;
        byte[] _data;

        Crypto _crypto;
        List<int> _iDs;
        List<string> _contactPublicKeys;
        

        public Client(string a_serveurIP, int a_port)
        {
            _serveurIP = a_serveurIP;
            _port = a_port;

            //_tCPClient = new TcpClient("192.168.56.1", 32123);
            _tCPClient = new TcpClient(_serveurIP, _port);
            //Console.Beep();
            _stream = _tCPClient.GetStream();
            //Console.Beep();
            
            _iPAppli = Dns.GetHostAddresses(Dns.GetHostName()); // récupère les adresses ip de la machine sur laquel est lancé l'application client
            _iPRunning = _iPAppli[FindIPV4()].ToString();

            _crypto = new Crypto();
            _contactPublicKeys = new List<string>();
            _iDs = new List<int>();
        }

        public void SendMessage(string a_messageToSend, int a_contactID = 0, bool a_wannaEncrypte = false)
        {
            // si contactId = 0 alors c'est une demande au serveur //

            //TODO : voir pour appeler la fonction d'encodage _crypto.Encrypt(a_messageToSend, FindKeyContact(contactID))
            //string destination = _serveurIP; // TODO : trouver une manière d'obtenir la personne que l'on veut contacter

            string a_messageToSendEncrypted = a_messageToSend;

            if (a_wannaEncrypte)
            {
                _crypto = new Crypto(_contactPublicKeys[a_contactID]);
                a_messageToSendEncrypted = _crypto.Encrypt(a_messageToSend, _crypto.GetPublicKey());
            }

            _message = _iPRunning + "/" + a_contactID + "/" + a_messageToSendEncrypted; // TODO : voir si c'est utile de stoquer le message

            _data = Encoding.ASCII.GetBytes(_message);
            _stream.Write(_data, 0, _data.Length);
        }

        /// <summary>
        /// renvoie la première adresse ipv4 trouvée, si pas d'IPV4, renvoie -1
        /// </summary>
        /// <returns></returns>
        private int FindIPV4()
        {
            int index = 0;
            bool find = false;

            foreach (IPAddress ip in _iPAppli)
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

        public string TestStreamReception()
        {
            _data = new byte[1500];

            int size = _stream.Read(_data, 0, _data.Length);
            return _crypto.Decrypt(_data);
            //return Encoding.ASCII.GetString(_data, 0, size);
        }

        public byte[] TestStreamReceptionByte()
        {
            _data = new byte[1500];

            int size = _stream.Read(_data, 0, _data.Length);
            return _data;
        }

        public void Close()
        {
            _stream.Close();
            _tCPClient.Close();
        }

        public string GetIP()
        {
            return _iPRunning;
        }

        public string GetServerIP()
        {
            return _serveurIP;
        }

        public string GetRSAXML()
        {
            return _crypto.GetRSAXML();
        }

        public void SetPublicKeys(string a_PublicKeysList)
        {
            string[] tmpKeys = a_PublicKeysList.Split('%');

            _contactPublicKeys = new List<string>(); // réinitialisation de la liste

            foreach (string key in tmpKeys)
            {
                _contactPublicKeys.Add(key);
            }

        }


    }
}
