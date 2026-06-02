// See https://aka.ms/new-console-template for more information

using Lesson07;

List<Player> players = new List<Player>()
{
    new Player("YakirIsrael", 80),
    new Player("MeAgain", 40),
    new Player("ThirdTimeIceCream", 70)
};


//Console.WriteLine(
 //   $"name = {players[0].name.SpaceString()} , score {players[0].score}");

var newPlayers = players.Select(
    p => new Player(p.name.SpaceString(), p.score)).OrderBy(p => p.score).Where(p => p.score >= 50);

foreach (var p in newPlayers)
{
    Console.WriteLine($"name = {p.name}, score {p.score}");
}



/*
string s = "somthing";

Console.WriteLine(s.IsFirstLetterUpperCase());
s = "New";
Console.WriteLine(s.IsFirstLetterUpperCase());
s = "";
Console.WriteLine(s.IsFirstLetterUpperCase());*/

