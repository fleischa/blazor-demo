using Microsoft.AspNetCore.Components;

namespace Blazor.Demo.Components;

public partial class Icon
{
	[Parameter]
	[EditorRequired]
	public string Name { get; set; } = null!;

	[Parameter]
	public string? Class { get; set; } = string.Empty;

	private string GetSymbolPath()
	{
		return $"_content/Blazor.Demo.Components/remixicon.symbol.svg#{this.Name}";
	}
}
