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
    public partial class Form1 : Form
    {
        Models.QLDD myQL;
        public Form1(string MaQL)
        {
            myQL = Models.QLDD.getMaQL(MaQL);
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void hideSubmenu()
        {
            if (pnQLKL.Visible == true)
            {
                pnQLKL.Visible = false;
            }
        }
        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        private void btnKL_Click(object sender, EventArgs e)
        {
            showSubmenu(pnQLKL);
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
        private void btnQLTL_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormQLRL());
        }

        private void btndaidoi_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormQLKL());
        }
    }
}
