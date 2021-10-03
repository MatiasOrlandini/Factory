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
    public partial class frmA_LOGINOUT : Form
    {
        public static frmA_LOGINOUT instancia;
        public static frmA_LOGINOUT OBTENER_INSTANCIA()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmA_LOGINOUT();
            }
            return instancia;
        }
        Controladora.LogInOuts cLog;
        public frmA_LOGINOUT()
        {
            InitializeComponent();
            cLog = Controladora.LogInOuts.OBTENER_INSTANCIA();
            ARMAR_GRILLA("");
        }
        public void ARMAR_GRILLA(string usuario)
        {
            if (usuario == null)
            {
                dgvGRILLA.DataSource = null;
                dgvGRILLA.DataSource = cLog.LISTAR_LOGINOUT();
            }
            else
            {
                dgvGRILLA.DataSource = null;
                dgvGRILLA.DataSource = cLog.LISTAR_LOGINOUT(usuario);
            }
        }

        private void txtUSUARIO_TextChanged(object sender, EventArgs e)
        {
            ARMAR_GRILLA(txtUSUARIO.Text);
        }
    }
}
