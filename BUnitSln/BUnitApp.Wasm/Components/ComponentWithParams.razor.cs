using Microsoft.AspNetCore.Components;

namespace BUnitApp.Wasm.Components;

public partial class ComponentWithParams : ComponentBase
{
    [Parameter] public int Numbers { get; set; }
    [Parameter] public List<string>? Lines { get; set; }
}