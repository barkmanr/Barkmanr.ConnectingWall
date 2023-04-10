using Connecting_wall.Logic;

namespace Connecting_wall.Views;

public partial class ConnectingWall : ContentPage
{
    Team _team1;
    Team _team2;
    int _round;
    public ConnectingWall(Team team1, Team team2, int round)
	{
		InitializeComponent();
        _team1 = team1;
        _team2 = team2;
        _round = round;
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

    private void TimerButtonClicked(object sender, EventArgs e)
    {

    }

    private void CheckCliked(object sender, EventArgs e)
    {

    }

    private void NextClicked(object sender, EventArgs e)
    {

    }
}