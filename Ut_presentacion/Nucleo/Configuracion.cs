using Dominio.Nucleo;

namespace Ut_presentacion.Nucleo
{
    public class Configuracion
    {
        private static Dictionary<string, string>? datos = null;

        public static string ObtenerValor(string clave)
        {
            if (datos == null)
                Cargar();

            if (datos == null)
                throw new InvalidOperationException("No se pudo cargar la configuración. Verifique el archivo de configuración.");

            if (!datos.ContainsKey(clave))
                throw new KeyNotFoundException($"La clave '{clave}' no existe en la configuración.");

            return datos[clave];
        }

        public static void Cargar()
        {
            if (!File.Exists(DatosGenerales.ruta_json))
            {
                datos = null;
                return;
            }

            var json = File.ReadAllText(DatosGenerales.ruta_json);
            datos = JsonConversor.ConvertirAObjeto<Dictionary<string, string>>(json);
        }
    }
}