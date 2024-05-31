using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestionareProduseMagazin
{
    public partial class Stergere : Form
    {
        private const string connectionString = "Data Source=DESKTOP-08KDD64\\SQLEXPRESS;Initial Catalog=ProduseMagazin; Integrated Security=True";

        public Stergere()
        {
            InitializeComponent();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(txtTara.Text);
            
            if (id > 100)
            {
                MessageBox.Show("Introduceți un id valid.");
                return;
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string deleteProdusQuery = "DELETE FROM Produse WHERE id = @Country";
                            SqlCommand deleteProdusCommand = new SqlCommand(deleteProdusQuery, connection, transaction);
                            deleteProdusCommand.Parameters.AddWithValue("@Country", id);
                            int flightsDeleted = deleteProdusCommand.ExecuteNonQuery();

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("A apărut o eroare în timpul ștergerii: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o eroare: " + ex.Message);
            }
        }

        private void Stergere_Load(object sender, EventArgs e)
        {

        }
    }
}