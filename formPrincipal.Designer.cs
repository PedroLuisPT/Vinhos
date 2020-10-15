namespace gestaoVinho
{
    partial class formPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.formuláriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enólogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.castaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regiãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vinhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonProdutor = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRegiao = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCasta = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEnologo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonVinho = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formuláriosToolStripMenuItem
            // 
            this.formuláriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtorToolStripMenuItem,
            this.enólogoToolStripMenuItem,
            this.castaToolStripMenuItem,
            this.regiãoToolStripMenuItem,
            this.vinhoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.formuláriosToolStripMenuItem.Name = "formuláriosToolStripMenuItem";
            this.formuláriosToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.formuláriosToolStripMenuItem.Text = "Formulários";
            // 
            // produtorToolStripMenuItem
            // 
            this.produtorToolStripMenuItem.Name = "produtorToolStripMenuItem";
            this.produtorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.produtorToolStripMenuItem.Text = "Produtor";
            this.produtorToolStripMenuItem.Click += new System.EventHandler(this.produtorToolStripMenuItem_Click);
            // 
            // enólogoToolStripMenuItem
            // 
            this.enólogoToolStripMenuItem.Name = "enólogoToolStripMenuItem";
            this.enólogoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.enólogoToolStripMenuItem.Text = "Enólogo";
            this.enólogoToolStripMenuItem.Click += new System.EventHandler(this.enólogoToolStripMenuItem_Click);
            // 
            // castaToolStripMenuItem
            // 
            this.castaToolStripMenuItem.Name = "castaToolStripMenuItem";
            this.castaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.castaToolStripMenuItem.Text = "Casta";
            this.castaToolStripMenuItem.Click += new System.EventHandler(this.castaToolStripMenuItem_Click);
            // 
            // regiãoToolStripMenuItem
            // 
            this.regiãoToolStripMenuItem.Name = "regiãoToolStripMenuItem";
            this.regiãoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.regiãoToolStripMenuItem.Text = "Região";
            this.regiãoToolStripMenuItem.Click += new System.EventHandler(this.regiãoToolStripMenuItem_Click);
            // 
            // vinhoToolStripMenuItem
            // 
            this.vinhoToolStripMenuItem.Name = "vinhoToolStripMenuItem";
            this.vinhoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.vinhoToolStripMenuItem.Text = "Vinho";
            this.vinhoToolStripMenuItem.Click += new System.EventHandler(this.vinhoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formuláriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonProdutor,
            this.toolStripButtonRegiao,
            this.toolStripButtonCasta,
            this.toolStripButtonEnologo,
            this.toolStripButtonVinho});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonProdutor
            // 
            this.toolStripButtonProdutor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonProdutor.Image = global::gestaoVinho.Properties.Resources.winery;
            this.toolStripButtonProdutor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonProdutor.Name = "toolStripButtonProdutor";
            this.toolStripButtonProdutor.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonProdutor.Text = "Produtor";
            this.toolStripButtonProdutor.Click += new System.EventHandler(this.produtorToolStripMenuItem_Click);
            // 
            // toolStripButtonRegiao
            // 
            this.toolStripButtonRegiao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRegiao.Image = global::gestaoVinho.Properties.Resources.map;
            this.toolStripButtonRegiao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRegiao.Name = "toolStripButtonRegiao";
            this.toolStripButtonRegiao.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonRegiao.Text = "Região";
            this.toolStripButtonRegiao.Click += new System.EventHandler(this.regiãoToolStripMenuItem_Click);
            // 
            // toolStripButtonCasta
            // 
            this.toolStripButtonCasta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCasta.Image = global::gestaoVinho.Properties.Resources.grape;
            this.toolStripButtonCasta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCasta.Name = "toolStripButtonCasta";
            this.toolStripButtonCasta.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonCasta.Text = "Casta";
            this.toolStripButtonCasta.Click += new System.EventHandler(this.castaToolStripMenuItem_Click);
            // 
            // toolStripButtonEnologo
            // 
            this.toolStripButtonEnologo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEnologo.Image = global::gestaoVinho.Properties.Resources.farmer;
            this.toolStripButtonEnologo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEnologo.Name = "toolStripButtonEnologo";
            this.toolStripButtonEnologo.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonEnologo.Text = "Enologo";
            this.toolStripButtonEnologo.Click += new System.EventHandler(this.enólogoToolStripMenuItem_Click);
            // 
            // toolStripButtonVinho
            // 
            this.toolStripButtonVinho.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonVinho.Image = global::gestaoVinho.Properties.Resources.wine;
            this.toolStripButtonVinho.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonVinho.Name = "toolStripButtonVinho";
            this.toolStripButtonVinho.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonVinho.Text = "Vinho";
            this.toolStripButtonVinho.Click += new System.EventHandler(this.vinhoToolStripMenuItem_Click);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formPrincipal";
            this.Text = "Formulário Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem formuláriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enólogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem castaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regiãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vinhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonProdutor;
        private System.Windows.Forms.ToolStripButton toolStripButtonRegiao;
        private System.Windows.Forms.ToolStripButton toolStripButtonCasta;
        private System.Windows.Forms.ToolStripButton toolStripButtonEnologo;
        private System.Windows.Forms.ToolStripButton toolStripButtonVinho;
    }
}

