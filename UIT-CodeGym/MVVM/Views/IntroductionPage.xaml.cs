using CommunityToolkit.Maui.Views;

namespace UIT_CodeGym.MVVM.Views;

public partial class IntroductionPage : ContentPage
{
	public IntroductionPage()
	{
		InitializeComponent();
	}

	private void SignInPopUp(object sender, EventArgs e)
	{
		var SignInForm = new PopupLoginForm();
		this.ShowPopup(SignInForm);
	}

}