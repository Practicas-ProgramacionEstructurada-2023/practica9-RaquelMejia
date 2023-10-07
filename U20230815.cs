using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("\nMenu de opciones:");
                Console.WriteLine("1. Multiplicar numeros");
                Console.WriteLine("2. Restar numeros");
                Console.WriteLine("3. Concatenar cadenas");
                Console.WriteLine("4. Salir");
                Console.WriteLine("\nIngrese su opcion: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.Write("\nIngrese dos numeros enteros para multiplicar: ");

                            Console.Write("\nNumero 1: ");
                            int num1 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("\nNumero 2: ");
                            int num2 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("\nResultado de la multiplicacion (entero): " + Multiplicar(num1, num2));

                            Console.Write("\nIngrese dos numeros decimales para multiplicar:");

                            Console.Write("\nNumero 1: ");
                            double num1Double = Convert.ToDouble(Console.ReadLine());

                            Console.Write("\nNumero 2: ");
                            double num2Double = Convert.ToDouble(Console.ReadLine());

                            Console.Write("\nResultado de la multiplicacion (decimal): " + Multiplicar(num1Double, num2Double));
                            break;
                        case 2:
                            Console.Write("\nEl resultado es: " + RestarNumeros(20, 5, 3, 2));
                            break;
                        case 3:
                            Console.Write("\nIngrese su primer nombre: ");
                            string? cadena1 = Convert.ToString(Console.ReadLine());

                            Console.Write("Ingrese su primer apellido: ");
                            string? cadena2 = Convert.ToString(Console.ReadLine());

                            Console.Write("Ingrese el separador: ");
                            string? separador1 = Convert.ToString(Console.ReadLine());

                            string resultadoConcatenacion1 = ConcatenarCadenas(cadena1, cadena2, separador1);
                            Console.WriteLine($"\nResultado de la concatenacion: {resultadoConcatenacion1}");



                            Console.Write("\nIngrese su segundo nombre: ");
                            string? cadena3 = Convert.ToString(Console.ReadLine());

                            Console.Write("Ingrese su segundo apellido: ");
                            string? cadena4 = Convert.ToString(Console.ReadLine());

                            Console.Write("Ingrese su tercer apellido: ");
                            string? cadena5 = Convert.ToString(Console.ReadLine());

                            Console.Write("Ingrese el separador: ");
                            string? separador2 = Convert.ToString(Console.ReadLine());

                            string resultadoConcatenacion2 = ConcatenarCadenas(cadena3, cadena4, cadena5, separador2);
                            Console.WriteLine($"\nResultado de la concatenacion: {resultadoConcatenacion2}");
                            break;
                        case 4:
                            Console.Write("\nSaliendo del programa....");
                            break;
                        default:
                            Console.Write("\nOpcion no valida. Intente de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.Write("\nOpcion no valida. Intente de nuevo.");
                }
            }while (opcion != 4);

        }

        static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        static int RestarNumeros(params int[] numeros)
        {
            int resultado = numeros[0]; //Inicializamos el resultado con el primer numero

            for (int i = 1; i < numeros.Length; i++)
            {
                resultado -= numeros[i]; //Restamos los numeros uno por uno
            }

            return resultado;
        }

        static string ConcatenarCadenas(string? cadena1, string? cadena2, string? separador1)
        {
            return cadena1 + separador1 + cadena2;
        }

        static string ConcatenarCadenas(string? cadena1, string? cadena2, string? cadena3, string? separador1)
        {
            return cadena1 + separador1 + cadena2 + separador1 + cadena3;
        }
    }
}
