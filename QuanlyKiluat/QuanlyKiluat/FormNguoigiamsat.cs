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
        public FormNguoigiamsat()
        {
            InitializeComponent();
            hienthidanhsach();
            txtgs.Enabled = false;
        }
        public void hienthidanhsach()
        {
            dgvgiamsat.DataSource = Models.giamsat.getTableGiamsat();
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
        }

        private void btnSVSua_Click(object sender, EventArgs e)
        {
            btnReload();
            btnSVLuu.Tag = "Sua";
            btnSVHuy.Tag = "Sua";
        }

        private void btnSVLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
