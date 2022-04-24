using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFO_ClassLibraryTest
{
    public class Class1
    {
        public int CalculeSomme(int a, int b, params int[] c)
        {
            return a + b + (c == null ? 0 : c.Sum());
        }
    }
}
