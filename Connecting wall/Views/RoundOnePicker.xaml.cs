using Connecting_wall.Logic;

namespace Connecting_wall.Views;

public partial class RoundOnePicker : ContentPage
{
    Team _team1;
    Team _team2;
	public RoundOnePicker(Team team1, Team team2)
	{
		InitializeComponent();
        _team1 = team1;
        _team2 = team2;
        Team1ScoreLabel.BindingContext = _team1;
        Team2ScoreLabel.BindingContext = _team2;
	}

    private void WhenUpClicked1(object sender, EventArgs e)
    {
        _team1.TeamScore++;
    }

    private void WhenDownClicked1(object sender, EventArgs e)
    {
        if(_team1.TeamScore > 0)
            _team1.TeamScore--;
    }

    private void WhenUpClicked2(object sender, EventArgs e)
    {
        _team2.TeamScore++;
    }

    private void WhenDownClicked2(object sender, EventArgs e)
    {
        if (_team2.TeamScore > 0)
            _team2.TeamScore--;
    }

    private async void NextClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ConnectingPicker(_team1,_team2));
    }

    private async void GoToBtnOne(object sender, EventArgs e)
    {
        IsEnabled = false;
        await Navigation.PushAsync(new RoundOneBoard(_team1, _team2, 1));
    }

    private async void GoToBtnTwo(object sender, EventArgs e)
    {
        IsEnabled = false;
        await Navigation.PushAsync(new RoundOneBoard(_team1, _team2, 2));
    }

    private async void GoToBtnThree(object sender, EventArgs e)
    {
        IsEnabled = false;
        await Navigation.PushAsync(new RoundOneBoard(_team1, _team2, 3));
    }

    private async void GoToBtnFour(object sender, EventArgs e)
    {
        IsEnabled = false;
        await Navigation.PushAsync(new RoundOneBoard(_team1, _team2, 4));
    }

    private async void GoToBtnFive(object sender, EventArgs e)
    {
        IsEnabled = false;
        await Navigation.PushAsync(new RoundOneBoard(_team1, _team2, 5));
    }

    private async void GoToBtnSix(object sender, EventArgs e)
    {
        IsEnabled = false;
        await Navigation.PushAsync(new RoundOneBoard(_team1, _team2, 6));
    }
}