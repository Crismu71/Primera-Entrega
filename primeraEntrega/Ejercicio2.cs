namespace ejercicio2
{
    public class Ejercicio2
    {
        public static bool IsSpecialNumber(int numb)
        {
            if (numb % 5 == 0)
            {
                if (numb % 2 != 0 && numb % 3 != 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static void Exc() 
        {
            Console.WriteLine("Ingrese un número para verificar si es 'especial':");
            int numb;
            if (int.TryParse(Console.ReadLine(), out numb))
            {
                if (IsSpecialNumber(numb))
                {
                    Console.WriteLine($"El número {numb} es especial.");
                }
                else
                {
                    Console.WriteLine($"El número {numb} no es especial.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
            }
        }
    }
}
