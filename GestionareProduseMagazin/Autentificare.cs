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
    public partial class Autentificare : Form
    {
        public Autentificare()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Autentificare_Load(object sender, EventArgs e)
        {
            
            string[] utilizatori = File.ReadAllLines("utilizatori.txt");
            foreach(var linie in utilizatori)
            {
                string[] inregistrare = linie.Split(',');
                cmbUtilizator.Items.Add(inregistrare[0]);
            }
        }

        private int incercari = 0;


        private void btnAutentificare_Click_1(object sender, EventArgs e)
        {
            string[] utilizatori = File.ReadAllLines("utilizatori.txt");
            foreach (var linie in utilizatori)
            {
                string[] inregistrare = linie.Split(',');
                if ((cmbUtilizator.Text).Equals(inregistrare[0]))
                {
                    if (txtParola.Text.Trim().Equals(inregistrare[1].Trim()))
                    {
                        FormaPrincipala f = new FormaPrincipala();
                        f.ShowDialog();
                    }
                    {
                        incercari++;
                        MessageBox.Show("Parola incorecta! Mai aveti " + (3 - incercari).ToString() + " incercari.");
                    }
                }
                if (incercari == 3)
                    Application.Exit();
            }
        }

        private void btnIesire_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInregistrare_Click_1(object sender, EventArgs e)
        {
            Inregistrare f = new Inregistrare();
            f.ShowDialog();
        }
    }
}
