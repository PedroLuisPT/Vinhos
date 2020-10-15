namespace gestaoVinho
{
    partial class formCasta
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
            this.components = new System.ComponentModel.Container();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelCaracteristica = new System.Windows.Forms.Label();
            this.dataGridCasta = new System.Windows.Forms.DataGridView();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxCaracteristicas = new System.Windows.Forms.TextBox();
            this.erros = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBoxCasta = new System.Windows.Forms.PictureBox();
            this.buttonFoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCasta)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(132, 40);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(45, 17);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // labelCaracteristica
            // 
            this.labelCaracteristica.AutoSize = true;
            this.labelCaracteristica.Location = new System.Drawing.Point(76, 84);
            this.labelCaracteristica.Name = "labelCaracteristica";
            this.labelCaracteristica.Size = new System.Drawing.Size(101, 17);
            this.labelCaracteristica.TabIndex = 0;
            this.labelCaracteristica.Text = "Características";
            // 
            // dataGridCasta
            // 
            this.dataGridCasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCasta.Location = new System.Drawing.Point(460, 35);
            this.dataGridCasta.Name = "dataGridCasta";
            this.dataGridCasta.RowHeadersWidth = 51;
            this.dataGridCasta.RowTemplate.Height = 24;
            this.dataGridCasta.Size = new System.Drawing.Size(300, 139);
            this.dataGridCasta.TabIndex = 2;
            this.dataGridCasta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCasta_CellClick);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(206, 297);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(215, 32);
            this.buttonAdicionar.TabIndex = 3;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(206, 340);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(215, 32);
            this.buttonAlterar.TabIndex = 3;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(206, 383);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(215, 32);
            this.buttonApagar.TabIndex = 3;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(206, 37);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(215, 22);
            this.textBoxNome.TabIndex = 0;
            this.textBoxNome.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNome_Validating);
            this.textBoxNome.Validated += new System.EventHandler(this.textBoxNome_Validated);
            // 
            // textBoxCaracteristicas
            // 
            this.textBoxCaracteristicas.Location = new System.Drawing.Point(206, 82);
            this.textBoxCaracteristicas.Multiline = true;
            this.textBoxCaracteristicas.Name = "textBoxCaracteristicas";
            this.textBoxCaracteristicas.Size = new System.Drawing.Size(215, 92);
            this.textBoxCaracteristicas.TabIndex = 1;
            this.textBoxCaracteristicas.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCaracteristicas_Validating);
            this.textBoxCaracteristicas.Validated += new System.EventHandler(this.textBoxCaracteristicas_Validated);
            // 
            // erros
            // 
            this.erros.ContainerControl = this;
            // 
            // pictureBoxCasta
            // 
            this.pictureBoxCasta.Location = new System.Drawing.Point(460, 197);
            this.pictureBoxCasta.Name = "pictureBoxCasta";
            this.pictureBoxCasta.Size = new System.Drawing.Size(300, 218);
            this.pictureBoxCasta.TabIndex = 4;
            this.pictureBoxCasta.TabStop = false;
            // 
            // buttonFoto
            // 
            this.buttonFoto.Location = new System.Drawing.Point(345, 197);
            this.buttonFoto.Name = "buttonFoto";
            this.buttonFoto.Size = new System.Drawing.Size(75, 32);
            this.buttonFoto.TabIndex = 5;
            this.buttonFoto.Text = "Foto...";
            this.buttonFoto.UseVisualStyleBackColor = true;
            this.buttonFoto.Click += new System.EventHandler(this.buttonFoto_Click);
            // 
            // formCasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFoto);
            this.Controls.Add(this.pictureBoxCasta);
            this.Controls.Add(this.textBoxCaracteristicas);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.dataGridCasta);
            this.Controls.Add(this.labelCaracteristica);
            this.Controls.Add(this.labelNome);
            this.Name = "formCasta";
            this.Text = "formCasta";
            this.Load += new System.EventHandler(this.formCasta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCasta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelCaracteristica;
        private System.Windows.Forms.DataGridView dataGridCasta;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxCaracteristicas;
        private System.Windows.Forms.ErrorProvider erros;
        private System.Windows.Forms.Button buttonFoto;
        private System.Windows.Forms.PictureBox pictureBoxCasta;
    }
}