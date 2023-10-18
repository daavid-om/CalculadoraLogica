using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogica.Servicios
{
    /// <summary>
    /// Interfaz que relaciona con el menu
    /// 181023 - dom
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que muestra el menú y recoge la opción seleccionada
        /// 181023 - dom
        /// </summary>
        /// <returns></returns>
        public int mostrarMenu();
    }
}
