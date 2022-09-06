namespace AbstractFactory
{
    /// <summary>
    /// AbstractFactory
    /// </summary>
    public interface IShoppingCartPurchaseFactory
    {
        IDiscountService CreateDiscountService();
        IShippingCostService CreateShippingCostService();
    }
}