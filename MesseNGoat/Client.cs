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

            _tCPClient = new TcpClient(_serveurIP, _port);
            _stream = _tCPClient.GetStream();
        }

        public void SendMessage(string a_messageToSend)
        {
            //TODO : voir pour appeler la fonction d'encodage
            _message = a_messageToSend; // TODO : voir si c'est utile de stoquer le message
            _data = Encoding.ASCII.GetBytes(_message);
            _stream.Write(_data, 0, _data.Length);
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

    }
}
