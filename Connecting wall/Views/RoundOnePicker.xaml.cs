using Connecting_wall.Logic;
using Plugin.Maui.Audio;

namespace Connecting_wall.Views;
/// <summary>
/// 
/// </summary>
public partial class RoundOnePicker : ContentPage
{
    Team _team1;
    Team _team2;
    IAudioManager _audioManager;
    /// <summary>
    /// 
    /// </summary>
    /// <param name="team1"></param>
    /// <param name="team2"></param>
    /// <param name="audioManager"></param>
	public RoundOnePicker(Team team1, Team team2, IAudioManager audioManager)
	{
		InitializeComponent();
        _team1 = team1;
        _team2 = team2;
        Team1ScoreLabel.BindingContext = _team1;
        Team2ScoreLabel.BindingContext = _team2;
        _audioManager = audioManager;
	}
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void WhenUpClicked1(object sender, EventArgs e)
    {
        _team1.TeamScore++;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void WhenDownClicked1(object sender, EventArgs e)
    {
        if(_team1.TeamScore > 0)
            _team1.TeamScore--;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void WhenUpClicked2(object sender, EventArgs e)
    {
        _team2.TeamScore++;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void WhenDownClicked2(object sender, EventArgs e)
    {
        if (_team2.TeamScore > 0)
            _team2.TeamScore--;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void NextClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RoundTwoPicker(_team1,_team2));
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void GoToBtnOne(object sender, EventArgs e)
    {
        Symbol1.IsEnabled = false;
        Symbol1.BackgroundColor = Color.Parse("Grey");
        await Navigation.PushAsync(new RoundOneBoard(_team1, _team2, 1, _audioManager));
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void GoToBtnTwo(object sender, EventArgs e)
    {
        Symbol2.IsEnabled = false;
        Symbol2.BackgroundColor = Color.Parse("Grey");
        await Navigation.PushAsync(new RoundOneBoard(_team1, _team2, 2, _audioManager));
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void GoToBtnThree(object sender, EventArgs e)
    {
        Symbol3.IsEnabled = false;
        Symbol3.BackgroundColor = Color.Parse("Grey");
        await Navigation.PushAsync(new RoundOneBoard(_team1, _team2, 3, _audioManager));
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void GoToBtnFour(object sender, EventArgs e)
    {
        Symbol4.IsEnabled = false;
        Symbol4.BackgroundColor = Color.Parse("Grey");
        await Navigation.PushAsync(new RoundOneBoard(_team1, _team2, 4, _audioManager));
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void GoToBtnFive(object sender, EventArgs e)
    {
        Symbol5.IsEnabled = false;
        Symbol5.BackgroundColor = Color.Parse("Grey");
        await Navigation.PushAsync(new RoundOneBoard(_team1, _team2, 5, _audioManager));
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void GoToBtnSix(object sender, EventArgs e)
    {
        Symbol6.IsEnabled = false;
        Symbol6.BackgroundColor = Color.Parse("Grey");
        await Navigation.PushAsync(new RoundOneBoard(_team1, _team2, 6, _audioManager));
    }
}