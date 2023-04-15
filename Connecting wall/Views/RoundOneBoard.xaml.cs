using Connecting_wall.Logic;
using Plugin.Maui.Audio;

namespace Connecting_wall.Views;
/// <summary>
/// All the cs code for the round one board containing methods that allows for binding between buttons and logic.
/// </summary>
public partial class RoundOneBoard : ContentPage
{
    Team _team1; //Team 1 variable
    Team _team2; // Team 2 variable
    IAudioManager _audioManager;  
    int _round; // Keeps track of the round and enables specific question according to the round number.
    private int Item = 1; //Setting the item value to one initially so it starts at item one output.
    // Initializes player objects and makes them global so that they can be obtained from anywhere within the module.
    private IAudioPlayer player1;
    private IAudioPlayer player2;
    private IAudioPlayer player3;
    private IAudioPlayer player4;
    /// <summary>
    /// Round One board constructor.
    /// </summary>
    /// <param name="team1"></param>
    /// <param name="team2"></param>
    /// <param name="round"></param>
    /// <param name="audioManager">audio manager parameter used to create player for audio</param>
    public RoundOneBoard(Team team1, Team team2, int round, IAudioManager audioManager)
	{
		InitializeComponent();
        _team1 = team1;
        _team2 = team2;
        _round = round;
        Team1ScoreLabel.BindingContext = _team1;
        Team2ScoreLabel.BindingContext = _team2;
        _audioManager = audioManager;
        if (QuestionList.GetRound1Question(_round).Type == QuestionType.Audio)
        setupaudio();
    }
    /// <summary>
    /// Function for creating all the players while also setting them up to contain the audio files.
    /// </summary>
    public async void setupaudio()
    {
        player1 = _audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync(QuestionList.GetRound1Question(_round).Item[0] + ".mp3"));
        player2 = _audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync(QuestionList.GetRound1Question(_round).Item[1] + ".mp3"));
        player3 = _audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync(QuestionList.GetRound1Question(_round).Item[2] + ".mp3"));
        player4 = _audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync(QuestionList.GetRound1Question(_round).Item[3] + ".mp3"));
    }
    /// <summary>
    /// Event handler for when the reveal button is clicked that contains if/else statements for the three types of questions: text, image, and audio.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void WhenRevealedClicked(object sender, EventArgs e)
    {
        if (QuestionList.GetRound1Question(_round).Type == QuestionType.Image)
        {
            if (Item == 1)
            {
                Item1.Source = QuestionList.GetRound1Question(_round).Item[0] + ".png";
            }
            if (Item == 2)
            {
                Item2.Source = QuestionList.GetRound1Question(_round).Item[1] + ".png";
            }
            if (Item == 3)
            {
                Item3.Source = QuestionList.GetRound1Question(_round).Item[2] + ".png";
            }
            if (Item == 4)
            {
                Item4.Source = QuestionList.GetRound1Question(_round).Item[3] + ".png";
                RevealButton.IsEnabled = false;
            }
        }
        else if (QuestionList.GetRound1Question(_round).Type == QuestionType.Audio)
        {
            if (Item == 1)
            {
                player1.Play();
                string itemImageSource = null;
                Item1.Source = ImageSource.FromFile(itemImageSource);
                Item1Label.Text = "Playing Audio...";
            }
            if (Item == 2)
            {
                Item1Label.Text = "Audio Stopped...";
                player1.Stop();
                player2.Play();
                string itemImageSource = null;
                Item2.Source = ImageSource.FromFile(itemImageSource);
                Item2Label.Text = "Playing Audio...";
            }
            if (Item == 3)
            {
                Item2Label.Text = "Audio Stopped...";
                player2.Stop();
                player3.Play();
                string itemImageSource = null;
                Item3.Source = ImageSource.FromFile(itemImageSource);
                Item3Label.Text = "Playing Audio...";
            }
            if (Item == 4)
            {
                Item3Label.Text = "Audio Stopped...";
                player3.Stop();
                player4.Play();
                string itemImageSource = null;
                Item4.Source = ImageSource.FromFile(itemImageSource);
                Item4Label.Text = "Playing Audio...";
            }

        }
        else
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
        }
            Item += 1;
    }
    /// <summary>
    /// Event handler for the answer button when clicked reveals all the answers//descriptions and ensures audio is stopped if audio type question is in use.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void WhenAnswerClicked(object sender, EventArgs e)
    {
        if (QuestionList.GetRound1Question(_round).Type == QuestionType.Audio)
        {
            player1.Stop();
            player2.Stop();
            player3.Stop();
            player4.Stop();
            Item4Label.Text = "Audio Stopped...";
        }
        string answerMessage = "Connection: " + QuestionList.GetRound1Question(_round).Connection;
        Answer.Text = answerMessage;
        AnswerButton.IsEnabled = false;
        string itemImageSource = null;
        Item1.Source = ImageSource.FromFile(itemImageSource);
        Item2.Source = ImageSource.FromFile(itemImageSource);
        Item3.Source = ImageSource.FromFile(itemImageSource);
        Item4.Source = ImageSource.FromFile(itemImageSource);
        Item1Label.Text = QuestionList.GetRound1Question(_round).Item[0] +  "\nDescription:\n" + QuestionList.GetRound1Question(_round).Description[0];
        Item2Label.Text = QuestionList.GetRound1Question(_round).Item[1] + "\nDescription:\n" + QuestionList.GetRound1Question(_round).Description[1];
        Item3Label.Text = QuestionList.GetRound1Question(_round).Item[2] + "\nDescription:\n" + QuestionList.GetRound1Question(_round).Description[2];
        Item4Label.Text = QuestionList.GetRound1Question(_round).Item[3] + "\nDescription:\n" + QuestionList.GetRound1Question(_round).Description[3];
        Frame1.IsVisible = true;
        Frame2.IsVisible = true; 
        Frame3.IsVisible = true; 
        Frame4.IsVisible = true;
    }
    /// <summary>
    /// Event handler for raising team 1 score
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void WhenUpClicked1(object sender, EventArgs e)
    {
        _team1.TeamScore++;
    }
    /// <summary>
    /// Event handler for lowering team 1 score
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void WhenDownClicked1(object sender, EventArgs e)
    {
        if (_team1.TeamScore > 0)
            _team1.TeamScore--;
    }
    /// <summary>
    /// Event handler for raising team 2 score
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void WhenUpClicked2(object sender, EventArgs e)
    {
        _team2.TeamScore++;
    }
    /// <summary>
    /// Event handler for lowering team 2 score
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void WhenDownClicked2(object sender, EventArgs e)
    {
        if (_team2.TeamScore > 0)
            _team2.TeamScore--;
    }
    /// <summary>
    /// Event handler for back button which takes user back to round one picker.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void BackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}