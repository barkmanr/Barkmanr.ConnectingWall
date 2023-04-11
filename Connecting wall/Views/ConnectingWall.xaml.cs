using Connecting_wall.Logic;

namespace Connecting_wall.Views;

public partial class ConnectingWall : ContentPage
{
    Team _team1;
    Team _team2;
    int _round;
    Random rnd = new Random();
    public ConnectingWall(Team team1, Team team2, int round)
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

    private void TimerButtonClicked(object sender, EventArgs e)
    {

    }

    private void CheckCliked(object sender, EventArgs e)
    {

    }

    private void NextClicked(object sender, EventArgs e)
    {

    }

    private void setUpBoard()
    {
        List<Question> questions;
        List<string> items= new List<string>();
        if (_round == 1)
        {
           questions = (List<Question>)QuestionList.Round3A;
        }
        else
        {
           questions = (List<Question>)QuestionList.Round3B;
        }

        for(int count = 0;count < questions.Count; count++)
        {
            items.Add(questions[count].Item[0]);
            items.Add(questions[count].Item[1]);
            items.Add(questions[count].Item[2]);
            items.Add(questions[count].Item[3]);
        }


        List<string> format = new List<string>();

        int index;
        for(int count = 0; count < 16; count++)
        {
            index = rnd.Next(items.Count);
            format.Add(items[index]);
            items.RemoveAt(index);
        }

        CWB1.Text = $"{format[0]}";
        CWB2.Text = $"{format[1]}";
        CWB3.Text = $"{format[2]}";
        CWB4.Text = $"{format[3]}";
        CWB5.Text = $"{format[4]}";
        CWB6.Text = $"{format[5]}";
        CWB7.Text = $"{format[6]}";
        CWB8.Text = $"{format[7]}";
        CWB9.Text = $"{format[8]}";
        CWB10.Text = $"{format[9]}";
        CWB11.Text = $"{format[10]}";
        CWB12.Text = $"{format[11]}";
        CWB13.Text = $"{format[12]}";
        CWB14.Text = $"{format[13]}";
        CWB15.Text = $"{format[14]}";
        CWB16.Text = $"{format[15]}";

    }
}