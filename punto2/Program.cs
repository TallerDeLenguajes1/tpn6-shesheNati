using System;

namespace punto2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion, a, b;
            char again;
            do
            {
                do
                {
                    Console.Write("---------CALCULADORA---------\n");
                    Console.Write("1. Sumar\n");
                    Console.Write("2. Restar\n");
                    Console.Write("3. Multiplicar\n");
                    Console.Write("4. Dividir\n");
                    opcion = int.Parse(Console.ReadLine());

                    if (opcion < 1 || opcion > 4)
                    {
                        Console.Write("ERROR! Ingrese un valor dentro del rango\n");
                        Console.ReadKey();
                    }
                } while (opcion < 1 || opcion > 4);

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el primer numero:");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo numero:");
                        b = int.Parse(Console.ReadLine());
                        Console.Write(a + b);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Write("Ingrese el primer numero:");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo numero:");
                        b = int.Parse(Console.ReadLine());
                        Console.Write(a - b);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Write("Ingrese el primer numero:");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo numero:");
                        b = int.Parse(Console.ReadLine());
                        Console.Write(a * b);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Write("Ingrese el primer numero:");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo numero distinto de 0:");
                        b = int.Parse(Console.ReadLine());
                        Console.Write(a / b);
                        Console.ReadKey();
                        break;
                }
                Console.Write("Desea hacer otro calculo? s/n: ");
                again = Convert.ToChar(Console.ReadLine());
            } while (again == 's' || again == 'S');
        }
    }
}
