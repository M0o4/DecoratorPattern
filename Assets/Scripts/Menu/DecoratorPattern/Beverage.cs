namespace Menu.DecoratorPattern
{
    public abstract class Beverage
    {
        public string Description
        {
            get => _description;
            set => _description = value;
        }
        
        private string _description;

        public abstract double Cost();
    }
}
