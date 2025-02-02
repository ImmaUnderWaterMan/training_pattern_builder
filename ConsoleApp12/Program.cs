using System;
using System.Collections.Generic;

public class House
{
    public string Material { get; }
    public List<string> Features { get; }

    public House(string material)
    {
        Material = material;
        Features = new List<string>();
    }

    public void AddFeature(string feature)
    {
        if (!Features.Contains(feature))
        {
            Features.Add(feature);
        }
    }
}

public class Catalog
{
    private readonly List<House> _houses = new List<House>();

    public void AddHouse(House house)
    {
        _houses.Add(house);
    }

    public void Display()
    {
        Console.WriteLine("Каталог домов:");
        for (int i = 0; i < _houses.Count; i++)
        {
            var house = _houses[i];
            Console.WriteLine($"Дом {i + 1}:");
            Console.WriteLine($"  Материал: {house.Material}");

            string features = house.Features.Count > 0
                ? string.Join(", ", house.Features)
                : "отсутствуют";

            Console.WriteLine($"  Дополнительные постройки: {features}\n");
        }
    }
}

class Program
{
    static void Main()
    {
        Catalog catalog = new Catalog();

        House house1 = new House("камень");
        house1.AddFeature("бассейн");
        house1.AddFeature("гараж");
        catalog.AddHouse(house1);

        House house2 = new House("кирпич");
        house2.AddFeature("палисадник");
        house2.AddFeature("тропинка");
        catalog.AddHouse(house2);

        House house3 = new House("камень");
        catalog.AddHouse(house3);

        catalog.Display();
    }
}