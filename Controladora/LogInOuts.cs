using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Controladora
{
    public class LogInOuts
    {
        public static LogInOuts instancia;
        public static LogInOuts OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new LogInOuts();
            }
            return instancia;
        }
        Modelo.Fabrica oFabrica;
        public LogInOuts()
        {
            oFabrica = Modelo.Fabrica.OBTENER_INSTANCIA();
        }
        public void AGREGAR_LOGINOUT(Modelo.LogInOut oLog)
        {
            oFabrica.LOGINOUT.Add(oLog);
            oFabrica.SaveChanges();
        }
        public System.Collections.IEnumerable LISTAR_LOGINOUT(string USUARIO = "")
        {
            var logs = from log in oFabrica.LOGINOUT.Include(a=>a.USUARIO).ToList()
                        where log.USUARIO.NOMBRE.ToLower().Contains(USUARIO.ToLower())
                       select new
                       {
                           CODIGO = log.CODIGO,
                           USUARIO = log.USUARIO,
                           FECHA = log.FECHA,
                           ACCION = log.ACCION
                          };
            return logs.ToList();
        }
    }
}
