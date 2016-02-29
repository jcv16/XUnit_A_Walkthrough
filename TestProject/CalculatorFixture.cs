using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClassLibrary;

namespace TestProject
{
    public class CalculatorFixture : IDisposable
    {
        public Calculator Sut { get; private set; }
        public CalculatorFixture()
        {
            Sut = new Calculator();
        }

        public void Dispose()
        {
            Sut.Dispose();
        }
    }
}
