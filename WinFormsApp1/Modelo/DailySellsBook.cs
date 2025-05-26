using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Modelo
{
    public class DailySellsBook : BaseModelBook 
    {
        public int sell {  get; set; } //Venta 
        public int netSell { get; set; } // Venta neta
        public int pMethood { get; set; } // Metodo de pago 
        public int tip {  get; set; } // propina
    }
}
