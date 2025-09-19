using Dominio.Entidades;
using Repositorio.Implementaciones;
using Repositorio.Interfaces;
using Ut_presentacion.Nucleo;

namespace Ut_presentacion.Aplicacion
{
    [TestClass]
    public class EditorialesPrueba
    {
        private readonly IEditorialesAplicacion? iAplicacion;
        private readonly IConexion? iConexion;
        private List<Editoriales>? lista;
        private Editoriales? entidad;

        public EditorialesPrueba()
        {
            iConexion = new Conexion();
            iConexion.StringConexion = Configuracion.ObtenerValor("StringConexion");
            iAplicacion = new EditorialesAplicacion(iConexion);
        }

        [TestMethod]
        public void Ejecutar()
        {
            Assert.AreEqual(true, Guardar());
            Assert.AreEqual(true, Modificar());
            Assert.AreEqual(true, Listar());
            Assert.AreEqual(true, Borrar());
        }

        public bool Listar()
        {
            this.lista = this.iAplicacion!.Listar();
            return lista.Count > 0;
        }

        public bool Guardar()
        {
            this.entidad = EntidadesNucleo.Editoriales()!;
            this.iAplicacion!.Guardar(this.entidad);
            return true;
        }

        public bool Modificar()
        {
            this.entidad!.Nombre_Editorial = "EditorialPruebaModificada";
            this.iAplicacion!.Modificar(this.entidad);
            return true;
        }

        public bool Borrar()
        {
            this.iAplicacion!.Borrar(this.entidad);
            return true;
        }
    }
}
