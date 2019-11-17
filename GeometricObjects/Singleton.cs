using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    class Singleton
    {
        private static Singleton _Instance = null;
        public int Value { get; set; }

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Singleton();
                }
                return _Instance;
            }
        }
    }
}
