using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace International_assigmen
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();

          
            this.Paint += FormAdmin_Paint;
        }

        private void FormAdmin_Paint(object sender, PaintEventArgs e)
        {
            
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(178, 57,78,68),Color.Transparent, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminQaytishBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void HodimQOshishBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHodimQo_shish n = new FormHodimQo_shish();
            n.ShowDialog();
        }
    }
}
