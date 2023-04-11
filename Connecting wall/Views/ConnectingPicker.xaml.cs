using Connecting_wall.Logic;

namespace Connecting_wall.Views;

public partial class ConnectingPicker : ContentPage
{
    Team _team1;
    Team _team2;
    public ConnectingPicker(Team team1, Team team2)
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
        if (_team1.TeamScore > 0)
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

    private void FinishClicked(object sender, EventArgs e)
    {

    }

    private async void GoToConectingWallOne(object sender, EventArgs e)
    {
        OneBtn.IsEnabled= false;
        TwoBtn.BackgroundColor = Color.Parse("Grey");
        await Navigation.PushAsync(new ConnectingWall(_team1, _team2, 1));
    }

    private async void GoToConectingWallTwo(object sender, EventArgs e)
    {
        TwoBtn.IsEnabled= false;
        TwoBtn.BackgroundColor = Color.Parse("Grey");
        await Navigation.PushAsync(new ConnectingWall(_team1, _team2, 2));
    }
}