using System.Xml.Serialization;

namespace Animal;

[Comment("animal")]
[XmlInclude(typeof(Pig))]
[Serializable]
public abstract class Animal
{
    public abstract string Country { get; set; }
    public abstract string Name { get; set; }
    public abstract bool HideFromOtherAnimals { get; set; }
    public abstract string WhatAnimal { get; }

    public abstract void SayHello();
    public abstract void GetFavouriteFood();
    public abstract void GetClassificationAnimal();

    public Animal(){ }

    public Animal(string country, string name, bool hideFromOtherAnimals)
    {
        this.Country = country;
        this.Name = name;
        this.HideFromOtherAnimals = hideFromOtherAnimals;
    }
}