namespace ejercicio4
{
    public class Ejercicio4
    {
        public static void Exc()
        {
            int count = 3;
            User defaultUser = new User();

            Console.WriteLine("Bienvenido al sistema de inicio de sesión.");

            while (count > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Ingrese su nombre de usuario:");
                string inputUserName = Console.ReadLine();

                Console.WriteLine("Ingrese su contraseña:");
                string inputPassword = Console.ReadLine();
                User newUser = new User(inputUserName, inputPassword);
                Console.WriteLine();

                if (defaultUser.Equals(newUser))
                {
                    Console.WriteLine("Acceso concedido.");
                    return;
                }
                else
                {
                    count--;
                    if (count > 0)
                    {
                        Console.WriteLine($"Nombre de usuario o contraseña incorrectos. Intentos restantes: {count}");
                    }
                    else
                    {
                        Console.WriteLine("Acceso denegado. Se han agotado los intentos.");
                    }
                }
            }
        }
    }


    public class User
    {
        public string name;
        public string password;

        public User()
        {
            name = "admin";
            password = "12345";
        }

        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        public override bool Equals(object? obj)
        {
            return obj is User user &&
                   name == user.name &&
                   password == user.password;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
