namespace ejercicio3
{
    public class Ejercicio3
    {
        public static void Exc() {
            Console.WriteLine("Ingrese su edad:");
            if (int.TryParse(Console.ReadLine(), out int age) && age >= 0)
            {
                int days = CalculateDays(age);
                int weeks = days / 7;
                Console.WriteLine($"Han transcurrido {days} días y {weeks} semanas desde el inicio del año actual.");
            }
            else
            {
                Console.WriteLine("Edad no válida. Por favor, ingrese un número entero positivo.");
            }

        }
        public static int CalculateDays(int age)
        {
            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;
            int days = 0;

            for (int i = 1; i <= currentMonth; i++) 
            {
                int daysPerMonth = DateTime.DaysInMonth(currentYear, i);
                if (i == DateTime.Now.Month)
                {
                    days += DateTime.Now.Day - 1;
                    break;
                }
                days += daysPerMonth;
                
            }

            for (int j = currentYear - age; j < currentYear; j++) {
                if (DateTime.IsLeapYear(j)) {
                    days++;
                }
                days += 365;
            }

            return days;
        }
    }
}
