using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numero_letras
{
    public partial class frmEmisiondeCheque : Form
    {
        public frmEmisiondeCheque()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //UTILS.NumerosLetras.TestUnidades();
            int num = Int32.Parse(this.txtResultado.Text);
            this.txtResultado.Text = UTILS.NumerosLetras.getUnidades(num);
        }
    }
}
