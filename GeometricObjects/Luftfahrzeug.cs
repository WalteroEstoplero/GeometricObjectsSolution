using System;

namespace GeometricObjects
{
    // Verdecken bzw. ausblenden
    /*
            public class Luftfahrzeug
            {
                public string Hersteller { get; set; }
                public int Baujahr { get; set; }

                public void Starten()                       // vollständige Methode !
                {
                    Console.WriteLine("Das Luftfahrzeug startet.");
                }
            }

            public class Flugzeug : Luftfahrzeug
            {
                public double Spannweite { get; set; }

                // Methode mit oder ohne new verdecken bzw. ausblenden
                // Ohne new gibt es nur eine Warnung
                public new void Starten()
                {
                    Console.WriteLine("Das Flugzeug startet.");
                }
            }

            public class Hubschrauber : Luftfahrzeug
            {
                public double Rotor { get; set; }

                // Methode mit oder ohne new verdecken bzw. ausblenden
                // Ohne new gibt es nur eine Warnung
                public new void Starten()
                {
                    Console.WriteLine("Das Hubschrauber startet.");
                }
            }
     */

    /*
                // Abstract mit override
                public abstract class Luftfahrzeug      // abstract hier !
                {
                    public string Hersteller { get; set; }
                    public int Baujahr { get; set; }

                    public abstract void Starten();     // und abstract hier. Keine vollständige Methode !
                }

                public class Flugzeug : Luftfahrzeug
                {
                    public double Spannweite { get; set; }

                    public override void Starten()      // override hier !
                    {
                        Console.WriteLine("Das Flugzeug startet.");
                    }
                }

                public class Hubschrauber : Luftfahrzeug
                {
                    public double Rotor { get; set; }

                    public override void Starten()      // override hier !
                    {
                        Console.WriteLine("Das Hubschrauber startet.");
                    }
                }
    */


    // Virtual mit override
    public class Luftfahrzeug
    {
        public string Hersteller { get; set; }
        public int Baujahr { get; set; }

        public virtual void Starten()               // virtual hier und vollständige Methode !
        {
            Console.WriteLine("Das Luftfahrzeug startet.");
        }
    }

    public class Flugzeug : Luftfahrzeug
    {
        public double Spannweite { get; set; }

        public override void Starten()      // override hier !
        {
            Console.WriteLine("Das Flugzeug startet.");
        }
    }

    public class Hubschrauber : Luftfahrzeug
    {
        public double Rotor { get; set; }

        public override void Starten()      // override hier !
        {
            Console.WriteLine("Das Hubschrauber startet.");
        }
    }

}

