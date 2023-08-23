using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Blazor.Demo.Components;

public partial class DescriptionButton
{
	[Parameter]
	public string? IconName { get; set; }

	[Parameter]
	public string? Header { get; set; }

	[Parameter]
	public string? Description { get; set; }

	[Parameter]
	public ButtonType Type { get; set; } = ButtonType.Button;

	[Parameter]
	public Intention Intention { get; set; } = Intention.General;

	[Parameter]
	public int TabIndex { get; set; }

	[Parameter]
	public bool IsDisabled { get; set; }

	[Parameter]
	public EventCallback<MouseEventArgs> OnClick { get; set; }
}