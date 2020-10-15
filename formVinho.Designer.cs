namespace gestaoVinho
{
    partial class formVinho
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
            this.labelRegiao = new System.Windows.Forms.Label();
            this.labelProdutor = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelTeorAlcoolico = new System.Windows.Forms.Label();
            this.labelAno = new System.Windows.Forms.Label();
            this.labelCor = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.dataGridVinho = new System.Windows.Forms.DataGridView();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.comboBoxRegiao = new System.Windows.Forms.ComboBox();
            this.comboBoxProdutor = new System.Windows.Forms.ComboBox();
            this.erros = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxCor = new System.Windows.Forms.TextBox();
            this.textBoxTeorAlcoolico = new System.Windows.Forms.TextBox();
            this.textBoxVolume = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageEnologos = new System.Windows.Forms.TabPage();
            this.dataGridRestantesEnologos = new System.Windows.Forms.DataGridView();
            this.dataGridVinhoEnologo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDissociar = new System.Windows.Forms.Button();
            this.buttonAssociar = new System.Windows.Forms.Button();
            this.tabPageCastas = new System.Windows.Forms.TabPage();
            this.textBoxPercentagem = new System.Windows.Forms.TextBox();
            this.labelPercentagem = new System.Windows.Forms.Label();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.dataGridRestantesCastas = new System.Windows.Forms.DataGridView();
            this.dataGridVinhoCasta = new System.Windows.Forms.DataGridView();
            this.maskedTextBoxAno = new System.Windows.Forms.MaskedTextBox();
            this.labelCastasSeleccionadas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erros)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageEnologos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRestantesEnologos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVinhoEnologo)).BeginInit();
            this.tabPageCastas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRestantesCastas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVinhoCasta)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(134, 40);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(45, 17);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // labelRegiao
            // 
            this.labelRegiao.AutoSize = true;
            this.labelRegiao.Location = new System.Drawing.Point(126, 210);
            this.labelRegiao.Name = "labelRegiao";
            this.labelRegiao.Size = new System.Drawing.Size(53, 17);
            this.labelRegiao.TabIndex = 0;
            this.labelRegiao.Text = "Região";
            // 
            // labelProdutor
            // 
            this.labelProdutor.AutoSize = true;
            this.labelProdutor.Location = new System.Drawing.Point(116, 242);
            this.labelProdutor.Name = "labelProdutor";
            this.labelProdutor.Size = new System.Drawing.Size(63, 17);
            this.labelProdutor.TabIndex = 0;
            this.labelProdutor.Text = "Produtor";
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(301, 102);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(32, 17);
            this.labelVolume.TabIndex = 0;
            this.labelVolume.Text = "Vol.";
            // 
            // labelTeorAlcoolico
            // 
            this.labelTeorAlcoolico.AutoSize = true;
            this.labelTeorAlcoolico.Location = new System.Drawing.Point(81, 102);
            this.labelTeorAlcoolico.Name = "labelTeorAlcoolico";
            this.labelTeorAlcoolico.Size = new System.Drawing.Size(98, 17);
            this.labelTeorAlcoolico.TabIndex = 0;
            this.labelTeorAlcoolico.Text = "Teor Alcoólico";
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.Location = new System.Drawing.Point(315, 72);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(33, 17);
            this.labelAno.TabIndex = 0;
            this.labelAno.Text = "Ano";
            // 
            // labelCor
            // 
            this.labelCor.AutoSize = true;
            this.labelCor.Location = new System.Drawing.Point(149, 74);
            this.labelCor.Name = "labelCor";
            this.labelCor.Size = new System.Drawing.Size(30, 17);
            this.labelCor.TabIndex = 0;
            this.labelCor.Text = "Cor";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(206, 35);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(215, 22);
            this.textBoxNome.TabIndex = 0;
            this.textBoxNome.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNome_Validating);
            this.textBoxNome.Validated += new System.EventHandler(this.textBoxNome_Validated);
            // 
            // dataGridVinho
            // 
            this.dataGridVinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVinho.Location = new System.Drawing.Point(795, 35);
            this.dataGridVinho.Name = "dataGridVinho";
            this.dataGridVinho.RowHeadersWidth = 51;
            this.dataGridVinho.RowTemplate.Height = 24;
            this.dataGridVinho.Size = new System.Drawing.Size(300, 380);
            this.dataGridVinho.TabIndex = 16;
            this.dataGridVinho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVinho_CellClick);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(206, 297);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(215, 32);
            this.buttonAdicionar.TabIndex = 7;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(206, 340);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(215, 32);
            this.buttonAlterar.TabIndex = 8;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(206, 383);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(215, 32);
            this.buttonApagar.TabIndex = 9;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // comboBoxRegiao
            // 
            this.comboBoxRegiao.FormattingEnabled = true;
            this.comboBoxRegiao.Location = new System.Drawing.Point(206, 204);
            this.comboBoxRegiao.Name = "comboBoxRegiao";
            this.comboBoxRegiao.Size = new System.Drawing.Size(215, 24);
            this.comboBoxRegiao.TabIndex = 5;
            // 
            // comboBoxProdutor
            // 
            this.comboBoxProdutor.FormattingEnabled = true;
            this.comboBoxProdutor.Location = new System.Drawing.Point(206, 236);
            this.comboBoxProdutor.Name = "comboBoxProdutor";
            this.comboBoxProdutor.Size = new System.Drawing.Size(215, 24);
            this.comboBoxProdutor.TabIndex = 6;
            // 
            // erros
            // 
            this.erros.ContainerControl = this;
            // 
            // textBoxCor
            // 
            this.textBoxCor.Location = new System.Drawing.Point(206, 69);
            this.textBoxCor.Name = "textBoxCor";
            this.textBoxCor.Size = new System.Drawing.Size(82, 22);
            this.textBoxCor.TabIndex = 1;
            this.textBoxCor.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCor_Validating);
            this.textBoxCor.Validated += new System.EventHandler(this.textBoxCor_Validated);
            // 
            // textBoxTeorAlcoolico
            // 
            this.textBoxTeorAlcoolico.Location = new System.Drawing.Point(206, 97);
            this.textBoxTeorAlcoolico.Name = "textBoxTeorAlcoolico";
            this.textBoxTeorAlcoolico.Size = new System.Drawing.Size(82, 22);
            this.textBoxTeorAlcoolico.TabIndex = 3;
            this.textBoxTeorAlcoolico.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTeorAlcoolico_Validating);
            this.textBoxTeorAlcoolico.Validated += new System.EventHandler(this.textBoxTeorAlcoolico_Validated);
            // 
            // textBoxVolume
            // 
            this.textBoxVolume.Location = new System.Drawing.Point(339, 97);
            this.textBoxVolume.Name = "textBoxVolume";
            this.textBoxVolume.Size = new System.Drawing.Size(82, 22);
            this.textBoxVolume.TabIndex = 4;
            this.textBoxVolume.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxVolume_Validating);
            this.textBoxVolume.Validated += new System.EventHandler(this.textBoxVolume_Validated);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageEnologos);
            this.tabControl.Controls.Add(this.tabPageCastas);
            this.tabControl.Location = new System.Drawing.Point(464, 35);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(309, 380);
            this.tabControl.TabIndex = 7;
            // 
            // tabPageEnologos
            // 
            this.tabPageEnologos.Controls.Add(this.dataGridRestantesEnologos);
            this.tabPageEnologos.Controls.Add(this.dataGridVinhoEnologo);
            this.tabPageEnologos.Controls.Add(this.label2);
            this.tabPageEnologos.Controls.Add(this.label1);
            this.tabPageEnologos.Controls.Add(this.buttonDissociar);
            this.tabPageEnologos.Controls.Add(this.buttonAssociar);
            this.tabPageEnologos.Location = new System.Drawing.Point(4, 25);
            this.tabPageEnologos.Name = "tabPageEnologos";
            this.tabPageEnologos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEnologos.Size = new System.Drawing.Size(301, 351);
            this.tabPageEnologos.TabIndex = 0;
            this.tabPageEnologos.Text = "Enologos";
            this.tabPageEnologos.UseVisualStyleBackColor = true;
            // 
            // dataGridRestantesEnologos
            // 
            this.dataGridRestantesEnologos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRestantesEnologos.Location = new System.Drawing.Point(28, 176);
            this.dataGridRestantesEnologos.Name = "dataGridRestantesEnologos";
            this.dataGridRestantesEnologos.RowHeadersWidth = 51;
            this.dataGridRestantesEnologos.RowTemplate.Height = 24;
            this.dataGridRestantesEnologos.Size = new System.Drawing.Size(240, 105);
            this.dataGridRestantesEnologos.TabIndex = 8;
            // 
            // dataGridVinhoEnologo
            // 
            this.dataGridVinhoEnologo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVinhoEnologo.Location = new System.Drawing.Point(28, 47);
            this.dataGridVinhoEnologo.Name = "dataGridVinhoEnologo";
            this.dataGridVinhoEnologo.RowHeadersWidth = 51;
            this.dataGridVinhoEnologo.RowTemplate.Height = 24;
            this.dataGridVinhoEnologo.Size = new System.Drawing.Size(240, 94);
            this.dataGridVinhoEnologo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Restantes Enologos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enologos que participaram";
            // 
            // buttonDissociar
            // 
            this.buttonDissociar.Location = new System.Drawing.Point(193, 302);
            this.buttonDissociar.Name = "buttonDissociar";
            this.buttonDissociar.Size = new System.Drawing.Size(75, 23);
            this.buttonDissociar.TabIndex = 10;
            this.buttonDissociar.Text = "Dissociar";
            this.buttonDissociar.UseVisualStyleBackColor = true;
            this.buttonDissociar.Click += new System.EventHandler(this.buttonDissociar_Click);
            // 
            // buttonAssociar
            // 
            this.buttonAssociar.Location = new System.Drawing.Point(36, 302);
            this.buttonAssociar.Name = "buttonAssociar";
            this.buttonAssociar.Size = new System.Drawing.Size(75, 23);
            this.buttonAssociar.TabIndex = 9;
            this.buttonAssociar.Text = "Associar";
            this.buttonAssociar.UseVisualStyleBackColor = true;
            this.buttonAssociar.Click += new System.EventHandler(this.buttonAssociar_Click);
            // 
            // tabPageCastas
            // 
            this.tabPageCastas.Controls.Add(this.labelCastasSeleccionadas);
            this.tabPageCastas.Controls.Add(this.textBoxPercentagem);
            this.tabPageCastas.Controls.Add(this.labelPercentagem);
            this.tabPageCastas.Controls.Add(this.buttonRemover);
            this.tabPageCastas.Controls.Add(this.buttonInserir);
            this.tabPageCastas.Controls.Add(this.dataGridRestantesCastas);
            this.tabPageCastas.Controls.Add(this.dataGridVinhoCasta);
            this.tabPageCastas.Location = new System.Drawing.Point(4, 25);
            this.tabPageCastas.Name = "tabPageCastas";
            this.tabPageCastas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCastas.Size = new System.Drawing.Size(301, 351);
            this.tabPageCastas.TabIndex = 1;
            this.tabPageCastas.Text = "Castas";
            this.tabPageCastas.UseVisualStyleBackColor = true;
            // 
            // textBoxPercentagem
            // 
            this.textBoxPercentagem.Location = new System.Drawing.Point(140, 317);
            this.textBoxPercentagem.Name = "textBoxPercentagem";
            this.textBoxPercentagem.Size = new System.Drawing.Size(100, 22);
            this.textBoxPercentagem.TabIndex = 15;
            // 
            // labelPercentagem
            // 
            this.labelPercentagem.AutoSize = true;
            this.labelPercentagem.Location = new System.Drawing.Point(21, 323);
            this.labelPercentagem.Name = "labelPercentagem";
            this.labelPercentagem.Size = new System.Drawing.Size(92, 17);
            this.labelPercentagem.TabIndex = 2;
            this.labelPercentagem.Text = "Percentagem";
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(186, 280);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(75, 23);
            this.buttonRemover.TabIndex = 14;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(21, 280);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(75, 23);
            this.buttonInserir.TabIndex = 13;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // dataGridRestantesCastas
            // 
            this.dataGridRestantesCastas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRestantesCastas.Location = new System.Drawing.Point(21, 150);
            this.dataGridRestantesCastas.Name = "dataGridRestantesCastas";
            this.dataGridRestantesCastas.RowHeadersWidth = 51;
            this.dataGridRestantesCastas.RowTemplate.Height = 24;
            this.dataGridRestantesCastas.Size = new System.Drawing.Size(240, 105);
            this.dataGridRestantesCastas.TabIndex = 12;
            // 
            // dataGridVinhoCasta
            // 
            this.dataGridVinhoCasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVinhoCasta.Location = new System.Drawing.Point(21, 31);
            this.dataGridVinhoCasta.Name = "dataGridVinhoCasta";
            this.dataGridVinhoCasta.RowHeadersWidth = 51;
            this.dataGridVinhoCasta.RowTemplate.Height = 24;
            this.dataGridVinhoCasta.Size = new System.Drawing.Size(240, 105);
            this.dataGridVinhoCasta.TabIndex = 11;
            // 
            // maskedTextBoxAno
            // 
            this.maskedTextBoxAno.Location = new System.Drawing.Point(355, 72);
            this.maskedTextBoxAno.Mask = "0000";
            this.maskedTextBoxAno.Name = "maskedTextBoxAno";
            this.maskedTextBoxAno.Size = new System.Drawing.Size(66, 22);
            this.maskedTextBoxAno.TabIndex = 2;
            this.maskedTextBoxAno.ValidatingType = typeof(int);
            // 
            // labelCastasSeleccionadas
            // 
            this.labelCastasSeleccionadas.AutoSize = true;
            this.labelCastasSeleccionadas.Location = new System.Drawing.Point(21, 11);
            this.labelCastasSeleccionadas.Name = "labelCastasSeleccionadas";
            this.labelCastasSeleccionadas.Size = new System.Drawing.Size(147, 17);
            this.labelCastasSeleccionadas.TabIndex = 16;
            this.labelCastasSeleccionadas.Text = "Castas Seleccionadas";
            // 
            // formVinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1119, 450);
            this.Controls.Add(this.maskedTextBoxAno);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.comboBoxProdutor);
            this.Controls.Add(this.comboBoxRegiao);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.dataGridVinho);
            this.Controls.Add(this.textBoxVolume);
            this.Controls.Add(this.textBoxTeorAlcoolico);
            this.Controls.Add(this.textBoxCor);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelCor);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.labelAno);
            this.Controls.Add(this.labelProdutor);
            this.Controls.Add(this.labelTeorAlcoolico);
            this.Controls.Add(this.labelRegiao);
            this.Controls.Add(this.labelNome);
            this.Name = "formVinho";
            this.Text = "formVinho";
            this.Load += new System.EventHandler(this.formVinho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVinho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erros)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageEnologos.ResumeLayout(false);
            this.tabPageEnologos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRestantesEnologos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVinhoEnologo)).EndInit();
            this.tabPageCastas.ResumeLayout(false);
            this.tabPageCastas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRestantesCastas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVinhoCasta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelRegiao;
        private System.Windows.Forms.Label labelProdutor;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label labelTeorAlcoolico;
        private System.Windows.Forms.Label labelAno;
        private System.Windows.Forms.Label labelCor;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.DataGridView dataGridVinho;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.ComboBox comboBoxRegiao;
        private System.Windows.Forms.ComboBox comboBoxProdutor;
        private System.Windows.Forms.ErrorProvider erros;
        private System.Windows.Forms.TextBox textBoxCor;
        private System.Windows.Forms.TextBox textBoxVolume;
        private System.Windows.Forms.TextBox textBoxTeorAlcoolico;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageEnologos;
        private System.Windows.Forms.DataGridView dataGridRestantesEnologos;
        private System.Windows.Forms.DataGridView dataGridVinhoEnologo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDissociar;
        private System.Windows.Forms.Button buttonAssociar;
        private System.Windows.Forms.TabPage tabPageCastas;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.DataGridView dataGridRestantesCastas;
        private System.Windows.Forms.DataGridView dataGridVinhoCasta;
        private System.Windows.Forms.TextBox textBoxPercentagem;
        private System.Windows.Forms.Label labelPercentagem;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAno;
        private System.Windows.Forms.Label labelCastasSeleccionadas;
    }
}