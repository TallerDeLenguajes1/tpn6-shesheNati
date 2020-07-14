using System;

namespace punto4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 4, resultado = a + b;


            Console.WriteLine("Ingrese la cadena1 con al menos 1 espacio");
            string cadena1 = Console.ReadLine();
            Console.WriteLine("Ingrese la cadena2");
            string cadena2 = Console.ReadLine();
            string cadenaConcatenada = String.Concat(cadena1, cadena2);

            Console.WriteLine("\nLa cadena1 ingresada es: " + cadena1);

            Console.WriteLine("Largo de cadena1 es " + cadena1.Length + " caracteres");

            Console.WriteLine("La cadena concatenada tiene: " + cadenaConcatenada);

            Console.WriteLine("La subcadena resultante de la concatenacion es: " + cadenaConcatenada.Substring(0, 7));

            Console.WriteLine("La cadena1 termina se muestra hasta el primer espacio: " + cadena1.Substring(0, cadena1.IndexOf(" ", 0)));//Devuelve la cadena hasta el espacio, desde el caracter inicial

            Console.WriteLine("La suma de " + Convert.ToString(a) + " y " + Convert.ToString(b) + " es " + Convert.ToString(resultado));

            Console.WriteLine("La cadena concatenada en MAYUSCULA es " + cadenaConcatenada.ToUpper());

            Console.WriteLine("La cadena concatenada en minuscula es " + cadenaConcatenada.ToLower());

            if (string.Compare(cadena1, cadena2) == 0)
            {
                Console.WriteLine("Las cadenas 1 y 2 son iguales");
            }
            else
            {
                Console.WriteLine("Las cadenas son distintas");
            }

            string cadena3 = "esta cadena esta separada y se guarda en un arreglo de string";
            char[] delimitadores = { ' ', ',' };
            string[] cadenas_separadas = cadena3.Split(delimitadores);

            for (int i = 0; i < cadenas_separadas.Length; i++)
            {
                Console.WriteLine("Posicion[{0}] {1}", (i), cadenas_separadas[i]);
            }

            Console.ReadKey();
        }
    }
}
