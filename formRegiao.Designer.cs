namespace gestaoVinho
{
    partial class formRegiao
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
            this.labelCaracteristicas = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxCaracterisitcas = new System.Windows.Forms.TextBox();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.dataGridRegiao = new System.Windows.Forms.DataGridView();
            this.erros = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegiao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erros)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(140, 62);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(45, 17);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // labelCaracteristicas
            // 
            this.labelCaracteristicas.AutoSize = true;
            this.labelCaracteristicas.Location = new System.Drawing.Point(84, 110);
            this.labelCaracteristicas.Name = "labelCaracteristicas";
            this.labelCaracteristicas.Size = new System.Drawing.Size(101, 17);
            this.labelCaracteristicas.TabIndex = 0;
            this.labelCaracteristicas.Text = "Características";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(210, 56);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(211, 22);
            this.textBoxNome.TabIndex = 0;
            this.textBoxNome.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNome_Validating);
            this.textBoxNome.Validated += new System.EventHandler(this.textBoxNome_Validated);
            // 
            // textBoxCaracterisitcas
            // 
            this.textBoxCaracterisitcas.Location = new System.Drawing.Point(210, 105);
            this.textBoxCaracterisitcas.Name = "textBoxCaracterisitcas";
            this.textBoxCaracterisitcas.Size = new System.Drawing.Size(211, 22);
            this.textBoxCaracterisitcas.TabIndex = 1;
            this.textBoxCaracterisitcas.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCaracterisitcas_Validating);
            this.textBoxCaracterisitcas.Validated += new System.EventHandler(this.textBoxCaracterisitcas_Validated);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(206, 297);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(215, 32);
            this.buttonAdicionar.TabIndex = 2;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(206, 340);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(215, 32);
            this.buttonAlterar.TabIndex = 2;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(206, 383);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(215, 32);
            this.buttonApagar.TabIndex = 2;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // dataGridRegiao
            // 
            this.dataGridRegiao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRegiao.Location = new System.Drawing.Point(460, 35);
            this.dataGridRegiao.Name = "dataGridRegiao";
            this.dataGridRegiao.RowHeadersWidth = 51;
            this.dataGridRegiao.RowTemplate.Height = 24;
            this.dataGridRegiao.Size = new System.Drawing.Size(300, 380);
            this.dataGridRegiao.TabIndex = 3;
            this.dataGridRegiao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRegiao_CellClick);
            // 
            // erros
            // 
            this.erros.ContainerControl = this;
            // 
            // formRegiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridRegiao);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.textBoxCaracterisitcas);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelCaracteristicas);
            this.Controls.Add(this.labelNome);
            this.Name = "formRegiao";
            this.Text = "formRegiao";
            this.Load += new System.EventHandler(this.formRegiao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegiao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelCaracteristicas;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxCaracterisitcas;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.DataGridView dataGridRegiao;
        private System.Windows.Forms.ErrorProvider erros;
    }
}