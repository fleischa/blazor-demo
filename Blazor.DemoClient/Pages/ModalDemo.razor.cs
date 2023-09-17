using Blazor.Demo.Client.Views;
using Blazor.Demo.Modal;
using Microsoft.AspNetCore.Components;

namespace Blazor.Demo.Client.Pages;

public partial class ModalDemo
{
	[Inject]
	public ModalService ModalService { get; set; } = null!;

	private void OnModalClick()
	{
		this.ModalService.OpenModal(typeof(DemoModalContent));
	}
}