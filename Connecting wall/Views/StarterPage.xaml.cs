using Connecting_wall.Logic;
using Plugin.Maui.Audio;
using System.IO;

namespace Connecting_wall.Views;

/// <summary>
/// Starter page to get users to enter team name
/// </summary>
public partial class StarterPage : ContentPage
{
	IAudioManager _audioManager;

    public StarterPage(IAudioManager audioManager)
	{
		InitializeComponent();
		_audioManager = audioManager;
	}

	/// <summary>
	/// Makes sure two team names are entered before starting
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
    private async void GoToRoundOne(object sender, EventArgs e)
    {
		try
		{

			Team team1 = new Team(0, TeamOneEnt.Text);
			Team team2 = new Team(0, TeamTwoEnt.Text);
			QuestionList.SetUpAllQuestions(); //set up all questions 
			await Navigation.PushAsync(new RoundOnePicker(team1, team2, _audioManager));
		}
		catch (Exception ex)
		{
			await DisplayAlert("Error", $"{ex.Message}","ok")  ;
		}
    }
}