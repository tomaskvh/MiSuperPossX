using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Modelo;

namespace WinFormsApp1.Dato
{
    public class User
    {
        List<ModelUser> lista = new List<ModelUser>();
        /// <summary>
        /// Guarda los datos de los usuarios
        /// </summary>
        /// <param name="user">Datos del usuario</param>
        public void SaveUser(ModelUser user)
        {
            lista.Add(user);
        }
        /// <summary>
        /// Consulta todos los  usuarios
        /// </summary>
        /// <returns>Todos los usuarios</returns>
        public List<ModelUser> Consultar() { 
            return lista; 
        }
    }
}
