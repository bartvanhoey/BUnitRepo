using System.Collections.Generic;
using BUnitApp.Wasm.Components;

namespace BUnitApp.Tests;

public class ComponentWithParamsTests : BunitContext
{
    [Fact]
    public void CounterStartsAtZero()
    {
        
        var lines = new List<string> { "line1", "line2" };
        
        
        
        // Arrange
        var cut = Render<ComponentWithParams>(parameters => parameters.Add(p => p.Numbers, 10).Add(p => p.Lines, lines));

        // Assert that content of the paragraph shows counter at zero
        cut.Find("p").MarkupMatches("<p>Current count: 0</p>");
    }
}