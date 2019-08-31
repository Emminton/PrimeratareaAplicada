using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosAplicada.Tarea1
{           // metodo para convertir la Temperatura
    class Temperatura
    {
        double centigrado, faren;
        string valor = "";

        public void carcularTemperatura()
        {
            Console.Write("Ingrse la temperatura a Convertir: ");
            valor = Console.ReadLine();
            centigrado = Convert.ToDouble(valor);

            faren = (centigrado * 9 / 5 ) + 32;

            Console.Write("La temperatura es:{0} ", faren);

            Console.ReadKey();
        }
    }
}
