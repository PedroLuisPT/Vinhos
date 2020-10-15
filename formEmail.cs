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
    public partial class formEmail : Form
    {
        public formEmail()
        {
            InitializeComponent();
        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
            string key = "0b382224cf44298d9ec42ed83dc41904";
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
            textBoxFormato.Text = dados.format_valid.ToString();
            textBoxTemporario.Text = dados.disposable.ToString();
        }
    }
}
