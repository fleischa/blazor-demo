using Microsoft.AspNetCore.Components;

namespace Blazor.Demo.Client.Shared;

public partial class ModalDecorator
{
	[Parameter]
	public RenderFragment? ChildContent { get; set; }

	[Parameter]
	public string? Title { get; set; }
}