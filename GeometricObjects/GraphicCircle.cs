using System;

namespace GeometricObjects
{
    // mit sealed kann diese Klasse nicht noch weiter abgeleitet werden
    public sealed class GraphicCircle : Circle
    {
/*
        // --------- Konstruktoren ---------------
        public GraphicCircle() : base(0, 0, 0) { Console.WriteLine("Aufruf des Standardkonstruktors von GraphicCircle"); }
        public GraphicCircle(int radius) : base(radius, 0, 0) { }
        public GraphicCircle(int radius, double x, double y) : base(radius, x, y) { Console.WriteLine("Aufruf des 3-fachen Parameterkonstruktors von GraphicCircle"); }
*/

        public GraphicCircle() : this(0, 0, 0) { Console.WriteLine("Aufruf des Standardkonstruktors von GraphicCircle"); }
        public GraphicCircle(int radius) : this(radius, 0, 0) { }
        public GraphicCircle(int radius, double x, double y)
        {
            Radius = radius;
            XCoordinate = x;
            YCoordinate = y;
            Console.WriteLine("Aufruf des 3-fachen Parameterkonstruktors von GraphicCircle");
            Circle._CountCircles++;
        }

        // ---------- Instanzmethoden ----------

        public void Draw()
        {
            Console.WriteLine("Der Kreis wird gezeichnet");
        }
    }
}
