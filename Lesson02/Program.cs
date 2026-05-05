// See https://aka.ms/new-console-template for more information


using Adventure4Life;
using Zoo;

List<Animal> animals = new List<Animal>();
animals.Add(new StreetCat());
animals.Add(new Cat());
animals.Add(new Unicorn());
animals.Add(new PlatiUnicorn());

foreach (Animal a in animals)
{
    a.Walk();
}