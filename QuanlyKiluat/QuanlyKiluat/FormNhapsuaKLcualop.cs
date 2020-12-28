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
    public partial class FormNhapsuaKLcualop : Form
    {
        Models.HVKL myhvkl;
        string id_gv;
        public FormNhapsuaKLcualop()
        {
            InitializeComponent();
            end();
            hienthidanhsach();
        }
        public FormNhapsuaKLcualop(string id) : this()
        {
            Models.Connection data = new Models.Connection();
            id_gv = id;
            string query = "EXEC dbo. getHocvien '" + id + "'";
            DataTable info = data.getDataSet(query).Tables[0];
            lbmahv.Text = info.Rows[0]["MaHV"].ToString().Trim();
            dgvchinhsuarl.DataSource = Models.HVKL.gettablehvplkl(info.Rows[0]["MaHV"].ToString().Trim());
        }
        private void FormNhapsuaKLcualop_Load(object sender, EventArgs e)
        {

        }
        public void hienthidanhsach()
        {
            //dgvchinhsuarl.DataSource = Models.HVKL.gettablehvplrl(lbmahv.Text);
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
            txtcdg.Enabled = txtdkl.Enabled = txthdd.Enabled = txtht.Enabled = txtkqkl.Enabled = txtls.Enabled = txtndg.Enabled = false;
        }
        public void unend()
        {
            txtcdg.Enabled = txtdkl.Enabled = txthdd.Enabled = txtht.Enabled = txtkqkl.Enabled = txtls.Enabled = txtndg.Enabled = true;
        }
        private void btnSVThem_Click(object sender, EventArgs e)
        {
            btnSVLuu.Tag = "Them";
            btnSVHuy.Tag = "Them";
            btnReload();
            unend();
        }

        private void btnSVSua_Click(object sender, EventArgs e)
        {
            btnReload();
            btnSVLuu.Tag = "Sua";
            btnSVHuy.Tag = "Sua";
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

        private void btnSVXoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSVHuy_Click(object sender, EventArgs e)
        {
            btnReload();
            end();
        }

        private void dgvchinhsuarl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                lbhvkl.Text = dgvchinhsuarl.Rows[index].Cells["Mahv_plkl"].Value.ToString();
                lbmahv.Text = dgvchinhsuarl.Rows[index].Cells["MaHV"].Value.ToString();
                dtpthoigian.Text = dgvchinhsuarl.Rows[index].Cells["Thoigian"].Value.ToString();
                txtkqkl.Text = dgvchinhsuarl.Rows[index].Cells["MaPLKL"].Value.ToString();
                txtcdg.Text = dgvchinhsuarl.Rows[index].Cells["Capdanhgia"].Value.ToString();
                txtndg.Text = dgvchinhsuarl.Rows[index].Cells["Nguoidanhgia"].Value.ToString();
                txtls.Text = dgvchinhsuarl.Rows[index].Cells["Diemloisong"].Value.ToString();
                txtht.Text = dgvchinhsuarl.Rows[index].Cells["Diemhoctap"].Value.ToString();
                txtdkl.Text = dgvchinhsuarl.Rows[index].Cells["Diemkiluat"].Value.ToString();
                txthdd.Text = dgvchinhsuarl.Rows[index].Cells["Diemhoatdongdoan"].Value.ToString();
            }
        }
    }
}
