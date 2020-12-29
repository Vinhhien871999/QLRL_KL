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
    public partial class TK : Form
    {
        public TK()
        {
            InitializeComponent();
        }

        private void TK_Load(object sender, EventArgs e)
        {
            var db = new Quanlykiluat1Entities();
            var table = db.getPLRL_DaiDoi_2().ToList();
            chart1.DataSource = table;
            chart1.Series[0].XValueMember = "TenPLRL";
            chart1.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart1.Series[0].YValueMembers = "Soluong";
            chart1.Series[0].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            chart2.DataSource = db.getPLKL_DaiDoi();
            chart2.Series[0].XValueMember = "TenPLKL";
            chart2.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart2.Series[0].YValueMembers = "Soluong";
            chart2.Series[0].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
        }
    }
}
