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
    public partial class FormLop : Form
    {
        string id_gv;
        public FormLop()
        {
            InitializeComponent();
        }
        public FormLop(string id) : this()
        {
            Models.Connection data = new Models.Connection();
            id_gv = id;
            string query = "EXEC dbo. spgetTableHVLop '" + id + "'";
            dgvlop.DataSource = data.getDataSet(query).Tables[0];
            DataTable info = data.getDataSet(query).Tables[0];
            lbLop.Text = info.Rows[0]["Tenlop"].ToString().Trim();          
        }

        private void dgvlop_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                ContextMenu cm = new ContextMenu();

                ContextMenu cmHeader = new ContextMenu();
                int currentMouseOverRow = dgvlop.HitTest(e.X, e.Y).RowIndex;
                int currentMouseOverCol = dgvlop.HitTest(e.X, e.Y).ColumnIndex;

                if (currentMouseOverRow >= 0)
                {
                    if (dgvlop.Rows[currentMouseOverRow].Selected == true)
                    {
                        MenuItem itemTaiNCKH = new MenuItem();
                        itemTaiNCKH.Text = "Rèn Luyện";
                        MenuItem itemTaiHVKL = new MenuItem();
                        itemTaiHVKL.Text = "Kỉ Luật";

                        cm.MenuItems.Add(itemTaiNCKH);
                        cm.MenuItems.Add(itemTaiHVKL);
                        itemTaiNCKH.Click += shownhapthongtin;
                        itemTaiHVKL.Click += shownhapthongtinKL;
                        cm.Show(dgvlop, new Point(e.X, e.Y));

                    }
                }

            }
        }
        private void shownhapthongtin(object sender, EventArgs e)
        {
            int pos = dgvlop.SelectedRows[0].Index;
            DataGridViewRow temp = this.dgvlop.Rows[pos];
            string id = temp.Cells[0].Value.ToString().Trim();
            QuanlyKiluat.FormThemKQ tai = new QuanlyKiluat.FormThemKQ(id);
            tai.ShowDialog();
        }
        private void shownhapthongtinKL(object sender, EventArgs e)
        {
            int pos = dgvlop.SelectedRows[0].Index;
            DataGridViewRow temp = this.dgvlop.Rows[pos];
            string id = temp.Cells[0].Value.ToString().Trim();
            QuanlyKiluat.FormDanhgia tai = new QuanlyKiluat.FormDanhgia(id);
            tai.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
