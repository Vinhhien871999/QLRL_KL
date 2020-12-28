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
        public FormDanhgia()
        {
            InitializeComponent();
        }
        public FormDanhgia(string id) : this()
        {
            Models.Connection data = new Models.Connection();
            id_gv = id;
            string query = "EXEC dbo. getHocvien '" + id + "'";
            DataTable info = data.getDataSet(query).Tables[0];
            lbmahv.Text = info.Rows[0]["MaHV"].ToString().Trim();
        }
    }
}
