using Menu.DecoratorPattern;

namespace Menu.Coffee
{
    public class Espresso : Beverage
    {
        private double _cost;
        
        public Espresso(double cost)
        {
            Description = "Espresso";

            _cost = cost;
        }
        
        public override double Cost()
        {
            //1.99
            return _cost;
        }
    }
}