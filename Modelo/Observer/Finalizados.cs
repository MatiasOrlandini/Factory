using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Finalizados : IFinalizados
    {
        private List<Usuario> USUARIOS = new List<Usuario>();
        public List<Producto> PRODUCTOS;
        public Finalizados()
        {
            PRODUCTOS = new List<Producto>();
        }
        public void AGREGAR_PRODUCTO(Producto oProducto)
        {
            PRODUCTOS.Add(oProducto);
            Notificar(oProducto);
        }
        public void Suscribirse(Usuario observador)
        {
            USUARIOS.Add(observador);
        }
        public void Dar_de_Baja(Usuario observador)
        {
            USUARIOS.Remove(observador);
        }

        public void Notificar(Producto oProducto)
        {
            USUARIOS.ForEach(x => x.Actualizar(oProducto)); ;
        }  
    }
}
