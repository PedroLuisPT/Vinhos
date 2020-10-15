namespace gestaoVinho
{
    partial class formPaises
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
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.dataGridountries = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridountries)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.Items.AddRange(new object[] {
            "África",
            "América",
            "Ásia",
            "Europa",
            "Oceania"});
            this.comboBoxRegion.Location = new System.Drawing.Point(108, 48);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(121, 24);
            this.comboBoxRegion.TabIndex = 0;
            this.comboBoxRegion.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegion_SelectedIndexChanged);
            // 
            // dataGridountries
            // 
            this.dataGridountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridountries.Location = new System.Drawing.Point(431, 48);
            this.dataGridountries.Name = "dataGridountries";
            this.dataGridountries.RowHeadersWidth = 51;
            this.dataGridountries.RowTemplate.Height = 24;
            this.dataGridountries.Size = new System.Drawing.Size(287, 332);
            this.dataGridountries.TabIndex = 1;
            // 
            // formPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridountries);
            this.Controls.Add(this.comboBoxRegion);
            this.Name = "formPaises";
            this.Text = "formPaises";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridountries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRegion;
        private System.Windows.Forms.DataGridView dataGridountries;
    }
}