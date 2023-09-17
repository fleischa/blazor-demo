namespace Blazor.Demo.Modal;

public class OpenModalEventArgs : EventArgs
{
	public OpenModalEventArgs(Type componentType)
	{
		this.ComponentType = componentType;
	}

	public Type ComponentType { get; }
}