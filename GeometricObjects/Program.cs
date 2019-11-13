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

            Circle kreis3 = new Circle();
            kreis3.XCoordinate = 50;
            kreis3.YCoordinate = 25;
            kreis3.Radius = 12;
            int height = 30;
            double volume = kreis3.GetArea() * height;
            Console.WriteLine(volume);

            Circle kreis4 = new Circle();
            kreis4.XCoordinate = -100;
            kreis4.YCoordinate = 90;
            kreis4.Move(120, -200);
            Console.WriteLine("x= " + kreis4.XCoordinate +";y= " + kreis4.YCoordinate);

            // Bigger Rückgaben int
            // 1 wenn Radius des aufrufenden Objekts > übergebener Objekt.Radius
            // -1 wenn Radius des aufrufenden Objekts < übergebener Objekt.Radius
            // 0 wenn beide gleich
            Circle kreis5 = new Circle();
            kreis5.Radius = 23; // 12;
            Circle kreis6 = new Circle();
            kreis6.Radius = 23;
            if (kreis5.Bigger(kreis6) == -1)
                Console.WriteLine("Objekt 'kreis5' ist kleiner als Objekt 'kreis6'");
            if (kreis5.Bigger(kreis6) == 1)
                Console.WriteLine("Objekt 'kreis5' ist größer als Objekt 'kreis6'");
            if (kreis5.Bigger(kreis6) == 0)
                Console.WriteLine("Objekt 'kreis5' und Objekt 'kreis6' sind gleich groß");

            // Benannte Argumente
            kreis5.Move(dx: 100, dy: -200);
            kreis5.Move(dy: 300, dx: -100);


            // Anwendung der Klasse Demo
            int[] array0 = { 3, 6, 9, 4, 13, 22, 2, 29, 17 };
            int[] array = new int[] { 3, 6, 9, 4, 13, 22, 2, 29, 17 };
            Demo demo = new Demo();
            int maxValue= demo.GetMaxValue(array);
            Console.WriteLine("Maximalwert = {0}", demo.GetMaxValue(array));

            // Params
            //int[] list = { 1, 2, 3 }; Console.WriteLine(demo.Add(15, 19, list));
            Console.WriteLine(demo.Add(15, 19, 1, 2, 3));
            Console.WriteLine(demo.Add(1, 2, 3, 4, 5, 6));
            Console.WriteLine(demo.Add(95));
            Console.WriteLine(demo.Add(95, 5));
            Console.WriteLine(demo.Add());


            // Übergabe von Objekten
            Demo1 object1 = new Demo1();        // Wert = 1
            Demo2 object2 = new Demo2();        // Wert = 2
            object2.ChangeValue(object1);
            Console.WriteLine("object1.Value sollte 1 sein: = " + object1.Value);
            object2.ChangeValue(ref object1);
            Console.WriteLine("object1.Value sollte 2 sein: = " + object1.Value);

            // Konstuktor-Weiterleitung
            Circle kreis7 = new Circle(12, -100, 250);

            // Vereinfachte Objektinitialisierung Kap 3.6.7 !!! KLAPPT NICHT !!!
            Circle kreis8 = new Circle { YCoordinate = 2, XCoordinate = -7, Radius = 2 };


            // Konstanten
            Console.WriteLine(Mathematics.PI);

            // Klassenvariable Kap 3.9.1
            Console.WriteLine("CountCircles " + Circle.CountCircles);



            Console.ReadLine();
        }
    }   // class Program
}
