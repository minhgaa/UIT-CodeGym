using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;


namespace UIT_CodeGym;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("Raleway-Regular.ttf", "RalewayRegular");
				fonts.AddFont("Raleway-ExtraBold.ttf", "RalewayExtraBold");
                fonts.AddFont("Raleway-SemiBold.ttf", "RalewaySemiBold");
				fonts.AddFont("Raleway-Bold.ttf", "RalewayBold");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
