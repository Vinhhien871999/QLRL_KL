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
    public partial class FormHocvienDanhgia : Form
    {
        Models.Hocvien myHv;
        public FormHocvienDanhgia(string MaHv)
        {
            myHv = Models.Hocvien.getmaHv(MaHv);
            InitializeComponent();
            lblop.Text = myHv.Malop1;
            WindowState = FormWindowState.Maximized;
        }
        private void AbrirFormEnPanel(object Formijo)
        {
            if (this.pnMain.Controls.Count > 0)
                this.pnMain.Controls.RemoveAt(0);
            Form fh = Formijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnMain.Controls.Add(fh);
            this.pnMain.Tag = fh;
            fh.Show();
        }

        private void btnQl_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormHVDGKL(myHv.MaHV1));
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
