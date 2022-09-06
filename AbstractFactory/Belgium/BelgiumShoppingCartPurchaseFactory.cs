namespace AbstractFactory.Belgium
{
    /// <summary>
    /// ConcreteFactory
    /// </summary>
    public class BelgiumShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
    {
        public IDiscountService CreateDiscountService()
        {
            return new BelgiumDiscountService();
        }

        public IShippingCostService CreateShippingCostService()
        {
            return new BelgiumShippingCostService();
        }
    }
}
