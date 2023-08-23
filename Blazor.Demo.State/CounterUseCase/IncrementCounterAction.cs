using Fluxor;

namespace Blazor.Demo.State;

public class IncrementCounterAction
{
	public IncrementCounterAction(int increment = 1)
	{
		this.Increment = increment;
	}

	public int Increment { get; }

	[ReducerMethod]
	public static CounterState Reduce(CounterState state, IncrementCounterAction action)
	{
		return new CounterState { Count = state.Count + action.Increment };
	}
}