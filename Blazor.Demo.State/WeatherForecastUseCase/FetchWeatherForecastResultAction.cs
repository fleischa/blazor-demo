using Blazor.Demo.Shared;
using Fluxor;

namespace Blazor.Demo.State;

public class FetchWeatherForecastResultAction
{
	public FetchWeatherForecastResultAction(IEnumerable<WeatherForecast> weatherForecasts)
	{
		this.WeatherForecasts = weatherForecasts;
	}

	public IEnumerable<WeatherForecast> WeatherForecasts { get; }

	[ReducerMethod]
	public static WeatherForecastState Reduce(WeatherForecastState state, FetchWeatherForecastResultAction action)
	{
		return new WeatherForecastState { IsFetching = false, WeatherForecasts = action.WeatherForecasts };
	}
}