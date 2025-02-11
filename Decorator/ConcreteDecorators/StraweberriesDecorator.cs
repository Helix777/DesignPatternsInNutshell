using Decorator.Component;
using Decorator.Decorator;

namespace Decorator.ConcreteDecorators
{
    public class StraweberriesDecorator : OatmealDecorator
    {
        public StraweberriesDecorator(Oatmeal oatmeal) : base(oatmeal)
        {
        }

        public override double CalculateCost()
        {
            return _oatmeal.CalculateCost() + 2.50;
        }

        public override string GetDescription()
        {
            return _oatmeal.GetDescription() + " with Straweberries";
        }
    }
}