using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestaoVinho
{

    public partial class formProdutor : Form
    {
        modeloVinhos bd = new modeloVinhos();
        
       /* void ValidarEmail(string email, out bool formato, out bool temporario)
        {
            string key = "9aadb3a1f148a22902981d44e1b7727f";
            //configurar pedido
            WebRequest req;
            req = WebRequest.Create("http://apilayer.net/api/check?access_key=" +
                            key + "&email=" + textBoxEmail.Text
                            + "&smtp=&format=1");
            req.ContentType = "application/json";
            //obter resposta (JSON)
            WebResponse resp = req.GetResponse();
            //converter resposta para formato texto (string)
            Stream strm = resp.GetResponseStream();
            StreamReader strm_reader = new StreamReader(strm);
            string json = strm_reader.ReadToEnd();

            //converter string para objecto
            Email dados = JsonConvert.DeserializeObject<Email>(json);

            formato = dados.format_valid;
            temporario = dados.disposable;
        }
            */


        public formProdutor()
        {
            InitializeComponent();
        }

        #region Métodos

        void PreencherGridProdutores()
        {
            var q = from p in bd.Produtors
                    orderby p.Nome ascending
                    select new
                    {
                        p.IdProdutor,
                        p.Nome,
                        p.Email,
                        p.URL
                    };

            dataGridProdutor.DataSource = q.ToList();
            dataGridProdutor.AllowUserToResizeRows = false;
            dataGridProdutor.AllowUserToResizeColumns = false;
            dataGridProdutor.ReadOnly = true;
            dataGridProdutor.MultiSelect = false;
            dataGridProdutor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridProdutor.Columns[0].Visible = false;

            dataGridProdutor.Columns[1].HeaderText = "Produtor";
            dataGridProdutor.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridProdutor.Columns[2].Visible = false;
            dataGridProdutor.Columns[3].Visible = false;

        }

        void Limpar()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Text = "";
                if (item is DataGridView)
                {
                    ((DataGridView)item).ClearSelection();
                    ((DataGridView)item).CurrentCell = null;
                }
            }
        }

        #endregion

        private void gridProdutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNome.Text = dataGridProdutor.CurrentRow.Cells[1].Value.ToString();
            textBoxEmail.Text = dataGridProdutor.CurrentRow.Cells[2].Value.ToString();
            textBoxURL.Text = dataGridProdutor.CurrentRow.Cells[3].Value.ToString();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            Produtor p = new Produtor();

            if (Validacoes.ValidarNome(textBoxNome.Text))
                p.Nome = textBoxNome.Text;
            else
            {
                MessageBox.Show("Defina o nome do produtor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNome.Focus();
                return;
            }

            if (Validacoes.ValidarEmail(textBoxEmail.Text))
            {
                p.Email = textBoxEmail.Text;
            }
            else
            {
                MessageBox.Show("Defina um email correto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmail.Focus();
                return;
            }
            //validação do email
           /* bool f, t;
            ValidarEmail(textBoxEmail.Text, out f, out t);
            if (f == false)
            {
                MessageBox.Show("Formato de email incorrecto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmail.Focus();
                return;
            }
            else if (t == false)
            {
                MessageBox.Show("Não pode utilizar um email temporário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNome.Focus();
                return;
            }
            else
            {
                //ambas as validações (formato e temporário) estão correctas
                p.Email = textBoxEmail.Text;
            }*/

            p.URL = textBoxURL.Text;

            bd.Produtors.Add(p);
            bd.SaveChanges();

            PreencherGridProdutores();
            Limpar();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridProdutor.CurrentRow != null)
            {
                if (int.TryParse(dataGridProdutor.CurrentRow.Cells[0].Value.ToString(), out int id))
                {
                    Produtor p = bd.Produtors.Find(id);

                    if (Validacoes.ValidarNome(textBoxNome.Text))
                        p.Nome = textBoxNome.Text;
                    else
                    {
                        MessageBox.Show("Defina o nome do produtor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxNome.Focus();
                        return;
                    }
                    p.Email = textBoxEmail.Text;
                    p.URL = textBoxURL.Text;

                    bd.SaveChanges();

                    PreencherGridProdutores();
                    Limpar();
                }
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridProdutor.CurrentRow != null)
            {
                if (int.TryParse(dataGridProdutor.CurrentRow.Cells[0].Value.ToString(), out int id))
                {
                    Produtor p = bd.Produtors.Find(id);
                    if (p != null && p.Vinhoes.Count == 0 && MessageBox.Show($"{p.Nome} não está associado a qualquer vinho; eliminar?",
                        "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bd.Produtors.Remove(p);
                        bd.SaveChanges();
                        PreencherGridProdutores();
                    }
                    if (p != null && p.Vinhoes.Count > 0)
                        MessageBox.Show($"{p.Nome} está associado a {p.Vinhoes.Count} vinhos;\nNão pode eliminar este registo.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void formProdutor_Load(object sender, EventArgs e)
        {
            PreencherGridProdutores();
        }

    }
    class Email
    {
        public string email { get; set; }
        public string did_you_mean { get; set; }
        public string user { get; set; }
        public string domain { get; set; }
        public bool format_valid { get; set; }
        public object mx_found { get; set; }
        public object smtp_check { get; set; }
        public object catch_all { get; set; }
        public bool role { get; set; }
        public bool disposable { get; set; }
        public bool free { get; set; }
        public double score { get; set; }
    }
}

