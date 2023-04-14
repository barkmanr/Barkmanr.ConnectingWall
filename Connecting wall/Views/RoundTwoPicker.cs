namespace Connecting_wall.Views;

public class RoundTwoPicker : ContentPage
{
	public RoundTwoPicker()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};
	}
}