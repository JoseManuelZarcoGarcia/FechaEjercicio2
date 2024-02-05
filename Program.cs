namespace FechaEjercicio2
{

    class Program
    {

        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            dateTime.ToString("yy - MM - ddThh:mm: ss.ms");
            Console.WriteLine("Formato fecha - tiempo: " + dateTime.ToString());

            int dia = dateTime.Day;
            int mes = dateTime.Month;
            int anyo = dateTime.Year;
            int hora = dateTime.Hour;
            int minutos = dateTime.Minute;
            int segundos = dateTime.Second;
            string diaSemana = dateTime.DayOfWeek.ToString();
            string diaAnyo = dateTime.DayOfYear.ToString();

            Console.WriteLine(dia);
            Console.WriteLine(mes);
            Console.WriteLine(anyo);
            Console.WriteLine(hora);
            Console.WriteLine(minutos);
            Console.WriteLine(segundos);
            Console.WriteLine(diaSemana);
            Console.WriteLine(diaAnyo);

        }

    }

}