namespace KouakouChristAxel
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.nbrImg = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timepasse = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotationAGaucheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotationADroiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mirroirHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fenetreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mosaïqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnO = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnRoG = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnRoD = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.nbrImg,
            this.toolStripStatusLabel2,
            this.timepasse});
            this.statusStrip1.Location = new System.Drawing.Point(0, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(570, 25);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            this.statusStrip1.Resize += new System.EventHandler(this.statusStrip1_Resize);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(129, 20);
            this.toolStripStatusLabel1.Text = "Nombre d\'image :";
            // 
            // nbrImg
            // 
            this.nbrImg.Name = "nbrImg";
            this.nbrImg.Size = new System.Drawing.Size(17, 20);
            this.nbrImg.Text = "0";
            this.nbrImg.Click += new System.EventHandler(this.nbrImg_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 20);
            // 
            // timepasse
            // 
            this.timepasse.Name = "timepasse";
            this.timepasse.Size = new System.Drawing.Size(236, 20);
            this.timepasse.Text = "Application ouverte depuis : 0 min";
            this.timepasse.Click += new System.EventHandler(this.toolStripStatusLabel4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.fenetreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(570, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem,
            this.fermerToolStripMenuItem,
            this.toolStripMenuItem1,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.fichierToolStripMenuItem.Text = "Fichier";
            this.fichierToolStripMenuItem.Click += new System.EventHandler(this.fichierToolStripMenuItem_Click);
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.ouvrirToolStripMenuItem.Text = "&Ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.fermerToolStripMenuItem.Text = "Fermer";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(174, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotationAGaucheToolStripMenuItem,
            this.rotationADroiteToolStripMenuItem,
            this.mirroirHorizontalToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // rotationAGaucheToolStripMenuItem
            // 
            this.rotationAGaucheToolStripMenuItem.Name = "rotationAGaucheToolStripMenuItem";
            this.rotationAGaucheToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.rotationAGaucheToolStripMenuItem.Text = "Rotation a gauche";
            this.rotationAGaucheToolStripMenuItem.Click += new System.EventHandler(this.rotationAGaucheToolStripMenuItem_Click);
            // 
            // rotationADroiteToolStripMenuItem
            // 
            this.rotationADroiteToolStripMenuItem.Name = "rotationADroiteToolStripMenuItem";
            this.rotationADroiteToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.rotationADroiteToolStripMenuItem.Text = "Rotation a droite";
            this.rotationADroiteToolStripMenuItem.Click += new System.EventHandler(this.rotationADroiteToolStripMenuItem_Click);
            // 
            // mirroirHorizontalToolStripMenuItem
            // 
            this.mirroirHorizontalToolStripMenuItem.Name = "mirroirHorizontalToolStripMenuItem";
            this.mirroirHorizontalToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.mirroirHorizontalToolStripMenuItem.Text = "Mirroir Horizontal";
            // 
            // fenetreToolStripMenuItem
            // 
            this.fenetreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposDeToolStripMenuItem,
            this.mosaïqueToolStripMenuItem,
            this.cascadeToolStripMenuItem});
            this.fenetreToolStripMenuItem.Name = "fenetreToolStripMenuItem";
            this.fenetreToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.fenetreToolStripMenuItem.Text = "Fenetre";
            // 
            // aProposDeToolStripMenuItem
            // 
            this.aProposDeToolStripMenuItem.Name = "aProposDeToolStripMenuItem";
            this.aProposDeToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.aProposDeToolStripMenuItem.Text = "A propos de...";
            this.aProposDeToolStripMenuItem.Click += new System.EventHandler(this.aProposDeToolStripMenuItem_Click);
            // 
            // mosaïqueToolStripMenuItem
            // 
            this.mosaïqueToolStripMenuItem.Name = "mosaïqueToolStripMenuItem";
            this.mosaïqueToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.mosaïqueToolStripMenuItem.Text = "Mosaïque";
            this.mosaïqueToolStripMenuItem.Click += new System.EventHandler(this.mosaïqueToolStripMenuItem_Click);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnO,
            this.toolStripBtnRoG,
            this.toolStripBtnRoD});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(570, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnO
            // 
            this.toolStripBtnO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnO.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnO.Image")));
            this.toolStripBtnO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnO.Name = "toolStripBtnO";
            this.toolStripBtnO.Size = new System.Drawing.Size(23, 24);
            this.toolStripBtnO.Text = "1";
            this.toolStripBtnO.Click += new System.EventHandler(this.toolStripBtnO_Click);
            // 
            // toolStripBtnRoG
            // 
            this.toolStripBtnRoG.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnRoG.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnRoG.Image")));
            this.toolStripBtnRoG.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnRoG.Name = "toolStripBtnRoG";
            this.toolStripBtnRoG.Size = new System.Drawing.Size(23, 24);
            this.toolStripBtnRoG.Text = "2";
            this.toolStripBtnRoG.Click += new System.EventHandler(this.toolStripBtnRoG_Click);
            // 
            // toolStripBtnRoD
            // 
            this.toolStripBtnRoD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnRoD.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnRoD.Image")));
            this.toolStripBtnRoD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnRoD.Name = "toolStripBtnRoD";
            this.toolStripBtnRoD.Size = new System.Drawing.Size(23, 24);
            this.toolStripBtnRoD.Text = "3";
            this.toolStripBtnRoD.Click += new System.EventHandler(this.toolStripBtnRoD_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(570, 569);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Afficheur photo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fenetreToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel timepasse;
        private System.Windows.Forms.ToolStripMenuItem rotationAGaucheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotationADroiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mirroirHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mosaïqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripBtnO;
        private System.Windows.Forms.ToolStripButton toolStripBtnRoG;
        private System.Windows.Forms.ToolStripButton toolStripBtnRoD;
        public System.Windows.Forms.ToolStripStatusLabel nbrImg;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

