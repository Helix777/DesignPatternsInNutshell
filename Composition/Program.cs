// Klasa reprezentująca silnik
public class Engine
{
    public void Ignite()
    {
        Console.WriteLine("Engine is started.");
    }

    public void Zatrzymaj()
    {
        Console.WriteLine("Silnik zatrzymany.");
    }
}

// Klasa reprezentująca koło
public class Tire
{
    public void Pompuj()
    {
        Console.WriteLine("Koło zostało napompowane.");
    }
}

// Klasa reprezentująca układ sterowania
public class SteeringSystem
{
    public void TurnLeft()
    {
        Console.WriteLine("Skręcono w lewo.");
    }

    public void TurnRight()
    {
        Console.WriteLine("Skręcono w prawo.");
    }
}

// Class Car is using composition
public class Car
{
    private Engine _engine;
    private Tire[] _kola;
    private SteeringSystem _steeringSystem;

    public Car()
    {
        _engine = new Engine();
        _kola = new Tire[4]; // Samochód ma 4 koła
        for (int i = 0; i < _kola.Length; i++)
        {
            _kola[i] = new Tire();
        }
        _steeringSystem = new SteeringSystem();
    }

    public void Drive()
    {
        _engine.Ignite();
        Console.WriteLine("The car is driving");
    }

    public void Stop()
    {
        _engine.Zatrzymaj();
        Console.WriteLine("Samochód zatrzymany.");
    }

    public void InflateWheels()
    {
        foreach (var kolo in _kola)
        {
            kolo.Pompuj();
        }
    }

    public void TurnLeft()
    {
        _steeringSystem.TurnLeft();
    }

    public void TurnRight()
    {
        _steeringSystem.TurnRight();
    }
}

// Run program
internal class Program
{
    private static void Main(string[] args)
    {
        Car mojSamochod = new Car();
        mojSamochod.InflateWheels();
        mojSamochod.Drive();
        mojSamochod.TurnLeft();
        mojSamochod.TurnRight();
        mojSamochod.Stop();
    }
}