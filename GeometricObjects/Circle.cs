using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    public class Circle
    {
        private double _XCoordinate;
//        private double _XCoordinate { get; set; }
//        public double XCoordinate { get => _XCoordinate; set => _XCoordinate = value; }
        public double XCoordinate { get { return _XCoordinate; } set { _XCoordinate = value; }  }
        private double _YCoordinate;
        public double YCoordinate
        {
            get { return _YCoordinate; }
            set { _YCoordinate = value; }
        }
     

        // Dasselbe wie public int Radius = 0;
        // public int Radius;
        // Da die öffentliche Eigenschaftsmethode Radius lautet, 
        // musste das private Feld aus Gründen der Eindeutigkeit umbenannt werden.
        private int _Radius;
        // Eigenschaftsmethode get und set
        public int Radius
        {
            get {return _Radius;}
            set {if (value >= 0) _Radius = value;
             else Console.Write("Unzulässiger negativer Wert."); }
        }

        public double GetArea()
        {
            double area = Math.Pow(Radius, 2) * Math.PI;
            return area;
        }

        public double GetCircumference()
        {
            double circumference = 2 * Radius * Math.PI;
            return circumference;
        }

        public void Move(double dx, double dy)
        {
            XCoordinate += dx;
            YCoordinate += dy;
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
    }
}
