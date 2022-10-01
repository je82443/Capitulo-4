namespace ejercicio1cap1
{
    public class Program
    {
        public static void Main()
        {
            int dia = 0;
            int anyo = 0;
            int mes; 

            double bisiesto4 = anyo % 4;

            Console.WriteLine("Ingrese el año.");
            anyo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el mes");
            mes = Convert.ToInt32(Console.ReadLine());

            if (mes == 2)
            {
                Console.WriteLine("Ingrese el día.");
                dia = Convert.ToInt32(Console.ReadLine());
                if (dia > 29 && bisiesto4 == 0)
                {
                    Console.Write("Este mes solo tiene 29 días.");
                }
                else
                {
                    if (dia > 28)
                    {
                        Console.Write("Dia bisiesto");
                    }
                }
            }

            if (mes == 01 || mes == 03 || mes == 05 || mes == 07 || mes == 08 || mes == 10 || mes == 12)
            {
                Console.WriteLine("Ingrese el día.");
                dia = Convert.ToInt32(Console.ReadLine());
                if (dia > 31)
                {
                    Console.Write("Dia incorrecto");
                }
            }

            else if (mes == 04 || mes == 06 || mes == 09 || mes == 11)
            {
                Console.WriteLine("Ingrese el día");
                dia = Convert.ToInt32(Console.ReadLine());
                if (dia > 30)
                {
                    Console.Write("Dia incorrecto");
                }
            }

            DateTime Fecha = new DateTime(anyo, mes, dia);
            Fecha = Fecha.AddDays(1);
            Console.WriteLine(Fecha);
        }
    }
}