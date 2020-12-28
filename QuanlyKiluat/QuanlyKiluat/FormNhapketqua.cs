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
    public partial class FormNhapketqua : Form
    {
        public FormNhapketqua()
        {
            InitializeComponent();
            hienthiketqua();
        }
        public void hienthiketqua()
        {
            dgvcntt1.DataSource = Models.Lop.getTableLop();
        }
        private void shownhapthongtin(object sender, EventArgs e)
        {
            int pos = dgvcntt1.SelectedRows[0].Index;
            DataGridViewRow temp = this.dgvcntt1.Rows[pos];
            string id = temp.Cells[0].Value.ToString().Trim();
            QuanlyKiluat.FormLop tai = new QuanlyKiluat.FormLop(id);
            tai.ShowDialog();
        }

        private void dgvcntt1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                ContextMenu cm = new ContextMenu();

                ContextMenu cmHeader = new ContextMenu();
                int currentMouseOverRow = dgvcntt1.HitTest(e.X, e.Y).RowIndex;
                int currentMouseOverCol = dgvcntt1.HitTest(e.X, e.Y).ColumnIndex;

                if (currentMouseOverRow >= 0)
                {
                    if (dgvcntt1.Rows[currentMouseOverRow].Selected == true)
                    {
                        MenuItem itemTaiNCKH = new MenuItem();
                        itemTaiNCKH.Text = "Thông Tin";

                        cm.MenuItems.Add(itemTaiNCKH);
                        itemTaiNCKH.Click += shownhapthongtin;
                        cm.Show(dgvcntt1, new Point(e.X, e.Y));

                    }
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
