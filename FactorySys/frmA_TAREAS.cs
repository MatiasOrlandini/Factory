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
    public partial class frmA_TAREAS : Form
    {
        public static frmA_TAREAS instancia;
        public static frmA_TAREAS OBTENER_INSTANCIA()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmA_TAREAS();
            }
            return instancia;
        }
        Controladora.A_OrdenF cA_OrdenF;
        public frmA_TAREAS()
        {
            InitializeComponent();
            cA_OrdenF = Controladora.A_OrdenF.OBTENER_INSTANCIA();
            ARMAR_GRILLA();
        }
        public void ARMAR_GRILLA()
        {
            dgvGRILLA.DataSource = null;
            dgvGRILLA.DataSource = cA_OrdenF.LISTAR_A_OF(txtACCION.Text, txtTAREA.Text,txtUSER.Text);
                
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ARMAR_GRILLA();
        }
    }
}
