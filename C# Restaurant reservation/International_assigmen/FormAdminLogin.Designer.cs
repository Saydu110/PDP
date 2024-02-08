namespace International_assigmen
{
    partial class FormAdminLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AdminLoginTxt = new System.Windows.Forms.TextBox();
            this.AdminPasswordTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.KirishBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 22.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(274, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 22.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(219, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // AdminLoginTxt
            // 
            this.AdminLoginTxt.Location = new System.Drawing.Point(422, 164);
            this.AdminLoginTxt.Multiline = true;
            this.AdminLoginTxt.Name = "AdminLoginTxt";
            this.AdminLoginTxt.Size = new System.Drawing.Size(236, 35);
            this.AdminLoginTxt.TabIndex = 3;
            // 
            // AdminPasswordTxt
            // 
            this.AdminPasswordTxt.Location = new System.Drawing.Point(422, 242);
            this.AdminPasswordTxt.Multiline = true;
            this.AdminPasswordTxt.Name = "AdminPasswordTxt";
            this.AdminPasswordTxt.Size = new System.Drawing.Size(236, 35);
            this.AdminPasswordTxt.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(195, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 72);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Rockwell", 18.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "ADMIN PANEL";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.PeachPuff;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Image = global::International_assigmen.Properties.Resources.AdminLogin;
            this.pictureBox2.Location = new System.Drawing.Point(0, 357);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(834, 204);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::International_assigmen.Properties.Resources.image_removebg_preview__7_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // KirishBtn
            // 
            this.KirishBtn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold);
            this.KirishBtn.Location = new System.Drawing.Point(656, 303);
            this.KirishBtn.Name = "KirishBtn";
            this.KirishBtn.Size = new System.Drawing.Size(154, 35);
            this.KirishBtn.TabIndex = 7;
            this.KirishBtn.Text = "Kirish";
            this.KirishBtn.UseVisualStyleBackColor = true;
            this.KirishBtn.Click += new System.EventHandler(this.KirishBtn_Click);
            // 
            // FormAdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.KirishBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AdminPasswordTxt);
            this.Controls.Add(this.AdminLoginTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormAdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAdminLogin";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AdminLoginTxt;
        private System.Windows.Forms.TextBox AdminPasswordTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button KirishBtn;
    }
}