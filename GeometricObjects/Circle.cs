using System;

namespace GeometricObjects
{
    public class Circle : GeometricObject
    {
        // Kap. 5.2.1 InvalidMeasure = Eventbezeichner.
        public event InvalidMeasureEventHandler InvalidMeasure; // 2.

        // ---------- Klasseneigenschaft  Kap. 3.9.1 -----------------
        protected static int _CountCircles;
        // Klasseneigenschaftsmethode schreibgeschützt weil ohne set
        public static int CountCircles  {
            get { return _CountCircles; }
        }
//        public double XCoordinate { get; set; }
//        private double _XCoordinate;
//        public double XCoordinate { get => _XCoordinate; set => _XCoordinate = value; }
//        public double XCoordinate { get { return _XCoordinate; } set { _XCoordinate = value; } }

//        public double YCoordinate { get; set; }
        //        private double _YCoordinate;

//        public double YCoordinate  { get { return _YCoordinate; } set { _YCoordinate = value; } }

        // Da die öffentliche Eigenschaftsmethode Radius lautet, 
        // muss das private Feld aus Gründen der Eindeutigkeit umbenannt werden.
        protected int _Radius;   // Dasselbe wie protected int _Radius = 0;
        public virtual int Radius   // virtual Kap 4.6.1
        {
            get { return _Radius; }
            set
            {
                if (value >= 0) _Radius = value;
                else {
                    // Kap. 5.2.1
                    // Ereignis auslösen
                    if (InvalidMeasure != null)
                    {
                        InvalidMeasure();       // 3. Eventbezeichner
                    }
                    //Console.Write("Unzulässiger negativer Wert.");
            }
        }
        }
        // --------- Konstruktoren ---------------
        public Circle() : this(0, 0, 0) { Console.WriteLine("Aufruf des Standardkonstruktors von Circle"); }                // immer 3 Parameter
        public Circle(int radius) : this(radius, 0, 0)     // immer 3 Parameter
        {
            Radius = radius;
        }
        // Konstruktor mit maximalen Parametern
        public Circle(int radius, double x, double y)
        {
            Radius = radius;
            XCoordinate = x;
            YCoordinate = y;
            Console.WriteLine("Aufruf des 3-fachen Parameterkonstruktors von Circle");
            Circle._CountCircles++;     // Klassenvariable Kap 3.9.1
//            Console.WriteLine("Radius= " + Radius + ", XCoordinate= " + XCoordinate + ", YCoordinate= " + YCoordinate);
        }

/*
        // statischer Konstruktor
        static Circle() { }
*/

        /*
                // Konstruktoren mit Weiterleitung (veraltet)
                public Circle()
                {

                }
                public Circle(int radius)
                {
                    Radius = radius;
                }
                // Aufruf des Konstruktors mit 1 Parameter durch this
                public Circle(int radius, double x, double y) : this(radius)
                {
                    XCoordinate = x;
                    YCoordinate = y;
        //            Radius = radius;      // wird weitergeleitet
                }
        */
        // ---------- Instanzmethoden ----------
        public override double GetArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }

        public override double GetCircumference()
        {
            return 2 * Radius * Math.PI;
        }

        public override /*virtual*/ void Move(double dx, double dy)  // virtual Kap 4.6.1
        {
            XCoordinate += dx;
            YCoordinate += dy;
        }

        public void Move(double dx, double dy, int dRadius)
        {
            XCoordinate += dx;
            YCoordinate += dy;
            Radius += dRadius;
        }

        // Bigger Rückgaben int
        // 1 wenn Radius des aufrufenden Objekts > übergebener Objekt.Radius
        // -1 wenn Radius des aufrufenden Objekts < übergebener Objekt.Radius
        // 0 wenn beide gleich
        public int Bigger(Circle kreis)
        {
            if (kreis == null || this.Radius > kreis.Radius) { return 1; }
            if (this.Radius < kreis.Radius) { return -1; }
            else return 0;
        }

        // -------- Klassenmethoden Kap 3.9.2 ------------
        public static double GetArea(int radius)
        {
            return Math.Pow(radius, 2) * Math.PI;
        }

        public static double GetCircumference(int radius)
        {
            return 2 * radius * Math.PI;
        }

        // 1 wenn Radius von kreis1 > kreis2.Radius
        // -1 wenn Radius von kreis1 < kreis2.Radius
        public static int Bigger(Circle kreis1, Circle kreis2)
        {
            if (kreis1 == null && kreis2 == null) { return 0; }
            if (kreis1 == null) { return -1; }
            if (kreis2 == null) return 1;
            if (kreis1.Radius > kreis2.Radius) { return 1; }
            if (kreis1.Radius < kreis2.Radius) { return -1; }
            return 0;
        }
    }
}
