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
    public partial class FormChinhsuaRl : Form
    {
        Models.HVRL mygvrl;
        public FormChinhsuaRl()
        {
            InitializeComponent();
            hienthidanhsach();
        }
        public void hienthidanhsach()
        {
            dgvchinhsuarl.DataSource = Models.HVRL.gettableplrl();
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
            string _Maplrl = "";
            try
            {
                _Maplrl = txtkqrl.Text;
            }
            catch { }
            string _NgaySinh = convertToDateSQL(dtpthoigian.Value.ToString("dd/MM/yyy"));

            string _MaGS = "";
            try
            {
                _MaGS = txtgs.Text;
            }
            catch { }
            string _Boi = "";
            try
            {
                _Boi = txtboi.Text;
            }
            catch { }
            string _chaydai = "";
            try
            {
                _chaydai = txtchaydai.Text;
            }
            catch { }
            string _chayngan = "";
            try
            {
                _chayngan = txtchayngan.Text;
            }
            catch { }
            string _xa = "";
            try
            {
                _xa = txtxa.Text;
            }
            catch { }
            string _nhayxa = "";
            try
            {
                _nhayxa = txtnhayxa.Text;
            }
            catch { }
            if (txtboi.Text != "")
            {
                if (txtchaydai.Text != "")
                {
                    if (txtchayngan.Text != "")
                    {
                        if (txtnhayxa.Text != "")
                        {
                            if (txtxa.Text != "")
                            {
                                string thoigian = convertToDateSQL(dtpthoigian.Value.ToString("dd/MM/yyy"));
                                mygvrl = new Models.HVRL(lbhvrl.Text, thoigian, lbmahv.Text, txtkqrl.Text, txtgs.Text
                                    , txtboi.Text, txtchaydai.Text, txtchayngan.Text,
                                    txtnhayxa.Text, txtxa.Text);
                                var i = mygvrl.UpdateHVRL();
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

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void SearchByKey(string query, string value)
        {

            query = query + "N'%" + value + "%'";
            DataTable data = Models.Connection.SeachInDataBase(query);
            if (data.Rows.Count == 0) MessageBox.Show("Không Tìm Thấy");
            else dgvchinhsuarl.DataSource = data;
        }
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string GiaTri = cbbhv.GetItemText(this.cbbhv.SelectedItem).Trim();

            string keyRow = txthv.Text;
            if (GiaTri == "" || keyRow == "")
            {
                MessageBox.Show("Chưa Có Thông Tin Cần Tìm");
            }
            else
            {

                string query = "";
                //set value of query if valuaCol change 
                if (GiaTri == "MaHV") query = "Select * from Hocvien_Phanloairenluyen where MaHV like ";
                SearchByKey(query, keyRow);
            }
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
