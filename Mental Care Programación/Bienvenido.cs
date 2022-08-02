using System;
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
    public partial class Bienvenido : Form
    {
        public Bienvenido()
        {
            InitializeComponent();
        }

        private void bttnIngrese_Click(object sender, EventArgs e)
        {
            INFOEAPB USUARIO1 = new INFOEAPB();
            USUARIO1.Show();
            this.Hide();
        }
    }
 }

