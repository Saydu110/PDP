using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace International_assigmen
{
    public partial class FormAdminLogin : Form
    {
        public FormAdminLogin()
        {
            InitializeComponent();
        }

        private void KirishBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=CrudCRUD;Integrated Security=True"))
                {
                    con.Open();
                    string query = "SELECT * FROM roll WHERE login = @login AND password = @password";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@login", AdminLoginTxt.Text);
                    cmd.Parameters.AddWithValue("@password", AdminPasswordTxt.Text);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        this.Hide();
                        FormAdmin formAdmin = new FormAdmin();
                        formAdmin.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Login or Password Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
