using CalculadoraLogica;
using CalculadoraLogica.Servicios;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace CalculadoraLogica
{
    /// <summary>
    /// clase principal
    /// 181023 - dom
    /// </summary>
    class program
    {
        /// <summary>
        /// Método entrada a la calculadora
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Creamos a los objetos para poder utilizar los métodos de MenuImplementación
            MenuInterfaz mi = new MenuImplementacion();
            
            //variable que controla la entrada y salida del bool
            bool cerrarMenu = false;
            //contener la opción del usuario
            int opcionSeleccionada;

            while (!cerrarMenu)
            {
                opcionSeleccionada = mi.mostrarMenu();
                switch(opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("[INFO] Se cierra la aplicación");
                        cerrarMenu = true;
                        break;
                      
                }
            }
        }
    }
}
