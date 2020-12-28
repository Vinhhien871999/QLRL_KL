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
    public partial class FormThemKQ : Form
    {
        string id_gv;
        Models.HVRL mygvrl;
        public FormThemKQ()
        {
            InitializeComponent();
            hienthidanhsach();
            
        }
        public void hienthidanhsach()
        {
            dgvquychuan.DataSource = Models.QuyChuan.getTableQuyChuanRL();
        }
        public FormThemKQ(string id) : this()
        {
            Models.Connection data = new Models.Connection();
            id_gv = id;
            string query = "EXEC dbo. getHocvien '" + id + "'";
            DataTable info = data.getDataSet(query).Tables[0];  
            lbmahv.Text = info.Rows[0]["MaHV"].ToString().Trim();
        }

        private void FormThemKQ_Load(object sender, EventArgs e)
        {

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
                                var i = mygvrl.InsertHVRL();
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

        private void txtkqrl_Click(object sender, EventArgs e)
        {
            txtkqrl.DataSource = Models.HVRL.getmahvrl();
            txtkqrl.DisplayMember = "MaPLRL";
        }
    }
}
