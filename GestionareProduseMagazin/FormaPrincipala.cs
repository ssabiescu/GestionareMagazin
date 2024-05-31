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
    public partial class FormaPrincipala : Form
    {
        public FormaPrincipala()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormaPrincipala_Load(object sender, EventArgs e)
        {
            string connect = @"Data Source=DESKTOP-08KDD64\SQLEXPRESS;Initial Catalog=ProduseMagazin; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            string tabel_date = "select * from Produse";
            SqlDataAdapter da=new SqlDataAdapter(tabel_date, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "Produse");
            dGWProduse.DataSource = ds.Tables["Produse"].DefaultView;
            conn.Close();

        }

        private void btnCautare_Click(object sender, EventArgs e)
        {
            string connect = @"Data Source=DESKTOP-08KDD64\SQLEXPRESS;Initial Catalog=ProduseMagazin; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            string tabel_date = "select * from Produse where tip_produs='"+txtCautare.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(tabel_date, conn);
            DataSet ds=new DataSet();
            da.Fill(ds, "Produse");
            dGWProduse.DataSource = ds.Tables["Produse"].DefaultView;
            conn.Close();   
            da.Dispose(); 
            ds.Dispose();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            AdaugareProduse f = new AdaugareProduse();
            f.ShowDialog();
        }

        private void FormaPrincipala_Deactivate(object sender, EventArgs e)
        {
            this.FormaPrincipala_Load(sender, e);
        }

       
        private void btnAdaugareInfo_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(dGWProduse.SelectedCells[0].Value.ToString());
            AdaugareInfoProdus f=new AdaugareInfoProdus(id);
            f.ShowDialog();
        }

        private void btnAdaugareImg_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(dGWProduse.SelectedCells[0].Value.ToString());
            AdaugareImagini f = new AdaugareImagini(id);
            f.ShowDialog();
        }

        private void btnVizualizareProdus_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(dGWProduse.SelectedCells[0].Value.ToString());
            VizualizareProduse f = new VizualizareProduse(id);
            f.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStergereProdus_Click(object sender, EventArgs e)
        {
            using (Stergere stergereForm = new Stergere())
            {
                stergereForm.ShowDialog();
                //Application.Restart();
                FormaPrincipala_Load(sender, e);
            }
        }
    }
}
