using Menu.DecoratorPattern;

namespace Menu.Coffee
{
    public class DarkRoast : Beverage
    {
        private double _cost;
        
        public DarkRoast(int cost)
        {
            Description = "Dark Roast";

            _cost = cost;
        }
        
        public override double Cost()
        {
            //0.99
            return _cost;
        }
    }
}