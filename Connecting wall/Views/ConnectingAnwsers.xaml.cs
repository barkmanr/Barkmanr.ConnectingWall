using Connecting_wall.Logic;

namespace Connecting_wall.Views;

public partial class ConnectingAnwsers : ContentPage
{
    Team _team1;
    Team _team2;
    int _round;
    List<Question> _questions;
    public ConnectingAnwsers(Team team1, Team team2, int round)
	{
		InitializeComponent();
        _team1 = team1;
        _team2 = team2;
        _round = round;
        Team1ScoreLabel.BindingContext = _team1;
        Team2ScoreLabel.BindingContext = _team2;
        setUpBoard();
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

    private async void BackClicked(object sender, EventArgs e)
    {
        Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 2]);
        await Navigation.PopAsync();
    }

    private void setUpBoard()
    {
        if (_round == 1)
        {
            _questions = (List<Question>)QuestionList.Round3A;
        }
        else
        {
            _questions = (List<Question>)QuestionList.Round3B;
        }
        Item1.Text = _questions[0].Item[0];
        Item2.Text = _questions[0].Item[1];
        Item3.Text = _questions[0].Item[2];
        Item4.Text = _questions[0].Item[3];
        Item5.Text = _questions[1].Item[0];
        Item6.Text = _questions[1].Item[1];
        Item7.Text = _questions[1].Item[2];
        Item8.Text = _questions[1].Item[3];
        Item9.Text = _questions[2].Item[0];
        Item10.Text = _questions[2].Item[1];
        Item11.Text = _questions[2].Item[2];
        Item12.Text = _questions[2].Item[3];
        Item13.Text = _questions[3].Item[0];
        Item14.Text = _questions[3].Item[1];
        Item15.Text = _questions[3].Item[2];
        Item16.Text = _questions[3].Item[3];
    }

    private void CheckedOne(object sender, EventArgs e)
    {
        Item1.Text = _questions[0].Description[0];
        Item2.Text = _questions[0].Description[1];
        Item3.Text = _questions[0].Description[2];
        Item4.Text = _questions[0].Description[3];
        Check1.Text = _questions[0].Connection;
        Check1.IsEnabled = false;
    }

    private void CheckedTwo(object sender, EventArgs e)
    {
        Item5.Text = _questions[1].Description[0];
        Item6.Text = _questions[1].Description[1];
        Item7.Text = _questions[1].Description[2];
        Item8.Text = _questions[1].Description[3];
        Check2.Text = _questions[1].Connection;
        Check2.IsEnabled = false;
    }

    private void CheckedThree(object sender, EventArgs e)
    {
        Item9.Text = _questions[2].Description[0];
        Item10.Text = _questions[2].Description[1];
        Item11.Text = _questions[2].Description[2];
        Item12.Text = _questions[2].Description[3];
        Check3.Text = _questions[2].Connection;
        Check3.IsEnabled = false;
    }

    private void CheckedFour(object sender, EventArgs e)
    {
        Item13.Text = _questions[3].Description[0];
        Item14.Text = _questions[3].Description[1];
        Item15.Text = _questions[3].Description[2];
        Item16.Text = _questions[3].Description[3];
        Check4.Text = _questions[3].Connection;
        Check4.IsEnabled = false;
    }
}