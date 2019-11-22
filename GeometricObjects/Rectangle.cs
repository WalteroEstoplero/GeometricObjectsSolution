using System;

namespace GeometricObjects
{
    class Rectangle
    {
        // ---------- Klasseneigenschaft  Kap. 3.9.1 -----------------
        protected static int _CountCircles;     // ???
        // Klasseneigenschaftsmethode schreibgeschützt weil ohne set
        public static int CountCircles
        {
            get { return _CountCircles; }
        }
        public double XCoordinateL { get; set; }
        public double YCoordinateL { get; set; }
        public double XCoordinateR { get; set; }
        public double YCoordinateR { get; set; }

        // --------- Konstruktoren ---------------
        public Rectangle() { Console.WriteLine("Aufruf des Standardkonstruktors von Rectangle"); }                // immer 3 Parameter
        // ???
        // ???

        // ---------- Instanzmethoden ----------
        public double GetArea()
        {
            return (XCoordinateR - XCoordinateL) * (YCoordinateR - YCoordinateL);
        }

        public double GetCircumference()
        {
            return (2*(XCoordinateR - XCoordinateL) + (YCoordinateR - YCoordinateL));
        }

        public virtual void Move(double dx, double dy)  // virtual Kap 4.6.1
        {
            XCoordinateR += dx;
            XCoordinateL += dx;
            YCoordinateR += dy;
            YCoordinateL += dy;
        }

        // Bigger Rückgaben int
        // 1 wenn Radius des aufrufenden Objekts > übergebener Objekt.Radius
        // -1 wenn Radius des aufrufenden Objekts < übergebener Objekt.Radius
        // 0 wenn beide gleich
        public int Bigger(Rectangle rect)
        {
            if (rect == null || this.GetArea() > rect.GetArea()) { return 1; }
            if (this.GetArea() < rect.GetArea()) { return -1; }
            else return 0;
        }

        // -------- Klassenmethoden Kap 3.9.2 ------------
        public static double GetArea(int xr)
        {
            return 0;   // ERROR
// ???            return (XCoordinateR - XCoordinateL) * (YCoordinateR - YCoordinateL);
        }

        public static double GetCircumference(int xr)
        {
            return 0;   // ERROR
// ???           return (2 * (XCoordinate2 - XCoordinate1) + (YCoordinate2 - YCoordinate1));
        }

        public static int Bigger(Rectangle rect1, Rectangle rect2)
        {
            if (rect1 == null && rect2 == null) { return 0; }
            if (rect1 == null) { return -1; }
            if (rect2 == null) return 1;
            if (rect1.GetArea() > rect2.GetArea()) { return 1; }
            if (rect1.GetArea() < rect2.GetArea()) { return -1; }
            return 0;
        }
    }
}
