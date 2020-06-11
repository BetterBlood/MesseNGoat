using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesseNGoatCrypto
{
    class Program
    {
        static void Main(string[] args)
        {
            Crypto cryTest = new Crypto();
            Crypto cryTest2 = new Crypto(cryTest.GetRSA()); // création d'un nouvel objet RSA grace a un stringXML du premier objet (envoyable par message)
            
            Console.WriteLine(cryTest.Hash("salut")); // test de hashage
            
            Console.WriteLine(cryTest.GetRSA()); // affichage du xmlString obtenu

            byte[] test = cryTest2.EncryptByte("coucou", cryTest2.GetPublicKey()); // encryption avec la clé public de la copie du RSA machin

            Console.WriteLine(cryTest.Decrypt(test)); // décriptage avec l'objet RSA originel (le seul a connaitre la clé privé)

            Console.ReadLine();
        }
    }
}
