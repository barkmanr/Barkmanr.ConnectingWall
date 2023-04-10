using Connecting_wall.Logic;

namespace Connecting_wall.Views;

public partial class RoundOneBoard : ContentPage
{
    Team _team1;
    Team _team2;
    int _round;
    private int Item = 1;
    public RoundOneBoard(Team team1, Team team2, int round)
	{
		InitializeComponent();
        _team1 = team1;
        _team2 = team2;
        _round = round;
        Team1ScoreLabel.BindingContext = _team1;
        Team2ScoreLabel.BindingContext = _team2;
    }

    private void WhenRevealedClicked(object sender, EventArgs e)
    {
        if (Item == 1)
        {
            string itemImageSource = null;
            Item1.Source = ImageSource.FromFile(itemImageSource);
        }
        if (Item == 2)
        {
            string itemImageSource = null;
            Item2.Source = ImageSource.FromFile(itemImageSource);
        }
        if (Item == 3)
        {
            string itemImageSource = null;
            Item3.Source = ImageSource.FromFile(itemImageSource);
        }
        if (Item == 4)
        {
            string itemImageSource = null;
            Item4.Source = ImageSource.FromFile(itemImageSource);
            RevealButton.IsEnabled = false;
        }
        Item += 1;
    }

    private void WhenAnswerClicked(object sender, EventArgs e)
    {
        string answerMessage = "Answer: Connection";
        Answer.Text = answerMessage;
        AnswerButton.IsEnabled = false;
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

    private void BackClicked(object sender, EventArgs e)
    {

    }
}