namespace Connecting_wall.Views;

public partial class ConnectingWall : ContentPage
{
    int Team1Score = 0;
    int Team2Score = 0;
    public ConnectingWall()
	{
		InitializeComponent();
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