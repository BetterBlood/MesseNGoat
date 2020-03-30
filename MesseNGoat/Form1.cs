﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            LoginResult.BackgroundImage = lisimage[indexbackimage];
            SaveLogin.BackgroundImage = lisimage[indexbackimage];
            ChatBox.BackgroundImage = lisimage[indexbackimage];
        }

        private void IPServeur_Click(object sender, EventArgs e)
        {
            IPServeur.Text = "IP Goat Serveur";
            frm2.Show();
            this.Hide();
        }

        private void Connexion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            _client = new Client(textBoxIP.Text, Convert.ToInt32(textBoxPort.Text));
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
            }
            
            labelretourServeur.Text = "reçu";
            richTextBoxConversation.Text += accuseRecep;
            
        }
    }
}
