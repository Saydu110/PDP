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

namespace International_assigmen
{
    public partial class FormUserLogin : Form
    {
        public FormUserLogin()
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
                    string query = "SELECT * FROM UserTab WHERE login = @login AND password = @password";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@login", LoginUserTxt.Text);
                    cmd.Parameters.AddWithValue("@password", PasswordUserTxt.Text);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        this.Hide();
                       FormUserBron formUserBron = new FormUserBron();
                       formUserBron.ShowDialog();
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
