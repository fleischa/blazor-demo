using Blazor.Demo.Modal;
using Microsoft.AspNetCore.Components;

namespace Blazor.Demo.Client.Views;

public partial class DemoModalContent
{
	[Inject]
	public ModalService ModalService { get; set; } = null!;

	private void OnCloseClick()
	{
		this.ModalService.CloseModal();
	}
}