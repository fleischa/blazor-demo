using Fluxor;

namespace Blazor.Demo.State;

[FeatureState]
public record CounterState
{
	public int Count { get; init; }
}