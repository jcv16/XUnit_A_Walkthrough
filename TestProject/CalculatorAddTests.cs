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
    public class CalculatorAddTests :  CalculatorTestBase, IClassFixture<CalculatorFixture>
    {
        private readonly CalculatorFixture _fixture;
        
        public CalculatorAddTests(ITestOutputHelper h, CalculatorFixture fixture): base(h)
        {
            _fixture = fixture;
            _fixture.Sut.Clear();
        }

        [Fact]
        [Trait("category", "Error Checking")]
        public void TestAdd()
        {
            Helper.WriteLine("Creating PlayerCharacter");
            var calculator = new Calculator();
            Assert.Equal(calculator.Add(1,1), 2);
        }

        [Fact]
        public void TestAdd1()
        {
            var calculator = new Calculator();
            Assert.Equal(calculator.Add(2, 1), 3);
        }

        [Fact]
        [Trait("category", "Error Checking1")]
        public void TestAdd2()
        {
            var calculator = new Calculator();
            Assert.Equal(calculator.Add(2, 1), 3);
        }


        [Fact]
        [Trait("category", "Fixture Checking")]
        public void TestFixture()
        {
           Assert.Equal(_fixture.Sut.Add(1, 1), 2);
        }

        [Fact]
        [Trait("category", "Fixture Checking")]
        public void TestFixture2()
        {
            Assert.Equal(_fixture.Sut.Add(1, 2), 3);
        }

        [Theory]
        [InlineData(1,2,3)]
        [InlineData(4, 5, 9)]
        public void InlineDataTest(int first, int second, int expectedResult )
        {
            Assert.Equal(_fixture.Sut.Add(first, second), expectedResult);
        }

        [Theory]
        [MemberData("TestData", MemberType = typeof(CalculatorTestData))]
        public void InlineDataTest2(int first, int second, int expectedResult)
        {
            Assert.Equal(_fixture.Sut.Add(first, second), expectedResult);
        }
    }
}
