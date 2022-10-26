using Microsoft.VisualBasic;
using System;

class Cat
{
    public Cat(string name, int age, string hunger)
    {
        Name = name;
        Age = age;
        Hunger = hunger;
    }

    public string Name { get; set; }  // имя
    public int Age { get; set; }  // возраст

    public string Hunger { get; set; }
    public void Meow()

    {
        Console.WriteLine("Введите число от 1 до бесконечности, на сколько голоден кот");
        string Hunger  = Console.ReadLine();
        switch (Hunger)

        {
            case "0":
                Console.WriteLine("Мур");
                break;
            case "1":
                Console.WriteLine("Мяу");
                break;
            case "2":
                Console.WriteLine("Мяяу");
                break;
            case "3":
                Console.WriteLine("Мяяяу");
                break;

            default:
                Console.WriteLine("Безудерно орет Мяу");
                break;
        }

        Console.ReadLine();
    }

}
class Program
{

    public static void Main ()
    {
        var myCat = new Cat("Беляш", 15, "Голод");

        myCat.Meow();
    }
}
   
