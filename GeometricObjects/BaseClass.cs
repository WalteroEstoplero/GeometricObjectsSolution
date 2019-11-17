using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    class BaseClass
    {
        public void DoSomething()
        {
            Console.WriteLine("In 'BaseClass.DoSomething()'");
        }
    }
    class SubClass1 : BaseClass { }

    class SubClass2 : SubClass1
    {
        public void BaseTest()
        {
            base.DoSomething();
        }
    }
}
