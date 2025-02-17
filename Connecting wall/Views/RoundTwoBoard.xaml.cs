using Connecting_wall.Logic;
using Microsoft.Maui.Controls;

namespace Connecting_wall.Views;
/// <summary>
/// Identical to round 1 board logic apart from lacking a fourth item
/// </summary>
public partial class RoundTwoBoard : ContentPage
{

    Team _team1;
    Team _team2;
    int _round;
    private int Item = 1;
    public RoundTwoBoard(Team team1, Team team2, int round)
	{
		InitializeComponent();
        _team1 = team1;
        _team2 = team2;
        _round = round;
        Team1ScoreLabel.BindingContext = _team1;
        Team2ScoreLabel.BindingContext = _team2;
    }
    //Event handler for reveal button but only reveals 3 items instead of the earlier 4
    private void WhenRevealedClicked(object sender, EventArgs e)
    {
        if (QuestionList.GetRound2Question(_round).Type == QuestionType.Image)
        {
            if (Item == 1)
            {
                Item1.Source = QuestionList.GetRound2Question(_round).Item[0] + ".png";
            }
            if (Item == 2)
            {
                Item2.Source = QuestionList.GetRound2Question(_round).Item[1] + ".png";
            }
            if (Item == 3)
            {
                Item3.Source = QuestionList.GetRound2Question(_round).Item[2] + ".png";
            }
        }
        else
        {
            if (Item == 1)
            {
                string itemImageSource = null;
                Item1.Source = ImageSource.FromFile(itemImageSource);
                Item1Label.Text = QuestionList.GetRound2Question(_round).Item[0];
            }
            if (Item == 2)
            {
                string itemImageSource = null;
                Item2.Source = ImageSource.FromFile(itemImageSource);
                Item2Label.Text = QuestionList.GetRound2Question(_round).Item[1];
            }
            if (Item == 3)
            {
                string itemImageSource = null;
                Item3.Source = ImageSource.FromFile(itemImageSource);
                Item3Label.Text = QuestionList.GetRound2Question(_round).Item[2];
            }
        }
        Item += 1;
    }
    //Event handler for answer button
    private void WhenAnswerClicked(object sender, EventArgs e)
    {
        string answerMessage = "Connection: " + QuestionList.GetRound2Question(_round).Connection;
        Answer.Text = answerMessage;
        AnswerButton.IsEnabled = false;
        string itemImageSource = null;
        Item1.Source = ImageSource.FromFile(itemImageSource);
        Item2.Source = ImageSource.FromFile(itemImageSource);
        Item3.Source = ImageSource.FromFile(itemImageSource);
        Item4.Source = ImageSource.FromFile(itemImageSource);
        Item1Label.Text = QuestionList.GetRound2Question(_round).Item[0] + "\nDescription:\n" + QuestionList.GetRound2Question(_round).Description[0];
        Item2Label.Text = QuestionList.GetRound2Question(_round).Item[1] + "\nDescription:\n" + QuestionList.GetRound2Question(_round).Description[1];
        Item3Label.Text = QuestionList.GetRound2Question(_round).Item[2] + "\nDescription:\n" + QuestionList.GetRound2Question(_round).Description[2];
        AnswerLabel.Text = QuestionList.GetRound2Question(_round).Item[3];
        Frame1.IsVisible = true;
        Frame2.IsVisible = true;
        Frame3.IsVisible = true;
        //Reveals the fourth item that is the answer for round 2
        //Checks if it is an question type question before proceeding
        if (QuestionList.GetRound2Question(_round).Type == QuestionType.Image)
        {
            Item4.Source = QuestionList.GetRound2Question(_round).Item[3] + ".png";
        }
        else
        {
            Item4Label.Text = "\nDescription:\n" + QuestionList.GetRound2Question(_round).Description[3];
            Frame4.IsVisible = true;
        }
        RevealButton.IsEnabled = false;
    }

    //Buttons for team score and back button that takes user back to the Round2Picker
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
        _team2.TeamScore++;
    }

    private async void BackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}