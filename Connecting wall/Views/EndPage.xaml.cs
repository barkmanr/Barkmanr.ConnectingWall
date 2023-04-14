using Connecting_wall.Logic;

namespace Connecting_wall.Views;

public partial class EndPage : ContentPage
{
	public EndPage(Team team1, Team team2)
	{
		InitializeComponent();
		if(team1.TeamScore > team2.TeamScore)
		{
			winnerlbl.Text = team1.TeamName;
			endImg.Source = "trophy.png";
		}
		else if(team1.TeamScore < team2.TeamScore)
		{
            winnerlbl.Text = team2.TeamName;
            endImg.Source = "trophy.png";
        }
		else if(team1.TeamScore == 0 & team2.TeamScore == 0)
		{
			WINNNNNER.Text = "LO00oSSSSERRRR";
			winnerlbl.Text = "You both SUCK!!!!: YOU LOSE good day sir";
            endImg.Source = "trash.png";
        }
        else if (team1.TeamScore == team2.TeamScore)
        {
            winnerlbl.Text = "TIE";
            endImg.Source = "tie.png";
			WINNNNNER.Text = WINNNNNER.Text + "$";
        }
    }
}