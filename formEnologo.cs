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
    public partial class formEnologo : Form
    {
        public formEnologo()
        {
            InitializeComponent();
        }

        void PreencherGridEnologos()
        {
            modeloVinhos bd = new modeloVinhos();
            //LINQ
            var q = from a in bd.Enologoes
                    orderby a.Nome ascending
                    select new
                    {
                        ID = a.IdEnologo,
                        Nome = a.Nome,
                        Instagram = a.Instragram,
                        Twitter = a.Twitter
                    };
            dataGridEnologo.DataSource = q.ToList();
            dataGridEnologo.Columns[0].Visible = false;
            dataGridEnologo.Columns[1].Width = 150;
            dataGridEnologo.Columns[2].Width = 150;
            dataGridEnologo.Columns[3].Width = 150;
        }

        private void formEnologo_Load(object sender, EventArgs e)
        {
            PreencherGridEnologos();
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
            Enologo a = new Enologo();
            a.Nome = textBoxNome.Text;
            a.Instragram = textBoxInstagram.Text;
            a.Twitter = textBoxTwitter.Text;
            bd.Enologoes.Add(a);
            bd.SaveChanges();
            PreencherGridEnologos();
            LimparControlos();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            modeloVinhos bd = new modeloVinhos();
            int id = (int)dataGridEnologo.CurrentRow.Cells[0].Value;
            Enologo a = bd.Enologoes.Find(id);
            try
            {
                bd.Enologoes.Remove(a);
                bd.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Não pode eliminar o registo seleccionado.");
            }
            PreencherGridEnologos();
            LimparControlos();

        }

        private void dataGridEnologo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNome.Text = dataGridEnologo.CurrentRow.Cells[1].Value.ToString();
            textBoxInstagram.Text = dataGridEnologo.CurrentRow.Cells[2].Value.ToString();
            textBoxTwitter.Text = dataGridEnologo.CurrentRow.Cells[3].Value.ToString();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            modeloVinhos bd = new modeloVinhos();
            int id = (int)dataGridEnologo.CurrentRow.Cells[0].Value;
            Enologo a = bd.Enologoes.Find(id);
            a.Nome = textBoxNome.Text;
            a.Instragram = textBoxInstagram.Text;
            a.Twitter = textBoxTwitter.Text;
            bd.SaveChanges();
            PreencherGridEnologos();
            LimparControlos();
        }

        private void textBoxNome_Validating(object sender, CancelEventArgs e)
        {
            if (Validacoes.ValidarNome(textBoxNome.Text) == false)
            {
                erros.SetError(textBoxNome, "Defina um nome.");
                textBoxNome.Focus();
                textBoxNome.SelectAll();
                e.Cancel = true;
            }
        }

        private void textBoxNome_Validated(object sender, EventArgs e)
        {
            erros.SetError(textBoxNome, "");
        }

        private void textBoxInstagram_Validating(object sender, CancelEventArgs e)
        {
            if (Validacoes.ValidarNome(textBoxInstagram.Text) == false)
            {
                erros.SetError(textBoxInstagram, "Defina um nome.");
                textBoxInstagram.Focus();
                textBoxInstagram.SelectAll();
                e.Cancel = true;
            }
        }

        private void textBoxInstagram_Validated(object sender, EventArgs e)
        {
            erros.SetError(textBoxInstagram, "");
        }

        private void textBoxTwitter_Validating(object sender, CancelEventArgs e)
        {
            if (Validacoes.ValidarNome(textBoxTwitter.Text) == false)
            {
                erros.SetError(textBoxTwitter, "Defina um endereço de Twitter.");
                textBoxTwitter.Focus();
                textBoxTwitter.SelectAll();
                e.Cancel = true;
            }
        }

        private void textBoxTwitter_Validated(object sender, EventArgs e)
        {
            erros.SetError(textBoxTwitter, "");
        }
    }
}
