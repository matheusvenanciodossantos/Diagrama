﻿using Microsoft.Extensions.Logging;

namespace diagrma;

public static class MauiProgram
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
				fonts.AddFont("Arrows.ttf", "Arrows");
			
			
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}