using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestaoVinho
{
    public partial class formPaises : Form
    {
        public formPaises()
        {
            InitializeComponent();
        }

        private void comboBoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            WebRequest req;
            req = WebRequest.Create("https://restcountries.eu/rest/v2/region/" +
            comboBoxRegion.Text);
            req.ContentType = "application/json";
            WebResponse resp = req.GetResponse();
            Stream strm = resp.GetResponseStream();
            StreamReader strm_reader = new StreamReader(strm);
            string json = strm_reader.ReadToEnd();
            List<Countries.Country> paises =
            JsonConvert.DeserializeObject<List<Countries.Country>>(json);
            var q = from p in paises
                    orderby p.name ascending
                    select new
                    {
                        p.name
                    };
            dataGridountries.DataSource = q.ToList();
            dataGridountries.ReadOnly = true;
            dataGridountries.Columns[0].HeaderText = "Country";
            dataGridountries.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridountries.AllowUserToResizeColumns = false;
            dataGridountries.AllowUserToResizeRows = false;

        }
    }
}
