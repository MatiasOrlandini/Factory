using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("A_OrdenF")]
    public class A_OrdenF
    {
        [Key]
        public Int32 CODIGO { get; set; }
        public string NOMBRE { get; set; } //TODO: cambiar a nombre del usuario
        public DateTime FECHA { get; set; }
        public string ACCION { get; set; }
        //INSUMO
        public Int32 CODIGO_OF { get; set; }
        public string TAREA { get; set; }
    }
}
