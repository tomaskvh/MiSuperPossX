using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Lib
{
    public class DataManagment
    {
        private string rutaAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public bool appDataExists;
        public DataManagment() 
        {
            string rutaData = rutaAppData + "/MiSuperPossX/";

            if (!Directory.Exists(rutaData)) 
            { 
                createAppData();  
                appDataExists = true;
            }
            appDataExists = true;
        }

        private void createAppData() // Crea carpeta en AppData
        {

            /*
            # Estructura de carpetas de AppData:
               :: Libros
                   ::: Ventas
                   ::: Anulaciones
                   ::: Resumens
               :: Data
                   ::: Usuarios
                   ::: Temp
                   ::: Cierres
               :: Logs
                   ::: Crash

            */


            string rutaData = rutaAppData + "/MiSuperPossX/"; // Obtiene la ruta de la carpeta del poss

            List<Carpeta> carpetas;
            Carpeta libros = new Carpeta()
            {
                CarpetaPrincipal = "Libros",
                SubCarpetas = ["Ventas", "Anulaciones", "Resumens"]
            };
            Carpeta data = new Carpeta()
            {
                CarpetaPrincipal = "Data",
                SubCarpetas = ["Usuarios", "Temp", "Cierres"]
            };
            Carpeta crashHandle = new Carpeta()
            {
                CarpetaPrincipal = "Logs",
                SubCarpetas = ["Crash"]
            };

            carpetas = [libros, data, crashHandle];

            Directory.CreateDirectory(rutaData);

            foreach (Carpeta c in carpetas)
            {
                string newFolder = rutaData + c.CarpetaPrincipal;
                Directory.CreateDirectory(newFolder);
                List<String> f = c.SubCarpetas;
                foreach (String x in f)
                {
                    String path = newFolder + "/" + x;
                    Directory.CreateDirectory(path);
                }
            }

        }
    }

    internal class Carpeta
    {
        public string CarpetaPrincipal {  get; set; }
        public List<String> SubCarpetas { get; set; }
    }
}
