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

namespace GestionareProduseMagazin
{
    public partial class AdaugareProduse : Form
    {
        public AdaugareProduse()
        {
            InitializeComponent();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (txtID.Text != string.Empty && txttipProdus.Text != string.Empty && txtRaion.Text != string.Empty)
            {
                string connect = @"Data Source=DESKTOP-08KDD64\SQLEXPRESS;Initial Catalog=ProduseMagazin; Integrated Security=True";
                SqlConnection conn = new SqlConnection(connect);
                conn.Open();
                string date = "insert into Produse ([id],[tip_produs],[raion]) values (@id, @tp, @r)";
                SqlCommand sc = new SqlCommand(date, conn);
                sc.Parameters.AddWithValue("@id",Convert.ToInt16(txtID.Text));
                sc.Parameters.AddWithValue("@tp", txttipProdus.Text);
                sc.Parameters.AddWithValue("@r", txtRaion.Text);
                sc.ExecuteNonQuery();
                conn.Close();
                this.DialogResult=DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Trebuie sa completati toate campurile");
        }

        private void AdaugareProduse_Load(object sender, EventArgs e)
        {

        }
    }
}
