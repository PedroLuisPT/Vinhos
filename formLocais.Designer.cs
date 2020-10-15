namespace gestaoVinho
{
    partial class formLocais
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
            this.labelPesquisa = new System.Windows.Forms.Label();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.buttonInformacao = new System.Windows.Forms.Button();
            this.labelLatitude = new System.Windows.Forms.Label();
            this.labelLongitude = new System.Windows.Forms.Label();
            this.labelWhat3Word = new System.Windows.Forms.Label();
            this.textBoxLatitude = new System.Windows.Forms.TextBox();
            this.textBoxWhat3Words = new System.Windows.Forms.TextBox();
            this.textBoxLongitude = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelPesquisa
            // 
            this.labelPesquisa.AutoSize = true;
            this.labelPesquisa.Location = new System.Drawing.Point(63, 62);
            this.labelPesquisa.Name = "labelPesquisa";
            this.labelPesquisa.Size = new System.Drawing.Size(124, 17);
            this.labelPesquisa.TabIndex = 0;
            this.labelPesquisa.Text = "Local  a pesquisar";
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(220, 56);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(252, 22);
            this.textBoxPesquisa.TabIndex = 1;
            // 
            // buttonInformacao
            // 
            this.buttonInformacao.Location = new System.Drawing.Point(220, 153);
            this.buttonInformacao.Name = "buttonInformacao";
            this.buttonInformacao.Size = new System.Drawing.Size(252, 23);
            this.buttonInformacao.TabIndex = 2;
            this.buttonInformacao.Text = "Obter Informação";
            this.buttonInformacao.UseVisualStyleBackColor = true;
            this.buttonInformacao.Click += new System.EventHandler(this.buttonInformacao_Click);
            // 
            // labelLatitude
            // 
            this.labelLatitude.AutoSize = true;
            this.labelLatitude.Location = new System.Drawing.Point(63, 245);
            this.labelLatitude.Name = "labelLatitude";
            this.labelLatitude.Size = new System.Drawing.Size(59, 17);
            this.labelLatitude.TabIndex = 0;
            this.labelLatitude.Text = "Latitude";
            // 
            // labelLongitude
            // 
            this.labelLongitude.AutoSize = true;
            this.labelLongitude.Location = new System.Drawing.Point(373, 245);
            this.labelLongitude.Name = "labelLongitude";
            this.labelLongitude.Size = new System.Drawing.Size(71, 17);
            this.labelLongitude.TabIndex = 0;
            this.labelLongitude.Text = "Longitude";
            // 
            // labelWhat3Word
            // 
            this.labelWhat3Word.AutoSize = true;
            this.labelWhat3Word.Location = new System.Drawing.Point(63, 351);
            this.labelWhat3Word.Name = "labelWhat3Word";
            this.labelWhat3Word.Size = new System.Drawing.Size(83, 17);
            this.labelWhat3Word.TabIndex = 0;
            this.labelWhat3Word.Text = "What3Word";
            // 
            // textBoxLatitude
            // 
            this.textBoxLatitude.Location = new System.Drawing.Point(193, 240);
            this.textBoxLatitude.Name = "textBoxLatitude";
            this.textBoxLatitude.Size = new System.Drawing.Size(125, 22);
            this.textBoxLatitude.TabIndex = 1;
            // 
            // textBoxWhat3Words
            // 
            this.textBoxWhat3Words.Location = new System.Drawing.Point(193, 346);
            this.textBoxWhat3Words.Name = "textBoxWhat3Words";
            this.textBoxWhat3Words.Size = new System.Drawing.Size(252, 22);
            this.textBoxWhat3Words.TabIndex = 1;
            // 
            // textBoxLongitude
            // 
            this.textBoxLongitude.Location = new System.Drawing.Point(503, 240);
            this.textBoxLongitude.Name = "textBoxLongitude";
            this.textBoxLongitude.Size = new System.Drawing.Size(252, 22);
            this.textBoxLongitude.TabIndex = 1;
            // 
            // formLocais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonInformacao);
            this.Controls.Add(this.textBoxLongitude);
            this.Controls.Add(this.textBoxWhat3Words);
            this.Controls.Add(this.textBoxLatitude);
            this.Controls.Add(this.textBoxPesquisa);
            this.Controls.Add(this.labelLongitude);
            this.Controls.Add(this.labelWhat3Word);
            this.Controls.Add(this.labelLatitude);
            this.Controls.Add(this.labelPesquisa);
            this.Name = "formLocais";
            this.Text = "formLocais";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPesquisa;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.Button buttonInformacao;
        private System.Windows.Forms.Label labelLatitude;
        private System.Windows.Forms.Label labelLongitude;
        private System.Windows.Forms.Label labelWhat3Word;
        private System.Windows.Forms.TextBox textBoxLatitude;
        private System.Windows.Forms.TextBox textBoxWhat3Words;
        private System.Windows.Forms.TextBox textBoxLongitude;
    }
}