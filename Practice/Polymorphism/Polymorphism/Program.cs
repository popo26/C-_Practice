abstract class Vehicle : IVehicle
{
    //public void breathe()
    public abstract void Move(); //With Polymorphism
}

abstract class Automobile : Vehicle
{
    //public void breathe()
    public abstract void Drive(); //With Polymorphism    
}

class Sedan : Automobile
{
    public override void Drive()
    {
        throw new NotImplementedException();
    }

    public override void Move()
    {
        throw new NotImplementedException();
    }

    public void CarryPassengers()
    {
        Console.WriteLine("Woof Woof");
    }
}

abstract class Aircraft : Vehicle
{
    public abstract void Fly();
}

class Drone : Aircraft
{
    public override void Fly()
    {
        throw new NotImplementedException();
    }

    public override void Move()
    {
        throw new NotImplementedException();
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



