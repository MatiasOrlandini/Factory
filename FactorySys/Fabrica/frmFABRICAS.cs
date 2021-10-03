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
    public partial class frmFABRICAS : Form
    {
        public static frmFABRICAS instancia;
        public static frmFABRICAS OBTENER_INSTANCIA(Modelo.Usuario miUSUARIO)
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmFABRICAS(miUSUARIO);
            }
            return instancia;
        }
        Controladora.OrdenesFabricacion cOF;
        Modelo.Usuario oUsuario;
        public frmFABRICAS(Modelo.Usuario miUSUARIO)
        {
            InitializeComponent();
            cOF = Controladora.OrdenesFabricacion.OBTENER_INSTANCIA();
            oUsuario = miUSUARIO;
            ARMAR_GRILLA();
            APAGAR_BOTONES();
            ARMA_MENU();
        }
        public void ARMA_MENU()
        {
            foreach (var oGrupo in oUsuario.GRUPO)
            {
                foreach (var oPermiso in oGrupo.PERMISOS.ToList())
                {
                    if (oPermiso.DESCRIPCION.Contains("Fabrica"))
                    {
                        switch (oPermiso.CODIGO_ACCION)
                        {                                                      
                            case 1:
                                btnMODIFICAR.Enabled = true;
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                break;
                            default:
                                MessageBox.Show("Error en permiso");
                                break;
                        }
                    }
                }
            }
        }
        public void APAGAR_BOTONES()
        {
            btnMODIFICAR.Enabled = false;
        }
        public void ARMAR_GRILLA()
        {
            dgvOF.DataSource = null;
            dgvOF.DataSource = cOF.LISTAR_OF_FABRICA();
        }
        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvOF.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una Orden de Fabricación", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmFABRICA abrir = new frmFABRICA(cOF.BUSCAR_OF(Convert.ToInt32(dgvOF.CurrentRow.Cells[0].Value)),oUsuario);
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ARMAR_GRILLA();
            }
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
