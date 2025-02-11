using Decorator.Component;
using Decorator.ConcreteComponents;
using Decorator.ConcreteDecorators;

internal class Program
{
    private static void Main(string[] args)
    {
        Oatmeal mediumOatmeal = new MediumOatmeal();
        mediumOatmeal = new RaspberriesDecorator(mediumOatmeal);
        mediumOatmeal = new BananaDecorator(mediumOatmeal);
        mediumOatmeal = new StraweberriesDecorator(mediumOatmeal);

        Console.WriteLine("{0:C2}", mediumOatmeal.CalculateCost());
        Console.WriteLine(mediumOatmeal.GetDescription());

        Console.ReadKey();
    }
}