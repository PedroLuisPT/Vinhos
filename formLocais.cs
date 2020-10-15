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
    public partial class formLocais : Form
    {
        public formLocais()
        {
            InitializeComponent();
        }

        private void buttonInformacao_Click(object sender, EventArgs e)
        {
            string hereKey = "Chave obtida na plataforma Here";
            WebRequest req;
            req = WebRequest.Create
            ("https://geocoder.ls.hereapi.com/search/6.2/geocode.json?"
            + "languages=pt-pt&maxresults=4&searchtext=" + textBoxPesquisa.Text + "&apiKey=" + hereKey);

            req.ContentType = "application/json";
            WebResponse resp = req.GetResponse();
            Stream strm = resp.GetResponseStream();
            StreamReader strm_reader = new StreamReader(strm);
            string json = strm_reader.ReadToEnd();
            Here.Local dados = JsonConvert.DeserializeObject<Here.Local>(json);
            Here.Result r = dados.Response.View[0].Result[0];
            textBoxLatitude.Text = r.Location.DisplayPosition.Latitude.ToString();
            textBoxLongitude.Text = r.Location.DisplayPosition.Longitude.ToString();


            /////////////////////////////////////////////////////

            string whatKey = "Chave obtida na plataforma What3Words";
            string lat = textBoxLatitude.Text.Replace(',', '.'),
            lng = textBoxLongitude.Text.Replace(',', '.');
            req = WebRequest.Create(
            "https://api.what3words.com/v3/convert-to-3wa?key=" + whatKey +
            "&coordinates=" + lat + "," + lng + "&language=pt&format=json");
            req.ContentType = "application/json";
            resp = req.GetResponse();
            strm = resp.GetResponseStream();
            strm_reader = new StreamReader(strm);
            json = strm_reader.ReadToEnd();
            What3Words.Local dados3Words = JsonConvert.DeserializeObject<What3Words.Local>(json);
            textBoxWhat3Words.Text = dados3Words.words;

        }





    }
}
