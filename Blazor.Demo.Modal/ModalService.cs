namespace Blazor.Demo.Modal;

public class ModalService
{
	public event EventHandler<OpenModalEventArgs>? OpenModalRequested;

	public event EventHandler<CloseModalEventArgs>? CloseModalRequested;

	public void OpenModal(Type componentType)
	{
		this.OpenModalRequested?.Invoke(this, new OpenModalEventArgs(componentType));
	}

	public void CloseModal()
	{
		this.CloseModalRequested?.Invoke(this, new CloseModalEventArgs());
	}
}