using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Blazor.Demo.Components;

public partial class ButtonDecorator
{
	[Parameter]
	public RenderFragment? ChildContent { get; set; }

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

	private string ButtonTypeString
	{
		get
		{
			return this.Type switch
			{
				ButtonType.Button => "button",
				ButtonType.Submit => "submit",
				_ => throw new ArgumentOutOfRangeException()
			};
		}
	}

	private string IntentionClasses
	{
		get
		{
			return this.Intention switch
			{
				Intention.Remove =>
					"hover:from-red-200 hover:to-red-300 hover:border-red-400 focus:border-red-400 focus:ring focus:ring-red-400/50",
				_ => "hover:from-blue-100 hover:to-blue-200 hover:border-blue-400 focus:border-blue-400 focus:ring focus:ring-blue-400/50"
			};
		}
	}
}