using Decorator.Component;
using Decorator.Decorator;

namespace Decorator.ConcreteDecorators
{
    public class BananaDecorator : OatmealDecorator
    {
        public BananaDecorator(Oatmeal oatmeal) : base(oatmeal)
        {
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 0.50;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " with Banana";
        }
    }
}