using Decorator.Component;

namespace Decorator.ConcreteComponents
{
    public class HugeOatmeal : Oatmeal
    {
        public override double CalculateCost()
        {
            return 16.00;
        }

        public override string GetDescription()
        {
            return "Huge Oatmeal for adult men";
        }
    }
}