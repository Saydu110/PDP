using System;
using System.Drawing;
using System.Windows.Forms;


namespace International_assigmen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdminLogin formAdmin = new FormAdminLogin();
            formAdmin.ShowDialog();
        }

        private void UserBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUserLogin formUserLogin = new FormUserLogin();
            formUserLogin.ShowDialog();
        }
    }
}
