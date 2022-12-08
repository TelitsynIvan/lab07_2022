namespace Animal;

[Comment("cow")]
public class Cow : Animal
{
    public override string Country { get; set; }
    public override string Name { get; set; }
    public override bool HideFromOtherAnimals { get; set; }
    
    public Cow():base(){}

    public override string WhatAnimal {
        get
        {
            return "cow";
        }
         }

    public Cow(string country, string name, bool hideFromOtherAnimals) : base(country, name, hideFromOtherAnimals)
    {
    }

    public override void SayHello()
    {
        Console.WriteLine("МУУУУ");
    }

    public override void GetFavouriteFood()
    {
        Console.WriteLine(eFavoriteFood.Plants.ToString());
    }

    public override void GetClassificationAnimal()
    {
        Console.WriteLine(eClassificationAnimals.Herbivores.ToString());
    }
}