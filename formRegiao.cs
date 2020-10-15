using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestaoVinho
{
    public partial class formRegiao : Form
    {
        public formRegiao()
        {
            InitializeComponent();
        }

        void PreencherGridRegiao()
        {
            modeloVinhos bd = new modeloVinhos();
            var q = from a in bd.Regiaos
                    orderby a.Nome ascending
                    select new
                    {
                        ID = a.IdRegiao,
                        Nome = a.Nome,
                        Caracteristicas = a.Caracteristicas
                    };
            dataGridRegiao.DataSource = q.ToList();
            dataGridRegiao.Columns[0].Visible = false;
            dataGridRegiao.Columns[1].Width = 150;
            dataGridRegiao.Columns[2].Width = 150;
        }

        private void formRegiao_Load(object sender, EventArgs e)
        {
            PreencherGridRegiao();
        }

        void LimparControlos()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    item.Text = "";
                if (item is CheckBox)
                {
                    CheckBox chk = (CheckBox)item;
                    chk.Checked = false;
                }
            }
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            modeloVinhos bd = new modeloVinhos();
            Regiao a = new Regiao();
            a.Nome = textBoxNome.Text;
            a.Caracteristicas = textBoxCaracterisitcas.Text;
            bd.Regiaos.Add(a);
            bd.SaveChanges();
            PreencherGridRegiao();
            LimparControlos();

        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            modeloVinhos bd = new modeloVinhos();
            int id = (int)dataGridRegiao.CurrentRow.Cells[0].Value;
            Regiao a = bd.Regiaos.Find(id);
            try
            {
                bd.Regiaos.Remove(a);
                bd.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Não pode eliminar o registo seleccionado.");
            }
            PreencherGridRegiao();
            LimparControlos();
        }

        private void dataGridRegiao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNome.Text = dataGridRegiao.CurrentRow.Cells[1].Value.ToString();
            textBoxCaracterisitcas.Text = dataGridRegiao.CurrentRow.Cells[2].Value.ToString();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            modeloVinhos bd = new modeloVinhos();
            int id = (int)dataGridRegiao.CurrentRow.Cells[0].Value;
            Regiao a = bd.Regiaos.Find(id);
            a.Nome = textBoxNome.Text;
            a.Caracteristicas = textBoxCaracterisitcas.Text;
            bd.SaveChanges();
            PreencherGridRegiao();
            LimparControlos();

        }

        private void textBoxNome_Validating(object sender, CancelEventArgs e)
        {
            if (Validacoes.ValidarNome(textBoxNome.Text) == false)
            {
                erros.SetError(textBoxNome, "Defina um email.");
                textBoxNome.Focus();
                textBoxNome.SelectAll();
                e.Cancel = true;
            }
        }

        private void textBoxNome_Validated(object sender, EventArgs e)
        {
            erros.SetError(textBoxNome, "");
        }

        private void textBoxCaracterisitcas_Validating(object sender, CancelEventArgs e)
        {
            if (Validacoes.ValidarNome(textBoxCaracterisitcas.Text) == false)
            {
                erros.SetError(textBoxNome, "Defina um email.");
                textBoxCaracterisitcas.Focus();
                textBoxCaracterisitcas.SelectAll();
                e.Cancel = true;
            }
        }

        private void textBoxCaracterisitcas_Validated(object sender, EventArgs e)
        {
            erros.SetError(textBoxCaracterisitcas, "");
        }
    }
}
