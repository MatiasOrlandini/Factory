using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace FactorySys
{
    public partial class frmBACKUP : Form
    {
        public frmBACKUP()
        {
            InitializeComponent();
        }
        string folder;
        string comando_consulta;
        SqlConnection connection = new SqlConnection(@"SERVER=DESKTOP-CAP34IG\SQLEXPRESS;DATABASE=Modelo.Fabrica;integrated security=True");

        private void btnRUTA_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            folder = folderBrowserDialog1.SelectedPath;
            txtDESTINO.Text = folder;
        }

        private void btnGENERAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(folder))
            {
                string path = (@"C:\Users\Naza\Desktop\mati");
                if (!Directory.Exists(path))
                {
                    DirectoryInfo di = Directory.CreateDirectory(@"C:\Users\Naza\Desktop\mati");
                }             
                comando_consulta = (@"BACKUP DATABASE[Modelo.Fabrica] TO DISK = N'"+ path + @"\ModeloFabrica.bak' WITH NOFORMAT, NOINIT, NAME = N'Modelo.Fabrica-Completa Base de datos Copia de seguridad', SKIP, NOREWIND, NOUNLOAD,  STATS = 10");
                MessageBox.Show(@"Ustéd no selecciono ningun destino, se generará uan ruta automatica en: 'C:\Users\Naza\Desktop\mati\ModeloFabrica'.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GENERAR();
            }
            else
            {
                comando_consulta = (@"BACKUP DATABASE [ModeloFabrica] TO  DISK = N'" + folder + " ' WITH NOFORMAT, NOINIT,  NAME = N'Modelo.Fabrica-Completa Base de datos Copia de seguridad', SKIP, NOREWIND, NOUNLOAD,  STATS = 10");
                GENERAR();
            }                                      
        }
        private void GENERAR()
        {
            SqlCommand cmd = new SqlCommand(comando_consulta, connection);
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Copia de seguridad creada satisfactoriamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Cierre el formulario e intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
        }
    }
}
