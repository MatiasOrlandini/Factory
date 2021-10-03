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
    public partial class frmFABRICA : Form
    {
        public Modelo.Finalizados Finalizados = new Modelo.Finalizados();
        Modelo.LineaOrdenFabricación oLinea_Fabricacion;
        List<Modelo.LineaOrdenFabricación> Lista_Fabricacion;
        Controladora.OrdenesFabricacion cOF;
        Modelo.OrdenFabricacion oOF;
        Controladora.Estados cEstado;
        Modelo.A_OrdenF oA_OrdenF;
        Modelo.Usuario oUsuario;
        Controladora.A_OrdenF cA_OF;
        int Numero_Tareas;
        int Tareas_realizadas;
        public frmFABRICA(Modelo.OrdenFabricacion miORDEN, Modelo.Usuario miUSUARIO)
        {
            InitializeComponent();
            cOF = Controladora.OrdenesFabricacion.OBTENER_INSTANCIA();
            cA_OF = Controladora.A_OrdenF.OBTENER_INSTANCIA();
            cEstado = new Controladora.Estados();
            oOF = miORDEN;
            oUsuario = miUSUARIO;

            Finalizados.Suscribirse(oUsuario);
            cmbTAREAS.DataSource = oOF.PEDIDO.TAREAS.ToList();
            cmbTAREAS.DisplayMember = "NOMBRE";
            cmbESTADO.DataSource = cOF.LISTAR_ESTADOS();
            cmbESTADO.DisplayMember = "NOMBRE";
            cmbESTADO.SelectedItem = oOF.ESTADO;

            ARMAR_LINEA_FABRICACION();
            Lista_Fabricacion = oOF.LINEA_OF.ToList();
            Numero_Tareas = oOF.PEDIDO.TAREAS.Count;
            Tareas_realizadas = dgvLINEA_FABRICACION.RowCount;
            if (oOF.ESTADO.NOMBRE == "FINALIZADA")
            {
                btnAGREGAR_PROCESO.Enabled = false;
                btnELIMINAR_PROCESO.Enabled = false;
                return;
            }
            if (dgvLINEA_FABRICACION.RowCount > 0)
            {
                cmbTAREAS.SelectedIndex = Tareas_realizadas;
            }            
        }
        public void ARMAR_LINEA_FABRICACION()
        {
            dgvLINEA_FABRICACION.DataSource = null;
            dgvLINEA_FABRICACION.DataSource = oOF.LINEA_OF.ToList();
            dgvLINEA_FABRICACION.Columns[3].Width = 350;
            dgvLINEA_FABRICACION.Columns[1].Visible = false;
        }
        private void btnAGREGAR_PROCESO_Click(object sender, EventArgs e)
        {
            try
            {       
                oLinea_Fabricacion = new Modelo.LineaOrdenFabricación();
                oLinea_Fabricacion.TAREA = (Modelo.Tarea)cmbTAREAS.SelectedItem;
                oLinea_Fabricacion.DETALLE = txtDETALLE.Text;
                oOF.LINEA_OF.Add(oLinea_Fabricacion);
                AUDITAR("ALTA", oLinea_Fabricacion);
                ARMAR_LINEA_FABRICACION();
                
                Tareas_realizadas++;
                cmbTAREAS.SelectedIndex = Tareas_realizadas;
                Estado();
            }
            catch (Exception)
            {
                Estado();
                btnAGREGAR_PROCESO.Enabled = false;
                return;
            }           
        }
        private void btnELIMINAR_PROCESO_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (dgvLINEA_FABRICACION.RowCount == 0)
                {
                    MessageBox.Show("No se encuentran lineas.", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (dgvLINEA_FABRICACION.CurrentRow.Index != (dgvLINEA_FABRICACION.RowCount - 1))
                {
                    MessageBox.Show("Solo es posible eliminar la última tarea.", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                oLinea_Fabricacion = (Modelo.LineaOrdenFabricación)dgvLINEA_FABRICACION.CurrentRow.DataBoundItem;
                oOF.LINEA_OF.Remove(oLinea_Fabricacion);
                AUDITAR("BAJA", oLinea_Fabricacion);
                ARMAR_LINEA_FABRICACION();
                
                Tareas_realizadas--;
                cmbTAREAS.SelectedIndex = Tareas_realizadas;
                Estado();
                if (Tareas_realizadas > 0)
                {
                    btnAGREGAR_PROCESO.Enabled = true;
                }

            }
            catch (Exception)
            {
                btnELIMINAR_PROCESO.Enabled = false;
                Estado();
                return;              
            }         
        }
        private void Estado()
        {
            cmbESTADO.SelectedIndex = cEstado.Verifica(oOF);
            oOF.ESTADO = (Modelo.Estado)cmbESTADO.SelectedItem;
        }

        private void frmFABRICA_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (oOF.ESTADO.NOMBRE == "FINALIZADA")
            {
                foreach (var oLinea in oOF.PEDIDO.LINEA_PEDIDO.ToList())
                {
                    for (int i = 0; i < oLinea.CANTIDAD; i++)
                    {
                        Finalizados.AGREGAR_PRODUCTO(oLinea.PRODUCTO);
                    }                    
                }
                
            }
            cOF.MODIFICAR_OF(oOF);
            DialogResult = DialogResult.OK;
        }
        private void AUDITAR(string accion, Modelo.LineaOrdenFabricación oLinea)
        {
            oA_OrdenF = new Modelo.A_OrdenF();
            oA_OrdenF.CODIGO_OF = oOF.CODIGO_OF;
            oA_OrdenF.FECHA = DateTime.Now;
            oA_OrdenF.NOMBRE = oUsuario.NOMBRE;
            if (accion == "ALTA")
            {
                oA_OrdenF.ACCION = "ALTA";
            }
            else
            {
                oA_OrdenF.ACCION = "BAJA";
            }
            oA_OrdenF.TAREA = oLinea.TAREA.NOMBRE;
            cA_OF.AGREGAR_A_OF(oA_OrdenF);         
        }
    }
}
