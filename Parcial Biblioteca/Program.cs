using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblio = new Biblioteca();
            biblio.CargarListas();
            biblio.GenerarReporte();
            Console.ReadKey();
        }
    }
}
