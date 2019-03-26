using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ravintola
{

    public partial class poytavaraus : Form
    {
        SqlCommand cmd;
        SqlConnection conn;

        public poytavaraus()
        {
            InitializeComponent();
        }

        private void poytavaraus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'varauksetDataSet1.Varaukset' table. You can move, or remove it, as needed.
            this.varauksetTableAdapter.Fill(this.varauksetDataSet1.Varaukset);
        }

        // Lisää uusi button
        private void button1_Click(object sender, EventArgs e)
        {
            this.varauksetBindingSource.AddNew();
        }

        // Tallenna button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.varauksetBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.varauksetDataSet1);

            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\temp\Varaukset.mdf;Integrated Security=True");
            conn.Open();
            cmd = new SqlCommand("INSERT INTO Varaukset (Id, Etunimi, Sukunimi, Klo, Pvm, Pöytänro) VALUES (@Id, @Etunimi, @Sukunimi, @Klo, @Pvm, @Pöytänro)", conn);

            cmd.Parameters.AddWithValue("@Id", int.Parse(idTextBox.Text));
            cmd.Parameters.AddWithValue("@Etunimi", etunimiTextBox.Text);
            cmd.Parameters.AddWithValue("@Sukunimi", sukunimiTextBox.Text);
            cmd.Parameters.AddWithValue("@Klo", kloTextBox.Text);
            cmd.Parameters.AddWithValue("@Pvm", pvmTextBox.Text);
            cmd.Parameters.AddWithValue("@Pöytänro", int.Parse(pöytänroTextBox.Text));

            cmd.ExecuteNonQuery();
        }

        // Poista button, Ei poista tietokannoista mutta poistaa näkymästä rivin kun ohjelma on auki. (eli ei tallenna muutoksia)
        private void button3_Click(object sender, EventArgs e)
        {
            this.varauksetBindingSource.RemoveCurrent();
        }
    }
}
