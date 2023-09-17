using Microsoft.AspNetCore.Components;

namespace Blazor.Demo.Modal;

public partial class ModalHost : IDisposable
{
	private RenderFragment? childContent;
	private ModalService? modalService;
	private string visibility = "collapse";

	[Inject]
	private ModalService? ModalService
	{
		get => this.modalService;
		set
		{
			if (this.modalService != null)
			{
				this.modalService.OpenModalRequested -= this.OnOpenModalRequested;
				this.modalService.CloseModalRequested -= this.OnCloseModalRequested;
			}

			this.modalService = value;

			if (this.modalService != null)
			{
				this.modalService.OpenModalRequested += this.OnOpenModalRequested;
				this.modalService.CloseModalRequested += this.OnCloseModalRequested;
			}
		}
	}

	[Parameter]
	public string ZIndex { get; set; } = "999";

	[Parameter]
	public string Background { get; set; } = "#7F7F7F7F";

	public void Dispose()
	{
		if (this.modalService != null)
		{
			this.modalService.OpenModalRequested -= this.OnOpenModalRequested;
			this.modalService.CloseModalRequested -= this.OnCloseModalRequested;
		}
	}

	private void OnOpenModalRequested(object? sender, OpenModalEventArgs e)
	{
		this.InvokeAsync(() =>
		{
			this.childContent = builder =>
			{
				builder.OpenComponent(0, e.ComponentType);
				builder.CloseComponent();
			};

			this.visibility = "visible";
			this.StateHasChanged();
		});
	}

	private void OnCloseModalRequested(object? sender, CloseModalEventArgs e)
	{
		this.InvokeAsync(() =>
		{
			this.visibility = "collapse";
			this.childContent = null;
			this.StateHasChanged();
		});
	}
}