namespace AbstractFactory.Belgium
{
    /// <summary>
    /// ConcreteProduct
    /// </summary>
    public class BelgiumShippingCostService : IShippingCostService
    {
        public decimal ShippingCosts => 20;
    }
}
