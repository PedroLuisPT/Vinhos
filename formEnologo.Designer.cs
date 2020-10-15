namespace gestaoVinho
{
    partial class formEnologo
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
            this.labelInstagram = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxInstagram = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTwitter = new System.Windows.Forms.TextBox();
            this.dataGridEnologo = new System.Windows.Forms.DataGridView();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.erros = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEnologo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erros)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(142, 88);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(45, 17);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // labelInstagram
            // 
            this.labelInstagram.AutoSize = true;
            this.labelInstagram.Location = new System.Drawing.Point(117, 134);
            this.labelInstagram.Name = "labelInstagram";
            this.labelInstagram.Size = new System.Drawing.Size(70, 17);
            this.labelInstagram.TabIndex = 0;
            this.labelInstagram.Text = "Instagram";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(206, 84);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(215, 22);
            this.textBoxNome.TabIndex = 0;
            this.textBoxNome.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNome_Validating);
            this.textBoxNome.Validated += new System.EventHandler(this.textBoxNome_Validated);
            // 
            // textBoxInstagram
            // 
            this.textBoxInstagram.Location = new System.Drawing.Point(206, 131);
            this.textBoxInstagram.Name = "textBoxInstagram";
            this.textBoxInstagram.Size = new System.Drawing.Size(215, 22);
            this.textBoxInstagram.TabIndex = 1;
            this.textBoxInstagram.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxInstagram_Validating);
            this.textBoxInstagram.Validated += new System.EventHandler(this.textBoxInstagram_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Twitter";
            // 
            // textBoxTwitter
            // 
            this.textBoxTwitter.Location = new System.Drawing.Point(206, 175);
            this.textBoxTwitter.Name = "textBoxTwitter";
            this.textBoxTwitter.Size = new System.Drawing.Size(215, 22);
            this.textBoxTwitter.TabIndex = 2;
            this.textBoxTwitter.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTwitter_Validating);
            this.textBoxTwitter.Validated += new System.EventHandler(this.textBoxTwitter_Validated);
            // 
            // dataGridEnologo
            // 
            this.dataGridEnologo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEnologo.Location = new System.Drawing.Point(460, 35);
            this.dataGridEnologo.Name = "dataGridEnologo";
            this.dataGridEnologo.RowHeadersWidth = 51;
            this.dataGridEnologo.RowTemplate.Height = 24;
            this.dataGridEnologo.Size = new System.Drawing.Size(300, 380);
            this.dataGridEnologo.TabIndex = 2;
            this.dataGridEnologo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEnologo_CellClick);
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
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // erros
            // 
            this.erros.ContainerControl = this;
            // 
            // formEnologo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.dataGridEnologo);
            this.Controls.Add(this.textBoxTwitter);
            this.Controls.Add(this.textBoxInstagram);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelInstagram);
            this.Controls.Add(this.labelNome);
            this.Name = "formEnologo";
            this.Text = "formEnologo";
            this.Load += new System.EventHandler(this.formEnologo_Load);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNome_Validating);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEnologo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelInstagram;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxInstagram;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTwitter;
        private System.Windows.Forms.DataGridView dataGridEnologo;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.ErrorProvider erros;
    }
}