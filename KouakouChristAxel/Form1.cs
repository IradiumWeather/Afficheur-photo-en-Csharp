using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KouakouChristAxel
{
    public partial class Form1 : Form
    {
        
        public Form2 f2 = null;
        public apropos FormAprs = null;

        public int cpte = 0; //variable pour compter le nombre d'image ouverte
        int temps = 0; //La variable du temps passé dans l'application

        public Form1()
        {
            InitializeComponent();
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Selection de l'image

            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image|*.jpg;*.png;|Tous|*.*";
            op.Title = "Selectionner";
            op.ShowDialog();
            //Création d'une nouvelle instance de form 2
            if (op.FileName != "")
            {
                f2 = new Form2();
                f2.MdiParent = this;
                f2.Show();
                f2.pictureBox1.ImageLocation = op.FileName;
                f2.Text = op.FileName;
                cpte++; //lorsqu'une image est ouverte cpte s'incrémente de 1
            }
            nbrImg.Text = string.Format("{0}", cpte); //le texte de nbrImg se trouvant dans le statustip reçoit cpte donc le nombre d'image
            //Dans form2 lorsque la form est fermé cpte diminue de 1
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 activeChild = this.ActiveMdiChild as Form2;
            activeChild.Close();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nbrImg_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ++temps;
            timepasse.Text = String.Format("Application ouverte depuis {0} min", temps);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            statusStrip1_Resize(sender, e);
        }

        private void rotationAGaucheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                //Recupérer la form2 active
                 Form2 activeChild = this.ActiveMdiChild as Form2;
                
                activeChild.pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                activeChild.pictureBox1.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Aucune image ouverte ou sélectionner");
            }
        }

        private void rotationADroiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Si aucune form2 n'est active ou ouverte lors de l'appuie sur le bouton l'application bug donc je mets un try pour prévenir ce cas
            try
            {
                //Recupérer la form2 active
                Form2 activeChild = this.ActiveMdiChild as Form2; //cette ligne nous permet de récupérer la form2 qui a le focus pour faire le traitement sur elle,
                //sans cette ligne le traitement ne s'applique qu'au dernier form2 qui a été ouvert.
                activeChild.pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                activeChild.pictureBox1.Refresh(); //Sans cette ligne le traitement(rotation) effectué ne s'afficherait pas
            }
            catch (Exception)
            {
                MessageBox.Show("Aucune image ouverte ou sélectionner");
            }
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mettre les fenetres enfant du MDI en cascade
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void mosaïqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mettre les fenetres enfant du MDI en mosaique
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Lorsqu'on ferme form1 toute l'application se ferme
            Application.Exit();
        }

        private void toolStripBtnO_Click(object sender, EventArgs e)
        {
            ouvrirToolStripMenuItem_Click(sender, e);
        }

        private void toolStripBtnRoG_Click(object sender, EventArgs e)
        {
            rotationAGaucheToolStripMenuItem_Click(sender, e);
        }

        private void toolStripBtnRoD_Click(object sender, EventArgs e)
        {
            rotationADroiteToolStripMenuItem_Click(sender,e);
        }

        private void aProposDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //affichage de a propos via le bouton a propos du menustrip
            //Le if nous permet de ne pas créé plusieurs form apropos
            if (FormAprs == null)
            {
                FormAprs = new apropos();
                FormAprs.MdiParent = this;
                FormAprs.Show();
            }
            else
            {
                FormAprs.Activate();
            }
            FormAprs.FormClosed += FormAprs_Closed;
        }

        public void FormAprs_Closed(object sender, FormClosedEventArgs e)
        {
            //Pour éviter que apropos puisse être réouverte on remet ca valeur a null lors de la fermeture
            FormAprs = null;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {

        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {

        }

        private void statusStrip1_Resize(object sender, EventArgs e)
        {
            //Calcul de l'espace entre la bordure droite et le controle du temps passé
            int padd = this.Size.Width - (toolStripStatusLabel1.Size.Width + nbrImg.Size.Width + timepasse.Size.Width + 30);
            toolStripStatusLabel2.Size = new Size(padd, 20); //On affecte l'espace - 30px pour que le temps passé dans l'application reste toujours tout au bout
        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
