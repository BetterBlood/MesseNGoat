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

        public MesseNGoat()
        {
            InitializeComponent();
            //var timer = new Timer();
            ////change the background image every second  
            //timer.Interval = 666;
            //timer.Tick += new EventHandler(timer_Tick);
            //timer.Start();
            frm2 = new test2(this);
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
                MessageBox.Show("Erreur, le serveur (ou le port) mentionné n'est pas atteignable\n\n" + exception.Message + "\n\nVeuillez vérifier les données puis réessayer", "Connexion Failed");
            }
            finally
            {
                // TODO : modifier le finally car la il est configuré seulement pour tester le changement de pannel

                //Connexion.Hide();

                //this.Size = new Size(650, 241);
                //UserConnexion.Location = new Point(5, 5);
                //UserConnexion.Show();
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
                MessageBox.Show("Erreur, le serveur (ou le port) mentionné n'est pas atteignable\n\n" + exception.Message + "\n\nVeuillez vérifier que le serveur à bien été démaré", "Connexion Failed");
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
                _client.SendMessage(messageAEnvoyer.Text);
                accuseRecep = _client.TestStreamReception() + "\n";
            }
            catch (Exception exception)
            {
                accuseRecep = exception.Message;
                Size = new Size(428, 241);
                Connexion.Location = new Point(5, 5);

                UserConnexion.Hide();
                ChatBox.Hide();
                SaveLogin.Hide();
            }
            
            labelretourServeur.Text = "reçu";
            richTextBoxConversation.Text += accuseRecep;
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void userConnexionButton_Click(object sender, EventArgs e)
        {
            // TODO : gérer les exceptions, ptetre mettre un message d'erreur etc...

            UserConnexion.Hide();
            
            this.Size = new Size(750, 350);
            ChatBox.Location = new Point(5, 5);
            ChatBox.Show();
        }

        private void disconnectFromServerButton_Click(object sender, EventArgs e)
        {
            // TODO : gérer les exceptions, ptetre mettre un message d'erreur etc...

            UserConnexion.Hide();

            this.Size = new Size(428, 241);
            Connexion.Location = new Point(5, 5);
            Connexion.Show();
            
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            // TODO : gérer les exceptions, ptetre mettre un message d'erreur etc...

            ChatBox.Hide();

            this.Size = new Size(650, 241);
            UserConnexion.Location = new Point(5, 5);
            UserConnexion.Show();
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
    }
}
