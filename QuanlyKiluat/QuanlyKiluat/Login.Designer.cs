namespace QuanlyKiluat
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btndangnhap = new System.Windows.Forms.Button();
            this.panelpass = new System.Windows.Forms.Panel();
            this.textBoxpass = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxuser = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Iberrormessage = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // btndangnhap
            // 
            this.btndangnhap.BackColor = System.Drawing.Color.Black;
            this.btndangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.ForeColor = System.Drawing.Color.White;
            this.btndangnhap.Location = new System.Drawing.Point(268, 344);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(283, 67);
            this.btndangnhap.TabIndex = 43;
            this.btndangnhap.Text = "Đăng Nhập";
            this.btndangnhap.UseVisualStyleBackColor = false;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // panelpass
            // 
            this.panelpass.BackColor = System.Drawing.Color.Black;
            this.panelpass.Location = new System.Drawing.Point(147, 250);
            this.panelpass.Name = "panelpass";
            this.panelpass.Size = new System.Drawing.Size(517, 1);
            this.panelpass.TabIndex = 38;
            // 
            // textBoxpass
            // 
            this.textBoxpass.BackColor = System.Drawing.Color.White;
            this.textBoxpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpass.ForeColor = System.Drawing.Color.Black;
            this.textBoxpass.HideSelection = false;
            this.textBoxpass.Location = new System.Drawing.Point(244, 205);
            this.textBoxpass.Name = "textBoxpass";
            this.textBoxpass.Size = new System.Drawing.Size(390, 27);
            this.textBoxpass.TabIndex = 37;
            this.textBoxpass.TabStop = false;
            this.textBoxpass.Text = "PassWord";
            this.textBoxpass.Enter += new System.EventHandler(this.textBoxpass_Enter);
            this.textBoxpass.Leave += new System.EventHandler(this.textBoxpass_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(147, 158);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(517, 1);
            this.panel3.TabIndex = 41;
            // 
            // textBoxuser
            // 
            this.textBoxuser.BackColor = System.Drawing.Color.White;
            this.textBoxuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxuser.ForeColor = System.Drawing.Color.Black;
            this.textBoxuser.HideSelection = false;
            this.textBoxuser.Location = new System.Drawing.Point(244, 113);
            this.textBoxuser.Name = "textBoxuser";
            this.textBoxuser.Size = new System.Drawing.Size(390, 27);
            this.textBoxuser.TabIndex = 39;
            this.textBoxuser.TabStop = false;
            this.textBoxuser.Text = "UsersName";
            this.textBoxuser.Enter += new System.EventHandler(this.textBoxuser_Enter);
            this.textBoxuser.Leave += new System.EventHandler(this.textBoxuser_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(751, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Iberrormessage
            // 
            this.Iberrormessage.AutoSize = true;
            this.Iberrormessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iberrormessage.ForeColor = System.Drawing.Color.Black;
            this.Iberrormessage.Image = ((System.Drawing.Image)(resources.GetObject("Iberrormessage.Image")));
            this.Iberrormessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Iberrormessage.Location = new System.Drawing.Point(142, 280);
            this.Iberrormessage.Name = "Iberrormessage";
            this.Iberrormessage.Size = new System.Drawing.Size(140, 25);
            this.Iberrormessage.TabIndex = 42;
            this.Iberrormessage.Text = "Error Massage";
            this.Iberrormessage.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(147, 194);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(147, 102);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(53, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 40;
            this.pictureBox7.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.Iberrormessage);
            this.Controls.Add(this.panelpass);
            this.Controls.Add(this.textBoxpass);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBoxuser);
            this.Controls.Add(this.pictureBox7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Label Iberrormessage;
        private System.Windows.Forms.Panel panelpass;
        private System.Windows.Forms.TextBox textBoxpass;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxuser;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}