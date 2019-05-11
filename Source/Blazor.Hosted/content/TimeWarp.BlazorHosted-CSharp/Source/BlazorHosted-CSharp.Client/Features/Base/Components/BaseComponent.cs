﻿namespace BlazorHosted_CSharp.Client.Features.Base.Components
{
  using BlazorState.Pipeline.ReduxDevTools;
  using BlazorHosted_CSharp.Client.Features.Application;
  using BlazorHosted_CSharp.Client.Features.Counter;
  using BlazorHosted_CSharp.Client.Features.WeatherForecast;
  using BlazorHosted_CSharp.Client.Features.EventStream;

  /// <summary>
  /// Makes access to the State a little easier and by inheriting from
  /// BlazorStateDevToolsComponent it allows for ReduxDevTools operation.
  /// </summary>
  /// <remarks>
  /// In production one would NOT be required to use these base components
  /// But would be required to properly implement the required interfaces.
  /// one could conditionally inherit from BaseComponent for production build.
  /// </remarks>
  public class BaseComponent : BlazorStateDevToolsComponent
  {
    internal ApplicationState ApplicationState => GetState<ApplicationState>();
    internal CounterState CounterState => GetState<CounterState>();
    internal EventStreamState EventStreamState => GetState<EventStreamState>();
    internal WeatherForecastsState WeatherForecastsState => GetState<WeatherForecastsState>();
  }
}