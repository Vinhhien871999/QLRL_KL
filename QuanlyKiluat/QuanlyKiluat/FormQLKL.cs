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
    public partial class FormQLKL : Form
    {
        public FormQLKL()
        {
            InitializeComponent();
        }
        private void AbrirFormEnPanel(object Formijo)
        {
            if (this.panelmain.Controls.Count > 0)
                this.panelmain.Controls.RemoveAt(0);
            Form fh = Formijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelmain.Controls.Add(fh);
            this.panelmain.Tag = fh;
            fh.Show();
        }
        private void btndanggia_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormNhapketqua());
        }
    }
}
