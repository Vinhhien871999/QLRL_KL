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
    public partial class FormRLcualop : Form
    {
        string id_gv;
        public FormRLcualop(string id)
        {
            InitializeComponent();
            Models.Connection data = new Models.Connection();
            id_gv = id;
            string query = "EXEC dbo. spgetTableHVLop '" + id + "'";
            dgvHv.DataSource = data.getDataSet(query).Tables[0];
        }

        private void dgvHv_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                ContextMenu cm = new ContextMenu();

                ContextMenu cmHeader = new ContextMenu();
                int currentMouseOverRow = dgvHv.HitTest(e.X, e.Y).RowIndex;
                int currentMouseOverCol = dgvHv.HitTest(e.X, e.Y).ColumnIndex;

                if (currentMouseOverRow >= 0)
                {
                    if (dgvHv.Rows[currentMouseOverRow].Selected == true)
                    {
                        MenuItem itemTaiNCKH = new MenuItem();
                        itemTaiNCKH.Text = "Rèn Luyện";
                        MenuItem itemTaiHVKL = new MenuItem();
                        itemTaiHVKL.Text = "Kỉ Luật";

                        cm.MenuItems.Add(itemTaiNCKH);
                        cm.MenuItems.Add(itemTaiHVKL);
                        itemTaiNCKH.Click += shownhapthongtin;
                        itemTaiHVKL.Click += shownhapthongtinKL;
                        cm.Show(dgvHv, new Point(e.X, e.Y));

                    }
                }

            }
        }
        private void shownhapthongtin(object sender, EventArgs e)
        {
            int pos = dgvHv.SelectedRows[0].Index;
            DataGridViewRow temp = this.dgvHv.Rows[pos];
            string id = temp.Cells[0].Value.ToString().Trim();
            QuanlyKiluat.FormNhapSuacualop tai = new QuanlyKiluat.FormNhapSuacualop(id);
            tai.ShowDialog();
        }
        private void shownhapthongtinKL(object sender, EventArgs e)
        {
            int pos = dgvHv.SelectedRows[0].Index;
            DataGridViewRow temp = this.dgvHv.Rows[pos];
            string id = temp.Cells[0].Value.ToString().Trim();
            QuanlyKiluat.FormNhapsuaKLcualop tai = new QuanlyKiluat.FormNhapsuaKLcualop(id);
            tai.ShowDialog();
        }
    }
}
