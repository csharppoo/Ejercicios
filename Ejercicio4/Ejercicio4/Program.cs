using System;

/*
 * Mildred Tatiana Bolañoz Burbano
 * Grupo: 116
 * Ejercicio 4: Capturar por teclado un número capicúa positivo menor que 1000 y hallar su centenas, 
 *              decenas y unidades e imprimirlas por pantalla. 
 * Código fuente: Autoría propia
 */

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objeto de la clase
            ClaseOperaciones obj1 = new ClaseOperaciones();

            //Instancia del objeto
            obj1.CapturarNumero();
            Console.WriteLine("\nEl número actual contiene: ");
            obj1.Centenas();
            obj1.Decenas();
            obj1.Unidades();

            //Presiona una tecla para salir
            Console.ReadKey();
        }
    }
}
