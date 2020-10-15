using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestaoVinho
{
    public partial class formCasta : Form
    {
        modeloVinhos db = new modeloVinhos();

        static string imagem = "";

        OpenFileDialog open = new OpenFileDialog();
        string destino = Directory.GetParent(Directory.GetParent(
            Path.GetDirectoryName(Application.ExecutablePath)).
            ToString()).ToString() + @"\imagens\castas\";


        public formCasta()
        {
            InitializeComponent();
        }

        void PreencherGridCasta()
        {
            modeloVinhos bd = new modeloVinhos();
            //LINQ
            var q = from a in bd.Castas
                    orderby a.Nome ascending
                    select new
                    {
                        ID = a.IdCasta,
                        Nome = a.Nome,
                        Caracteristicas = a.Caracteristicas,
                        Foto = a.Foto
                    };
            dataGridCasta.DataSource = q.ToList();
            //configurar controlo
            dataGridCasta.AllowUserToResizeRows = false;
            dataGridCasta.AllowUserToResizeColumns = false;
            dataGridCasta.ReadOnly = true;
            dataGridCasta.MultiSelect = false;
            dataGridCasta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //configurar colunas
            dataGridCasta.Columns[0].Visible = false;
            dataGridCasta.Columns[1].HeaderText = "Casta";
            dataGridCasta.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridCasta.Columns[2].Visible = false;
            dataGridCasta.Columns[3].Visible = false;

        }

        private void formCasta_Load(object sender, EventArgs e)
        {
            PreencherGridCasta();
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
            pictureBoxCasta.Image = null;
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            Casta c = new Casta();
            if (Validacoes.ValidarNome(textBoxNome.Text))
                c.Nome = textBoxNome.Text;
            else
            {
                MessageBox.Show("Defina o nome da casta.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNome.Focus();
                return;
            }
            c.Caracteristicas = textBoxCaracteristicas.Text;
            if (imagem.Length > 0)
            {
                c.Foto = imagem;
            }
            db.Castas.Add(c);
            db.SaveChanges();
            PreencherGridCasta();
            Limpar();

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridCasta.CurrentRow != null)
            {
                if (int.TryParse(dataGridCasta.CurrentRow.Cells[0].Value.ToString(), out int id))
                {
                    Casta c = db.Castas.Find(id);
                    //se a casta está associada a algum vinho, não permitir a eliminação
                    if (c != null && c.VinhoCastas.Count == 0 &&
                    MessageBox.Show($"{c.Nome} está associado a {c.VinhoCastas.Count} vinhos; eliminar?",
                    "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                    {
                        c.VinhoCastas.Clear();
                        db.Castas.Remove(c);
                        db.SaveChanges();
                        PreencherGridCasta();
                    }
                    else
                        MessageBox.Show($"A região {c.Nome} está associada a { c.VinhoCastas.Count} vinhos;" +
                            $"\nNão pode eliminar este registo.",
                "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível eliminar o registo.", "Eliminar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Seleccione o registo a eliminar.", "Eliminar",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpar();
        }

        private void dataGridCasta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNome.Text = dataGridCasta.CurrentRow.Cells[1].Value.ToString();
            textBoxCaracteristicas.Text = dataGridCasta.CurrentRow.Cells[2].Value.ToString();
            if (dataGridCasta.CurrentRow.Cells[3].Value.ToString().Length > 0)
            {
                pictureBoxCasta.Image = new
                Bitmap(dataGridCasta.CurrentRow.Cells[3].Value.ToString());
            }

        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridCasta.CurrentRow != null)
            {
                if (int.TryParse(dataGridCasta.CurrentRow.Cells[0].Value.ToString(), out int id))
                {
                    Casta c = db.Castas.Find(id);
                    if (Validacoes.ValidarNome(textBoxNome.Text))
                        c.Nome = textBoxNome.Text;
                    else
                    {
                        MessageBox.Show("Defina o nome da casta.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxNome.Focus();
                        return;
                    }
                    c.Caracteristicas = textBoxCaracteristicas.Text;
                    if (imagem.Length > 0)
                    {
                        File.Copy(open.FileName, Path.Combine(destino, open.FileName), true);
                        c.Foto = Path.Combine(destino, open.FileName);
                    }
                    db.SaveChanges();
                    PreencherGridCasta();
                    Limpar();
                }
            }
            else
                MessageBox.Show("Seleccione o registo a editar.", "Editar",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void textBoxNome_Validating(object sender, CancelEventArgs e)
        {
            if (Validacoes.ValidarNome(textBoxNome.Text) == false)
            {
                erros.SetError(textBoxNome, "Defina um Nome válido.");
                textBoxNome.Focus();
                textBoxNome.SelectAll();
                e.Cancel = true;
            }
        }

        private void textBoxNome_Validated(object sender, EventArgs e)
        {
            erros.SetError(textBoxNome, "");
        }

        private void textBoxCaracteristicas_Validating(object sender, CancelEventArgs e)
        {
            if (Validacoes.ValidarNome(textBoxCaracteristicas.Text) == false)
            {
                erros.SetError(textBoxNome, "Defina as características.");
                textBoxCaracteristicas.Focus();
                textBoxCaracteristicas.SelectAll();
                e.Cancel = true;
            }
        }

        private void textBoxCaracteristicas_Validated(object sender, EventArgs e)
        {
            erros.SetError(textBoxCaracteristicas, "");
        }

        private void checkBoxFoto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonFoto_Click(object sender, EventArgs e)
        {
            try
            {
                open.Filter =
                "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(open.FileName, Path.Combine(destino,
                   open.SafeFileName), true);
                    pictureBoxCasta.Image =
                   new Bitmap(Path.Combine(destino, open.SafeFileName));
                    imagem = Path.Combine(destino, open.SafeFileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao obter o ficheiro", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
