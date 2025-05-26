using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Modelo;

namespace WinFormsApp1.Dato
{
    public class SellsBook
    {
        List<DailySellsBook> lista = new List<DailySellsBook>();
        /// <summary>
        /// Guarda los datos de los usuarios
        /// </summary>
        /// <param name="dsb">Libro de ventas diario</param>
        public void SaveUser(DailySellsBook dsb)
        {
            lista.Add(dsb);
        }
        /// <summary>
        /// Consulta todos los  usuarios
        /// </summary>
        /// <returns>Todos los usuarios</returns>
        public List<DailySellsBook> Consultar()
        {
            return lista;
        }
    }
}
