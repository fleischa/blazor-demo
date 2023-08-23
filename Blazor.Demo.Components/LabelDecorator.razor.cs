using Microsoft.AspNetCore.Components;

namespace Blazor.Demo.Components;

public partial class LabelDecorator
{
	[Parameter]
	[EditorRequired]
	public string Label { get; set; } = null!;

	[Parameter]
	public string? For { get; set; }

	[Parameter]
	public RenderFragment? ChildContent { get; set; }
}