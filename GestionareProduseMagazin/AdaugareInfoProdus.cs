using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionareProduseMagazin
{
    public partial class AdaugareInfoProdus : Form
    {
        int id_citit;
        public AdaugareInfoProdus(int id)
        {
            this.id_citit = id; 
            InitializeComponent();
        }

        private void AdaugareInfoProdus_Load(object sender, EventArgs e)
        {
            txtID.Text = id_citit.ToString();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (txtID.Text != string.Empty && txtCodProdus.Text != string.Empty && txtNumeProdus.Text != string.Empty && txtPret.Text != string.Empty)
            {
                string connect = @"Data Source=DESKTOP-08KDD64\SQLEXPRESS;Initial Catalog=ProduseMagazin; Integrated Security=True";
                SqlConnection conn = new SqlConnection(connect);
                conn.Open();
                string date = "insert into InfoProduse ([id],[cod_produs],[nume_produs], [pret]) values (@id, @cp, @np, @p)";
                SqlCommand sc = new SqlCommand(date, conn);
                sc.Parameters.AddWithValue("@id", Convert.ToInt16(txtID.Text));
                sc.Parameters.AddWithValue("@cp", txtCodProdus.Text);
                sc.Parameters.AddWithValue("@np", txtNumeProdus.Text);
                sc.Parameters.AddWithValue("@p", Convert.ToInt16(txtPret.Text));
                sc.ExecuteNonQuery();
                conn.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Trebuie sa completati toate campurile");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
