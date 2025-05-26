using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Modelo
{
    // Clase base para la creación de libros maestros de datos
    public class BaseModelMBook
    {
        public string ID { get; set; } // ID del libro creado
        public string creationDate { get; set; } // Fecha de apertura libro
        public string closingDate { get; set; } // Fecha de cierre libro
        public bool IsOpen { get; set; } // ¿Esta abierto el libro? V/F
        public int type { get; set; } // Tipo de libro
    }
}
