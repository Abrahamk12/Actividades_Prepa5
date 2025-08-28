using System;
public class Program
{
    public static void Main()
    {
        string nombre = "Mundo", nombre2;
        int numero = 42, numero2, j = 10;
        double decimalNumber = 3.14, decimalNumber2;
        bool booleanValue = true, booleanValue2;
        char character = 'A', character2;
        Console.WriteLine("Ingrese su nombre: "+nombre);
        Console.WriteLine($"Hola, {nombre}! la suma de 2+2 es igual a {4}");
        if (numero > 10)
        {
            Console.WriteLine("El número es mayor que 10.");
        }

        /* Abrir cometario
         * = es para asignar
         * == es para comparar
         * += es para sumar y asignar
         * -= es para restar y asignar
         * != es para diferente
         * -- es para decrementar en 1 en 1
         * ++ es para incrementar en 1 en 1
         * < es menor que
         * > es mayor que
         * =< es menor o igual que
         * => es mayor o igual que
         * Console.WriteLine();
         * Console.ReadLine();
         * Estructura if, else if, else
         * Tarea
         *     Crear un programa que guarde en una variable el nombre de una
         *     persona y en otra variable su edad.
         *     Despues la muestre por consola, y si la edad es mayor a 18
         *     que muestre un mensaje, si no lo es, que muestre otro mensaje.
         */ //Cerrar comentario
            //Linea unica de comentario
        numero += 5;
        numero -= 5;
        while (true)
        {
            if(j != 0)
            {
                Console.WriteLine(j);
                j--;
            }else if(j == 0)
            {
                Console.WriteLine("Despegue!");
                break;
            }
            else
            {
                break;
            }
        }
    }
}