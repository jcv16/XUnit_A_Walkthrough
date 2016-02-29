using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace TestProject
{
    public class CalculatorTestBase
    {
        public ITestOutputHelper Helper;
        public CalculatorTestBase(ITestOutputHelper helper)
        {
            Helper = helper;
        }
    }
}
