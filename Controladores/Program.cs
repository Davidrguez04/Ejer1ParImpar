using Ejer1ParImpar.Servicios;

namespace Ejer1ParImpar.Controladores
{

    /// <summary>
    /// Clase que controla el flujo de procedimientos de la aplicación
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método de entrada a la aplicación
        /// contiene el procedimiento o flujo de nuestra aplicación
        /// 241023 - David Rodriguez Alonso
        /// </summary>
        /// <param name="args"></param>



        static void Main(string[] args)
        {

            /*Escribe un programa que solicite un número entero al usuario, lo lea de la consola e indique si es 
             * par o impar.

            El método que solicite el número deberá estar definido en un servicio. El método mostrará el mensaje 
            de petición 
            de número, recogerá el número escrito en la consola y lo devolverá al método main.
            La identificación de si es par o impar el número se podrá hacer en el método main.*/

            //Llamada al método que imprime el mensaje por consola
            InterfazPeticion ni =new ImplPeticion();

            int num=ni.pedirNumero();

            //if para saber si el numero es par o impar
            if (num / 2 == 0)
            {
                Console.WriteLine("El numero "+num+" es un numero impar");

            }
            else
            {
                Console.WriteLine("El numero "+num+" es un numero par");
            }


        }


    }
}
