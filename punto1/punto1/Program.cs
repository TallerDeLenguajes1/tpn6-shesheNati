using System;

namespace punto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, total = 0;
            Console.Write("Ingrese un numero positivo: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.Write("Usted ingreso: " + numero);
                while (numero >= 10)
                {
                    total = total + (numero % 10);
                    total = total * 10;
                    numero = numero / 10;
                }
                total = total + numero;
                Console.Write("\nEl numero dado vuelta es: " + total);
                Console.ReadKey();
            }
            else
            {
                Console.Write("ERROR! Ingrese un numero positivo");
                Console.ReadKey();
            }
        }
    }
}
