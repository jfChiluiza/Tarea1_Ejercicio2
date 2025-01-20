using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Evaluar si un número es positivo, negativo o cero
        Console.WriteLine("1. Evaluar si un número es positivo, negativo o cero");
        Console.Write("Ingrese un número: ");
        if (double.TryParse(Console.ReadLine(), out double numero))
        {
            if (numero > 0) Console.WriteLine("El número es positivo.");
            else if (numero < 0) Console.WriteLine("El número es negativo.");
            else Console.WriteLine("El número es cero.");
        }
        else
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
        }

        // 2. Mostrar mensaje según calificación
        Console.WriteLine("\n2. Calificación (Aprobado/Reprobado)");
        Console.Write("Ingrese una calificación: ");
        if (double.TryParse(Console.ReadLine(), out double calificacion))
        {
            Console.WriteLine(calificacion >= 60 ? "Aprobado" : "Reprobado");
        }
        else
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
        }

        // 3. Determinar rango de un número
        Console.WriteLine("\n3. Determinar rango de un número");
        Console.Write("Ingrese un número: ");
        if (double.TryParse(Console.ReadLine(), out numero))
        {
            if (numero < 10) Console.WriteLine("Menor que 10");
            else if (numero <= 20) Console.WriteLine("Entre 10 y 20");
            else Console.WriteLine("Mayor que 20");
        }
        else
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
        }

        // 4. Día de la semana
        Console.WriteLine("\n4. Día de la semana");
        Console.Write("Ingrese un número del 1 al 7: ");
        if (int.TryParse(Console.ReadLine(), out int dia) && dia >= 1 && dia <= 7)
        {
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
            Console.WriteLine($"El día correspondiente es {dias[dia - 1]}.");
        }
        else
        {
            Console.WriteLine("Entrada no válida. Ingrese un número entre 1 y 7.");
        }

        // 5. Calculadora básica
        Console.WriteLine("\n5. Calculadora básica");
        Console.Write("Ingrese el primer número: ");
        if (double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.Write("Ingrese el segundo número: ");
            if (double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.Write("Ingrese la operación (+, -, *, /): ");
                string operacion = Console.ReadLine();
                switch (operacion)
                {
                    case "+":
                        Console.WriteLine($"Resultado: {num1 + num2}");
                        break;
                    case "-":
                        Console.WriteLine($"Resultado: {num1 - num2}");
                        break;
                    case "*":
                        Console.WriteLine($"Resultado: {num1 * num2}");
                        break;
                    case "/":
                        if (num2 != 0) Console.WriteLine($"Resultado: {num1 / num2}");
                        else Console.WriteLine("No se puede dividir entre cero.");
                        break;
                    default:
                        Console.WriteLine("Operación no válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida para el segundo número.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida para el primer número.");
        }
    }
}
