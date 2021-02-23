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

namespace Win.Rentas1
{
    public partial class FormRegistrarVuelo : Form
    {
        Registrar_VueloBL _vuelos;

        public FormRegistrarVuelo()
        {
            InitializeComponent();

            _vuelos = new Registrar_VueloBL();
            listaRegistrarVueloBindingSource.DataSource = _vuelos.ObtenerRegistarVuelo();
        }

        private void listaRegistrarVueloBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaRegistrarVueloBindingSource.EndEdit();
            var vuelo = (RegistrarVuelo)listaRegistrarVueloBindingSource.Current;

            var resultado = _vuelos.GuardarVuelo(vuelo);

            if (resultado.Exitoso == true)
            {
                listaRegistrarVueloBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _vuelos.AgregarVuelo();
            listaRegistrarVueloBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            

            if (idVueloTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var Id = Convert.ToInt32(idVueloTextBox.Text);
                    Eliminar(Id);
                }
 
            }
        }

        private void Eliminar(int Id)
        {
            var resultado = _vuelos.EliminarVuelo(Id);

            if (resultado == true)
            {
                listaRegistrarVueloBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el registro");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            Eliminar(0);
        }
    }
}
