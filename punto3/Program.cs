using System;

namespace punto3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            double numero = double.Parse(Console.ReadLine());

            Console.Write("El valor absoluto es " + Math.Abs(numero));
            Console.Write("\nEl cuadrado es " + Math.Pow(numero, 2));
            Console.Write("\nLa raiz es " + Math.Sqrt(numero));
            Console.Write("\nEl seno es " + Math.Sin(numero));
            Console.Write("\nEl conseno es " + Math.Cos(numero));
            Console.Write("\nLa parte entera es " + Math.Truncate(numero));
            Console.ReadKey();

            Console.Write("\n\nIngrese el primer numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("\nIngrese el segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("El maximo es " + Math.Max(a, b));
            Console.WriteLine("El minimo es " + Math.Min(a, b));
            Console.ReadKey();

        }
    }
}
