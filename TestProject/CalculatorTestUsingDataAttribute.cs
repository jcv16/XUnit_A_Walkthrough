using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClassLibrary;
using Xunit;
using Xunit.Abstractions;

namespace TestProject
{
    public class CalculatorTestUsingDataAttribute 
    {
        [Theory]
        [CsvTestDataAttribute("data.csv")]
        public void InlineDataTest_TestData(int first, int second, int expectedResult)
        {
            var calc = new Calculator();
            Assert.Equal(calc.Add(first, second), expectedResult);
        }
    }
}
