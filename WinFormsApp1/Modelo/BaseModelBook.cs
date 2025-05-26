using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Modelo
{
    // Modelo Base para libros internos
    public class BaseModelBook
    {
        public int operationNo {  get; set; } // No. Boleta/Operación
        public int Attender { get; set; } // Codigo de atendedor
        public int Responsable { get; set; } // Codigo del responsable (Supervisor)
        public string Date { get; set; } // fecha actuación
        public string Time { get; set; } // hora actuación 
    }
}
