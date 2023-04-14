using Connecting_wall.Logic;
using Plugin.Maui.Audio;

namespace Connecting_wall.Views;

public partial class StarterPage : ContentPage
{
	IAudioManager _audioManager;

    public StarterPage(IAudioManager audioManager)
	{
		InitializeComponent();
		_audioManager = audioManager;
	}

    private async void GoToRoundOne(object sender, EventArgs e)
    {
		try
		{
			Team team1 = new Team(0, TeamOneEnt.Text);
			Team team2 = new Team(0, TeamTwoEnt.Text);
			QuestionList.SetUpAllQuestions();
			await Navigation.PushAsync(new RoundOnePicker(team1, team2, _audioManager));
		}
		catch (Exception ex)
		{
			await DisplayAlert("Error", $"{ex.Message}","ok")  ;
		}
    }
}