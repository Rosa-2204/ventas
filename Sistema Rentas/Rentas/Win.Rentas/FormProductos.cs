﻿using BL.Rentas;
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
    public partial class FormProductos : Form

    {
        VueloBL _vuelo;

        public FormProductos()
        {
            InitializeComponent();

            _vuelo = new VueloBL();
            listaVueloBindingSource.DataSource = _vuelo.ObtenerVuelo();
        }
    }
}
