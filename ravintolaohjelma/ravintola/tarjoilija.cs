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
using Newtonsoft.Json.Linq;

namespace ravintola
{
    public partial class tarjoilija : Form
    {
        public double yhtHinta;
        public double yhtHinta1;
        public double yhtHinta2;
        public double yhtHinta3;
        public double yhtHinta4;
        public double yhtHinta5;
        public double yhtHinta6;

        string polku1 = (@"C:\temp\pöytä1.txt");
        string polku2 = (@"C:\temp\pöytä2.txt");
        string polku3 = (@"C:\temp\pöytä3.txt");
        string polku4 = (@"C:\temp\pöytä4.txt");
        string polku5 = (@"C:\temp\pöytä5.txt");
        string polku6 = (@"C:\temp\pöytä6.txt");

        public List<Ruoka> ruoat = new List<Ruoka>();

        public List<Ruoka> tilaus = new List<Ruoka>();

        public List<Ruoka> poyta1 = new List<Ruoka>();

        DateTime dt = DateTime.Now;
        string aika = "dd/MM/yyyy";

        public tarjoilija()
        {
            InitializeComponent();
            ruoat = lueruoat();
            listBox1.DataSource = lueruoat();
        }

        //Lista lul
        public List<Ruoka> lueruoat()
        {
            string ruoat = @"C:\temp\menu.txt";
            TextReader tr = new StreamReader(ruoat);

            List<Ruoka> ruokalista = JsonConvert.DeserializeObject<List<Ruoka>>(tr.ReadToEnd());
            tr.Close();
            return ruokalista;
        }

        //Lisätään ja poistetaan listboxeilta tilauksia ja lasketaan yhteishinta
        //Lisaa ja poista metodit
        //ADD pöytä 1
        public void Lisaalist2_Click(object sender, EventArgs e)
        {
            Lisaa(listBox1, listBox2, textBox1, 1);
        }
        //REMOVE pöytä 1
        public void Poistalist2_Click(object sender, EventArgs e)
        {
            poista(listBox2, textBox1, 1);
        }

        //ADD pöytä 2
        private void Lisaalist3_Click(object sender, EventArgs e)
        {
            Lisaa(listBox1, listBox3, textBox2, 2);
        }
        //REMOVE pöytä 2
        private void Poistalist3_Click(object sender, EventArgs e)
        {
            poista(listBox3, textBox2, 2);
        }

        //ADD pöytä 3
        private void Lisaalist4_Click(object sender, EventArgs e)
        {
            Lisaa(listBox1, listBox4, textBox3, 3);
        }
        //REMOVE pöytä 3
        private void Poistalist4_Click(object sender, EventArgs e)
        {
            poista(listBox4, textBox3, 3);
        }

        //ADD pöytä 4
        private void Lisaalist5_Click(object sender, EventArgs e)
        {
            Lisaa(listBox1, listBox5, textBox4, 4);
        }
        //REMOVE pöytä 4
        private void Poistalist5_Click(object sender, EventArgs e)
        {
            poista(listBox5, textBox4, 4);
        }

        //ADD pöytä 5
        private void Lisaalist6_Click(object sender, EventArgs e)
        {
            Lisaa(listBox1, listBox6, textBox5, 5);
        }
        //REMOVE pöytä 5
        private void Poistalist6_Click(object sender, EventArgs e)
        {
            poista(listBox6, textBox5, 5);
        }

        //ADD pöytä 6
        private void Lisaalist7_Click(object sender, EventArgs e)
        {
            Lisaa(listBox1, listBox7, textBox6, 6);
        }
        //REMOVE pöytä 6
        private void Poistalist7_Click(object sender, EventArgs e)
        {
            poista(listBox7, textBox6, 6);
        }

        //Lisää metodi
        public void Lisaa(ListBox list1, ListBox list2, TextBox text, int value)
        {
            Ruoka pleb;
            pleb = (Ruoka)list1.SelectedItem;

            list2.Items.Add(list1.SelectedItem);
            switch (value)
            {
                case 1:
                    yhtHinta1 = yhtHinta1 + +pleb.hinta;
                    text.Text = yhtHinta1.ToString();
                    break;
                case 2:
                    yhtHinta2 = yhtHinta2 + +pleb.hinta;
                    text.Text = yhtHinta2.ToString();
                    break;
                case 3:
                    yhtHinta3 = yhtHinta3 + +pleb.hinta;
                    text.Text = yhtHinta3.ToString();
                    break;
                case 4:
                    yhtHinta4 = yhtHinta4 + +pleb.hinta;
                    text.Text = yhtHinta4.ToString();
                    break;
                case 5:
                    yhtHinta5 = yhtHinta5 + +pleb.hinta;
                    text.Text = yhtHinta5.ToString();
                    break;
                case 6:
                    yhtHinta6 = yhtHinta6 + +pleb.hinta;
                    text.Text = yhtHinta6.ToString();
                    break;
            }
        }

        //Poista metodi
        public void poista(ListBox list2, TextBox text, int value)
        {
            Ruoka pleb;
            pleb = (Ruoka)list2.SelectedItem;

            list2.Items.Remove(list2.SelectedItem);
            switch (value)
            {
                case 1:
                    yhtHinta1 = yhtHinta1 - pleb.hinta;
                    text.Text = yhtHinta1.ToString();
                    break;
                case 2:
                    yhtHinta2 = yhtHinta2 - pleb.hinta;
                    text.Text = yhtHinta2.ToString();
                    break;
                case 3:
                    yhtHinta3 = yhtHinta3 - pleb.hinta;
                    text.Text = yhtHinta3.ToString();
                    break;
                case 4:
                    yhtHinta4 = yhtHinta4 - pleb.hinta;
                    text.Text = yhtHinta4.ToString();
                    break;
                case 5:
                    yhtHinta5 = yhtHinta5 - pleb.hinta;
                    text.Text = yhtHinta5.ToString();
                    break;
                case 6:
                    yhtHinta6 = yhtHinta6 - pleb.hinta;
                    text.Text = yhtHinta6.ToString();
                    break;
            }
        }

        //TEKSTITIEDOSTOIHIN KIRJOITUKSET Tilaaja metodia käyttäen
        //pöytä 1 tilaus
        private void Tilauslist2_Click(object sender, EventArgs e)
        {
            Tilaaja(polku1, listBox2, yhtHinta1);
        }
        //pöytä 2 tilaus
        private void Tilauslist3_Click(object sender, EventArgs e)
        {
            Tilaaja(polku2, listBox3, yhtHinta2);
        }
        //pöytä 3 tilaus
        private void Tilauslist4_Click(object sender, EventArgs e)
        {
            Tilaaja(polku3, listBox4, yhtHinta3);
        }
        //pöytä 4 tilaus
        private void Tilauslist5_Click(object sender, EventArgs e)
        {
            Tilaaja(polku4, listBox5, yhtHinta4);
        }
        //pöytä 5 tilaus
        private void Tilauslist6_Click(object sender, EventArgs e)
        {
            Tilaaja(polku5, listBox6, yhtHinta5);
        }
        //pöytä 6 tilaus
        private void Tilauslist7_Click(object sender, EventArgs e)
        {
            Tilaaja(polku6, listBox7, yhtHinta6);
        }

        //Tilaaja metodi
        public void Tilaaja(string polku, ListBox sisalto, double yhtHinta)
        {
            string kirjoituspolku = polku;
            double yht = yhtHinta;
            StreamWriter sw = new StreamWriter(kirjoituspolku);
            foreach (var item in sisalto.Items)
            {
                sw.WriteLine(item.ToString());
            }
            sw.WriteLine("Yhteensä " + yht);
            sw.WriteLine("PVM " + dt.ToString(aika));
            sw.WriteLine("KLO " + DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo));

            sw.WriteLine("Tilaus valmis: ei");
            sw.Close();
            MessageBox.Show("Tilaus lähetetty");

        }

    }
    public class Ruoka
    {
        public int id;
        public string nimi = "";
        public double hinta = 0;
        public string lakton = "";
        public string gluton = "";

        public Ruoka()
        {

        }

        public Ruoka(int id, string nimi, double hinta, string lakton, string gluton)
        {
            this.id = id;
            this.nimi = nimi;
            this.hinta = hinta;
            this.lakton = lakton;
            this.gluton = gluton;
        }

        public override string ToString()
        {
            return string.Format("Annos: {1}, Lakton: {3}, Gluton: {4}, Hinta: {2}", id, nimi, hinta, lakton, gluton);
        }
    }
}