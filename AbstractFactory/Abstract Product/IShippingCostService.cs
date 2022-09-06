namespace AbstractFactory
{
    /// <summary>
    /// AbstractProduct
    /// </summary>
    public interface IShippingCostService
    {
        decimal ShippingCosts { get; }
    }
}