using Decorator.Component;

namespace Decorator.ConcreteComponents
{
    public class SmallOatmeal : Oatmeal
    {
        public override double CalculateCost()
        {
            return 2.00;
        }

        public override string GetDescription()
        {
            return "Small Oatmeal for toddler";
        }
    }
}