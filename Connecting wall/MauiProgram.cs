﻿using Microsoft.Extensions.Logging;
using Plugin.Maui.Audio;
using Connecting_wall.Views;

namespace Connecting_wall;

public static class MauiProgram //test
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		builder.Services.AddSingleton(AudioManager.Current);
		builder.Services.AddTransient<StarterPage>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	} //test
}
