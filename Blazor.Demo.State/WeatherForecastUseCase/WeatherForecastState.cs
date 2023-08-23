using Blazor.Demo.Shared;
using Fluxor;

namespace Blazor.Demo.State;

[FeatureState]
public record WeatherForecastState
{
	public bool IsFetching { get; init; }

	public IEnumerable<WeatherForecast> WeatherForecasts { get; init; } = Enumerable.Empty<WeatherForecast>();
}