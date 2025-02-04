namespace BUnitApp.Tests.HelloWorld;

public class HelloWorldTests : BunitContext
{
    [Fact]
    public void HelloWorldComponentRendersCorrectly()
    {
        
        var cut = Render<BUnitApp.Wasm.Components.HelloWorld>();

        
        cut.MarkupMatches("<h1>Hello world from Blazor</h1>");
    }
}