using Decorator.Component;

namespace Decorator.Decorator
{
    public class OatmealDecorator : Oatmeal
    {
        protected Oatmeal _oatmeal;

        public OatmealDecorator(Oatmeal oatmeal)
        {
            _oatmeal = oatmeal;
        }

        public override double CalculateCost()
        {
            return _oatmeal.CalculateCost();
        }

        public override string GetDescription()
        {
            return _oatmeal.GetDescription();
        }
    }
}