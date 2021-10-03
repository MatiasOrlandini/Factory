using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
     
    public class A_OrdenF
    {
        public static A_OrdenF instancia;
        public static A_OrdenF OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new A_OrdenF();
            }
            return instancia;
        }
        Modelo.Auditoria oAuditoria;
        public A_OrdenF()
        {
            oAuditoria = Modelo.Auditoria.OBTENER_INSTANCIA();
        }
        public void AGREGAR_A_OF(Modelo.A_OrdenF oA_OrdenF)
        {
            oAuditoria.A_ORDENF.Add(oA_OrdenF);
            oAuditoria.SaveChanges();
        }
        public System.Collections.IEnumerable LISTAR_A_OF()
        {
                var ordenes = from orden in oAuditoria.A_ORDENF.ToList()
                              select new
                              {
                                  CODIGO = orden.CODIGO,
                                  USUARIO = orden.NOMBRE,
                                  FECHA = orden.FECHA,   
                                  ACCION = orden.ACCION,
                                  TAREA = orden.TAREA,
                                  ORDEN = orden.CODIGO_OF
                              };
                return ordenes.ToList();
        }
        public System.Collections.IEnumerable LISTAR_A_OF( string accion = "", string tarea = "", string usuario = "")
        {
            var ordenes = from orden in oAuditoria.A_ORDENF.ToList()
                          where (orden.NOMBRE.ToLower().Contains(usuario.ToLower()) && (orden.ACCION.ToLower().Contains(accion.ToLower())) &&(orden.TAREA.ToLower().Contains(tarea.ToLower())))
                          select new
                          {
                              CODIGO = orden.CODIGO,
                              USUARIO = orden.NOMBRE,
                              FECHA = orden.FECHA,
                              ACCION = orden.ACCION,
                              TAREA = orden.TAREA,
                              ORDEN = orden.CODIGO_OF
                          };
            return ordenes.ToList();
        }
    }
}
