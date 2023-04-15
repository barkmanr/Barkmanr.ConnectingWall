using Connecting_wall.Logic;

namespace Connecting_wall.Views;
/// <summary>
/// All the cs code for the round one board containing methods that allows for binding between buttons and logic.
/// </summary>
public partial class RoundTwoPicker : ContentPage
{
    Team _team1;
    Team _team2;
    /// <summary>
    /// RoundTwoPicker constructor
    /// </summary>
    /// <param name="team1"></param>
    /// <param name="team2"></param>
    public RoundTwoPicker(Team team1, Team team2)
    {
        InitializeComponent();
        _team1 = team1;
        _team2 = team2;
        Team1ScoreLabel.BindingContext = _team1;
        Team2ScoreLabel.BindingContext = _team2;
    }
    /// <summary>
    /// Event handler for raising score
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void WhenUpClicked1(object sender, EventArgs e)
    {
        _team1.TeamScore++;
    }
    /// <summary>
    /// Event Handler for lowering score
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void WhenDownClicked1(object sender, EventArgs e)
    {
        if (_team1.TeamScore > 0)
            _team1.TeamScore--;
    }
    /// <summary>
    /// Event handler for raising score
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void WhenUpClicked2(object sender, EventArgs e)
    {
        _team2.TeamScore++;
    }
    /// <summary>
    /// Event Handler for lowering score
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void WhenDownClicked2(object sender, EventArgs e)
    {
        if (_team2.TeamScore > 0)
            _team2.TeamScore--;
    }

    /// <summary>
    /// Event Handler for next button that takes user to round three connecting wall picker.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void NextClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ConnectingPicker(_team1, _team2));
    }

    /// <summary>
    /// Event handler for symbol button 1
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void GoToBtnOne(object sender, EventArgs e)
    {
        //Disables button after initial use
        Symbol1.IsEnabled = false;
        //Changes button to grey to showcase that it is disabled
        Symbol1.BackgroundColor = Color.Parse("Grey");
        checkEnabled();
        await Navigation.PushAsync(new RoundTwoBoard(_team1, _team2, 1));
    }

    /// <summary>
    /// Event handler for symbol button 2
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void GoToBtnTwo(object sender, EventArgs e)
    {
        //Disables button after initial use
        Symbol2.IsEnabled = false;
        //Changes button to grey to showcase that it is disabled
        Symbol2.BackgroundColor = Color.Parse("Grey");
        checkEnabled();
        await Navigation.PushAsync(new RoundTwoBoard(_team1, _team2, 2));
    }
    /// <summary>
    /// Event handler for symbol button 3
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void GoToBtnThree(object sender, EventArgs e)
    {
        //Disables button after initial use
        Symbol3.IsEnabled = false;
        //Changes button to grey to showcase that it is disabled
        Symbol3.BackgroundColor = Color.Parse("Grey");
        checkEnabled();
        await Navigation.PushAsync(new RoundTwoBoard(_team1, _team2, 3));
    }
    /// <summary>
    /// Event handler for symbol button 4
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void GoToBtnFour(object sender, EventArgs e)
    {
        //Disables button after initial use
        Symbol4.IsEnabled = false;
        //Changes button to grey to showcase that it is disabled
        Symbol4.BackgroundColor = Color.Parse("Grey");
        checkEnabled();
        await Navigation.PushAsync(new RoundTwoBoard(_team1, _team2, 4));
    }
    /// <summary>
    /// Event handler for symbol button 5
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void GoToBtnFive(object sender, EventArgs e)
    {
        //Disables button after initial use
        Symbol5.IsEnabled = false;
        //Changes button to grey to showcase that it is disabled
        Symbol5.BackgroundColor = Color.Parse("Grey");
        checkEnabled();
        await Navigation.PushAsync(new RoundTwoBoard(_team1, _team2, 5));
    }
    /// <summary>
    /// Event handler for symbol button 6
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void GoToBtnSix(object sender, EventArgs e)
    {
        //Disables button after initial use
        Symbol6.IsEnabled = false;
        //Changes button to grey to showcase that it is disabled
        Symbol6.BackgroundColor = Color.Parse("Grey");
        checkEnabled();
        await Navigation.PushAsync(new RoundTwoBoard(_team1, _team2, 6));
    }

    private void checkEnabled()
    {
        if (Symbol1.IsEnabled == false & Symbol2.IsEnabled == false & Symbol3.IsEnabled == false
            & Symbol4.IsEnabled == false & Symbol5.IsEnabled == false & Symbol6.IsEnabled == false)
        {
            NextButton.IsEnabled = true;
        }
    }
}