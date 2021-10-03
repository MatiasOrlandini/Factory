using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorySys
{
    public partial class frmMANUAL : Form
    {

        public static frmMANUAL instancia;
        public static frmMANUAL OBTENER_INSTANCIA()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmMANUAL();
            }
            return instancia;
        }
        public frmMANUAL()
        {
            InitializeComponent();
        }
    }
}
