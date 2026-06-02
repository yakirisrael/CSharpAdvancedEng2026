namespace Lesson07;

public class Player
{
    public string name { get; set; }
    public int score { get;set;}

    public Player(string name, int score)
    {
        this.name = name;
        this.score = score;
    }
}