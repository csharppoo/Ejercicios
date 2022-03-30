using System;

/*
 * Mildred Tatiana Bolañoz Burbano
 * Grupo: 116
 * Ejercicio 1: Capturar por teclado 2 números enteros positivos entre 1 y 1000 incluidos, 
 *              para hallar y mostrar por pantalla los números capicúa que se encuentran en ese rango 
 *              y la cantidad de números hallados
 * Código fuente: Autoría propia
 */

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objeto de la clase
            ClaseOperaciones obj = new ClaseOperaciones();

            //Instancia del objeto
            Console.WriteLine("Ingrese 2 números enteros positivos entre 1 y 1000");
            obj.CapturarNumero1();
            obj.CapturarNumero2();
            obj.NumerosComprendidos();
            obj.MostrarCapicua();

            //Presiona una tecla para salir
            Console.ReadKey();
        }
    }
}
