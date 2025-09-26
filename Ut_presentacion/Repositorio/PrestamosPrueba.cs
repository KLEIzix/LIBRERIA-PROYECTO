using System;
using System.Collections.Generic;
using Dominio.Entidades;
using Repositorio.Implementaciones;
using Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ut_presentacion.Nucleo;

namespace Ut_presentacion.Repositorios
{
    [TestClass]
    public class PrestamosPrueba
    {
        private readonly IConexion? iConexion;

        // Entidades usadas durante la prueba (campos para poder borrarlas en Borrar())
        private List<Prestamos>? lista;
        private Prestamos? entidad;

        private Usuarios? usuario;
        private Existencias? existencia;
        private TiposPrestamos? tipoPrestamo;

        private Editoriales? editorial;
        private Paises? pais;
        private Tipos? tipoLibro;
        private Libros? libro;
        private Estados? estado;
        private EstadosExistencias? estadosExistencia;

        public PrestamosPrueba()
        {
            iConexion = new Conexion();
            iConexion.StringConexion = Configuracion.ObtenerValor("StringConexion");
        }

        [TestMethod]
        public void Ejecutar()
        {
            Assert.IsTrue(Guardar());
            Assert.IsTrue(Modificar());
            Assert.IsTrue(Listar());
            Assert.IsTrue(Borrar());
        }

        public bool Guardar()
        {
            // Dependencias
            this.usuario = EntidadesNucleo.Usuarios()!;
            this.tipoPrestamo = EntidadesNucleo.TiposPrestamos()!;
            var estado = EntidadesNucleo.Estados()!;

            iConexion!.Usuarios!.Add(this.usuario);
            iConexion.TiposPrestamos!.Add(this.tipoPrestamo);
            iConexion.Estados!.Add(estado);
            iConexion.SaveChanges();

            // Crear libro
            var editorial = EntidadesNucleo.Editoriales()!;
            var pais = EntidadesNucleo.Paises()!;
            var tipo = EntidadesNucleo.Tipos()!;
            iConexion.Editoriales!.Add(editorial);
            iConexion.Paises!.Add(pais);
            iConexion.Tipos!.Add(tipo);
            iConexion.SaveChanges();

            var libro = EntidadesNucleo.Libros(editorial, pais, tipo)!;
            iConexion.Libros!.Add(libro);
            iConexion.SaveChanges();

            // Crear existencia
            this.existencia = EntidadesNucleo.Existencias(libro)!;
            iConexion.Existencias!.Add(this.existencia);
            iConexion.SaveChanges();

            // Crear estado de existencia (relación)
            var estadoExistencia = EntidadesNucleo.EstadosExistencias(this.existencia, estado)!;
            iConexion.EstadosExistencias!.Add(estadoExistencia);
            iConexion.SaveChanges();

            // Crear préstamo
            this.entidad = EntidadesNucleo.Prestamos(this.usuario, this.existencia, this.tipoPrestamo)!;
            iConexion.Prestamos!.Add(this.entidad);
            iConexion.SaveChanges();

            return true;
        }

        public bool Modificar()
        {
            if (this.entidad == null) return false;

            this.entidad.Fecha_Devolucion = DateOnly.FromDateTime(DateTime.Now.AddDays(10));
            var entry = iConexion!.Entry<Prestamos>(this.entidad);
            entry.State = EntityState.Modified;
            iConexion.SaveChanges();
            return true;
        }

        public bool Listar()
        {
            this.lista = iConexion!.Prestamos!.ToList();
            return lista.Count > 0;
        }

        public bool Borrar()
        {
            // Borrado en orden seguro para respetar FK
            if (this.entidad != null)
            {
                iConexion!.Prestamos!.Remove(this.entidad);
                iConexion.SaveChanges();
            }

            if (this.estadosExistencia != null)
            {
                iConexion!.EstadosExistencias!.Remove(this.estadosExistencia);
                iConexion.SaveChanges();
            }

            if (this.existencia != null)
            {
                iConexion!.Existencias!.Remove(this.existencia);
                iConexion.SaveChanges();
            }

            if (this.libro != null)
            {
                iConexion!.Libros!.Remove(this.libro);
                iConexion.SaveChanges();
            }

            if (this.estado != null)
            {
                iConexion!.Estados!.Remove(this.estado);
                iConexion.SaveChanges();
            }

            if (this.editorial != null)
            {
                iConexion!.Editoriales!.Remove(this.editorial);
                iConexion.SaveChanges();
            }

            if (this.pais != null)
            {
                iConexion!.Paises!.Remove(this.pais);
                iConexion.SaveChanges();
            }

            if (this.tipoLibro != null)
            {
                iConexion!.Tipos!.Remove(this.tipoLibro);
                iConexion.SaveChanges();
            }

            if (this.usuario != null)
            {
                iConexion!.Usuarios!.Remove(this.usuario);
                iConexion.SaveChanges();
            }

            if (this.tipoPrestamo != null)
            {
                iConexion!.TiposPrestamos!.Remove(this.tipoPrestamo);
                iConexion.SaveChanges();
            }

            return true;
        }
    }
}