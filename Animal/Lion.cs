namespace Animal;

[Comment("lion")]
public class Lion :Animal
{
    public override string Country { get; set; }
    public override string Name { get; set; }
    public override bool HideFromOtherAnimals { get; set; }

    public override string WhatAnimal
    {
        get
        {
            return "Lion";
        }
    }
    
    public Lion() :base(){}
    
    public Lion(string country, string name, bool hideFromOtherAnimals) : base(country, name, hideFromOtherAnimals)
    {
    }
    
    public override void SayHello()
    {  
        Console.WriteLine("РРРРРРР");
    }

    public override void GetFavouriteFood()
    {
        Console.WriteLine(eFavoriteFood.Meat.ToString());
    }

    public override void GetClassificationAnimal()
    {
        Console.WriteLine(eClassificationAnimals.Herbivores.ToString());
    }
}