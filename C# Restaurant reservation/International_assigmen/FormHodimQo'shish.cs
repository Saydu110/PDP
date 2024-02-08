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
    public partial class FormHodimQo_shish : Form
    {
        public FormHodimQo_shish()
        {
            InitializeComponent();
        }

        private void ADD_btn_Click(object sender, EventArgs e)
        {
            
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=CrudCRUD;Integrated Security=True"))
                    {
                        conn.Open();

                        string query = "INSERT INTO roll VALUES (@login, @password)";

                        SqlCommand cmd = new SqlCommand(query, conn);

                        cmd.Parameters.AddWithValue("@Id", ID_Txt.Text);
                        cmd.Parameters.AddWithValue("@login", LoginUserADDTxt.Text);
                        cmd.Parameters.AddWithValue("@password", PasswordUserADDTxt.Text);

                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
        }
    }
}
