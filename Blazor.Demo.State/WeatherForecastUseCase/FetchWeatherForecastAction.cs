using Fluxor;

namespace Blazor.Demo.State;

public class FetchWeatherForecastAction
{
	[ReducerMethod]
	public static WeatherForecastState Reduce(WeatherForecastState state, FetchWeatherForecastAction action)
	{
		return new WeatherForecastState { IsFetching = true };
	}
}