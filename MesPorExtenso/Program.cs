using System;
using System.Globalization;

namespace MesPorExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            ExibirMesPorExtenso(new DateTime(2019, 7, 7));

            Console.ReadKey();
        }

        public static void ExibirMesPorExtenso(DateTime data)
        {
            var idioma = CultureInfo.CreateSpecificCulture("pt-br");

            Console.WriteLine(data.ToString("MMMM", idioma));
            Console.WriteLine("---");
            Console.WriteLine(data.ToString("MMM", idioma));
            Console.WriteLine("---");
            Console.WriteLine(data.ToString("MM", idioma));
            Console.WriteLine("---");
            Console.WriteLine(data.ToString("M", idioma));
        }
    }
}
