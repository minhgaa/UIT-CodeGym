namespace UIT_CodeGym.MVVM.Views;

public partial class IntroductionPage : ContentPage
{
	public IntroductionPage()
	{
		InitializeComponent();
	}
	protected override void OnSizeAllocated (double pageWidth, double pageHeight) {
    base.OnSizeAllocated(pageWidth, pageHeight);
    const double aspectRatio = 1600 / 1441.0; // Aspect ratio of the original image
    backgroundImage.WidthRequest = Math.Max(pageHeight * aspectRatio, pageWidth);
}
}