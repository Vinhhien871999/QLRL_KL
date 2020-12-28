using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanlyKiluat
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void qlrenluyentheluc_click(object sender, EventArgs e)
        {

        }

        private void qlrenluyenkyluat_click(object sender, EventArgs e)
        {

        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            var db = new Quanlykiluat1Entities();
            chart1.DataSource = db.getPLRL_DaiDoi_2().ToList();
            chart1.Series["soluong"].XValueMember = "TenPLRL";
            chart1.Series["soluong"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart1.Series["soluong"].YValueMembers = "Soluong";
            chart1.Series["soluong"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chart3.DataBindCrossTable(db.getPLRL_Lop(), "TenPLRL", "TenLop", "Soluong", "");
            var table = db.getPLKL_DaiDoi_2();

            table.ToList().ForEach(r => {
                chart2.Series[0].Points.AddXY(r.TenPLKL, r.Soluong);
            });

            chart4.DataBindCrossTable(db.getPLKL_Lop().ToList(), "TenPLKL", "TenLop", "Soluong", "");
        }
    }
}
