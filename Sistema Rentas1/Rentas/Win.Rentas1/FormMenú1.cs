using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Rentas1
{
    public partial class FormMenú1 : Form
    {
        public FormMenú1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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

        private void FormMenú1_Load(object sender, EventArgs e)
        {
            Login();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
