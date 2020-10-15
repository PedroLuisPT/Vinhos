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
    public partial class formVinho : Form
    {
        modeloVinhos bd = new modeloVinhos();
        public formVinho()
        {
            InitializeComponent();
        }

        void PreencherGridVinhos()
        {
            var q = from a in bd.Vinhoes
                    orderby a.Nome ascending
                    select new
                    {
                        ID = a.IdVinho,
                        Nome = a.Nome,
                        Cor = a.Cor,
                        Regiao = a.Regiao,
                        Produtor = a.Produtor,
                        volume = a.Volume,
                        TeorAlcoolico = a.TeorAlcoolico,
                        Ano = a.Ano
                    };
            dataGridVinho.DataSource = q.ToList();
            dataGridVinho.Columns[0].Visible = false;
            dataGridVinho.Columns[1].HeaderText = "Vinho";
            dataGridVinho.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridVinho.Columns[2].Visible = false;
            dataGridVinho.Columns[3].Visible = false;
            dataGridVinho.Columns[4].Visible = false;
            dataGridVinho.Columns[5].Visible = false;
            dataGridVinho.Columns[6].Visible = false;
            dataGridVinho.Columns[7].Visible = false;
        }

        private void formVinho_Load(object sender, EventArgs e)
        {
            PreencherGridVinhos();
            PreencherComboRegiao();
            PreencherComboProdutor();
        }

        void LimparControlos()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Text = "";
                if (item is ComboBox)
                    ((ComboBox)item).SelectedIndex = -1;
                if (item is DataGridView)
                {
                    ((DataGridView)item).ClearSelection();
                    ((DataGridView)item).CurrentCell = null;
                }
            }
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            Vinho v = new Vinho();
            if (Validacoes.ValidarNome(textBoxNome.Text))
                v.Nome = textBoxNome.Text;
            else
            {
                MessageBox.Show("Defina o nome do vinho.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNome.Focus();
                return;
            }
            v.TeorAlcoolico = decimal.Parse(textBoxTeorAlcoolico.Text);
            v.Volume = decimal.Parse(textBoxVolume.Text);
            v.Ano = int.Parse(maskedTextBoxAno.Text);
            v.Cor = textBoxCor.Text;
            //produtor e região - valores seleccionado nas ComoBox
            v.Produtor = int.Parse(comboBoxProdutor.SelectedValue.ToString());
            v.Regiao = int.Parse(comboBoxRegiao.SelectedValue.ToString());

            bd.Vinhoes.Add(v);
            bd.SaveChanges();
            PreencherGridVinhos();
            LimparControlos();

        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridVinho.CurrentRow != null)
            {
                int id = (int)dataGridVinho.CurrentRow.Cells[0].Value;
                Vinho v = bd.Vinhoes.Find(id);
                try
                {
                    if (MessageBox.Show($"Eliminar o vinho {v.Nome}?", "Eliminar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        v.VinhoCastas.Clear();
                        v.VinhoEnologoes.Clear();
                        bd.Vinhoes.Remove(v);
                        bd.SaveChanges();
                        PreencherGridVinhos();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao eliminar o registo");
                }
                LimparControlos();
            }
            else
                MessageBox.Show("Seleccione o registo a elimnar.", "Eliminar",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridVinho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNome.Text = dataGridVinho.CurrentRow.Cells[1].Value.ToString();
            textBoxTeorAlcoolico.Text = dataGridVinho.CurrentRow.Cells[2].Value.ToString();
            maskedTextBoxAno.Text = dataGridVinho.CurrentRow.Cells[3].Value.ToString();
            textBoxVolume.Text = dataGridVinho.CurrentRow.Cells[4].Value.ToString();
            comboBoxRegiao.SelectedValue = dataGridVinho.CurrentRow.Cells[5].Value;
            comboBoxProdutor.SelectedValue = dataGridVinho.CurrentRow.Cells[6].Value;
            textBoxCor.Text = dataGridVinho.CurrentRow.Cells[7].Value.ToString();
            int id = int.Parse(dataGridVinho.CurrentRow.Cells[0].Value.ToString());
            VinhoCastas(id);
            RestantesCastas(id);
            VinhoEnologos(id);
            RestantesEnologos(id);
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridVinho.CurrentRow != null)
            {
                int id = (int)dataGridVinho.CurrentRow.Cells[0].Value;
                Vinho v = bd.Vinhoes.Find(id);
                v.Nome = textBoxNome.Text;
                v.TeorAlcoolico = decimal.Parse(textBoxTeorAlcoolico.Text);
                v.Volume = decimal.Parse(textBoxVolume.Text);
                v.Ano = int.Parse(maskedTextBoxAno.Text);
                v.Cor = textBoxCor.Text;
                v.Produtor = int.Parse(comboBoxProdutor.SelectedValue.ToString());
                v.Regiao = int.Parse(comboBoxRegiao.SelectedValue.ToString());
                bd.SaveChanges();
                PreencherGridVinhos();
                LimparControlos();
            }
            else
                MessageBox.Show("Seleccione o registo a editar.", "Editar",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void PreencherComboRegiao()
        {
            var q = from r in bd.Regiaos
                    orderby r.Nome ascending
                    select new { r.IdRegiao, r.Nome };
            comboBoxRegiao.DataSource = q.ToList();
            comboBoxRegiao.DisplayMember = "Nome";
            comboBoxRegiao.ValueMember = "IdRegiao";
            comboBoxRegiao.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        void PreencherComboProdutor()
        {
            var q = from p in bd.Produtors
                    orderby p.Nome ascending
                    select new { p.IdProdutor, p.Nome };
            comboBoxProdutor.DataSource = q.ToList();
            comboBoxProdutor.DisplayMember = "Nome";
            comboBoxProdutor.ValueMember = "IdProdutor";
            comboBoxProdutor.DropDownStyle = ComboBoxStyle.DropDownList;

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

        private void textBoxCor_Validating(object sender, CancelEventArgs e)
        {
            if (Validacoes.ValidarNome(textBoxCor.Text) == false)
            {
                erros.SetError(textBoxNome, "Defina uma cor.");
                textBoxNome.Focus();
                textBoxNome.SelectAll();
                e.Cancel = true;
            }
        }

        private void textBoxAno_Validating(object sender, CancelEventArgs e)
        {
            int n = 0;
            if (int.TryParse(maskedTextBoxAno.Text, out n) == false)
            {
                erros.SetError(maskedTextBoxAno, "Defina um ano válido.");
                maskedTextBoxAno.Focus();
                maskedTextBoxAno.SelectAll();
                e.Cancel = true;
            }
        }

        private void textBoxNome_Validated(object sender, EventArgs e)
        {
            erros.SetError(textBoxNome, "");
        }

        private void textBoxCor_Validated(object sender, EventArgs e)
        {
            erros.SetError(textBoxCor, "");
        }

        private void textBoxAno_Validated(object sender, EventArgs e)
        {
            erros.SetError(maskedTextBoxAno, "");
        }

        private void textBoxVolume_Validating(object sender, CancelEventArgs e)
        {
            int n = 0;
            if (int.TryParse(textBoxVolume.Text, out n) == false)
            {
                erros.SetError(textBoxVolume, "Defina um volume válido.");
                textBoxVolume.Focus();
                textBoxVolume.SelectAll();
                e.Cancel = true;
            }
        }

        private void textBoxVolume_Validated(object sender, EventArgs e)
        {
            erros.SetError(textBoxVolume, "");
        }

        private void textBoxTeorAlcoolico_Validating(object sender, CancelEventArgs e)
        {
            int n = 0;
            if (int.TryParse(textBoxTeorAlcoolico.Text, out n) == false)
            {
                erros.SetError(textBoxTeorAlcoolico, "Defina um teor alcoólico válido.");
                textBoxTeorAlcoolico.Focus();
                textBoxTeorAlcoolico.SelectAll();
                e.Cancel = true;
            }
        }

        private void textBoxTeorAlcoolico_Validated(object sender, EventArgs e)
        {
            erros.SetError(textBoxTeorAlcoolico, "");
        }


        void VinhoEnologos(int id)
        {
            var q = from ve in bd.VinhoEnologoes
                    join e in bd.Enologoes on ve.Enologo equals e.IdEnologo
                    where ve.Vinho == id
                    select new
                    {
                        ve.IDVinhoEnologo,
                        e.Nome
                    };
            dataGridVinhoEnologo.DataSource = q.ToList();
            dataGridVinhoEnologo.AllowUserToResizeColumns = false;
            dataGridVinhoEnologo.AllowUserToResizeRows = false;
            dataGridVinhoEnologo.ReadOnly = true;
            dataGridVinhoEnologo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridVinhoEnologo.MultiSelect = false;
            dataGridVinhoEnologo.Columns[0].Visible = false;
            dataGridVinhoEnologo.Columns[1].HeaderText = "Enólogo";
            dataGridVinhoEnologo.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        void RestantesEnologos(int id)
        {
            //obter a lista de enólogos que já estão associados ao vinho
            var enologos = (from ve in bd.VinhoEnologoes
                            where ve.Vinho == id
                            select ve.Enologo).ToList();
            //obter a lista de enólogos que não estão associados ao vinho
            var q = from en in bd.Enologoes
                    where !enologos.Contains(en.IdEnologo)
                    orderby en.Nome ascending
                    select new { en.IdEnologo, en.Nome };
            dataGridRestantesEnologos.DataSource = q.ToList();
            dataGridRestantesEnologos.AllowUserToResizeColumns = false;
            dataGridRestantesEnologos.AllowUserToResizeRows = false;
            dataGridRestantesEnologos.ReadOnly = true;
            dataGridRestantesEnologos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridRestantesEnologos.MultiSelect = false;
            dataGridRestantesEnologos.Columns[0].Visible = false;
            dataGridRestantesEnologos.Columns[1].HeaderText = "Enólogo";
            dataGridRestantesEnologos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        void VinhoCastas(int id)
        {
            var q = from vc in bd.VinhoCastas
                    join c in bd.Castas on vc.Casta equals c.IdCasta
                    where vc.Vinho == id
                    select new { vc.IdVinhoCasta, c.Nome, vc.Percentagem };
            dataGridVinhoCasta.DataSource = q.ToList();
            dataGridVinhoCasta.AllowUserToResizeColumns = false;
            dataGridVinhoCasta.AllowUserToResizeRows = false;
            dataGridVinhoCasta.ReadOnly = true;
            dataGridVinhoCasta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridVinhoCasta.MultiSelect = false;
            dataGridVinhoCasta.Columns[0].Visible = false;
            dataGridVinhoCasta.Columns[1].HeaderText = "Casta";
            dataGridVinhoCasta.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridVinhoCasta.Columns[2].HeaderText = "Percentagem";
            dataGridVinhoCasta.Columns[2].Width = 75;
        }

        void RestantesCastas(int id)
        {
            //obter a lista de castas que já estão associadas ao vinho
            var temp = (from vc in bd.VinhoCastas
                        where vc.Vinho == id
                        select vc.Casta).ToList();
            //obter a lista de castas que não estão associadas ao vinho
            var q = from c in bd.Castas
                    where !temp.Contains(c.IdCasta)
                    orderby c.Nome
                    select new { c.IdCasta, c.Nome };
            dataGridRestantesCastas.DataSource = q.ToList();
            dataGridRestantesCastas.AllowUserToResizeColumns = false;
            dataGridRestantesCastas.AllowUserToResizeRows = false;
            dataGridRestantesCastas.ReadOnly = true;
            dataGridRestantesCastas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridRestantesCastas.MultiSelect = false;
            dataGridRestantesCastas.Columns[0].Visible = false;
            dataGridRestantesCastas.Columns[1].HeaderText = "Casta";
            dataGridRestantesCastas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void buttonAssociar_Click(object sender, EventArgs e)
        {
            if (dataGridVinho.CurrentRow != null && dataGridRestantesEnologos.CurrentRow != null)
            {
                //associar enólogo ao vinho
                int id_vinho = int.Parse(dataGridVinho.CurrentRow.Cells[0].Value.ToString());
                VinhoEnologo ve = new VinhoEnologo();
                ve.Enologo = int.Parse(dataGridRestantesEnologos.CurrentRow.Cells[0].Value.ToString());
                ve.Vinho = id_vinho;
                bd.VinhoEnologoes.Add(ve);
                bd.SaveChanges();
                VinhoEnologos(id_vinho);
                RestantesEnologos(id_vinho);
            }
            else
                MessageBox.Show("Seleccione o vinho e o enólogo.", "Associar enólogo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDissociar_Click(object sender, EventArgs e)
        {
            //dissociar enólogo do vinho
            if (dataGridVinhoEnologo.CurrentRow != null)
            {
                int id_vinho = int.Parse(dataGridVinho.CurrentRow.Cells[0].Value.ToString());
                VinhoEnologo ve = bd.VinhoEnologoes.Find(
                int.Parse(dataGridVinhoEnologo.CurrentRow.Cells[0].Value.ToString()));
                bd.VinhoEnologoes.Remove(ve);
                bd.SaveChanges();
                VinhoEnologos(id_vinho);
                RestantesEnologos(id_vinho);
            }
            else
                MessageBox.Show("Seleccione o enólogo.", "Dissociar enólogo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //função que obtém a soma da percentagens das castas associadas a um vinho
        decimal PercentagemVinho(int id)
        {
            var q = from vc in bd.VinhoCastas
                    where vc.Vinho == id
                    select new { vc.Vinho, vc.Percentagem };
            decimal p = 0;
            foreach (var item in q)
            {
                p += (decimal)item.Percentagem;
            }
            return p;
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            //adicionar casta
            if (dataGridVinho.CurrentRow != null && dataGridRestantesCastas.CurrentRow != null)
            {
                int id_vinho = int.Parse(dataGridVinho.CurrentRow.Cells[0].Value.ToString());
                VinhoCasta vc = new VinhoCasta();
                vc.Vinho = id_vinho;
                vc.Casta = int.Parse(dataGridRestantesCastas.CurrentRow.Cells[0].Value.ToString());
                decimal.TryParse(textBoxPercentagem.Text, out decimal per);
                vc.Percentagem = per;
                if (PercentagemVinho(id_vinho) + per <= 100)
                {
                    bd.VinhoCastas.Add(vc);
                    bd.SaveChanges();
                    VinhoCastas(id_vinho);
                    RestantesCastas(id_vinho);
                }
                else
                {
                    MessageBox.Show("A soma das percentagens é superior a 100%.",
                    "Associar casta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxPercentagem.Focus();
                    textBoxPercentagem.SelectAll();
                }
            }
            else
                MessageBox.Show("Seleccione o vinho e o enólogo.", "Associar enólogo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            //remover casta
            if (dataGridVinhoCasta.CurrentRow != null)
            {
                int id_vinho = int.Parse(dataGridVinho.CurrentRow.Cells[0].Value.ToString());
                VinhoCasta vc = bd.VinhoCastas.Find(
                int.Parse(dataGridVinhoCasta.CurrentRow.Cells[0].Value.ToString()));
                bd.VinhoCastas.Remove(vc);
                bd.SaveChanges();
                VinhoCastas(id_vinho);
                RestantesCastas(id_vinho);
            }
            else
                MessageBox.Show("Seleccione a casta a remover.", "Disssociar casta",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
