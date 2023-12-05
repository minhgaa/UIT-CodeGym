using UIT_CodeGym.MVVM.Views;
namespace UIT_CodeGym;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new IntroductionPage();

	}
}

