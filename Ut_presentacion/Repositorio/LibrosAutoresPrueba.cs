﻿using Dominio.Entidades;
using Repositorio.Implementaciones;
using Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Ut_presentacion.Nucleo;

namespace ut_presentacion.Repositorios
{
    [TestClass]
    public class LibrosAutoresPrueba
    {
        private readonly IConexion? iConexion;
        private List<LibrosAutores>? lista;
        private LibrosAutores? entidad;

        private Autores? autor;
        private Libros? libro;

        public LibrosAutoresPrueba()
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
            // Crear dependencias de Libro
            var editorial = EntidadesNucleo.Editoriales()!;
            var pais = EntidadesNucleo.Paises()!;
            var tipo = EntidadesNucleo.Tipos()!;

            this.iConexion!.Editoriales!.Add(editorial);
            this.iConexion!.Paises!.Add(pais);
            this.iConexion!.Tipos!.Add(tipo);
            this.iConexion!.SaveChanges();

            // Crear autor
            this.autor = EntidadesNucleo.Autores()!;
            this.iConexion!.Autores!.Add(this.autor);
            this.iConexion!.SaveChanges();

            // Crear libro con ISBN único
            string isbnUnico = "ISBN-" + Guid.NewGuid().ToString("N").Substring(0, 13);
            this.libro = new Libros
            {
                Editorial = editorial.Id,
                Pais = pais.Id,
                Tipo = tipo.Id,
                Isbn = isbnUnico,
                Titulo = "Libro de prueba con autor",
                Edicion = "Primera",
                Fecha_Lanzamiento = DateOnly.FromDateTime(DateTime.Now)
            };
            this.iConexion!.Libros!.Add(this.libro);
            this.iConexion!.SaveChanges();

            // Crear relación LibrosAutores
            this.entidad = new LibrosAutores
            {
                Libro = this.libro.Id,
                Autor = this.autor.Id
            };
            this.iConexion!.LibrosAutores!.Add(this.entidad);
            this.iConexion!.SaveChanges();

            return true;
        }

        public bool Modificar()
        {
            // Crear un nuevo autor y reasignar
            var nuevoAutor = EntidadesNucleo.Autores()!;
            this.iConexion!.Autores!.Add(nuevoAutor);
            this.iConexion!.SaveChanges();

            this.entidad!.Autor = nuevoAutor.Id;

            var entry = this.iConexion!.Entry<LibrosAutores>(this.entidad);
            entry.State = EntityState.Modified;
            this.iConexion!.SaveChanges();

            return true;
        }

        public bool Listar()
        {
            this.lista = this.iConexion!.LibrosAutores!.ToList();
            return lista.Count > 0;
        }

        public bool Borrar()
        {
            this.iConexion!.LibrosAutores!.Remove(this.entidad!);
            this.iConexion!.SaveChanges();
            return true;
        }
    }
}
