using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionareProduseMagazin
{
    public partial class AdaugareImagini : Form
    {
        int id_citit;
        public AdaugareImagini(int id)
        {
            this.id_citit = id;
            InitializeComponent();
        }

        private void AdaugareImagini_Load(object sender, EventArgs e)
        {
            txtID.Text = id_citit.ToString();
        }

        private void btnImagine_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog(); 
            if(dlg.ShowDialog() == DialogResult.OK )
            {
                txtImagine.Text = Path.GetFileName(dlg.FileName);

            }
        }

        private void btnAdaugaImagine_Click(object sender, EventArgs e)
        {
            if (txtImagine.Text != string.Empty)
            {
                string connect = @"Data Source=DESKTOP-08KDD64\SQLEXPRESS;Initial Catalog=ProduseMagazin; Integrated Security=True";
                SqlConnection conn = new SqlConnection(connect);
                conn.Open();
                string date = "insert into ImaginiProduse2 ([id],[cale_imagine]) values (@id, @ci)";
                SqlCommand sc = new SqlCommand(date, conn);
                sc.Parameters.AddWithValue("@id", Convert.ToInt16(txtID.Text));
                sc.Parameters.AddWithValue("@ci", txtImagine.Text);
                sc.ExecuteNonQuery();
                conn.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Trebuie sa completati toate campurile");
        }
    }
}
