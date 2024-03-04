namespace primeraEntrega
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
        }

        static void ShowMenu()
        {
            bool flag = true; 
            while (flag)
            {
                Console.WriteLine();
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Calculadora de fracciones");
                Console.WriteLine("2. Numero especial");
                Console.WriteLine("3. Dias y semanas");
                Console.WriteLine("4. Sistema de inicio de sesion");
                Console.WriteLine("5. Salir");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        ejercicio1.Ejercicio1.Exc();
                        break;
                    case "2":
                        ejercicio2.Ejercicio2.Exc();
                        break;
                    case "3":
                        ejercicio3.Ejercicio3.Exc();
                        break;
                    case "4":
                        ejercicio4.Ejercicio4.Exc();
                        break;
                    case "5":
                        Console.WriteLine("Saliendo del programa.");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
        }
    }

}