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
    
    public partial class FormChinhsuaKL : Form
    {
        Models.HVKL myHvkl;
        public FormChinhsuaKL()
        {
            InitializeComponent();
            hienthidanhsach();
        }
        public void hienthidanhsach()
        {
            dgvchinhsuarl.DataSource = Models.HVKL.gettableplkl();
        }
        private void FormChinhsuaKL_Load(object sender, EventArgs e)
        {

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
        string convertToDateSQL(string dateC)
        {
            string result;
            string date = dateC.Split(' ')[0];
            var X = date.Split('/');
            result = X[2] + "-" + X[1] + "-" + X[0];
            return result;
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            string _Maplkl = "";
            try
            {
                _Maplkl = txtkqkl.Text;
            }
            catch { }
            string _NgaySinh = convertToDateSQL(dtpthoigian.Value.ToString("dd/MM/yyy"));

            string _Capdanhgia = "";
            try
            {
                _Capdanhgia = txtcdg.Text;
            }
            catch { }
            string _Nguoidanhgia = "";
            try
            {
                _Nguoidanhgia = txtndg.Text;
            }
            catch { }
            string _Diemkiluat = "";
            try
            {
                _Diemkiluat = txtdkl.Text;
            }
            catch { }
            string _Diemhoctap = "";
            try
            {
                _Diemhoctap = txtht.Text;
            }
            catch { }
            string _Diemloisong = "";
            try
            {
                _Diemloisong = txtls.Text;
            }
            catch { }
            string _Diemhoatdongdoan = "";
            try
            {
                _Diemhoatdongdoan = txthdd.Text;
            }
            catch { }
            if (txtdkl.Text != "")
            {
                if (txtht.Text != "")
                {
                    if (txtls.Text != "")
                    {
                        if (txthdd.Text != "")
                        {
                            if (txthdd.Text != "")
                            {
                                string thoigian = convertToDateSQL(dtpthoigian.Value.ToString("dd/MM/yyy"));
                                myHvkl = new Models.HVKL(lbhvkl.Text, thoigian, lbmahv.Text, txtkqkl.Text, txtcdg.Text
                                    , txtndg.Text, txtdkl.Text, txtht.Text,
                                    txtls.Text, txthdd.Text);
                                var i = myHvkl.UpdateHVKL();
                                if (i == 0)
                                {
                                    MessageBox.Show("Sửa mới thất bại !");
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Sửa mới thành công !");
                                    this.Close();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
