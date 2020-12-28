﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyKiluat
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxuser_Enter(object sender, EventArgs e)
        {
            if (textBoxuser.Text == "UsersName")
            {
                textBoxuser.Text = "";
                textBoxuser.ForeColor = Color.Black;
            }
        }

        private void textBoxuser_Leave(object sender, EventArgs e)
        {
            if (textBoxuser.Text == "")
            {
                textBoxuser.Text = "UsersName";
                textBoxuser.ForeColor = Color.Black;
            }
        }

        private void textBoxpass_Enter(object sender, EventArgs e)
        {
            if (textBoxpass.Text == "PassWord")
            {
                textBoxpass.Text = "";
                textBoxpass.ForeColor = Color.Black;
                textBoxpass.UseSystemPasswordChar = true;
            }
        }

        private void textBoxpass_Leave(object sender, EventArgs e)
        {
            if (textBoxpass.Text == "")
            {
                textBoxpass.Text = "PassWord";
                textBoxpass.ForeColor = Color.Black;
                textBoxpass.UseSystemPasswordChar = false;
            }
        }
        void QLDD(string maNV)
        {
            QuanlyKiluat.Form1 nv = new QuanlyKiluat.Form1(maNV);
            this.Hide();
            nv.Show();
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            Button login = sender as Button;
            //List<List<string>> SV = Models.SinhVien.getMaSV();
            List<List<string>> NV = Models.QLDD.getMaQL();
            string maDN = textBoxuser.Text;
            string matKhau = textBoxpass.Text;
            //if (SV[0].Contains(maDN.ToUpper()) && SV[1][SV[0].IndexOf(maDN.ToUpper())] == matKhau)
            //{
            //    SinhVien(maDN);
            //}
            //else 
            if (NV[0].Contains(maDN.ToUpper()) && NV[1][NV[0].IndexOf(maDN.ToUpper())] == matKhau)
            {
                QLDD(maDN);
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
