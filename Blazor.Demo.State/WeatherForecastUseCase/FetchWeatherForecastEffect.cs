using System.Net.Http.Json;
using Blazor.Demo.Shared;
using Fluxor;

namespace Blazor.Demo.State;

public class FetchWeatherForecastEffect : Effect<FetchWeatherForecastAction>
{
	private readonly IHttpClientFactory httpClientFactory;

	public FetchWeatherForecastEffect(IHttpClientFactory httpClientFactory)
	{
		this.httpClientFactory = httpClientFactory;
	}

	public override async Task HandleAsync(FetchWeatherForecastAction action, IDispatcher dispatcher)
	{
		try
		{
			HttpClient httpClient = this.httpClientFactory.CreateClient("Blazor.Demo.ServerAPI");
			WeatherForecast[]? weatherForecasts = await httpClient.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
			dispatcher.Dispatch(new FetchWeatherForecastResultAction(weatherForecasts));
		}
		catch (Exception e)
		{
			Console.WriteLine(e);
			throw;
		}
	}
}