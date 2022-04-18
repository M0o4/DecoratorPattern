using Menu.DecoratorPattern;

namespace Menu.Coffee
{
    public class Decaf : Beverage
    {
        private double _cost;
        
        public Decaf(double cost)
        {
            Description = "Decaf";

            _cost = cost;
        }
        
        public override double Cost()
        {
            //1.05
            return _cost;
        }
    }
}