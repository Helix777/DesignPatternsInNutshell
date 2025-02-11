using Decorator.Component;
using Decorator.Decorator;

namespace Decorator.ConcreteDecorators
{
    public class RaspberriesDecorator : OatmealDecorator
    {
        public RaspberriesDecorator(Oatmeal oatmeal) : base(oatmeal)
        {
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 3.00;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " with Raspberries";
        }
    }
}