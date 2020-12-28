using System;
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
    public partial class FormHVDGKL : Form
    {
        Models.Hocvien myHv;
        Models.HVKL myhvkl;
        public FormHVDGKL(string MaHv)
        {
            myHv = Models.Hocvien.getmaHv(MaHv);
            InitializeComponent();
            lbmahv.Text = myHv.MaHV1;
            txtcdg.Enabled = false;
            hienthidanhsach();
            txtndg.Text = myHv.Malop1;
        }
        public void hienthidanhsach()
        {
            dgvchinhsuarl.DataSource = Models.HVKL.gettablephaihvplkl(myHv.MaHV1);
        }
        string convertToDateSQL(string dateC)
        {
            string result;
            string date = dateC.Split(' ')[0];
            var X = date.Split('/');
            result = X[2] + "-" + X[1] + "-" + X[0];
            return result;
        }
        void btnReload()
        {
            btnSVSua.Visible = btnSVXoa.Visible =
                btnSVThem.Visible = !btnSVSua.Visible;
            btnSVHuy.Visible = btnSVLuu.Visible = !btnSVLuu.Visible;
        }
        public void end()
        {
            txtdkl.Enabled = txthdd.Enabled = txtht.Enabled = txtkqkl.Enabled = txtls.Enabled = txtndg.Enabled = false;
        }
        public void unend()
        {
            txtdkl.Enabled = txthdd.Enabled = txtht.Enabled = txtkqkl.Enabled = txtls.Enabled = txtndg.Enabled = true;
        }

        private void btnSVThem_Click(object sender, EventArgs e)
        {
            btnSVLuu.Tag = "Them";
            btnSVHuy.Tag = "Them";
            btnReload();
            unend();
            
        }

        private void btnSVLuu_Click(object sender, EventArgs e)
        {
            if (btnSVLuu.Tag.ToString() == "Them")
            {
                string thoigian = convertToDateSQL(dtpthoigian.Value.ToString("dd/MM/yyy"));
                myhvkl = new Models.HVKL(lbhvkl.Text, thoigian, lbmahv.Text, txtkqkl.Text, txtcdg.Text
                    , txtndg.Text, txtdkl.Text, txtht.Text,
                    txtls.Text, txthdd.Text);
                var i = myhvkl.InsertHVKL();
                if (i == 0)
                {
                    MessageBox.Show("Thêm mới thất bại !");
                }
                else
                {
                    MessageBox.Show("Thêm mới thành công !");
                    hienthidanhsach();

                }
            }
            if (btnSVLuu.Tag.ToString() == "Sua")
            {
                string thoigian = convertToDateSQL(dtpthoigian.Value.ToString("dd/MM/yyy"));
                myhvkl = new Models.HVKL(lbhvkl.Text, thoigian, lbmahv.Text, txtkqkl.Text, txtcdg.Text
                    , txtndg.Text, txtdkl.Text, txtht.Text,
                    txtls.Text, txthdd.Text);
                var i = myhvkl.UpdateHVKL();
                if (i == 0)
                {
                    MessageBox.Show("Sửa mới thất bại !");
                }
                else
                {
                    MessageBox.Show("Sửa mới thành công !");
                    hienthidanhsach();
                }
            }
        }

        private void btnSVSua_Click(object sender, EventArgs e)
        {
            btnReload();
            btnSVLuu.Tag = "Sua";
            btnSVHuy.Tag = "Sua";
            unend();
        }

        private void btnSVHuy_Click(object sender, EventArgs e)
        {
            btnReload();
            end();
        }

        private void btnSVXoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
