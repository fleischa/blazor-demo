using System.Net.Http.Json;
using Blazor.Demo.Shared;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

namespace Blazor.Demo.Client.Pages;

public partial class FetchData
{
	private WeatherForecast[]? forecasts;

	protected override async Task OnInitializedAsync()
	{
		try
		{
			this.forecasts = await this.Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
		}
		catch (AccessTokenNotAvailableException exception)
		{
			exception.Redirect();
		}
	}
}