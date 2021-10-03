using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    interface IFinalizados
    {
        void Suscribirse(Usuario observador);
        void Dar_de_Baja(Usuario observador);
        void Notificar(Producto oProducto);
    }
}
