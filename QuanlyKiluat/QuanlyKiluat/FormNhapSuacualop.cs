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
    
    public partial class FormNhapSuacualop : Form
    {
        Models.HVRL myHvRl;
        public FormNhapSuacualop(string id)
        {
            InitializeComponent();
            hienthidanhsach();
        }
        public void hienthidanhsach()
        {
            dgvchinhsuarl.DataSource = Models.HVRL.gettableplrl();
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
        private void btnSVThem_Click(object sender, EventArgs e)
        {
            btnSVLuu.Tag = "Them";
            btnSVHuy.Tag = "Them";
            btnReload();
        }

        private void btnSVSua_Click(object sender, EventArgs e)
        {
            btnReload();
            btnSVLuu.Tag = "Sua";
            btnSVHuy.Tag = "Sua";
        }

        private void btnSVLuu_Click(object sender, EventArgs e)
        {
            if (btnSVLuu.Tag.ToString() == "Them")
            {
                string thoigian = convertToDateSQL(dtpthoigian.Value.ToString("dd/MM/yyy"));
                myHvRl = new Models.HVRL(lbhvrl.Text, thoigian, lbmahv.Text, txtkqrl.Text, txtgs.Text
                    , txtboi.Text, txtchaydai.Text, txtchayngan.Text,
                    txtnhayxa.Text, txtxa.Text);
                var i = myHvRl.InsertHVRL();
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
                myHvRl = new Models.HVRL(lbhvrl.Text, thoigian, lbmahv.Text, txtkqrl.Text, txtgs.Text
                    , txtboi.Text, txtchaydai.Text, txtchayngan.Text,
                    txtnhayxa.Text, txtxa.Text);
                var i = myHvRl.UpdateHVRL();
                if (i == 0)
                {
                    MessageBox.Show("Sửa thất bại !");
                }
                else
                {
                    MessageBox.Show("Sửa thành công !");
                    hienthidanhsach();
                }
            }
        }

        private void btnSVHuy_Click(object sender, EventArgs e)
        {
            btnReload();
        }

        private void btnSVXoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvchinhsuarl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                lbhvrl.Text = dgvchinhsuarl.Rows[index].Cells["Mahv_plrl"].Value.ToString();
                lbmahv.Text = dgvchinhsuarl.Rows[index].Cells["MaHV"].Value.ToString();
                dtpthoigian.Text = dgvchinhsuarl.Rows[index].Cells["Thoigian"].Value.ToString();
                txtkqrl.Text = dgvchinhsuarl.Rows[index].Cells["MaPLRL"].Value.ToString();
                txtgs.Text = dgvchinhsuarl.Rows[index].Cells["MaGS"].Value.ToString();
                txtboi.Text = dgvchinhsuarl.Rows[index].Cells["Boi"].Value.ToString();
                txtchaydai.Text = dgvchinhsuarl.Rows[index].Cells["Chaydai"].Value.ToString();
                txtchayngan.Text = dgvchinhsuarl.Rows[index].Cells["Chayngan"].Value.ToString();
                txtnhayxa.Text = dgvchinhsuarl.Rows[index].Cells["nhayxa"].Value.ToString();
                txtxa.Text = dgvchinhsuarl.Rows[index].Cells["Xa"].Value.ToString();
            }
        }
    }
}
