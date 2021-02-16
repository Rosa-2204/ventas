using BL.Rentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Rentas
{
    public partial class FormLogin : Form
    {
        SeguridadBL _seguridad;
        string usuario = "Rosa";
        string contra = "123"; 
 

        public FormLogin()
        {
            InitializeComponent();

            _seguridad = new SeguridadBL();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resultado = _seguridad.Autorizar(usuario, contra);
            if ((textBox1.Text != usuario || textBox2.Text != contra))
            {
                if (resultado == true)
               
                {
                    MessageBox.Show("Usuario Incorrecto");
                    textBox1.Clear();
                    textBox1.Focus();
                    return;
                }
                if (textBox2.Text != contra)
                {
                    MessageBox.Show("Contraseña Incorrecta");
                    textBox2.Clear();
                    textBox2.Focus();
                    return;
                }
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("Bienvenido, usuario de Airline");
                FormMenu Form = new FormMenu();
                Form.ShowDialog();

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
