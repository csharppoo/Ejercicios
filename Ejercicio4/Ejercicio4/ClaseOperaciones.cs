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
    class ClaseOperaciones
    {
        //atributos de la clase
        private int numero { get; set; }
        private int centenas;
        private int decenas;
        private int unidades;

        //Método constructor
        public ClaseOperaciones()
        {
            numero = 0;
            centenas = 0;
            decenas = 0;
            unidades = 0;
        }

        //Método para capturar el número capicúa ingresado por teclado
        public int CapturarNumero()
        {
            int numeroBase = 0;
            int resultado = 0;

            Console.WriteLine("Ingrese un número capicúa positivo menor que 1000");

            do
            {
                Console.Write("\nNúmero uno: ");
                numero = int.Parse(Console.ReadLine());

                numeroBase = numero;

                while (numeroBase > 0)
                {
                    resultado = resultado * 10 + numeroBase % 10;
                    numeroBase /= 10;
                }

                if (numero < 1 || numero > 1000 || resultado != numero)
                {
                    Console.WriteLine("\nPor favor ingrese el número correctamente");
                    resultado = 0;
                }
            } while (numero < 1 || numero > 1000 || resultado != numero);

            return numero;
        }

        //Método para mostrar las centenas del número ingresado
        public void Centenas()
        {
            centenas = (numero % 1000 - numero % 100) / 100;

            Console.WriteLine("\nCentenas = " + centenas);
        }

        //Método para mostrar las decenas del número ingresado
        public void Decenas()
        {
            decenas = (numero % 100 - numero % 10) / 10;

            Console.WriteLine("Decenas = " + decenas);
        }

        //Método para mostrar las unidades del número ingresado
        public void Unidades()
        {
            unidades = numero % 10;

            Console.WriteLine("Unidades = " + unidades);
        }
    }
}
