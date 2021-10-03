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
    public partial class frmOFS : Form
    {
        public static frmOFS instancia;
        public static frmOFS OBTENER_INSTANCIA(Modelo.Usuario miUSUARIO)
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmOFS(miUSUARIO);
            }
            return instancia;
        }
        Modelo.Usuario oUsuario;
        Controladora.OrdenesFabricacion cOF;
        Controladora.Pedidos cPedido;
        public frmOFS(Modelo.Usuario miUSUARIO)
        {
            InitializeComponent();
            oUsuario = miUSUARIO;
            cOF = Controladora.OrdenesFabricacion.OBTENER_INSTANCIA();
            cPedido = Controladora.Pedidos.OBTENER_INSTANCIA();
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
                    if (oPermiso.DESCRIPCION.Contains("OrdenF"))
                    {
                        switch (oPermiso.CODIGO_ACCION)
                        {
                            case 1:
                                btnAGREGAR.Enabled = true;
                                break;
                            case 2:
                                btnELIMINAR.Enabled = true;
                                break;
                            case 3:
                                btnMODIFICAR.Enabled = true;
                                break;
                            case 4:
                                btnVERIFICAR.Enabled = true;
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
            btnAGREGAR.Enabled = false;
            btnELIMINAR.Enabled = false;
            btnMODIFICAR.Enabled = false;
            btnVERIFICAR.Enabled = false;
        }
        public void ARMAR_GRILLA()
        {
            dgvOF.DataSource = null;
            dgvOF.DataSource = cOF.LISTAR_OF();
        }
        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            frmOF abrir = new frmOF(new Modelo.OrdenFabricacion(),"A", oUsuario);
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ARMAR_GRILLA();
            }
        }
        private void btnSALIR_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            cPedido = Controladora.Pedidos.OBTENER_INSTANCIA();
            if (dgvOF.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una Orden de Fabricacion", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Modelo.OrdenFabricacion oOF = cOF.BUSCAR_OF(Convert.ToInt32(dgvOF.CurrentRow.Cells[0].Value));
            /**if (oOF.ESTADO.NOMBRE == "EN FABRICACION" || oOF.ESTADO.NOMBRE == "FINALIZADA")
            {
                MessageBox.Show("No es posible eliminar una Orden que posea estado 'EN FABRICACION' o 'FINALIZADA'", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/
            DialogResult pregunta = MessageBox.Show("Desea dar de baja la Orden de compra con codigo: " + " " + oOF.CODIGO_OF + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pregunta == DialogResult.Yes)
            {
                Modelo.Pedido oPedido;
                oPedido = oOF.PEDIDO;
                oPedido.ESTADO = "SIN ASIGNAR";
                cPedido.MODIFICAR_PEDIDO(oPedido);
                cOF.ELIMINAR_OF(oOF);
                ARMAR_GRILLA();
            }
        }
        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvOF.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una Orden de Fabricacion", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmOF abrir = new frmOF(cOF.BUSCAR_OF(Convert.ToInt32(dgvOF.CurrentRow.Cells[0].Value)), "M", oUsuario);
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ARMAR_GRILLA();
            }
        }

        private void btnVERIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvOF.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una Orden de Fabricacion", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Modelo.OrdenFabricacion oOF;
            oOF = cOF.BUSCAR_OF(Convert.ToInt32(dgvOF.CurrentRow.Cells[0].Value));
            if (oOF.ESTADO.NOMBRE == "PARA FABRICAR" || oOF.ESTADO.NOMBRE == "EN FABRICACION" || oOF.ESTADO.NOMBRE == "FINALIZADA")
            {
                MessageBox.Show("No es posible verificar una orden que posee estado 'Para Fabricar','En Fabricacion o 'Finalizada'.", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Antes de enviar la orden a Fábrica, debe verificar que esté todo correcto.","Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            frmOF abrir = new frmOF(oOF, "V", oUsuario);
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ARMAR_GRILLA();
            }
        }
    }
}
