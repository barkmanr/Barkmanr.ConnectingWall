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
            Item1Label.Text = QuestionList.GetRound1Question(_round).Item[0];
        }
        if (Item == 2)
        {
            string itemImageSource = null;
            Item2.Source = ImageSource.FromFile(itemImageSource);
            Item2Label.Text = QuestionList.GetRound1Question(_round).Item[1];
        }
        if (Item == 3)
        {
            string itemImageSource = null;
            Item3.Source = ImageSource.FromFile(itemImageSource);
            Item3Label.Text = QuestionList.GetRound1Question(_round).Item[2];
        }
        if (Item == 4)
        {
            string itemImageSource = null;
            Item4.Source = ImageSource.FromFile(itemImageSource);
            RevealButton.IsEnabled = false;
            Item4Label.Text = QuestionList.GetRound1Question(_round).Item[3];
        }
        Item += 1;
    }

    private void WhenAnswerClicked(object sender, EventArgs e)
    {
        string answerMessage = QuestionList.GetRound1Question(_round).Connection;
        Answer.Text = answerMessage;
        AnswerButton.IsEnabled = false;
        string itemImageSource = null;
        Item1.Source = ImageSource.FromFile(itemImageSource);
        Item2.Source = ImageSource.FromFile(itemImageSource);
        Item3.Source = ImageSource.FromFile(itemImageSource);
        Item4.Source = ImageSource.FromFile(itemImageSource);
        Item1Label.Text = QuestionList.GetRound1Question(_round).Item[0] +  "\n\nDescription:\n" + QuestionList.GetRound1Question(_round).Description[0];
        Item2Label.Text = QuestionList.GetRound1Question(_round).Item[1] + "\n\nDescription:\n" + QuestionList.GetRound1Question(_round).Description[1];
        Item3Label.Text = QuestionList.GetRound1Question(_round).Item[2] + "\n\nDescription:\n" + QuestionList.GetRound1Question(_round).Description[2];
        Item4Label.Text = QuestionList.GetRound1Question(_round).Item[3] + "\n\nDescription:\n" + QuestionList.GetRound1Question(_round).Description[3];
        Frame1.IsVisible = true;
        Frame2.IsVisible = true; 
        Frame3.IsVisible = true; 
        Frame4.IsVisible = true;
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
        await Navigation.PopAsync();
    }
}