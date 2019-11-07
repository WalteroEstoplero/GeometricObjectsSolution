﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    public class Circle
    {
        private double _XCoordinate;
        public double XCoordinate
        {
            get { return _XCoordinate; }
            set { _XCoordinate = value; }
        }

        private double _YCoordinate;
        public double YCoordinate
        {
            get { return _YCoordinate; }
            set { _YCoordinate = value; } }

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
             else Console.Write("Unzulässiger negativer Wert."); } }
    }
}