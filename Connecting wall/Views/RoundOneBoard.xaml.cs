namespace Connecting_wall.Views;

public partial class RoundOneBoard : ContentPage
{
    int Team1Score = 0;
    int Team2Score = 0;
    private int Item = 1;
    public RoundOneBoard()
	{
		InitializeComponent();
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
        Team1Score += 1;
        string scoreMessage = $"Team 2 Score: {Team1Score}";
        Team2ScoreLabel.Text = scoreMessage;
    }

    private void WhenDownClicked1(object sender, EventArgs e)
    {
        if (Team1Score > 0)
        {
            Team1Score -= 1;
            string scoreMessage = $"Team 2 Score: {Team1Score}";
            Team2ScoreLabel.Text = scoreMessage;
        }
    }

    private void WhenUpClicked2(object sender, EventArgs e)
    {
        Team2Score += 1;
        string scoreMessage = $"Team 1 Score: {Team2Score}";
        Team1ScoreLabel.Text = scoreMessage;
    }

    private void WhenDownClicked2(object sender, EventArgs e)
    {
        if (Team2Score > 0)
        {
            Team2Score -= 1;
            string scoreMessage = $"Team 1 Score: {Team2Score}";
            Team1ScoreLabel.Text = scoreMessage;
        }
    }
}