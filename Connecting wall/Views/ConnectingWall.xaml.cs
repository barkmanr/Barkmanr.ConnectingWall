using Connecting_wall.Logic;

namespace Connecting_wall.Views;

public partial class ConnectingWall : ContentPage
{
    Team _team1;
    Team _team2;
    int _round;
    Random rnd = new Random();
    int _itemsSelectedNo;
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

    private void OneClicked(object sender, EventArgs e)
    {
        if (CWB1.BackgroundColor == Color.Parse("Lightblue"))
        {
            _itemsSelectedNo--;
            CWB1.BackgroundColor = Color.Parse("PeachPuff");
        }
        else
        {
            if (_itemsSelectedNo < 4)
            {
                _itemsSelectedNo++;
                CWB1.BackgroundColor = Color.Parse("Lightblue");
            }
        }
    }

    private void TwoClicked(object sender, EventArgs e)
    {
        if (CWB2.BackgroundColor == Color.Parse("Lightblue"))
        {
            _itemsSelectedNo--;
            CWB2.BackgroundColor = Color.Parse("PeachPuff");
        }
        else
        {
            if (_itemsSelectedNo < 4)
            {
                _itemsSelectedNo++;
                CWB2.BackgroundColor = Color.Parse("Lightblue");
            }
        }
    }

    private void ThreeClicked(object sender, EventArgs e)
    {
        if (CWB3.BackgroundColor == Color.Parse("Lightblue"))
        {
            _itemsSelectedNo--;
            CWB3.BackgroundColor = Color.Parse("PeachPuff");
        }
        else
        {
            if (_itemsSelectedNo < 4)
            {
                _itemsSelectedNo++;
                CWB3.BackgroundColor = Color.Parse("Lightblue");
            }
        }
    }

    private void FourClicked(object sender, EventArgs e)
    {
        if (CWB4.BackgroundColor == Color.Parse("Lightblue"))
        {
            _itemsSelectedNo--;
            CWB4.BackgroundColor = Color.Parse("PeachPuff");
        }
        else
        {
            if (_itemsSelectedNo < 4)
            {
                _itemsSelectedNo++;
                CWB4.BackgroundColor = Color.Parse("Lightblue");
            }
        }
    }

    private void FiveClicked(object sender, EventArgs e)
    {
        if (CWB5.BackgroundColor == Color.Parse("Lightblue"))
        {
            _itemsSelectedNo--;
            CWB5.BackgroundColor = Color.Parse("PeachPuff");
        }
        else
        {
            if (_itemsSelectedNo < 4)
            {
                _itemsSelectedNo++;
                CWB5.BackgroundColor = Color.Parse("Lightblue");
            }
        }
    }

    private void SixClicked(object sender, EventArgs e)
    {
        if (CWB6.BackgroundColor == Color.Parse("Lightblue"))
        {
            _itemsSelectedNo--;
            CWB6.BackgroundColor = Color.Parse("PeachPuff");
        }
        else
        {
            if (_itemsSelectedNo < 4)
            {
                _itemsSelectedNo++;
                CWB6.BackgroundColor = Color.Parse("Lightblue");
            }
        }
    }

    private void SevenClicked(object sender, EventArgs e)
    {
        if (CWB7.BackgroundColor == Color.Parse("Lightblue"))
        {
            _itemsSelectedNo--;
            CWB7.BackgroundColor = Color.Parse("PeachPuff");
        }
        else
        {
            if (_itemsSelectedNo < 4)
            {
                _itemsSelectedNo++;
                CWB7.BackgroundColor = Color.Parse("Lightblue");
            }
        }
    }

    private void EightClicked(object sender, EventArgs e)
    {
        if (CWB8.BackgroundColor == Color.Parse("Lightblue"))
        {
            _itemsSelectedNo--;
            CWB8.BackgroundColor = Color.Parse("PeachPuff");
        }
        else
        {
            if (_itemsSelectedNo < 4)
            {
                _itemsSelectedNo++;
                CWB8.BackgroundColor = Color.Parse("Lightblue");
            }
        }
    }

    private void NineClicked(object sender, EventArgs e)
    {
        if (CWB9.BackgroundColor == Color.Parse("Lightblue"))
        {
            _itemsSelectedNo--;
            CWB9.BackgroundColor = Color.Parse("PeachPuff");
        }
        else
        {
            if (_itemsSelectedNo < 4)
            {
                _itemsSelectedNo++;
                CWB9.BackgroundColor = Color.Parse("Lightblue");
            }
        }
    }

    private void TenClicked(object sender, EventArgs e)
    {
        if (CWB10.BackgroundColor == Color.Parse("Lightblue"))
        {
            _itemsSelectedNo--;
            CWB10.BackgroundColor = Color.Parse("PeachPuff");
        }
        else
        {
            if (_itemsSelectedNo < 4)
            {
                _itemsSelectedNo++;
                CWB10.BackgroundColor = Color.Parse("Lightblue");
            }
        }
    }

    private void ElevenClicked(object sender, EventArgs e)
    {
        if (CWB11.BackgroundColor == Color.Parse("Lightblue"))
        {
            _itemsSelectedNo--;
            CWB11.BackgroundColor = Color.Parse("PeachPuff");
        }
        else
        {
            if (_itemsSelectedNo < 4)
            {
                _itemsSelectedNo++;
                CWB11.BackgroundColor = Color.Parse("Lightblue");
            }
        }
    }

    private void TwelveClicked(object sender, EventArgs e)
    {
        if (CWB12.BackgroundColor == Color.Parse("Lightblue"))
        {
            _itemsSelectedNo--;
            CWB12.BackgroundColor = Color.Parse("PeachPuff");
        }
        else
        {
            if (_itemsSelectedNo < 4)
            {
                _itemsSelectedNo++;
                CWB12.BackgroundColor = Color.Parse("Lightblue");
            }
        }
    }

    private void ThirteenClicked(object sender, EventArgs e)
    {
        if (CWB13.BackgroundColor == Color.Parse("Lightblue"))
        {
            _itemsSelectedNo--;
            CWB13.BackgroundColor = Color.Parse("PeachPuff");
        }
        else
        {
            if (_itemsSelectedNo < 4)
            {
                _itemsSelectedNo++;
                CWB13.BackgroundColor = Color.Parse("Lightblue");
            }
        }
    }

    private void FourteenClicked(object sender, EventArgs e)
    {
        if (CWB14.BackgroundColor == Color.Parse("Lightblue"))
        {
            _itemsSelectedNo--;
            CWB14.BackgroundColor = Color.Parse("PeachPuff");
        }
        else
        {
            if (_itemsSelectedNo < 4)
            {
                _itemsSelectedNo++;
                CWB14.BackgroundColor = Color.Parse("Lightblue");
            }
        }
    }

    private void FifthteenClicked(object sender, EventArgs e)
    {
        if (CWB15.BackgroundColor == Color.Parse("Lightblue"))
        {
            _itemsSelectedNo--;
            CWB15.BackgroundColor = Color.Parse("PeachPuff");
        }
        else
        {
            if (_itemsSelectedNo < 4)
            {
                _itemsSelectedNo++;
                CWB15.BackgroundColor = Color.Parse("Lightblue");
            }
        }
    }

    private void SixteenClicked(object sender, EventArgs e)
    {
        if (CWB16.BackgroundColor == Color.Parse("Lightblue"))
        {
            _itemsSelectedNo--;
            CWB16.BackgroundColor = Color.Parse("PeachPuff");
        }
        else
        {
            if (_itemsSelectedNo < 4)
            {
                _itemsSelectedNo++;
                CWB16.BackgroundColor = Color.Parse("Lightblue");
            }
        }
    }
}