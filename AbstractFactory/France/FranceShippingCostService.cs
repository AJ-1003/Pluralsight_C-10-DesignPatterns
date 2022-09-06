namespace AbstractFactory.France
{
    /// <summary>
    /// ConcreteProduct
    /// </summary>
    public class FranceShippingCostService : IShippingCostService
    {
        public decimal ShippingCosts => 25;
    }
}
