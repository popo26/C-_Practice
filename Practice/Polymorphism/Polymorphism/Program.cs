class Animal
{ 
    //public void breathe()
     public virtual void breathe() //With Polymorphism
    {
        Console.WriteLine("Animals breathe.");
    }
}

class Fish : Animal
{
    //public void breathe()
    public override void breathe() //With Polymorphism
    {
        Console.WriteLine("Fish breathes in the water.");
    }
}

class Dog : Animal
{
    public void voice()
    {
        Console.WriteLine("Woof Woof");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Animal animal = new Animal();
        animal.breathe();
        Console.WriteLine("");

        Animal fish1 = new Fish();
        fish1.breathe();
        Console.WriteLine("");

        Fish fish2 = new Fish();
        fish2.breathe();
        Console.WriteLine("");

        Animal dog1 = new Dog();
        dog1.breathe();
        //dog1.voice(); // no
        Console.WriteLine("");

        Dog dog2 = new Dog();
        dog2.breathe();
        dog2.voice();
        Console.WriteLine("");


        Console.ReadKey();
    }
}



