using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1ParImpar.Servicios
{
    /// <summary>
    /// iMPLEMENTACION DE LAS ACCIONES DEL MENU
    /// 241023 - David RA
    /// </summary>
    internal class ImplPeticion:InterfazPeticion
    {
        //método para pedir numero por consola
        public int pedirNumero()
        {
            Console.WriteLine("Introduzca un numero entero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El numero elegido es el "+num1);

          return num1;
        }
    }
}
