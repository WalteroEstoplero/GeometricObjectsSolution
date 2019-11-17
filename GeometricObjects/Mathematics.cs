using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    // Kap 3.9.4
    // Statische Klassen dürfen nur statische Klassenmitglieder haben.
    // Der Modifizierer static ist auch bei den Membern anzugeben.
    // Statische Klassen enthalten keine Konstruktoren und können deshalb auch nicht instanziiert werden.
    // Der parameterlose Konstruktor ist implizit private
    public static class Mathematics
    {
        // Konstanten Kap 3.8.1
        public const double PI = 3.14159;

        // statische Methoden in statischen Klassen Kap 3.9.4
        public static double Add(params double[] values)
        {
            double sum = 0;
            foreach(double v in values)
            {
                sum += v;
            }
            return sum;
        }

        public static double Subtract(params double[] values)
        {
            double diff = values[0];
            for (int i = 1;i<values.Length;i++)
            {
                diff -= values[i];
            }
            return diff;
        }
    }
}
