using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Modelo
{
    [Table("Usuarios")]
    public class Usuario : IUsuario
    {
        public Usuario()
        {
            GRUPO = new HashSet<Grupo>();
        }
        [Key]
        public Int32 CODIGO_USUARIO { get; set; }
        public string NOMBRE { get; set; }
        public string USUARIO { get; set; }
        public string CONTRASEÑA { get; set; }
        public string EMAIL { get; set; }
        public ICollection<Modelo.Grupo> GRUPO { get; set; }
        public bool PRIMERA { get; set; }
        public void Actualizar(Producto oProducto)
        {
            string PATHLOG = @"C:\Users\MATI\Desktop\FactorySys";
            string LOGTXT = "Finalizados.txt";
            StreamWriter sw;
            string PATHCOMPLETO = PATHLOG + @"\" + LOGTXT;
            var dirInfo = new DirectoryInfo(PATHLOG);
            if (!dirInfo.Exists)
            {
                Directory.CreateDirectory(PATHLOG);
            }
            if (!File.Exists(PATHCOMPLETO))
            {
                sw = File.CreateText(PATHCOMPLETO);
                sw.WriteLine("--------------------------------------------");
                sw.WriteLine("Productos finalizados - " + DateTime.Now.ToString());
                sw.WriteLine("--------------------------------------------");
            }
            else
            {
                sw = File.AppendText(PATHCOMPLETO);
            }
            sw.WriteLine("Cod:" + oProducto.CODIGO + " - " + oProducto.DESCRIPCION + "- FINALIZADO");
            sw.Close();
        }
        public override string ToString()
        {
            return NOMBRE;
        }
    }
}
