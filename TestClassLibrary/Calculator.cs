using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassLibrary
{
    public class Calculator:IDisposable
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public void Clear()
        {
            // Nothing
            ;
        }

        public void Dispose()
        {
            ;
        }
    }
}
