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
    public partial class apropos : Form
    {
        public apropos()
        {
            InitializeComponent();
        }

        private void splashlogo_Click(object sender, EventArgs e)
        {

        }
        public Timer temps = null;

        private void apropos_Shown(object sender, EventArgs e)
        {
            if (Application.OpenForms["Form1"] == null)
            {
                //Création du timer control
                temps = new Timer();
                //interval de temps de 5 secondes au lieu de 10
                //(puisque une seconde fait 100 millisecondes)
                temps.Interval = 5000;
                //
                temps.Start();
                temps.Tick += temps_Tick;
            }
            else
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            }
        }


        private void temps_Tick(object sender, EventArgs e) 
        {
            //lancement du formulaire principale après le temps donné
            temps.Stop();
            Form1 principale = new Form1();
            principale.Show();
            this.Hide();//on cache Form3 après avoir ouvert form1
        }

        private void apropos_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
