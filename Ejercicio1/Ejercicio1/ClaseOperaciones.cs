using System;
using System.Collections.Generic;

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
    class ClaseOperaciones
    {
        //atributos de la clase
        private int numero1 { get; set; }
        private int numero2 { get; set; }
        private List<int> ResultadoC;

        //Método constructor
        public ClaseOperaciones()
        {
            numero1 = 0;
            numero2 = 0;
            ResultadoC = new List<int>();
        }

        //Método para capturar los números ingresados por teclado
        public int CapturarNumero1()
        {
            do
            {
                Console.Write("\nNúmero uno: ");
                numero1 = int.Parse(Console.ReadLine());

                if (numero1 < 1 || numero1 > 1000)
                {
                    Console.WriteLine("\nPor favor ingrese el número correctamente");
                }
            } while (numero1 < 1 || numero1 > 1000);
         
            return numero1;
        }

        public int CapturarNumero2()
        {
            do
            {
                Console.Write("\nNúmero dos: ");
                numero2 = int.Parse(Console.ReadLine());

                if (numero2 < 1 || numero2 > 1000)
                {
                    Console.WriteLine("\nPor favor ingrese el número correctamente");
                }
            } while (numero2 < 1 || numero2 > 1000);

            return numero2;
        }

        //Método para agregar a la lista los números conprendidos entre n1 y n2
        public List<int> NumerosComprendidos()
        {
            List<int> numeros = new List<int>();

            if (numero1 < numero2)
            {
                for (int i = numero1; i <= numero2; i++)
                {
                    numeros.Add(i);
                }
            }
            else
            {
                for (int i = numero2; i <= numero1; i++)
                {
                    numeros.Add(i);                  
                }
            }

            return ResultadoC = numeros;
        }

        //Método para bucar los números capicúa de la lista
        public void MostrarCapicua()
        {
            int numero = 0;
            int resultado = 0;
            int contador = 0;

            Console.WriteLine("\nLos números capicúa son:\n");

            foreach (int r in ResultadoC)
            {
                numero = r;

                while (numero > 0)
                {
                    resultado = resultado * 10 + numero % 10;
                    numero /= 10;
                }
                if (resultado == r)
                {
                    Console.Write(" | " + r);
                    contador++;
                }
                resultado = 0;
            }
            if (contador == 0)
            {
                Console.Write("No se encontraron números capicúa");
            }

            Console.WriteLine("\n\nLa cantidad de numeros hallados es: " + contador);
        }
    }
}
