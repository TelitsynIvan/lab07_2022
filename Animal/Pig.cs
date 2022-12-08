namespace Animal;

[Comment("Pig")]
public class Pig :Animal
{
    public override string Country { get; set; }
    public override string Name { get; set; }
    public override bool HideFromOtherAnimals { get; set; }

    public override string WhatAnimal
    {
        get
        {
            return "Pig";
        }
    }

    public Pig() :base()
    {
    }

    public Pig(string country, string name, bool hideFromOtherAnimals):base (country,name, hideFromOtherAnimals)
    {
    }
    
    public override void SayHello()
    {
        Console.WriteLine("ХРЮ-ХРЮ");
    }

    public override void GetFavouriteFood()
    {
        Console.WriteLine(eFavoriteFood.Everything.ToString());
    }

    public override void GetClassificationAnimal()
    {
        Console.WriteLine(eClassificationAnimals.Omnivores.ToString());
    }
}