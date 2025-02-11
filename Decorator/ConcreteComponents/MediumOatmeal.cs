using Decorator.Component;

namespace Decorator.ConcreteComponents
{
    public class MediumOatmeal : Oatmeal
    {
        public override double CalculateCost()
        {
            return 12.00;
        }

        public override string GetDescription()
        {
            return "Medium Oatmeal for a child";
        }
    }
}