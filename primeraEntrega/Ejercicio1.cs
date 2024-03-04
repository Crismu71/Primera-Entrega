namespace ejercicio1
{
    public class Ejercicio1
    {
        public static void Exc()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Ingrese la primera fracción (en el formato 'numerador/denominador'): ");
                    string[] Fraction1 = Console.ReadLine().Split('/');
                    int numerator1 = int.Parse(Fraction1[0]);
                    int denominator1 = int.Parse(Fraction1[1]);

                    Console.WriteLine("Ingrese la segunda fracción (en el formato 'numerador/denominador'): ");
                    string[] Fraction2 = Console.ReadLine().Split('/');
                    int numerator2 = int.Parse(Fraction2[0]);
                    int denominator2 = int.Parse(Fraction2[1]);

                    Fraction f1 = new(numerator1, denominator1);
                    Fraction f2 = new(numerator2, denominator2);

                    Console.WriteLine("Ingrese el operador (+, -, *, /): ");
                    char operador = char.Parse(Console.ReadLine());

                    Fraction resultado;
                    switch (operador)
                    {
                        case '+':
                            resultado = f1.Add(f2);
                            break;
                        case '-':
                            resultado = f1.Substract(f2);
                            break;
                        case '*':
                            resultado = f1.Multiply(f2);
                            break;
                        case '/':
                            resultado = f1.Divide(f2);
                            break;
                        default:
                            Console.WriteLine("Operador no válido");
                            return;
                    }

                    Console.WriteLine($"El resultado es: {resultado}");
                    break;
                }
                catch (Exception ex)
                {
                    if (ex is ArgumentException)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Por favor, intentalo nuevamente.");
                    }
                    
                    if (ex is FormatException)
                    {
                        Console.WriteLine("Debes de ingresar valores numericos");
                    }

                    if (ex is IndexOutOfRangeException) {
                        Console.WriteLine("Debes de escribir tu numero en un formato valido 'numerado/denominador'");
                    }
                }
            }
        }
    }
    public class Fraction
    {
        private readonly int _numerator;
        private readonly int _denominator;

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("El denominador no puede ser cero.");
            }

            _numerator = numerator;
            _denominator = denominator;
        }

        public Fraction Add(Fraction other)
        {
            int newDenominator = _denominator * other._denominator;
            int newNumerator = (_numerator * other._denominator) + (_denominator * other._numerator);
            return new Fraction(newNumerator, newDenominator);

        }

        public Fraction Substract(Fraction other)
        {
            int newDenominator = _denominator * other._denominator;
            int newNumerator = (_numerator * other._denominator) - (_denominator * other._numerator);
            return new Fraction(newNumerator, newDenominator);
        }

        public Fraction Multiply(Fraction other)
        {
            int newDenominator = _denominator * other._denominator;
            int newNumerator = _numerator * other._numerator;
            return new Fraction(newNumerator, newDenominator);
        }

        public Fraction Divide(Fraction other)
        {
            int newDenominator = _denominator * other._numerator;
            int newNumerator = _numerator * other._denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        public override string ToString()
        {
            return $"{_numerator}/{_denominator}";
        }

    }


}