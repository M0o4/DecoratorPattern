using Menu.DecoratorPattern;

namespace Menu.Coffee
{
    public class HouseBlend : Beverage
    {
        private double _cost;
        
        public HouseBlend(double cost)
        {
            Description = "House Blend";

            _cost = cost;
        }
        
        public override double Cost()
        {
            //0.89
            return _cost;
        }
    }
}