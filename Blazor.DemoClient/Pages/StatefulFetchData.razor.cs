using Blazor.Demo.State;
using Fluxor;
using Microsoft.AspNetCore.Components;

namespace Blazor.Demo.Client.Pages;

public partial class StatefulFetchData
{
	[Inject]
	private IState<WeatherForecastState> WeatherForecastState { get; set; } = null!;

	[Inject]
	private IDispatcher Dispatcher { get; set; } = null!;

	protected override void OnInitialized()
	{
		base.OnInitialized();
		this.Dispatcher.Dispatch(new FetchWeatherForecastAction());
	}
}