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
    public partial class ruokalistamuokkaus : Form
    {
        public List<Ruoka> ruokalista = new List<Ruoka>();
        public ruokalistamuokkaus()
        {
            InitializeComponent();

            // Listboxiin luetaan sisältö
            listBox1.DataSource = luemenu();
        }

        // Lue ruokalista ja deserialisoi se
        public List<Ruoka> luemenu()
        {
            string ruoat = @"C:\temp\menu.txt";
            TextReader lukija = new StreamReader(ruoat); // lukee ruokalistan "raa'assa" muodossa
            this.ruokalista = JsonConvert.DeserializeObject<List<Ruoka>>(lukija.ReadToEnd()); // deserialisoi listan json muodosta
            lukija.Close();
            return ruokalista;
        }

        // Ruoka -luokka
        public class Ruoka
        {
            public int id;
            public string nimi = "";
            public double hinta = 0;
            public string lakton = "";
            public string gluton = "";

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
                return string.Format("{1} - Lakton: {2}, Gluton: {3} - H: {4}€", id, nimi, lakton, gluton, hinta);
            }
        }

        //Valitusta annoksesta tulee annosboxiin annoksen nimi ja hintaboxiin hinta
        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ruoka kek;

            kek = (Ruoka)listBox1.SelectedItem;

            annosBox.Text = kek.nimi;
            hintaBox.Text = Convert.ToString(kek.hinta);
            hintaNollaalvBox.Text = Convert.ToString(hintalaskuri());
            annosIDBox.Text = kek.id.ToString();
            //Alla olevat tarkistaa onko annos laktoositon ja gluteeniton, ja ilmoittaa asian checkboxilla
            if (kek.lakton == "on")
            {
                laktoncheckBox.CheckState = CheckState.Checked;
            }
            else
            {
                laktoncheckBox.CheckState = CheckState.Unchecked;
            }
            if (kek.gluton == "on")
            {
                glutoncheckBox.CheckState = CheckState.Checked;
            }
            else
            {
                glutoncheckBox.CheckState = CheckState.Unchecked;
            }
        }

        // Laskee ALV 0% hinnan ja palauttaa arvon sille varattuun textboxiin
        public double hintalaskuri()
        {
            Ruoka kek;
            kek = (Ruoka)listBox1.SelectedItem;
            double nollaALV = Math.Round(kek.hinta / 1.14, 2); //Math.Round pyöristää arvon kahden desimaalin tarkkuuteen
            return nollaALV;
        }

        // Hinta-boxi huolii vain numeroita ja yhden desimaalipilkun
        private void hintaBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        // Tallenna-nappi varmistaa haluaako käyttäjä tallentaa muutokset
        private void tallennaButton_Click(object sender, EventArgs e)
        {
            const string message = "Haluatko varmasti tallentaa muutokset ruokalistaan?";
            const string caption = "Muutoksen vahvistus";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Mikäli valinta on kyllä, tallennetaan uudet tiedot
            if (result == DialogResult.Yes)
            {
                string ruoat = @"C:\temp\menu.txt";
                ruokalistanMuokkaaja();
                string sisalto = JsonConvert.SerializeObject(ruokalista);
                TextWriter kirjoittaja = new StreamWriter(ruoat);
                kirjoittaja.Write(sisalto);
                kirjoittaja.Close();
                // Päivittää tallennuksen jälkeen listboxin sisällön:
                listBox1.DataSource = luemenu();
            }
            else // mikäli valinta on ei, lukee listboxin tiedot uudelleen tiedostosta joita ei ole vielä muokattu = käytännössä tyhjentää kentät
            {
                listBox1.DataSource = luemenu();
            }
        }

        // Ruokalistan muokkaaja
        public void ruokalistanMuokkaaja()
        {
            Ruoka annos;
            annos = (Ruoka)listBox1.SelectedItem;

            annos.id = int.Parse(annosIDBox.Text);
            annos.nimi = annosBox.Text;
            annos.hinta = int.Parse(hintaBox.Text);
            string uusilakton;
            string uusigluton;
            if (laktoncheckBox.CheckState == CheckState.Checked)
            {
                uusilakton = "on";
            }
            else
            {
                uusilakton = "ei";
            }
            annos.lakton = uusilakton;
            if (glutoncheckBox.CheckState == CheckState.Checked)
            {
                uusigluton = "on";
            }
            else
            {
                uusigluton = "ei";
            }
            annos.gluton = uusigluton;

            this.ruokalista[listBox1.SelectedIndex] = annos;

        }

        private void suljeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
