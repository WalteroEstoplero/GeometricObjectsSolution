using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle kreis = new Circle();
            // kreis wird zu keinem Zeitpunkt initialisiert,
            // und daher bricht die Kompilierung mit einer Fehlermeldung ab.
            // Eine Objektvariable kann nur benutzt werden, wenn sie initialisiert ist.
            if (kreis == null)
            {
                // die Variable "kreis" referenziert kein Objekt
                Console.WriteLine("Das Objekt existiert nicht!");
                kreis = new Circle();
            }
            else
                // "kreis" ist eine gültige Objektreferenz
                Console.WriteLine("Das Objekt existiert");
            // weitere Anweisungen

            Circle kreis1 = new Circle();
            Circle kreis2 = kreis1;
            kreis1.Radius = 10;
            Console.WriteLine(kreis2.Radius);
            kreis2.Radius = 20;
            kreis2 = null;
            Console.WriteLine(kreis1.Radius);

            kreis.Radius = 12;
            Console.WriteLine("Der Kreisradius beträgt {0}", kreis.Radius);

            kreis = null;


            Console.ReadLine();
        }
    }
}
