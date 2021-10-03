using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Usuario_Contraseña_Vacios()
        {
            Controladora.Facade cFacade = Controladora.Facade.OBTENER_INSTANCIA();
            string usuario = "";
            string contraseña = "";
            Modelo.Usuario oUsuario = cFacade.BUSCAR(usuario, contraseña);
        }
        [TestMethod]
        public void Usuario_Contraseña_Incorrectos()
        {
            Controladora.Facade cFacade = Controladora.Facade.OBTENER_INSTANCIA();
            string usuario = "admin";
            string contraseña = "1234123";
            Modelo.Usuario oUsuario = cFacade.BUSCAR(usuario, contraseña);
        }
        [TestMethod]
        public void Usuario_Contraseña_Correcto()
        {
            Controladora.Facade cFacade = Controladora.Facade.OBTENER_INSTANCIA();
            string usuario = "admin";
            string contraseña = "admin";
            Modelo.Usuario oUsuario = cFacade.BUSCAR(usuario, contraseña);
        }
    }
}
