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
    public partial class FormDanhgia : Form
    {
        string id_gv;
        Models.HVKL myHvkl;
        public FormDanhgia()
        {
            InitializeComponent();
            hienthidanhsach();
        }
        public void hienthidanhsach()
        {
            dgvquychuan.DataSource = Models.QuyChuan.getTableQuyChuanKL();
        }
        public FormDanhgia(string id) : this()
        {
            Models.Connection data = new Models.Connection();
            id_gv = id;
            string query = "EXEC dbo. getHocvien '" + id + "'";
            DataTable info = data.getDataSet(query).Tables[0];
            lbmahv.Text = info.Rows[0]["MaHV"].ToString().Trim();
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
                                var i = myHvkl.InsertHVKL();
                                if (i == 0)
                                {
                                    MessageBox.Show("Thêm mới thất bại !");
                                }
                                else
                                {
                                    MessageBox.Show("Thêm mới thành công !");
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

        private void txtkqkl_Click(object sender, EventArgs e)
        {
            txtkqkl.DataSource = Models.HVKL.getmahvrl();
            txtkqkl.DisplayMember = "MaPLKL";
        }
    }
}
