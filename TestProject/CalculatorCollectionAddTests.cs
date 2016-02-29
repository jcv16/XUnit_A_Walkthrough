using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace TestProject
{
    [Collection("Calculator Collection")]   // One instance of this class accross multiple classes
    public class CalculatorCollectionAddTests : CalculatorTestBase
    {
        private CalculatorFixture _fixture;

        public CalculatorCollectionAddTests(ITestOutputHelper helper,
                                                CalculatorFixture fixture): base(helper)
        {
            _fixture = fixture;
            _fixture.Sut.Clear();
        }

        [Fact]
        [Trait("Category", "Single Fixture Accross Classes")]
        public void AddTest()
        {
            Assert.Equal(_fixture.Sut.Add(1, 1), 2);
        }
    }
}
