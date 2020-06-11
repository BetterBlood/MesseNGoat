using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Media;


namespace MesseNGoat
{
    public partial class MesseNGoat : Form
    {
        Client _client;
        test2 frm2;

        string _pseudo;
        string _users;

        public MesseNGoat()
        {
            InitializeComponent();
            //var timer = new Timer();
            ////change the background image every second  
            //timer.Interval = 666;
            //timer.Tick += new EventHandler(timer_Tick);
            //timer.Start();
            frm2 = new test2(this);
            _pseudo = "";
            _users = "";
        }

        private void MesseNGoat_Load(object sender, EventArgs e)
        {
            this.Size = new Size(428, 241);
            Connexion.Location = new Point(5, 5);

            UserConnexion.Hide();
            ChatBox.Hide();
            SaveLogin.Hide();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            //add image in list from resource file.  
            List<Bitmap> lisimage = new List<Bitmap>();
            lisimage.Add(Properties.Resources.Chevre_9_DG);
            lisimage.Add(Properties.Resources.chevre_log);
            lisimage.Add(Properties.Resources.Chèvre_de_Savoie_type_barrettes);
            lisimage.Add(Properties.Resources.csm_Appenzellerziege_ProSpecieRara_100_881b7443c9);
            lisimage.Add(Properties.Resources.csm_Walliser_Schwarzhalsziege_ProSpecieRara_100_91e99500ea);
            lisimage.Add(Properties.Resources.csm_Walliser_Schwarzhalsziege_ProSpecieRara_101_306e5857d4);
            lisimage.Add(Properties.Resources.csm_Ziegen_ProSpecieRara_0f7b1f0deb);
            lisimage.Add(Properties.Resources.She_goat_J1);
            lisimage.Add(Properties.Resources.unnamed);
            lisimage.Add(Properties.Resources._110208);
            lisimage.Add(Properties.Resources._1280x800_goat_with_glasses);
            lisimage.Add(Properties.Resources._4212842_jpg_1200x900_q90);

            var indexbackimage = DateTime.Now.Second % lisimage.Count;
            Connexion.BackgroundImage = lisimage[indexbackimage];
            UserConnexion.BackgroundImage = lisimage[indexbackimage];
            SaveLogin.BackgroundImage = lisimage[indexbackimage];
            ChatBox.BackgroundImage = lisimage[indexbackimage];
        }

        private void IPServeur_Click(object sender, EventArgs e)
        {
            IPServeur.Text = "IP Goat Serveur";
            frm2.Show();
            this.Hide();
        }

        private void PlaySound(object a_relativePath)
        {
            new SoundPlayer(a_relativePath.ToString()).Play();
        }

        private void Connexion_Paint(object sender, PaintEventArgs e)
        {
            // TODO : aucune idée de ce que c'est !!!!
        }

        private void connexionToServeurButton_Click(object sender, EventArgs e)
        {
            // TODO : gérer les exceptions, ptetre mettre un message d'erreur etc...
            try
            {
                _client = new Client(textBoxIP.Text, Convert.ToInt32(textBoxPort.Text));
                Connexion.Hide();

                this.Size = new Size(650, 241);
                UserConnexion.Location = new Point(5, 5);
                UserConnexion.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erreur, le serveur (ou le port) mentionné n'est pas atteignable : \n\n[ " + exception.GetType() + " : " + exception.Message + " ]\n\nVeuillez vérifier les données puis réessayer", "Connexion Failed");
            }
            finally
            {
                // TODO : modifier le finally car la il est configuré seulement pour tester le changement de pannel

                new SoundPlayer("..//..//Sounds//IntroSpicyInvaders.wav").Play();
            }
        }

        private void quickConnexionToServeurButton_Click(object sender, EventArgs e)
        {
            try
            {
                _client = new Client(ipServeurDefaultLabel.Text, Convert.ToInt32(portServerDefaultLabel.Text)); // ligne pouvant générer une exception

                Connexion.Hide();
                this.Size = new Size(650, 241);
                UserConnexion.Location = new Point(5, 5);
                UserConnexion.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erreur, le serveur (ou le port) mentionné n'est pas atteignable\n\n[ " + exception.GetType() + " : " + exception.Message + " ]\n\nVeuillez vérifier que le serveur à bien été démaré", "Connexion Failed");
            }
            finally
            {

                // nothing to do je crois
            }
        }

        private void buttonForSending_Click(object sender, EventArgs e)
        {
            richTextBoxConversation.Text += messageAEnvoyer.Text + "\n";
            string accuseRecep;

            try
            {
                string destinataire = destinationTextBox.Text;

                string[] users = _users.Split('\n');

                int destinationIndice = 0;
                int verification = 0;

                foreach(string user in users)
                {
                    destinationIndice++;

                    if (user.Equals(destinataire))
                    {
                        break;
                    }
                    verification++;
                }

                if (destinationIndice == verification)
                {
                    destinationIndice = 0; // on reset à 0 car l'utilisateur n'a pas été trouvé
                }

                _client.SendMessage(messageAEnvoyer.Text, destinationIndice);
                accuseRecep = _client.TestStreamReception() + "\n";
            }
            catch (Exception exception)
            {
                accuseRecep = exception.Message +"\n";
                MessageBox.Show("Connection Lost : \n\nVeuillez vérifier que le serveur n'a pas été déconnecté", "Connexion Lost");
                Size = new Size(428, 241);
                Connexion.Location = new Point(5, 5);

                UserConnexion.Hide();
                ChatBox.Hide();
                SaveLogin.Hide();

                Connexion.Show();
            }

            richTextBoxConversation.Text += accuseRecep;
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // TODO : je crois que c'est pour tester si on peu masquer le mot de passe quand il est tapé pour ne pas l'afficher (c'est géré ailleurs)
        }

        private void userConnexionButton_Click(object sender, EventArgs e)
        {
            // TODO : gérer les exceptions, ptetre mettre un message d'erreur etc...

            // envoyer une requette au serveur pour voir si la personne peut se connecter, si oui on continue sinon message d'erreur
            string accuseRecep = "";

            try
            {
                _client.SendMessage(userPseudoTestBox.Text + "/" + userMdpTextBox.Text + "/connection"); // TODO : ne pas oublié de crypter les infos !!!!
                accuseRecep = _client.TestStreamReception() + "\n";
            }
            catch (Exception exception)
            {
                accuseRecep = exception.Message + "\n";
            }

            string[] accuseRecepSplit = accuseRecep.Split('/');

            if (accuseRecepSplit[0].Equals("goodID"))
            {
                // TODO : trouver un moyen pour transmettre la clé public du Client, et ptetre que le serveur envoie en réponse la liste des utilisateurs (leur clé public, leur id et pseudo)
                _pseudo = userPseudoTestBox.Text;
                affichagePseudo.Text = _pseudo;

                _users = "";
                bool pop = true;

                foreach (string user in accuseRecepSplit)
                {
                    if (!pop)
                    {
                        _users += user + "\n";
                    }
                    pop = false;
                }
                
                destinationPossibility.Text = "" + _users;

                UserConnexion.Hide();
            
                this.Size = new Size(750, 350);
                ChatBox.Location = new Point(5, 5);
                ChatBox.Show();
            }
            else if (accuseRecepSplit[0].Equals("badID"))
            {
                MessageBox.Show("Les identifiants entrés sont invalides", "identifiant invalide");
            }
            else
            {
                MessageBox.Show("Un problème est survenu lors de la requete, merci de le signaler au SAV : " + accuseRecep, "Connexion Issue");
            }
        }

        private void disconnectFromServerButton_Click(object sender, EventArgs e)
        {
            // TODO : gérer les exceptions, ptetre mettre un message d'erreur etc... et surtout réellement déconnecter le stream du serveur

            UserConnexion.Hide();

            this.Size = new Size(428, 241);
            Connexion.Location = new Point(5, 5);
            Connexion.Show();
            
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            // TODO : gérer les exceptions, ptetre mettre un message d'erreur etc... et surtout réellement déconnecter du serveur l'utilisateur

            string accuseRecep = "";

            try
            {
                _client.SendMessage("requestToLogOut"); // TODO : ne pas oublié de crypter les infos !!!!
                _pseudo = "";
                ChatBox.Hide();

                this.Size = new Size(650, 241);
                UserConnexion.Location = new Point(5, 5);
                UserConnexion.Show();
            }
            catch (Exception exception)
            {
                accuseRecep = exception.Message + "\n";
                MessageBox.Show("Erreur inconnue : " + accuseRecep, "Unknown Error");
            }
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            // TODO : gérer les exceptions, ptetre mettre un message d'erreur etc...

            UserConnexion.Hide();

            this.Size = new Size(325, 360);
            SaveLogin.Location = new Point(5, 5);
            SaveLogin.Show();
        }

        private void returnToUserConnexion_Click(object sender, EventArgs e)
        {
            // TODO : gérer les exceptions, ptetre mettre un message d'erreur etc...

            SaveLogin.Hide();

            this.Size = new Size(650, 241);
            UserConnexion.Location = new Point(5, 5);
            UserConnexion.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Thread threadTest = new Thread(new ParameterizedThreadStart(PlaySound));
            threadTest.Name = "testMusique";
            threadTest.Start("..//..//Sounds//EnnemyDeath.wav");
            //Invoke(new Action<string>(PlaySound), "..//..//Sounds//EnnemyDeath.wav");
        }

        private void accountCreationButton_Click(object sender, EventArgs e)
        {
            // envoyer une requette au serveur pour créer un utilisateur
            // si le nom d'utilisateur n'est pas pris => on vérifie que le nom d'utilisateur et le mot de passe ne contiennent pas de "/" => (tous ça dans la partie server)
            // si le serveur nous dit que c'est bon on retourne a la page de connexion, sinon on envoie un message d'erreure comme quoi les informations sont incorrectes

            string accuseRecep = "";

            try
            {
                if (conditionsUtilisation.Checked)
                {
                    if (userNameCreationbox.Text.Length < 5 || userMdpCreationBox.Text.Length < 8)
                    {
                        throw new Exception("nom d'utilisateur ou mot de passe trop court !");
                    }

                    if (!userNameCreationbox.Text.Contains("/") && !userMdpCreationBox.Text.Contains("/"))
                    {
                        _client.SendMessage(userNameCreationbox.Text + "/" + userMdpCreationBox.Text + "/newUser"); // TODO : ne pas oublié de crypter les infos !!!! + de donner la clé public ?
                    }
                    else
                    {
                        MessageBox.Show("Les identifiants entrés ne peuvent pas être validés, le symbole '/' est interdit. Veuillez vous assurer que vous ne l'avez pas utilisé", "nom d'utilisateur ou mdp invalide");
                    }
                }
                
                accuseRecep = _client.TestStreamReception() + "\n";
            }
            catch (Exception exception)
            {
                accuseRecep = exception.Message + "\n";
            }

            string[] accuseRecepSplit = accuseRecep.Split('/');

            if (accuseRecepSplit[0].Equals("goodID")) // récupérer la liste des utilisateurs et si on les envoie depuis le serveur il faut la stringxml(clépublic)
            {
                SaveLogin.Hide();

                this.Size = new Size(650, 241);
                UserConnexion.Location = new Point(5, 5);
                UserConnexion.Show();
            }
            else if (accuseRecepSplit[0].Equals("badID"))
            {
                MessageBox.Show("Les identifiants entrés ne peuvent pas être validés", "utilisateur déjà existant");
            }
            else
            {
                MessageBox.Show("Un problème est survenu lors de la requete, merci de le signaler au SAV : " + accuseRecep, "Connexion Issue");
            }
        }
    }
}
