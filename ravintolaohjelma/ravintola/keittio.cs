using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace ravintola
{
    public partial class keittio : Form
    {
        ruokalistamuokkaus rm;

        DateTime dt = DateTime.Now;
        string pvm = "dd.MM.yyyy";
        string klo = "HH:mm:ss";

        string polku1 = (@"C:\temp\pöytä1.txt");
        string polku2 = (@"C:\temp\pöytä2.txt");
        string polku3 = (@"C:\temp\pöytä3.txt");
        string polku4 = (@"C:\temp\pöytä4.txt");
        string polku5 = (@"C:\temp\pöytä5.txt");
        string polku6 = (@"C:\temp\pöytä6.txt");


        public keittio()
        {
            InitializeComponent();
            pvm_label.Text = dt.ToString(pvm);
            klo_label.Text = dt.ToString(klo);

            poyta1box.DataSource = tilauslukija(polku1);
            poyta2box.DataSource = tilauslukija(polku2);
            poyta3box.DataSource = tilauslukija(polku3);
            poyta4box.DataSource = tilauslukija(polku4);
            poyta5box.DataSource = tilauslukija(polku5);
            poyta6box.DataSource = tilauslukija(polku6);
        }

        // Lukee pöytien tilauksen annetulla parametrillä ja palauttaa ne listamuodossa listboxien sisällöiksi
        public List<string> tilauslukija(string polku)
        {
            string lukupolku = polku;
            // ** Jätä myöhempää käyttöä varten: **
            //TextReader lukija = new StreamReader(lukupolku);
            //string luettu = lukija.ReadToEnd();
            //lukija.Close();
            List<string> filu = new List<string>();
            using (var sr = new StreamReader(lukupolku))
            {
                while (sr.Peek() >= 0)
                    filu.Add(sr.ReadLine());
            }
            
            return filu;
        }

        // Tallentaa tekstitiedostoihin tiedon että pöydän tilaus on valmis, metodikutsu sijoitetaan jokaisen pöydän napin alle
        public void kuittaaja(string polkuParam)
        {
            
            string polku = polkuParam;
            //tilauslukija(polku) => lista, jonka sisältö on saatu parametrina, eli käytännössä joku tekstitiedoston sisältö -^
            for (int i = 0; i < tilauslukija(polku).Count; i++)
            {
                if (tilauslukija(polku)[i].Contains("Tilaus valmis: ei"))
                    tilauslukija(polku)[i] = "Tilaus valmis: kyllä";
            }

            StreamWriter sw = new StreamWriter(polku);
            sw.Write(tilauslukija(polku));
            sw.Close();

            // HOX HOX HOX
            // EI TOIMI TÄLLÄ HETKELLÄ, LUE MUUTOSLOKI.TXT
        }


        private void pt1valmis_nappi_Click(object sender, EventArgs e)
        {
            // Kutsu metodia joka tekee tallennuksen, tässä tapauksessa:
            kuittaaja(polku1);
        }

        // Avaa ikkunan jossa ruokalistaa voi muokata
        private void ruokalistaNappi_Click(object sender, EventArgs e)
        {
            rm = new ruokalistamuokkaus();
            rm.Show();
        }

        // Lähdetään pois keittiöstä, sulkee siis ikkunan
        private void paluuNappi_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        // TIETYLLÄ TAPAA TOIMIVA LUKIJA ?? KÄYTÄ MYÖHEMMIN / JEMMAA
        //public string tilauslukija(string polku)
        //{
        //    string lukupolku = polku;
        //    TextReader lukija = new StreamReader(lukupolku);
        //    string luettu = lukija.ReadToEnd();
        //    lukija.Close();
        //    return luettu;

        //}
    }
}
