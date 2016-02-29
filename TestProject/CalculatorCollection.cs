using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject
{
    // This collection will re used in multiple classes, one instantiation only : )
    [CollectionDefinition("Calculator Collection")]
    public class CalculatorCollection: ICollectionFixture<CalculatorFixture>
    {
    }
}
