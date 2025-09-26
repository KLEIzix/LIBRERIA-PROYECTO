using Dominio.Entidades;
using Repositorio.Implementaciones;
using Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ut_presentacion.Nucleo;

namespace ut_presentacion.Aplicacion
{
    
    [TestClass]
    public class EstadosExistenciasPrueba
    {
        private readonly IEstadosExistenciasAplicacion? iAplicacion;
        private readonly IConexion? iConexion;
        private List<EstadosExistencias>? lista;
        private EstadosExistencias? entidad;
        
        public EstadosExistenciasPrueba()
        {
            iConexion = new Conexion();
            iConexion.StringConexion = Configuracion.ObtenerValor("StringConexion");
            iAplicacion = new EstadosExistenciasAplicacion(iConexion);
        }
    }
}
