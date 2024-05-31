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

namespace GestionareProduseMagazin
{
    public partial class VizualizareProduse : Form
    {
        int id_citit;
        public VizualizareProduse(int id)
        {
            this.id_citit = id; 
            InitializeComponent();
        }

        private void VizualizareProduse_Load(object sender, EventArgs e)
        {
            txtID.Text = id_citit.ToString();

            string connect = @"Data Source=DESKTOP-08KDD64\SQLEXPRESS;Initial Catalog=ProduseMagazin; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            //////////////////////////////////////////////
            string tabel_date="select * from Produse where id="+txtID.Text;
            SqlCommand sc=new SqlCommand(tabel_date, conn);
            SqlDataReader dr = sc.ExecuteReader();
            if(dr.Read())
            {
                txttipProdus.Text = dr["tip_produs"].ToString();
                txtRaion.Text = dr["raion"].ToString();
            }
            conn.Close();
            //////////////////////////////////////////////
            conn.Open();
            tabel_date = "select * from InfoProduse where id="+txtID.Text;
            SqlDataAdapter da= new SqlDataAdapter(tabel_date, conn);
            DataSet ds=new DataSet();
            da.Fill(ds, "InfoProduse");
            dGWInforProd.DataSource = ds.Tables["InfoProduse"].DefaultView;
            conn.Close();
            ///////////////////////////////////////////////
            AfisareImagini();
        }

        private void AfisareImagini() 
        {
            PictureBox pb;
            int index = 0;

            fLPInformatii.Controls.Clear();
            string connect = @"Data Source=DESKTOP-08KDD64\SQLEXPRESS;Initial Catalog=ProduseMagazin; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            string tabel_date = "select * from ImaginiProduse2 where id=" + txtID.Text;
            SqlCommand sc= new SqlCommand(tabel_date,conn);
            SqlDataReader dr = sc.ExecuteReader();
            while(dr.Read())
            {
                string poza = dr["cale_imagine"].ToString();
                string cale_poza = @"D:\poze\" + poza;
                pb=new PictureBox();
                pb.Name = "Picture" + index.ToString();
                pb.SetBounds(0, 0, 90, 70);
                pb.BackColor = Color.White;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Image=Bitmap.FromFile(cale_poza);
                pb.Tag = index++;
                fLPInformatii.Controls.Add(pb);
                pb.Click += Pb_Click;
            }
            conn.Close( );
            sc.Dispose( ); 
            dr.Close( );
        }

        private void Pb_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pBoxPoze.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxPoze.Image = pic.Image;
            pic.BorderStyle = BorderStyle.Fixed3D;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
