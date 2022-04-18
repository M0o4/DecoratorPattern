namespace Menu.DecoratorPattern
{
    public abstract class CondimentDecorator : Beverage
    {
        public new abstract string GetDescription();
    }
}