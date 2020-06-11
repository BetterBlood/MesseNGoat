using System;
using System.Collections.Generic;
using System.IO;
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
            Crypto cryTest2 = new Crypto(cryTest.GetRSAXML()); // création d'un nouvel objet RSA grace a un stringXML du premier objet (envoyable par message)
            
            Console.WriteLine(cryTest.Hash("qwertzqwertz")); // test de hashage
            File.WriteAllText(Path.GetFullPath("hashed.txt"), cryTest.Hash("qwertzqwertz"));
            File.WriteAllText(Path.GetFullPath("publickey.txt"), cryTest.GetRSAXML());
            //Console.WriteLine(cryTest.GetRSAXML()); // affichage du xmlString obtenu

            //byte[] test = cryTest2.EncryptByte("coucou", cryTest2.GetPublicKey()); // encryption avec la clé public de la copie du RSA machin

            //Console.WriteLine(cryTest.Decrypt(test)); // décriptage avec l'objet RSA originel (le seul a connaitre la clé privé)

            Console.ReadLine();
        }
    }
}
