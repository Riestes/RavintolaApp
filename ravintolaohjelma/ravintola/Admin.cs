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
    public partial class Admin : Form
    {
      
        tarjoilija tr;
        keittio kt;
        poytavaraus pv;
        public Admin()
        {
            InitializeComponent();
            //tarjoilija2 tarjoilija = new tarjoilija2();
        }
        
        public void button1_Click(object sender, EventArgs e)
        {
            tr = new tarjoilija();
            tr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pv = new poytavaraus();
            pv.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kt = new keittio();
            kt.Show();
        }
    }
}
