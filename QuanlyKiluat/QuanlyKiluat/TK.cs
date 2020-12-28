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
            chart1.DataSource = db.getPLKL_DaiDoi_2().ToList();
            chart1.Series[0].XValueMember = "TenPLRL";
            chart1.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
        }
    }
}
