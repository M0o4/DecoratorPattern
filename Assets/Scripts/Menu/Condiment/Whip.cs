using Menu.DecoratorPattern;

namespace Menu.Condiment
{
    public class Whip : CondimentDecorator
    {
        private Beverage _beverage;

        private double _cost;
        
        public Whip(Beverage beverage, double cost)
        {
            _beverage = beverage;

            _cost = cost;
        }
        
        public override string GetDescription()
        {
            return _beverage.Description + ", Mocha";
        }

        public override double Cost()
        {
            //0.20
            return _cost + _beverage.Cost();
        }
    }
}