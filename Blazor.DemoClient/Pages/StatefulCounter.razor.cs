using Blazor.Demo.State;
using Fluxor;
using Microsoft.AspNetCore.Components;

namespace Blazor.Demo.Client.Pages;

public partial class StatefulCounter
{
	[Inject]
	private IState<CounterState> CounterState { get; set; } = null!;

	[Inject]
	private IDispatcher Dispatcher { get; set; } = null!;

	private void IncrementCount()
	{
		this.Dispatcher.Dispatch(new IncrementCounterAction(3));
	}
}