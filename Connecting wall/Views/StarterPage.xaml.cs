using Connecting_wall.Logic;

namespace Connecting_wall.Views;

public partial class StarterPage : ContentPage
{
	public StarterPage()
	{
		InitializeComponent();
	}

    private async void GoToRoundOne(object sender, EventArgs e)
    {
		Team team1 = new Team(0, TeamOneEnt.Text);
		Team team2 = new Team(0, TeamTwoEnt.Text);
		QuestionList.SetUpAllQuestions();
		await Navigation.PushAsync(new RoundOnePicker(team1,team2));
    }
}