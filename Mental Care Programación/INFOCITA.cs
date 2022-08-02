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
    public partial class INFOCITA : Form
    {
        public INFOCITA()
        {
            InitializeComponent();
        }

        private void lblINFORMACIÓNDELAEAPB_Click(object sender, EventArgs e)
        {

        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            INFORMULA USUARIO1 = new INFORMULA();
            USUARIO1.Show();
            this.Hide();
        }
    }
}
