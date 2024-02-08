namespace International_assigmen
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AdminBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UserBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(95, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 276);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::International_assigmen.Properties.Resources.image_removebg_preview__6_;
            this.pictureBox2.Location = new System.Drawing.Point(99, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(295, 139);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.Controls.Add(this.AdminBtn);
            this.panel2.Location = new System.Drawing.Point(95, 398);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 71);
            this.panel2.TabIndex = 2;
            // 
            // AdminBtn
            // 
            this.AdminBtn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold);
            this.AdminBtn.Location = new System.Drawing.Point(22, 20);
            this.AdminBtn.Name = "AdminBtn";
            this.AdminBtn.Size = new System.Drawing.Size(156, 33);
            this.AdminBtn.TabIndex = 0;
            this.AdminBtn.Text = "ADMIN";
            this.AdminBtn.UseVisualStyleBackColor = true;
            this.AdminBtn.Click += new System.EventHandler(this.AdminBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Bisque;
            this.panel3.Controls.Add(this.UserBtn);
            this.panel3.Location = new System.Drawing.Point(312, 398);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 71);
            this.panel3.TabIndex = 3;
            // 
            // UserBtn
            // 
            this.UserBtn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold);
            this.UserBtn.Location = new System.Drawing.Point(21, 20);
            this.UserBtn.Name = "UserBtn";
            this.UserBtn.Size = new System.Drawing.Size(156, 33);
            this.UserBtn.TabIndex = 1;
            this.UserBtn.Text = "USER";
            this.UserBtn.UseVisualStyleBackColor = true;
            this.UserBtn.Click += new System.EventHandler(this.UserBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::International_assigmen.Properties.Resources.Снимок_экрана_2024_02_05_210443;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(834, 561);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button AdminBtn;
        private System.Windows.Forms.Button UserBtn;
    }
}

