﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mental_Care_Programación
{
    public partial class informacion_de_la_prueba_del_tamizaje : Form
    {
        public informacion_de_la_prueba_del_tamizaje()
        {
            InitializeComponent();
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            INFOCITA USUARIO1 = new INFOCITA();
            USUARIO1.Show();
            this.Hide();
        }

        private void txtApe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 126) || (e.KeyChar >= 128 && e.KeyChar <= 255))

            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
