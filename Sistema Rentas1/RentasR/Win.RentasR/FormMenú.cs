using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.RentasR
{
    public partial class FormMenú : Form
    {
        public FormMenú()
        {
            InitializeComponent();
        }

        private void vUELOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void registrarVueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formRegistrarVuelo = new FormRegistrarVuelo();
            formRegistrarVuelo.MdiParent = this;
            formRegistrarVuelo.Show();
        }

        private void FormMenú_Load(object sender, EventArgs e)
        {
            Login();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
