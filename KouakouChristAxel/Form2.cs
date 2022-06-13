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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = (Form1)MdiParent;
            f1.cpte--;//A chaque fois que form2 est fermé cpte diminue de 1
            f1.nbrImg.Text =string.Format("{0}", f1.cpte);
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
