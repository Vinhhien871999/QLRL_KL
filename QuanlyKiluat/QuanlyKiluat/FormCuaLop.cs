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
    public partial class FormCuaLop : Form
    {
        Models.Lop myLop;
        public FormCuaLop(string Malop)
        {
            myLop = Models.Lop.getLop(Malop);
            InitializeComponent();
            lblop.Text = myLop.Tenlop1;
            WindowState = FormWindowState.Maximized;
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
            AbrirFormEnPanel(new FormRLcualop(myLop.MaLop1));
        }
    }
}
