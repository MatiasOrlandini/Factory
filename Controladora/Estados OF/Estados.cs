using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class Estados
    {
        public int Verifica(Modelo.OrdenFabricacion oOF)
        {
            int index = 0;
            if (oOF.LINEA_OF.Count > 0 )
            {
                index = 2;  //en fabricacion
                
            }
            if (oOF.LINEA_OF.Count == 0)
            {
                index = 1;   //para fabricar
            }
            if (oOF.LINEA_OF.Count == oOF.PEDIDO.TAREAS.Count)
            {
                index = 3; //FINALIZADA
            }
            return index;
        }
    }
}
