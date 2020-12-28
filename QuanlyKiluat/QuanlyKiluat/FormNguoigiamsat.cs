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
    public partial class FormNguoigiamsat : Form
    {
        Models.giamsat mygs;
        public FormNguoigiamsat()
        {
            InitializeComponent();
            hienthidanhsach();
            txtgs.Enabled = false;
            end();
        }
        public void hienthidanhsach()
        {
            dgvgiamsat.DataSource = Models.giamsat.getTableGiamsat();
        }
        public void end()
        {
            txtcapbac.Enabled = false;
            txtchucvu.Enabled = false;
            txttengs.Enabled = false;
        }
        public void unend()
        {
            txtcapbac.Enabled = true;
            txtchucvu.Enabled = true;
            txttengs.Enabled = true;
        }
        private void dgvgiamsat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtgs.Text = dgvgiamsat.Rows[index].Cells["Mags"].Value.ToString();
                txttengs.Text = dgvgiamsat.Rows[index].Cells["Tennguoigiamsat"].Value.ToString();
                txtchucvu.Text = dgvgiamsat.Rows[index].Cells["Chucvu"].Value.ToString();
                txtcapbac.Text = dgvgiamsat.Rows[index].Cells["Capbac"].Value.ToString();
            }
        }
        void btnReload()
        {
            btnSVSua.Visible = btnSVXoa.Visible =
                btnSVThem.Visible = !btnSVSua.Visible;
            btnSVHuy.Visible = btnSVLuu.Visible = !btnSVLuu.Visible;
        }
        private void btnSVThem_Click(object sender, EventArgs e)
        {
            txtgs.Text = "GS" + dgvgiamsat.Rows.Count.ToString("0000");
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
                var db = new Quanlykiluat1Entities();
                var i = db.insert_giamsat(txtgs.Text, txttengs.Text, txtchucvu.Text, txtcapbac.Text);
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
                var db = new Quanlykiluat1Entities();
                var i = db.update_giamsat(txtgs.Text, txttengs.Text, txtchucvu.Text, txtcapbac.Text);
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
            end();
        }

        private void btnSVXoa_Click(object sender, EventArgs e)
        {
            var db = new Quanlykiluat1Entities();
            var i = db.delete_giamsat(txtgs.Text);
            if (i == 0)
            {
                MessageBox.Show("Xóa thất bại !");
            }
            else
            {
                MessageBox.Show("Xóa thành công !");
                hienthidanhsach();
            }
        }
    }
}
