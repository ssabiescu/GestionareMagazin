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

namespace GestionareProduseMagazin
{
    public partial class Inregistrare : Form
    {
        public Inregistrare()
        {
            InitializeComponent();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            progressBar1.Value -= 1;
            progressBar1.Value += 1;
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer2.Stop();
                MessageBox.Show("inregistrare a reusit");
                Application.Restart();
            }
        }

        private void btnAutentificare_Click(object sender, EventArgs e)
        {
            timer2.Start();
            using (StreamWriter w = File.AppendText("utilizatori.txt"))
            {
                w.WriteLine(txtUtilizator.Text + "," + txtParola.Text);
            }
        }

    }
}
