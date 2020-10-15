namespace gestaoVinho
{
    partial class formEmail
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
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelFormato = new System.Windows.Forms.Label();
            this.labelTemporario = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxFormato = new System.Windows.Forms.TextBox();
            this.textBoxTemporario = new System.Windows.Forms.TextBox();
            this.buttonValidar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(84, 59);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 17);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email";
            // 
            // labelFormato
            // 
            this.labelFormato.AutoSize = true;
            this.labelFormato.Location = new System.Drawing.Point(84, 231);
            this.labelFormato.Name = "labelFormato";
            this.labelFormato.Size = new System.Drawing.Size(60, 17);
            this.labelFormato.TabIndex = 0;
            this.labelFormato.Text = "Formato";
            // 
            // labelTemporario
            // 
            this.labelTemporario.AutoSize = true;
            this.labelTemporario.Location = new System.Drawing.Point(84, 331);
            this.labelTemporario.Name = "labelTemporario";
            this.labelTemporario.Size = new System.Drawing.Size(81, 17);
            this.labelTemporario.TabIndex = 0;
            this.labelTemporario.Text = "Temporário";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(176, 53);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(485, 22);
            this.textBoxEmail.TabIndex = 1;
            // 
            // textBoxFormato
            // 
            this.textBoxFormato.Location = new System.Drawing.Point(176, 226);
            this.textBoxFormato.Name = "textBoxFormato";
            this.textBoxFormato.Size = new System.Drawing.Size(485, 22);
            this.textBoxFormato.TabIndex = 1;
            // 
            // textBoxTemporario
            // 
            this.textBoxTemporario.Location = new System.Drawing.Point(176, 326);
            this.textBoxTemporario.Name = "textBoxTemporario";
            this.textBoxTemporario.Size = new System.Drawing.Size(485, 22);
            this.textBoxTemporario.TabIndex = 1;
            // 
            // buttonValidar
            // 
            this.buttonValidar.Location = new System.Drawing.Point(176, 135);
            this.buttonValidar.Name = "buttonValidar";
            this.buttonValidar.Size = new System.Drawing.Size(75, 23);
            this.buttonValidar.TabIndex = 2;
            this.buttonValidar.Text = "Validar";
            this.buttonValidar.UseVisualStyleBackColor = true;
            this.buttonValidar.Click += new System.EventHandler(this.buttonValidar_Click);
            // 
            // formEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonValidar);
            this.Controls.Add(this.textBoxTemporario);
            this.Controls.Add(this.textBoxFormato);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelTemporario);
            this.Controls.Add(this.labelFormato);
            this.Controls.Add(this.labelEmail);
            this.Name = "formEmail";
            this.Text = "c_rest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelFormato;
        private System.Windows.Forms.Label labelTemporario;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxFormato;
        private System.Windows.Forms.TextBox textBoxTemporario;
        private System.Windows.Forms.Button buttonValidar;
    }
}