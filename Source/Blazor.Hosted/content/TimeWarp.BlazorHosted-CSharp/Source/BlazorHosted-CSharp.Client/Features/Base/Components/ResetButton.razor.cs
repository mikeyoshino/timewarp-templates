﻿namespace BlazorHosted_CSharp.Client.Features.Base.Components
{
  using BlazorHosted_CSharp.Client.Features.Application;

  public class ResetButtonModel : BaseComponent
  {
    internal void ButtonClick() => Mediator.Send(new ResetStoreAction());
  }
}