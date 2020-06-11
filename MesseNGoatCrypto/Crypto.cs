using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace MesseNGoatCrypto
{
    public class Crypto
    {
        private UnicodeEncoding _unicodeEncoding;
        private RSACryptoServiceProvider _rSACrypto;
        private RSAParameters _publicKey;
        private RSAParameters _privateKey;

        public Crypto()
        {
            _unicodeEncoding = new UnicodeEncoding();
            _rSACrypto = new RSACryptoServiceProvider();
            _publicKey = _rSACrypto.ExportParameters(false);
            _privateKey = _rSACrypto.ExportParameters(true);
        }

        public Crypto(string a_xmlString)
        {
            _unicodeEncoding = new UnicodeEncoding();
            _rSACrypto = new RSACryptoServiceProvider();
            _rSACrypto.FromXmlString(a_xmlString);
            _publicKey = _rSACrypto.ExportParameters(false);
        }

        public string Encrypt(string a_message, RSAParameters a_publicKey)
        {
            _rSACrypto.ImportParameters(a_publicKey); // rend possible l'encryptage avec la clé public fournie
            byte[] messageEncrypted = _rSACrypto.Encrypt(_unicodeEncoding.GetBytes(a_message), false);
            return _unicodeEncoding.GetString(messageEncrypted);
        }

        public byte[] EncryptByte(string a_message, RSAParameters a_publicKey)
        {
            _rSACrypto.ImportParameters(a_publicKey); // rend possible l'encryptage avec la clé public fournie
            byte[] messageEncrypted = _rSACrypto.Encrypt(_unicodeEncoding.GetBytes(a_message), false);
            return messageEncrypted;
        }

        public string Decrypt(byte[] a_byteMessage)
        {
            _rSACrypto.ImportParameters(_privateKey);
            
            byte[] messageDecrypted = _rSACrypto.Decrypt(a_byteMessage, false); // je sais pas pk ça marche pas...

            return _unicodeEncoding.GetString(messageDecrypted);
        }

        public string Hash(string a_passWord)
        {
            SHA256 sHA256 = SHA256.Create();
            
            byte[] bytesPassWord = _unicodeEncoding.GetBytes(a_passWord);
            byte[] bytesPassWordHashed = sHA256.ComputeHash(bytesPassWord); 
            string hashedPassWord = BitConverter.ToString(bytesPassWordHashed).Replace("-",""); // le replace permet d'enlever les tirrets innutils

            return hashedPassWord;
        }

        public RSAParameters GetPublicKey() // créé pour les tests ma9s on peut ptetre la garder
        {
            return _publicKey;
        }

        public string GetRSA()
        {
            return _rSACrypto.ToXmlString(false);
        }
    }
}
