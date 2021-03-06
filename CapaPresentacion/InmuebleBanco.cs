﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class InmuebleBanco : Form
    {
        InmuebleBancoMostrarBanco mostrarBanco;
        InmuebleBancoRegistrarBanco registrarBanco;
        public InmuebleBanco()
        {
            InitializeComponent();
        }

        
    
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (registrarBanco == null)
            {
                registrarBanco = new InmuebleBancoRegistrarBanco(this);
            }
            this.Hide();
            registrarBanco.Show();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (mostrarBanco == null)
            {
                mostrarBanco = new InmuebleBancoMostrarBanco(this);
            }
            this.Hide();
            mostrarBanco.Abrir();
        }
    }
}
