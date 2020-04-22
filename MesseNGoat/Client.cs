using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace MesseNGoat
{
    class Client
    {
        IPAddress[] _iPAppli;
        private string _iPRunning;

        string _serveurIP;
        string _message;
        int _port;

        TcpClient _tCPClient;
        Stream _stream;
        byte[] _data;

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
        }

        public void SendMessage(string a_messageToSend)
        {
            //TODO : voir pour appeler la fonction d'encodage
            string destination = _serveurIP;
            _message = _iPRunning + "/" + destination + "/" + a_messageToSend; // TODO : voir si c'est utile de stoquer le message
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
            return Encoding.ASCII.GetString(_data, 0, size);
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
    }
}
