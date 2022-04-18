using Menu.DecoratorPattern;

namespace Menu.Condiment
{
    public class Soy : CondimentDecorator
    {
        private Beverage _beverage;

        private double _cost;
        
        public Soy(Beverage beverage, double cost)
        {
            _beverage = beverage;

            _cost = cost;
        }
        
        public override string GetDescription()
        {
            return _beverage.Description + ", Soy";
        }

        public override double Cost()
        {
            //0.15
            return _cost + _beverage.Cost();
        }
    }
}